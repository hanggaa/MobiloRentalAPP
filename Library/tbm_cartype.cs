using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class tbm_cartype
    {
        private String m_categoryid;
        private String m_categoryname;
        private String m_carbrandid;
        private String m_brandname;
        private String m_typeid;
        private String m_typename;
        private String m_opadd;
        private String m_pcadd;
        private DateTime m_luadd;
        private String m_opedit;
        private String m_pcedit;
        private DateTime m_luedit;
        private bool m_dlt;
        private Npgsql.NpgsqlConnection m_Koneksi;

        #region Property Value
        public String typeid
        {
            get { return m_typeid; }
            set { m_typeid = value; }
        }
        public String typename
        {
            get { return m_typename; }
            set { m_typename = value; }
        }
        public String categoryid
        {
            get { return m_categoryid; }
            set { m_categoryid = value; }
        }
        public String categoryname
        {
            get { return m_categoryname; }
            set { m_categoryname = value; }
        }
        public String brandid
        {
            get { return m_carbrandid; }
            set { m_carbrandid = value; }
        }
        public String brandname
        {
            get { return m_brandname; }
            set { m_brandname = value; }
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
        #endregion Property Value
        public bool Insert()
        {
            string sQuery = "insert into tbm_cartype(typeid,carcategoryid,carbrandid,typename,dlt,opadd,pcadd,luadd)" + "Values"
                + "(@tid,@cid,@bid,@tname,@dlt,@opadd,@pcadd,@luadd)";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            if (typeid != null)
            {
                cmd.Parameters.Add("@tid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = typeid;
            }
            else {
                cmd.Parameters.Add("@tid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (categoryid != null)
            {
                cmd.Parameters.Add("@cid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = categoryid;
            }
            else {
                cmd.Parameters.Add("@cid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (brandid != null)
            {
                cmd.Parameters.Add("@bid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = brandid;
            }
            else
            {
                cmd.Parameters.Add("@bid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (typename != null)
            {
                cmd.Parameters.Add("@tname", NpgsqlTypes.NpgsqlDbType.Varchar).Value = typename;
            }
            else {
                cmd.Parameters.Add("@tname", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }

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
            catch (Npgsql.NpgsqlException Ex)
            {
                System.Windows.Forms.MessageBox.Show(Ex.Message, "An error occurred while processing!!!");
                return false;
            }
        }
        public bool Update()
        {
            string sQuery = "UPDATE tbm_cartype SET " +
                "carcategoryid = @cid,carbrandid =@bid,typename = @tname,dlt=@dlt,opedit=@opedit,pcedit=@pcedit,luedit=now()" +
                "WHERE typeid = @tid";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            if (m_typeid != null)
            {
                cmd.Parameters.Add("@tid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = typeid;
            }
            else {
                cmd.Parameters.Add("@tid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (m_categoryid != null)
            {
                cmd.Parameters.Add("@cid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = categoryid;
            }
            else {
                cmd.Parameters.Add("@cid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (m_carbrandid != null)
            {
                cmd.Parameters.Add("@bid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = brandid;
            }
            else {
                cmd.Parameters.Add("@bid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (m_typename != null)
            {
                cmd.Parameters.Add("@tname", NpgsqlTypes.NpgsqlDbType.Varchar).Value = typename;
            }
            else {
                cmd.Parameters.Add("@tname", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
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
            catch (Npgsql.NpgsqlException Ex)
            {
                System.Windows.Forms.MessageBox.Show(Ex.Message, "An error occurred while processing!!!");
                return false;
            }
        }
        public bool SoftDelete()
        {
            string sQuery = "Update tbm_cartype set dlt=true,opedit=@opedit,pcedit=@pcedit,luedit=now()" +
                "where typeid=@tid";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            cmd.CommandText = sQuery;
            cmd.Parameters.Add("@tid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = typeid;
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
            string sQuery = "select * from tbm_cartype WHERE typeid='" + pKey + "'";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            cmd.CommandText = sQuery;
            Npgsql.NpgsqlDataReader rdr = cmd.ExecuteReader();
            try
            {
                if (rdr.Read())
                {
                    if (!rdr.IsDBNull(rdr.GetOrdinal("typeid")))
                    {
                        m_typeid = rdr.GetString(rdr.GetOrdinal("typeid"));
                    }
                    else
                    {
                        m_typeid = "";
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("carcategoryid")))
                    {
                        m_categoryid = rdr.GetString(rdr.GetOrdinal("carcategoryid"));
                    }
                    else
                    {
                        m_categoryid = "";
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("carbrandid")))
                    {
                        m_carbrandid = rdr.GetString(rdr.GetOrdinal("carbrandid"));
                    }
                    else
                    {
                        m_carbrandid = "";
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("typename")))
                    {
                        m_typename = rdr.GetString(rdr.GetOrdinal("typename"));
                    }
                    else
                    {
                        m_categoryname = "";
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
        public string NewID()
        {
            string i = "";
            string sQuery = "select '" + clsGlobal.pstrservercode + "'||nextval('tbm_cartype_nextid') as id;";
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
