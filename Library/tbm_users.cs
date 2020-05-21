using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class tbm_users
    {
        private String m_userid;
        private String m_username;
        private String m_password;
        private String m_fullname;
        private String m_email;
        private String m_groupusers;
        private Boolean m_active;
        private String m_opadd;
        private String m_pcadd;
        private DateTime m_luadd;
        private String m_opedit;
        private String m_pcedit;
        private DateTime m_luedit;
        private bool m_dlt;
        private Npgsql.NpgsqlConnection m_Koneksi;
        clsEncryption oEncryption = new clsEncryption();

        public String userid
        {
            get { return m_userid; }
            set { m_userid = value; }
        }

        public String username
        {
            get { return m_username; }
            set { m_username = value; }
        }
        public String password
        {
            get { return m_password; }
            set { m_password = value; }
        }
        public String fullname
        {
            get { return m_fullname; }
            set { m_fullname = value; }
        }
        public String email
        {
            get { return m_email; }
            set { m_email = value; }
        }

        public String groupusers
        {
            get { return m_groupusers; }
            set { m_groupusers = value; }
        }
        public bool active
        {
            get { return m_active; }
            set { m_active = value; }
        }
        public String opadd
        {
            get { return m_opadd; }
            set { m_opadd = value; }
        }
        public String pcadd
        {
            get { return m_pcadd; }
            set { m_pcadd = value; }
        }
        public DateTime luadd
        {
            get { return m_luadd; }
            set { m_luadd = value; }
        }
        public String opedit
        {
            get { return m_opedit; }
            set { m_opedit = value; }
        }
        public String pcedit
        {
            get { return m_pcedit; }
            set { m_pcedit = value; }
        }
        public DateTime luedit
        {
            get { return m_luedit; }
            set { m_luedit = value; }
        }
        public bool dlt
        {
            get { return m_dlt; }
            set { m_dlt = value; }
        }
        public Npgsql.NpgsqlConnection Koneksi
        {
            get { return m_Koneksi; }
            set { m_Koneksi = value; }
        }

        public bool Insert()
        {
            string sQuery = "Insert into tbm_users(userid,username,password,fullname,email,groupusers,active,opadd,pcadd,luadd,dlt)"+"VALUES"+
                "(@userid,@username,@password,@fullname,@email,@groupusers,@active,@opadd,@pcadd,now(),@dlt)";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            if(userid != null)
            {
                cmd.Parameters.Add("@userid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = userid; 
            }
            else {
                cmd.Parameters.Add("@userid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if(username != null)
            {
                cmd.Parameters.Add("@username", NpgsqlTypes.NpgsqlDbType.Varchar).Value = oEncryption.Encrypt(username.ToString().ToUpper());;
            }
            else
            {
                cmd.Parameters.Add("@username", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if(password != null)
            {
                cmd.Parameters.Add("@password", NpgsqlTypes.NpgsqlDbType.Varchar).Value = oEncryption.Encrypt(password.ToString());
            }
            else
            {
                cmd.Parameters.Add("@password", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (fullname != null)
            {
                cmd.Parameters.Add("@fullname", NpgsqlTypes.NpgsqlDbType.Varchar).Value = fullname;
            }
            else
            {
                cmd.Parameters.Add("@fullname", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if(email != null)
            {
                cmd.Parameters.Add("@email", NpgsqlTypes.NpgsqlDbType.Varchar).Value = email;
            }
            else
            {
                cmd.Parameters.Add("@email", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if(groupusers != null)
            {
                cmd.Parameters.Add("@groupusers", NpgsqlTypes.NpgsqlDbType.Varchar).Value = groupusers;
            }
            else
            {
                cmd.Parameters.Add("@groupusers", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            cmd.Parameters.Add("@active", NpgsqlTypes.NpgsqlDbType.Boolean).Value = active;
            if (opadd != null)
            {
                cmd.Parameters.Add("@opadd", NpgsqlTypes.NpgsqlDbType.Varchar).Value = opadd;
            }
            else
            {
                cmd.Parameters.Add("@opadd", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (pcadd != null)
            {
                cmd.Parameters.Add("@pcadd", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pcadd;
            }
            else
            {
                cmd.Parameters.Add("@pcadd", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (luadd != null && luadd != DateTime.MinValue)
            {
                cmd.Parameters.Add("@luadd", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = luadd;
            }
            else
            {
                cmd.Parameters.Add("@luadd", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = DBNull.Value;
            }
            if (opedit != null)
            {
                cmd.Parameters.Add("@opedit", NpgsqlTypes.NpgsqlDbType.Varchar).Value = opedit;
            }
            else
            {
                cmd.Parameters.Add("@opedit", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (pcedit != null)
            {
                cmd.Parameters.Add("@pcedit", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pcedit;
            }
            else
            {
                cmd.Parameters.Add("@pcedit", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (luedit != null && luedit != DateTime.MinValue)
            {
                cmd.Parameters.Add("@luedit", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = luedit;
            }
            else
            {
                cmd.Parameters.Add("@luedit", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = DBNull.Value;
            }
            cmd.Parameters.Add("@dlt", NpgsqlTypes.NpgsqlDbType.Boolean).Value = dlt;
            cmd.CommandText = sQuery;
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(Npgsql.NpgsqlException Ex)
            {
                System.Windows.Forms.MessageBox.Show(Ex.Message, "An error occurred while processing!!!");
                return false;
            }
        }
        public bool Update()
        {
            string sQuery = "UPDATE tbm_users SET " +
                "username=@username,password=@password,fullname=@fullname,email=@email,groupusers=@groupusers,active=@active,dlt=@dlt,opedit=@opedit,pcedit=@pcedit,luedit=now()" +
                "WHERE userid=@userid";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            if (userid != null)
            {
                cmd.Parameters.Add("@userid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = userid;
            }
            else {
                cmd.Parameters.Add("@userid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (username != null)
            {
                cmd.Parameters.Add("@username", NpgsqlTypes.NpgsqlDbType.Varchar).Value = username;
            }
            else
            {
                cmd.Parameters.Add("@username", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (password != null)
            {
                cmd.Parameters.Add("@password", NpgsqlTypes.NpgsqlDbType.Varchar).Value = password;
            }
            else
            {
                cmd.Parameters.Add("@password", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (fullname != null)
            {
                cmd.Parameters.Add("@fullname", NpgsqlTypes.NpgsqlDbType.Varchar).Value = fullname;
            }
            else
            {
                cmd.Parameters.Add("@fullname", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (email != null)
            {
                cmd.Parameters.Add("@email", NpgsqlTypes.NpgsqlDbType.Varchar).Value = email;
            }
            else
            {
                cmd.Parameters.Add("@email", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (groupusers != null)
            {
                cmd.Parameters.Add("@groupusers", NpgsqlTypes.NpgsqlDbType.Varchar).Value = groupusers;
            }
            else
            {
                cmd.Parameters.Add("@groupusers", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (opedit != null)
            {
                cmd.Parameters.Add("@opedit", NpgsqlTypes.NpgsqlDbType.Varchar).Value = opedit;
            }
            else
            {
                cmd.Parameters.Add("@opedit", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (pcedit != null)
            {
                cmd.Parameters.Add("@pcedit", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pcedit;
            }
            else
            {
                cmd.Parameters.Add("@pcedit", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (luedit != null && luedit != DateTime.MinValue)
            {
                cmd.Parameters.Add("@luedit", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = luedit;
            }
            else
            {
                cmd.Parameters.Add("@luedit", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = DBNull.Value;
            }
            cmd.Parameters.Add("@active", NpgsqlTypes.NpgsqlDbType.Boolean).Value = active;
            cmd.Parameters.Add("@dlt", NpgsqlTypes.NpgsqlDbType.Boolean).Value = dlt;
            cmd.CommandText = sQuery;
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Npgsql.NpgsqlException Ex)
            {
                System.Windows.Forms.MessageBox.Show(Ex.Message, "An error occurred while processing!!!");
                return false;
            }
        }
        public bool Delete()
        {
            string sQuery = " DELETE FROM tbm_users WHERE userid=@userid";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            cmd.Parameters.Add("@jenispajakid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = userid;
            cmd.CommandText = sQuery;
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Npgsql.NpgsqlException Ex)
            {
                System.Windows.Forms.MessageBox.Show(Ex.Message, "An error occurred while processing!!!");
                return false;
            }
        }
        public bool SoftDelete()
        {
            string sQuery = "Update tbm_users set dlt=true,active=false,opedit=@opedit,pcedit=@pcedit,luedit=now()" +
                "where userid=@userid";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            cmd.CommandText = sQuery;
            cmd.Parameters.Add("@userid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = userid;
            cmd.Parameters.Add("@opedit", NpgsqlTypes.NpgsqlDbType.Varchar).Value = clsGlobal.strUserName;
            cmd.Parameters.Add("@pcedit", NpgsqlTypes.NpgsqlDbType.Varchar).Value = System.Windows.Forms.SystemInformation.ComputerName;
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Npgsql.NpgsqlException Ex)
            {
                System.Windows.Forms.MessageBox.Show(Ex.Message, "An error occurred while processing!!!");
                return false;
            }
        }

        public bool GetByPrimaryKey(string pKey)
        {
            string sQuery = "select * from tbm_users WHERE userid='" + pKey + "'";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            cmd.CommandText = sQuery;
            Npgsql.NpgsqlDataReader rdr = cmd.ExecuteReader();
            try
            {
                if (rdr.Read())
                {
                    if (!rdr.IsDBNull(rdr.GetOrdinal("userid")))
                    {
                        m_userid = rdr.GetString(rdr.GetOrdinal("userid"));
                    }
                    else
                    {
                        m_userid = "";
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("username")))
                    {
                        m_username = rdr.GetString(rdr.GetOrdinal("username"));
                    }
                    else
                    {
                        m_username = "";
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("password")))
                    {
                        m_password = rdr.GetString(rdr.GetOrdinal("password"));
                    }
                    else
                    {
                        m_password = "";
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("password")))
                    {
                        m_password = rdr.GetString(rdr.GetOrdinal("password"));
                    }
                    else
                    {
                        m_password = "";
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("fullname")))
                    {
                        m_fullname = rdr.GetString(rdr.GetOrdinal("fullname"));
                    }
                    else
                    {
                        m_fullname= "";
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("email")))
                    {
                        m_email = rdr.GetString(rdr.GetOrdinal("email"));
                    }
                    else
                    {
                        m_email = "";
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("groupusers")))
                    {
                        m_groupusers = rdr.GetString(rdr.GetOrdinal("groupusers"));
                    }
                    else
                    {
                        m_groupusers = "";
                    };


                    if (!rdr.IsDBNull(rdr.GetOrdinal("opadd")))
                    {
                        m_opadd = rdr.GetString(rdr.GetOrdinal("opadd"));
                    }
                    else
                    {
                        m_opadd = "";
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("pcadd")))
                    {
                        m_pcadd = rdr.GetString(rdr.GetOrdinal("pcadd"));
                    }
                    else
                    {
                        m_pcadd = "";
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("luadd")))
                    {
                        m_luadd = rdr.GetDateTime(rdr.GetOrdinal("luadd"));
                    }
                    else
                    {
                        m_luadd = System.DateTime.MinValue;
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("opedit")))
                    {
                        m_opedit = rdr.GetString(rdr.GetOrdinal("opedit"));
                    }
                    else
                    {
                        m_opedit = "";
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("pcedit")))
                    {
                        m_pcedit = rdr.GetString(rdr.GetOrdinal("pcedit"));
                    }
                    else
                    {
                        m_pcedit = "";
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("luedit")))
                    {
                        m_luedit = rdr.GetDateTime(rdr.GetOrdinal("luedit"));
                    }
                    else
                    {
                        m_luedit = System.DateTime.MinValue;
                    };
                    m_dlt = rdr.GetBoolean(rdr.GetOrdinal("dlt"));
                    m_active = rdr.GetBoolean(rdr.GetOrdinal("active"));
                }
                return true;
            }
            catch (Npgsql.NpgsqlException Ex)
            {
                System.Windows.Forms.MessageBox.Show(Ex.Message, "An error occurred while processing!!!");
                return false;
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
            }
        }
        public System.Data.DataTable GetData(Npgsql.NpgsqlCommand cmd)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            System.Data.DataTable dt = ds.Tables.Add("tbm_users");
            cmd.Connection = Koneksi;
            Npgsql.NpgsqlDataAdapter da = new Npgsql.NpgsqlDataAdapter(cmd);
            da.Fill(ds, "tbm_users");
            return dt;
        }

        public System.Data.DataTable GetData(string strSQL)
        {
            if (strSQL == "")
            {
                strSQL = "select * from tbm_users";
            }
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(strSQL, Koneksi);
            System.Data.DataSet ds = new System.Data.DataSet();
            System.Data.DataTable dt = ds.Tables.Add("tbm_users");
            Npgsql.NpgsqlDataAdapter da = new Npgsql.NpgsqlDataAdapter(cmd);
            da.Fill(ds, "tbm_users");
            return dt;
        }
        public Npgsql.NpgsqlDataReader ReadData(Npgsql.NpgsqlCommand cmd)
        {
            cmd.Connection = Koneksi;
            Npgsql.NpgsqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public Npgsql.NpgsqlDataReader ReadData(string strSQL)
        {
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(strSQL, Koneksi);
            Npgsql.NpgsqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public string NewID()
        {
            string i = "";
            string sQuery = "select '" + clsGlobal.pstrservercode + "'||nextval('tbm_userid_nextid') as id;";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            cmd.CommandText = sQuery;
            try
            {
                Npgsql.NpgsqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    if (!rdr.IsDBNull(rdr.GetOrdinal("id")))
                    {
                        i = rdr.GetValue(0).ToString();
                    }
                    else
                    {
                        i = "";
                    };
                }
                rdr.Close();
            }
            catch (Npgsql.NpgsqlException Ex)
            {
                System.Windows.Forms.MessageBox.Show(Ex.Message, "An error occurred while processing!!!");
                return "";
            }

            return i;
        }
    }
}
