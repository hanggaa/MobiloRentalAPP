using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class tbm_customer
    {
        private String m_customerid;
        private String m_name;
        private String m_identity_type;
        private String m_identity_number;
        private String m_gender;
        private decimal m_phoneNumber;
        private DateTime m_dob;
        private String m_address;
        private String m_opadd;
        private String m_pcadd;
        private DateTime m_luadd;
        private String m_opedit;
        private String m_pcedit;
        private DateTime m_luedit;
        private bool m_dlt;
        private Npgsql.NpgsqlConnection m_Koneksi;

        #region Property Value
        public String customerid
        {
            get { return m_customerid; }
            set { m_customerid = value; }
        }
        public String name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        public String identity_type
        {
            get { return m_identity_type; }
            set { m_identity_type = value; }
        }
        public String identity_number
        {
            get { return m_identity_number; }
            set { m_identity_number = value; }
        }
        public String gender
        {
            get { return m_gender; }
            set { m_gender = value; }
        }
        public Decimal phoneNumber
        {
            get { return m_phoneNumber; }
            set { m_phoneNumber = value; }
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
        public DateTime dob
        {
            get { return m_dob; }
            set { m_dob = value; }
        }
        public String address
        {
            get { return m_address; }
            set { m_address = value; }
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
            string sQuery = "insert into tbm_customer(customerid,name,identity_type,identity_number,gender,phonenumber,dateofbirth,address,opadd,pcadd,luadd,dlt)" + "Values"
                + "(@cid,@name,@it,@in,@gender,@pnumber,@dob,@address,@opadd,@pcadd,@luadd,@dlt)";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            if (customerid != null)
            {
                cmd.Parameters.Add("@cid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = customerid;
            }
            else {
                cmd.Parameters.Add("@cid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (name != null)
            {
                cmd.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = name;
            }
            else
            {
                cmd.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (identity_type != null)
            {
                cmd.Parameters.Add("@it", NpgsqlTypes.NpgsqlDbType.Varchar).Value = identity_type;
            }
            else {
                cmd.Parameters.Add("@it", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (identity_number != null)
            {
                cmd.Parameters.Add("@in", NpgsqlTypes.NpgsqlDbType.Varchar).Value = identity_number;
            }
            else
            {
                cmd.Parameters.Add("@in", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (gender!= null)
            {
                cmd.Parameters.Add("@gender", NpgsqlTypes.NpgsqlDbType.Varchar).Value = gender;
            }
            else {
                cmd.Parameters.Add("@gender", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }

            if (dob != null && dob != DateTime.MinValue)
            {
                cmd.Parameters.Add("@dob", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = dob;
            }
            else
            {
                cmd.Parameters.Add("@dob", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = DBNull.Value;
            }
             if (phoneNumber != null)
            {
                cmd.Parameters.Add("@pnumber", NpgsqlTypes.NpgsqlDbType.Numeric).Value = phoneNumber;
            }
            else
            {
                cmd.Parameters.Add("@pnumber", NpgsqlTypes.NpgsqlDbType.Numeric).Value = DBNull.Value;
            }
            if (address!= null)
            {
                cmd.Parameters.Add("@address", NpgsqlTypes.NpgsqlDbType.Varchar).Value = address;
            }
            else {
                cmd.Parameters.Add("@address", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
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
            string sQuery = "UPDATE tbm_customer SET " +
                "name=@name,identity_type=@it,identity_number=@in,gender=@gender,phonenumber=@pnumber,dateofbirth=@dob,address=@address,opedit=@opedit,pcedit=@pcedit,dlt=@dlt,luedit=now()" +
                "WHERE customerid=@cid";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            if (customerid != null)
            {
                cmd.Parameters.Add("@cid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = customerid;
            }
            else {
                cmd.Parameters.Add("@cid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (name != null)
            {
                cmd.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = name;
            }
            else
            {
                cmd.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (identity_type != null)
            {
                cmd.Parameters.Add("@it", NpgsqlTypes.NpgsqlDbType.Varchar).Value = identity_type;
            }
            else {
                cmd.Parameters.Add("@it", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (identity_number != null)
            {
                cmd.Parameters.Add("@in", NpgsqlTypes.NpgsqlDbType.Varchar).Value = identity_number;
            }
            else
            {
                cmd.Parameters.Add("@in", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (gender != null)
            {
                cmd.Parameters.Add("@gender", NpgsqlTypes.NpgsqlDbType.Varchar).Value = gender;
            }
            else {
                cmd.Parameters.Add("@gender", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }

            if (dob != null && dob != DateTime.MinValue)
            {
                cmd.Parameters.Add("@dob", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = dob;
            }
            else
            {
                cmd.Parameters.Add("@dob", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = DBNull.Value;
            }
            if (phoneNumber != null)
            {
                cmd.Parameters.Add("@pnumber", NpgsqlTypes.NpgsqlDbType.Numeric).Value = phoneNumber;
            }
            else
            {
                cmd.Parameters.Add("@pnumber", NpgsqlTypes.NpgsqlDbType.Numeric).Value = DBNull.Value;
            }
            if (address != null)
            {
                cmd.Parameters.Add("@address", NpgsqlTypes.NpgsqlDbType.Varchar).Value = address;
            }
            else {
                cmd.Parameters.Add("@address", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
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
            //try
            //{
                cmd.ExecuteNonQuery();
                return true;
            //}
            //catch (Npgsql.NpgsqlException Ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(Ex.Message, "An error occurred while processing!!!");
            //    return false;
            //}
        }

        public bool Delete()
        {
            string sQuery = " DELETE FROM tbm_customer WHERE customerid=@cid";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            cmd.Parameters.Add("@cid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = customerid;
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
            string sQuery = "Update tbm_customer set dlt=true,opedit=@opedit,pcedit=@pcedit,luedit=now()" +
                "where customerid=@cid";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            cmd.CommandText = sQuery;
            cmd.Parameters.Add("@cid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = customerid;
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
            string sQuery = "select * from tbm_customer WHERE customerid='" + pKey + "'";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            cmd.CommandText = sQuery;
            Npgsql.NpgsqlDataReader rdr = cmd.ExecuteReader();
            try
            {
                if (rdr.Read())
                {
                    if (!rdr.IsDBNull(rdr.GetOrdinal("customerid")))
                    {
                        m_customerid = rdr.GetString(rdr.GetOrdinal("customerid"));
                    }
                    else
                    {
                        m_customerid= "";
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("name")))
                    {
                        m_name = rdr.GetString(rdr.GetOrdinal("name"));
                    }
                    else
                    {
                        m_name = "";
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("identity_type")))
                    {
                        m_identity_type = rdr.GetString(rdr.GetOrdinal("identity_type"));
                    }
                    else
                    {
                        m_identity_type = "";
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("identity_number")))
                    {
                        m_identity_number = rdr.GetString(rdr.GetOrdinal("identity_number"));
                    }
                    else
                    {
                        m_identity_number= "";
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("gender")))
                    {
                        m_gender = rdr.GetString(rdr.GetOrdinal("gender"));
                    }
                    else
                    {
                        m_gender = "";
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("phonenumber")))
                    {
                        m_phoneNumber = rdr.GetDecimal(rdr.GetOrdinal("phonenumber"));
                    }
                    else
                    {
                        m_phoneNumber = 0;
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("dateofbirth")))
                    {
                        m_dob = rdr.GetDateTime(rdr.GetOrdinal("dateofbirth"));
                    }
                    else
                    {
                        m_dob = System.DateTime.MinValue;
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("address")))
                    {
                        m_address = rdr.GetString(rdr.GetOrdinal("address"));
                    }
                    else
                    {
                        m_address = "";
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
            string sQuery = "select '" + clsGlobal.pstrservercode + "'||nextval('tbm_customer_nextid') as id;";
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
