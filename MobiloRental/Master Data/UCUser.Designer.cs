namespace MobiloRental.Master_Data
{
    partial class UCUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCUser));
            this.gcontrolUsers = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnEndEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.dgData = new DevExpress.XtraGrid.GridControl();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupUsers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ricmbGroup = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcontrolUsers)).BeginInit();
            this.gcontrolUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricmbGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // gcontrolUsers
            // 
            this.gcontrolUsers.CaptionImage = ((System.Drawing.Image)(resources.GetObject("gcontrolUsers.CaptionImage")));
            this.gcontrolUsers.Controls.Add(this.panelControl1);
            this.gcontrolUsers.Controls.Add(this.dgData);
            this.gcontrolUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcontrolUsers.Location = new System.Drawing.Point(0, 0);
            this.gcontrolUsers.MinimumSize = new System.Drawing.Size(1222, 609);
            this.gcontrolUsers.Name = "gcontrolUsers";
            this.gcontrolUsers.Size = new System.Drawing.Size(1222, 609);
            this.gcontrolUsers.TabIndex = 1;
            this.gcontrolUsers.Text = "Manage User";
            this.gcontrolUsers.Paint += new System.Windows.Forms.PaintEventHandler(this.gcontrolUsers_Paint);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.btnEndEdit);
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.btnEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(3, 544);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1216, 62);
            this.panelControl1.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1048, 8);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 50);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEndEdit
            // 
            this.btnEndEdit.Enabled = false;
            this.btnEndEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEndEdit.Image")));
            this.btnEndEdit.Location = new System.Drawing.Point(284, 8);
            this.btnEndEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEndEdit.Name = "btnEndEdit";
            this.btnEndEdit.Size = new System.Drawing.Size(135, 50);
            this.btnEndEdit.TabIndex = 12;
            this.btnEndEdit.Text = "E&nd Edit";
            this.btnEndEdit.Click += new System.EventHandler(this.btnEndEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(478, 8);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 50);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(66, 8);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(135, 50);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dgData
            // 
            this.dgData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgData.Location = new System.Drawing.Point(3, 43);
            this.dgData.MainView = this.gridViewData;
            this.dgData.Name = "dgData";
            this.dgData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ricmbGroup});
            this.dgData.Size = new System.Drawing.Size(1216, 563);
            this.dgData.TabIndex = 1;
            this.dgData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            this.dgData.Click += new System.EventHandler(this.gridControl1_Click_1);
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserId,
            this.colUsername,
            this.colPassword,
            this.colFullname,
            this.colEmail,
            this.colGroupUsers,
            this.colActive});
            this.gridViewData.GridControl = this.dgData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsView.ShowGroupPanel = false;
            this.gridViewData.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewData_ValidateRow);
            // 
            // colUserId
            // 
            this.colUserId.Caption = "UserId";
            this.colUserId.FieldName = "userid";
            this.colUserId.Name = "colUserId";
            this.colUserId.OptionsColumn.ReadOnly = true;
            // 
            // colUsername
            // 
            this.colUsername.Caption = "Username";
            this.colUsername.FieldName = "username";
            this.colUsername.Name = "colUsername";
            this.colUsername.Visible = true;
            this.colUsername.VisibleIndex = 0;
            // 
            // colPassword
            // 
            this.colPassword.Caption = "Password";
            this.colPassword.FieldName = "password";
            this.colPassword.Name = "colPassword";
            this.colPassword.Visible = true;
            this.colPassword.VisibleIndex = 1;
            // 
            // colFullname
            // 
            this.colFullname.Caption = "Fullname";
            this.colFullname.FieldName = "fullname";
            this.colFullname.Name = "colFullname";
            this.colFullname.Visible = true;
            this.colFullname.VisibleIndex = 2;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 3;
            // 
            // colGroupUsers
            // 
            this.colGroupUsers.Caption = "GroupUsers";
            this.colGroupUsers.ColumnEdit = this.ricmbGroup;
            this.colGroupUsers.FieldName = "groupusers";
            this.colGroupUsers.Name = "colGroupUsers";
            this.colGroupUsers.Visible = true;
            this.colGroupUsers.VisibleIndex = 4;
            // 
            // ricmbGroup
            // 
            this.ricmbGroup.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
            this.ricmbGroup.AutoHeight = false;
            this.ricmbGroup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ricmbGroup.Name = "ricmbGroup";
            this.ricmbGroup.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colActive
            // 
            this.colActive.Caption = "Active";
            this.colActive.FieldName = "active";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 5;
            // 
            // UCUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.gcontrolUsers);
            this.MinimumSize = new System.Drawing.Size(1222, 609);
            this.Name = "UCUser";
            this.Size = new System.Drawing.Size(1222, 609);
            this.Load += new System.EventHandler(this.UCUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcontrolUsers)).EndInit();
            this.gcontrolUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricmbGroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcontrolUsers;
        private DevExpress.XtraGrid.GridControl dgData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn colUserId;
        private DevExpress.XtraGrid.Columns.GridColumn colUsername;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colFullname;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupUsers;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnEndEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox ricmbGroup;
    }
}
