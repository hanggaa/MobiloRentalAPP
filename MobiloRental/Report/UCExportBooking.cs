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
    public partial class UCExportBooking : DevExpress.XtraEditors.XtraUserControl
    {
        public UCExportBooking()
        {
            this.DoubleBuffered = true;

            frmMain.setLoadDialog(true, "Loading Components...");
            InitializeComponent();
            frmMain.setLoadDialog(false, "");
        }
        public frmMain fMain;
        public void Refresh()
        {
            base.Refresh();
            //Clear();
            loadData();
            //fillCombo();
        }
        private void loadData()
        {
            try
            {
                using (clsConnection oConn = new clsConnection())
                {
                    NpgsqlCommand ocmd = new NpgsqlCommand();
                    frmMain.setLoadDialog(true, "Loading data...");
                    string strSql = @"select * from tbm_booking where dlt='0'";
                    DataTable dtData = oConn.GetData(strSql);
                    dgData.DataSource = dtData;
                    label8.Text = dtData.Rows.Count.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (clsConnection oConn = new clsConnection())
                {
                    NpgsqlCommand ocmd = new NpgsqlCommand();
                    frmMain.setLoadDialog(true, "Loading data...");
                    string strSql = @"select * from tbm_booking where dlt='0' and bookingid='"+txtSearch.Text+"'";
                    DataTable dtData = oConn.GetData(strSql);
                    dgData.DataSource = dtData;
                    label8.Text = dtData.Rows.Count.ToString();
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
                    string strSql = @"select * from tbm_booking where dlt='0' and date_order between'" + dateStart.Value + "'And'"+dateEnd.Value+"'";
                    DataTable dtData = oConn.GetData(strSql);
                    dgData.DataSource = dtData;
                    label8.Text = dtData.Rows.Count.ToString();
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
            sfd.FileName = "MBR_Booking_" + DateTime.Now.ToString("ddMMMMyyyy");
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

        private void dgData_Click(object sender, EventArgs e)
        {
            try
            {
                using (clsConnection oConn = new clsConnection())
                {
                    NpgsqlCommand ocmd = new NpgsqlCommand();
                    frmMain.setLoadDialog(true, "Loading data...");
                    string strSql = @"select a.detailid,a.carid,a.price,b.bookingid,b.edatebooking,c.platnumber,d.typename from tbm_bookingdetail a 
                    INNER join tbm_booking b on b.bookingid = a.bookingid and b.dlt='0' 
                    INNER join tbm_car c on c.carid = a.carid and c.dlt='0'
                    INNER join tbm_cartype d on d.typeid = c.typeid and d.dlt='0'
                    where b.bookingid ='"+ dgData.CurrentRow.Cells[0].Value.ToString() + "' AND NOT EXISTS(Select bookingid from tbm_carreturn where tbm_carreturn.bookingid = b.bookingid) ORDER BY c.carid";
                    DataTable dtData = oConn.GetData(strSql);
                    dgBawah.DataSource = dtData;
                    label9.Text = dgBawah.Rows.Count.ToString();
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
    }
}

