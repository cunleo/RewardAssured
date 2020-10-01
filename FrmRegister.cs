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
    public partial class FrmRegister : Form
    {
        AppAction Action;

        private BindingSource BindingSource1 = new BindingSource();
        public FrmRegister(string Action, int ReturnCode = 0)
        {
            InitializeComponent();
        }
        private void FrmRegister_Load(object sender, EventArgs e)
        {
            mnuNew.Enabled = MyModules.GetUserAccessDetails("Add New Contractor", false);
            mnuEdit.Enabled = MyModules.GetUserAccessDetails("Edit Contractor", false);
            mnuDelete.Enabled = MyModules.GetUserAccessDetails("Delete Contractor", false);
            mnuBrowse.Enabled = mnuEdit.Enabled || mnuDelete.Enabled;
            dataGridViewJobs.DataSource = BindingSource1;
          if (mnuNew.Enabled)  mnuNew_Click(sender, e);

            MyModules.applyGridTheme(dataGridViewJobs);

            dataGridViewJobs.ReadOnly = false;
            dataGridViewJobs.AllowUserToAddRows = true;
            dataGridViewJobs.AllowUserToDeleteRows = true;
            dataGridViewJobs.Columns[0].Visible = false;
            dataGridViewJobs.Columns[1].Width = 100;
            dataGridViewJobs.Columns[2].Width = 30;
            dataGridViewJobs.Columns[3].Visible = false;
            dataGridViewJobs.Columns[4].Width = 60;
            dataGridViewJobs.Columns[5].Width = 60;
            dataGridViewJobs.Columns[6].Width = 250;
            dataGridViewJobs.Columns[7].Width = 100;
            dataGridViewJobs.Columns[11].Width = 80;

            for (int i = 3; i < 8; i++) // dataGridViewJobs.Columns.Count - 1; i++)
            {
                dataGridViewJobs.Columns[i].ReadOnly = true;
            }
          



        }

        private void cmdGetFile_Click(object sender, EventArgs e)
        {
            if (MyModules.eDocFilePath == "")
            {
                MessageBox.Show("Please specify the path to save the eDocument" + char.ConvertFromUtf32(13) + "Using the Company Information menu", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                OpenFileDialog OpenFileDialog = new OpenFileDialog();
                OpenFileDialog.InitialDirectory = MyModules.eDocFilePath;
                OpenFileDialog.Filter = "PDF|*.pdf";
                OpenFileDialog.FilterIndex = 1;
                tFileName.Text = "";
                if (OpenFileDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    string FileName = OpenFileDialog.FileName;
                    tFileName.Text = FileName;
                }
            }

        }

        private void mnuNew_Click(object sender, EventArgs e)
        {

            Action = AppAction.Add;
            InitialiseAction();
        }


        private void InitialiseAction()
        {
             if (Action == AppAction.Add)
            {
                lblAction.Text = "New Record";
                cmdOk.Visible = true;
            }
             else if (Action == AppAction.Browse)
            {
                lblAction.Text = "Browse Record";
                cmdOk.Visible = false;
            }
             else if (Action == AppAction.Edit)
            {
                lblAction.Text = "Edit Record";
                cmdOk.Visible = true;
            }
            else if (Action == AppAction.Delete)
            {
                lblAction.Text = "Delete Record";
                cmdOk.Visible = true;
            }
            else if (Action == AppAction.Authorise)
            {
                lblAction.Text = "Authorise Record";
            }
            Flush();
        }


        private void Flush()
        {
            
        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {
            Action = AppAction.Edit;
            InitialiseAction();
        }

        private void mnuBrowse_Click(object sender, EventArgs e)
        {
            Action = AppAction.Browse;
            InitialiseAction();
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            Action = AppAction.Delete;
            InitialiseAction();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            //System.Data.SqlClient.SqlTransaction myTrans; //= new SqlTransaction;
            //try
            //{
            //    SqlConnection cnSQL = new SqlConnection(MyModules.strConnect);
            //    SqlCommand cmSQL = new SqlCommand(); // cnSQL.CreateCommand;
            //    cmSQL.Connection = cnSQL;


            //    // SqlDataReader drSQL = null;
            //    // string NewMandateNo = "";

            //    if (string.IsNullOrEmpty(tMandateNo.Text.Trim(' ')))
            //    {
            //        MessageBox.Show("Pls. enter Mandate No", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        return;
            //    }

            //    if (CheckPayments(tMandateNo.Text) == true)
            //    {
            //        if (MessageBox.Show("Records already exist for this Mandate No...Continue (y/n)?" + "\r" + "\n" + "If you choose to Continue, the previous would be overwritten", MyModules.strApptitle, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
            //        {
            //            return;
            //        }
            //    }


            //    int i = 0;

            //    if (DGridList.Rows.Count > 0)
            //    {
            //        for (i = 0; i < DGridList.Rows.Count; i++)
            //        {
            //            if (string.IsNullOrEmpty(DGridList["Bank1", i].Value.ToString().Trim(' ')))
            //            {
            //                MessageBox.Show("Bank not specified", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                return;
            //            }
            //            if (string.IsNullOrEmpty(DGridList["Account", i].Value.ToString().Trim(' ')))
            //            {
            //                MessageBox.Show("AccountNo not specified", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                return;
            //            }
            //        }
            //    }

            //    cnSQL.Open();

            //    myTrans = cnSQL.BeginTransaction(IsolationLevel.Serializable);
            //    cmSQL.Transaction = myTrans;

            //    cmSQL.Parameters.Clear();
            //    cmSQL.CommandText = "DeletePayment";
            //    cmSQL.CommandType = CommandType.StoredProcedure;
            //    cmSQL.Parameters.AddWithValue("@MandateNo", tMandateNo.Text);
            //    cmSQL.ExecuteNonQuery();

            //    int g = 0;
            //    for (i = 0; i < DGridList.Rows.Count; i++)
            //    {

            //        if (DGridList["Amount", i].Value == null || Convert.ToDouble(DGridList["Amount", i].Value) == 0)
            //        {
            //        }
            //        else
            //        {
            //            g = g + 1;
            //            cmSQL.Parameters.Clear();
            //            cmSQL.CommandText = "InsertPayment";
            //            cmSQL.CommandType = CommandType.StoredProcedure;
            //            cmSQL.Parameters.AddWithValue("@PayValueDate", MyModules.FormatDate(dtpDate.Value));
            //            cmSQL.Parameters.AddWithValue("@RefNo", ((DGridList["Sn", i].Value == null) ? "" : DGridList["Sn", i].Value));
            //            cmSQL.Parameters.AddWithValue("@Name", ((DGridList["tName", i].Value == null) ? "" : DGridList["tName", i].Value).ToString().ToUpper());
            //            cmSQL.Parameters.AddWithValue("@Address", ((DGridList["Address", i].Value == null) ? "" : DGridList["Address", i].Value).ToString().ToUpper());
            //            cmSQL.Parameters.AddWithValue("@BankName", ((DGridList["Bank1", i].Value == null) ? "" : DGridList["Bank1", i].Value).ToString().ToUpper());
            //            cmSQL.Parameters.AddWithValue("@BankAcctNo", ((DGridList["Account", i].Value == null) ? "" : DGridList["Account", i].Value).ToString().ToUpper());
            //            cmSQL.Parameters.AddWithValue("@BankCode", ((DGridList["BankCode", i].Value == null) ? "" : DGridList["BankCode", i].Value).ToString().ToUpper());
            //            cmSQL.Parameters.AddWithValue("@SchoolID", ((DGridList["SchoolID", i].Value == null) ? "" : DGridList["SchoolID", i].Value).ToString().ToUpper());
            //            cmSQL.Parameters.AddWithValue("@SchName", ((DGridList["SchName", i].Value == null) ? "" : DGridList["SchName", i].Value).ToString().ToUpper());
            //            cmSQL.Parameters.AddWithValue("@PayDetails", ((DGridList["PaymentDetails", i].Value == null) ? "" : DGridList["PaymentDetails", i].Value).ToString().ToUpper());
            //            cmSQL.Parameters.AddWithValue("@Source", ((DGridList["SchoolID", i].Value == null) ? "" : DGridList["Source", i].Value).ToString().ToUpper());
            //            cmSQL.Parameters.AddWithValue("@Remark", ((DGridList["Remark", i].Value == null) ? "" : DGridList["Remark", i].Value).ToString().ToUpper());
            //            cmSQL.Parameters.AddWithValue("@Amount", ((DGridList["Amount", i].Value == null) ? 0 : Convert.ToDouble(DGridList["Amount", i].Value)));
            //            cmSQL.Parameters.AddWithValue("@MandateNo", tMandateNo.Text.ToUpper());
            //            cmSQL.Parameters.AddWithValue("@PayType", ((DGridList["PayType1", i].Value == null) ? "" : DGridList["PayType1", i].Value).ToString().ToUpper());
            //            cmSQL.Parameters.AddWithValue("@dIndex", g);
            //            cmSQL.Parameters.AddWithValue("@Username", MyModules.sysUser);
            //            cmSQL.Parameters.AddWithValue("@MandateSn", Convert.ToInt16(tMandateNo.Tag));
            //            cmSQL.Parameters.AddWithValue("@MandatePrefix", " "); // dtpDate.Tag);


            //            cmSQL.ExecuteNonQuery();
            //        }
            //    }

            //    myTrans.Commit();

            //    cmSQL.Connection.Close();
            //    cmSQL.Dispose();
            //    cnSQL.Close();
            //    cnSQL.Dispose();

            //    if (g == 0)
            //    {
            //        MessageBox.Show("No Record Saved", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        return;
            //    }

            //    MessageBox.Show("Successful", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    DGVhasChanged = false;

            //    LastMandateNo = tMandateNo.Text;


            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    // myTrans.Rollback();
            //}
        }

        private void dataGridViewJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            dataGridViewJobs.Tag = e.RowIndex;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {

                if (senderGrid.Columns[e.ColumnIndex].Name == "JobCommand")
                {
                    using (var form = new FrmList("Contracts", "List of Contracts"))
                    {
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            FillContract(Convert.ToInt16(form.ReturnValue), e.RowIndex);
                        }
                    }

                }

            }
        }


        private void FillContract(int RefNo, int dRow)
        {
            try
            {

             

               SqlConnection cnSQL = new SqlConnection(MyModules.strConnect);
                SqlCommand cmSQL = new SqlCommand();
                cmSQL.Connection = cnSQL;
                SqlDataReader drSQL = null;

            
                cmSQL.CommandText = "SELECT RefNo, [Title],[EvaluationYear] ,[Lot],[Category] FROM [ContractSetup] WHERE RefNo=" + RefNo;


                cnSQL.Open();
                drSQL = cmSQL.ExecuteReader();
                if (drSQL.Read())
                {
                    dataGridViewJobs["JobRefNo", dRow].Value = drSQL["RefNo"].ToString();
                    dataGridViewJobs["Year", dRow].Value = drSQL["EvaluationYear"].ToString();
                    dataGridViewJobs["Lot", dRow].Value = drSQL["Lot"].ToString();
                    dataGridViewJobs["JobTitle", dRow].Value = drSQL["Title"].ToString();
                    dataGridViewJobs["JobCategory", dRow].Value = drSQL["Category"].ToString();
                }
                //cmSQL.Connection.Close()
                cmSQL.Dispose();
                drSQL.Close();
                cnSQL.Close();
                cnSQL.Dispose();

                return;

              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = chkSelectAll.Checked;
            checkBox2.Checked = chkSelectAll.Checked;
            checkBox3.Checked = chkSelectAll.Checked;
            checkBox3.Checked = chkSelectAll.Checked;
            checkBox4.Checked = chkSelectAll.Checked;
            checkBox5.Checked = chkSelectAll.Checked;
            checkBox6.Checked = chkSelectAll.Checked;
            checkBox7.Checked = chkSelectAll.Checked;
            checkBox8.Checked = chkSelectAll.Checked;
            checkBox9.Checked = chkSelectAll.Checked;
            checkBox10.Checked = chkSelectAll.Checked;
            checkBox11.Checked = chkSelectAll.Checked;

        }
    }
}
