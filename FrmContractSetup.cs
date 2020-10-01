using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RewardAssured
{
    public partial class FrmContractSetup : Form
    {
        public FrmContractSetup()
        {
            InitializeComponent();
        }

        private void FrmBank_Load(object sender, EventArgs e)
        {
            oLoadCategory();
            oLoad();
            PanCommands.Enabled = MyModules.GetUserAccessDetails("Add/Modify Contract Setup", false);
        }

        private void oLoad()
        {
            try
            {
                SqlConnection cnSQL = new SqlConnection(MyModules.strConnect);
                SqlCommand cmSQL = new SqlCommand();
                cmSQL.Connection = cnSQL;
                SqlDataReader drSQL = null;

                lvList.Items.Clear();

                cmSQL.CommandText = "SELECT RefNo, [Title],[EvaluationYear] ,[Lot],[Category] FROM [ContractSetup] ORDER BY [EvaluationYear] ";


                cnSQL.Open();
                drSQL = cmSQL.ExecuteReader();
                long j = 0;
                string initialText = null;
                while (drSQL.Read())
                {
                    j += 1;
                    initialText = drSQL["RefNo"].ToString();

                    ListViewItem LvItems = new ListViewItem(initialText);

                    LvItems.SubItems.Add(drSQL["EvaluationYear"].ToString());
                    LvItems.SubItems.Add(drSQL["Lot"].ToString());
                    LvItems.SubItems.Add(drSQL["Title"].ToString());
                    LvItems.SubItems.Add(drSQL["Category"].ToString());

                    lvList.Items.AddRange(new ListViewItem[] { LvItems });
                }
                //cmSQL.Connection.Close()
                cmSQL.Dispose();
                drSQL.Close();
                cnSQL.Close();
                cnSQL.Dispose();

                lblCount.Text = j.ToString();

                return;

            }
            catch
            {
                //goto errhdl;
            }

        }

        private void oLoadCategory()
        {
            try
            {
                SqlConnection cnSQL = new SqlConnection(MyModules.strConnect);
                SqlCommand cmSQL = new SqlCommand();
                cmSQL.Connection = cnSQL;
                SqlDataReader drSQL = null;

                cCateory.Items.Clear();

                cmSQL.CommandText = "SELECT DISTINCT [Category] FROM [ContractSetup] ORDER BY [Category] ";


                cnSQL.Open();
                drSQL = cmSQL.ExecuteReader();
                while (drSQL.Read())
                {
                    cCateory.Items.Add(drSQL["Category"].ToString());
                }
                //cmSQL.Connection.Close()
                cmSQL.Dispose();
                drSQL.Close();
                cnSQL.Close();
                cnSQL.Dispose();

                return;

            }
            catch
            {
                //goto errhdl;
            }

        }

        private void CmdCut_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnSQL = new SqlConnection(MyModules.strConnect);
                SqlCommand cmSQL = new SqlCommand();
                cmSQL.Connection = cnSQL;

                tTitle.Tag = Convert.ToInt16(lvList.SelectedItems[0].Text);
                numYear.Value =Convert.ToInt16(lvList.SelectedItems[0].SubItems[1].Text);
                tLot.Text = lvList.SelectedItems[0].SubItems[2].Text;
                tTitle.Text = lvList.SelectedItems[0].SubItems[3].Text;
                cCateory.Text = lvList.SelectedItems[0].SubItems[4].Text;

                if (MessageBox.Show("The selected record would be deleted completely" + "\r" + "Continue (y/n)", "DELETE RECORD", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cnSQL.Open();
                    cmSQL.CommandText = "DeleteContractSetup";
                    cmSQL.CommandType = CommandType.StoredProcedure;
                    cmSQL.Parameters.AddWithValue("@RefNo", tTitle.Tag);
                    cmSQL.ExecuteNonQuery();

                    cmSQL.Dispose();
                    cnSQL.Close();
                    oLoad();
                    tTitle.Text = "";
                    tTitle.Tag = "";
                }
            }
            catch
            {
                MessageBox.Show(Microsoft.VisualBasic.Information.Err().Description, MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
       

        }

        private void CmdOpen_Click(object sender, EventArgs e)
        {
            tTitle.Tag = Convert.ToInt16(lvList.SelectedItems[0].Text);
            numYear.Value = Convert.ToInt16(lvList.SelectedItems[0].SubItems[1].Text);
            tLot.Text = lvList.SelectedItems[0].SubItems[2].Text;
            tTitle.Text = lvList.SelectedItems[0].SubItems[3].Text;
            cCateory.Text = lvList.SelectedItems[0].SubItems[4].Text;
        }

        private void CmdInsert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnSQL = new SqlConnection(MyModules.strConnect);
                SqlCommand cmSQL = new SqlCommand();
                cmSQL.Connection = cnSQL;

                if (string.IsNullOrEmpty(tTitle.Text.Trim(' ')) || string.IsNullOrEmpty(tLot.Text.Trim(' ')))
                {
                    MessageBox.Show("Incomplete data", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                cnSQL.Open();

                System.Data.SqlClient.SqlTransaction myTrans = null;
                if (string.IsNullOrEmpty(Convert.ToString(tTitle.Tag).Trim(' ')))
                {
                    cmSQL.CommandText = "InsertContractSetup";
                    cmSQL.CommandType = CommandType.StoredProcedure;
                    cmSQL.Parameters.AddWithValue("@EvaluationYear", numYear.Text);
                    cmSQL.Parameters.AddWithValue("@Title", tTitle.Text);
                    cmSQL.Parameters.AddWithValue("@Category", cCateory.Text);
                    cmSQL.Parameters.AddWithValue("@Lot",tLot.Text);
                    
                    cmSQL.ExecuteNonQuery();
                }
                else
                {

                    myTrans = cnSQL.BeginTransaction();
                    cmSQL.Transaction = myTrans;

                    cmSQL.Parameters.Clear();
                    cmSQL.CommandText = "DeleteContractSetup";
                    cmSQL.CommandType = CommandType.StoredProcedure;
                    cmSQL.Parameters.AddWithValue("@RefNo", tTitle.Tag);
                    cmSQL.ExecuteNonQuery();

                    cmSQL.Parameters.Clear();
                    cmSQL.CommandText = "InsertContractSetup";
                    cmSQL.CommandType = CommandType.StoredProcedure;
                    cmSQL.Parameters.AddWithValue("@EvaluationYear", numYear.Text);
                    cmSQL.Parameters.AddWithValue("@Title", tTitle.Text);
                    cmSQL.Parameters.AddWithValue("@Category", cCateory.Text);
                    cmSQL.Parameters.AddWithValue("@Lot", tLot.Text);

                    cmSQL.ExecuteNonQuery();

                    myTrans.Commit();
                }
                cmSQL.Dispose();
                cnSQL.Close();
                oLoad();

                tTitle.Text = "";
                tTitle.Tag = "";

            }

            catch (Exception ex)
            {
                if (Microsoft.VisualBasic.Information.Err().Number == 5)
                {
                    MessageBox.Show("Pls. selected an entry to Edit", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(ex.Message.ToString(), MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
