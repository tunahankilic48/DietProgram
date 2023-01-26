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
    public partial class frmCompareReport : Form
    {
        public frmCompareReport()
        {
            InitializeComponent();
        }
        AppUser _user;
        frmReports _report;
        DietContext context = new DietContext();


        public frmCompareReport(frmReports activeReport, AppUser activeUser)
        {
            _user = activeUser;
            _report = activeReport;
            InitializeComponent();

            

        }

        private void frmCompareReport_FormClosing(object sender, FormClosingEventArgs e)
        {

            MessageBox.Show("Do you want to close without saving your changes?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            _report.Show();

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            //Belirtilen aralikta kullanicilarin tukkettigi toplam ortalama kalori hesaplanacak. kullanicinin tükettigi kalori ile karsilastirilecak.

            //var deneme = context.MealContents.Where(x => x.CreatedDate.Value > dtpStartDate.Value).Where(x => x.CreatedDate.Value < dtpEndDate.Value).Select(x=> new { Date = x.CreatedDate, ProductId = x.ProductId, Quantity = x.Quantity}).ToList();


            var allUsersTotalCalorieList = (from mc in context.MealContents 
                               join p in context.Products on mc.ProductId equals p.Id 
                               where p.CreatedDate.Value > dtpStartDate.Value 
                               where p.CreatedDate.Value < dtpEndDate.Value 
                               select new { Date = mc.CreatedDate, ProductId = mc.ProductId, Quantity = mc.Quantity, totalCalorie = p.Calorie * mc.Quantity}).ToList();

            var userTotalCalorieList = (from mc in context.MealContents
                               join p in context.Products on mc.ProductId equals p.Id
                               join m in context.Meals on mc.MealId equals m.Id
                               where m.UserId == _user.Id
                               where p.CreatedDate.Value > dtpStartDate.Value
                               where p.CreatedDate.Value < dtpEndDate.Value
                               select new { Date = mc.CreatedDate, ProductId = mc.ProductId, Quantity = mc.Quantity, totalCalorie = p.Calorie * mc.Quantity }).ToList();

            int? totalNumberOfUser = (from au in context.AppUsers select new {Id = au.Id}).Count();

            int? userTotalCalorie = userTotalCalorieList.Select(x => x.totalCalorie).Sum();

            int? allUserTotalCalorie = allUsersTotalCalorieList.Select(x => x.totalCalorie).Sum();

            int? allUsersAverageTotalCalorie = allUserTotalCalorie / totalNumberOfUser;

            string neededStr = (userTotalCalorie <= allUsersAverageTotalCalorie) ? "below " : "above";

            int? percent=0;

            if ( allUsersAverageTotalCalorie > userTotalCalorie)
            {
                percent = 100 - (userTotalCalorie) * 100 / allUsersAverageTotalCalorie;
            }

            else if (allUsersAverageTotalCalorie < userTotalCalorie)
            {
                percent =  (userTotalCalorie) * 100 / allUsersAverageTotalCalorie-100;
            }

           lblAverageUsers.Text = $"{allUsersAverageTotalCalorie} kcal ";
           lblUser.Text= $"{userTotalCalorie} kcal  (%{percent} {neededStr} average)";
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartDate.Value;
        }
    }
}
