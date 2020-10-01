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
    public partial class FrmEnrollment : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private long StoredX;
        private long StoredY;

        public FrmEnrollment()
        {
            InitializeComponent();
        }

        private void FrmEnrollment_Load(object sender, EventArgs e)
        {
            DGrid.AutoGenerateColumns = false;

            DGrid.DataSource = bindingSource;
            MyModules.applyGridTheme(DGrid);
            tPhone.Focus();
            LoadGrid();
          

        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            try
            {
                tCode.Text = FetchNextNo();
                if (string.IsNullOrEmpty(tCode.Text.Trim(' ')) || string.IsNullOrEmpty(tPhone.Text.Trim(' ')) || string.IsNullOrEmpty(tName.Text.Trim(' ')))
                {
                    MessageBox.Show("Incomplete relevant data", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                return;

                }

                string strDate = "";
                if (cboDay.Text=="" || cboMonth.Text=="" )
                {
                    strDate = "01-01-1900";
                }
                else
                {
                    strDate = cboDay.Text + "-" + cboMonth.Text + "-2020";   
                }


                //else
                //{
                //    MessageBox.Show("Invalid DOB entries", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                //    return;
                //}

                SqlConnection cnSQL = new SqlConnection(MyModules.strConnect);
                SqlCommand cmSQL = new SqlCommand();
                cmSQL.Connection = cnSQL;
                cnSQL.Open();

                cmSQL.Parameters.Clear();

                cmSQL.CommandText = "InsertRegister";
                cmSQL.CommandType = CommandType.StoredProcedure;
                cmSQL.Parameters.AddWithValue("@Code", tCode.Text);
                cmSQL.Parameters.AddWithValue("@Telephone", tPhone.Text);
                cmSQL.Parameters.AddWithValue("@Name", tName.Text);
                cmSQL.Parameters.AddWithValue("@Address", tAddress.Text);
                cmSQL.Parameters.AddWithValue("@Email", tEmail.Text);
                cmSQL.Parameters.AddWithValue("@IsHeader", 1);
                cmSQL.Parameters.AddWithValue("@Parent", "None");
                cmSQL.Parameters.AddWithValue("@Outline", "@" + tCode.Text + "@");
                cmSQL.Parameters.AddWithValue("@AutoID", Convert.ToInt16(tCode.Text));
                cmSQL.Parameters.AddWithValue("@Discontinue", chkDiscontinue.Checked);
                cmSQL.Parameters.AddWithValue("@DOB", strDate);
                cmSQL.Parameters.AddWithValue("@mLevel", 1);

                cmSQL.ExecuteNonQuery();

                cmSQL.Connection.Close();
                cmSQL.Dispose();
                cnSQL.Close();
                cnSQL.Dispose();

                //LoadGrid();

                 tCode.Text="";
                 tPhone.Text="";
                tName.Text="";
                tAddress.Text="";
                tEmail.Text="";
                chkDiscontinue.Checked=false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        public void LoadGrid()
        {
            try
            {
                SqlConnection cnSQL = new SqlConnection(MyModules.strConnect);
                SqlCommand cmSQL = new SqlCommand();
                cmSQL.Connection = cnSQL;
                cnSQL.Open();

                cmSQL.CommandType = CommandType.Text;
                cmSQL.CommandText = "SELECT * FROM Register ORDER BY outline"; // mLevel,Code";

                dataAdapter = new SqlDataAdapter(cmSQL);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(this.dataAdapter);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                this.dataAdapter.Fill(table);
                this.bindingSource.DataSource = table;

                cmSQL.Dispose();
                lblCount.Text = (DGrid.Rows.Count - 1).ToString();
                DGrid.Columns["mAdd"].Width = 35;
                DGrid.Columns["Edit"].Width = 35;
                DGrid.Columns["Delete"].Width = 35;
                DGrid.Columns["Phone"].Width = 80;
                DGrid.Columns["cName"].Width = 120;
                DGrid.Columns["Email"].Width =120;
                DGrid.Columns["Address"].Width = 100;
                DGrid.Columns["oParent"].Width = 50;
                DGrid.Columns["mLevel"].Width = 50;
                DGrid.Columns["AutoID"].Width = 5;
                DGrid.Columns["Outline"].Width = 5;
                DGrid.Columns["Discontinue"].Width = 80;
                DGrid.Columns["DOB"].Width = 80;

                LoadTV();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          }

        public void LoadTV()
        {
            try
            {

                SqlConnection cnSQL = new SqlConnection(MyModules.strConnect);
                SqlCommand cmSQL = new SqlCommand();
                cmSQL.Connection = cnSQL;
                cnSQL.Open();
             SqlDataReader drSQL = null;
                TVList.Nodes.Clear();

                cmSQL.CommandText = "SELECT * FROM Register  ORDER BY mLevel";
             cmSQL.CommandType = CommandType.Text;
                drSQL = cmSQL.ExecuteReader();
                while (drSQL.Read())
                {
                    TVList.BeginUpdate();
                    TVList.Nodes.Add(drSQL["Code"].ToString()+"a", drSQL["Code"].ToString() + " - " + drSQL["Telephone"].ToString()+ " ("+drSQL["Name"].ToString()+")");
                    TVList.EndUpdate();
                    loadChildren(drSQL["Outline"].ToString(), drSQL["Code"].ToString());

                }

                drSQL.Close();
              
                cnSQL.Close();
              //  TVList.ExpandAll();
                
            }
            catch (Exception ex)
            {
         MessageBox.Show(ex.Message,MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        
            }
     
        }
        private void loadChildren(string dOutline,string Code)
        {
            try
            {

                SqlConnection cnSQL1 = new SqlConnection(MyModules.strConnect);
                SqlCommand cmSQL1 = new SqlCommand();
                cmSQL1.Connection = cnSQL1;
                cnSQL1.Open();
                SqlDataReader drSQL1 = null;
                int H1 = 0;
              
                cmSQL1.CommandText = "SELECT * FROM Register WHERE outline like '%@" + Code + "%' AND Code<>'" + Code + "'  ORDER BY mLevel";

                cmSQL1.CommandType = CommandType.Text;
                drSQL1 = cmSQL1.ExecuteReader();
                string d1 = null;
                string d2 = null;
                string d3 = null;
                string d4 = null;
                string d5 = null;
                string d6 = null;
                string d7 = null;
                string d8 = null;
                string d9 = null;
                string d10 = null;
                string dRealOutline = "";
                while (drSQL1.Read())
                {
                    TVList.BeginUpdate();
                    if (MyModules.Left(drSQL1["Outline"].ToString(),Code.Length+1)=="@"+Code)
                    {
                        dRealOutline = drSQL1["Outline"].ToString();
                    }
                    else
                    {
                        dRealOutline = drSQL1["Outline"].ToString().Substring(MyModules.GetIt4Me( drSQL1["Outline"].ToString(), "@" + Code).Length);   // MyModules.Mid(drSQL1["Outline"].ToString(),;

                    }
                    //dRealOutline =MyModules.Mid(drSQL1["Outline"].ToString(), drSQL1["Outline"].ToString().Length,-1);
                   // dRealOutline =  drSQL1["Outline"].ToString().Substring(dOutline.Length-1); //drSQL1["Outline"].ToString(); //

                    //for (int i=1;i<CountCharacter(dRealOutline, Convert.ToChar("@")); i++)
                    //{
                    int theIndex = CountCharacter(dRealOutline, Convert.ToChar("@"));
                    //}
                    switch (theIndex)
                    {
                        case 2:
                          TVList.Nodes.Add(drSQL1["Code"].ToString()+"a", drSQL1["Code"].ToString() + " - " + drSQL1["Telephone"].ToString() + " (" + drSQL1["Name"].ToString() + ")");
                            break;
                        case 3:
                            if (MyModules.PyramidLevel < 1)
                            {
                            }
                            else
                            {
                                d1 = dRealOutline.Substring(1, dRealOutline.Substring(1).IndexOf("@"));
                                TVList.Nodes[d1 + "a"].Nodes.Add(drSQL1["Code"].ToString(), drSQL1["Code"].ToString() + " - " + drSQL1["Telephone"].ToString() + " (" + drSQL1["Name"].ToString() + ")");
                            }
                            break;
                        case 4:
                            if (MyModules.PyramidLevel < 2)
                            {
                             }
                            else
                            {
                                d1 = dRealOutline.Substring(1, dRealOutline.Substring(1).IndexOf("@"));
                                d2 = dRealOutline.Substring((d1.Length + 3) - 1, dRealOutline.Substring((d1.Length + 4) - 1).IndexOf("@") + 1);
                                TVList.Nodes[d1 + "a"].Nodes[d2].Nodes.Add(drSQL1["Code"].ToString(), drSQL1["Code"].ToString() + " - " + drSQL1["Telephone"].ToString() + " (" + drSQL1["Name"].ToString() + ")");
                            }
                            break;
                        case 5:
                            if (MyModules.PyramidLevel < 3)
                            {
                            }
                            else
                            {
                                d1 = dRealOutline.Substring(1, dRealOutline.Substring(1).IndexOf("@"));
                                d2 = dRealOutline.Substring((d1.Length + 3) - 1, dRealOutline.Substring((d1.Length + 4) - 1).IndexOf("@") + 1);
                                d3 = dRealOutline.Substring((d1.Length + d2.Length + 4) - 1, dRealOutline.Substring((d1.Length + d2.Length + 4) - 1).IndexOf("@"));
                                TVList.Nodes[d1 + "a"].Nodes[d2].Nodes[d3].Nodes.Add(drSQL1["Code"].ToString(), drSQL1["Code"].ToString() + " - " + drSQL1["Telephone"].ToString() + " (" + drSQL1["Name"].ToString() + ")");
                            }
                            break;
                        case 6:
                            if (MyModules.PyramidLevel < 4)
                            {
                            }
                            else
                            {
                                d1 = dRealOutline.Substring(1, dRealOutline.Substring(1).IndexOf("@"));
                                d2 = dRealOutline.Substring((d1.Length + 3) - 1, dRealOutline.Substring((d1.Length + 4) - 1).IndexOf("@") + 1);
                                d3 = dRealOutline.Substring((d1.Length + d2.Length + 4) - 1, dRealOutline.Substring((d1.Length + d2.Length + 4) - 1).IndexOf("@"));
                                d4 = dRealOutline.Substring((d1.Length + d2.Length + d3.Length + 5) - 1, dRealOutline.Substring((d1.Length + d2.Length + d3.Length + 5) - 1).IndexOf("@"));
                                TVList.Nodes[d1 + "a"].Nodes[d2].Nodes[d3].Nodes[d4].Nodes.Add(drSQL1["Code"].ToString(), drSQL1["Code"].ToString() + " - " + drSQL1["Telephone"].ToString() + " (" + drSQL1["Name"].ToString() + ")");
                            }

                            break;
                        case 7:
                            if (MyModules.PyramidLevel < 5)
                            {
                            }
                            else
                            {
                                d1 = dRealOutline.Substring(1, drSQL1["Outline"].ToString().Substring(1).IndexOf("@"));
                                d2 = dRealOutline.Substring((d1.Length + 3) - 1, dRealOutline.Substring((d1.Length + 4) - 1).IndexOf("@") + 1);
                                d3 = dRealOutline.Substring((d1.Length + d2.Length + 4) - 1, dRealOutline.Substring((d1.Length + d2.Length + 4) - 1).IndexOf("@"));
                                d4 = dRealOutline.Substring((d1.Length + d2.Length + d3.Length + 5) - 1, dRealOutline.Substring((d1.Length + d2.Length + d3.Length + 5) - 1).IndexOf("@"));
                                d5 = dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + 6) - 1, dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + 6) - 1).IndexOf("@"));
                                TVList.Nodes[d1 + "a"].Nodes[d2].Nodes[d3].Nodes[d4].Nodes[d5].Nodes.Add(drSQL1["Code"].ToString(), drSQL1["Code"].ToString() + " - " + drSQL1["Telephone"].ToString() + " (" + drSQL1["Name"].ToString() + ")");
                            }
                            break;
                        case 8:
                            if (MyModules.PyramidLevel < 6)
                            {
                            }
                            else
                            {
                                d1 = dRealOutline.Substring(1, drSQL1["Outline"].ToString().Substring(1).IndexOf("@"));
                                d2 = dRealOutline.Substring((d1.Length + 3) - 1, dRealOutline.Substring((d1.Length + 4) - 1).IndexOf("@") + 1);
                                d3 = dRealOutline.Substring((d1.Length + d2.Length + 4) - 1, dRealOutline.Substring((d1.Length + d2.Length + 4) - 1).IndexOf("@"));
                                d4 = dRealOutline.Substring((d1.Length + d2.Length + d3.Length + 5) - 1, dRealOutline.Substring((d1.Length + d2.Length + d3.Length + 5) - 1).IndexOf("@"));
                                d5 = dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + 6) - 1, dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + 6) - 1).IndexOf("@"));
                                d6 = dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + 7) - 1, dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + 7) - 1).IndexOf("@"));
                                TVList.Nodes[d1 + "a"].Nodes[d2].Nodes[d3].Nodes[d4].Nodes[d5].Nodes[d6].Nodes.Add(drSQL1["Code"].ToString(), drSQL1["Code"].ToString() + " - " + drSQL1["Telephone"].ToString() + " (" + drSQL1["Name"].ToString() + ")");
                            }
                            break;
                        case 9:
                            if (MyModules.PyramidLevel < 7)
                            {
                            }
                            else
                            {
                                d1 = dRealOutline.Substring(1, drSQL1["Outline"].ToString().Substring(1).IndexOf("@"));
                                d2 = dRealOutline.Substring((d1.Length + 3) - 1, dRealOutline.Substring((d1.Length + 4) - 1).IndexOf("@") + 1);
                                d3 = dRealOutline.Substring((d1.Length + d2.Length + 4) - 1, dRealOutline.Substring((d1.Length + d2.Length + 4) - 1).IndexOf("@"));
                                d4 = dRealOutline.Substring((d1.Length + d2.Length + d3.Length + 5) - 1, dRealOutline.Substring((d1.Length + d2.Length + d3.Length + 5) - 1).IndexOf("@"));
                                d5 = dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + 6) - 1, dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + 6) - 1).IndexOf("@"));
                                d6 = dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + 7) - 1, dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + 7) - 1).IndexOf("@"));
                                d7 = dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + d6.Length + 8) - 1, dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + d6.Length + 8) - 1).IndexOf("@"));
                                TVList.Nodes[d1 + "a"].Nodes[d2].Nodes[d3].Nodes[d4].Nodes[d5].Nodes[d6].Nodes[d7].Nodes.Add(drSQL1["Code"].ToString(), drSQL1["Code"].ToString() + " - " + drSQL1["Telephone"].ToString() + " (" + drSQL1["Name"].ToString() + ")");
                            }
                            break;
                        case 10:
                            if (MyModules.PyramidLevel < 8)
                            {
                            }
                            else
                            {
                                d1 = dRealOutline.Substring(1, drSQL1["Outline"].ToString().Substring(1).IndexOf("@"));
                                d2 = dRealOutline.Substring((d1.Length + 3) - 1, dRealOutline.Substring((d1.Length + 4) - 1).IndexOf("@") + 1);
                                d3 = dRealOutline.Substring((d1.Length + d2.Length + 4) - 1, dRealOutline.Substring((d1.Length + d2.Length + 4) - 1).IndexOf("@"));
                                d4 = dRealOutline.Substring((d1.Length + d2.Length + d3.Length + 5) - 1, dRealOutline.Substring((d1.Length + d2.Length + d3.Length + 5) - 1).IndexOf("@"));
                                d5 = dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + 6) - 1, dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + 6) - 1).IndexOf("@"));
                                d6 = dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + 7) - 1, dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + 7) - 1).IndexOf("@"));
                                d7 = dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + d6.Length + 8) - 1, dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + d6.Length + 8) - 1).IndexOf("@"));
                                d8 = dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + d6.Length + d7.Length + 9) - 1, dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + d6.Length + d7.Length + 9) - 1).IndexOf("@"));

                                TVList.Nodes[d1 + "a"].Nodes[d2].Nodes[d3].Nodes[d4].Nodes[d5].Nodes[d6].Nodes[d7].Nodes[d8].Nodes.Add(drSQL1["Code"].ToString(), drSQL1["Code"].ToString() + " - " + drSQL1["Telephone"].ToString() + " (" + drSQL1["Name"].ToString() + ")");
                            }
                            break;
                        case 11:
                            if (MyModules.PyramidLevel < 9)
                            {
                            }
                            else
                            {
                                d1 = dRealOutline.Substring(1, drSQL1["Outline"].ToString().Substring(1).IndexOf("@"));
                                d2 = dRealOutline.Substring((d1.Length + 3) - 1, dRealOutline.Substring((d1.Length + 4) - 1).IndexOf("@") + 1);
                                d3 = dRealOutline.Substring((d1.Length + d2.Length + 4) - 1, dRealOutline.Substring((d1.Length + d2.Length + 4) - 1).IndexOf("@"));
                                d4 = dRealOutline.Substring((d1.Length + d2.Length + d3.Length + 5) - 1, dRealOutline.Substring((d1.Length + d2.Length + d3.Length + 5) - 1).IndexOf("@"));
                                d5 = dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + 6) - 1, dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + 6) - 1).IndexOf("@"));
                                d6 = dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + 7) - 1, dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + 7) - 1).IndexOf("@"));
                                d7 = dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + d6.Length + 8) - 1, dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + d6.Length + 8) - 1).IndexOf("@"));
                                d8 = dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + d6.Length + d7.Length + 9) - 1, dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + d6.Length + d7.Length + 9) - 1).IndexOf("@"));
                                d9 = dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + d6.Length + d7.Length + d8.Length + 10) - 1, dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + d6.Length + d7.Length + d8.Length + 10) - 1).IndexOf("@"));

                                TVList.Nodes[d1 + "a"].Nodes[d2].Nodes[d3].Nodes[d4].Nodes[d5].Nodes[d6].Nodes[d7].Nodes[d8].Nodes[d9].Nodes.Add(drSQL1["Code"].ToString(), drSQL1["Code"].ToString() + " - " + drSQL1["Telephone"].ToString() + " (" + drSQL1["Name"].ToString() + ")");
                            }
                            break;
                        case 12:
                            if (MyModules.PyramidLevel < 10)
                            {
                            }
                            else
                            {
                                d1 = dRealOutline.Substring(1, drSQL1["Outline"].ToString().Substring(1).IndexOf("@"));
                                d2 = dRealOutline.Substring((d1.Length + 3) - 1, dRealOutline.Substring((d1.Length + 4) - 1).IndexOf("@") + 1);
                                d3 = dRealOutline.Substring((d1.Length + d2.Length + 4) - 1, dRealOutline.Substring((d1.Length + d2.Length + 4) - 1).IndexOf("@"));
                                d4 = dRealOutline.Substring((d1.Length + d2.Length + d3.Length + 5) - 1, dRealOutline.Substring((d1.Length + d2.Length + d3.Length + 5) - 1).IndexOf("@"));
                                d5 = dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + 6) - 1, dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + 6) - 1).IndexOf("@"));
                                d6 = dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + 7) - 1, dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + 7) - 1).IndexOf("@"));
                                d7 = dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + d6.Length + 8) - 1, dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + d6.Length + 8) - 1).IndexOf("@"));
                                d8 = dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + d6.Length + d7.Length + 9) - 1, dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + d6.Length + d7.Length + 9) - 1).IndexOf("@"));
                                d9 = dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + d6.Length + d7.Length + d8.Length + 10) - 1, dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + d6.Length + d7.Length + d8.Length + 10) - 1).IndexOf("@"));
                                d10 = dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + d6.Length + d7.Length + d8.Length + d9.Length + 10) - 1, dRealOutline.Substring((d1.Length + d2.Length + d3.Length + d4.Length + d5.Length + d6.Length + d7.Length + d8.Length + d9.Length + 10) - 1).IndexOf("@"));

                                TVList.Nodes[d1 + "a"].Nodes[d2].Nodes[d3].Nodes[d4].Nodes[d5].Nodes[d6].Nodes[d7].Nodes[d8].Nodes[d9].Nodes[d10].Nodes.Add(drSQL1["Code"].ToString(), drSQL1["Code"].ToString() + " - " + drSQL1["Telephone"].ToString() + " (" + drSQL1["Name"].ToString() + ")");
                            }
                            break;
                        default:
                            if (H1 == 0)
                            {
                                TVList.Nodes.Add("MORE12345", "More Than 10 Levels");
                                H1 = 1;
                            }
                            TVList.Nodes["MORE12345"].Nodes.Add(drSQL1["Code"].ToString(), drSQL1["Code"].ToString() + " - " + drSQL1["Telephone"].ToString() + " (" + drSQL1["Name"].ToString() + ")");
                            break;
                        
                    }
                    TVList.EndUpdate();
                }

                drSQL1.Close();
                cnSQL1.Close();
        
            }
            catch (Exception ex)
            {
                // if (Microsoft.VisualBasic.Information.Err().Number == 91)
                //{
                //     Microsoft.VisualBasic.Information.Err().Clear();

                //    TVList.Nodes.Add(drSQL["Code"].ToString(), drSQL["Code"].ToString() + " - " + drSQL["Telephone"].ToString() + "(" + drSQL["Name"].ToString() + ")");

                //}
                //else
                //{
                MessageBox.Show(ex.Message, MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

            }

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

        private string FetchNextNo()
        {
            string tempFetchNextNo = "";
            try
            {
                tempFetchNextNo = "";
                SqlConnection cnSQL = new SqlConnection(MyModules.strConnect);
                SqlCommand cmSQL = new SqlCommand();
                cmSQL.Connection = cnSQL;
                cnSQL.Open();
                SqlDataReader drSQL = null;


            
                cmSQL.CommandText = "FetchNewCode4Register";
                cmSQL.CommandType = CommandType.StoredProcedure;
               drSQL = cmSQL.ExecuteReader();
                if (drSQL.HasRows)
                {
                    if (drSQL.Read())
                    {
                        tempFetchNextNo = new string('0', 4 - ((string)(Convert.ToInt64(drSQL[0]).ToString())).Length) + Convert.ToInt64(drSQL[0]).ToString();
                    }
                }
                else
                {
                    tempFetchNextNo = "0001";

                }
                cmSQL.Connection.Close();
                cmSQL.Dispose();
                cnSQL.Close();
                cnSQL.Dispose();

                return tempFetchNextNo;
      
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tempFetchNextNo;
            }
      
        }

        private void lnkRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadGrid();
      
        }

        private void DGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {


                    lblParentName.Text = "";
                    lblParentName.Tag = "";
                    lblParent.Tag = "";
                    tCode1.Tag = "";
                    tCode1.Text = "";
                    tPhone1.Text = "";
                    tName1.Text = "";
                    tAddress1.Text = "";
                    tEmail1.Text = "";
                    cboDay1.Text = "";
                    cboMonth1.Text = "";

                    if (DGrid[e.ColumnIndex, e.RowIndex].Value.ToString() == "Add") //add
                    {

                        //Code, Description, Category, IsHeader, Parent, Outline, mlevel, AutoID

                        //if (DGrid.Item("Control", e.RowIndex).Value == false)
                        //{
                        //    MessageBox.Show("To Create Sub Account, Please Click on a Control Account", strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //    Panel4.Visible = false;
                        //    return;
                        //}
                        //else
                        {
                            Panel4.Visible = true;
                            lblAction.Text = "New Record";
                            lblParentName.Text = DGrid["Code", e.RowIndex].Value + " - " + DGrid["Phone", e.RowIndex].Value + "(" + DGrid["cName", e.RowIndex].Value + ")";
                            lblParentName.Tag = DGrid["Outline", e.RowIndex].Value;
                            lblParent.Tag = DGrid["mlevel", e.RowIndex].Value;
                            //tCode1.Text = DGrid["Code", e.RowIndex].Value;

                        }
                    }

                        //}
                        if (DGrid[e.ColumnIndex, e.RowIndex].Value.ToString() == "Edit")
                        {
                            Panel4.Visible = true;
                            lblAction.Text = "Edit Record";

                            lblParentName.Text = DGrid["oParent", e.RowIndex].Value.ToString(); //+ " - " + DGrid.Item("Description", e.RowIndex).Value
                            lblParentName.Tag = DGrid["Outline", e.RowIndex].Value;
                            lblParent.Tag = DGrid["mlevel", e.RowIndex].Value;
                            tCode1.Tag = DGrid["Code", e.RowIndex].Value;
                            tCode1.Text = DGrid["Code", e.RowIndex].Value.ToString();
                            tPhone1.Text = DGrid["Phone", e.RowIndex].Value.ToString();
                            tName1.Text = DGrid["cName", e.RowIndex].Value.ToString();
                            tAddress1.Text = DGrid["Address", e.RowIndex].Value.ToString();
                            tEmail1.Text = DGrid["Email", e.RowIndex].Value.ToString();
                            chkDiscontinue1.Checked =Convert.ToBoolean( DGrid["Discontinue", e.RowIndex].Value);

                        tCode1.Enabled = false;

                        String sDate = DGrid["DOB", e.RowIndex].Value.ToString();
                        DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));

                        String dy = datevalue.Day.ToString();
                        String mn = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(datevalue.Month); //datevalue.Month.ToString();
                        String yy = Convert.ToDateTime(sDate.ToString()).Year.ToString();   /*datevalue.Year.ToString();*/

                        if (yy == "1900")
                        {
                            cboDay1.Text = "";
                            cboMonth1.Text = "";
                        }
                        else
                        {
                            cboDay1.Text = dy;
                            cboMonth1.Text = mn;
                        }

                     
                        }

                        if (DGrid[e.ColumnIndex, e.RowIndex].Value.ToString() == "Del")
                        {

                        if (MessageBox.Show("The selected record would be Deleted Parmanently....Continue(y/n)?", MyModules.strApptitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                        {
                            return;
                        }

                        SqlConnection cnSQL = new SqlConnection(MyModules.strConnect);
                        SqlCommand cmSQL = new SqlCommand();
                        cmSQL.Connection = cnSQL;
                        cnSQL.Open();
                       
                            cmSQL.Parameters.Clear();

                            cmSQL.CommandText = "DeleteRegister";
                            cmSQL.CommandType = CommandType.StoredProcedure;
                            cmSQL.Parameters.AddWithValue("@Code", DGrid["Code", e.RowIndex].Value);
                            cmSQL.ExecuteNonQuery();

                            MessageBox.Show("Successfully", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmSQL.Connection.Close();
                            cmSQL.Dispose();
                            cnSQL.Close();
                            cnSQL.Dispose();

                            System.Windows.Forms.LinkLabelLinkClickedEventArgs e1 = null;

                            lnkRefresh_LinkClicked(sender, e1);

                        }
                    }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void cmdOk1_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (lblAction.Text == "New Record")
                {
                    tCode1.Text = FetchNextNo();
                }

                if (string.IsNullOrEmpty(tCode1.Text.Trim(' ')) || string.IsNullOrEmpty(tPhone1.Text.Trim(' ')) || string.IsNullOrEmpty(tName1.Text.Trim(' ')))
                {
                    MessageBox.Show("Incomplete relevant data", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;

                }

                SqlConnection cnSQL = new SqlConnection(MyModules.strConnect);
                SqlCommand cmSQL = new SqlCommand();
                cmSQL.Connection = cnSQL;
                cnSQL.Open();

                System.Data.SqlClient.SqlTransaction myTrans = cnSQL.BeginTransaction();
                cmSQL.Transaction = myTrans;

                // Dim drSQL As SqlDataReader

                string strDate = "";
                if (cboDay1.Text == "" || cboMonth1.Text == "")
                {
                    strDate = "01-01-1900";
                }
                else
                {
                    strDate = cboDay1.Text + "-" + cboMonth1.Text + "-2020";
                }


                if (lblAction.Text == "New Record")
                {

                cmSQL.Parameters.Clear();
                cmSQL.CommandText = "InsertRegister";
                cmSQL.CommandType = CommandType.StoredProcedure;
                cmSQL.Parameters.AddWithValue("@Code", tCode1.Text);
                cmSQL.Parameters.AddWithValue("@Telephone", tPhone1.Text);
                cmSQL.Parameters.AddWithValue("@Name", tName1.Text);
                cmSQL.Parameters.AddWithValue("@Address", tAddress1.Text);
                cmSQL.Parameters.AddWithValue("@Email", tEmail1.Text);
                cmSQL.Parameters.AddWithValue("@IsHeader", 0);
                cmSQL.Parameters.AddWithValue("@Parent",MyModules.GetIt4Me(lblParentName.Text, " - "));
                cmSQL.Parameters.AddWithValue("@Outline", lblParentName.Tag + tCode1.Text + "@");
                cmSQL.Parameters.AddWithValue("@mLevel", Convert.ToInt16((lblParent.Tag)) + 1);
                cmSQL.Parameters.AddWithValue("@AutoID",Convert.ToInt16( tCode1.Text));
                cmSQL.Parameters.AddWithValue("@Discontinue", chkDiscontinue1.Checked);
                cmSQL.Parameters.AddWithValue("@DOB", strDate);
                cmSQL.ExecuteNonQuery();

                }

                if (lblAction.Text == "Edit Record")
                {
                    cmSQL.Parameters.Clear();

                    cmSQL.CommandText = "DeleteRegister";
                    cmSQL.CommandType = CommandType.StoredProcedure;
                    cmSQL.Parameters.AddWithValue("@Code", tCode1.Text);
                    cmSQL.ExecuteNonQuery();

                    cmSQL.Parameters.Clear();

                    cmSQL.CommandText = "InsertRegister";
                    cmSQL.CommandType = CommandType.StoredProcedure;
                    cmSQL.Parameters.AddWithValue("@Code", tCode1.Text);
                    cmSQL.Parameters.AddWithValue("@Telephone", tPhone1.Text);
                    cmSQL.Parameters.AddWithValue("@Name", tName1.Text);
                    cmSQL.Parameters.AddWithValue("@Address", tAddress1.Text);
                    cmSQL.Parameters.AddWithValue("@Email", tEmail1.Text);
                    cmSQL.Parameters.AddWithValue("@IsHeader", 0);
                    cmSQL.Parameters.AddWithValue("@Parent", MyModules.GetIt4Me(lblParentName.Text, " - "));
                    cmSQL.Parameters.AddWithValue("@Outline", lblParentName.Tag);
                    cmSQL.Parameters.AddWithValue("@mLevel", Convert.ToInt16(lblParent.Tag));
                    cmSQL.Parameters.AddWithValue("@AutoID", Convert.ToInt16(tCode1.Text));
                    cmSQL.Parameters.AddWithValue("@Discontinue", chkDiscontinue1.Checked);
                    cmSQL.Parameters.AddWithValue("@DOB", strDate);
                    cmSQL.ExecuteNonQuery();

                }


                myTrans.Commit();

                cmSQL.Connection.Close();
                cmSQL.Dispose();
                cnSQL.Close();
                cnSQL.Dispose();

                Panel4.Visible = false;
                LoadGrid();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void cmdClose1_Click(object sender, EventArgs e)
        {
            Panel4.Visible = false;
        }

        private void Panel4_MouseDown(object sender, MouseEventArgs e)
        {
            StoredX = e.X;
            StoredY = e.Y;
            Panel4.Cursor = Cursors.NoMove2D;
        }

        private void Panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Panel4.Top =Convert.ToInt16(Panel4.Top) - (Convert.ToInt16(StoredY) - e.Y);
                Panel4.Left = Convert.ToInt16(Panel4.Left) - (Convert.ToInt16(StoredX) - e.X);
            }
            Panel4.Cursor = Cursors.Default;

        }

        private void TVList_AfterSelect(object sender, TreeViewEventArgs e)
        {
         
         //           MessageBox.Show(e.Node.Name.ToString(), MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lnkViewTV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lnkViewTV.Text== "Expand All")
            {
                lnkViewTV.Text = "Collapse All";
                TVList.ExpandAll();
            }
            else
            {
                lnkViewTV.Text = "Expand All";
               TVList.CollapseAll();
            }
        }
    }
}
