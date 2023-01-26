using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UILayer
{
    public partial class frmReports : Form
    {
        private AppUser _user;
        private frmMainPage _frmMainPage;
        public frmReports()
        {
            InitializeComponent();
        }

        public frmReports(frmMainPage activeMainPage, AppUser activeUser)
        {
            InitializeComponent();
            _user = activeUser;
            _frmMainPage = activeMainPage;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmDailyReport frm = new frmDailyReport(this, _user);
            frm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

            frmCompareReport frm = new frmCompareReport(this, _user);
            frm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pnlDailyReports_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmReports_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Do you want to close without saving your changes?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            _frmMainPage.Show();
          
        }
    }
}
