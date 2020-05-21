namespace MobiloRental.Report
{
    partial class UCDataReturn
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
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgData = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ReturnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimeReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PenaltyPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentAmmoutn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1154, 386);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Transaction Booking";
            // 
            // dgData
            // 
            this.dgData.AllowUserToAddRows = false;
            this.dgData.AllowUserToDeleteRows = false;
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReturnID,
            this.BookingID,
            this.DateTimeReturn,
            this.RemainingPayment,
            this.PenaltyPayment,
            this.PaymentAmmoutn});
            this.dgData.Location = new System.Drawing.Point(42, 132);
            this.dgData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgData.Name = "dgData";
            this.dgData.Size = new System.Drawing.Size(1148, 245);
            this.dgData.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(960, 386);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "SUM(Payment Ammount) :";
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(664, 57);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(187, 27);
            this.dateEnd.TabIndex = 26;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(417, 58);
            this.dateStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(187, 27);
            this.dateStart.TabIndex = 27;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1046, 71);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 35);
            this.button4.TabIndex = 22;
            this.button4.Text = "Export To Excel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1050, 26);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 35);
            this.button3.TabIndex = 23;
            this.button3.Text = "Refresh Data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(862, 54);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 24;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 55);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 25;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 58);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 27);
            this.textBox1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "S/D";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Search Data (Date Time Return)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Search Data (Return ID)";
            // 
            // groupControl1
            // 
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1242, 459);
            this.groupControl1.TabIndex = 32;
            this.groupControl1.Text = "Export Return Data";
            // 
            // ReturnID
            // 
            this.ReturnID.DataPropertyName = "returnid";
            this.ReturnID.HeaderText = "ReturnID";
            this.ReturnID.Name = "ReturnID";
            // 
            // BookingID
            // 
            this.BookingID.DataPropertyName = "bookingid";
            this.BookingID.HeaderText = "BookingID";
            this.BookingID.Name = "BookingID";
            // 
            // DateTimeReturn
            // 
            this.DateTimeReturn.DataPropertyName = "dtreturn";
            this.DateTimeReturn.HeaderText = "DateTimeReturn";
            this.DateTimeReturn.Name = "DateTimeReturn";
            // 
            // RemainingPayment
            // 
            this.RemainingPayment.DataPropertyName = "remainingpayment";
            this.RemainingPayment.HeaderText = "RemainingPayment";
            this.RemainingPayment.Name = "RemainingPayment";
            // 
            // PenaltyPayment
            // 
            this.PenaltyPayment.DataPropertyName = "penaltypayment";
            this.PenaltyPayment.HeaderText = "PenaltyPayment";
            this.PenaltyPayment.Name = "PenaltyPayment";
            // 
            // PaymentAmmoutn
            // 
            this.PaymentAmmoutn.DataPropertyName = "paymentamount";
            this.PaymentAmmoutn.HeaderText = "PaymentAmmount";
            this.PaymentAmmoutn.Name = "PaymentAmmoutn";
            // 
            // UCDataReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupControl1);
            this.Name = "UCDataReturn";
            this.Size = new System.Drawing.Size(1242, 459);
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn PenaltyPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentAmmoutn;
    }
}
