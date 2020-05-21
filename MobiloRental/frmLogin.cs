using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Npgsql;
using Library;

namespace MobiloRental
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        #region Value Property
        bool activation = false;
        #endregion Value Property
        clsConnection oconn = new clsConnection();
        private clsEncryption oEncryption = new clsEncryption();

       


        private void hlServerInitialize_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            frmServerInitialize frm = new frmServerInitialize();
            frm.ShowDialog(this);
        }

        private void oRegistry()
        {
            clsRegKey oRegKey = new clsRegKey();
            oRegKey.RegistryPathCurrentUser = clsGlobal.s_FullRegKey;
            oRegKey = null;
        }
       private void Login(string strUsername, string strPassword)
        {
            try
            {
                clsEncryption oEncryption = new clsEncryption();
                using(clsConnection oconn = new clsConnection())
                {
                    NpgsqlCommand ocmd = new NpgsqlCommand();
                    oconn.Open();
                    ocmd.Connection = oconn.Conn;
                   
                    ocmd = new NpgsqlCommand();
                    ocmd.Connection = oconn.Conn;
                    bool isActive = true;
                   string strsql = @"select userid, username, fullname,email, groupusers from tbm_users where username=@username and password=@password and dlt='0' and active='1'";
                    ocmd.Parameters.Add("@username", NpgsqlTypes.NpgsqlDbType.Varchar).Value = oEncryption.Encrypt(strUsername.ToString().ToUpper());
                    ocmd.Parameters.Add("@password", NpgsqlTypes.NpgsqlDbType.Varchar).Value = oEncryption.Encrypt(strPassword.ToString());
                     ocmd.CommandText = strsql;
                    NpgsqlDataReader dr;
                    dr = ocmd.ExecuteReader();
                    if (dr.Read())
                    {
                        clsRegKey oRegKey = new clsRegKey();
                        oRegKey.RegistryPathCurrentUser = clsGlobal.s_FullRegKey;
                        oRegKey = null;
                        clsGlobal.strUserName = oEncryption.Decrypt(dr["username"].ToString());
                        clsGlobal.strUserID = dr["userid"].ToString();
                        clsGlobal.strHakAkses = dr["groupusers"].ToString();
                        clsGlobal.strNamaPetugas = dr["fullname"].ToString();
                        clsGlobal.strUserPassword = txtPassword.Text;
                        clsGlobal.strGroupUser = dr["groupusers"].ToString();
                    } 
                    else
                    {
                        XtraMessageBox.Show("Invalid username or password .!", clsGlobal.str_ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        strPassword = "";
                        oconn.Close();
                        ocmd = null;
                        oEncryption = null;
                        return;
                    }
                    oconn.Close();
                    ocmd = null;
                }
                oEncryption = null;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Unable connect to database server, please configure the database connection first", clsGlobal.str_ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmServerInitialize frm = new frmServerInitialize();
                frm.ShowDialog(this);
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
            else if(e.KeyCode == Keys.Tab)
            {
                btnLogin.Focus();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult != System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
                Environment.Exit(1);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            try
            {
                clsRegKey oReg = new clsRegKey();
                clsEncryption oEncryption = new clsEncryption();
                oReg.RegistryPathCurrentUser = clsGlobal.s_FullRegKey;
                clsGlobal.str_Server = oReg.getSetting("Server");
                clsGlobal.str_User = oEncryption.Decrypt(oReg.getSetting("User"));
                clsGlobal.str_Password = oEncryption.Decrypt(oReg.getSetting("Password"));
                clsGlobal.str_Database = oReg.getSetting("Database");
                clsGlobal.str_Port = oReg.getSetting("Port");
                oReg = null;
                oEncryption = null;
    
            }
            catch (NpgsqlException ex)
            {
                XtraMessageBox.Show("Unable connect to database server, please configure the database connection first", clsGlobal.str_ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmServerInitialize frm = new frmServerInitialize();
                frm.ShowDialog(this);
                frm = null;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Could not write/read Registry System.!\nCall Your System Administrator\n", clsGlobal.str_ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(txtUsername.Text) == "")
            {
                XtraMessageBox.Show("Username tidak boleh kosong!", clsGlobal.str_ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsername.Focus();
                return;
            }
            else if (Convert.ToString(txtPassword.Text) == "")
            {
                XtraMessageBox.Show("Password tidak boleh kosong!", clsGlobal.str_ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
                return;
            }
            Login(txtUsername.Text, txtPassword.Text);
        }

        private void btnExit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                btnExit.Focus();
            }
        }
    }
}
