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

namespace MobiloRental
{
    public partial class UCCustomer : DevExpress.XtraEditors.XtraUserControl
    {
        public UCCustomer()
        {
            frmMain.setLoadDialog(true, "Loading Components...");
            InitializeComponent();
            frmMain.setLoadDialog(false, "");
        }
        public frmMain fMain;
        public void Refresh()
        {
            base.Refresh();
            btnEdit.Enabled = clsGlobal.bolAdd || clsGlobal.bolEdit;
            btnDelete.Enabled = clsGlobal.bolDelete;
            loadData();

        }
        private void LoadCmb()
        {
         
            Dictionary<int, string> IdentityType = new Dictionary<int, string>()
                                            {
                                                {1,"SIM"},
                                                {2, "KTP"},
                                                {3,"KK"}
                                            };
            foreach (KeyValuePair<int, string> item in IdentityType)
            {
                ricmbIdentityType.Items.Add(item.Value);
            }

            Dictionary<int, string> Gender = new Dictionary<int, string>()
                                            {
                                                {1,"Male"},
                                                {2, "Female"},
                                            };
            foreach (KeyValuePair<int, string> item in Gender)
            {
                ricmbGender.Items.Add(item.Value);
            }




        }
        public void loadData()
        {
            try
            {
                using (clsConnection oConn = new clsConnection())
                {
                    NpgsqlCommand ocmd = new NpgsqlCommand();
                    frmMain.setLoadDialog(true, "Loading data...");
                    string strSql = @"select * from tbm_customer where dlt=false";
                    DataTable dtData = oConn.GetData(strSql);
                    dgData.DataSource = dtData;
                    foreach (DataRow row in dtData.Rows)
                    {

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
            LoadCmb();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            gridViewData.OptionsBehavior.Editable = true;
            gridViewData.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            btnEdit.Enabled = false;
            btnEndEdit.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void btnEndEdit_Click(object sender, EventArgs e)
        {
            gridViewData.OptionsBehavior.Editable = false;
            gridViewData.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            btnEdit.Enabled = clsGlobal.bolAdd || clsGlobal.bolEdit;
            btnEndEdit.Enabled = false;
            btnDelete.Enabled = clsGlobal.bolDelete;
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
                        tbm_customer oObject = new tbm_customer();
                        oConn.Open();
                        oObject.Koneksi = oConn.Conn;
                        oObject.customerid = Convert.ToString(gridViewData.GetFocusedRowCellValue(colCustomerid));
                        oObject.opedit = clsGlobal.strUserName;
                        oObject.pcedit = SystemInformation.ComputerName;
                        oObject.SoftDelete();
                        oObject = null;
                        gridViewData.DeleteSelectedRows();
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
                }
            }
        }

        private void gridViewData_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            try
            {
                using (clsConnection oConn = new clsConnection())
                {
                    string customerid = Convert.ToString(gridViewData.GetFocusedRowCellValue(colCustomerid));
                    string strCount = clsGlobal.getData1Field("select count(*) from tbm_customer where dlt='0' and trim(lower(name))=trim(lower('" + Convert.ToString(gridViewData.GetFocusedRowCellValue(colName)) + "')) and customerid <>'" + customerid + "'");
                    if (Convert.ToInt32(strCount) == 0)
                    {
                        tbm_customer oObject = new tbm_customer();
                        oConn.Open();
                        oObject.Koneksi = oConn.Conn;
                        if (!string.IsNullOrEmpty(customerid))
                        {
                            oObject.GetByPrimaryKey(customerid);
                        }
                        oObject.customerid = Convert.ToString(gridViewData.GetFocusedRowCellValue(colCustomerid));
                        oObject.name = Convert.ToString(gridViewData.GetFocusedRowCellValue(colName));
                        oObject.identity_type = Convert.ToString(gridViewData.GetFocusedRowCellValue(colIdentityType));
                        oObject.identity_number = Convert.ToString(gridViewData.GetFocusedRowCellValue(colIdentityNumber));
                        oObject.gender = Convert.ToString(gridViewData.GetFocusedRowCellValue(colGender));
                        oObject.phoneNumber = Convert.ToDecimal(gridViewData.GetFocusedRowCellValue(colPhoneNumber));
                        oObject.dob = Convert.ToDateTime(gridViewData.GetFocusedRowCellValue(colDob));
                        oObject.address = Convert.ToString(gridViewData.GetFocusedRowCellValue(colAddress));

                        if (oObject.name == "")
                        {
                            XtraMessageBox.Show("Data Can't Be Null", "Warning");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(customerid))
                            {
                                oObject.customerid = oObject.NewID();
                                oObject.opadd = clsGlobal.strUserName;
                                oObject.pcadd = SystemInformation.ComputerName;
                                oObject.luadd = DateTime.Now;
                                oObject.Insert();
                                gridViewData.SetFocusedRowCellValue(colCustomerid, oObject.customerid);
                            }
                            else
                            {
                                oObject.opedit = clsGlobal.strUserName;
                                oObject.pcedit = SystemInformation.ComputerName;
                            oObject.luedit = DateTime.Now;
                                oObject.Update();
                            }
                            oObject = null;
                            e.Valid = true;
                        }

                    }
                    else
                    {
                        e.ErrorText = "This code " + Convert.ToString(gridViewData.GetFocusedRowCellValue(colName)) + " already exists in database and cannot be filled the same value.!\n";
                        gridViewData.FocusedColumn = colName;
                        e.Valid = false;
                        return;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (fMain != null)
            {
                fMain.barButtonItemCloseClick(true);
            }
        }
    }
}
