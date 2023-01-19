using DataAccessLayer;
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
        DietContext context;
        WeightsAndHeights weightsAndHeights;

        public frmMainPage(AppUser user)
        {
            InitializeComponent();
            _user = user;
        }
        private void frmMainPage_Load(object sender, EventArgs e)
        {
            context= new DietContext();
            weightsAndHeights = context.UsersWeightsAndHeights.Where(x => x.AppUserId == _user.Id).OrderByDescending(x => x.CreatedDate).FirstOrDefault();
            weightsAndHeights.AppUser= _user;
            lblUserName.Text = _user.Name;
            lblUserLastName.Text = _user.LastName;
            lblUserHeight.Text = weightsAndHeights.Height.ToString() + " cm";
            lblUserWeight.Text = weightsAndHeights.Weight.ToString() + " kg";
            lblUserBodyMassIndex.Text = weightsAndHeights.BodyMassIndex.ToString();
            lblUserCaloriesNeeded.Text = weightsAndHeights.DailyRequiredCalori.ToString() + " Calorie";

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
            HeightandWeightUpdate frm = new HeightandWeightUpdate(weightsAndHeights, this);
            frm.Show();
            this.Hide();
        }
    }
}
