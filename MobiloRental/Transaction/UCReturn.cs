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

namespace MobiloRental.Transaction
{
    public partial class UCReturn : DevExpress.XtraEditors.XtraUserControl
    {
        public UCReturn()
        {
            this.DoubleBuffered = true;

            frmMain.setLoadDialog(true, "Loading Components...");
            InitializeComponent();
            frmMain.setLoadDialog(false, "");
        }
        public frmMain fMain;
        DateTime dtEdateBooking = new DateTime();
        public void Refresh()
        {
            base.Refresh();
            clear();
            //loadData();
        }
        void clear()
        {
            txtReturnID.Enabled = false;
            txtBookingID.Enabled = false;
            btnSearch.Enabled = false;
            txtName.Enabled = false;
            txtIdentity.Enabled = false;
            dateReturn.Enabled = false;
            txtTotal.Enabled = false;
            txtDP.Enabled = false;
            txtRemaining.Enabled = false;
            txtPenalty.Enabled = false;
            txtPayment.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnNew.Enabled = true;
            txtReturnID.Text = "";
            txtBookingID.Text = "";
            txtName.Text = "";
            txtIdentity.Text = "";
            dateReturn.Text = "";
            txtTotal.Text = "";
            txtDP.Text = "";
            txtRemaining.Text = "";
            txtPenalty.Text = "";
            txtPayment.Text = "";
            dgData.DataSource = null;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                using (clsConnection oConn = new clsConnection())
                {
                    NpgsqlCommand ocmd = new NpgsqlCommand();
                    frmMain.setLoadDialog(true, "Loading data...");
                    string strSql = @"select * from tbm_carreturn where dlt=false";
                    DataTable dtData = oConn.GetData(strSql);
                    //dgData.DataSource = dtData;
                    if (dtData.Rows.Count == 0)
                    {
                        int bookingId = 1;
                        txtReturnID.Text = clsGlobal.pstrservercode + "0" + bookingId++;
                    }
                    else
                    {
                        foreach (DataRow row in dtData.Rows)
                        {
                            int BookingId = Convert.ToInt32(row["returnid"].ToString().Substring(3, 2));
                            int IncBookingId = BookingId++;
                            string strBookingId = Convert.ToString(BookingId++);
                            string finalid = clsGlobal.pstrservercode + "0" + strBookingId;
                            txtReturnID.Text = finalid;

                        }
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
            txtReturnID.Enabled = false;
            txtBookingID.Enabled = true;
            btnSearch.Enabled = true;
            txtName.Enabled = false;
            txtIdentity.Enabled = false;
            dateReturn.Enabled = true;
            txtTotal.Enabled = false;
            txtDP.Enabled = false;
            txtRemaining.Enabled = false;
            txtPenalty.Enabled = false;
            txtPayment.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            btnNew.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (clsConnection oConn = new clsConnection())
                {
                    NpgsqlCommand ocmd = new NpgsqlCommand();
                    frmMain.setLoadDialog(true, "Loading data...");
                    string strSql1 = @"select a.name,a.identity_number,b.down_payment from tbm_customer a inner join tbm_booking b on b.customerid=a.customerid and b.dlt='0' where b.bookingid='" + txtBookingID.Text + "'";
                    DataTable dtData = oConn.GetData(strSql1);
                    string strSql2 = @"select a.detailid,a.carid,a.price,b.bookingid,b.edatebooking,c.platnumber,d.typename from tbm_bookingdetail a 
                    INNER join tbm_booking b on b.bookingid = a.bookingid and b.dlt='0' 
                    INNER join tbm_car c on c.carid = a.carid and c.dlt='0'
                    INNER join tbm_cartype d on d.typeid = c.typeid and d.dlt='0'
                    where b.bookingid ='" + txtBookingID.Text + "' AND NOT EXISTS(Select bookingid from tbm_carreturn where tbm_carreturn.bookingid = b.bookingid) ORDER BY c.carid ";
                    DataTable dtData2 = oConn.GetData(strSql2);
                    if (dtData.Rows.Count == 0)
                    {
                        MessageBox.Show("Data Not Found From This BookingID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtPenalty.Enabled = true;
                        dgData.DataSource = dtData2;
                        dtEdateBooking = Convert.ToDateTime(dtData2.Rows[0]["edatebooking"].ToString());
                        txtName.Text = dtData.Rows[0]["name"].ToString();
                        txtIdentity.Text = dtData.Rows[0]["identity_number"].ToString();
                        int sum = 0;
                        for (int i = 0; i < dtData.Rows.Count; i++)
                        {
                            sum += Convert.ToInt32(dgData.Rows[i].Cells["price"].Value);
                        }
                        txtTotal.Text = sum.ToString();
                        txtDP.Text = (Convert.ToInt32(txtTotal.Text) / 2).ToString();
                        txtRemaining.Text = (Convert.ToInt32(txtTotal.Text) - Convert.ToInt32(txtDP.Text)).ToString();
                        getPenaltyAmount();
                    }
                    if (dtData2.Rows.Count == 0)
                    {
                        MessageBox.Show("All Car Has Been Returned", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void getPenaltyAmount()
        {
            try {
                DateTime dTimeToday = DateTime.Today;
                //TimeSpan subtractedValue = dTimeToday.Subtract(dateRseturn.Value);
                TimeSpan subtractedValue = dateReturn.Value.Subtract(dtEdateBooking);
                decimal dateLate = Convert.ToDecimal(subtractedValue.TotalDays);
                int totalPriceBooking = Convert.ToInt32(txtTotal.Text);
                txtPenalty.Text = (dateLate * totalPriceBooking).ToString();
                string diffrentDays = (dateReturn.Value - dtEdateBooking).TotalDays.ToString();
                double diff1 = Convert.ToDouble(diffrentDays);
                double diff2 = Math.Round(diff1, MidpointRounding.AwayFromZero);
                if (diff2 < 0 || diff1 <0 || diff2.ToString().Length == 0)
                {
                    txtPenalty.Text = "0";
                    txtPayment.Text = (Convert.ToInt32(txtRemaining.Text) + Convert.ToInt32(txtPenalty.Text)).ToString();
                }
                else if (diffrentDays.Length >= 1)
                {
                    txtPenalty.Text = (diff2 * totalPriceBooking).ToString();
                    txtPayment.Text = (Convert.ToInt32(txtRemaining.Text) + Convert.ToInt32(txtPenalty.Text)).ToString();
                }

            }
            catch { }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookingID.Text == "" || txtPenalty.Text == "" || txtPayment.Text == "")
            {
                MessageBox.Show("Please Provide All The Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dgData.Rows.Count == 0)
            {
                MessageBox.Show("You Have No Car To be Return", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    using (clsConnection oConn = new clsConnection())
                    {
                        tbm_carreturn oObject = new tbm_carreturn();
                        oConn.Open();
                        oObject.Koneksi = oConn.Conn;
                        if (!string.IsNullOrEmpty(txtReturnID.Text))
                        {
                            oObject.GetByPrimaryKey(txtReturnID.Text);
                        }
                        oObject.returnid = txtReturnID.Text;
                        oObject.bookingid = txtBookingID.Text;
                        oObject.dtreturn = dateReturn.Value;
                        oObject.remainingpayment = Convert.ToDecimal(txtRemaining.Text);
                        oObject.penaltypayment = Convert.ToDecimal(txtPenalty.Text);
                        oObject.paymentamount = Convert.ToDecimal(txtPayment.Text);
                        oObject.opadd = clsGlobal.strUserName;
                        oObject.pcadd = SystemInformation.ComputerName;
                        oObject.Insert();
                       
                        for (int i = 0; i < dgData.Rows.Count; i++)
                        {
                            tbm_car oObject1 = new tbm_car();
                            oConn.Open();
                            oObject1.Koneksi = oConn.Conn;
                            oObject1.carid = "Example";
                            oObject1.platnumber = dgData.Rows[i].Cells[5].Value.ToString();
                            oObject1.available = true;
                            oObject.pcedit = SystemInformation.ComputerName;
                            oObject.opedit = clsGlobal.strUserName;
                            oObject.luedit = DateTime.Now;
                            oObject1.updateAv();
                        }
                        clear();
                        MessageBox.Show("Data Submitted", "Submit", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void txtPenalty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPayment.Text = (Convert.ToInt32(txtRemaining.Text) + Convert.ToInt32(txtPenalty.Text)).ToString();
            }
        }
    }
}
