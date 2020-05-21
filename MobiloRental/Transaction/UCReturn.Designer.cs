namespace MobiloRental.Transaction
{
    partial class UCReturn
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dateReturn = new System.Windows.Forms.DateTimePicker();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.txtRemaining = new System.Windows.Forms.TextBox();
            this.txtDP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPenalty = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdentity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReturnID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgData = new System.Windows.Forms.DataGridView();
            this.CarID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarPlatNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingIDDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(403, 80);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 35);
            this.btnSearch.TabIndex = 121;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1050, 545);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 35);
            this.btnSave.TabIndex = 118;
            this.btnSave.Text = "Save Return";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(918, 547);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 119;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(755, 545);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(135, 35);
            this.btnNew.TabIndex = 120;
            this.btnNew.Text = "New Return";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dateReturn
            // 
            this.dateReturn.CustomFormat = "dd/MM/yyyy";
            this.dateReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateReturn.Location = new System.Drawing.Point(196, 200);
            this.dateReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateReturn.Name = "dateReturn";
            this.dateReturn.Size = new System.Drawing.Size(298, 27);
            this.dateReturn.TabIndex = 117;
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(830, 205);
            this.txtPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(298, 27);
            this.txtPayment.TabIndex = 112;
            // 
            // txtRemaining
            // 
            this.txtRemaining.Location = new System.Drawing.Point(830, 125);
            this.txtRemaining.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRemaining.Name = "txtRemaining";
            this.txtRemaining.Size = new System.Drawing.Size(298, 27);
            this.txtRemaining.TabIndex = 111;
            // 
            // txtDP
            // 
            this.txtDP.Location = new System.Drawing.Point(830, 85);
            this.txtDP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDP.Name = "txtDP";
            this.txtDP.Size = new System.Drawing.Size(298, 27);
            this.txtDP.TabIndex = 110;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(672, 205);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 19);
            this.label10.TabIndex = 105;
            this.label10.Text = "Payment Ammount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(672, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 19);
            this.label6.TabIndex = 106;
            this.label6.Text = "Penalty Payment";
            // 
            // txtPenalty
            // 
            this.txtPenalty.Location = new System.Drawing.Point(830, 165);
            this.txtPenalty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPenalty.Name = "txtPenalty";
            this.txtPenalty.Size = new System.Drawing.Size(298, 27);
            this.txtPenalty.TabIndex = 109;
            this.txtPenalty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPenalty_KeyDown);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(830, 45);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(298, 27);
            this.txtTotal.TabIndex = 113;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 19);
            this.label5.TabIndex = 99;
            this.label5.Text = "Date Time Return";
            // 
            // txtIdentity
            // 
            this.txtIdentity.Location = new System.Drawing.Point(196, 160);
            this.txtIdentity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdentity.Name = "txtIdentity";
            this.txtIdentity.Size = new System.Drawing.Size(298, 27);
            this.txtIdentity.TabIndex = 108;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 97;
            this.label4.Text = "Identity Number";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(196, 120);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(298, 27);
            this.txtName.TabIndex = 107;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 96;
            this.label3.Text = "Customer Name";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(196, 80);
            this.txtBookingID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(196, 27);
            this.txtBookingID.TabIndex = 114;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 100;
            this.label2.Text = "Booking ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(672, 125);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 19);
            this.label9.TabIndex = 104;
            this.label9.Text = "Remaining Payment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(672, 90);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 19);
            this.label8.TabIndex = 103;
            this.label8.Text = "DP (Down Payment)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(672, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 19);
            this.label7.TabIndex = 102;
            this.label7.Text = "Total Price";
            // 
            // txtReturnID
            // 
            this.txtReturnID.Location = new System.Drawing.Point(196, 40);
            this.txtReturnID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReturnID.Name = "txtReturnID";
            this.txtReturnID.Size = new System.Drawing.Size(298, 27);
            this.txtReturnID.TabIndex = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 101;
            this.label1.Text = "Return ID";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSearch);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtReturnID);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.dateReturn);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtPayment);
            this.groupControl1.Controls.Add(this.txtBookingID);
            this.groupControl1.Controls.Add(this.txtRemaining);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtDP);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.txtIdentity);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.txtPenalty);
            this.groupControl1.Controls.Add(this.txtTotal);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1222, 610);
            this.groupControl1.TabIndex = 122;
            this.groupControl1.Text = "Return";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgData);
            this.groupControl2.Location = new System.Drawing.Point(28, 241);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1163, 279);
            this.groupControl2.TabIndex = 122;
            this.groupControl2.Text = "List Car Return";
            // 
            // dgData
            // 
            this.dgData.AllowUserToAddRows = false;
            this.dgData.AllowUserToDeleteRows = false;
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarID,
            this.CarPlatNumber,
            this.TypeName,
            this.Price,
            this.BookingID,
            this.BookingIDDetail});
            this.dgData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgData.Location = new System.Drawing.Point(3, 30);
            this.dgData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgData.Name = "dgData";
            this.dgData.Size = new System.Drawing.Size(1157, 246);
            this.dgData.TabIndex = 83;
            // 
            // CarID
            // 
            this.CarID.DataPropertyName = "carid";
            this.CarID.HeaderText = "CarID";
            this.CarID.Name = "CarID";
            this.CarID.Visible = false;
            // 
            // CarPlatNumber
            // 
            this.CarPlatNumber.DataPropertyName = "platnumber";
            this.CarPlatNumber.HeaderText = "CarPlatNumber";
            this.CarPlatNumber.Name = "CarPlatNumber";
            // 
            // TypeName
            // 
            this.TypeName.DataPropertyName = "typename";
            this.TypeName.HeaderText = "TypeName";
            this.TypeName.Name = "TypeName";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // BookingID
            // 
            this.BookingID.DataPropertyName = "bookingid";
            this.BookingID.HeaderText = "BookingID";
            this.BookingID.Name = "BookingID";
            // 
            // BookingIDDetail
            // 
            this.BookingIDDetail.DataPropertyName = "detailid";
            this.BookingIDDetail.HeaderText = "BookingIDDetail";
            this.BookingIDDetail.Name = "BookingIDDetail";
            // 
            // UCReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupControl1);
            this.Name = "UCReturn";
            this.Size = new System.Drawing.Size(1222, 610);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DateTimePicker dateReturn;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.TextBox txtRemaining;
        private System.Windows.Forms.TextBox txtDP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPenalty;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdentity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReturnID;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarPlatNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingIDDetail;
    }
}
