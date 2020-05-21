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

namespace MobiloRental.Master_Data
{
    public partial class UCCarBrand : DevExpress.XtraEditors.XtraUserControl
    {
        public UCCarBrand()
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
        public void loadData()
        {
            try
            {
                using (clsConnection oConn = new clsConnection())
                {
                    NpgsqlCommand ocmd = new NpgsqlCommand();
                    frmMain.setLoadDialog(true, "Loading data...");

                    string strSql = @"select carbrandid as brandid,
                                      brandname 
                                      from tbm_carbrand
                                      where dlt='0'";
                    DataTable dtData = oConn.GetData(strSql);
                    dgData.DataSource = dtData;
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
            finally
            {
                frmMain.setLoadDialog(false, "");
            }
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
                        tbm_carcategory oObject = new tbm_carcategory();
                        oConn.Open();
                        oObject.Koneksi = oConn.Conn;
                        oObject.categoryid = Convert.ToString(gridViewData.GetFocusedRowCellValue(colCarBrandId));
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
                    string brandId = Convert.ToString(gridViewData.GetFocusedRowCellValue(colCarBrandId));
                    string strCount = clsGlobal.getData1Field("select count(*) from tbm_carcategory where dlt='0' and trim(lower(carcategoryname))=trim(lower('" + Convert.ToString(gridViewData.GetFocusedRowCellValue(colBrandName)) + "')) and carcategoryid <>'" + brandId + "'");
                    if (Convert.ToInt32(strCount) == 0)
                    {
                        tbm_carbrand oObject = new tbm_carbrand();
                        oConn.Open();
                        oObject.Koneksi = oConn.Conn;
                        if (!string.IsNullOrEmpty(brandId))
                        {
                            oObject.GetByPrimaryKey(brandId);
                        }
                        oObject.brandid = Convert.ToString(gridViewData.GetFocusedRowCellValue(colCarBrandId));
                        oObject.brandname = Convert.ToString(gridViewData.GetFocusedRowCellValue(colBrandName));

                        if (oObject.brandname == "")
                        {
                            XtraMessageBox.Show("Data Can't Be Null", "Warning");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(brandId))
                            {
                                oObject.brandid = oObject.NewID();
                                oObject.opadd = clsGlobal.strUserName;
                                oObject.pcadd = SystemInformation.ComputerName;
                                oObject.luadd = DateTime.Now;
                                oObject.Insert();
                                gridViewData.SetFocusedRowCellValue(colCarBrandId, oObject.brandid);
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
                        e.ErrorText = "This code " + Convert.ToString(gridViewData.GetFocusedRowCellValue(colBrandName)) + " already exists in database and cannot be filled the same value.!\n";
                        gridViewData.FocusedColumn = colBrandName;
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
