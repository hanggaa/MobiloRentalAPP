namespace MobiloRental.Master_Data
{
    partial class UCCarType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCarType));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgData = new DevExpress.XtraGrid.GridControl();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTypeid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ricmbCategory = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colBrandname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ricmbBrand = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colTypename = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrandId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnEndEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricmbCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricmbBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Car Type";
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
            this.ricmbCategory,
            this.ricmbBrand});
            this.dgData.Size = new System.Drawing.Size(1216, 499);
            this.dgData.TabIndex = 0;
            this.dgData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
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
            this.colTypeid,
            this.colCategoryname,
            this.colBrandname,
            this.colTypename,
            this.colCategoryid,
            this.colBrandId});
            this.gridViewData.GridControl = this.dgData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewData.OptionsBehavior.Editable = false;
            this.gridViewData.OptionsFind.AlwaysVisible = true;
            this.gridViewData.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewData.OptionsView.RowAutoHeight = true;
            this.gridViewData.OptionsView.ShowGroupedColumns = true;
            this.gridViewData.ShownEditor += new System.EventHandler(this.gridViewData_ShownEditor);
            this.gridViewData.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewData_ValidateRow);
            // 
            // colTypeid
            // 
            this.colTypeid.Caption = "Id";
            this.colTypeid.FieldName = "typeid";
            this.colTypeid.Name = "colTypeid";
            // 
            // colCategoryname
            // 
            this.colCategoryname.Caption = "Kategori";
            this.colCategoryname.ColumnEdit = this.ricmbCategory;
            this.colCategoryname.FieldName = "categoryname";
            this.colCategoryname.Name = "colCategoryname";
            this.colCategoryname.Visible = true;
            this.colCategoryname.VisibleIndex = 0;
            // 
            // ricmbCategory
            // 
            this.ricmbCategory.AutoHeight = false;
            this.ricmbCategory.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ricmbCategory.Name = "ricmbCategory";
            // 
            // colBrandname
            // 
            this.colBrandname.Caption = "Brand";
            this.colBrandname.ColumnEdit = this.ricmbBrand;
            this.colBrandname.FieldName = "brandname";
            this.colBrandname.Name = "colBrandname";
            this.colBrandname.Visible = true;
            this.colBrandname.VisibleIndex = 1;
            // 
            // ricmbBrand
            // 
            this.ricmbBrand.AutoHeight = false;
            this.ricmbBrand.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ricmbBrand.Name = "ricmbBrand";
            // 
            // colTypename
            // 
            this.colTypename.Caption = "Type";
            this.colTypename.FieldName = "typename";
            this.colTypename.Name = "colTypename";
            this.colTypename.Visible = true;
            this.colTypename.VisibleIndex = 2;
            // 
            // colCategoryid
            // 
            this.colCategoryid.Caption = "KategoriId";
            this.colCategoryid.FieldName = "categoryid";
            this.colCategoryid.Name = "colCategoryid";
            // 
            // colBrandId
            // 
            this.colBrandId.Caption = "BrandId";
            this.colBrandId.FieldName = "brandid";
            this.colBrandId.Name = "colBrandId";
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
            // UCCarType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "UCCarType";
            this.Size = new System.Drawing.Size(1222, 609);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricmbCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricmbBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl dgData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnEndEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeid;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryname;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandname;
        private DevExpress.XtraGrid.Columns.GridColumn colTypename;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryid;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandId;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox ricmbCategory;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox ricmbBrand;
    }
}
