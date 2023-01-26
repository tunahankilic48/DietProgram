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
    public partial class frmProductRatesReport : Form
    {
        public frmProductRatesReport()
        {
            InitializeComponent();
        }

        AppUser _user;
        frmReports _report;
        DietContext context = new DietContext();


        public frmProductRatesReport(frmReports activeReport, AppUser activeUser)
        {
            _user = activeUser;
            _report = activeReport;
            InitializeComponent();

        }

        private void frmProductRatesReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Do you want to close without saving your changes?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            _report.Show();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartDate.Value;
        }

        private void btnGenerateResult_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;

            string selectedCriteria = null;



            if (rdbAllMeals.Checked)
            {

                var deneme = (from mc in context.MealContents
                              join p in context.Products on mc.ProductId equals p.Id
                              join m in context.Meals on mc.MealId equals m.Id
                              where m.UserId == _user.Id
                              where p.CreatedDate.Value > dtpStartDate.Value
                              where p.CreatedDate.Value < dtpEndDate.Value
                              select new { Date = mc.CreatedDate, MealCategoryName = m.MealCategory.Name, ProductName = p.Name, Quantity = mc.Quantity, }).ToList();

                var filteredList = deneme.GroupBy(e => e.ProductName).Select(g =>
                {
                    var item = g.First();
                    return new
                    {

                        ProductName = item.ProductName,
                        Quantity = g.Sum(e => e.Quantity)
                    };
                }).ToList();

                dataGridView1.DataSource = filteredList;

            }

            else if (rdbBreakfasts.Checked)
            {
                selectedCriteria = "Kahvalti";

                var deneme = (from mc in context.MealContents
                              join p in context.Products on mc.ProductId equals p.Id
                              join m in context.Meals on mc.MealId equals m.Id
                              where m.UserId == _user.Id
                              where p.CreatedDate.Value > dtpStartDate.Value
                              where p.CreatedDate.Value < dtpEndDate.Value
                              where m.MealCategory.Name == selectedCriteria
                              select new { Date = mc.CreatedDate, MealCategoryName = m.MealCategory.Name, ProductName = p.Name, Quantity = mc.Quantity, }).ToList();

                var filteredList = deneme.GroupBy(e => e.ProductName).Select(g =>
                {
                    var item = g.First();
                    return new
                    {

                        ProductName = item.ProductName,
                        MealCategoryName = item.MealCategoryName,
                        Quantity = g.Sum(e => e.Quantity)
                    };
                }).ToList().OrderByDescending(e => e.Quantity) ;

                var filteretList2 = filteredList.Where(x => x.MealCategoryName == selectedCriteria).ToList();
                dataGridView1.DataSource = filteretList2;


            }
            else if(rdbLaunch.Checked)

            {
                selectedCriteria = "Oglen";
                var deneme = (from mc in context.MealContents
                              join p in context.Products on mc.ProductId equals p.Id
                              join m in context.Meals on mc.MealId equals m.Id
                              where m.UserId == _user.Id
                              where p.CreatedDate.Value > dtpStartDate.Value
                              where p.CreatedDate.Value < dtpEndDate.Value
                              where m.MealCategory.Name == selectedCriteria
                              select new { Date = mc.CreatedDate, MealCategoryName = m.MealCategory.Name, ProductName = p.Name, Quantity = mc.Quantity, }).ToList();

                
                var filteredList = deneme.GroupBy(e => e.ProductName).Select(g =>
                {
                    var item = g.First();
                    return new
                    {

                        ProductName = item.ProductName,
                        MealCategoryName = item.MealCategoryName,
                        Quantity = g.Sum(e => e.Quantity)
                    };
                }).ToList().OrderByDescending(e=> e.Quantity);
                var filteretList2 = filteredList.Where(x => x.MealCategoryName == selectedCriteria).ToList();
                dataGridView1.DataSource = filteretList2;

            }
            else if (rdbDinners.Checked)
            {
                selectedCriteria = "Aksam";

                var deneme = (from mc in context.MealContents
                              join p in context.Products on mc.ProductId equals p.Id
                              join m in context.Meals on mc.MealId equals m.Id
                              where m.UserId == _user.Id
                              where p.CreatedDate.Value > dtpStartDate.Value
                              where p.CreatedDate.Value < dtpEndDate.Value
                              where m.MealCategory.Name == selectedCriteria
                              select new { Date = mc.CreatedDate, MealCategoryName = m.MealCategory.Name, ProductName = p.Name, Quantity = mc.Quantity, }).ToList();

                var filteredList = deneme.GroupBy(e => e.ProductName).Select(g =>
                {
                    var item = g.First();
                    return new
                    {

                        ProductName = item.ProductName,
                        MealCategoryName = item.MealCategoryName,
                        Quantity = g.Sum(e => e.Quantity)
                    };
                }).ToList().OrderByDescending(e => e.Quantity); ;

                var filteretList2 = filteredList.Where(x => x.MealCategoryName == selectedCriteria).ToList();
                dataGridView1.DataSource = filteretList2;
            }
            else if (rdbSnacks.Checked)
            {
                selectedCriteria = "Ara Ogun";
                var deneme = (from mc in context.MealContents
                              join p in context.Products on mc.ProductId equals p.Id
                              join m in context.Meals on mc.MealId equals m.Id
                              where m.UserId == _user.Id
                              where p.CreatedDate.Value > dtpStartDate.Value
                              where p.CreatedDate.Value < dtpEndDate.Value
                              where m.MealCategory.Name == selectedCriteria
                              select new { Date = mc.CreatedDate, MealCategoryName = m.MealCategory.Name, ProductName = p.Name, Quantity = mc.Quantity, }).ToList();
                var filteredList = deneme.GroupBy(e => e.ProductName).Select(g =>
                {
                    var item = g.First();
                    return new
                    {

                        ProductName = item.ProductName,
                        MealCategoryName = item.MealCategoryName,
                        Quantity = g.Sum(e => e.Quantity)
                    };
                }).ToList().OrderByDescending(e => e.Quantity); ;

                var filteretList2 = filteredList.Where(x => x.MealCategoryName == selectedCriteria).ToList();
                dataGridView1.DataSource = filteretList2;
            }




   


            
            
            

            
        }
    }


}
