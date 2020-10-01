using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RewardAssured
{
    public partial class FrmProgramParameterSub : Form
    {
        public object ReturnValue { get; set; }
        int mlevel;
        string mPercentageStr;
        double mTotalPercent;
        public FrmProgramParameterSub(string PercentageStr, int level,double dTotalPercent)
        {
            InitializeComponent();
            mlevel = level;
            mPercentageStr = PercentageStr;
            mTotalPercent = dTotalPercent;
        }

        private void FrmProgramParameterSub_Load(object sender, EventArgs e)
        {
            string tempvar;

            MyModules.applyGridTheme(dGrid);
            dGrid.Columns[0].Width = 50;
            dGrid.Columns[1].Width = 60;

            for (int h = 1; h <= mlevel; h = h + 1)
            {
                dGrid.Rows.Add();
                dGrid[0, dGrid.Rows.Count - 1].Value = h;
                int g = mPercentageStr.IndexOf(",");
                if (g>0)
                {
                    tempvar = MyModules.GetIt4Me(mPercentageStr, ",");
                    dGrid[1, dGrid.Rows.Count - 1].Value = tempvar;
                    mPercentageStr = MyModules.Mid(mPercentageStr, g + 1, -1);
                }
                else
                {
                    dGrid[1, dGrid.Rows.Count - 1].Value = mPercentageStr;
                }
               
                
              
            }
            
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            string TheStr = "";

            double sum = 0;
            for (int j = 0; j < dGrid.Rows.Count; j++)
            {
                sum = sum + Convert.ToDouble(dGrid[1, j].Value);
            }

            if (sum != mTotalPercent)
            {
                MessageBox.Show("A difference of ("+ Math.Abs(sum-mTotalPercent).ToString() + ") Exist!!! Percentage does not add up", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            for (int i = 0; i < dGrid.RowCount; i++)
            {
                var tempVar = ((TheStr == "") ? "" : ",");
                TheStr = TheStr + tempVar + dGrid[1, i].Value.ToString();
             

            }
            this.ReturnValue = TheStr;
            this.DialogResult = DialogResult.OK;
        }
    }
}
