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
    public partial class UCUser : DevExpress.XtraEditors.XtraUserControl
    {
        public UCUser()
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
                clsEncryption oEncryption = new clsEncryption();
                using (clsConnection oConn = new clsConnection())
                {
                    NpgsqlCommand ocmd = new NpgsqlCommand();
                    frmMain.setLoadDialog(true, "Loading data...");

                    string strSql = @"select userid, username, password,fullname,email,groupusers,active
                                    from tbm_users
                                    where dlt='0'
                                    order by groupusers";
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
            loadGroupUsers();
        }
        
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void gcontrolUsers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UCUser_Load(object sender, EventArgs e)
        {

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
            Refresh();
        }

        private void loadGroupUsers()
        {
            Dictionary<int, string> Gender = new Dictionary<int, string>()
                                            {
                                                {1,"Admin"},
                                                {2, "Frontuser"},
                                            };
            foreach (KeyValuePair<int, string> item in Gender)
            {
                ricmbGroup.Items.Add(item.Value);
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
                        tbm_users oObject = new tbm_users();
                        oConn.Open();
                        oObject.Koneksi = oConn.Conn;
                        oObject.userid = Convert.ToString(gridViewData.GetFocusedRowCellValue(colUserId));
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
                    string strID = Convert.ToString(gridViewData.GetFocusedRowCellValue(colUserId));
                    string strPassword = Convert.ToString(gridViewData.GetFocusedRowCellValue(colPassword));
                    string strUsername = Convert.ToString(gridViewData.GetFocusedRowCellValue(colUsername));
                    string strCount = clsGlobal.getData1Field("select count(*) from tbm_users where dlt='0' and trim(lower(username))=trim(lower('" + Convert.ToString(gridViewData.GetFocusedRowCellValue(colUsername)) + "')) and userid<>'" + strID + "'");
                    string strGetPassword = clsGlobal.getData1Field("select password from tbm_users where userid='" + strID + "'");
                    string strGetUsername = clsGlobal.getData1Field("select username from tbm_users where userid='" + strID + "'");

                    if (Convert.ToInt32(strCount) == 0)
                    {
                        tbm_users oObject = new tbm_users();
                        oConn.Open();
                        oObject.Koneksi = oConn.Conn;
                        if (!string.IsNullOrEmpty(strID))
                        {
                            oObject.GetByPrimaryKey(strID);
                        }
                        clsEncryption oEncryption = new clsEncryption();
                        if(strPassword == strGetPassword)
                        {
                            oObject.password = strGetPassword;
                        }
                        else
                        {
                            oObject.password = oEncryption.Encrypt(strPassword);
                        }
                        if (strUsername== strGetUsername)
                        {
                            oObject.username = strGetUsername;
                        }
                        else
                        {
                            oObject.username = oEncryption.Encrypt(strUsername);
                        }
                        oObject.userid =  Convert.ToString(gridViewData.GetFocusedRowCellValue(colUserId));
                        oObject.fullname = Convert.ToString(gridViewData.GetFocusedRowCellValue(colFullname));
                        oObject.email = Convert.ToString(gridViewData.GetFocusedRowCellValue(colEmail));
                        oObject.groupusers = Convert.ToString(gridViewData.GetFocusedRowCellValue(colGroupUsers)).ToLower();
                        if ( oObject.username == "" || oObject.password == "" || oObject.fullname == "" || oObject.email == "" || oObject.groupusers == "")
                        {
                            XtraMessageBox.Show("Data Can't Be Null", "Warning");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(strID))
                            {
                                oObject.userid = oObject.NewID();
                                oObject.active = true;
                                oObject.opadd = clsGlobal.strUserName;
                                oObject.pcadd = SystemInformation.ComputerName;
                                oObject.luadd = DateTime.Now;
                                oObject.Insert();
                                gridViewData.SetFocusedRowCellValue(colUserId, oObject.userid);
                            }
                            else
                            {
                                oObject.active = Convert.ToBoolean(gridViewData.GetFocusedRowCellValue(colActive));
                                oObject.opedit = clsGlobal.strUserName;
                                oObject.pcedit = SystemInformation.ComputerName;
                                oObject.Update();
                            }
                            oObject = null;
                            e.Valid = true;
                        }
                       
                    }
                    else
                    {
                        e.ErrorText = "This code " + Convert.ToString(gridViewData.GetFocusedRowCellValue(colUserId)) + " already exists in database and cannot be filled the same value.!\n";
                        gridViewData.FocusedColumn = colUsername;
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
