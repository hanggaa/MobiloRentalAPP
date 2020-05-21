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

namespace MobiloRental.Master_Data
{
    public partial class UCCarType : DevExpress.XtraEditors.XtraUserControl
    {
        RepositoryItemComboBox cmbCategory;
        public UCCarType()
        {
            frmMain.setLoadDialog(true, "Loading Components...");
            InitializeComponent();
            frmMain.setLoadDialog(false, "");
            //cmbCategory.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            //dgData.RepositoryItems.Add(cmbCategory);
            //gridViewData.CustomRowCellEdit += gridViewData_CustomRowCellEdit;
            
        }

        public frmMain fMain;
        public void Refresh()
        {
            base.Refresh();
            btnEdit.Enabled = clsGlobal.bolAdd || clsGlobal.bolEdit;
            btnDelete.Enabled = clsGlobal.bolDelete;
            loadData();
        }
        private void gridViewData_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {

            for (int i = 0; i < gridViewData.RowCount; i++)
            {
                DataRowView row = gridViewData.GetRow(i) as DataRowView;
                if (row != null)
                {
                    if (e.Column.FieldName == "categoryname")
                        if (e.RowHandle == i)
                            e.RepositoryItem = cmbCategory;
                }
            }
        
        }
        private void loadCmb()
        {
            try
            {
                using (clsConnection oConn = new clsConnection())
                {
                    NpgsqlCommand ocmd = new NpgsqlCommand();
                    string strSqlCategory = @"select carcategoryname as categoryname from tbm_carcategory where dlt='0'";
                    string strSqlBrand = @"select brandname from tbm_carbrand where dlt='0'";
                    DataTable dtCategory = oConn.GetData(strSqlCategory);
                    DataTable dtBrand = oConn.GetData(strSqlBrand);
            foreach (DataRow row in dtCategory.Rows)
                    {
                        ricmbCategory.Items.Add(row["categoryname"]);
                    }
            foreach(DataRow row in dtBrand.Rows)
                    {
                        ricmbBrand.Items.Add(row["brandname"]);
                    }
                }
            }
            catch
            {

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

                    //List<Char> getCategory = new List<char>();
                    //   var getCategory= oConn.ReadData("select carcategoryname from tbm_carcategory").ToString().ToList();
                    //ricmbCategory.Items.Add(getCategory);
                    string strSql = @"select a.typeid, a.carcategoryid as categoryid,a.carbrandid as brandid, a.typename,
                                b.carcategoryid as categoryids,b.carcategoryname as categoryname,
                                c.carbrandid as brandids, c.brandname 
                                from tbm_cartype a
                                left join tbm_carcategory b on b.carcategoryid = a.carcategoryid and b.dlt='0' 
                                left join tbm_carbrand c on c.carbrandid = a.carbrandid and c.dlt='0'
                                where a.dlt ='0' order by a.typeid;";
                    DataTable dtData = oConn.GetData(strSql);
                    dgData.DataSource = dtData;


                    //string strSqlCategory = clsGlobal.getData1Field("select carcategoryid from tbm_carcategory where carcategoryname='" + Convert.ToString(gridViewData.GetFocusedRowCellValue(colCategoryname)) + "'");

                    //DataTable categoryData = oConn.GetData(getCategoryValue);
                    //DataTable brandData = oConn.GetData(getBrandValue);
                    loadCmb();

                    gridViewData.Columns[1].ColumnEdit = ricmbCategory;
                    gridViewData.Columns[2].ColumnEdit = ricmbBrand;
                  
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
                        tbm_cartype oObject = new tbm_cartype();
                        oConn.Open();
                        oObject.Koneksi = oConn.Conn;
                        oObject.typeid = Convert.ToString(gridViewData.GetFocusedRowCellValue(colTypeid));
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
                    string typeid = Convert.ToString(gridViewData.GetFocusedRowCellValue(colTypeid));
                    string strCount = clsGlobal.getData1Field("select count(*) from tbm_cartype where dlt='0' and trim(lower(typename))=trim(lower('" + Convert.ToString(gridViewData.GetFocusedRowCellValue(colTypename)) + "')) and typeid <>'" + typeid + "'");
                    if (Convert.ToInt32(strCount) == 0)
                    {
                        tbm_cartype oObject = new tbm_cartype();
                        oConn.Open();
                        oObject.Koneksi = oConn.Conn;
                        if (!string.IsNullOrEmpty(typeid))
                        {
                            oObject.GetByPrimaryKey(typeid);
                        }
                        string categoryid = clsGlobal.getData1Field("select  carcategoryid from tbm_carcategory where carcategoryname='" + Convert.ToString(gridViewData.GetFocusedRowCellValue(colCategoryname)) + "'");
                        string brandid = clsGlobal.getData1Field("select carbrandid from tbm_carbrand where brandname='" + Convert.ToString(gridViewData.GetFocusedRowCellValue(colBrandname)) + "'");
                        oObject.typeid = Convert.ToString(gridViewData.GetFocusedRowCellValue(colTypeid));
                        oObject.categoryid = categoryid;
                        oObject.brandid = brandid;
                        oObject.typename = Convert.ToString(gridViewData.GetFocusedRowCellValue(colTypename));

                        if (oObject.categoryname == "")
                        {
                            XtraMessageBox.Show("Data Can't Be Null", "Warning");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(typeid))
                            {
                                oObject.typeid = oObject.NewID();
                                oObject.opadd = clsGlobal.strUserName;
                                oObject.pcadd = SystemInformation.ComputerName;
                                oObject.luadd = DateTime.Now;
                                oObject.Insert();
                                gridViewData.SetFocusedRowCellValue(colTypeid, oObject.typeid);
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
                        e.ErrorText = "This code " + Convert.ToString(gridViewData.GetFocusedRowCellValue(colTypename)) + " already exists in database and cannot be filled the same value.!\n";
                        gridViewData.FocusedColumn = colTypename;
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

        private void gridViewData_ShownEditor(object sender, EventArgs e)
        {

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
