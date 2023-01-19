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
    public partial class frmMainPage : Form
    {
        private AppUser _user;

        public frmMainPage(AppUser user)
        {
            InitializeComponent();
            _user = user;
        }

        private void frmMainPage_Load(object sender, EventArgs e)
        {
            lblUserName.Text = _user.Name;
            lblUserLastName.Text = _user.LastName;
            lblUserLength.Text = _user.Length.ToString() + " cm";
            lblUserWeight.Text = _user.Weigth.ToString() + " kg";
            lblUserBodyMassIndex.Text = _user.BodyMassIndex.ToString();
            lblUserCaloriesNeeded.Text = _user.DailyRequiredCalori.ToString() + " Calorie";

        }

        private void btnMeal_Click(object sender, EventArgs e)
        {
            frmMeal frm = new frmMeal();
            frm.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReports frm = new frmReports();
            frm.Show();
            this.Hide();
        }

        private void btnUpdateAccountInformation_Click(object sender, EventArgs e)
        {
            frmNewAccount frm = new frmNewAccount();
            frm.Show();
            this.Hide();
        }

        private void btnHeightandWeightUpdate_Click(object sender, EventArgs e)
        {
            HeightandWeightUpdate frm = new HeightandWeightUpdate();
            frm.Show();
            this.Hide();
        }
    }
}
