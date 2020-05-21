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
    public partial class frmServerInitialize : Form
    {
        public frmServerInitialize()
        {
            InitializeComponent();
        }
        clsConnection oconn = new clsConnection();
        clsRegKey oReg = new clsRegKey();
        private clsEncryption oEncryption = new clsEncryption();

        private void btnTry_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection cn = new NpgsqlConnection("Server=" + txtServer.Text + ";User Id=" + txtUsername.Text + ";Password=" + txtpassword.Text + ";Database=postgres;Port=" + txtPort.Text + "");

                cn.Open();
                string strSql;

                strSql = "SELECT datname as database FROM pg_database where datname not like '%template%' order by datname";
                NpgsqlCommand cmd = new NpgsqlCommand(strSql, cn);

                //NpgsqlDataReader  rdr ;//= new  NpgsqlDataReader();

                //rdr = cmd.ExecuteReader();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);
                //txtDatabaseName.DataSource = dt;
                //txtDatabaseName.DisplayMember = "datname";

                //da.Fill(dt);
                cboDatabase.Properties.DataSource = dt;
                cboDatabase.Properties.DisplayMember = "database";
                cboDatabase.Properties.ValueMember = "database";
                cn.Close();
                XtraMessageBox.Show("Connection Success !", clsGlobal.str_ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (dt.Rows.Count > 0)
                {
                    cboDatabase.Text = "";
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Could not connect to the server .!\nCall Your System Administrator\n", clsGlobal.str_ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                oconn.Server = txtServer.Text;
                oconn.User = txtUsername.Text;
                oconn.Password = txtpassword.Text;
                oconn.Database = cboDatabase.Text;
                oconn.Port = txtPort.Text;

                oconn.OpenTesting();
                XtraMessageBox.Show("Congratulation\n You have been connected to server : " + txtServer.Text, clsGlobal.str_ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                oReg.SaveSetting("Server", txtServer.Text);
                oReg.SaveSetting("User", oEncryption.Encrypt(txtUsername.Text));
                oReg.SaveSetting("Password", oEncryption.Encrypt(txtpassword.Text));
                oReg.SaveSetting("Database", cboDatabase.Text);
                oReg.SaveSetting("Port", txtPort.Text);

                oconn.Server = oReg.getSetting("Server");
                oconn.User = oReg.getSetting("User");
                oconn.Password = oReg.getSetting("Password");
                oconn.Database = oReg.getSetting("Database");
                oconn.Port = oReg.getSetting("Port");

                clsGlobal.str_Server = oconn.Server;
                clsGlobal.str_User = txtUsername.Text;
                clsGlobal.str_Password = txtpassword.Text;
                clsGlobal.str_Database = oconn.Database;
                clsGlobal.str_Port = oconn.Port;

                oconn.Close();
                this.Dispose();
            }
            catch (Exception ee)
            {
                XtraMessageBox.Show("Could not connect to the server .!\nCall Your System Administrator\n", clsGlobal.str_ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ServerInitialize_Load(object sender, EventArgs e)
        {
            try
            {
                oReg.RegistryPathCurrentUser = clsGlobal.s_FullRegKey;

                txtServer.Text = oReg.getSetting("Server");
                txtUsername.Text = oEncryption.Decrypt(oReg.getSetting("User"));
                txtpassword.Text = oEncryption.Decrypt(oReg.getSetting("Password"));
                cboDatabase.Properties.NullText = oReg.getSetting("Database");
                txtPort.Text = oReg.getSetting("Port");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Could not write/read Registry System.!\nCall Your System Administrator\n", clsGlobal.str_ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if(txtUsernameUnlock.Text.ToLower() == "mobiloserver" && txtPasswordUnlock.Text.ToLower() == "mobilo")
            {
                groupControl1.Enabled = true;
                groupControl2.Visible = false;
            }
        }

        private void txtPasswordUnlock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton2_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Tab)
            {
                simpleButton2.Focus();
            }
        }
    }
}
