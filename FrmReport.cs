using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace RewardAssured
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {

            ReportDocument RptFilename = new ReportDocument();

            string selformula = "";

            switch (lblReport.Text)
            {
                case "SALES by Staff":

                    RptFilename = new Reports.SalesByAgent(); //.Load(MyModules.AppPath + "ConfigDir\\Ledger.rpt");
                    selformula = " {RptSales.Date}>=#" + dtpStartDate.Text + "# AND {RptSales.Date}<=#" + dtpEndDate.Text + "#";
                    break;
                case "SALES per period":
                    RptFilename = new Reports.SalesList();
                    selformula = " {RptSalesParticulars.Date}>=#" + dtpStartDate.Text + "# AND {RptSalesParticulars.Date}<=#" + dtpEndDate.Text + "#";
                    break;

                case "SALES by service type":

                    RptFilename = new Reports.SalesByProduct();
                    selformula = " {RptSales.Date}>=#" + dtpStartDate.Text + "# AND {RptSales.Date}<=#" + dtpEndDate.Text + "#";
                    break;
                case "SALES by Client Patronage":
                    RptFilename = new Reports.SalesByClientPatronage();
                    selformula = " {RptServices.TransDate}>=#" + dtpStartDate.Text + "# AND {RptServices.TransDate}<=#" + dtpEndDate.Text + "#";
                    break;

                default:
                    MessageBox.Show("Please select a report item", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }


            FrmRptDisplay ChildForm = new FrmRptDisplay();
           if (selformula!="")  ChildForm.SelFormula = selformula;
            ChildForm.RptTitle = lblReport.Text;
            ChildForm.RptDestination = "Screen";
            ChildForm.myReportDocument = RptFilename;
            ChildForm.ShowDialog();

        }

        private void lvList_SelectedIndexChanged(object sender, EventArgs e)
           
        {
            try
            {
                lblReport.Text = lvList.SelectedItems[0].Text;
            }
         catch
            { }   
        }
    }
}
