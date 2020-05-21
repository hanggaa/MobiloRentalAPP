using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class tbm_car
    {
        private String m_carid;
        private String m_carplatnumber;
        private String m_filepath_car;
        private decimal m_price;
        private String m_description;
        private bool m_available;
        private decimal m_capacity;
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
        private String m_carimage;
        private bool m_dlt;
        private Npgsql.NpgsqlConnection m_Koneksi;

        #region Property Value
        public String carid
        {
            get { return m_carid; }
            set { m_carid = value; }
        }
        public String platnumber
        {
            get { return m_carplatnumber; }
            set { m_carplatnumber = value; }
        }
        public String filepath_car
        {
            get { return m_filepath_car; }
            set { m_filepath_car = value; }
        }
        public String image_car
        {
            get { return m_carimage; }
            set { m_carimage = value; }
        }
        public decimal price
        {
            get { return m_price; }
            set { m_price = value; }
        }
        public String description
        {
            get { return m_description; }
            set { m_description = value; }
        }
        public bool available
        {
            get { return m_available; }
            set { m_available  = value; }
        }
        public decimal capacity
        {
            get { return m_capacity; }
            set { m_capacity = value; }
        }
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
            string sQuery = "insert into tbm_car(carid,platnumber,typeid,imagename,filepath_car,price,description,passengercapacity,statusavailable,dlt,opadd,pcadd,luadd)" + "Values"
                + "(@cid,@platnumber,@tid,@image,@filepath,@price,@desc,@capacity,@av,@dlt,@opadd,@pcadd,@luadd)";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            if (carid != null)
            {
                cmd.Parameters.Add("@cid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = carid;
            }
            else {
                cmd.Parameters.Add("@cid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if ( platnumber!= null)
            {
                cmd.Parameters.Add("@platnumber", NpgsqlTypes.NpgsqlDbType.Varchar).Value = platnumber;
            }
            else {
                cmd.Parameters.Add("@platnumber", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (typeid != null)
            {
                cmd.Parameters.Add("@tid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = typeid;
            }
            else {
                cmd.Parameters.Add("@tid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (image_car != null)
            {
                cmd.Parameters.Add("@image", NpgsqlTypes.NpgsqlDbType.Varchar).Value = image_car;
            }
            else
            {
                cmd.Parameters.Add("@image", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (filepath_car != null)
            {
                cmd.Parameters.Add("@filepath", NpgsqlTypes.NpgsqlDbType.Varchar).Value = filepath_car;
            }
            else
            {
                cmd.Parameters.Add("@filepath", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (price != null)
            {
                cmd.Parameters.Add("@price", NpgsqlTypes.NpgsqlDbType.Numeric).Value = price;
            }
            else {
                cmd.Parameters.Add("@price", NpgsqlTypes.NpgsqlDbType.Numeric).Value = DBNull.Value;
            }
            if (description != null)
            {
                cmd.Parameters.Add("@desc", NpgsqlTypes.NpgsqlDbType.Varchar).Value = description;
            }
            else {
                cmd.Parameters.Add("@desc", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (capacity != null)
            {
                cmd.Parameters.Add("@capacity", NpgsqlTypes.NpgsqlDbType.Numeric).Value = capacity;
            }
            else {
                cmd.Parameters.Add("@capacity", NpgsqlTypes.NpgsqlDbType.Numeric).Value = DBNull.Value;
            }
            cmd.Parameters.Add("@av", NpgsqlTypes.NpgsqlDbType.Boolean).Value = available;

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
        public bool updateAv()
        {
            string sQuery = "UPDATE tbm_car SET statusavailable=@av,dlt=@dlt,opedit=@opedit,pcedit=@pcedit,luedit=now()" +
                "WHERE platnumber=@pn";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
         
            //}
            if (platnumber!= null)
            {
                cmd.Parameters.Add("@pn", NpgsqlTypes.NpgsqlDbType.Varchar).Value = platnumber;
            }
            else {
                cmd.Parameters.Add("@pn", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            cmd.Parameters.Add("@av", NpgsqlTypes.NpgsqlDbType.Boolean).Value = available;
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
            string sQuery = "UPDATE tbm_car SET " +
                "platnumber=@pn,typeid=@tid,imagename=@image,filepath_car=@filepath,price=@price,description=@desc,"
                +"passengercapacity=@capacity,statusavailable=@av,dlt=@dlt,opedit=@opedit,pcedit=@pcedit,luedit=now()" +
                "WHERE carid=@cid";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            if (carid != null)
            {
                cmd.Parameters.Add("@cid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = carid;
            }
            else {
                cmd.Parameters.Add("@cid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (platnumber != null)
            {
                cmd.Parameters.Add("@pn", NpgsqlTypes.NpgsqlDbType.Varchar).Value = platnumber;
            }
            else {
                cmd.Parameters.Add("@pn", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (typeid != null)
            {
                cmd.Parameters.Add("@tid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = typeid;
            }
            else {
                cmd.Parameters.Add("@tid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (image_car != null)
            {
                cmd.Parameters.Add("@image", NpgsqlTypes.NpgsqlDbType.Varchar).Value = image_car;
            }
            else
            {
                cmd.Parameters.Add("@image", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (filepath_car != null)
            {
                cmd.Parameters.Add("@filepath", NpgsqlTypes.NpgsqlDbType.Varchar).Value = filepath_car;
            }
            else
            {
                cmd.Parameters.Add("@filepath", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (price != null)
            {
                cmd.Parameters.Add("@price", NpgsqlTypes.NpgsqlDbType.Numeric).Value = price;
            }
            else {
                cmd.Parameters.Add("@price", NpgsqlTypes.NpgsqlDbType.Numeric).Value = DBNull.Value;
            }
            if (description != null)
            {
                cmd.Parameters.Add("@desc", NpgsqlTypes.NpgsqlDbType.Varchar).Value = description;
            }
            else {
                cmd.Parameters.Add("@desc", NpgsqlTypes.NpgsqlDbType.Varchar).Value = DBNull.Value;
            }
            if (capacity != null)
            {
                cmd.Parameters.Add("@capacity", NpgsqlTypes.NpgsqlDbType.Numeric).Value = capacity;
            }
            else {
                cmd.Parameters.Add("@capacity", NpgsqlTypes.NpgsqlDbType.Numeric).Value = DBNull.Value;
            }
            cmd.Parameters.Add("@av", NpgsqlTypes.NpgsqlDbType.Boolean).Value = available;
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
            string sQuery = "Update tbm_car set dlt=true,opedit=@opedit,pcedit=@pcedit,luedit=now(),statusavailable='0'" +
                "where carid=@cid";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(sQuery, Koneksi);
            cmd.CommandText = sQuery;
            cmd.Parameters.Add("@cid", NpgsqlTypes.NpgsqlDbType.Varchar).Value = carid;
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
            string sQuery = "select * from tbm_car WHERE carid='" + pKey + "'";
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
                    if (!rdr.IsDBNull(rdr.GetOrdinal("platnumber")))
                    {
                        m_carplatnumber = rdr.GetString(rdr.GetOrdinal("platnumber"));
                    }
                    else
                    {
                        m_carplatnumber = "";
                    };
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
                        //m_price = Convert.ToInt32((rdr.GetOrdinal("price")));
                        m_price = rdr.GetDecimal(rdr.GetOrdinal("price"));
                    }
                    else
                    {
                        m_price = 0;
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("description")))
                    {
                        m_description = rdr.GetString(rdr.GetOrdinal("description"));
                    }
                    else
                    {
                        m_description = "";
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("passengercapacity")))
                    {
                        m_capacity = rdr.GetDecimal(rdr.GetOrdinal("passengercapacity"));
                    }
                    else
                    {
                        m_capacity = 0;
                    };
                    //if (System.IO.File.Exists(row["imagename"].ToString()))
                    //{
                  
                    if (!rdr.IsDBNull(rdr.GetOrdinal("imagename")))
                    {
                         m_carimage = rdr.GetString(rdr.GetOrdinal("imagename"));
                        
                    }
                    else
                    {
                        m_carimage = "";
                    };
                    if (!rdr.IsDBNull(rdr.GetOrdinal("filepath_car")))
                    {
                        m_filepath_car = rdr.GetString(rdr.GetOrdinal("filepath_car"));
                    }
                    else
                    {
                        m_filepath_car = "";
                    };
                    m_available = rdr.GetBoolean(rdr.GetOrdinal("statusavailable"));
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
            string sQuery = "select '" + clsGlobal.pstrservercode + "'||nextval('tbm_carid_nextid') as id;";
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
