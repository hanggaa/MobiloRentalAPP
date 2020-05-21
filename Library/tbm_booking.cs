using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class tbm_booking
    {
        #region Variable Declaration
        private String m_bookingid;
        private String m_customerid;
        private DateTime m_dateorder;
        private String m_identity_number;
        private DateTime m_sdatebooking;
        private DateTime m_edatebooking;
        private decimal m_duration;
        private decimal m_downpayment;
        private String m_opadd;
        private String m_pcadd;
        private DateTime m_luadd;
        private String m_opedit;
        private String m_pcedit;
        private DateTime m_luedit;
        private bool m_dlt;
        private Npgsql.NpgsqlConnection m_Koneksi;
        #endregion

        #region Property Value
        public String bookingid
        {
            get { return m_bookingid; }
            set { m_bookingid = value; }
        }
        public String customerid
        {
            get { return m_customerid; }
            set { m_customerid = value; }
        }
        public DateTime dateorder
        {
            get { return m_dateorder; }
            set { m_dateorder = value; }
        }
        public DateTime sdatebooking
        {
            get { return m_sdatebooking; }
            set { m_sdatebooking = value; }
        }
        public DateTime edatebooking
        {
            get { return m_edatebooking; }
            set { m_edatebooking = value; }
        }
        public decimal duration_booking
        {
            get { return m_duration; }
            set { m_duration = value; }
        }
        public Decimal downpayment
        {
            get { return m_downpayment; }
            set { m_downpayment = value; }
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
            string sQuery = "insert into tbm_booking(bookingid,customerid,date_order,sdatebooking,duration_booking,edatebooking,down_payment,pcadd,opadd,luadd,dlt)" + "Values"
                + "(@bid,@cid,@do,@sdb,@db,@edb,@dp,@pcadd,@opadd,@luadd,@dlt)";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            if (bookingid != null)
            {
                cmd.Parameters.Add("@bid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = bookingid;
            }
            else {
                cmd.Parameters.Add("@bid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (customerid != null)
            {
                cmd.Parameters.Add("@cid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = customerid;
            }
            else
            {
                cmd.Parameters.Add("@cid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (dateorder != null && dateorder != DateTime.MinValue)
            {
                cmd.Parameters.Add("@do", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = dateorder;
            }
            else
            {
                cmd.Parameters.Add("@do", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = DBNull.Value;
            }
            if (sdatebooking != null && edatebooking != DateTime.MinValue)
            {
                cmd.Parameters.Add("@sdb", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = sdatebooking;
            }
            else
            {
                cmd.Parameters.Add("@sdb", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = DBNull.Value;
            }
            if (duration_booking != null)
            {
                cmd.Parameters.Add("@db", NpgsqlTypes.NpgsqlDbType.Numeric).Value = duration_booking;
            }
            else {
                cmd.Parameters.Add("@db", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }

            if (edatebooking != null && edatebooking != DateTime.MinValue)
            {
                cmd.Parameters.Add("@edb", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = edatebooking;
            }
            else
            {
                cmd.Parameters.Add("@edb", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = DBNull.Value;
            }
            if (downpayment != null)
            {
                cmd.Parameters.Add("@dp", NpgsqlTypes.NpgsqlDbType.Numeric).Value = downpayment;
            }
            else
            {
                cmd.Parameters.Add("@dp", NpgsqlTypes.NpgsqlDbType.Numeric).Value = DBNull.Value;
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
            string sQuery = "UPDATE tbm_booking SET " +
                "customerid=@cid,date_order=@do,sdatebooking=@sdb,down_payment=@db,edatebooking=@edb,pcedit=@pcedit,opedit=@opedit,luedit=now(),dlt=@dlt" +
                "WHERE bookingid=@bid";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            if (bookingid != null)
            {
                cmd.Parameters.Add("@bid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = bookingid;
            }
            else {
                cmd.Parameters.Add("@bid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (customerid != null)
            {
                cmd.Parameters.Add("@cid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = customerid;
            }
            else
            {
                cmd.Parameters.Add("@cid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (dateorder != null && dateorder != DateTime.MinValue)
            {
                cmd.Parameters.Add("@do", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = dateorder;
            }
            else
            {
                cmd.Parameters.Add("@do", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = DBNull.Value;
            }
            if (sdatebooking != null && edatebooking != DateTime.MinValue)
            {
                cmd.Parameters.Add("@sdb", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = sdatebooking;
            }
            else
            {
                cmd.Parameters.Add("@sdb", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = DBNull.Value;
            }
            if (duration_booking != null)
            {
                cmd.Parameters.Add("@db", NpgsqlTypes.NpgsqlDbType.Numeric).Value = duration_booking;
            }
            else {
                cmd.Parameters.Add("@db", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }

            if (edatebooking != null && edatebooking != DateTime.MinValue)
            {
                cmd.Parameters.Add("@edb", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = edatebooking;
            }
            else
            {
                cmd.Parameters.Add("@edb", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = DBNull.Value;
            }
            if (downpayment != null)
            {
                cmd.Parameters.Add("@dp", NpgsqlTypes.NpgsqlDbType.Numeric).Value = downpayment;
            }
            else
            {
                cmd.Parameters.Add("@dp", NpgsqlTypes.NpgsqlDbType.Numeric).Value = DBNull.Value;
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

        public bool Delete()
        {
            string sQuery = " DELETE FROM tbm_booking WHERE bookingid=@bid";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            cmd.Parameters.Add("@bid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = customerid;
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
            string sQuery = "Update tbm_booking set dlt=true,opedit=@opedit,pcedit=@pcedit,luedit=now()" +
                "where bookingid=@bid";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            cmd.CommandText = sQuery;
            cmd.Parameters.Add("@bid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = bookingid;
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
            string sQuery = "select * from tbm_booking WHERE bookingid='" + pKey + "'";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            cmd.CommandText = sQuery;
            Npgsql.NpgsqlDataReader rdr = cmd.ExecuteReader();
            try
            {
                if (rdr.Read())
                {
                    if (!rdr.IsDBNull(rdr.GetOrdinal("bookingid")))
                    {
                        bookingid = rdr.GetString(rdr.GetOrdinal("bookingid"));
                    }
                    else
                    {
                        bookingid = "";
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("customerid")))
                    {
                        m_customerid = rdr.GetString(rdr.GetOrdinal("customerid"));
                    }
                    else
                    {
                        m_customerid = "";
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("date_order")))
                    {
                        m_dateorder = rdr.GetDateTime(rdr.GetOrdinal("date_order"));
                    }
                    else
                    {
                        m_dateorder = System.DateTime.MinValue;
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("sdatebooking")))
                    {
                        m_sdatebooking = rdr.GetDateTime(rdr.GetOrdinal("sdatebooking"));
                    }
                    else
                    {
                        m_sdatebooking = System.DateTime.MinValue;
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("edatebooking")))
                    {
                        m_edatebooking = rdr.GetDateTime(rdr.GetOrdinal("edatebooking"));
                    }
                    else
                    {
                        m_edatebooking = System.DateTime.MinValue;
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("down_payment")))
                    {
                        m_downpayment = rdr.GetDecimal(rdr.GetOrdinal("down_payment"));
                    }
                    else
                    {
                        m_downpayment = 0;
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("duration_booking")))
                    {
                        m_duration = rdr.GetDecimal(rdr.GetOrdinal("duration_booking"));
                    }
                    else
                    {
                        m_duration = 0;
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
            string sQuery = "select '" + clsGlobal.pstrservercode + "'||nextval('tbm_booking_nextid') as id;";
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
