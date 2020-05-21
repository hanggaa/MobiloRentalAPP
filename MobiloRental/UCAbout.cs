using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MobiloRental
{
    public partial class UCAbout : DevExpress.XtraEditors.XtraUserControl
    {
        public UCAbout()
        {
            this.DoubleBuffered = true;

            frmMain.setLoadDialog(true, "Loading Components...");
            InitializeComponent();
            frmMain.setLoadDialog(false, "");
        }
        public frmMain fMain;
        public void Refresh()
        {
            base.Refresh();
            //Clear();
            this.dateNow.DateTime = DateTime.Today;
            //fillCombo();
        }
        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void VisitLink(string strText)
        {
            if(strText == "fb")
            {
                System.Diagnostics.Process.Start("https://web.facebook.com/mycotta");
            }
            else if(strText == "git")
            {
                System.Diagnostics.Process.Start("https://github.com/CRZN1");
            }
        }
        private void lblGit_Click(object sender, EventArgs e)
        {

        }

        private void linkFB_HyperlinkClick(object sender, DevExpress.Utils.HyperlinkClickEventArgs e)
        {
            try
            {
                VisitLink("fb");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void linkGit_HyperlinkClick(object sender, DevExpress.Utils.HyperlinkClickEventArgs e)
        {
            try
            {
                VisitLink("git");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }
    }
}
