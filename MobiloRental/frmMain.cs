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
using Library;
using DevExpress.Utils;
using Npgsql;

namespace MobiloRental
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        frmLogin formSplash;
        clsRegKey oReg = new clsRegKey();
        static WaitDialogForm loadDialog;
        private bool isActive = true;
        bool isVisible = true;
        public frmMain fMain;
        public frmMain()
        {
            try
            {
                formSplash = new frmLogin();
                formSplash.ShowDialog(this);
                if (formSplash.DialogResult == DialogResult.OK)
                {
                    clsGlobal.xpatchDatabase();
                   
                    loadDialog = new WaitDialogForm("Loading Components...", "Processing...Please Wait...", new Size(420, 78));
                    InitializeComponent();

                    if (clsGlobal.bolevaluationversion)
                    {
                        clsGlobal.pstrAppName = "EVALUATION VERSION - Mobilo Rental";
                        this.Text = "EVALUATION VERSION - Mobilo Rental";
                    }
                    else
                    {
                        clsGlobal.pstrAppName = "MobiloRental";
                        this.Text = "Mobilo Rental";
                    }

                    oReg.RegistryPathCurrentUser = clsGlobal.s_FullRegKey;

                    using (clsConnection oconn = new clsConnection())
                    {
                        oconn.Open();


                        lblWelcome.Text = "WELCOME : " + clsGlobal.strUserName.ToUpper();
                        lblPosition.Text ="POSITION : " + clsGlobal.strGroupUser.ToUpper();
                        oconn.Close();
                    }
                    setUserPrivillage();
                    nbiVisibility();

                }
            }
            catch
            {
            }
            finally
            {
                setLoadDialog(false, "");
            }

            try
            {
                if (clsGlobal.isusebackgroundimage)
                {
                    if (System.IO.File.Exists(Application.StartupPath.ToString() + "\\bg\\mainbg.jpg"))
                    {
                        panelHome.Visible = true;
                        panelHome.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + "\\bg\\mainbg.jpg");
                        panelHome.BackgroundImageLayout = ImageLayout.Stretch;

                    }

                }
            }
            catch (Exception ex)
            {

            }
        }
        public static void setLoadDialog(bool isVisible, string caption)
        {
            if (loadDialog == null) return;
            if (loadDialog.IsDisposed == true)
            {
                loadDialog = new WaitDialogForm("Loading Components...", "Processing...Please Wait...", new Size(420, 78));
            }

            loadDialog.Visible = isVisible;
            if (isVisible)
            {
                loadDialog.TopMost = false;
                loadDialog.TopLevel = true;
                loadDialog.Caption = caption;
                Application.DoEvents();
            }
        }

        private void nbiVisibility()
        {
            if (clsGlobal.strGroupUser == "admin" || clsGlobal.strUserName.ToLower() == "adminmr")
            {
                nbiUser.Visible = true;
                nbiCarCategory.Visible = false;
                nbiCarBrand.Visible = false;
                nbiCarType.Visible = false;
                nbiCar.Visible = false;
                nbiCustomer.Visible = false;
                nbgTransaction.Visible = false;
                nbgReport.Visible = false;
            }
            else if (clsGlobal.strGroupUser.ToLower() == "frontuser" || clsGlobal.strUserName.ToLower() == "frontmr")
            {
                foPrivillage();
            }
        }
        private void adminPrivillage()
        {
            nbiUser.Visible = true;
            nbiCarCategory.Visible = false;
            nbiCarBrand.Visible = false;
            nbiCarType.Visible = false;
            nbiCar.Visible = false;
            nbiCustomer.Visible = false;
            nbgTransaction.Visible = false;
            nbgReport.Visible = false;
            
        }
        private void foPrivillage()
        {
            nbiUser.Visible = false;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = FormBorderStyle.None;
            
        }
        private bool bolRead, bolAdd, bolEdit, bolDelete, bolPrint, bolSave, bolDownload, bolUpload;
        private Master_Data.UCUser userForm;
        private void nbiUser_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelMain.Controls.Clear();
            nbiUser.Enabled = false;
            if (panelMain.Controls.Contains(userForm) == false)
            {
                
                userForm = new Master_Data.UCUser();
                panelMain.Controls.Add(userForm);
                barButtonItemCloseClick(false);
                userForm.Dock = DockStyle.Fill;

            }
            userForm.fMain = this;
            setUserPrivillage(Convert.ToString(e.Link.Item.Tag).ToLower(), userForm);
            userForm.Refresh();

            this.Text = clsGlobal.pstrAppName + " [" + Convert.ToString(e.Link.Caption) + "]";
            nbiUser.Enabled = true;
        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBawah_Paint(object sender, PaintEventArgs e)
        {

        }

        private void navBarControl1_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            barButtonItemCloseClick(true);
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F5)
                {
                    this.Refresh();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void panelMain_ControlAdded(object sender, ControlEventArgs e)
        {
            panelMain.Visible = true;
            panelHome.Visible = !panelMain.Visible;
        }

        private void panelMain_ControlRemoved(object sender, ControlEventArgs e)
        {
            try
            {
                bool bolVisible = (panelMain.Controls.Count > 0);
                foreach (Control ctl in panelMain.Controls)
                {
                    bolVisible = false;
                    if (ctl.Visible)
                    {
                        bolVisible = true;
                        break;
                    }
                }

                panelMain.Visible = bolVisible;
                panelHome.Visible = !panelMain.Visible;
            }
            catch { }
        }
        private Master_Data.UCCarCategory CarCategoryForm;
        private void nbiCarCategory_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelMain.Controls.Clear();
            nbiCarCategory.Enabled = false;
            if (panelMain.Controls.Contains(CarCategoryForm) == false)
            {

                CarCategoryForm = new Master_Data.UCCarCategory();
                panelMain.Controls.Add(CarCategoryForm);
                barButtonItemCloseClick(false);
                CarCategoryForm.Dock = DockStyle.Fill;

            }
            CarCategoryForm.fMain = this;
            setUserPrivillage(Convert.ToString(e.Link.Item.Tag).ToLower(), CarCategoryForm);
            CarCategoryForm.Refresh();

            this.Text = clsGlobal.pstrAppName + " [" + Convert.ToString(e.Link.Caption) + "]";
            nbiCarCategory.Enabled = true;
        }
        private Master_Data.UCCarBrand CarBrand;
        private void nbiCarBrand_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelMain.Controls.Clear();
            nbiCarBrand.Enabled = false;
            if (panelMain.Controls.Contains(CarBrand) == false)
            {

                CarBrand = new Master_Data.UCCarBrand();
                panelMain.Controls.Add(CarBrand);
                barButtonItemCloseClick(false);
                CarBrand.Dock = DockStyle.Fill;
            }
            CarBrand.fMain = this;
            setUserPrivillage(Convert.ToString(e.Link.Item.Tag).ToLower(), CarBrand);
            CarBrand.Refresh();

            this.Text = clsGlobal.pstrAppName + " [" + Convert.ToString(e.Link.Caption) + "]";
            nbiCarBrand.Enabled = true;
        }
        private Master_Data.UCCarType CarType;
        private void nbiCarType_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelMain.Controls.Clear();
            nbiCarType.Enabled = false;
            if (panelMain.Controls.Contains(CarType) == false)
            {

                CarType = new Master_Data.UCCarType();
                panelMain.Controls.Add(CarType);
                barButtonItemCloseClick(false);
                CarType.Dock = DockStyle.Fill;

            }
            CarType.fMain = this;
            setUserPrivillage(Convert.ToString(e.Link.Item.Tag).ToLower(), CarType);
            CarType.Refresh();

            this.Text = clsGlobal.pstrAppName + " [" + Convert.ToString(e.Link.Caption) + "]";
            nbiCarType.Enabled = true;
        }

        private Master_Data.UCCar Car;
        private void nbiCar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelMain.Controls.Clear();
            nbiCar.Enabled = false;
            if (panelMain.Controls.Contains(Car) == false)
            {

                Car = new Master_Data.UCCar();
                panelMain.Controls.Add(Car);
                barButtonItemCloseClick(false);
                Car.Dock = DockStyle.Fill;

            }
            Car.fMain = this;
            setUserPrivillage(Convert.ToString(e.Link.Item.Tag).ToLower(), Car);
            Car.Refresh();

            this.Text = clsGlobal.pstrAppName + " [" + Convert.ToString(e.Link.Caption) + "]";
            nbiCar.Enabled = true;
        }
        private UCCustomer Customer;
        private void nbiCustomer_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelMain.Controls.Clear();
            nbiCustomer.Enabled = false;
            if (panelMain.Controls.Contains(Customer) == false)
            {

                Customer = new UCCustomer();
                panelMain.Controls.Add(Customer);
                barButtonItemCloseClick(false);
                Customer.Dock = DockStyle.Fill;

            }
            Customer.fMain = this;
            setUserPrivillage(Convert.ToString(e.Link.Item.Tag).ToLower(), Customer);
            Customer.Refresh();

            this.Text = clsGlobal.pstrAppName + " [" + Convert.ToString(e.Link.Caption) + "]";
            nbiCustomer.Enabled = true;
        }
        private Transaction.UCBooking Booking;
        private void nbiBooking_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelMain.Controls.Clear();
            nbiBooking.Enabled = false;
            if (panelMain.Controls.Contains(Booking) == false)
            {

                Booking = new Transaction.UCBooking();
                panelMain.Controls.Add(Booking);
                barButtonItemCloseClick(false);
                Booking.Dock = DockStyle.Fill;
            }
            Booking.fMain = this;
            setUserPrivillage(Convert.ToString(e.Link.Item.Tag).ToLower(), Booking);
            Booking.Refresh();

            this.Text = clsGlobal.pstrAppName + " [" + Convert.ToString(e.Link.Caption) + "]";
            nbiBooking.Enabled = true;
        }
        private Transaction.UCReturn Return;
        private void nbiReturn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelMain.Controls.Clear();
            nbiReturn.Enabled = false;
            if (panelMain.Controls.Contains(Return) == false)
            {

                Return = new Transaction.UCReturn();
                panelMain.Controls.Add(Return);
                barButtonItemCloseClick(false);
                Return.Dock = DockStyle.Fill;
            }
            Return.fMain = this;
            setUserPrivillage(Convert.ToString(e.Link.Item.Tag).ToLower(), Return);
            Return.Refresh();

            this.Text = clsGlobal.pstrAppName + " [" + Convert.ToString(e.Link.Caption) + "]";
            nbiReturn.Enabled = true;
        }
        private Transaction.UCRepair Repair;
        private void nbiRepair_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelMain.Controls.Clear();
            nbiRepair.Enabled = false;
            if (panelMain.Controls.Contains(Repair) == false)
            {

                Repair = new Transaction.UCRepair();
                panelMain.Controls.Add(Repair);
                barButtonItemCloseClick(false);
                Repair.Dock = DockStyle.Fill;
            }
            Repair.fMain = this;
            setUserPrivillage(Convert.ToString(e.Link.Item.Tag).ToLower(), Repair);
            Repair.Refresh();

            this.Text = clsGlobal.pstrAppName + " [" + Convert.ToString(e.Link.Caption) + "]";
            nbiRepair.Enabled = true;
        }
        private Report.UCExportBooking DBooking;
        private void nbiDBooking_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelMain.Controls.Clear();
            nbiDBooking.Enabled = false;
            if (panelMain.Controls.Contains(DBooking) == false)
            {

                DBooking = new Report.UCExportBooking();
                panelMain.Controls.Add(DBooking);
                barButtonItemCloseClick(false);
                DBooking.Dock = DockStyle.Fill;
            }
            DBooking.fMain = this;
            setUserPrivillage(Convert.ToString(e.Link.Item.Tag).ToLower(), DBooking);
            DBooking.Refresh();

            this.Text = clsGlobal.pstrAppName + " [" + Convert.ToString(e.Link.Caption) + "]";
            nbiDBooking.Enabled = true;
        }
        private Report.UCDataReturn DReturn;
        private void nbiDReturn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelMain.Controls.Clear();
            nbiDReturn.Enabled = false;
            if (panelMain.Controls.Contains(DReturn) == false)
            {

                DReturn = new Report.UCDataReturn();
                panelMain.Controls.Add(DReturn);
                barButtonItemCloseClick(false);
                DReturn.Dock = DockStyle.Fill;
            }
            DReturn.fMain = this;
            setUserPrivillage(Convert.ToString(e.Link.Item.Tag).ToLower(), DReturn);
            DReturn.Refresh();

            this.Text = clsGlobal.pstrAppName + " [" + Convert.ToString(e.Link.Caption) + "]";
            nbiDReturn.Enabled = true;
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            doLogout(); 
        }
        public void doLogout()
        {
            clsGlobal.dtCekAkses = null;
            this.Hide();
            frmMain frm = new frmMain();
            frm.Show();
        }
        private UCAbout About;
        private void nbiAbout_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelMain.Controls.Clear();
            nbiAbout.Enabled = false;
            if (panelMain.Controls.Contains(About) == false)
            {

                About = new UCAbout();
                panelMain.Controls.Add(About);
                barButtonItemCloseClick(false);
                About.Dock = DockStyle.Fill;
            }
            About.fMain = this;
            setUserPrivillage(Convert.ToString(e.Link.Item.Tag).ToLower(), About);
            About.Refresh();

            this.Text = clsGlobal.pstrAppName + " [" + Convert.ToString(e.Link.Caption) + "]";
            nbiAbout.Enabled = true;
        }

        public void barButtonItemCloseClick(bool bolShowHomePanel)
        {
            try
            {
                this.Text = clsGlobal.pstrAppName;
                if (panelMain.Controls.Count > 0)
                {
                    foreach (Control ctl in panelMain.Controls)
                    {
                        if (ctl.GetType().ToString().Substring(0, 7).Equals("Payroll"))
                        {
                            ctl.Dispose();
                        }
                    }
                    if (bolShowHomePanel == false)
                        panelHome.Visible = false;
                    else
                        panelHome.Visible = !panelMain.Visible;

                }
                else
                {
                    panelMain.Visible = false;
                    panelHome.Visible = !panelMain.Visible;
                }
            }
            catch
            {
            }
            finally
            {
                setLoadDialog(false, "");
            }
        }
        public void closeUC(bool bolShowHomePanel)
        {
            try
            {
                this.Text = clsGlobal.pstrAppName;
                if (panelMain.Controls.Count > 0)
                {
                    foreach (Control ctl in panelMain.Controls)
                    {
                        if (ctl.GetType().ToString().Substring(0, 7).Equals("Payroll"))
                        {
                            ctl.Dispose();
                        }
                    }
                    if (bolShowHomePanel == false)
                        panelHome.Visible = false;
                    else
                        panelHome.Visible = !panelMain.Visible;

                }
                else
                {
                    panelMain.Visible = false;
                    panelHome.Visible = !panelMain.Visible;
                }
            }
            catch
            {
            }
            finally
            {
                setLoadDialog(false, "");
            }
        }


        private void frmMain_Deactivate(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void frmMain_Activated(object sender, EventArgs e)
         {
            isActive = true;
        }
        private void setUserPrivillage(string moduleName, object frmName)
        {
            if (frmName == null) return;
            bolRead = false;
            bolAdd = false;
            bolEdit = false;
            bolDelete = false;
            bolPrint = false;
            bolSave = false;
            bolDownload = false;
            bolUpload = false;

            if (clsGlobal.CekAkses(moduleName, ref bolRead, ref bolAdd, ref bolEdit,
                                        ref bolDelete, ref bolPrint, ref bolSave, ref bolDownload, ref bolUpload) == true)
            {
            }
            clsGlobal.bolRead = bolRead;
            clsGlobal.bolAdd = bolAdd;
            clsGlobal.bolEdit = bolEdit;
            clsGlobal.bolDelete = bolDelete;
            clsGlobal.bolPrint = bolPrint;
            clsGlobal.bolSave = bolSave;
            clsGlobal.bolDownload = bolDownload;
            clsGlobal.bolUpload = bolUpload;


            switch (frmName.ToString().ToLower())
            {
                case "OniQ.usercontrolbusinessunit":
                    {
                        //userControlBusinessUnit fname = frmName as userControlBusinessUnit;

                        //fname.btnCreateNew.Enabled = bolAdd;
                        //fname.btnEdit.Enabled = bolEdit;
                        //fname.btnDelete.Enabled = bolDelete;
                        //fname.btnSave.Enabled = bolAdd || bolEdit;
                        //fname.btnCancel.Enabled = bolEdit;
                        ////fname.btnPreview.Enabled = bolPrint;
                        break;
                    }


                default:
                    {
                        break;
                    }
            }
            //if (clsGlobal.strUsername.ToLower() == "superadmin" || clsGlobal.strGroupUser.ToLower() == "superadmin")
            //{
            clsGlobal.bolRead = true;
            clsGlobal.bolAdd = true;
            clsGlobal.bolEdit = true;
            clsGlobal.bolDelete = true;
            clsGlobal.bolPrint = true;
            clsGlobal.bolSave = true;
            //}
        }
        private void setUserPrivillage()
        {

            bolRead = false;
            bolAdd = false;
            bolEdit = false;
            bolDelete = false;
            bolPrint = false;
            bolSave = false;
            bolDownload = false;
            bolUpload = false;

            //bool bolShowRptTab = false;

            NpgsqlCommand NpCmd = new NpgsqlCommand();
            clsConnection oconn = new clsConnection();

            NpCmd.CommandText = @"SELECT moduleid, module_nama, ket
                            FROM tbmmodule where dlt='0'";

            NpgsqlDataReader npdr = oconn.ReadData(NpCmd);
            while (npdr.Read())
            {
                if (clsGlobal.CekAkses(npdr["module_nama"].ToString(), ref bolRead, ref bolAdd, ref bolEdit,
                                            ref bolDelete, ref bolPrint, ref bolSave, ref bolDownload, ref bolUpload) == false)
                {


                    DevExpress.XtraNavBar.NavBarItem nbiDA = navBarControl1.Items[npdr["moduleid"].ToString()] as DevExpress.XtraNavBar.NavBarItem;
                    if (nbiDA != null)
                    {
                        nbiDA.Visible = false;
                        continue;
                    }
                }
            }


        }
        public void close()
        {
            panelMain.Controls.Clear();
        }
    }
}