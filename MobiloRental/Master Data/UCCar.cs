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

namespace MobiloRental.Master_Data
{
    public partial class UCCar : DevExpress.XtraEditors.XtraUserControl
    {
        public frmMain fMain;
        RepositoryItemButtonEdit showImage;
        bool status;
        public UCCar()
        {
            this.DoubleBuffered = true;

            frmMain.setLoadDialog(true, "Loading Components...");
            InitializeComponent();
            frmMain.setLoadDialog(false, "");

        }
        private void gridViewData_RowCellClick(object sender, RowCellClickEventArgs e)
        {

        }
        private void gridViewData_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {

            for (int i = 0; i < gridViewData.RowCount; i++)
            {
                DataRowView row = gridViewData.GetRow(i) as DataRowView;
                if (row != null)
                {
                    if (e.Column.FieldName == "colImage")
                        if (e.RowHandle == i)
                            e.RepositoryItem = showImage;
                }
            }

        }

        public void Refresh()
        {
            base.Refresh();
            btnViewData.Enabled = clsGlobal.bolAdd || clsGlobal.bolEdit;
            btnDelete.Enabled = clsGlobal.bolDelete;
            //btnDelete.Enabled = true;
            loadData();
            loadCmb();

        }
        public void loadData()
        {
            try
            {
                using (clsConnection oConn = new clsConnection())
                {
                    NpgsqlCommand ocmd = new NpgsqlCommand();
                    frmMain.setLoadDialog(true, "Loading data...");
                    string strSql = @"select a.carid, a.platnumber,a.imagename,a.typeid,a.filepath_car,a.passengercapacity,a.price,a.description,
                                      a.statusavailable,
                                      b.typeid,b.carcategoryid as categoryid, b.carbrandid,b.typename,
                                      c.carcategoryid as categoryid,c.carcategoryname as categoryname,
                                      d.carbrandid as brandids,d.brandname
                                      from tbm_car a
                                      left join tbm_cartype b on b.typeid =  a.typeid and b.dlt='0'
                                      left join tbm_carcategory c on c.carcategoryid = b.carcategoryid and c.dlt='0' 
                                      left join tbm_carbrand d on d.carbrandid = b.carbrandid and d.dlt='0'
                                      where a.dlt=false order by a.statusavailable;";
                    DataTable dtData = oConn.GetData(strSql);
                    dgData.DataSource = dtData;
                    foreach(DataRow row in dtData.Rows)
                    {
                       
                    }
                    gridViewData.Columns[1].ColumnEdit = ricmbCarType;


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
        private void loadCmb()
        {
            try
            {
                using (clsConnection oConn = new clsConnection())
                {
                    string strSql = @"select a.carid, a.platnumber,a.typeid,a.filepath_car,a.passengercapacity,a.price,a.description,
                                      a.statusavailable as available,
                                      b.typeid,b.carcategoryid as categoryid, b.carbrandid,b.typename,
                                      c.carcategoryid as categoryid,c.carcategoryname as categoryname,
                                      d.carbrandid as brandids,d.brandname
                                      from tbm_car a
                                      left join tbm_cartype b on b.typeid =  a.typeid and b.dlt='0'
                                      left join tbm_carcategory c on c.carcategoryid = b.carcategoryid and c.dlt='0' 
                                      left join tbm_carbrand d on d.carbrandid = b.carbrandid and d.dlt='0'
                                      where b.dlt ='0' a.typeid='" + Convert.ToString(gridViewData.GetFocusedRowCellValue(colTypeid)) + "' order by a.typeid;";
                    DataTable dtData = oConn.GetData(strSql);
                    string strTypename = @"select typename from tbm_cartype where dlt='0' ";
                    DataTable dtType = oConn.GetData(strTypename);
                    foreach (DataRow row in dtType.Rows)
                    {
                        ricmbCarType.Items.Add(row["typename"]);
                    }


                }
            }
            catch
            {

            }
        }
        private void doStuff()
        {
            try
            {
                using (clsConnection oConn = new clsConnection())
                {
                    string carId = Convert.ToString(gridViewData.GetFocusedRowCellValue(colCarId));
                    string platnumber = Convert.ToString(gridViewData.GetFocusedRowCellValue(colPlatnumber));
                    string strCount = clsGlobal.getData1Field("select count(*) from tbm_car where dlt='0' and trim(lower(platnumber))=trim(lower('" + platnumber + "')) and carid <>'" + carId + "'");
                        if (Convert.ToInt32(strCount) == 0)
                        {
                            tbm_car oObject = new tbm_car();
                            oConn.Open();
                            oObject.Koneksi = oConn.Conn;
                            if (!string.IsNullOrEmpty(carId))
                            {
                                oObject.GetByPrimaryKey(carId);
                            }


                        oObject.carid = carId;
                            if (string.IsNullOrEmpty(carId))
                            {
                                oObject.carid = oObject.NewID();
                                oObject.opadd = clsGlobal.strUserName;
                                oObject.pcadd = SystemInformation.ComputerName;
                            oObject.luadd = DateTime.Now;
                                oObject.Insert();

                            }
                            else
                            {
                            oObject.available = status;
                            oObject.opedit = clsGlobal.strUserName;
                            oObject.pcedit = SystemInformation.ComputerName;
                            oObject.luedit = DateTime.Now;
                            oObject.Update();

                            }

                        }
                        else
                        {

                        }
                    }
                }

            catch (NpgsqlException ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
            
        

        private void btnEdit_Click(object sender, EventArgs e)
        {

            viewData();
        }

        private void btnEndEdit_Click(object sender, EventArgs e)
        {
            //gridViewData.OptionsBehavior.Editable = false;
            //gridViewData.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            //btnEdit.Enabled = clsGlobal.bolAdd || clsGlobal.bolEdit;
            //btnEndEdit.Enabled = false;
            //btnDelete.Enabled = clsGlobal.bolDelete;
        }

        private void gridViewData_ShownEditor(object sender, EventArgs e)
        {

        }



        private void gridViewData_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            doStuff();
        }



        private void gridViewData_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            

        }

        private void viewData()
        {
                btnViewData.Enabled = false;
                if (Convert.ToString(gridViewData.GetFocusedRowCellValue(colCarId)) != "")
                {
                    frmCarInfo oForm = new frmCarInfo();
                    oForm.Icon = fMain.Icon;
                    oForm.fMain = fMain;
                    oForm.CarId = Convert.ToString(gridViewData.GetFocusedRowCellValue(colCarId));

                    oForm.RefreshAll();
                    oForm.ShowDialog(this);
                    if (oForm.isSaved)
                    {
                        //loadData(true);
                        //loadData(false);
                        loadData();
                        loadCmb();
                    }
                    clsHelper.setGridMasterSelected(gridViewData, colCarId.FieldName, oForm.CarId);
                    oForm = null;
                if(clsGlobal.isClose == true)
                {
                    loadData();
                    loadCmb();
                }
              
                }
       

            btnViewData.Enabled = true;
        }

        private void gridViewData_DoubleClick(object sender, EventArgs e)
        {
            if (btnViewData.Enabled)
            {
                btnEdit_Click(sender, e);
            }
        }

       

        private void btnCreate_Click(object sender, EventArgs e)
        {
            btnViewData.Enabled = false;

            
                frmCarInfo oForm = new frmCarInfo();
                oForm.Icon = fMain.Icon;
                oForm.fMain = fMain;

                oForm.RefreshAll();
                oForm.ShowDialog(this);
                if (oForm.isSaved)
                {
                    loadData();
                }
                oForm = null;

            }

        private void btnView(object sender, EventArgs e)
        {
            viewData();
        }

        private void UCCar_Leave(object sender, EventArgs e)
        {
            frmMain.setLoadDialog(false, "");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (fMain != null)
            {
                fMain.barButtonItemCloseClick(true);
            }
        }

        private void gridViewData_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
        }

        private void riAvailable_EditValueChanged(object sender, EventArgs e)
        {

        }
      
        private void riAvailable_CheckedChanged(object sender, EventArgs e)
        {
            //if (XtraMessageBox.Show("Do you want to this action?", clsGlobal.pstrAppName, MessageBoxButtons.YesNo) != DialogResult.Yes)
            //{
                CheckEdit edit = (CheckEdit)sender;
                if (edit.Checked)
                {
                    status = true;

                }
                else
                {
                    status = false;
                }

            doStuff();
            
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
                        tbm_car oObject = new tbm_car();
                        oConn.Open();
                        oObject.Koneksi = oConn.Conn;
                        oObject.carid = Convert.ToString(gridViewData.GetFocusedRowCellValue(colCarId));
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
    }
}
