namespace MobiloRental
{
    partial class UCCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCustomer));
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnEndEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdentityType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ricmbIdentityType = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colIdentityNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ricmbGender = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgData = new DevExpress.XtraGrid.GridControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricmbIdentityType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricmbGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1074, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 50);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEndEdit
            // 
            this.btnEndEdit.Enabled = false;
            this.btnEndEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEndEdit.Image")));
            this.btnEndEdit.Location = new System.Drawing.Point(152, 7);
            this.btnEndEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEndEdit.Name = "btnEndEdit";
            this.btnEndEdit.Size = new System.Drawing.Size(135, 50);
            this.btnEndEdit.TabIndex = 2;
            this.btnEndEdit.Text = "E&nd Edit";
            this.btnEndEdit.Click += new System.EventHandler(this.btnEndEdit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(8, 7);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(135, 50);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.btnEndEdit);
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.btnEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(3, 539);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1216, 67);
            this.panelControl1.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(296, 7);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 50);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gridViewData
            // 
            this.gridViewData.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridViewData.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewData.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewData.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewData.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewData.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerid,
            this.colName,
            this.colIdentityType,
            this.colIdentityNumber,
            this.colGender,
            this.colPhoneNumber,
            this.colDob,
            this.colAddress});
            this.gridViewData.GridControl = this.dgData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewData.OptionsBehavior.Editable = false;
            this.gridViewData.OptionsFind.AlwaysVisible = true;
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewData.OptionsView.RowAutoHeight = true;
            this.gridViewData.OptionsView.ShowGroupedColumns = true;
            this.gridViewData.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewData_ValidateRow);
            // 
            // colCustomerid
            // 
            this.colCustomerid.Caption = "Customer Id";
            this.colCustomerid.FieldName = "customerid";
            this.colCustomerid.Name = "colCustomerid";
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 160;
            // 
            // colIdentityType
            // 
            this.colIdentityType.Caption = "Identity Type";
            this.colIdentityType.ColumnEdit = this.ricmbIdentityType;
            this.colIdentityType.FieldName = "identity_type";
            this.colIdentityType.Name = "colIdentityType";
            this.colIdentityType.Visible = true;
            this.colIdentityType.VisibleIndex = 1;
            this.colIdentityType.Width = 194;
            // 
            // ricmbIdentityType
            // 
            this.ricmbIdentityType.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
            this.ricmbIdentityType.AutoHeight = false;
            this.ricmbIdentityType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ricmbIdentityType.Name = "ricmbIdentityType";
            this.ricmbIdentityType.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colIdentityNumber
            // 
            this.colIdentityNumber.Caption = "Identity Number";
            this.colIdentityNumber.FieldName = "identity_number";
            this.colIdentityNumber.Name = "colIdentityNumber";
            this.colIdentityNumber.Visible = true;
            this.colIdentityNumber.VisibleIndex = 2;
            this.colIdentityNumber.Width = 236;
            // 
            // colGender
            // 
            this.colGender.Caption = "Gender";
            this.colGender.ColumnEdit = this.ricmbGender;
            this.colGender.FieldName = "gender";
            this.colGender.Name = "colGender";
            this.colGender.Visible = true;
            this.colGender.VisibleIndex = 3;
            this.colGender.Width = 180;
            // 
            // ricmbGender
            // 
            this.ricmbGender.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
            this.ricmbGender.AutoHeight = false;
            this.ricmbGender.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ricmbGender.Name = "ricmbGender";
            this.ricmbGender.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.Caption = "Phone Number";
            this.colPhoneNumber.FieldName = "phonenumber";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.Visible = true;
            this.colPhoneNumber.VisibleIndex = 4;
            this.colPhoneNumber.Width = 212;
            // 
            // colDob
            // 
            this.colDob.Caption = "Date of Birth";
            this.colDob.ColumnEdit = this.riDate;
            this.colDob.FieldName = "dateofbirth";
            this.colDob.Name = "colDob";
            this.colDob.Visible = true;
            this.colDob.VisibleIndex = 5;
            this.colDob.Width = 247;
            // 
            // riDate
            // 
            this.riDate.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
            this.riDate.AutoHeight = false;
            this.riDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riDate.Name = "riDate";
            this.riDate.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Address";
            this.colAddress.FieldName = "address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 6;
            this.colAddress.Width = 189;
            // 
            // dgData
            // 
            this.dgData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgData.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgData.Location = new System.Drawing.Point(3, 40);
            this.dgData.MainView = this.gridViewData;
            this.dgData.Margin = new System.Windows.Forms.Padding(4);
            this.dgData.Name = "dgData";
            this.dgData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ricmbGender,
            this.ricmbIdentityType,
            this.riDate});
            this.dgData.Size = new System.Drawing.Size(1216, 499);
            this.dgData.TabIndex = 0;
            this.dgData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.dgData);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1222, 609);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Customer";
            // 
            // UCCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "UCCustomer";
            this.Size = new System.Drawing.Size(1222, 609);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricmbIdentityType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricmbGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnEndEdit;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerid;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentityType;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentityNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colGender;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDob;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.GridControl dgData;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox ricmbGender;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox ricmbIdentityType;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit riDate;
    }
}
