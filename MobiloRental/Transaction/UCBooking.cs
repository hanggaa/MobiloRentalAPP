using System;
using System.Data;
using System.Windows.Forms;
using Library;
using Npgsql;

namespace MobiloRental.Transaction
{
    public partial class UCBooking : DevExpress.XtraEditors.XtraUserControl
    {
        public UCBooking()
        {
            this.DoubleBuffered = true;

            frmMain.setLoadDialog(true, "Loading Components...");
            InitializeComponent();
            frmMain.setLoadDialog(false, "");

        }
        public frmMain fMain;
        DataTable dtKiri = new DataTable();
        DataTable dtKanan = new DataTable();
        public void Refresh()
        {
            base.Refresh();
            clear();    
            loadData();
        }
        void clear()
        {
            txtBookingId.Enabled = false;
            txtIdentity_Number.Enabled = false;
            btnSearch.Enabled = false;
            txtCustomerName.Enabled = false;
            txtCustomerId.Enabled = false;
            dtTimeOrder.Enabled = false;
            dtSBooking.Enabled = false;
            seDuration.Enabled = false;
            dtEBooking.Enabled = false;
            btnNewBooking.Enabled = true;
            btnSaveBooking.Enabled = false;
            btnCancelBooking.Enabled = false;
            txtTotalPrice.Enabled = false;
            txtDP.Enabled = false;
            btnRight.Enabled = false;
            btnLeft.Enabled = false;
            txtBookingId.Text = "";
            txtIdentity_Number.Text = "";
            txtCustomerName.Text = "";
            txtCustomerId.Text = "";
            dtTimeOrder.Text = "";
            dtSBooking.Text = "";
            seDuration.Value = 0;
            dtEBooking.Text = "";
            dataRight.Rows.Clear();
        }
        public void loadData()
        {
            try
            {
                using (clsConnection oConn = new clsConnection())
                {
                    NpgsqlCommand ocmd = new NpgsqlCommand();
                    frmMain.setLoadDialog(true, "Loading data...");
                    string strSql = @"select a.platnumber,b.typename,a.price from tbm_car a left join tbm_cartype b on b.typeid=a.typeid and b.dlt='0' where a.statusavailable=true and not exists(select carid from tbm_carrepair where tbm_carrepair.carid = a.carid)";
                    DataTable dtData = oConn.GetData(strSql);
                    //dataLeft.DataSource = dtData;
                    foreach (DataRow row in dtData.Rows)
                    {
                        dataLeft.Rows.Add(row["platnumber"].ToString(), row["platnumber"].ToString(), row["price"]);
                    }
                    //gridViewData.Columns[1].ColumnEdit = ricmbCarType;


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
       
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (clsConnection oConn = new clsConnection())
                {
                    NpgsqlCommand ocmd = new NpgsqlCommand();
                    frmMain.setLoadDialog(true, "Loading data...");
                    string strSql = @"select * from tbm_customer where identity_number='" + txtIdentity_Number.Text+ "'";
                    DataTable dtData = oConn.GetData(strSql);
                    if (dtData.Rows.Count == 0)
                    {
                        MessageBox.Show("Error : Customer Data not Found", clsGlobal.pstrAppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        foreach(DataRow row in dtData.Rows)
                        {
                            txtCustomerId.Text = row["customerid"].ToString();
                            txtCustomerName.Text = row["name"].ToString();
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
        }
        private void loadBookingId()
        {
            using (clsConnection oConn = new clsConnection())
            {
                string strSql = @"select * from tbm_booking";
                DataTable dtData = oConn.GetData(strSql);
                if(dtData.Rows.Count == 0)
                {
                    int bookingId = 1;
                    txtBookingId.Text = clsGlobal.pstrservercode+"0" + bookingId++;
                }
                else
                {
                    foreach(DataRow row in dtData.Rows)
                    {
                        int BookingId = Convert.ToInt32(row["bookingid"].ToString().Substring(3, 2));
                        int IncBookingId = BookingId++;
                        string strBookingId = Convert.ToString(BookingId++);
                        string finalid = clsGlobal.pstrservercode + "0" + strBookingId;
                        txtBookingId.Text = finalid;

                    }
                }
               
            }
        }
        private void removeDgridRowLeft()
        {
            int selectedCount = dataLeft.SelectedRows.Count;
            while (selectedCount > 0)
            {
                if (!dataLeft.SelectedRows[0].IsNewRow)
                    dataLeft.Rows.RemoveAt(dataLeft.SelectedRows[0].Index);
                selectedCount--;
            }
        }
        private void btnRight_Click(object sender, EventArgs e)
        {
            try {
                DataGridView dgKiri = sender as DataGridView;
                if (txtBookingId.Text == "" || txtIdentity_Number.Text == "" || dtTimeOrder.Text == "" || dtSBooking.Text == "" || seDuration.Value == 0 || seDuration.Text == "" || dtEBooking.Text == "")
                {
                    MessageBox.Show("Please Provide All The Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool isExist = false;
                    for (int i = 0; i < dataLeft.Columns.Count; i++)
                    {
                        if (dataRight.Rows.Count != 0)
                        {
                            for (int j = 0; j < dataRight.Rows.Count; j++)
                            {
                                if (dataLeft.CurrentRow.Cells[0].Value.ToString() == dataRight.Rows[j].Cells[0].Value.ToString())
                                {
                                    isExist = true;
                                    break;
                                }
                            }
                            if (isExist == false)
                            {
                                if (dataLeft.CurrentRow.Cells[i].Selected)
                                {
                                    dataRight.Rows.Add(dataLeft.CurrentRow.Cells[0].Value.ToString(),
                                                       dataLeft.CurrentRow.Cells[1].Value.ToString(),
                                                       dataLeft.CurrentRow.Cells[2].Value.ToString(),
                                                       txtBookingId.Text);
                                }
                            }
                            removeDgridRowLeft();
                        }
                        else
                        {
                            if (dataLeft.CurrentRow.Cells[i].Selected)
                            {
                                dataRight.Rows.Add(dataLeft.CurrentRow.Cells[0].Value.ToString(),
                                                   dataLeft.CurrentRow.Cells[1].Value.ToString(),
                                                   dataLeft.CurrentRow.Cells[2].Value.ToString(),
                                                   txtBookingId.Text);
                                removeDgridRowLeft();
                            }
                        }
                    }
                    
                    
                    int sum = 0;
                    for (int i = 0; i < dataRight.Rows.Count; i++)
                    {
                        sum += Convert.ToInt32(dataRight.Rows[i].Cells[2].Value);
                    }
                    txtTotalPrice.Text = sum.ToString();
                    txtDP.Text = (sum / 2).ToString();
                }
            }
            catch { }
        }

        private void btnNewBooking_Click(object sender, EventArgs e)
        {
            loadBookingId();
            txtBookingId.Enabled = false;
            txtIdentity_Number.Enabled = true;
            btnSearch.Enabled = true;
            txtCustomerName.Enabled = false;
            txtCustomerId.Enabled = false;
            dtTimeOrder.Enabled = true;
            dtSBooking.Enabled = true;
            seDuration.Enabled = true;
            dtEBooking.Enabled = true;
            btnNewBooking.Enabled = false;
            btnSaveBooking.Enabled = true;
            btnCancelBooking.Enabled = true;
            btnLeft.Enabled = true;
            btnRight.Enabled = true;
            txtIdentity_Number.Text = "";
            txtCustomerName.Text = "";
            txtCustomerId.Text = "";
            dtTimeOrder.DateTime = DateTime.Today;
            dtSBooking.DateTime = DateTime.Today;
            seDuration.Value = 0;
            dtEBooking.Text = "";
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {

            try {
                for (int k = 0; k < dataRight.Rows.Count; k++)
                {
                    for (int l = dataRight.ColumnCount - 1; l >= 0; l--)
                    {
                        if (dataRight.Rows[k].Cells[l].Selected)
                        {
                            dataRight.Rows.RemoveAt(dataRight.Rows[k].Index);
                        }
                    }
                } }
            catch { }
        }

        private void seDuration_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            
        }

        private void dtEBooking_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void seDuration_EditValueChanged(object sender, EventArgs e)
        {
            try {
                Int32 getDuration = Convert.ToInt32(seDuration.Text.Replace(".", String.Empty));
                DateTime endDate = new DateTime();
                endDate = Convert.ToDateTime(dtSBooking.DateTime);

                dtEBooking.DateTime = endDate.AddDays(getDuration);
                dtEBooking.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"; }
            catch
            {

            }
        }

        private void save()
        {
            try
            {
                using (clsConnection oConn = new clsConnection())
                {
                    #region tbm_booking
                    tbm_booking oObject = new tbm_booking();
                    oConn.Open();
                    oObject.Koneksi = oConn.Conn;
                    oObject.bookingid = txtBookingId.Text;
                    oObject.customerid = txtCustomerId.Text;
                    oObject.dateorder = Convert.ToDateTime(dtTimeOrder.EditValue.ToString());
                    oObject.sdatebooking = Convert.ToDateTime(dtSBooking.EditValue.ToString());
                    oObject.edatebooking = Convert.ToDateTime(dtEBooking.EditValue.ToString());
                    oObject.duration_booking = Convert.ToDecimal(seDuration.Text);
                    oObject.downpayment = Convert.ToDecimal(txtDP.Text);
                    #endregion tbm_booking
                    if (!string.IsNullOrEmpty(txtBookingId.Text))
                    {
                        oObject.GetByPrimaryKey(txtBookingId.Text);
                    }
                    for (int j = 0; j < 3; j++)
                    {
                        if (j == 0)
                        {
                            oObject.opadd = clsGlobal.strUserName;
                            oObject.pcadd = SystemInformation.ComputerName;
                            oObject.luadd = DateTime.Now;
                            oObject.Insert();
                        }

                        if (j == 1)
                        {
                            for (int i = 0; i < dataRight.Rows.Count; i++)
                            {
                                #region getCarId
                                string strSQL = "Select * from tbm_car where platnumber='"+ dataRight.Rows[i].Cells[0].Value.ToString() + "'";
                                DataTable dt = oConn.GetData(strSQL);
                                #endregion getCarId
                                #region tbm_bookingDetail
                                tbm_bookingdetail oObject1 = new tbm_bookingdetail();
                                oConn.Open();
                                oObject1.Koneksi = oConn.Conn;
                                oObject1.detailid = oObject1.NewID();
                                oObject1.bookingid = txtBookingId.Text;
                                oObject1.carid = dt.Rows[0]["carid"].ToString();
                                oObject1.price = Convert.ToInt32(dt.Rows[0]["price"]);
                                oObject1.opadd = clsGlobal.strUserName;
                                oObject1.pcadd = SystemInformation.ComputerName;
                                oObject1.Insert();
                                #endregion tbm_bookingDetail
                            }
                        }
                        if (j == 2)
                        {
                            for (int i = 0; i < dataRight.Rows.Count; i++)
                            {
                                #region tbm_carid
                                tbm_car oObject2 = new tbm_car();
                                oConn.Open();
                                oObject2.Koneksi = oConn.Conn;

                                oObject2.platnumber = dataRight.Rows[i].Cells[0].Value.ToString();
                                oObject2.available = false;
                                oObject2.opedit = clsGlobal.strUserName;
                                oObject2.pcedit = SystemInformation.ComputerName;
                                oObject2.updateAv();
                                #endregion tbm_carid

                                Refresh();
                                MessageBox.Show("Data Saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
        }
            catch { }
        }
    private void btnSaveBooking_Click(object sender, EventArgs e)
        {
            save();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
