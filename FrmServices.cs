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
    public partial class FrmServices : Form
    {
        AppAction Action;
        string ClientOutline;
        public FrmServices()
        {
            InitializeComponent();
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



        private void cmdOk_Click(object sender, EventArgs e)
        {
            try
            {

                //if (lblAction.Text == "New Record")
                //{
                //    tCode1.Text = FetchNextNo();
                //}

                if (string.IsNullOrEmpty(tRefNo.Text.Trim(' ')) || string.IsNullOrEmpty(tClientsDetails.Text.Trim(' ')) || string.IsNullOrEmpty(tServiceDetails.Text.Trim(' ')) || string.IsNullOrEmpty(tServiceValue.Text.Trim(' ')) || string.IsNullOrEmpty(tAmountPaid.Text.Trim(' ')) || string.IsNullOrEmpty(tReward.Text.Trim(' ')))
                {
                    MessageBox.Show("Incomplete relevant data", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;

                }

                if (Convert.ToDouble(tServiceValue.Text) != Convert.ToDouble(tAmountPaid.Text) + Convert.ToDouble(tReward.Text))
                {
                    MessageBox.Show("Amount Payable do not correspond with actual payment ", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
                if (Convert.ToDouble(tReward.Text) > Convert.ToDouble(tRewardBalance.Text))
                {
                    MessageBox.Show("Drawal on Reward more than available !!!", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }

                if (Convert.ToDouble(tReward.Text) > Convert.ToDouble(tRewardBalance.Text) * (MyModules.PercentDrawable / 100))
                {
                    MessageBox.Show("Reward overdrawn !!!", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }

                SqlConnection cnSQL = new SqlConnection(MyModules.strConnect);
                SqlCommand cmSQL = new SqlCommand();
                cmSQL.Connection = cnSQL;
                cnSQL.Open();

                System.Data.SqlClient.SqlTransaction myTrans = cnSQL.BeginTransaction();
                cmSQL.Transaction = myTrans;

                // Dim drSQL As SqlDataReader

                if (Action == AppAction.Add)
                {
                    FetchNextNo();

                    string Telephone = MyModules.GetIt4Me(tClientsDetails.Text, " (");
                    cmSQL.Parameters.Clear();
                    cmSQL.CommandText = "InsertServices";
                    cmSQL.CommandType = CommandType.StoredProcedure;
                    cmSQL.Parameters.AddWithValue("@Sn", tTransNo.Text);
                    cmSQL.Parameters.AddWithValue("@TransDate", dtpDate.Text);
                    cmSQL.Parameters.AddWithValue("@RefNo", tRefNo.Text);
                    cmSQL.Parameters.AddWithValue("@Name", tClientsDetails.Text.ToString().Substring(Telephone.Length + 2, tClientsDetails.Text.ToString().Length - Telephone.Length-3));
                    cmSQL.Parameters.AddWithValue("@Telephone", Telephone);
                    cmSQL.Parameters.AddWithValue("@ServiceRendered", tServiceDetails.Text);
                    cmSQL.Parameters.AddWithValue("@ValueOfService", Convert.ToDouble(tServiceValue.Text));
                    cmSQL.Parameters.AddWithValue("@AmountPaid", Convert.ToDouble(tAmountPaid.Text));
                    cmSQL.Parameters.AddWithValue("@AmountChargedFromReward", Convert.ToDouble(tReward.Text));
                    cmSQL.Parameters.AddWithValue("@Username", MyModules.sysUserName);

                    cmSQL.ExecuteNonQuery();


                    for (int t = 0; t <= lvList.Items.Count - 1; t++)
                    {
                        cmSQL.Parameters.Clear();
                        cmSQL.CommandText = "InsertRewards";
                        cmSQL.Parameters.AddWithValue("@SourceRefNo", tTransNo.Text);
                        cmSQL.Parameters.AddWithValue("@ClientRefNo", lvList.Items[t].Text);
                        cmSQL.Parameters.AddWithValue("@Reward", lvList.Items[t].SubItems[3].Text);
                        cmSQL.Parameters.AddWithValue("@RewardPercent", lvList.Items[t].SubItems[2].Text);
                        cmSQL.Parameters.AddWithValue("@ClientDetails", lvList.Items[t].SubItems[4].Text);
                        cmSQL.Parameters.AddWithValue("@CourtesyRefNo", tRefNo.Text);
                        cmSQL.Parameters.AddWithValue("@CourtesyClientDetails", tClientsDetails.Text.ToString());
                        cmSQL.ExecuteNonQuery();
                    }

                }

                if (Action == AppAction.Edit)
                {
                    cmSQL.Parameters.Clear();

                    cmSQL.CommandText = "DeleteServices";
                    cmSQL.CommandType = CommandType.StoredProcedure;
                    cmSQL.Parameters.AddWithValue("@Sn", tTransNo.Text);
                    cmSQL.ExecuteNonQuery();

                    cmSQL.Parameters.Clear();
                    cmSQL.CommandText = "DeleteRewards";
                    cmSQL.CommandType = CommandType.StoredProcedure;
                    cmSQL.Parameters.AddWithValue("@SourceRefNo", tTransNo.Text);
                    cmSQL.ExecuteNonQuery();

                    //cmSQL.Parameters.Clear();
                    //cmSQL.CommandText = "DeleteSales";
                    //cmSQL.CommandType = CommandType.StoredProcedure;
                    //cmSQL.Parameters.AddWithValue("@OrderNo", tTransNo.Text);
                    //cmSQL.ExecuteNonQuery();

                    string Telephone = MyModules.GetIt4Me(tClientsDetails.Text, " (");
                    cmSQL.Parameters.Clear();
                    cmSQL.CommandText = "InsertServices";
                    cmSQL.CommandType = CommandType.StoredProcedure;
                    cmSQL.Parameters.AddWithValue("@Sn", tTransNo.Text);
                    cmSQL.Parameters.AddWithValue("@TransDate", dtpDate.Text);
                    cmSQL.Parameters.AddWithValue("@RefNo", tRefNo.Text);
                    cmSQL.Parameters.AddWithValue("@Name", tClientsDetails.Text.ToString().Substring(Telephone.Length + 2, tClientsDetails.Text.ToString().Length - Telephone.Length - 3));
                    cmSQL.Parameters.AddWithValue("@Telephone", Telephone);
                    cmSQL.Parameters.AddWithValue("@ServiceRendered", tServiceDetails.Text);
                    cmSQL.Parameters.AddWithValue("@ValueOfService", Convert.ToDouble(tServiceValue.Text));
                    cmSQL.Parameters.AddWithValue("@AmountPaid", Convert.ToDouble(tAmountPaid.Text));
                    cmSQL.Parameters.AddWithValue("@AmountChargedFromReward", Convert.ToDouble(tReward.Text));
                    cmSQL.Parameters.AddWithValue("@Username", MyModules.sysUserName);

                    cmSQL.ExecuteNonQuery();

                    for (int t = 0; t <= lvList.Items.Count - 1; t++)
                    {
                        cmSQL.Parameters.Clear();
                        cmSQL.CommandText = "InsertRewards";
                        cmSQL.Parameters.AddWithValue("@SourceRefNo", tTransNo.Text);
                        cmSQL.Parameters.AddWithValue("@ClientRefNo", lvList.Items[t].Text);
                        cmSQL.Parameters.AddWithValue("@Reward", lvList.Items[t].SubItems[3].Text);
                        cmSQL.Parameters.AddWithValue("@RewardPercent", lvList.Items[t].SubItems[2].Text);
                        cmSQL.Parameters.AddWithValue("@ClientDetails", lvList.Items[t].SubItems[4].Text);
                        cmSQL.Parameters.AddWithValue("@CourtesyRefNo", tRefNo.Text);
                        cmSQL.Parameters.AddWithValue("@CourtesyClientDetails", tClientsDetails.Text.ToString());
                        cmSQL.ExecuteNonQuery();
                    }
                }

                if (Action == AppAction.Delete)
                {


                    if (MessageBox.Show("The selected record would be Deleted Parmanently....Continue(y/n)?", MyModules.strApptitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                    {
                        return;
                    }

                    cmSQL.Parameters.Clear();
                    cmSQL.CommandText = "DeleteServices";
                    cmSQL.CommandType = CommandType.StoredProcedure;
                    cmSQL.Parameters.AddWithValue("@Sn", tTransNo.Text);
                    cmSQL.ExecuteNonQuery();

                    cmSQL.Parameters.Clear();
                    cmSQL.CommandText = "DeleteRewards";
                    cmSQL.CommandType = CommandType.StoredProcedure;
                    cmSQL.Parameters.AddWithValue("@SourceRefNo", tTransNo.Text);
                    cmSQL.ExecuteNonQuery();

                    cmSQL.Parameters.Clear();
                    cmSQL.CommandText = "DeleteSales";
                    cmSQL.CommandType = CommandType.StoredProcedure;
                    cmSQL.Parameters.AddWithValue("@OrderNo", tTransNo.Text);
                    cmSQL.ExecuteNonQuery();

                    try {
                        cmSQL.Parameters.Clear();
                        cmSQL.CommandText = "Delete FROM SalonFinance WHERE EnteredBy='" + tTransNo.Text + "'";
                        cmSQL.CommandType = CommandType.Text;
                        cmSQL.ExecuteNonQuery();
                    }
                    catch
                    {
                       
                    }
                }

                myTrans.Commit();

                cmSQL.Connection.Close();
                cmSQL.Dispose();
                cnSQL.Close();
                cnSQL.Dispose();

                mnuNew_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Flush()
        {
            tTransNo.Text = "";
            tRefNo.Text = "";
            tClientsDetails.Text = "";
            tServiceDetails.Text = "";
            tServiceValue.Text = "0";
            tAmountPaid.Text = "0";
            tReward.Text = "0";
            tRewardBalance.Text = "0";
            ClientOutline = "";
            lvList.Items.Clear();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdClient_Click(object sender, EventArgs e)
        {

            using (var form = new FrmList("Clients", "List of Clients"))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    tRefNo.Text = form.ReturnValue.ToString();
                    tClientsDetails.Text = form.ReturnValue1.ToString() + " (" + form.ReturnValue2.ToString() +")";
                    ClientOutline = form.ReturnValue3.ToString();

                    GetSubLevel(tRefNo.Text);
                    tRewardBalance.Text= MyModules.FormatDouble(GetClientReward(tRefNo.Text));
                    tServiceValue_TextChanged(sender, e);
                }

            }
        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {
            Action = AppAction.Edit;
            InitialiseAction();
            using (var form = new FrmList("Services", "List of Services"))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadService(Convert.ToInt16(form.ReturnValue));
                }

            }
        }

        private void GetSubLevel(string ClientRef)
        {
            try
            {

               string d1 = null;
                lvList.Items.Clear();
                string initialText = null;
                string dRealOutline = MyModules.GetIt4Me(ClientOutline.ToString(), ClientRef); 

                dRealOutline = Reverse(dRealOutline);

                int theIndex = CountCharacter(dRealOutline, Convert.ToChar("@"));
                if (theIndex == 1) return;
                if (theIndex-1 > MyModules.PyramidLevel) theIndex = MyModules.PyramidLevel+1;
                int pIndex = theIndex - 1;
                    for (int s = 1; s <= theIndex - 1; s++)
                    //for (int s = theIndex - 1; s >= 1; s--)
                    {
                
                    d1 = dRealOutline.Substring(1, dRealOutline.Substring(1).IndexOf("@"));
                    dRealOutline = dRealOutline.Substring(d1.Length + 1);

                    initialText = Reverse(d1.ToString());

                    ListViewItem LvItems = new ListViewItem(initialText);

            
                    //LvItems.SubItems.Add(s.ToString());
                    LvItems.SubItems.Add(pIndex.ToString());
                    LvItems.SubItems.Add(0.ToString());
                    LvItems.SubItems.Add("");
                    LvItems.SubItems.Add("");

                    lvList.Items.AddRange(new ListViewItem[] { LvItems });
                    pIndex = pIndex - 1;

                }

                string tempPyramidLevelPercent = GetPyramidLevelPercent(lvList.Items.Count);

                //tempPyramidLevelPercent = Reverse(tempPyramidLevelPercent);

               theIndex = CountCharacter(tempPyramidLevelPercent, Convert.ToChar(","));
                if (theIndex < 1)
                {
                    lvList.Items[0].SubItems[2].Text = tempPyramidLevelPercent;
                }
                if (theIndex+1 > MyModules.PyramidLevel) theIndex = MyModules.PyramidLevel;
                //for (int s = 1; s <= theIndex + 1; s++)
                    for (int s = theIndex + 1; s >= 1; s--)
                    {

                    d1 = MyModules.GetIt4Me(tempPyramidLevelPercent, ","); //.Substring(1, tempPyramidLevelPercent.Substring(1).IndexOf(","));
                    if (CountCharacter(tempPyramidLevelPercent, Convert.ToChar(",")) > 0)
                    {
                        tempPyramidLevelPercent = tempPyramidLevelPercent.Substring(d1.Length + 1); 
                    }
                    else
                    {
                        tempPyramidLevelPercent = "";
                    }
                    lvList.Items[s-1].SubItems[2].Text = d1;
 }

                for (int t=0;t<=lvList.Items.Count-1; t++)
                {
                    lvList.Items[t].SubItems[4].Text = GetClientDetails(lvList.Items[t].Text);
                }
                
            }
            catch (Exception ex)
            {
        
                MessageBox.Show(ex.Message, MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        public static string Reverse(string s)
        {
            //char[] charArray = s.ToCharArray();
            //Array.Reverse(charArray);
            //return new string(charArray);
            return new string(s.Reverse().ToArray());
        }

        public int CountCharacter(string value, char ch)
        {
            int cnt = 0;
            foreach (char c in value)
            {
                if (c == ch)
                {
                    cnt += 1;
                }
            }
            return cnt;
        }

        private void mnuBrowse_Click(object sender, EventArgs e)
        {
            Action = AppAction.Browse;
            InitialiseAction();
            using (var form = new FrmList("Services", "List of Services"))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadService(Convert.ToInt32(form.ReturnValue));
                }

            }
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            Action = AppAction.Delete;
            InitialiseAction();
            using (var form = new FrmList("Services", "List of Services"))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
              
                    LoadService(Convert.ToInt32(form.ReturnValue));
         
                }

            }
        }

        public void LoadService(int strCode)
        {
            try
            {


                SqlConnection cnSQL = new SqlConnection(MyModules.strConnect);
                SqlCommand cmSQL = new SqlCommand();
                cmSQL.Connection = cnSQL;
                cnSQL.Open();
                SqlDataReader drSQL = null;
                Flush();
                string dReward = "0";
                cmSQL.CommandText = "SELECT Services.*, Register.Outline FROM Services INNER JOIN Register ON Services.RefNo = Register.Code WHERE Sn=" + strCode ;
                cmSQL.CommandType = CommandType.Text;
                drSQL = cmSQL.ExecuteReader();
                while (drSQL.Read())
                {
                     tTransNo.Text= drSQL["Sn"].ToString();
                    dtpDate.Text = drSQL["TransDate"].ToString();
                    tRefNo.Text=drSQL["RefNo"].ToString();
                    tClientsDetails.Text = drSQL["Telephone"].ToString() + " ("+ drSQL["Name"].ToString()+")";
                    tServiceDetails.Text=drSQL["ServiceRendered"].ToString();
                    tServiceValue.Text = MyModules.FormatDouble(drSQL["ValueOfService"]); 
                    tAmountPaid.Text = MyModules.FormatDouble(drSQL["AmountPaid"]);
                    dReward = MyModules.FormatDouble(drSQL["AmountChargedFromReward"]);
                   ClientOutline = drSQL["Outline"].ToString();
                }

                tRewardBalance.Text = MyModules.FormatDouble(GetClientReward(tRefNo.Text) + Convert.ToDouble(dReward));
                tReward.Text = Convert.ToDouble(dReward).ToString();
            
                drSQL.Close();

                cnSQL.Close();

                GetSubLevel(tRefNo.Text);
                
           
                double dValue = 0;
                for (int t = 0; t <= lvList.Items.Count - 1; t++)
                {
                    dValue = Convert.ToDouble(tServiceValue.Text) * (Convert.ToDouble(lvList.Items[t].SubItems[2].Text) / 100);
                    lvList.Items[t].SubItems[3].Text = MyModules.FormatDouble(dValue);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public  string GetClientDetails(string strCode)
        {
            try
            {

                string tempGetClientDetails = "";
              
                SqlConnection cnSQL = new SqlConnection(MyModules.strConnect);
                SqlCommand cmSQL = new SqlCommand();
                cmSQL.Connection = cnSQL;
                cnSQL.Open();
                SqlDataReader drSQL = null;
               
                cmSQL.CommandText = "SELECT * FROM Register WHERE Code='" + strCode +"'";
                cmSQL.CommandType = CommandType.Text;
                drSQL = cmSQL.ExecuteReader();
                while (drSQL.Read())
                {

                    tempGetClientDetails = drSQL["Telephone"].ToString() + " (" + drSQL["Name"].ToString()+")";
                    

                }

                drSQL.Close();
                cnSQL.Close();

                return tempGetClientDetails;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }

        }
        public double GetClientReward(string strCode)
        {
            try
            {

                double tempGetClientReward = 0;

                SqlConnection cnSQL = new SqlConnection(MyModules.strConnect);
                SqlCommand cmSQL = new SqlCommand();
                cmSQL.Connection = cnSQL;
                cnSQL.Open();
                SqlDataReader drSQL = null;

                cmSQL.CommandText = "SELECT * FROM RewardBalances WHERE ClientRefNo='" + strCode + "'";
                cmSQL.CommandType = CommandType.Text;
                drSQL = cmSQL.ExecuteReader();
                while (drSQL.Read())
                {

                    tempGetClientReward =Convert.ToDouble( drSQL["RewardBalance"]);


                }

                drSQL.Close();
                cnSQL.Close();

                return tempGetClientReward;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

        }

        private void FrmServices_Load(object sender, EventArgs e)
        {
            mnuNew_Click(sender, e);
        }

        private void FetchNextNo()
        {
            
            try
            {
                SqlConnection cnSQL = new SqlConnection(MyModules.strConnect);
                SqlCommand cmSQL = new SqlCommand();
                cmSQL.Connection = cnSQL;
                cnSQL.Open();
                SqlDataReader drSQL = null;

                cmSQL.CommandText = "SELECT ISNULL(MAX(Sn),0)+1 AS NewNo FROM Services";
                cmSQL.CommandType = CommandType.Text;
                drSQL = cmSQL.ExecuteReader();
                if (drSQL.HasRows)
                {
                    if (drSQL.Read())
                    {
                        tTransNo.Text = drSQL["NewNo"].ToString();
                    }
                }
                else
                {
                    tTransNo.Text = "0";

                }
                cmSQL.Connection.Close();
                cmSQL.Dispose();
                cnSQL.Close();
                cnSQL.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tServiceValue_TextChanged(object sender, EventArgs e)
        {
            try {
                double dValue = 0;
                for (int t = 0; t <= lvList.Items.Count - 1; t++)
                {
                    dValue = Convert.ToDouble(tServiceValue.Text) * (Convert.ToDouble(lvList.Items[t].SubItems[2].Text) / 100);
                    lvList.Items[t].SubItems[3].Text = MyModules.FormatDouble(dValue);
                }
            }
            catch
            {

            }
        }

        private void tAmountPaid_TextChanged(object sender, EventArgs e)
        {

        }

        private void tReward_TextChanged(object sender, EventArgs e)
        {
            if (tRewardBalance.Text == "") tRewardBalance.Text = "0";
            if (tReward.Text == "")tReward.Text = "0";
            if (Convert.ToDouble(tReward.Text) > Convert.ToDouble(tRewardBalance.Text))
            {
                MessageBox.Show("Exceeds Available Reward", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                tReward.Text = "0";
            }

            tAmountPaid.Text = MyModules.FormatDouble(Convert.ToDouble(tServiceValue.Text) - Convert.ToDouble(tReward.Text));
        }

        private void tServiceValue_Leave(object sender, EventArgs e)
        {
            tServiceValue.Text=MyModules.FormatDouble(tServiceValue.Text);
            tReward.Text = "0";
            tAmountPaid.Text = "0";
        }

        private void tAmountPaid_Leave(object sender, EventArgs e)
        {
            tAmountPaid.Text = MyModules.FormatDouble(tAmountPaid.Text);
        }

        private void tReward_Leave(object sender, EventArgs e)
        {
            tReward.Text = MyModules.FormatDouble(tReward.Text);
        }

        public string GetPyramidLevelPercent(int strCurrentLevel)
        {


            try
            {
               string  tempPyramidLevelPercent = "";


                SqlConnection cnSQL = new SqlConnection(MyModules.strConnect);
                SqlCommand cmSQL = new SqlCommand();
                cmSQL.Connection = cnSQL;
                SqlDataReader drSQL;

                cnSQL.Open();

                cmSQL.CommandText = "SELECT PyramidPercent FROM PyramidScale WHERE PyramidLevel=" + strCurrentLevel;
                cmSQL.CommandType = System.Data.CommandType.Text;
                drSQL = cmSQL.ExecuteReader();
                if (drSQL.HasRows == false)
                {
                    MessageBox.Show("Pls Setup Pyramid Scale", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tempPyramidLevelPercent = "";
                }
                else
                {
                    if (drSQL.Read())
                    {

                        tempPyramidLevelPercent = drSQL["PyramidPercent"].ToString();

                    }
                }


                //cmSQL.Connection.Close()
                cmSQL.Dispose();
                drSQL.Close();
                cnSQL.Close();
                //cnSQL.Dispose()
                return tempPyramidLevelPercent;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return "";
            }

        }
    }
}
