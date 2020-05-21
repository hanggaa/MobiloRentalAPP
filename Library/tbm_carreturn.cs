using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class tbm_carreturn
    {
        private String m_returnid;
        private String m_bookingid;
        private DateTime m_dtreturn;
        private decimal m_remainingpayment;
        private decimal m_penaltypayment;
        private decimal m_paymentamount;
        private String m_opadd;
        private String m_pcadd;
        private DateTime m_luadd;
        private String m_opedit;
        private String m_pcedit;
        private DateTime m_luedit;
        private bool m_dlt;
        private Npgsql.NpgsqlConnection m_Koneksi;

        #region Property Value
        public String returnid
        {
            get { return m_returnid; }
            set { m_returnid = value; }
        }
        public String bookingid
        {
            get { return m_bookingid; }
            set { m_bookingid = value; }
        }
        public DateTime dtreturn
        {
            get { return m_dtreturn; }
            set { m_dtreturn = value; }
        }
        public decimal remainingpayment
        {
            get { return m_remainingpayment; }
            set { m_remainingpayment = value; }
        }
        public decimal penaltypayment
        {
            get { return m_penaltypayment; }
            set { m_penaltypayment = value; }
        }
        public decimal paymentamount
        {
            get { return m_paymentamount; }
            set { m_paymentamount = value; }
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
            string sQuery = "insert into tbm_carreturn(returnid,bookingid,dtreturn,remainingpayment,penaltypayment,paymentamount,dlt,opadd,pcadd,luadd)" + "Values"
                + "(@rid,@bid,@dtr,@rp,@pp,@pa,@dlt,@opadd,@pcadd,now())";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            if (returnid != null)
            {
                cmd.Parameters.Add("@rid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = returnid;
            }
            else {
                cmd.Parameters.Add("@rid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (bookingid != null)
            {
                cmd.Parameters.Add("@bid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = bookingid;
            }
            else
            {
                cmd.Parameters.Add("@bid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (dtreturn != null && dtreturn != DateTime.MinValue)
            {
                cmd.Parameters.Add("@dtr", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = dtreturn;
            }
            else
            {
                cmd.Parameters.Add("@dtr", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = DBNull.Value;
            }
            if (remainingpayment != 0)
            {
                cmd.Parameters.Add("@rp", NpgsqlTypes.NpgsqlDbType.Numeric).Value = remainingpayment;
            }
            else
            {
                cmd.Parameters.Add("@rp", NpgsqlTypes.NpgsqlDbType.Numeric).Value = DBNull.Value;
            }
            if (penaltypayment != 0)
            {
                cmd.Parameters.Add("@pp", NpgsqlTypes.NpgsqlDbType.Numeric).Value = penaltypayment;
            }
            else
            {
                cmd.Parameters.Add("@pp", NpgsqlTypes.NpgsqlDbType.Numeric).Value = DBNull.Value;
            }
            if (paymentamount != 0)
            {
                cmd.Parameters.Add("@pa", NpgsqlTypes.NpgsqlDbType.Numeric).Value = paymentamount;
            }
            else
            {
                cmd.Parameters.Add("@pa", NpgsqlTypes.NpgsqlDbType.Numeric).Value = DBNull.Value;
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
            //if (luadd != null && luadd != DateTime.MinValue)
            //{
            //    cmd.Parameters.Add("@luadd", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = luadd;
            //}
            //else
            //{
            //    cmd.Parameters.Add("@luadd", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = DBNull.Value;
            //}
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
            string sQuery = "UPDATE tbm_carreturn SET " +
                "bookingid=@bid,dtreturn=@dtr,remainingpayment=@rp,penaltypayment=@pp,paymentamount=@pa,dlt=@dlt,opedit=@opedit,pcedit=@pcedit,luedit=now()" +
                "WHERE returnid = @rid";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            if (returnid != null)
            {
                cmd.Parameters.Add("@rid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = returnid;
            }
            else {
                cmd.Parameters.Add("@rid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (bookingid != null)
            {
                cmd.Parameters.Add("@bid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = bookingid;
            }
            else
            {
                cmd.Parameters.Add("@bid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (dtreturn != null && dtreturn != DateTime.MinValue)
            {
                cmd.Parameters.Add("@dtr", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = dtreturn;
            }
            else
            {
                cmd.Parameters.Add("@dtr", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = DBNull.Value;
            }
            if (remainingpayment != 0)
            {
                cmd.Parameters.Add("@rp", NpgsqlTypes.NpgsqlDbType.Numeric).Value = remainingpayment;
            }
            else
            {
                cmd.Parameters.Add("@rp", NpgsqlTypes.NpgsqlDbType.Numeric).Value = DBNull.Value;
            }
            if (penaltypayment != 0)
            {
                cmd.Parameters.Add("@pp", NpgsqlTypes.NpgsqlDbType.Numeric).Value = penaltypayment;
            }
            else
            {
                cmd.Parameters.Add("@pp", NpgsqlTypes.NpgsqlDbType.Numeric).Value = DBNull.Value;
            }
            if (paymentamount != 0)
            {
                cmd.Parameters.Add("@pa", NpgsqlTypes.NpgsqlDbType.Numeric).Value = paymentamount;
            }
            else
            {
                cmd.Parameters.Add("@pa", NpgsqlTypes.NpgsqlDbType.Numeric).Value = DBNull.Value;
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
            string sQuery = " DELETE FROM tbm_carreturn WHERE returnid=@rid";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            cmd.Parameters.Add("@rid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = returnid;
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
            string sQuery = "Update tbm_carreturn set dlt=true,opedit=@opedit,pcedit=@pcedit,luedit=now()" +
                "where returnid=@rid";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            cmd.CommandText = sQuery;
            cmd.Parameters.Add("@rid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = returnid;
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
            string sQuery = "select * from tbm_carreturn WHERE returnid='" + pKey + "'";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            cmd.CommandText = sQuery;
            Npgsql.NpgsqlDataReader rdr = cmd.ExecuteReader();
            try
            {
                if (rdr.Read())
                {
                    if (!rdr.IsDBNull(rdr.GetOrdinal("returnid")))
                    {
                        m_returnid= rdr.GetString(rdr.GetOrdinal("returnid"));
                    }
                    else
                    {
                        m_returnid = "";
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("bookingid")))
                    {
                        m_bookingid = rdr.GetString(rdr.GetOrdinal("bookingid"));
                    }
                    else
                    {
                        m_bookingid = "";
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("dtreturn")))
                    {
                        m_dtreturn = rdr.GetDateTime(rdr.GetOrdinal("dtreturn"));
                    }
                    else
                    {
                        m_dtreturn = System.DateTime.MinValue;
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("remainingpayment")))
                    {
                        m_remainingpayment = rdr.GetDecimal(rdr.GetOrdinal("remainingpayment"));
                    }
                    else
                    {
                        m_remainingpayment = 0;
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("penaltypayment")))
                    {
                        m_penaltypayment = rdr.GetDecimal(rdr.GetOrdinal("penaltypayment"));
                    }
                    else
                    {
                        m_penaltypayment = 0;
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("paymentamount")))
                    {
                        m_paymentamount = rdr.GetDecimal(rdr.GetOrdinal("paymentamount"));
                    }
                    else
                    {
                        m_paymentamount = 0;
                    };
                    ////////
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
            string sQuery = "select '" + clsGlobal.pstrservercode + "'||nextval('tbm_carreturn_nextid') as id;";
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
