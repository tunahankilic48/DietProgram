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
using Windows.Media.PlayTo;

namespace UILayer
{
    public partial class frmAddMeal : Form
    {
        DietContext context;
        Product selectedProduct; // It represent selected product in the dgvProduct for addion of the product to meal content
        MealContent mealContent;
        List<Meal> meals; // It created for list of the user meals
        Meal currentMeal; // It created for selection of the new meal
        MealContent willDeleteProduct; // It took selected product in the dgvMealContent
        private AppUser _user;
        private frmMeal _frmMeal;

        public frmAddMeal(frmMeal frmMeal, AppUser user)
        {
            InitializeComponent();
            _user = user;
            _frmMeal = frmMeal;
        }

        #region Methods
        /// <summary>
        /// It fills the cbbMeal combobox
        /// </summary>
        void FillcbbMeal()
        {
            cbbMeal.ValueMember = "Id";
            cbbMeal.DisplayMember = "Name";
            cbbMeal.DataSource = context.MealCategories.ToList();
            cbbMeal.SelectedIndex = -1;
        }
        /// <summary>
        /// It list the all products
        /// </summary>
        void ListdgvProduct()
        {
            var products = context.Products.Select(x => new
            {
                ProductName = x.Name,
                CategoryName = x.ProductCategory.Name,
                x.QuantityPerUnit,
                x.Id,
                CategoryId = x.ProductCategory.Id
            });
            dgvProduct.DataSource = products.ToList();

            dgvProduct.Columns["Id"].Visible = false;
            dgvProduct.Columns["CategoryId"].Visible = false;
        }
        /// <summary>
        /// It list products that contains string parametre
        /// </summary>
        /// <param name="productName">It is the variable that will search in the product name</param>
        void ListdgvProduct(string productName)
        {
            var products = context.Products.Where(x => x.Name.Contains(productName)).Select(x => new
            {
                ProductName = x.Name,
                CategoryName = x.ProductCategory.Name,
                x.QuantityPerUnit,
                x.Id,
                CategoryId = x.ProductCategory.Id
            });
            dgvProduct.DataSource = products.ToList();

            dgvProduct.Columns["Id"].Visible = false;
            dgvProduct.Columns["CategoryId"].Visible = false;

        }
        /// <summary>
        /// It list Meal content for choosen meal
        /// </summary>
        void ListdgvMealContent()
        {
            var mealProducts = context.MealContents.Where(x => x.MealId == currentMeal.Id).ToList();

            foreach (var item in mealProducts)
            {
                item.Product = context.Products.Find(item.ProductId);
                context.Update(item);
            }

            dgvMealContent.DataSource = mealProducts.Select(x => new
            {
                Meal = x.Meal.MealCategory.Name,
                Product = x.Product.Name,
                x.Quantity,
                x.TotalCalorie,
                x.CreatedDate,
                x.MealId,
                x.ProductId
            }).ToList();
            dgvMealContent.Columns["MealId"].Visible = false;
            dgvMealContent.Columns["ProductId"].Visible = false;
        }
        #endregion

        #region Buttons
        private void btnAddProductToMeal_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null) // It has been guaranteed that A producted was selected
            {

                if (nudQuan.Value > 0) // Selected producted must be added at least one
                {
                    var mealProducts = context.MealContents.Where(x => x.MealId == currentMeal.Id).Where(x => x.ProductId == selectedProduct.Id).ToList(); // It controls whether product added twice

                    if (mealProducts.Count == 0)
                    {
                        mealContent = new MealContent(); // New Meal content created and properties were filled
                        mealContent.MealId = currentMeal.Id;
                        mealContent.ProductId = selectedProduct.Id;
                        mealContent.Quantity = (int)nudQuan.Value;
                        mealContent.CreatedDate = DateTime.Now;
                        mealContent.ModifiedDate = dtpMealDate.Value;
                        mealContent.Product = selectedProduct;
                        try
                        {
                            context.MealContents.Add(mealContent); // Meal content added to the database
                            context.SaveChanges();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        ListdgvMealContent();
                        selectedProduct = null;
                    }
                    else
                        MessageBox.Show("You cannot add same product in the meal.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("You must set the quantity bigger than 0..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (selectedProduct == null)
                    MessageBox.Show("You must choose a product.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("You must choose a meal.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnCreateMeal_Click(object sender, EventArgs e)
        {
            if (cbbMeal.SelectedIndex != -1) // It has been guaranteed to choose a meal
            {
                List<Meal> tempMeals = new List<Meal>(); // It was created to check for meals containing the same date and same meal.
                foreach (Meal meal1 in meals)
                {
                    if ((meal1.ModifiedDate.Value.ToShortDateString() == dtpMealDate.Value.ToShortDateString()) && (meal1.MealCategoryId == (int)cbbMeal.SelectedValue))
                        tempMeals.Add(meal1); // If there is the same date and same meal, It added into tempMeals variable
                }

                if (tempMeals.Count == 0)
                {
                    Meal meal = new Meal();
                    meal.UserId = _user.Id;
                    meal.MealCategoryId = (int)cbbMeal.SelectedValue;
                    meal.CreatedDate = DateTime.Now;
                    meal.ModifiedDate = dtpMealDate.Value;
                    try
                    {
                        context.Meals.Add(meal);
                        context.SaveChanges();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    currentMeal = meal;

                    dtpMealDate.Enabled = false;
                    btnCreateMeal.Enabled = false;
                    cbbMeal.Enabled = false;

                    txtProduct.Enabled = true;
                    nudQuan.Enabled = true;
                    btnAddProductToMeal.Enabled = true;
                    btnConfirmTheMeal.Enabled = true;
                    btnDeleteProduct.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Choosen date has meal that is choosen category. Please select new date or meal category or go back to the meal section to modify created meals.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                tempMeals = null;
            }
            else
                MessageBox.Show("A meal category must be choosen.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                context.MealContents.Remove(willDeleteProduct);
                context.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ListdgvMealContent();
        }
        private void btnConfirmTheMeal_Click(object sender, EventArgs e)
        {
            _frmMeal.Show();
            this.Close();
        }
        private void btnTurnBackMealPages_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("All changes will be deleted. Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                try
                {
                    context.Meals.Remove(currentMeal); // All changes will remove from database
                    context.SaveChanges();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                _frmMeal.Show();
                this.Close();
            }
        }
        #endregion
        private void frmAddMeal_Load(object sender, EventArgs e)
        {
            context = new DietContext();
            meals = new List<Meal>();
            currentMeal = new Meal();

            txtProduct.Enabled = false;
            nudQuan.Enabled = false;
            btnAddProductToMeal.Enabled = false;
            btnConfirmTheMeal.Enabled = false;
            btnDeleteProduct.Enabled = false;

            dtpMealDate.Value = DateTime.Now; // It sets the current value
            dtpMealDate.MaxDate = dtpMealDate.Value; // The max date cannot be more than today
            _user = context.AppUsers.Find(1); // Silinecek

            FillcbbMeal();
            ListdgvProduct();

            meals = context.Meals.Where(x => x.UserId == _user.Id).ToList(); // The meals of user's

        }
        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            ListdgvProduct(txtProduct.Text); // It will filter the products acording to text in the txtProduct
        }
        private void dgvMealContent_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            willDeleteProduct = context.MealContents.Find((int)dgvMealContent.CurrentRow.Cells["MealId"].Value, (int)dgvMealContent.CurrentRow.Cells["ProductId"].Value); // It will find the willDeleteProduct
        }
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedProduct = context.Products.Find((int)dgvProduct.CurrentRow.Cells["Id"].Value); // It will find the selected product
        }
    }
}
