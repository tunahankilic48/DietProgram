namespace UILayer
{
    partial class frmMeal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNameSelectedProduct = new System.Windows.Forms.Label();
            this.lblCalorie = new System.Windows.Forms.Label();
            this.ptbProductPicture = new System.Windows.Forms.PictureBox();
            this.btnChangeQuantity = new System.Windows.Forms.Button();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.dgvProductsInSelectedMeal = new System.Windows.Forms.DataGridView();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.grbEditMeals = new System.Windows.Forms.GroupBox();
            this.lblTotalCalorieInput = new System.Windows.Forms.Label();
            this.lblUnitCalorieInput = new System.Windows.Forms.Label();
            this.lblProductNameInput = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.btnReturnMainPage = new System.Windows.Forms.Button();
            this.lblSelectedMeals = new System.Windows.Forms.Label();
            this.dtpDateSelection = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteSelectedMeal = new System.Windows.Forms.Button();
            this.btnShowMeals = new System.Windows.Forms.Button();
            this.grbMeals = new System.Windows.Forms.GroupBox();
            this.lblMealDate = new System.Windows.Forms.Label();
            this.btnAddNewMeal = new System.Windows.Forms.Button();
            this.dgvMealsInSelectedDate = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProductPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsInSelectedMeal)).BeginInit();
            this.grbEditMeals.SuspendLayout();
            this.grbMeals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealsInSelectedDate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameSelectedProduct
            // 
            this.lblNameSelectedProduct.AutoSize = true;
            this.lblNameSelectedProduct.Location = new System.Drawing.Point(200, 507);
            this.lblNameSelectedProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameSelectedProduct.Name = "lblNameSelectedProduct";
            this.lblNameSelectedProduct.Size = new System.Drawing.Size(157, 30);
            this.lblNameSelectedProduct.TabIndex = 5;
            this.lblNameSelectedProduct.Text = "Product Name:";
            // 
            // lblCalorie
            // 
            this.lblCalorie.AutoSize = true;
            this.lblCalorie.Location = new System.Drawing.Point(226, 575);
            this.lblCalorie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalorie.Name = "lblCalorie";
            this.lblCalorie.Size = new System.Drawing.Size(131, 30);
            this.lblCalorie.TabIndex = 4;
            this.lblCalorie.Text = "Unit Calorie:";
            // 
            // ptbProductPicture
            // 
            this.ptbProductPicture.Location = new System.Drawing.Point(21, 502);
            this.ptbProductPicture.Margin = new System.Windows.Forms.Padding(4);
            this.ptbProductPicture.Name = "ptbProductPicture";
            this.ptbProductPicture.Size = new System.Drawing.Size(155, 173);
            this.ptbProductPicture.TabIndex = 3;
            this.ptbProductPicture.TabStop = false;
            // 
            // btnChangeQuantity
            // 
            this.btnChangeQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnChangeQuantity.Location = new System.Drawing.Point(589, 569);
            this.btnChangeQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeQuantity.Name = "btnChangeQuantity";
            this.btnChangeQuantity.Size = new System.Drawing.Size(230, 44);
            this.btnChangeQuantity.TabIndex = 2;
            this.btnChangeQuantity.Text = "Change Quantity";
            this.btnChangeQuantity.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnChangeQuantity.UseVisualStyleBackColor = false;
            this.btnChangeQuantity.Click += new System.EventHandler(this.btnChangeQuantity_Click);
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnAddNewProduct.Location = new System.Drawing.Point(589, 636);
            this.btnAddNewProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(230, 44);
            this.btnAddNewProduct.TabIndex = 2;
            this.btnAddNewProduct.Text = "Add New Product";
            this.btnAddNewProduct.UseVisualStyleBackColor = false;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnDeleteProduct.Location = new System.Drawing.Point(589, 502);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(230, 44);
            this.btnDeleteProduct.TabIndex = 2;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // dgvProductsInSelectedMeal
            // 
            this.dgvProductsInSelectedMeal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductsInSelectedMeal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.dgvProductsInSelectedMeal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsInSelectedMeal.Location = new System.Drawing.Point(8, 116);
            this.dgvProductsInSelectedMeal.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductsInSelectedMeal.Name = "dgvProductsInSelectedMeal";
            this.dgvProductsInSelectedMeal.RowHeadersWidth = 51;
            this.dgvProductsInSelectedMeal.RowTemplate.Height = 29;
            this.dgvProductsInSelectedMeal.Size = new System.Drawing.Size(811, 364);
            this.dgvProductsInSelectedMeal.TabIndex = 1;
            this.dgvProductsInSelectedMeal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductsInSelectedMeal_CellClick);
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.AutoSize = true;
            this.lblTotalCalories.Location = new System.Drawing.Point(219, 643);
            this.lblTotalCalories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(138, 30);
            this.lblTotalCalories.TabIndex = 0;
            this.lblTotalCalories.Text = "Total Calorie:";
            // 
            // grbEditMeals
            // 
            this.grbEditMeals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.grbEditMeals.Controls.Add(this.lblTotalCalorieInput);
            this.grbEditMeals.Controls.Add(this.lblUnitCalorieInput);
            this.grbEditMeals.Controls.Add(this.lblProductNameInput);
            this.grbEditMeals.Controls.Add(this.lblNameSelectedProduct);
            this.grbEditMeals.Controls.Add(this.lblCalorie);
            this.grbEditMeals.Controls.Add(this.ptbProductPicture);
            this.grbEditMeals.Controls.Add(this.btnChangeQuantity);
            this.grbEditMeals.Controls.Add(this.btnAddNewProduct);
            this.grbEditMeals.Controls.Add(this.btnDeleteProduct);
            this.grbEditMeals.Controls.Add(this.dgvProductsInSelectedMeal);
            this.grbEditMeals.Controls.Add(this.lblProducts);
            this.grbEditMeals.Controls.Add(this.lblTotalCalories);
            this.grbEditMeals.Location = new System.Drawing.Point(880, 20);
            this.grbEditMeals.Margin = new System.Windows.Forms.Padding(4);
            this.grbEditMeals.Name = "grbEditMeals";
            this.grbEditMeals.Padding = new System.Windows.Forms.Padding(4);
            this.grbEditMeals.Size = new System.Drawing.Size(838, 694);
            this.grbEditMeals.TabIndex = 5;
            this.grbEditMeals.TabStop = false;
            // 
            // lblTotalCalorieInput
            // 
            this.lblTotalCalorieInput.AutoSize = true;
            this.lblTotalCalorieInput.Location = new System.Drawing.Point(354, 645);
            this.lblTotalCalorieInput.Name = "lblTotalCalorieInput";
            this.lblTotalCalorieInput.Size = new System.Drawing.Size(0, 30);
            this.lblTotalCalorieInput.TabIndex = 6;
            // 
            // lblUnitCalorieInput
            // 
            this.lblUnitCalorieInput.AutoSize = true;
            this.lblUnitCalorieInput.Location = new System.Drawing.Point(354, 575);
            this.lblUnitCalorieInput.Name = "lblUnitCalorieInput";
            this.lblUnitCalorieInput.Size = new System.Drawing.Size(0, 30);
            this.lblUnitCalorieInput.TabIndex = 6;
            // 
            // lblProductNameInput
            // 
            this.lblProductNameInput.AutoSize = true;
            this.lblProductNameInput.Location = new System.Drawing.Point(354, 507);
            this.lblProductNameInput.Name = "lblProductNameInput";
            this.lblProductNameInput.Size = new System.Drawing.Size(0, 30);
            this.lblProductNameInput.TabIndex = 6;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(371, 25);
            this.lblProducts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(97, 30);
            this.lblProducts.TabIndex = 0;
            this.lblProducts.Text = "Products";
            // 
            // btnReturnMainPage
            // 
            this.btnReturnMainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnReturnMainPage.Location = new System.Drawing.Point(20, 622);
            this.btnReturnMainPage.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturnMainPage.Name = "btnReturnMainPage";
            this.btnReturnMainPage.Size = new System.Drawing.Size(811, 64);
            this.btnReturnMainPage.TabIndex = 3;
            this.btnReturnMainPage.Text = "Turn Main Page";
            this.btnReturnMainPage.UseVisualStyleBackColor = false;
            this.btnReturnMainPage.Click += new System.EventHandler(this.btnReturnMainPage_Click);
            // 
            // lblSelectedMeals
            // 
            this.lblSelectedMeals.AutoSize = true;
            this.lblSelectedMeals.Location = new System.Drawing.Point(315, 75);
            this.lblSelectedMeals.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedMeals.Name = "lblSelectedMeals";
            this.lblSelectedMeals.Size = new System.Drawing.Size(75, 30);
            this.lblSelectedMeals.TabIndex = 2;
            this.lblSelectedMeals.Text = "Meals:";
            // 
            // dtpDateSelection
            // 
            this.dtpDateSelection.Location = new System.Drawing.Point(20, 25);
            this.dtpDateSelection.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateSelection.Name = "dtpDateSelection";
            this.dtpDateSelection.Size = new System.Drawing.Size(377, 36);
            this.dtpDateSelection.TabIndex = 0;
            // 
            // btnDeleteSelectedMeal
            // 
            this.btnDeleteSelectedMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnDeleteSelectedMeal.Location = new System.Drawing.Point(473, 525);
            this.btnDeleteSelectedMeal.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteSelectedMeal.Name = "btnDeleteSelectedMeal";
            this.btnDeleteSelectedMeal.Size = new System.Drawing.Size(358, 64);
            this.btnDeleteSelectedMeal.TabIndex = 0;
            this.btnDeleteSelectedMeal.Text = "Delete Selected Meal";
            this.btnDeleteSelectedMeal.UseVisualStyleBackColor = false;
            this.btnDeleteSelectedMeal.Click += new System.EventHandler(this.btnDeleteSelectedMeal_Click);
            // 
            // btnShowMeals
            // 
            this.btnShowMeals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnShowMeals.Location = new System.Drawing.Point(458, 25);
            this.btnShowMeals.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowMeals.Name = "btnShowMeals";
            this.btnShowMeals.Size = new System.Drawing.Size(373, 38);
            this.btnShowMeals.TabIndex = 0;
            this.btnShowMeals.Text = "Show Meals";
            this.btnShowMeals.UseVisualStyleBackColor = false;
            this.btnShowMeals.Click += new System.EventHandler(this.btnShowMeals_Click);
            // 
            // grbMeals
            // 
            this.grbMeals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.grbMeals.Controls.Add(this.lblMealDate);
            this.grbMeals.Controls.Add(this.btnReturnMainPage);
            this.grbMeals.Controls.Add(this.lblSelectedMeals);
            this.grbMeals.Controls.Add(this.dtpDateSelection);
            this.grbMeals.Controls.Add(this.btnDeleteSelectedMeal);
            this.grbMeals.Controls.Add(this.btnAddNewMeal);
            this.grbMeals.Controls.Add(this.dgvMealsInSelectedDate);
            this.grbMeals.Controls.Add(this.btnShowMeals);
            this.grbMeals.Location = new System.Drawing.Point(24, 20);
            this.grbMeals.Margin = new System.Windows.Forms.Padding(4);
            this.grbMeals.Name = "grbMeals";
            this.grbMeals.Padding = new System.Windows.Forms.Padding(4);
            this.grbMeals.Size = new System.Drawing.Size(848, 694);
            this.grbMeals.TabIndex = 4;
            this.grbMeals.TabStop = false;
            // 
            // lblMealDate
            // 
            this.lblMealDate.AutoSize = true;
            this.lblMealDate.Location = new System.Drawing.Point(383, 75);
            this.lblMealDate.Name = "lblMealDate";
            this.lblMealDate.Size = new System.Drawing.Size(0, 30);
            this.lblMealDate.TabIndex = 4;
            // 
            // btnAddNewMeal
            // 
            this.btnAddNewMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnAddNewMeal.Location = new System.Drawing.Point(20, 525);
            this.btnAddNewMeal.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewMeal.Name = "btnAddNewMeal";
            this.btnAddNewMeal.Size = new System.Drawing.Size(358, 64);
            this.btnAddNewMeal.TabIndex = 0;
            this.btnAddNewMeal.Text = "Add New Meal";
            this.btnAddNewMeal.UseVisualStyleBackColor = false;
            this.btnAddNewMeal.Click += new System.EventHandler(this.btnAddNewMeal_Click);
            // 
            // dgvMealsInSelectedDate
            // 
            this.dgvMealsInSelectedDate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMealsInSelectedDate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.dgvMealsInSelectedDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealsInSelectedDate.Location = new System.Drawing.Point(20, 116);
            this.dgvMealsInSelectedDate.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMealsInSelectedDate.Name = "dgvMealsInSelectedDate";
            this.dgvMealsInSelectedDate.RowHeadersWidth = 51;
            this.dgvMealsInSelectedDate.RowTemplate.Height = 29;
            this.dgvMealsInSelectedDate.Size = new System.Drawing.Size(811, 364);
            this.dgvMealsInSelectedDate.TabIndex = 1;
            this.dgvMealsInSelectedDate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMealsInSelectedDate_CellClick);
            // 
            // frmMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1733, 729);
            this.Controls.Add(this.grbEditMeals);
            this.Controls.Add(this.grbMeals);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmMeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DIET CHECKER";
            this.Load += new System.EventHandler(this.frmMeal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbProductPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsInSelectedMeal)).EndInit();
            this.grbEditMeals.ResumeLayout(false);
            this.grbEditMeals.PerformLayout();
            this.grbMeals.ResumeLayout(false);
            this.grbMeals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealsInSelectedDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblNameSelectedProduct;
        private Label lblCalorie;
        private PictureBox ptbProductPicture;
        private Button btnChangeQuantity;
        private Button btnAddNewProduct;
        private Button btnDeleteProduct;
        private DataGridView dgvProductsInSelectedMeal;
        private Label lblTotalCalories;
        private GroupBox grbEditMeals;
        private Label lblProducts;
        private Button btnReturnMainPage;
        private Label lblSelectedMeals;
        private DateTimePicker dtpDateSelection;
        private Button btnDeleteSelectedMeal;
        private Button btnShowMeals;
        private GroupBox grbMeals;
        private Button btnAddNewMeal;
        private DataGridView dgvMealsInSelectedDate;
        private Label lblTotalCalorieInput;
        private Label lblUnitCalorieInput;
        private Label lblProductNameInput;
        private Label lblMealDate;
    }
}