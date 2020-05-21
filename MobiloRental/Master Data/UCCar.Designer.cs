namespace MobiloRental.Master_Data
{
    partial class UCCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCar));
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnViewData = new DevExpress.XtraEditors.SimpleButton();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPlatnumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypename = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ricmbCarType = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrandname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPCapacity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riAvailable = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riImagebtn = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colCarId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgData = new DevExpress.XtraGrid.GridControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricmbCarType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riImagebtn)).BeginInit();
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCreate);
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.btnViewData);
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(3, 539);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1216, 67);
            this.panelControl1.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(6, 11);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(137, 50);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create Data";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(328, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 50);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnViewData
            // 
            this.btnViewData.Location = new System.Drawing.Point(169, 11);
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.Size = new System.Drawing.Size(137, 50);
            this.btnViewData.TabIndex = 10;
            this.btnViewData.Text = "View Data";
            this.btnViewData.Click += new System.EventHandler(this.btnView);
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
            this.colPlatnumber,
            this.colTypename,
            this.colCategory,
            this.colBrandname,
            this.colDescription,
            this.colPCapacity,
            this.colPrice,
            this.colStatus,
            this.colImage,
            this.colCarId,
            this.colTypeid});
            this.gridViewData.GridControl = this.dgData;
            this.gridViewData.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewData.OptionsFind.AlwaysVisible = true;
            this.gridViewData.OptionsView.ColumnAutoWidth = false;
            this.gridViewData.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewData.OptionsView.RowAutoHeight = true;
            this.gridViewData.OptionsView.ShowGroupedColumns = true;
            this.gridViewData.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewData_CellValueChanged);
            this.gridViewData.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewData_CellValueChanging);
            this.gridViewData.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewData_ValidateRow);
            this.gridViewData.DoubleClick += new System.EventHandler(this.gridViewData_DoubleClick);
            // 
            // colPlatnumber
            // 
            this.colPlatnumber.Caption = "Plat Number";
            this.colPlatnumber.FieldName = "platnumber";
            this.colPlatnumber.Name = "colPlatnumber";
            this.colPlatnumber.OptionsColumn.ReadOnly = true;
            this.colPlatnumber.Visible = true;
            this.colPlatnumber.VisibleIndex = 0;
            // 
            // colTypename
            // 
            this.colTypename.Caption = "Type";
            this.colTypename.ColumnEdit = this.ricmbCarType;
            this.colTypename.FieldName = "typename";
            this.colTypename.Name = "colTypename";
            this.colTypename.OptionsColumn.ReadOnly = true;
            this.colTypename.Visible = true;
            this.colTypename.VisibleIndex = 1;
            this.colTypename.Width = 230;
            // 
            // ricmbCarType
            // 
            this.ricmbCarType.AutoHeight = false;
            this.ricmbCarType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ricmbCarType.Name = "ricmbCarType";
            // 
            // colCategory
            // 
            this.colCategory.Caption = "Category";
            this.colCategory.FieldName = "categoryname";
            this.colCategory.Name = "colCategory";
            this.colCategory.OptionsColumn.ReadOnly = true;
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 2;
            this.colCategory.Width = 200;
            // 
            // colBrandname
            // 
            this.colBrandname.Caption = "Brand";
            this.colBrandname.FieldName = "brandname";
            this.colBrandname.Name = "colBrandname";
            this.colBrandname.OptionsColumn.ReadOnly = true;
            this.colBrandname.Visible = true;
            this.colBrandname.VisibleIndex = 3;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "description";
            this.colDescription.FieldName = "description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.ReadOnly = true;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            // 
            // colPCapacity
            // 
            this.colPCapacity.Caption = "Capacity";
            this.colPCapacity.FieldName = "passengercapacity";
            this.colPCapacity.Name = "colPCapacity";
            this.colPCapacity.OptionsColumn.ReadOnly = true;
            this.colPCapacity.Visible = true;
            this.colPCapacity.VisibleIndex = 5;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Price";
            this.colPrice.FieldName = "price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.ReadOnly = true;
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 6;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Available";
            this.colStatus.ColumnEdit = this.riAvailable;
            this.colStatus.FieldName = "statusavailable";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 7;
            // 
            // riAvailable
            // 
            this.riAvailable.AutoHeight = false;
            this.riAvailable.Name = "riAvailable";
            this.riAvailable.CheckedChanged += new System.EventHandler(this.riAvailable_CheckedChanged);
            this.riAvailable.EditValueChanged += new System.EventHandler(this.riAvailable_EditValueChanged);
            // 
            // colImage
            // 
            this.colImage.Caption = "Image";
            this.colImage.ColumnEdit = this.riImagebtn;
            this.colImage.FieldName = "imagename";
            this.colImage.Name = "colImage";
            this.colImage.OptionsColumn.ReadOnly = true;
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 8;
            this.colImage.Width = 96;
            // 
            // riImagebtn
            // 
            this.riImagebtn.AutoHeight = false;
            this.riImagebtn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.riImagebtn.Name = "riImagebtn";
            // 
            // colCarId
            // 
            this.colCarId.Caption = "Car Id";
            this.colCarId.FieldName = "carid";
            this.colCarId.Name = "colCarId";
            // 
            // colTypeid
            // 
            this.colTypeid.Caption = "Type Id";
            this.colTypeid.FieldName = "typeid1";
            this.colTypeid.Name = "colTypeid";
            this.colTypeid.Width = 116;
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
            this.ricmbCarType,
            this.riImagebtn,
            this.riAvailable});
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
            this.groupControl1.Text = "Car Management";
            // 
            // UCCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "UCCar";
            this.Size = new System.Drawing.Size(1222, 609);
            this.Leave += new System.EventHandler(this.UCCar_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricmbCarType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riImagebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn colPlatnumber;
        private DevExpress.XtraGrid.Columns.GridColumn colTypename;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandname;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colPCapacity;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraGrid.Columns.GridColumn colCarId;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeid;
        private DevExpress.XtraGrid.GridControl dgData;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox ricmbCarType;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit riImagebtn;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnViewData;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riAvailable;
    }
}
