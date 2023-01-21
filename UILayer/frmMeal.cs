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
    public partial class frmMeal : Form
    {
        DietContext context;
        MealContent? selectedMealContent; // It contains meal contents selected from dgvMealsInSelectedDate
        int selectedMeal; // It keep Id of the selected meal from dgvMealsInSelectedDate
        public int newQuantity; // It is for new quantity of the selected product
        private AppUser _user;
        private frmMainPage _frmMainPage;

        public frmMeal(frmMainPage frmMainPage, AppUser user)
        {
            InitializeComponent();
            _user = user;
            _frmMainPage = frmMainPage;
        }

        /// <summary>
        /// It lists meals for choosen date
        /// </summary>
        void ListTodgvMealsInSelectedDate()
        {
            var meals = context.Meals.Where(x => x.MealDate == dtpDateSelection.Value.Date).Where(x => x.UserId == _user.Id).Select(x => new
            {
                Name = x.User.Name + " " + x.User.LastName,
                Meal = x.MealCategory.Name,
                Date = x.ModifiedDate,
                x.Id
            }).ToList();

            lblMealDate.Text = dtpDateSelection.Value.ToShortDateString();

            dgvMealsInSelectedDate.DataSource = meals;
            dgvMealsInSelectedDate.Columns["Id"].Visible = false;
        }
        /// <summary>
        /// It lists meal content of the meal for choosen date
        /// </summary>
        void ListTodgvProductsInSelectedMeal()
        {
            var products = context.MealContents.Where(x => x.MealId == selectedMeal).ToList();

            foreach (var item in products)
            {
                item.Product = context.Products.Find(item.ProductId);
                context.Update(item);
            }

            dgvProductsInSelectedMeal.DataSource = products.Select(x => new
            {
                ProductName = x.Product.Name,
                x.Quantity,
                x.TotalCalorie,
                x.Product.QuantityPerUnit,
                x.ProductId,
                x.MealId
            }).ToList();

            dgvProductsInSelectedMeal.Columns["ProductId"].Visible = false;
            dgvProductsInSelectedMeal.Columns["MealId"].Visible = false;
        }

        private void frmMeal_Load(object sender, EventArgs e)
        {
            context = new DietContext();
            btnDeleteSelectedMeal.Enabled = false;
            btnDeleteProduct.Enabled = false;
            btnChangeQuantity.Enabled = false;
            btnAddNewProduct.Enabled = false;
        }
        private void btnShowMeals_Click(object sender, EventArgs e)
        {
            ListTodgvMealsInSelectedDate();
        }
        private void dgvMealsInSelectedDate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeleteProduct.Enabled = true;
            btnChangeQuantity.Enabled = true;
            btnAddNewProduct.Enabled = true;
            btnDeleteSelectedMeal.Enabled = true;

            selectedMeal = (int)dgvMealsInSelectedDate.CurrentRow.Cells["Id"].Value;
            ListTodgvProductsInSelectedMeal();
        }
        private void btnDeleteSelectedMeal_Click(object sender, EventArgs e)
        {
            if (selectedMeal != 0)
            {
                DialogResult answer = MessageBox.Show("The meal will be deleted. Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    try
                    {
                        Meal delete = context.Meals.Find(selectedMeal);
                        context.Meals.Remove(delete); // All changes will remove from database
                        context.SaveChanges();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                selectedMeal = 0;
                ListTodgvMealsInSelectedDate();
            }
            else
                MessageBox.Show("Please choose a meal.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnAddNewMeal_Click(object sender, EventArgs e)
        {
            frmAddMeal frm = new frmAddMeal(this, _user);
            frm.Show();
            this.Hide();
        }
        private void dgvProductsInSelectedMeal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedMealContent = context.MealContents.Find((int)dgvProductsInSelectedMeal.CurrentRow.Cells["MealId"].Value, (int)dgvProductsInSelectedMeal.CurrentRow.Cells["ProductId"].Value);

            lblProductNameInput.Text = selectedMealContent.Product.Name;
            lblUnitCalorieInput.Text = selectedMealContent.Product.Calorie.ToString();
            lblTotalCalorieInput.Text = selectedMealContent.TotalCalorie.ToString();
        }
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (selectedMealContent != null)
            {
                DialogResult answer = MessageBox.Show("The product will be deleted. Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    try
                    {
                        context.MealContents.Remove(selectedMealContent); // All changes will remove from database
                        Meal meal = context.Meals.Find(selectedMeal);
                        meal.ModifiedDate = DateTime.Now; // To update meal modified date
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                selectedMealContent = null;
                lblProductNameInput.Text = null;
                lblUnitCalorieInput.Text = null;
                lblTotalCalorieInput.Text = null;
                
                selectedMealContent = null;

                ListTodgvProductsInSelectedMeal();
            }
            else
                MessageBox.Show("Please choose a product.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnChangeQuantity_Click(object sender, EventArgs e)
        {
            if (selectedMealContent != null)
            {
                frmChangeQuantity frm = new frmChangeQuantity(this);
                frm.ShowDialog();
                try
                {
                    selectedMealContent.Quantity = newQuantity;
                    context.SaveChanges();
                    selectedMealContent = null;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                ListTodgvProductsInSelectedMeal();
            }
            else
                MessageBox.Show("Please choose a product.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnReturnMainPage_Click(object sender, EventArgs e)
        {
            _frmMainPage.Show();
            this.Close();
        }
    }
}
