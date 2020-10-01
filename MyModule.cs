using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing;
namespace RewardAssured
{

    public enum AppAction
    {
        Add = 1,
        Edit = 2,
        Delete = 3,
        Browse = 4,
        Authorise = 5,
        Open = 6
    }
    public static class MyModules
    {
        //A property
        public static string sysUser { get; set; }
        public static string sysOwner { get; set; }
        public static string strConnect { get; set; }
        public static string strApptitle { get; set; }
        public static string sysUserName { get; set; }


        public static string AppPath { get; set; }
        public static string ConfigFile { get; set; }
        public static int PyramidLevel { get; set; } = 0;
        public static double PyramidPercent { get; set; } = 0;
        public static double PercentDrawable { get; set; } = 0;
        
        public static string ServerName;
        public static string Password;
        public static string UserID;
        public static Boolean IntegratedSecurity;
        public static string AttachName;
        public static string sysPwd;
        public static string eDocFilePath;
        public static string BackupPath;

        public static byte[] UserLogo = null;

        public static List<string> SomeListOfStuff { get; set; }
        //Init your variables in here:

      

        static MyModules()
        {
            sysUser = "";
            // sysOwner = "Megahit Systems, Abuja";
            sysOwner = "IKANI SALON";

            strApptitle = "RewardAssured";
            sysUserName = "";

            AppPath = AppDomain.CurrentDomain.BaseDirectory.Length <= 3 ? AppDomain.CurrentDomain.BaseDirectory : AppDomain.CurrentDomain.BaseDirectory + "\\";
            AppPath = "C:\\Applications\\RewardAssured\\";
            ConfigFile =  AppPath + "ConfigDir\\Config.gif";

            IntegratedSecurity = false;

           InitialiseEntireSystem();
         //   MessageBox.Show(strConnect);

        }

        public static void InitialiseEntireSystem()
        {
            try
            {

                if (System.IO.File.Exists(MyModules.ConfigFile))

                {

                    System.IO.StreamReader objReader = new System.IO.StreamReader(MyModules.ConfigFile); //, true, System.Text.Encoding.UTF8);


                    MyModules.ServerName = objReader.ReadLine();
                    MyModules.AttachName = objReader.ReadLine();
                    MyModules.IntegratedSecurity = Convert.ToBoolean(objReader.ReadLine());
                    MyModules.UserID = objReader.ReadLine();
                    MyModules.Password = objReader.ReadLine();
                    MyModules.sysOwner = objReader.ReadLine();
                    objReader.Close();

                }
                else
                {
                    MessageBox.Show("Invalid Configuration Parameter" + "\r" + "System Halted", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Environment.Exit(0);
                }
              
                if (MyModules.IntegratedSecurity == false)
                {
                    //strConnect = "Data Source=tcp:" & ServerName & ";Initial Catalog=" & AttachName & ";Persist Security Info=True;User ID=" & UserID & ";Password=" & Password
                    MyModules.strConnect = "SERVER=" + MyModules.ServerName + ";Initial Catalog=" + MyModules.AttachName + ";Persist Security Info=True;Connection Timeout=90;User ID=" + MyModules.UserID + ";Password=" + MyModules.Password;
                    //Connection Timeout=0 ' indefinite
                }
                else
                {
                    MyModules.strConnect = "SERVER=" + MyModules.ServerName + ";Initial Catalog=" + MyModules.AttachName + ";Integrated Security=True;Connection Timeout=90";
                }

                //"Provider=SQLOLEDB;Data Source=(local);User ID=sa;Initial Catalog=ApexSuite

              
             fetchTheSystemParameters();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);


            }



        }


        private static void fetchTheSystemParameters()
        {
            try
            {

               SqlConnection cnSQL = new SqlConnection(MyModules.strConnect);
                SqlCommand cmSQL = new SqlCommand("FetchAllSystemParameters", cnSQL);
                SqlDataReader drSQL;
              
                cnSQL.Open();

                cmSQL.CommandText = "FetchAllSystemParameters";
                cmSQL.CommandType = System.Data.CommandType.StoredProcedure;
                drSQL = cmSQL.ExecuteReader();
                if (drSQL.HasRows == false)
                {
                    MessageBox.Show("Invalid System parameter", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Environment.Exit(1);
                }
                else
                {
                    if (drSQL.Read())
                    {
                       eDocFilePath = drSQL["eDocPath"].ToString();
                       BackupPath = drSQL["BackupPath"].ToString();
                       PyramidLevel =Convert.ToInt16( drSQL["PyramidLevel"]);
                       PyramidPercent =Convert.ToDouble( drSQL["TotalPyramidPercent"]);
                        PercentDrawable = Convert.ToDouble(drSQL["PercentDrawable"]);
                        if (Convert.IsDBNull(drSQL["Logo"]) == false)
                            UserLogo = (byte[])drSQL["Logo"];
                    }
                }


                //cmSQL.Connection.Close()
                cmSQL.Dispose();
                drSQL.Close();
                cnSQL.Close();
                //cnSQL.Dispose()
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static string FormatDouble(object TheStr)
        {
            string tempFormatDouble = "0";
            try

            {
             
                double tempD = Convert.ToDouble(TheStr);
                //return Convert.ToDouble(TheStr, System.Globalization.CultureInfo.InvariantCulture);
                tempFormatDouble =tempD.ToString("##,#.##");
                if (tempFormatDouble == "")
                    tempFormatDouble = "0";
                return tempFormatDouble;


            }
            catch
            {
                return tempFormatDouble;
            }

        }
        public static string Left(string param, int length)
        {
            string result = param.Substring(0, length);
            return result;
        }
        public static string Right(string param, int length)
        {
            string result = param.Substring(param.Length - length, length);
            return result;
        }
        public static string Mid(string param, int startIndex, int length)
        {
            string result;
            if (length == -1)
            {
                result = param.Substring(startIndex);
            }
            else
            {
                result = param.Substring(startIndex, length);
            }
            return result;
        }
        public static string GetIt4Me(string TheStr, string LocStr)
        {
            string tempGetIt4Me = null;
            try
            {
                tempGetIt4Me = "";
                if (string.IsNullOrEmpty(TheStr) || string.IsNullOrEmpty(LocStr))
                {
                    return tempGetIt4Me;
                }
                tempGetIt4Me = TheStr;
                int TheLen = TheStr.IndexOf(LocStr) + 1; //InStr(Trim(TheStr), LocStr) -----REMOVING TRIM
                if (TheLen != 0) // Trim(Mid$(Trim(TheStr), 1, TheLen - 1))
                {
                    tempGetIt4Me = TheStr.Substring(0, TheLen - 1);
                }
                return tempGetIt4Me;
            }
            catch
            {
                return "";
            }
        }


        public static bool GetUserAccessDetails(string dModule, bool DisplayMsg = true) 
        {
            try
            {
               if (sysUser.ToUpper() == "ADMIN")
                {
                    return true;
                }
                bool tempGetUserAccessDetails = false;
                SqlConnection cnSQL = new SqlConnection(MyModules.strConnect);
                SqlCommand cmSQL = new SqlCommand("FetchUserModuleAccess", cnSQL);
                SqlDataReader drSQL = null;

                cnSQL.Open();

                cmSQL.CommandText = "FetchUserModuleAccess";
                cmSQL.CommandType = System.Data.CommandType.StoredProcedure;
                cmSQL.Parameters.AddWithValue("@UserID", sysUser);
                cmSQL.Parameters.AddWithValue("@Module", dModule);
                drSQL = cmSQL.ExecuteReader();
                if (drSQL.HasRows == false)
                {
                }
                else
                {
                    if (drSQL.Read())
                        tempGetUserAccessDetails = true;
                }
                cmSQL.Dispose();
                drSQL.Close();
                cnSQL.Close();
                if (tempGetUserAccessDetails == false && DisplayMsg == true)
                {
                    MessageBox.Show("Access is denied to the " + char.ConvertFromUtf32(13) + dModule.ToUpper() + " module", strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return tempGetUserAccessDetails;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ooops! ERROR :" + char.ConvertFromUtf32(13) + ex, MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        public static DialogResult InputBox(string title, string promptText, ref string value, bool pwdchar)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            if (pwdchar == true)
            {
                textBox.PasswordChar = '*';

            }
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new System.Drawing.Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new System.Drawing.Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }


        public static void formatGrid(DataGridView DGrid1)
        {
          DataGridViewCellStyle myStyle1 = new DataGridViewCellStyle();
            myStyle1.Format = "N2";
            myStyle1.Alignment = DataGridViewContentAlignment.BottomRight;

            for (var i = 0; i < DGrid1.ColumnCount; i++)
            {
                if (DGrid1.Columns[i].ValueType.FullName == "System.Decimal")
                {
                    DGrid1.Columns[i].DefaultCellStyle = myStyle1;
                }
            }
        }

        public static void applyGridTheme(DataGridView grid)
        {

            bool hSize = false;

            System.Windows.Forms.DataGridViewCellStyle dateCellStyle = new System.Windows.Forms.DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight };
            System.Windows.Forms.DataGridViewCellStyle amountCellStyle = new System.Windows.Forms.DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleRight,
                Format = "N2"
            };
            System.Windows.Forms.DataGridViewCellStyle gridCellStyle = new System.Windows.Forms.DataGridViewCellStyle
            {
                Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft,
                BackColor = Color.AntiqueWhite,
                Font = new System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0)),
                ForeColor = Color.Black,
                SelectionBackColor = System.Drawing.SystemColors.Highlight,
                SelectionForeColor = System.Drawing.SystemColors.HighlightText,
                WrapMode = System.Windows.Forms.DataGridViewTriState.True
            };
            System.Windows.Forms.DataGridViewCellStyle gridCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle
            {
                Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft,
                BackColor = Color.FloralWhite,
                Font = new System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0)),
                ForeColor = Color.Black,
                SelectionBackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(155)), Convert.ToInt32(Convert.ToByte(187)), Convert.ToInt32(Convert.ToByte(89))),
                SelectionForeColor = System.Drawing.SystemColors.HighlightText,
                WrapMode = System.Windows.Forms.DataGridViewTriState.False
            };
            System.Windows.Forms.DataGridViewCellStyle gridCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle
            {
                Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft,
                BackColor = Color.AntiqueWhite,
                Font = new System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0)),
                ForeColor = Color.Black,
                SelectionBackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(155)), Convert.ToInt32(Convert.ToByte(187)), Convert.ToInt32(Convert.ToByte(89))),
                SelectionForeColor = System.Drawing.SystemColors.HighlightText,
                WrapMode = System.Windows.Forms.DataGridViewTriState.True
            };


            //grid.TopLeftHeaderCell.Value = "NO ";
            //grid.TopLeftHeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //grid.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders);
            // dgv.RowHeadersDefaultCellStyle.BackColor = HeaderTheme
            foreach (DataGridViewColumn cCol in grid.Columns)
            {

                if (cCol.ValueType == null)
                {

                }
                else
                {

                    if (cCol.ValueType.ToString() == typeof(DateTime).ToString())
                    {
                        cCol.DefaultCellStyle = dateCellStyle;
                    }
                    else if (cCol.ValueType.ToString() == typeof(decimal).ToString() || cCol.ValueType.ToString() == typeof(double).ToString())
                    {
                        cCol.DefaultCellStyle = amountCellStyle;
                    }
                }
            }
            if (hSize)
            {
                grid.RowHeadersWidth = grid.RowHeadersWidth + 16;
            }
            grid.AutoResizeColumns();

            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.BackgroundColor = Color.FloralWhite;
            grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            grid.ColumnHeadersDefaultCellStyle = gridCellStyle;
            grid.ColumnHeadersHeight = 32;
            grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.DefaultCellStyle = gridCellStyle2;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            grid.DefaultCellStyle.BackColor = Color.FloralWhite;

            grid.EnableHeadersVisualStyles = false;
            grid.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            grid.ReadOnly = false;
            grid.RowHeadersVisible = true;
            grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            grid.RowHeadersDefaultCellStyle = gridCellStyle3;
            grid.Font = gridCellStyle.Font;
           
        }

      

    }


}



