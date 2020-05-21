namespace MobiloRental.Master_Data
{
    partial class UCCarCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCarCategory));
            this.gcontrolCarCategory = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnEndEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.dgData = new DevExpress.XtraGrid.GridControl();
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCarCategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcontrolCarCategory)).BeginInit();
            this.gcontrolCarCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // gcontrolCarCategory
            // 
            this.gcontrolCarCategory.CaptionImage = ((System.Drawing.Image)(resources.GetObject("gcontrolCarCategory.CaptionImage")));
            this.gcontrolCarCategory.Controls.Add(this.panelControl1);
            this.gcontrolCarCategory.Controls.Add(this.dgData);
            this.gcontrolCarCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcontrolCarCategory.Location = new System.Drawing.Point(0, 0);
            this.gcontrolCarCategory.MinimumSize = new System.Drawing.Size(1222, 609);
            this.gcontrolCarCategory.Name = "gcontrolCarCategory";
            this.gcontrolCarCategory.Size = new System.Drawing.Size(1222, 609);
            this.gcontrolCarCategory.TabIndex = 2;
            this.gcontrolCarCategory.Text = "Manage Car Category";
            this.gcontrolCarCategory.Paint += new System.Windows.Forms.PaintEventHandler(this.gcontrolCarCategory_Paint);
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
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
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
            this.dgData.Size = new System.Drawing.Size(1216, 563);
            this.dgData.TabIndex = 1;
            this.dgData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            this.dgData.Click += new System.EventHandler(this.dgData_Click);
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCarCategoryId,
            this.colCategoryName});
            this.gridViewData.GridControl = this.dgData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsView.ShowGroupPanel = false;
            this.gridViewData.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewData_ValidateRow);
            // 
            // colCarCategoryId
            // 
            this.colCarCategoryId.Caption = "CategoryId";
            this.colCarCategoryId.FieldName = "categoryid";
            this.colCarCategoryId.Name = "colCarCategoryId";
            // 
            // colCategoryName
            // 
            this.colCategoryName.Caption = "Kategori";
            this.colCategoryName.FieldName = "categoryname";
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.Visible = true;
            this.colCategoryName.VisibleIndex = 0;
            // 
            // UCCarCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcontrolCarCategory);
            this.Name = "UCCarCategory";
            this.Size = new System.Drawing.Size(1222, 609);
            ((System.ComponentModel.ISupportInitialize)(this.gcontrolCarCategory)).EndInit();
            this.gcontrolCarCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcontrolCarCategory;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnEndEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraGrid.GridControl dgData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn colCarCategoryId;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryName;
    }
}
