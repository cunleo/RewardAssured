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
    public partial class FrmProgramParameter : Form
    {
        public FrmProgramParameter()
        {
            InitializeComponent();
        }

        private void FrmProgramParameter_Load(object sender, EventArgs e)
        {
            
            try
            {

                numPyramidLevel.Value = MyModules.PyramidLevel;
                numPercent.Value =Convert.ToDecimal( MyModules.PyramidPercent);
                numdrawable.Value = Convert.ToDecimal(MyModules.PercentDrawable);
                
                MyModules.applyGridTheme(dGrid);
                dGrid.Columns[0].Width = 80;
                dGrid.Columns[1].Width = 200;
                dGrid.Columns[2].Width = 30;
                FillPyramidScale();


            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message, MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void numPyramidLevel_ValueChanged(object sender, EventArgs e)
        {

            FillPyramidScale();
            if (numPyramidLevel.Value > dGrid.Rows.Count)
            {
                int d = Convert.ToInt16(numPyramidLevel.Value) - Convert.ToInt16(dGrid.Rows.Count);
                for (int h=1; h<=d; h=h+1)
                {
                    dGrid.Rows.Add();
                    dGrid[1, dGrid.Rows.Count-1].Value = 0;
                }
                for (int h = 0; h < dGrid.Rows.Count; h = h+1)
                {
                    dGrid[0,h].Value=h+1;
                    
                }
            }
            if (numPyramidLevel.Value < dGrid.Rows.Count)
            {
                int d =  Convert.ToInt16(dGrid.Rows.Count)-Convert.ToInt16(numPyramidLevel.Value);
                for (int h = 0; h >d; h = h + 1)
                {
                    dGrid.Rows.RemoveAt(h);
                }
            }

        }

        private void FillPyramidScale()
        {
            SqlConnection cnSQL = new SqlConnection(MyModules.strConnect);
            SqlCommand cmSQL = new SqlCommand();
            cmSQL.Connection = cnSQL;
            SqlDataReader drSQL;
            dGrid.Rows.Clear();
            cnSQL.Open();

            cmSQL.CommandText = "SELECT [PyramidLevel],[PyramidPercent]  FROM PyramidScale ORDER BY PyramidLevel";
            cmSQL.CommandType = CommandType.Text;
            drSQL = cmSQL.ExecuteReader();
            int i = 0;
            while (drSQL.Read())
            {
                if (i+1>numPyramidLevel.Value)
                {
                    goto errh;
                }
                dGrid.Rows.Add();
                dGrid[0, i].Value = drSQL["PyramidLevel"];
                dGrid[1, i].Value = drSQL["PyramidPercent"];
                i = i + 1;
            }
errh:
            //cmSQL.Connection.Close()
            cmSQL.Dispose();
            drSQL.Close();
            cnSQL.Close();
            //cnSQL.Dispose()
        }

        private void numPercent_ValueChanged(object sender, EventArgs e)
        {

            FillPyramidScale();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            try
            {

               
                SqlConnection cnSQL = new SqlConnection(MyModules.strConnect);
                SqlCommand cmSQL = new SqlCommand();
                cmSQL.Connection=cnSQL;
                cnSQL.Open();
                System.Data.SqlClient.SqlTransaction myTrans = cnSQL.BeginTransaction();
                cmSQL.Transaction = myTrans;

              
                int i = 0;

                cmSQL.CommandText = "DELETE FROM PyramidScale";
                cmSQL.CommandType = CommandType.Text;
                cmSQL.ExecuteNonQuery();

                cmSQL.CommandText = "UPDATE SystemParameters SET PyramidLevel=" + Convert.ToInt16(numPyramidLevel.Value)+ ", TotalPyramidPercent=" + Convert.ToDouble(numPercent.Value) + ",PercentDrawable=" + Convert.ToDouble(numdrawable.Value);
                cmSQL.CommandType = CommandType.Text;
                cmSQL.ExecuteNonQuery();


                for (i = 0; i < dGrid.RowCount; i++)
                {
               cmSQL.Parameters.Clear();
                    cmSQL.CommandText = "InsertPyramidScale";
                    cmSQL.CommandType = CommandType.StoredProcedure;
                    cmSQL.Parameters.AddWithValue("@PyramidLevel", dGrid[0,i].Value);
                    cmSQL.Parameters.AddWithValue("@PyramidPercent", dGrid[1, i].Value);
                    cmSQL.ExecuteNonQuery();

                }

                myTrans.Commit();
                cnSQL.Close();

                MyModules.PyramidLevel = Convert.ToInt16(numPyramidLevel.Value);
                MyModules.PyramidPercent = Convert.ToDouble(numPercent.Value);
                MyModules.PercentDrawable = Convert.ToDouble(numdrawable.Value);

                MessageBox.Show("Update Successfull!", MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message, MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
        }

        private void dGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {

                    using (var form = new FrmProgramParameterSub(senderGrid[1, e.RowIndex].Value.ToString(), Convert.ToUInt16(senderGrid[0, e.RowIndex].Value),Convert.ToDouble(numPercent.Value)))
                    {
                        form.Top = this.Top;
                        form.Left = this.Left + this.Width;
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            senderGrid[1, e.RowIndex].Value = form.ReturnValue.ToString();

                        }

                    }

                }
             
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, MyModules.strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
