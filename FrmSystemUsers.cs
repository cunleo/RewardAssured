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
    public partial class FrmSystemUsers : Form
    {
        public string Action;
        public FrmSystemUsers()
        {
            InitializeComponent();
        }

        private void FrmSystemUsers_Load(object sender, EventArgs e)
        {
            Action = "New";
            InitialiseAction("New");

            ModuleDGV.ReadOnly = false;
            ModuleDGV.Columns["Modules"].ReadOnly = true;
            ModuleDGV.Rows.Add();
            ModuleDGV[0, 0].Value = "Client Enrollment";
            ModuleDGV[1, 0].Value = 0;
            ModuleDGV.Rows.Add();
            ModuleDGV[0, 1].Value = "Services and Payment";
            ModuleDGV[1, 1].Value = 0;
            ModuleDGV.Rows.Add();
            ModuleDGV[0, 2].Value = "Ledger";
            ModuleDGV[1, 2].Value = 0;
            ModuleDGV.Rows.Add();
            ModuleDGV[0, 3].Value = "Reward Scale and Setup";
            ModuleDGV[1, 3].Value = 0;
            ModuleDGV.Rows.Add();
            ModuleDGV[0, 4].Value = "Admin. Role";
            ModuleDGV[1, 4].Value = 0;


        }

        private void InitialiseAction(string Action)
        {
              if (Action == "New")
            {
              
                lblAction.Text = "New User";
                tUserName.Visible = true;
                cboUser.Visible = false;
                cboUser.Items.Clear();
                tUserName.Focus();
            }

            if (Action == "Delete")
            {
                lblAction.Text = "Delete User";
                cboUser.Enabled = true;
                LoadUser();
                tUserName.Visible = false;
                cboUser.Visible = true;
            }
            if (Action == "Edit")
            {
                lblAction.Text = "Edit User";
                 cboUser.Enabled = true;
                LoadUser();
                tUserName.Visible = false;
                cboUser.Visible = true;
            }
        }
        private void cmdOk_Click(object sender, EventArgs e)
        {

            try
            {

                SqlConnection cnSQL = new SqlConnection(MyModules.strConnect);
                SqlCommand cmSQL = new SqlCommand("FetchAllSystemParameters", cnSQL);

                string TheLevel = "";
                int i = 0;
                for (i = 0; i < ModuleDGV.RowCount; i++)
                {
                    if ( Convert.ToBoolean(ModuleDGV["Open", i].Value) == true)
                    {
                        TheLevel = TheLevel + (string.IsNullOrEmpty(TheLevel) ? "" : ",") + ModuleDGV["Modules", i].Value;
                    }

                }
                if (Action == "New")
                {
                    if (string.IsNullOrEmpty(tPwd.Text.Trim(' ')) || string.IsNullOrEmpty(tConfirmPwd.Text.Trim(' ')) || string.IsNullOrEmpty(tUserName.Text.Trim(' ')))
                    {
                        MessageBox.Show("Incomplete data", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (tPwd.Text != tConfirmPwd.Text)
                    {
                        MessageBox.Show("Inconsistent Password", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    cnSQL.Open();
                    cmSQL.CommandText = "InsertUserAccess";
                    cmSQL.CommandType = CommandType.StoredProcedure;
                    cmSQL.Parameters.AddWithValue("@UserID", tUserName.Text);
                    cmSQL.Parameters.AddWithValue("@UserPassword", tPwd.Text);
                    cmSQL.Parameters.AddWithValue("@Level", TheLevel);
                    cmSQL.ExecuteNonQuery();
                    cmSQL.Parameters.Clear();
                    MessageBox.Show("Successfull!", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tUserName.Text = "";
                    tPwd.Text = "";
                    tConfirmPwd.Text = "";
                    tUserName.Focus();
                    chkSelectAll.Checked = false;
                }
                if (Action == "Delete")
                {
                    if (cboUser.Text.Trim(' ').ToUpper() == "ADMIN")
                    {
                        MessageBox.Show("This User cannot be deleted", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (string.IsNullOrEmpty(cboUser.Text.Trim(' ')))
                    {
                        MessageBox.Show("Pls. specify user", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                        return;
                    }
                    if (MessageBox.Show("Do You Want To Delete This Record?", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.No)
                    {
                        return;
                    }
                    cnSQL.Open();
                    cmSQL.CommandText = "DELETE FROM UserAccess WHERE UserID='" + cboUser.Text + "'";
                    cmSQL.CommandType = CommandType.Text;
                    cmSQL.ExecuteNonQuery();
                    MessageBox.Show("Delete Successfull!", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                if (Action == "Edit")
                {

                    cnSQL.Open();
                   // cmSQL.CommandText = "UPDATE UserAccess SET [Level]='" + TheLevel + "' WHERE UserID='" + cboUser.Text + "'";
                    cmSQL.CommandText = "DELETE FROM UserAccess WHERE UserID='" + cboUser.Text + "'";
                    cmSQL.CommandType = CommandType.Text;
                    cmSQL.ExecuteNonQuery();

                    cmSQL.Parameters.Clear();
                    cmSQL.CommandText = "InsertUserAccess";
                    cmSQL.CommandType = CommandType.StoredProcedure;
                    cmSQL.Parameters.AddWithValue("@UserID", tUserName.Text);
                    cmSQL.Parameters.AddWithValue("@UserPassword", tPwd.Text);
                    cmSQL.Parameters.AddWithValue("@Level", TheLevel);
                    cmSQL.ExecuteNonQuery();

                    MessageBox.Show("Update Successfull!", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
                  catch (Exception ex)
            {
                 if (ex.ToString().Contains("Violation of PRIMARY KEY constraint"))
                       MessageBox.Show("User already exist", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                     MessageBox.Show("Ooops! ERROR :" + char.ConvertFromUtf32(13) + ex, MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        
        private void LoadUser()
        {
            try
            {
                SqlConnection cnSQL = new SqlConnection(MyModules.strConnect);
                SqlCommand cmSQL = new SqlCommand("", cnSQL);
                SqlDataReader drSQL = null;
                cboUser.Items.Clear();
                cmSQL.CommandText = "SELECT * FROM UserAccess";
                cmSQL.CommandType = CommandType.Text;
                cnSQL.Open();
                drSQL = cmSQL.ExecuteReader();
                while (drSQL.Read())
                {
                    if (drSQL["UserID"].ToString().ToUpper() != "ADMIN")
                    {
                        cboUser.Items.Add(drSQL["UserID"].ToString());
                    }
                }

                drSQL.Close();
                cmSQL.Dispose();
                cnSQL.Close();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ooops! ERROR :" + char.ConvertFromUtf32(13) + ex, MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            int i = 0;
            for (i = 0; i < ModuleDGV.RowCount; i++)
            {
                ModuleDGV.Rows[i].Cells[1].Value = chkSelectAll.Checked;
            }

        }

        private void cboUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string theTask = FillTask();

            for (var i = 0; i < ModuleDGV.RowCount; i++)
            {
               if (!String.IsNullOrEmpty(theTask) && theTask.Trim().Contains(ModuleDGV["Modules", i].Value.ToString()))
                   
                {
                        ModuleDGV.Rows[i].Cells["Open"].Value = true;
                }
                else
                {
                    ModuleDGV.Rows[i].Cells["Open"].Value = false;
                }

            }

        }

       private string FillTask()
        {
            
            try
                
            {
                string tempFillTask = "";
                SqlConnection cnSQL = new SqlConnection(MyModules.strConnect);
                SqlCommand cmSQL = new SqlCommand("FetchAllSystemParameters", cnSQL);
                SqlDataReader drSQL = null;
                 cmSQL.CommandText = "SELECT * FROM UserAccess WHERE UserID='" + cboUser.Text.ToString() + "'";
                cmSQL.CommandType = CommandType.Text;
                cnSQL.Open();
                drSQL = cmSQL.ExecuteReader();
                if (drSQL.HasRows == false)
                {
                   goto SkipIt;
                 
                }
                if (drSQL.Read())
                {
                    tempFillTask = drSQL["level"].ToString();
                    tPwd.Text = drSQL["UserPassword"].ToString();
                    tConfirmPwd.Text = drSQL["UserPassword"].ToString();

                }
               SkipIt:
                drSQL.Close();
                cmSQL.Dispose();
                cnSQL.Close();

               return  tempFillTask;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ooops! ERROR :" + char.ConvertFromUtf32(13) + ex, MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return "";
            }
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            Action = "New";
            InitialiseAction(Action);
        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {
            Action = "Edit";
            InitialiseAction(Action);
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            Action = "Delete";
            InitialiseAction(Action);
        }
    }
}
