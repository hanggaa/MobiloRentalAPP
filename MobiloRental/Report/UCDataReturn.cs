using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Library;
using Npgsql;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;

namespace MobiloRental.Report
{
    public partial class UCDataReturn : DevExpress.XtraEditors.XtraUserControl
    {
        public UCDataReturn()
        {
            this.DoubleBuffered = true;

            frmMain.setLoadDialog(true, "Loading Components...");
            InitializeComponent();
            frmMain.setLoadDialog(false, "");
        }
        private void loadData()
        {
            try
            {
                using (clsConnection oConn = new clsConnection())
                {
                    NpgsqlCommand ocmd = new NpgsqlCommand();
                    frmMain.setLoadDialog(true, "Loading data...");
                    string strSql = @"select  returnid,bookingid,dtreturn,remainingpayment,penaltypayment,paymentamount from tbm_carreturn where dlt='0'";
                    DataTable dtData = oConn.GetData(strSql);
                    dgData.DataSource = dtData;
                    int sum = 0;
                    for (int i = 0; i < dgData.Rows.Count; i++)
                    {
                        sum += Convert.ToInt32(dgData.Rows[i].Cells[5].Value);
                    }
                    label6.Text = sum.ToString();
                }
            }
            catch (NpgsqlException ex)
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
                frmMain.setLoadDialog(false, "");
            }
        }

        public frmMain fMain;
        public void Refresh()
        {
            base.Refresh();
            //Clear();
            loadData();
            //fillCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (clsConnection oConn = new clsConnection())
                {
                    NpgsqlCommand ocmd = new NpgsqlCommand();
                    frmMain.setLoadDialog(true, "Loading data...");
                    string strSql = @"select returnid,bookingid,dtreturn,remainingpayment,penaltypayment,paymentamount from tbm_carreturn where dlt='0' and returnid ='" + textBox1.Text+"'";
                    DataTable dtData = oConn.GetData(strSql);
                    dgData.DataSource = dtData;
                    int sum = 0;
                    for (int i = 0; i < dgData.Rows.Count; i++)
                    {
                        sum += Convert.ToInt32(dgData.Rows[i].Cells[5].Value);
                    }
                    label6.Text = sum.ToString();
                    if (dtData.Rows.Count == 0)
                    {
                        MessageBox.Show("Data Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (NpgsqlException ex)
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
                frmMain.setLoadDialog(false, "");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (clsConnection oConn = new clsConnection())
                {
                    NpgsqlCommand ocmd = new NpgsqlCommand();
                    frmMain.setLoadDialog(true, "Loading data...");
                    string strSql = @"select * from tbm_carreturn where dlt='0' and dtreturn between'" + dateStart.Value + "'And'" + dateEnd.Value + "'";
                    DataTable dtData = oConn.GetData(strSql);
                    dgData.DataSource = dtData;
                    int sum = 0;
                    for (int i = 0; i < dgData.Rows.Count; i++)
                    {
                        sum += Convert.ToInt32(dgData.Rows[i].Cells[5].Value);
                    }
                    label6.Text = sum.ToString();
                    if (dtData.Rows.Count == 0)
                    {
                        MessageBox.Show("Data Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (NpgsqlException ex)
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
                frmMain.setLoadDialog(false, "");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);
            for (int i = 1; i < dgData.ColumnCount + 1; i++)
            {
                excel.Cells[1, i] = dgData.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgData.Rows.Count; i++)
            {
                for (int j = 0; j < dgData.Columns.Count; j++)
                {
                    excel.Cells[i + 2, j + 1] = dgData.Rows[i].Cells[j].Value.ToString();
                }
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files|.*xlsx";
            sfd.FilterIndex = 1;
            sfd.FileName = "MBR_Return_" + DateTime.Now.ToString("ddMMMMyyyy");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(sfd.FileName);
                excel.Quit();
                workbook = null;
                excel = null;
                MessageBox.Show("Data Exported", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }
    }
}
