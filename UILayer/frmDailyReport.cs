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
using Windows.Storage.AccessCache;

namespace UILayer
{
    public partial class frmDailyReport : Form
    {
        AppUser _user;
        frmReports _report;
        DietContext context = new DietContext();


        public frmDailyReport()
        {
            InitializeComponent();
        }

        public frmDailyReport(frmReports activeReport, AppUser activeUser)
        {
            _user = activeUser;
            _report = activeReport;
            InitializeComponent();

        }

        private void frmDailyReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Do you want to close without saving your changes?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            _report.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            dgvDailyMeals.Columns.Clear();
            dgvDailyMeals.Rows.Clear();
            lblLaunchTotalCalorieResult.Text = $"{0} kcal (%0)";
            lblDailySnackCalorieResult.Text = $"{0} kcal (%0)";
            lblBreakfastTotalCalorieResult.Text = $"{0} kcal (%0)";
            lblDinnerTotalCalorieResult.Text = $"{0} kcal (%0)";
            lblDailyTotalCalorieResult.Text = $"{0} kcal (%0)";

            var meals = context.Meals.Where(x => x.MealDate.Value == dtpDailyReport.Value.Date).Where(x => x.UserId == _user.Id).Select(x => new
            {
                Name = x.User.Name + " " + x.User.LastName,
                Meal = x.MealCategory.Name,
                Date = x.ModifiedDate,
                x.Id
            }).ToList();

            dgvDailyMeals.Columns.Add("MealName", "MealName");
            dgvDailyMeals.Columns.Add("ProductName", "ProductName");
            dgvDailyMeals.Columns.Add("Quantity", "Quantity");
            dgvDailyMeals.Columns.Add("TotalCalorie", "TotalCalorie");




            for (int i = 0; i < meals.Count; i++)
            {

                var mealContent = context.MealContents.Where(x => x.MealId == meals[i].Id).Select(x => new
                {
                    Product = x.ProductId,
                    Quantity = x.Quantity,
                }).ToList();



                for (int j = 0; j < mealContent.Count; j++)
                {
                    var productDetails = context.Products.Where(x => x.Id == mealContent[j].Product).Select(x => new { ProductName = x.Name, Calorie = x.Calorie }).ToList();

                    int totalCalorie = (int)mealContent[j].Quantity * (int)productDetails[0].Calorie;

                    var itemToDgvListsTemp2 = new { ProductName = (string)productDetails[0].ProductName, Quantity = (int)mealContent[j].Quantity, Calorie = totalCalorie };

                    dgvDailyMeals.Rows.Add(meals[i].Meal, itemToDgvListsTemp2.ProductName, itemToDgvListsTemp2.Quantity, itemToDgvListsTemp2.Calorie);
                }


            }



            int dailyTotal = 0;
            int breakfastTotal = 0;
            int lanchTotal = 0;
            int dinnerTotal = 0;
            int snackTotal = 0;

            for (int i = 0; i < dgvDailyMeals.Rows.Count; ++i)
            {
                dailyTotal += Convert.ToInt32(dgvDailyMeals.Rows[i].Cells[3].Value);
                lblDailyTotalCalorieResult.Text = $"{dailyTotal} kcal";
            }


            for (int i = 0; i < dgvDailyMeals.Rows.Count - 1; ++i)

            {
                if (dgvDailyMeals.Rows[i].Cells[0].Value.ToString() == "Kahvalti")
                {

                    breakfastTotal += Convert.ToInt32(dgvDailyMeals.Rows[i].Cells[3].Value);
                    lblBreakfastTotalCalorieResult.Text = $"{breakfastTotal} kcal (%{breakfastTotal * 100 / dailyTotal})";
                }
            }


            for (int i = 0; i < dgvDailyMeals.Rows.Count - 1; ++i)

            {
                if (dgvDailyMeals.Rows[i].Cells[0].Value.ToString() == "Oglen")
                {

                    lanchTotal += Convert.ToInt32(dgvDailyMeals.Rows[i].Cells[3].Value);
                    lblLaunchTotalCalorieResult.Text = $"{lanchTotal} kcal (%{lanchTotal * 100 / dailyTotal})";
                }
            }


            for (int i = 0; i < dgvDailyMeals.Rows.Count - 1; ++i)

            {
                if (dgvDailyMeals.Rows[i].Cells[0].Value.ToString() == "Aksam")
                {

                    dinnerTotal += Convert.ToInt32(dgvDailyMeals.Rows[i].Cells[3].Value);
                    lblDinnerTotalCalorieResult.Text = $"{dinnerTotal} kcal (%{dinnerTotal * 100 / dailyTotal})";
                }
            }



            for (int i = 0; i < dgvDailyMeals.Rows.Count - 1; ++i)

            {
                if (dgvDailyMeals.Rows[i].Cells[0].Value.ToString() == "Ara Ogun")
                {

                    snackTotal += Convert.ToInt32(dgvDailyMeals.Rows[i].Cells[3].Value);
                    lblDailySnackCalorieResult.Text = $"{snackTotal} kcal (%{snackTotal*100/dailyTotal})";
                }
            }



        }

    }
}
