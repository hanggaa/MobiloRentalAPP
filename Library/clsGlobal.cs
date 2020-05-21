using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using System.IO;
using System.Diagnostics;
using System.Reflection;

namespace Library
{
    public class clsGlobal
    {
        public static string strEmployeeName = "";
        public static string strGroupUser = "";
        public static string s_FullRegKey = "SOFTWARE\\MOBILO_RENTAL\\VERSION1";
        public static string s_SubKey = "";
        public static string s_RegKey = "";

        public static string str_Server = "localhost";
        public static string str_User = "postgres";
        public static string str_Password = "12345678";
        public static string str_Database = "db_mobilorental";
        public static string str_Port = "60766";

        public static string str_ApplicationName = "Mobilo Rental";
        public static string pstrAppName = str_ApplicationName;
        static string m_servercode;
        public static string pstrAppPath = Application.StartupPath;
        public static string pstrservercode = "MBR";
        
        public static bool firstConnect = true;
        public static string strUserName = "SuperAdmin";
        public static string strUserPassword = "";
        public static string strUserID = "";
        public static string strHakAkses = "";
        public static string strNamaPetugas = "";
        public static bool isusebackgroundimage = false;
        public static bool bolevaluationversion = false;
        public static bool isClose;
        public static string getData1Field(string strSQL)
        {
            string strHasil = "";
            try
            {
                clsConnection xconn = new clsConnection();
                xconn.Open();

                DataTable dt = new DataTable();
                NpgsqlCommand ocmd = new NpgsqlCommand();
                ocmd.Connection = xconn.Conn;
                ocmd.CommandType = CommandType.Text;
                ocmd.CommandText = strSQL;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(ocmd);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    strHasil = dt.Rows[0].ItemArray.GetValue(0).ToString();
                }
                xconn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return strHasil;
        }
        public static string getData1Field(NpgsqlCommand ocmd)
        {
            string strHasil = "";
            try
            {
                clsConnection xconn = new clsConnection();
                xconn.Open();
                DataTable dt = new DataTable();
                ocmd.Connection = xconn.Conn;
                ocmd.CommandType = CommandType.Text;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(ocmd);
                da.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    strHasil = dt.Rows[0].ItemArray.GetValue(0).ToString();
                }
                xconn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return strHasil;
        }
        public static DateTime getServerDate()
        {
            DateTime dateResult = DateTime.Now;
            try
            {
                DateTime.TryParse(getData1Field("select now()"), out dateResult);
            }
            catch (Exception)
            {

            }
            finally
            {

            }
            return dateResult;
        }
        #region Parsing Value
        public static Boolean GetParseBoolean(object strData)
        {
            Boolean m_Out;
            if (Convert.ToString(strData) == "1")
            {
                m_Out = true;
            }
            else
            {
                Boolean.TryParse(Convert.ToString(strData), out m_Out);
            }
            return m_Out;
        }
        public static DateTime GetParseDate(object strDate)
        {
            DateTime m_Out;
            DateTime.TryParse(Convert.ToString(strDate), out m_Out);
            return m_Out;
        }

        public static Decimal GetParseDecimal(object strDate)
        {
            Decimal m_Out;
            Decimal.TryParse(Convert.ToString(strDate), out m_Out);
            return m_Out;
        }

        public static Double GetParseDouble(object strDate)
        {
            Double m_Out;
            Double.TryParse(Convert.ToString(strDate), out m_Out);
            return m_Out;
        }

        public static int GetParseInt(object strDate)
        {
            int m_Out;
            int.TryParse(Convert.ToString(strDate), out m_Out);
            return m_Out;
        }
        public static byte[] GetParseByte(object strDate)
        {
            byte[] m_Out = null;
            try
            {
                m_Out = (byte[])strDate;
            }
            catch (Exception)
            { }
            return m_Out;
        }
        public static TimeSpan GetParseTimeSpan(object strDate)
        {
            string[] strArr = Convert.ToString(strDate).Split(':');
            TimeSpan m_Out = TimeSpan.Zero;
            if (strArr.Length > 2)
            {
                int jam = 0, menit = 0, detik = 0;
                int.TryParse(strArr[0], out jam); int.TryParse(strArr[1], out menit); int.TryParse(strArr[2], out detik);
                m_Out = new TimeSpan(jam, menit, detik);
            }
            return m_Out;
        }
        #endregion
        #region User Privillage
        static private bool m_superadmin, m_bolread, m_boladd, m_boledit,
                            m_boldelete, m_bolprint, m_bolsave, m_boldownload,
                            m_bolupload;

        static public bool bolRead
        {
            get { return m_bolread; }
            set { m_bolread = value; }
        }
        static public bool bolAdd
        {
            get { return m_boladd; }
            set { m_boladd = value;}
        }
        static public bool bolEdit
        {
            get { return m_boledit; }
            set { m_boledit = value; }
        }
        static public bool bolDelete
        {
            get { return m_boldelete; }
            set { m_boldelete = value; }
        }
        static public bool bolPrint
        {
            get { return m_bolprint; }
            set { m_bolprint = value; }
        }
        static public bool bolSave
        {
            get { return m_bolsave; }
            set { m_bolsave = value; }
        }
        static public bool bolDownload
        {
            get { return m_boldownload; }
            set { m_boldownload = value; }
        }
        static public bool bolUpload
        {
            get { return m_bolupload; }
            set { m_bolupload = value; }
        }
        static public DataTable dtCekAkses;
        static public bool CekAkses(string NamaModule, ref bool bolRead,
                                   ref bool bolAdd, ref bool boEdit,
                                   ref bool bolDelete, ref bool bolPrint,
                                   ref bool bolSave, ref bool bolDownload, ref bool bolUpload)
        {
            bool cekAkses;

            cekAkses = false;
            bolRead = false;
            bolAdd = false;
            bolEdit = false;
            bolDelete = false;
            bolPrint = false;
            bolSave = false;
            bolDownload = false;
            bolUpload = false;

            using (clsConnection oConn = new clsConnection())
            {
                if (strEmployeeName.ToLower() == "admin" || strGroupUser.ToLower() == "admin")
                {
                    cekAkses = true;
                    bolRead = true;
                    bolAdd = true;
                    boEdit = true;
                    bolDelete = true;
                    bolPrint = true;
                    bolSave = true;
                    bolDownload = true;
                    bolUpload = true;
                }
                else
                {
                    if(dtCekAkses == null)
                    {
                        NpgsqlCommand cmd = new NpgsqlCommand();
                        cmd.CommandText = @"SELECT a.usermoduleid, a.userid, a.moduleid, a.isread,
                                    a.isedit, a.isadd, a.isdelete, a.isprint, a.issave, a.isdownload, a.isupload, 
                                    b.module_nama
                                    FROM tbmusermodules a
                                    inner join tbmmodule b on a.moduleid=b.moduleid and b.dlt='0'
                                    Where a.dlt='0' and a.userid='" + strUserID + "'";
                        dtCekAkses = oConn.GetData(cmd);
                    }
                    foreach (DataRow Npdr in dtCekAkses.Select("module_nama='" + NamaModule.Replace("'", "''") + "'"))
                    {
                        bolRead = Convert.ToBoolean(Npdr["isread"]);
                        if (bolRead == false)
                        {
                            cekAkses = false;
                        }
                        else
                        {
                            cekAkses = true;
                            bolAdd = Convert.ToBoolean(Npdr["isadd"]);
                            boEdit = Convert.ToBoolean(Npdr["isedit"]);
                            bolDelete = Convert.ToBoolean(Npdr["isdelete"]);
                            bolPrint = Convert.ToBoolean(Npdr["isprint"]);
                            bolSave = Convert.ToBoolean(Npdr["issave"]);
                            bolDownload = Convert.ToBoolean(Npdr["isdownload"]);
                            bolUpload = Convert.ToBoolean(Npdr["isupload"]);
                        }
                    }
                }
            }
            return cekAkses;
        }
        #endregion
        #region Application Information
        #region GetFrameWork
        private const string FRAMEWORK_PATH = "\\MICROSOFT.NET\\FRAMEWORK";
        private const string WINDIR1 = "windir";
        private const string WINDIR2 = "SystemRoot";
        public static bool bo_login;

        public static string GetNetFrameWorkVersion
        {
            get
            {
                try
                {
                    return getHighestVersion(NetFrameworkInstallationPath);
                }
                catch (System.Security.SecurityException)
                {
                    return "Unknown";
                }
            }
        }
        private static string getHighestVersion(string installationPath)
        {
            string[] versions = Directory.GetDirectories(installationPath, "v*");
            string version = "Unknown";
            for(int i = version.Length -1; i >= 0; i--)
            {
                version = extractVersion(versions[i]);
                if (isNumber(version.Replace('.', '0').Trim()))
               return version;
            }
            return version;
        }
        private static string extractVersion(string directory)
        {
            int startIndex = directory.LastIndexOf("\\") + 2;
            return directory.Substring(startIndex, directory.Length - startIndex);
        }
        private static bool isNumber(string str)
        {
            return new System.Text.RegularExpressions.Regex(@"^[0-9]+\.?[0-9]*$").IsMatch(str);
        }
        public static string NetFrameworkInstallationPath
        {
            get { return WindowsPath + FRAMEWORK_PATH; }
        }
        public static string WindowsPath
        {
            get
            {
                string winDir = Environment.GetEnvironmentVariable(WINDIR1);
                if (string.IsNullOrEmpty(winDir))
                    winDir = Environment.GetEnvironmentVariable(WINDIR2);
                return winDir;
            }
        }
        #endregion
        public static string GetMacAddress()
        {
            string macAddresses = "";
            foreach( System.Net.NetworkInformation.NetworkInterface nic in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
            {
                if(nic.OperationalStatus == System.Net.NetworkInformation.OperationalStatus.Up)
                {
                    macAddresses += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }
            return macAddresses;
        }
        public static string s_LastUpdate()
        {
            string sfileversion = "";
            try
            {
                string sExeName = System.IO.Path.GetFileName(Application.ExecutablePath).ToString();
                sfileversion = getAssemblyInfo(sExeName);
                if (sfileversion == "")
                    sfileversion = getAssemblyInfo(sExeName);
                sfileversion = "Version :" + sfileversion + "LU:" + File.GetLastWriteTime(Application.ExecutablePath.ToString()).ToString("d/M/yyyy hh:mm tt");
            }
            catch
            {

            }
            return sfileversion;
        }
        public static string getAssemblyInfo(string assemblyFile)
        {
            string strVersion = "";
            try
            {
                AssemblyName asbInfo = AssemblyName.GetAssemblyName(assemblyFile);
                strVersion = asbInfo.Version.Major + "." + asbInfo.Version.MajorRevision + "." + asbInfo.Version.Minor + "." + asbInfo.Version.Minor;
            }
            catch
            {
                strVersion = "";
            }
            return strVersion;
        }
        public static string getVersionInfo(string fileName)
        {
            string strVersion = "";
            try
            {
                FileVersionInfo fvInfo = FileVersionInfo.GetVersionInfo(fileName);
                strVersion = fvInfo.FileMajorPart + "." + fvInfo.FileMinorPart + "." + fvInfo.FileBuildPart + "." + fvInfo.FilePrivatePart;
            }
            catch
            {
                strVersion = "";
            }
            return strVersion;
        }
        static public string strComputerName()
        {
            return System.Windows.Forms.SystemInformation.ComputerName;
        }
        static public string strIPAddress()
        {
            string sCode = "";
            string myHost = System.Net.Dns.GetHostName();
            System.Net.IPHostEntry myIps = System.Net.Dns.GetHostEntry(myHost);
            foreach(System.Net.IPAddress myIp in myIps.AddressList)
            {
                if(myIp.AddressFamily.ToString() == "InterNetwork")
                {
                    sCode = myIp.ToString();// ipv4
                    break;
                }
            }
            return sCode;
        }
        #endregion Application Information

        public static void xpatchDatabase()
        {
            try
            {
                string strSql = @"CREATE TABLE tbmmodule (
                    moduleid varchar(100) NOT NULL,
                    module_nama varchar(150),
                    ket varchar(200),
                    groupcode varchar(250),
                    groupname varchar(200),
                    op varchar(30),
                    pc varchar(30),
                    lu timestamp(6) DEFAULT now(),
                    dlt bool DEFAULT false,
                    isprintable bool DEFAULT false,
                    isdownloadable bool DEFAULT false,
                    isforceableedit bool DEFAULT false,
                    CONSTRAINT tbmmodule_pkey PRIMARY KEY (moduleid)
                    );

                    CREATE SEQUENCE tbmmodule_nextid;
                    CREATE INDEX tbmmodule_module_nama ON tbmmodule USING btree (module_nama);

                    CREATE TABLE tbmusermodules (
                    usermoduleid varchar(20) NOT NULL,
                    moduleid varchar(100),
                    userid varchar(20),
                    isread bool DEFAULT false,
                    isadd bool DEFAULT false,
                    isedit bool DEFAULT false,
                    isdelete bool DEFAULT false,
                    issave bool DEFAULT false,
                    isprint bool DEFAULT false,
                    op varchar(30),
                    pc varchar(30),
                    lu timestamp(6) DEFAULT now(),
                    dlt bool DEFAULT false,
                    isdownload bool DEFAULT false,
                    isupload bool DEFAULT false,
                    CONSTRAINT tbmusermodules_pkey PRIMARY KEY (usermoduleid)
                    );

                    CREATE SEQUENCE tbmusermodules_nextid;


                    CREATE INDEX tbmusermodules_dlt ON tbmusermodules USING btree (dlt);

                    CREATE INDEX tbmusermodules_moduleid ON tbmusermodules USING btree (moduleid);

                    CREATE INDEX tbmusermodules_userid ON tbmusermodules USING btree (userid);

                    CREATE INDEX tbmusermodules_usermoduleid ON tbmusermodules USING btree (usermoduleid);";
                xsetupdatedatabase(strSql);
            }
            catch
            {
            }
        }

        public static void xsetupdatedatabase(string strSql)
        {
            try
            {
                clsRegKey oReg = new clsRegKey();
                oReg.RegistryPathCurrentUser = clsGlobal.s_FullRegKey;
                using(clsConnection oConn = new clsConnection())
                {
                    oConn.Open();
                    NpgsqlCommand ocmd = new NpgsqlCommand();
                    ocmd = new NpgsqlCommand();
                    ocmd.Connection = oConn.Conn;
                    ocmd.CommandText = strSql;
                    ocmd.ExecuteNonQuery();
                    oConn.Close();
                }
            }
            catch(Exception ex)
            {
                //throw
            }
        }

    }
}