using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class tbm_bookingdetail
    {
        private String m_detailid;
        private String m_bookingid;
        private String m_carid;
        private Decimal m_price;
        private String m_opadd;
        private String m_pcadd;
        private DateTime m_luadd;
        private String m_opedit;
        private String m_pcedit;
        private DateTime m_luedit;
        private bool m_dlt;
        private NpgsqlConnection m_Koneksi;
        
        #region Property Value
        public String detailid
        {
            get { return m_detailid; }
            set { m_detailid = value; }
        }
        public String bookingid
        {
            get { return m_bookingid; }
            set { m_bookingid = value; }
        }
        public String carid
        {
            get { return m_carid; }
            set { m_carid = value; }
        }
        public Decimal price
        {
            get { return m_price; }
            set { m_price = value; }
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
        public NpgsqlConnection Koneksi
        {
            get { return m_Koneksi; }
            set { m_Koneksi = value; }
        }
        #endregion Property Value
        //
        public bool Insert()
        {
            string sQuery = "insert into tbm_bookingdetail(detailid,bookingid,carid,price,dlt,opadd,pcadd,luadd)" + "Values"
                + "(@did,@bid,@cid,@price,@dlt,@opadd,@pcadd,now())";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            if (bookingid != null)
            {
                cmd.Parameters.Add("@bid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = bookingid;
            }
            else {
                cmd.Parameters.Add("@bid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (detailid != null)
            {
                cmd.Parameters.Add("@did", NpgsqlTypes.NpgsqlDbType.Varchar).Value = detailid;
            }
            else
            {
                cmd.Parameters.Add("@did", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            ///
            if (carid != null)
            {
                cmd.Parameters.Add("@cid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = carid;
            }
            else {
                cmd.Parameters.Add("@cid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (price != 0)
            {
                cmd.Parameters.Add("@price", NpgsqlTypes.NpgsqlDbType.Numeric).Value = price;
            }
            else
            {
                cmd.Parameters.Add("@price", NpgsqlTypes.NpgsqlDbType.Numeric).Value = DBNull.Value;
            }
            //
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
            string sQuery = "UPDATE tbm_bookingdetail SET " +
                "bookingid=@bid,carid=@cid,price=@price,dlt=@dlt,opedit=@opedit,pcedit=@pcedit,luedit=now()" +
                "WHERE detailid = @did";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            if (bookingid != null)
            {
                cmd.Parameters.Add("@bid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = bookingid;
            }
            else {
                cmd.Parameters.Add("@bid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (detailid != null)
            {
                cmd.Parameters.Add("@did", NpgsqlTypes.NpgsqlDbType.Varchar).Value = detailid;
            }
            else
            {
                cmd.Parameters.Add("@did", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            ///
            if (carid != null)
            {
                cmd.Parameters.Add("@cid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = carid;
            }
            else {
                cmd.Parameters.Add("@cid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (price != 0)
            {
                cmd.Parameters.Add("@price", NpgsqlTypes.NpgsqlDbType.Numeric).Value = price;
            }
            else
            {
                cmd.Parameters.Add("@price", NpgsqlTypes.NpgsqlDbType.Numeric).Value = DBNull.Value;
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
        public bool Delete()
        {
            string sQuery = " DELETE FROM tbm_bookingdetail WHERE detailid=@did";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            cmd.Parameters.Add("@did", NpgsqlTypes.NpgsqlDbType.Varchar).Value = detailid;
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
            string sQuery = "Update tbm_bookingdetail set dlt=true,opedit=@opedit,pcedit=@pcedit,luedit=now()" +
                "where detailid=@did";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            cmd.CommandText = sQuery;
            cmd.Parameters.Add("@did", NpgsqlTypes.NpgsqlDbType.Varchar).Value = detailid;
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
            string sQuery = "select * from tbm_bookingdetail WHERE detailid='" + pKey + "'";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            cmd.CommandText = sQuery;
            Npgsql.NpgsqlDataReader rdr = cmd.ExecuteReader();
            try
            {
                if (rdr.Read())
                {
                    if (!rdr.IsDBNull(rdr.GetOrdinal("detailid")))
                    {
                        m_detailid = rdr.GetString(rdr.GetOrdinal("detailid"));
                    }
                    else
                    {
                        m_detailid = "";
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("bookingid")))
                    {
                        m_bookingid = rdr.GetString(rdr.GetOrdinal("bookingid"));
                    }
                    else
                    {
                        m_bookingid= "";
                    };
                    //
                    if (!rdr.IsDBNull(rdr.GetOrdinal("carid")))
                    {
                        m_carid = rdr.GetString(rdr.GetOrdinal("carid"));
                    }
                    else
                    {
                        m_carid = "";
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("price")))
                    {
                        m_price= rdr.GetDecimal(rdr.GetOrdinal("price"));
                    }
                    else
                    {
                        m_price = 0;
                    };
                    //
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
            string sQuery = "select '" + clsGlobal.pstrservercode + "'||nextval('tbm_bookingdetail_nextid') as id;";
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
