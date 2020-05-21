namespace MobiloRental.Transaction
{
    partial class UCRepair
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgData = new System.Windows.Forms.DataGridView();
            this.cmbPlatnumber = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RepairID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Controls.Add(this.dgData);
            this.groupControl1.Controls.Add(this.cmbPlatnumber);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1222, 610);
            this.groupControl1.TabIndex = 93;
            this.groupControl1.Text = "Car Repair";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Location = new System.Drawing.Point(74, 341);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1077, 100);
            this.panelControl1.TabIndex = 100;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnAdd.Location = new System.Drawing.Point(32, 23);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 56);
            this.btnAdd.TabIndex = 99;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSave.Location = new System.Drawing.Point(316, 23);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 56);
            this.btnSave.TabIndex = 97;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnCancel.Location = new System.Drawing.Point(562, 23);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 56);
            this.btnCancel.TabIndex = 96;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnDelete.Location = new System.Drawing.Point(833, 23);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 56);
            this.btnDelete.TabIndex = 98;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgData
            // 
            this.dgData.AllowUserToAddRows = false;
            this.dgData.AllowUserToDeleteRows = false;
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RepairID,
            this.CarID,
            this.Platnumber});
            this.dgData.Location = new System.Drawing.Point(74, 137);
            this.dgData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgData.Name = "dgData";
            this.dgData.Size = new System.Drawing.Size(1077, 164);
            this.dgData.TabIndex = 95;
            this.dgData.Click += new System.EventHandler(this.dgData_Click);
            // 
            // cmbPlatnumber
            // 
            this.cmbPlatnumber.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cmbPlatnumber.FormattingEnabled = true;
            this.cmbPlatnumber.Location = new System.Drawing.Point(540, 77);
            this.cmbPlatnumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPlatnumber.Name = "cmbPlatnumber";
            this.cmbPlatnumber.Size = new System.Drawing.Size(392, 42);
            this.cmbPlatnumber.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(313, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 34);
            this.label1.TabIndex = 93;
            this.label1.Text = "Car Plat Number";
            // 
            // RepairID
            // 
            this.RepairID.DataPropertyName = "repairid";
            this.RepairID.HeaderText = "RepairID";
            this.RepairID.MinimumWidth = 10;
            this.RepairID.Name = "RepairID";
            this.RepairID.Visible = false;
            // 
            // CarID
            // 
            this.CarID.DataPropertyName = "carid";
            this.CarID.HeaderText = "CarID";
            this.CarID.Name = "CarID";
            this.CarID.Visible = false;
            // 
            // Platnumber
            // 
            this.Platnumber.DataPropertyName = "platnumber";
            this.Platnumber.HeaderText = "Plat Number";
            this.Platnumber.MinimumWidth = 10;
            this.Platnumber.Name = "Platnumber";
            this.Platnumber.Width = 200;
            // 
            // UCRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "UCRepair";
            this.Size = new System.Drawing.Size(1222, 610);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.ComboBox cmbPlatnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepairID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platnumber;
    }
}
