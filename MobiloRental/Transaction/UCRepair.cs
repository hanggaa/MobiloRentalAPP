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
    public partial class UCRepair : DevExpress.XtraEditors.XtraUserControl
    {
        public UCRepair()
        {
            this.DoubleBuffered = true;

            frmMain.setLoadDialog(true, "Loading Components...");
            InitializeComponent();
            frmMain.setLoadDialog(false, "");
        }
        private string strRepairid = "";
        private string strCarid = "";
        private void fillCombo()
        {
            try
            {
                using (clsConnection oConn = new clsConnection())
                {
                    NpgsqlCommand ocmd = new NpgsqlCommand();
                    string strSql = @"select * from tbm_car where dlt='0'";
                    DataTable dtData = oConn.GetData(strSql);
                    for (int i = 0; i < dtData.Rows.Count; i++)
                    {
                        cmbPlatnumber.Items.Add(dtData.Rows[i]["platnumber"].ToString());
                    }
                }
            }
            catch (NpgsqlException ex)
            {

            }
            catch (Exception ex)
            {

            }
            
        }
        string id = "0";
        string carid = "0";
        public frmMain fMain;
        public void Refresh()
        {
            base.Refresh();
            Clear();
            loadData();
            fillCombo();
        }
        public void loadData()
        {
            try
            {
                using (clsConnection oConn = new clsConnection())
                {
                    NpgsqlCommand ocmd = new NpgsqlCommand();
                    frmMain.setLoadDialog(true, "Loading data...");
                    string strSql = @"select a.repairid,a.carid,b.platnumber from tbm_carrepair a inner join tbm_car b on b.carid=a.carid and b.dlt='0'";
                    DataTable dtData = oConn.GetData(strSql);
                    dgData.DataSource = dtData;
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
        
        private void Clear()
        {
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnDelete.Enabled = true;
            cmbPlatnumber.Enabled = false;
            cmbPlatnumber.Text = "";
            id = "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmbPlatnumber.Enabled = true;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = false;
            cmbPlatnumber.Text = "";
            id = "0";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgData_Click(object sender, EventArgs e)
        {
            id = dgData.CurrentRow.Cells["repairid"].Value.ToString();
            carid = dgData.CurrentRow.Cells["carid"].Value.ToString();
            cmbPlatnumber.Text = dgData.CurrentRow.Cells["platnumber"].Value.ToString();
        }
        private void getRepairId()
        {
            try
            {
                using (clsConnection oConn = new clsConnection())
                {
                    NpgsqlCommand ocmd = new NpgsqlCommand();
                    string strSql = @"select * from tbm_carrepair where dlt=false";
                    DataTable dtData = oConn.GetData(strSql);
                    //dgData.DataSource = dtData;
                    if (dtData.Rows.Count == 0)
                    {
                        int bookingId = 1;
                        strRepairid = clsGlobal.pstrservercode + "0" + bookingId++;
                    }
                    else
                    {
                        foreach (DataRow row in dtData.Rows)
                        {
                            int BookingId = Convert.ToInt32(row["repairid"].ToString().Substring(3, 2));
                            int IncBookingId = BookingId++;
                            string strBookingId = Convert.ToString(BookingId++);
                            string finalid = clsGlobal.pstrservercode + "0" + strBookingId;
                            strRepairid = finalid;

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
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            getRepairId();
            if (cmbPlatnumber.Text == "")
            {
                MessageBox.Show("Please Provide The Car ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                try
                {
                    using (clsConnection oConn = new clsConnection())
                    {
                        string strGetCarid = clsGlobal.getData1Field("select carid from tbm_car where platnumber='" + cmbPlatnumber.Text + "'");
                        string strCount = clsGlobal.getData1Field("select count(*) from tbm_carrepair where dlt='0' and trim(lower(carid))=trim(lower('" + strGetCarid + "')) and repairid <>'" + strRepairid + "'");
                        if (Convert.ToInt32(strCount) == 0)
                        {
                            tbm_carrepair oObject = new tbm_carrepair();
                            oConn.Open();
                            oObject.Koneksi = oConn.Conn;
                            if (!string.IsNullOrEmpty(strRepairid))
                            {
                                oObject.GetByPrimaryKey(strRepairid);
                            }
                            oObject.repairid = strRepairid;
                            oObject.carid = strGetCarid;

                            if (oObject.carid == "")
                            {
                                XtraMessageBox.Show("Data Can't Be Null", "Warning");
                            }
                            else
                            {
                                    oObject.repairid = strRepairid;
                                    oObject.opadd = clsGlobal.strUserName;
                                    oObject.pcadd = SystemInformation.ComputerName;
                                oObject.luadd = DateTime.Now;
                                    oObject.Insert();
                                    Clear();
                                    loadData();
                                    MessageBox.Show("Data Inserted", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    oObject = null;
                            }

                        }
                        else
                        {

                        }
                    }
                }
                catch (NpgsqlException ex)
                {
                    ////clsGlobal.generateErrMessageAndSendmail(ex, false);
                }
                catch (Exception ex)
                {
                    ////clsGlobal.generateErrMessageAndSendmail(ex, false);

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(this, "Are you sure to delete selected record?", clsGlobal.pstrAppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (clsConnection oConn = new clsConnection())
                    {
                        frmMain.setLoadDialog(true, "Deleting data...");
                        tbm_carrepair oObject = new tbm_carrepair();
                        oConn.Open();
                        oObject.Koneksi = oConn.Conn;
                        oObject.repairid = Convert.ToString(dgData.CurrentRow.Cells["repairid"].Value.ToString());
                        oObject.opedit = clsGlobal.strUserName;
                        oObject.pcedit = SystemInformation.ComputerName;
                        oObject.Delete();
                        oObject = null;
        
                    }
                }
                catch (NpgsqlException ex)
                {

                }
                catch (Exception ex)
                {
                    ////clsGlobal.generateErrMessageAndSendmail(ex, false);
                }
                finally
                {
                    frmMain.setLoadDialog(false, "");
                    loadData();
                }
            }
        }
    }
 }

