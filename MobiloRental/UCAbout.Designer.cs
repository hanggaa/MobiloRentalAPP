namespace MobiloRental
{
    partial class UCAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAbout));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dateNow = new DevExpress.XtraEditors.DateEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkGit = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.linkFB = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNow.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Controls.Add(this.panel1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1298, 648);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Application Credit";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.dateNow);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(3, 545);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1292, 100);
            this.panelControl2.TabIndex = 8;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.labelControl5.Location = new System.Drawing.Point(3, 6);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(289, 24);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "CREATED WITH COFFEE + LOVE";
            this.labelControl5.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // dateNow
            // 
            this.dateNow.EditValue = new System.DateTime(2020, 5, 20, 3, 3, 59, 0);
            this.dateNow.Enabled = false;
            this.dateNow.Location = new System.Drawing.Point(335, 3);
            this.dateNow.Name = "dateNow";
            this.dateNow.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNow.Properties.Appearance.Options.UseFont = true;
            this.dateNow.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNow.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNow.Properties.DisplayFormat.FormatString = "yyyy";
            this.dateNow.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateNow.Size = new System.Drawing.Size(103, 30);
            this.dateNow.TabIndex = 6;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Controls.Add(this.linkGit);
            this.panelControl1.Controls.Add(this.linkFB);
            this.panelControl1.Controls.Add(this.richTextBox1);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(3, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1292, 308);
            this.panelControl1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(313, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // linkGit
            // 
            this.linkGit.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.linkGit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkGit.Location = new System.Drawing.Point(35, 267);
            this.linkGit.Name = "linkGit";
            this.linkGit.Size = new System.Drawing.Size(185, 24);
            this.linkGit.TabIndex = 6;
            this.linkGit.Text = "MY GITHUB PROFILE";
            this.linkGit.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.linkGit_HyperlinkClick);
            // 
            // linkFB
            // 
            this.linkFB.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.linkFB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkFB.Location = new System.Drawing.Point(35, 220);
            this.linkFB.Name = "linkFB";
            this.linkFB.Size = new System.Drawing.Size(211, 24);
            this.linkFB.TabIndex = 5;
            this.linkFB.Text = "MY FACEBOOK PROFILE";
            this.linkFB.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.linkFB_HyperlinkClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(718, 18);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(557, 273);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.labelControl1.Location = new System.Drawing.Point(35, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(260, 34);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "MOBILO RENTAL V.1\r\n";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.labelControl2.Location = new System.Drawing.Point(35, 174);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(192, 24);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "CREATED BY : CRZN1";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 615);
            this.panel1.TabIndex = 9;
            // 
            // UCAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "UCAbout";
            this.Size = new System.Drawing.Size(1298, 648);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNow.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateNow;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.HyperlinkLabelControl linkGit;
        private DevExpress.XtraEditors.HyperlinkLabelControl linkFB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Panel panel1;
    }
}
