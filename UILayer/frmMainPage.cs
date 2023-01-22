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
        // to do: Reports kısmı eklenecek
        // to do: update kısmı eklenecek
        private AppUser _user;
        DietContext context;
        WeightsAndHeights weightsAndHeights;

        public frmMainPage(AppUser user)
        {
            InitializeComponent();
            _user = user;
        }
        /// <summary>
        /// This method fills user information in the main page
        /// </summary>
        void FillTheUserInformation()
        {
            weightsAndHeights = context.UsersWeightsAndHeights.Where(x => x.UserId == _user.Id).OrderByDescending(x => x.CreatedDate).FirstOrDefault();

            weightsAndHeights.AppUser = _user;

            lblUserName.Text = _user.Name;
            lblUserLastName.Text = _user.LastName;
            lblUserHeight.Text = weightsAndHeights.Height.ToString() + " cm";
            lblUserWeight.Text = weightsAndHeights.Weight.ToString() + " kg";

            lblUserBodyMassIndex.Text = weightsAndHeights.BodyMassIndex.ToString();

            lblUserCaloriesNeeded.Text = weightsAndHeights.DailyRequiredCalori.ToString() + " Calorie";

            var meals = context.Meals.Where(x => x.UserId == _user.Id).Where(x => x.MealDate == DateTime.Now.Date).ToList();

            List<MealContent> mealContents = new List<MealContent>();

            foreach (var item in meals)
            {
                mealContents.AddRange(context.MealContents.Where(x => x.MealId == item.Id).ToList());
            }
            int totalCalorie = 0;
            foreach (var item in mealContents)
            {
                item.Product = context.Products.Find(item.ProductId);
                totalCalorie += (int)item.TotalCalorie;

            }
            lblUserCaloriesTakenToday.Text = totalCalorie.ToString() + " Calorie";

            if (_user.ProfilePhoto.Length != 0)
            {
                MemoryStream ms = new MemoryStream(_user.ProfilePhoto, 0, _user.ProfilePhoto.Length);
                ms.Write(_user.ProfilePhoto, 0, _user.ProfilePhoto.Length);
                pictureBox1.Image = Image.FromStream(ms, true);//Exception occurs here
            }
        }
        private void frmMainPage_Load(object sender, EventArgs e)
        {
            context = new DietContext();
            FillTheUserInformation();
        }
        private void btnMeal_Click(object sender, EventArgs e)
        {
            frmMeal frm = new frmMeal(this, _user);
            frm.Show();
            this.Hide();
        }
        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReports frm = new frmReports();// to do: yapılacak
            frm.Show();
            this.Hide();
        }
        private void btnUpdateAccountInformation_Click(object sender, EventArgs e)
        {
            //frmNewAccount frm = new frmNewAccount(this);// to do: yapılacak
            //frm.Show();
            //this.Hide();
        }
        private void btnHeightandWeightUpdate_Click(object sender, EventArgs e)
        {
            HeightandWeightUpdate frm = new HeightandWeightUpdate(weightsAndHeights, this);
            frm.ShowDialog();
            FillTheUserInformation();
        }
    }
}
