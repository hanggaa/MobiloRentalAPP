namespace MobiloRental
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelBawah = new System.Windows.Forms.Panel();
            this.nbiDReturn = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiDBooking = new DevExpress.XtraNavBar.NavBarItem();
            this.nbgReport = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiUser = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiCustomer = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiCar = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiCarType = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiCarBrand = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiCarCategory = new DevExpress.XtraNavBar.NavBarItem();
            this.nbgMasterData = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiAbout = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiRepair = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiReturn = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiBooking = new DevExpress.XtraNavBar.NavBarItem();
            this.nbgTransaction = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLogout = new System.Windows.Forms.Label();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Version = new DevExpress.XtraEditors.LabelControl();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelAtas = new System.Windows.Forms.Panel();
            this.lblPosition = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelHome = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelAtas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBawah
            // 
            this.panelBawah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(159)))), ((int)(((byte)(206)))));
            this.panelBawah.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBawah.Location = new System.Drawing.Point(0, 975);
            this.panelBawah.Name = "panelBawah";
            this.panelBawah.Size = new System.Drawing.Size(1256, 35);
            this.panelBawah.TabIndex = 4;
            this.panelBawah.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBawah_Paint);
            // 
            // nbiDReturn
            // 
            this.nbiDReturn.Caption = "Data Return";
            this.nbiDReturn.Name = "nbiDReturn";
            this.nbiDReturn.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiDReturn.SmallImage")));
            this.nbiDReturn.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiDReturn_LinkClicked);
            // 
            // nbiDBooking
            // 
            this.nbiDBooking.Caption = "Data Booking";
            this.nbiDBooking.Name = "nbiDBooking";
            this.nbiDBooking.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiDBooking.SmallImage")));
            this.nbiDBooking.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiDBooking_LinkClicked);
            // 
            // nbgReport
            // 
            this.nbgReport.Caption = "Report";
            this.nbgReport.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiDBooking),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiDReturn)});
            this.nbgReport.Name = "nbgReport";
            this.nbgReport.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbgReport.SmallImage")));
            // 
            // nbiUser
            // 
            this.nbiUser.Caption = "Users";
            this.nbiUser.Name = "nbiUser";
            this.nbiUser.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiUser.SmallImage")));
            this.nbiUser.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiUser_LinkClicked);
            // 
            // nbiCustomer
            // 
            this.nbiCustomer.Caption = "Customer";
            this.nbiCustomer.Name = "nbiCustomer";
            this.nbiCustomer.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiCustomer.SmallImage")));
            this.nbiCustomer.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiCustomer_LinkClicked);
            // 
            // nbiCar
            // 
            this.nbiCar.Caption = "Car";
            this.nbiCar.Name = "nbiCar";
            this.nbiCar.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiCar.SmallImage")));
            this.nbiCar.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiCar_LinkClicked);
            // 
            // nbiCarType
            // 
            this.nbiCarType.Caption = "Car Type";
            this.nbiCarType.Name = "nbiCarType";
            this.nbiCarType.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiCarType.SmallImage")));
            this.nbiCarType.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiCarType_LinkClicked);
            // 
            // nbiCarBrand
            // 
            this.nbiCarBrand.Caption = "Car Brand";
            this.nbiCarBrand.Name = "nbiCarBrand";
            this.nbiCarBrand.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiCarBrand.SmallImage")));
            this.nbiCarBrand.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiCarBrand_LinkClicked);
            // 
            // nbiCarCategory
            // 
            this.nbiCarCategory.Caption = "Car Category";
            this.nbiCarCategory.Name = "nbiCarCategory";
            this.nbiCarCategory.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiCarCategory.SmallImage")));
            this.nbiCarCategory.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiCarCategory_LinkClicked);
            // 
            // nbgMasterData
            // 
            this.nbgMasterData.Caption = "Master Data";
            this.nbgMasterData.Expanded = true;
            this.nbgMasterData.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiCarCategory),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiCarBrand),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiCarType),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiCar),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiCustomer),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiUser),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiAbout)});
            this.nbgMasterData.Name = "nbgMasterData";
            this.nbgMasterData.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbgMasterData.SmallImage")));
            // 
            // nbiAbout
            // 
            this.nbiAbout.Caption = "About";
            this.nbiAbout.Name = "nbiAbout";
            this.nbiAbout.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiAbout.SmallImage")));
            this.nbiAbout.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiAbout_LinkClicked);
            // 
            // nbiRepair
            // 
            this.nbiRepair.Caption = "Repair";
            this.nbiRepair.Name = "nbiRepair";
            this.nbiRepair.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiRepair.SmallImage")));
            this.nbiRepair.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiRepair_LinkClicked);
            // 
            // nbiReturn
            // 
            this.nbiReturn.Caption = "Return";
            this.nbiReturn.Name = "nbiReturn";
            this.nbiReturn.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiReturn.SmallImage")));
            this.nbiReturn.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiReturn_LinkClicked);
            // 
            // nbiBooking
            // 
            this.nbiBooking.Caption = "Booking";
            this.nbiBooking.Name = "nbiBooking";
            this.nbiBooking.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiBooking.SmallImage")));
            this.nbiBooking.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiBooking_LinkClicked);
            // 
            // nbgTransaction
            // 
            this.nbgTransaction.Caption = "Transaction ";
            this.nbgTransaction.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiBooking),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiReturn),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiRepair)});
            this.nbgTransaction.Name = "nbgTransaction";
            this.nbgTransaction.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbgTransaction.SmallImage")));
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.nbgMasterData;
            this.navBarControl1.BackColor = System.Drawing.Color.Transparent;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nbgMasterData,
            this.nbgTransaction,
            this.nbgReport});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbiCarCategory,
            this.nbiCarBrand,
            this.nbiCarType,
            this.nbiCar,
            this.nbiCustomer,
            this.nbiBooking,
            this.nbiReturn,
            this.nbiRepair,
            this.nbiDBooking,
            this.nbiDReturn,
            this.nbiUser,
            this.nbiAbout});
            this.navBarControl1.Location = new System.Drawing.Point(0, 73);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 281;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(281, 902);
            this.navBarControl1.TabIndex = 3;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.ActiveGroupChanged += new DevExpress.XtraNavBar.NavBarGroupEventHandler(this.navBarControl1_ActiveGroupChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(159)))), ((int)(((byte)(206)))));
            this.panel2.Controls.Add(this.lblLogout);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Controls.Add(this.Version);
            this.panel2.Controls.Add(this.lblWelcome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1256, 37);
            this.panel2.TabIndex = 0;
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.BackColor = System.Drawing.Color.Transparent;
            this.lblLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLogout.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblLogout.ForeColor = System.Drawing.Color.White;
            this.lblLogout.Location = new System.Drawing.Point(1170, 0);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(86, 24);
            this.lblLogout.TabIndex = 5;
            this.lblLogout.Text = "LOGOUT";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Location = new System.Drawing.Point(1541, 19);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 24);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "LOGOUT";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(1522, 11);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 34);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "|";
            // 
            // Version
            // 
            this.Version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Version.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Version.Appearance.ForeColor = System.Drawing.Color.White;
            this.Version.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Version.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Version.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Version.Location = new System.Drawing.Point(1049, 15);
            this.Version.Margin = new System.Windows.Forms.Padding(4);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(438, 32);
            this.Version.TabIndex = 3;
            this.Version.Text = "Version : 1xxx.xxx";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(25, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(171, 24);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "WELCOME : NAME";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Location = new System.Drawing.Point(1409, 62);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(104, 24);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "00 : 00 : 00";
            // 
            // panelAtas
            // 
            this.panelAtas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(102)))), ((int)(((byte)(123)))));
            this.panelAtas.Controls.Add(this.lblPosition);
            this.panelAtas.Controls.Add(this.labelControl3);
            this.panelAtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAtas.Location = new System.Drawing.Point(0, 37);
            this.panelAtas.Name = "panelAtas";
            this.panelAtas.Size = new System.Drawing.Size(1256, 39);
            this.panelAtas.TabIndex = 2;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblPosition.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblPosition.ForeColor = System.Drawing.Color.White;
            this.lblPosition.Location = new System.Drawing.Point(28, 3);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(178, 24);
            this.lblPosition.TabIndex = 5;
            this.lblPosition.Text = "POSITION : GUEST";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.panelAtas);
            this.panelControl1.Controls.Add(this.panel2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.MinimumSize = new System.Drawing.Size(1256, 73);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1256, 73);
            this.panelControl1.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(281, 73);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(3);
            this.panelMain.Size = new System.Drawing.Size(975, 902);
            this.panelMain.TabIndex = 0;
            this.panelMain.Visible = false;
            this.panelMain.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panelMain_ControlAdded);
            this.panelMain.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panelMain_ControlRemoved);
            // 
            // panelHome
            // 
            this.panelHome.AutoSize = true;
            this.panelHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelHome.BackgroundImage")));
            this.panelHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHome.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(281, 73);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(975, 902);
            this.panelHome.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 1010);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.panelBawah);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1278, 1066);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mobilo Rental";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.Deactivate += new System.EventHandler(this.frmMain_Deactivate);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelAtas.ResumeLayout(false);
            this.panelAtas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBawah;
        private DevExpress.XtraNavBar.NavBarItem nbiDReturn;
        private DevExpress.XtraNavBar.NavBarItem nbiDBooking;
        private DevExpress.XtraNavBar.NavBarGroup nbgReport;
        private DevExpress.XtraNavBar.NavBarItem nbiUser;
        private DevExpress.XtraNavBar.NavBarItem nbiCustomer;
        private DevExpress.XtraNavBar.NavBarItem nbiCar;
        private DevExpress.XtraNavBar.NavBarItem nbiCarType;
        private DevExpress.XtraNavBar.NavBarItem nbiCarBrand;
        private DevExpress.XtraNavBar.NavBarItem nbiCarCategory;
        private DevExpress.XtraNavBar.NavBarGroup nbgMasterData;
        private DevExpress.XtraNavBar.NavBarItem nbiRepair;
        private DevExpress.XtraNavBar.NavBarItem nbiReturn;
        private DevExpress.XtraNavBar.NavBarItem nbiBooking;
        private DevExpress.XtraNavBar.NavBarGroup nbgTransaction;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl Version;
        private System.Windows.Forms.Label lblWelcome;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Panel panelAtas;
        private System.Windows.Forms.Label lblPosition;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label lblLogout;
        private DevExpress.XtraNavBar.NavBarItem nbiAbout;
    }
}