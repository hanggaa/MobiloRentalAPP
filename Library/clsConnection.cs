using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace Library
{
    public class clsConnection :IDisposable
    {
        private clsEncryption oEncryption = new clsEncryption();
        public NpgsqlConnection Conn = new NpgsqlConnection();
        private NpgsqlDataReader dr;

        private string m_Server = "";
        private string m_User = "";
        private string m_Password = "";
        private string m_Database = "";
        private string m_Port = "";

        public string Server
        {
            get { return m_Server; }
            set { m_Server = value; }
        }
        public string User
        {
            get { return m_User; }
            set { m_User = value; }
        }
        public string Password
        {
            get { return m_Password; }
            set { m_Password = value; }
        }
        public string Database
        {
            get { return m_Database; }
            set { m_Database = value; }
        }
        public string Port
        {
            get { return m_Port; }
            set { m_Port = value; }
        }
        public void Open()
        {
            clsRegKey oReg = new clsRegKey();
            oReg.RegistryPathCurrentUser = clsGlobal.s_FullRegKey;
            if (clsGlobal.firstConnect || string.IsNullOrEmpty(clsGlobal.str_Server))
            {
                clsGlobal.firstConnect = false;
            }
            m_Server = clsGlobal.str_Server;
            m_Database = clsGlobal.str_Database;
            m_Port = Convert.ToInt32(clsGlobal.str_Port) + "";
            m_User = clsGlobal.str_User;
            m_Password = clsGlobal.str_Password;

            string SConnString = "Server=" + clsGlobal.str_Server +
                ";Database=" + clsGlobal.str_Database +
                ";Port=" + Convert.ToInt32(clsGlobal.str_Port)+
                ";User ID=" + clsGlobal.str_User +
                ";Password=" + clsGlobal.str_Password +
                ";Pooling =false;";
            if(Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
            Conn.ConnectionString = SConnString;
            Conn.Open();
        }
        public void OpenTesting()
        {
            clsRegKey oReg = new clsRegKey();
            oReg.RegistryPathCurrentUser = clsGlobal.s_FullRegKey;

            string SConnString = "Server = " + Server +
                                 ";Database=" + Database +
                                 ";Port=" + Convert.ToInt32(Port) +
                                 ";Userid=" + User+
                                 ";Password=" + Password;


            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
            Conn.ConnectionString = SConnString;
            Conn.Open();
        }
        public bool TestConnection()
        {
            bool xResult = false;
            try
            {
                string SConnString = "Server=" + clsGlobal.str_Server +
                                     ";Database=" + clsGlobal.str_Database +
                                     ";Port=" + Convert.ToInt32(clsGlobal.str_Port) + "" +
                                     ";Userid=" + clsGlobal.str_User +
                                     ";Password=" + clsGlobal.str_Password;
                Conn.ConnectionString = SConnString;
                Conn.Open();

            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("Error Number : " + e.Code + "\n " + e.Message, clsGlobal.str_ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                xResult = false;
            }

            finally
            {
                Conn.Close();
            }
            return xResult;
        }
        public void Close()
        {
            Conn.Close();
        }
        public DataTable GetData(NpgsqlCommand cmd)
        {
            DataSet ds = new DataSet();
            DataTable dt = ds.Tables.Add("tblData");
            cmd.Connection = Conn;
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            Open();
            da.Fill(ds, "tblData");
            Close();
            return dt;
        }
        public DataTable GetData(string strSQL)
        {
            DataSet ds = new DataSet();
            DataTable dt = ds.Tables.Add("tblData");
            NpgsqlCommand cmd = new NpgsqlCommand(strSQL);

            try
            {
                cmd.Connection = Conn;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                Open();
                da.Fill(ds, "tblData");
                Close();
            }
            catch(NpgsqlException ex)
            {

            }
            return dt;
        }
        public void ExecuteCommand(NpgsqlCommand cmd)
        {
            cmd.Connection = Conn;
            Open();
            cmd.ExecuteNonQuery();
            Close();
        }
        public void ExecuteCommand(string strSQL)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = Conn;
                cmd.CommandText = strSQL;
                Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { }
            Close();
        }
        public NpgsqlDataReader ReadData(NpgsqlCommand cmd)
        {
            cmd.Connection = Conn;
            Open();
            dr = cmd.ExecuteReader();
            return dr;
        }
        public NpgsqlDataReader ReadData(string strSQL)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = strSQL;
            Open();
            dr = cmd.ExecuteReader();
            return dr;
        }
        #region "IDisposable"
        private bool disposed;
        ~clsConnection()
        {
            this.Dispose(false);
        }
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
            //throw new NotImplementedException();
        }
        protected virtual void Dispose(bool disposing)
        {
            try
            {
                if (!disposed)
                {
                    if (disposing)
                    {
                        //if (Conn.State == ConnectionState.Open)
                        //{
                        Conn.ClearPool();
                        Conn.Close();
                        //}
                        // Dispose= managed resources here.
                    }

                    // Dispose unmanaged resources here.
                }
            }
            catch
            {
            }
            disposed = true;
        }

        #endregion
    }
}
