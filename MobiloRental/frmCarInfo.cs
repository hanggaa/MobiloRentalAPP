using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using Library;
using Npgsql;

namespace MobiloRental
{
    public partial class frmCarInfo : DevExpress.XtraEditors.XtraForm
    {
        public frmCarInfo()
        {
            this.DoubleBuffered = true;
            frmMain.setLoadDialog(true, "Loading Components...");
            InitializeComponent();
            frmMain.setLoadDialog(false, "");
        }
        public bool isChange = false;
        public bool isLoad;
        public frmMain fMain;
        public bool isSaved = false;
        public string carTypeId;
        string filename;
        string pathText;
        string pathstring;
        string typeName;
        private String m_cartypeid;
        private String m_categoryid;
        private String m_carbrandid;
        private string m_imagestring;
        bool openimage;
        private string getImage;
        private String typeid
        {
            get { return m_cartypeid; }
            set { m_cartypeid = value; }

        }
        private String categoryid
        {
            get { return m_categoryid; }
            set { m_categoryid = value; }
        }
        private String brandid
        {
            get { return m_carbrandid; }
            set { m_carbrandid = value; }
        }
        public Byte[] PhotoData { get; protected set; }
        private Image photo;

        public void RefreshAll()
        {
            isLoad = true;
            base.Refresh();

            isLoad = false;

        }
        private String m_carid;
      
        public String CarId
        {
            get { return m_carid; }
            set { m_carid = value; }
        }
        private void doStuff()
        {
            try
            {
                using (clsConnection oConn = new clsConnection())
                {
                    string typename = cmbTipe.Text;
                    if (cmbTipe.Text != null)
                    {

                        string getTypeid = @"select a.typeid, a.carcategoryid as categoryid,a.carbrandid as brandid, a.typename,
                                b.carcategoryid as categoryids,b.carcategoryname as categoryname,
                                c.carbrandid as brandids, c.brandname 
                                from tbm_cartype a
                                left join tbm_carcategory b on b.carcategoryid = a.carcategoryid and b.dlt='0' 
                                left join tbm_carbrand c on c.carbrandid = a.carbrandid and c.dlt='0'
                                where a.dlt ='0' and a.typename='" + typename + "'";
                        DataTable dtData = oConn.GetData(getTypeid);
                        foreach (DataRow row in dtData.Rows)
                        {
                            txtKategori.Text = row["categoryname"].ToString();
                            txtBrand.Text= row["brandname"].ToString();
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                ////clsGlobal.generateErrMessageAndSendmail(ex, false);
            }
            catch (Exception ex)
            {
                ////clsGlobal.generateErrMessageAndSendmail(ex, false);

            }
        }

       
        private void loadData()
        {
            try
            {
                using (clsConnection oConn = new clsConnection())
                {
                    NpgsqlCommand ocmd = new NpgsqlCommand();


                    string strSql = @"select a.carid, a.platnumber,a.typeid,a.filepath_car,a.imagename,a.passengercapacity,a.price,a.description,
                                      a.statusavailable,
                                      b.typeid,b.carcategoryid as categoryid, b.carbrandid,b.typename as typename,
                                      c.carcategoryid as categoryid,c.carcategoryname as categoryname,
                                      d.carbrandid as brandids,d.brandname
                                      from tbm_car a
                                      left join tbm_cartype b on b.typeid =  a.typeid and b.dlt='0'
                                      left join tbm_carcategory c on c.carcategoryid = b.carcategoryid and c.dlt='0' 
                                      left join tbm_carbrand d on d.carbrandid = b.carbrandid and d.dlt='0'
                                      where b.dlt ='0' and a.carid='" + CarId + "'";
                    DataTable dtData = oConn.GetData(strSql);
                    //cmbTipe.DataSource = dtData;
                    //cmbTipe.SelectedValue = cmbTipe.Items.Contains("typename").ToString();


                    foreach (DataRow row in dtData.Rows)
                    {
                        txtPlatnumber.Text = Convert.ToString(row["platnumber"]);
                        cmbTipe.Text = row["typename"].ToString();
                        txtKategori.Text = Convert.ToString(row["categoryname"]);
                        txtBrand.Text = Convert.ToString(row["brandname"]);
                        txtDesc.Text = Convert.ToString(row["description"]);
                        txtkapasitas.Value = Convert.ToInt32(row["passengercapacity"]);
                        txtHarga.EditValue = Convert.ToString(row["price"]);
                        typeid = row["typeid"].ToString();
                        txtKategori.Text = row["categoryname"].ToString();
                        txtBrand.Text = row["brandname"].ToString();
                        if (System.IO.File.Exists(row["imagename"].ToString()))
                        {

                            pFoto.Image = Image.FromFile(row["imagename"].ToString());
                            txtPathText.Text = row["filepath_car"].ToString();
                            getImage = row["imagename"].ToString(); 
                        }
                        

                        //byte[] imageByte = oObject.imageCar.ToArray();

                    }
             

                }

            }
            catch
            {

            }
            //fillcmb();
        }
       
        private void BrowsePic()
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = " Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            opf.Multiselect = false;
            if (opf.ShowDialog() == DialogResult.OK)
            {
               
                pFoto.Image = Image.FromFile(opf.FileName);
                pathText = opf.SafeFileName;
                txtPathText.Text = opf.FileName;
                Image imageA = pFoto.Image;
                imageA.Save(pathText);
            }
        }

        private void fillcmb()
        {
            try
            {
                using (clsConnection oConn = new clsConnection())
                {

                 
                    string strSql = @"select * from tbm_cartype where dlt='0'";
                    DataTable dtData = oConn.GetData(strSql);
                    cmbTipe.DataSource = dtData;
                    cmbTipe.DisplayMember = "typename";
                    cmbTipe.ValueMember = "typeid";
                    foreach (DataRow row in dtData.Rows)
                    {
                        //cmbTipe.Items.Add(row["typename"].ToString());
                    }


                }
            }
            catch
            {

            }
        }
        bool isClose = false;

        private void getTypeid()
        {
            try
            {
                using (clsConnection oConn = new clsConnection())
                {
                    NpgsqlCommand ocmd = new NpgsqlCommand();
                    string getTypeid = @"select a.typeid, a.carcategoryid as categoryid,a.carbrandid as brandid, a.typename,
                                b.carcategoryid as categoryids,b.carcategoryname as categoryname,
                                c.carbrandid as brandids, c.brandname 
                                from tbm_cartype a
                                left join tbm_carcategory b on b.carcategoryid = a.carcategoryid and b.dlt='0' 
                                left join tbm_carbrand c on c.carbrandid = a.carbrandid and c.dlt='0'
                                where a.dlt ='0' and a.typename='" + cmbTipe.Text + "'";
                    DataTable dtType = oConn.GetData(getTypeid);
 
                    foreach (DataRow row in dtType.Rows)
                    {
                        typeid = Convert.ToString(row["typeid"]);
                    }
                    //foreach (DataRow row in dtBrand.Rows)
                    //{
                    //    ricmbBrand.Items.Add(row["brandname"]);
                    //}
                }
            }
            catch
            {

            }
        }
        public void loadImage()
        {
            try
            {
                using (clsConnection oConn = new clsConnection())
                {
                    NpgsqlCommand ocmd = new NpgsqlCommand();

                    string strSql = @"select * from tbm_car where carid ='" + CarId + "'";
                    DataTable dtData = oConn.GetData(strSql);
                    foreach(DataRow row in dtData.Rows)
                    {
                        m_imagestring = row["imagename"].ToString();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                ////clsGlobal.generateErrMessageAndSendmail(ex, false);
            }
            catch (Exception ex)
            {
                ////clsGlobal.generateErrMessageAndSendmail(ex, false);
            }
            finally
            {
                frmMain.setLoadDialog(false, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(this, "Do you want to save this data?", clsGlobal.pstrAppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                loadImage();
                if (txtPlatnumber.Text == "" || txtPathText.Text == "" || cmbTipe.Text == "" || txtkapasitas.Value <= 1 || txtHarga.Text == "" || txtDesc.Text == "")
                {
                    XtraMessageBox.Show("Data Can't Be Null", "Warning");
                }
                else {
                    getTypeid();
                    try
                    {
                        using (clsConnection oConn = new clsConnection())
                        {

                            string strCount = clsGlobal.getData1Field("select count(*) from tbm_car where dlt='0' and trim(lower(platnumber))=trim(lower('" + txtPlatnumber.Text + "')) and carid <>'" + CarId + "'");
                            if (Convert.ToInt32(strCount) == 0)
                            {

                                tbm_car oObject = new tbm_car();
                                oConn.Open();
                                oObject.Koneksi = oConn.Conn;


                                if (!string.IsNullOrEmpty(CarId))
                                {
                                    oObject.GetByPrimaryKey(CarId);
                                }

                                oObject.carid = m_carid;
                                oObject.platnumber = txtPlatnumber.Text;

                                oObject.typeid = typeid;
                                oObject.description = txtDesc.Text;
                                oObject.capacity = Convert.ToInt32(txtkapasitas.Value);
                                oObject.price = Convert.ToInt32(txtHarga.Text);
                                oObject.filepath_car = txtPathText.Text;

                                if (pathText == null)
                                {
                                    pathText = getImage;
                                }


                                oObject.image_car = pathText;

                                if (string.IsNullOrEmpty(CarId))
                                {
                                    oObject.carid = oObject.NewID();
                                    oObject.available = true;
                                    oObject.opadd = clsGlobal.strUserName;
                                    oObject.pcadd = SystemInformation.ComputerName;
                                    oObject.Insert();
                                    XtraMessageBox.Show("Data Has been Inserted", clsGlobal.pstrAppName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                                else
                                {
                                    oObject.opedit = clsGlobal.strUserName;
                                    oObject.pcedit = SystemInformation.ComputerName;
                                    oObject.Update();
                                    XtraMessageBox.Show("Data Has been Updated", clsGlobal.pstrAppName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }

                            }

                        }
                    }
                    //catch { }
                    catch (NpgsqlException ex)
                    {
                        XtraMessageBox.Show(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message);
                    }
                    this.Close();
                    clsGlobal.isClose = true;
         
                }
            }
            else
            {

            }
            
        }

  

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void frmCarInfo_Load(object sender, EventArgs e)
        {

            isLoad = true;
            fillcmb();
            loadData();
            isChange = false;


        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            BrowsePic();
        }

        private void cmbTipe_SelectedValueChanged(object sender, EventArgs e)
        {
            isChange = true;
            doStuff();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (isChange)
            {
                isClose = true;
                if (XtraMessageBox.Show(this, "Car Info has been changed. Do you want to save changes?", clsGlobal.pstrAppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnSave_Click(sender, e);
                }
                else
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                }
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }

        private void frmCarInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                btnClose_Click(sender, e);
            }
        }

        private void txtPlatnumber_EditValueChanged(object sender, EventArgs e)
        {
            isChange = true;
        }

        private void txtKategori_EditValueChanged(object sender, EventArgs e)
        {
            isChange = true;
        }

        private void txtBrand_EditValueChanged(object sender, EventArgs e)
        {
            isChange = true;
        }

        private void txtHarga_EditValueChanged(object sender, EventArgs e)
        {
            isChange = true;
        }

        private void txtkapasitas_ValueChanged(object sender, EventArgs e)
        {
            isChange = true;
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            isChange = true;
        }

        private void pFoto_ImageChanged(object sender, EventArgs e)
        {
            openimage = true;
        }
    }
}