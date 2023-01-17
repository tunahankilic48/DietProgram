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
            this.btnEditSelectedProduct = new System.Windows.Forms.Button();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.dgvProductsInSelectedMeal = new System.Windows.Forms.DataGridView();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.grbEditMeals = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReturnMainPage = new System.Windows.Forms.Button();
            this.lblSelectedMeals = new System.Windows.Forms.Label();
            this.dtpDateSelection = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteSelectedMeal = new System.Windows.Forms.Button();
            this.btnShowMeals = new System.Windows.Forms.Button();
            this.grbMeals = new System.Windows.Forms.GroupBox();
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
            this.lblNameSelectedProduct.Location = new System.Drawing.Point(152, 319);
            this.lblNameSelectedProduct.Name = "lblNameSelectedProduct";
            this.lblNameSelectedProduct.Size = new System.Drawing.Size(175, 15);
            this.lblNameSelectedProduct.TabIndex = 5;
            this.lblNameSelectedProduct.Text = "Product Name: [Product Name]";
            // 
            // lblCalorie
            // 
            this.lblCalorie.AutoSize = true;
            this.lblCalorie.Location = new System.Drawing.Point(152, 358);
            this.lblCalorie.Name = "lblCalorie";
            this.lblCalorie.Size = new System.Drawing.Size(123, 15);
            this.lblCalorie.TabIndex = 4;
            this.lblCalorie.Text = "Unit Calory: [ Calorie ]";
            // 
            // ptbProductPicture
            // 
            this.ptbProductPicture.Location = new System.Drawing.Point(16, 316);
            this.ptbProductPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbProductPicture.Name = "ptbProductPicture";
            this.ptbProductPicture.Size = new System.Drawing.Size(109, 100);
            this.ptbProductPicture.TabIndex = 3;
            this.ptbProductPicture.TabStop = false;
            // 
            // btnEditSelectedProduct
            // 
            this.btnEditSelectedProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnEditSelectedProduct.Location = new System.Drawing.Point(413, 355);
            this.btnEditSelectedProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditSelectedProduct.Name = "btnEditSelectedProduct";
            this.btnEditSelectedProduct.Size = new System.Drawing.Size(179, 22);
            this.btnEditSelectedProduct.TabIndex = 2;
            this.btnEditSelectedProduct.Text = "Edit";
            this.btnEditSelectedProduct.UseVisualStyleBackColor = false;
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnAddNewProduct.Location = new System.Drawing.Point(413, 394);
            this.btnAddNewProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(179, 22);
            this.btnAddNewProduct.TabIndex = 2;
            this.btnAddNewProduct.Text = "Add";
            this.btnAddNewProduct.UseVisualStyleBackColor = false;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnDeleteProduct.Location = new System.Drawing.Point(413, 316);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(179, 22);
            this.btnDeleteProduct.TabIndex = 2;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            // 
            // dgvProductsInSelectedMeal
            // 
            this.dgvProductsInSelectedMeal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.dgvProductsInSelectedMeal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsInSelectedMeal.Location = new System.Drawing.Point(16, 62);
            this.dgvProductsInSelectedMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductsInSelectedMeal.Name = "dgvProductsInSelectedMeal";
            this.dgvProductsInSelectedMeal.RowHeadersWidth = 51;
            this.dgvProductsInSelectedMeal.RowTemplate.Height = 29;
            this.dgvProductsInSelectedMeal.Size = new System.Drawing.Size(576, 241);
            this.dgvProductsInSelectedMeal.TabIndex = 1;
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.AutoSize = true;
            this.lblTotalCalories.Location = new System.Drawing.Point(152, 397);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(162, 15);
            this.lblTotalCalories.TabIndex = 0;
            this.lblTotalCalories.Text = "Total Calorie: [ Total Calories ]";
            // 
            // grbEditMeals
            // 
            this.grbEditMeals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.grbEditMeals.Controls.Add(this.lblNameSelectedProduct);
            this.grbEditMeals.Controls.Add(this.lblCalorie);
            this.grbEditMeals.Controls.Add(this.ptbProductPicture);
            this.grbEditMeals.Controls.Add(this.btnEditSelectedProduct);
            this.grbEditMeals.Controls.Add(this.btnAddNewProduct);
            this.grbEditMeals.Controls.Add(this.btnDeleteProduct);
            this.grbEditMeals.Controls.Add(this.dgvProductsInSelectedMeal);
            this.grbEditMeals.Controls.Add(this.label3);
            this.grbEditMeals.Controls.Add(this.lblTotalCalories);
            this.grbEditMeals.Location = new System.Drawing.Point(575, 10);
            this.grbEditMeals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbEditMeals.Name = "grbEditMeals";
            this.grbEditMeals.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbEditMeals.Size = new System.Drawing.Size(610, 428);
            this.grbEditMeals.TabIndex = 5;
            this.grbEditMeals.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Productlar";
            // 
            // btnReturnMainPage
            // 
            this.btnReturnMainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnReturnMainPage.Location = new System.Drawing.Point(11, 378);
            this.btnReturnMainPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturnMainPage.Name = "btnReturnMainPage";
            this.btnReturnMainPage.Size = new System.Drawing.Size(531, 32);
            this.btnReturnMainPage.TabIndex = 3;
            this.btnReturnMainPage.Text = "Turn Main Page";
            this.btnReturnMainPage.UseVisualStyleBackColor = false;
            // 
            // lblSelectedMeals
            // 
            this.lblSelectedMeals.AutoSize = true;
            this.lblSelectedMeals.Location = new System.Drawing.Point(206, 79);
            this.lblSelectedMeals.Name = "lblSelectedMeals";
            this.lblSelectedMeals.Size = new System.Drawing.Size(123, 15);
            this.lblSelectedMeals.TabIndex = 2;
            this.lblSelectedMeals.Text = "Meals [ Selected Date]";
            // 
            // dtpDateSelection
            // 
            this.dtpDateSelection.Location = new System.Drawing.Point(11, 28);
            this.dtpDateSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDateSelection.Name = "dtpDateSelection";
            this.dtpDateSelection.Size = new System.Drawing.Size(249, 23);
            this.dtpDateSelection.TabIndex = 0;
            // 
            // btnDeleteSelectedMeal
            // 
            this.btnDeleteSelectedMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnDeleteSelectedMeal.Location = new System.Drawing.Point(293, 331);
            this.btnDeleteSelectedMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteSelectedMeal.Name = "btnDeleteSelectedMeal";
            this.btnDeleteSelectedMeal.Size = new System.Drawing.Size(249, 32);
            this.btnDeleteSelectedMeal.TabIndex = 0;
            this.btnDeleteSelectedMeal.Text = "Delete Selected Meal";
            this.btnDeleteSelectedMeal.UseVisualStyleBackColor = false;
            // 
            // btnShowMeals
            // 
            this.btnShowMeals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnShowMeals.Location = new System.Drawing.Point(293, 28);
            this.btnShowMeals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowMeals.Name = "btnShowMeals";
            this.btnShowMeals.Size = new System.Drawing.Size(249, 23);
            this.btnShowMeals.TabIndex = 0;
            this.btnShowMeals.Text = "Show Meals";
            this.btnShowMeals.UseVisualStyleBackColor = false;
            // 
            // grbMeals
            // 
            this.grbMeals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.grbMeals.Controls.Add(this.btnReturnMainPage);
            this.grbMeals.Controls.Add(this.lblSelectedMeals);
            this.grbMeals.Controls.Add(this.dtpDateSelection);
            this.grbMeals.Controls.Add(this.btnDeleteSelectedMeal);
            this.grbMeals.Controls.Add(this.btnAddNewMeal);
            this.grbMeals.Controls.Add(this.dgvMealsInSelectedDate);
            this.grbMeals.Controls.Add(this.btnShowMeals);
            this.grbMeals.Location = new System.Drawing.Point(14, 10);
            this.grbMeals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbMeals.Name = "grbMeals";
            this.grbMeals.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbMeals.Size = new System.Drawing.Size(556, 428);
            this.grbMeals.TabIndex = 4;
            this.grbMeals.TabStop = false;
            // 
            // btnAddNewMeal
            // 
            this.btnAddNewMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnAddNewMeal.Location = new System.Drawing.Point(11, 331);
            this.btnAddNewMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNewMeal.Name = "btnAddNewMeal";
            this.btnAddNewMeal.Size = new System.Drawing.Size(249, 32);
            this.btnAddNewMeal.TabIndex = 0;
            this.btnAddNewMeal.Text = "Add New Meal";
            this.btnAddNewMeal.UseVisualStyleBackColor = false;
            // 
            // dgvMealsInSelectedDate
            // 
            this.dgvMealsInSelectedDate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.dgvMealsInSelectedDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealsInSelectedDate.Location = new System.Drawing.Point(11, 121);
            this.dgvMealsInSelectedDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMealsInSelectedDate.Name = "dgvMealsInSelectedDate";
            this.dgvMealsInSelectedDate.RowHeadersWidth = 51;
            this.dgvMealsInSelectedDate.RowTemplate.Height = 29;
            this.dgvMealsInSelectedDate.Size = new System.Drawing.Size(531, 182);
            this.dgvMealsInSelectedDate.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1199, 448);
            this.Controls.Add(this.grbEditMeals);
            this.Controls.Add(this.grbMeals);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.Text = "Form3";
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
        private Button btnEditSelectedProduct;
        private Button btnAddNewProduct;
        private Button btnDeleteProduct;
        private DataGridView dgvProductsInSelectedMeal;
        private Label lblTotalCalories;
        private GroupBox grbEditMeals;
        private Label label3;
        private Button btnReturnMainPage;
        private Label lblSelectedMeals;
        private DateTimePicker dtpDateSelection;
        private Button btnDeleteSelectedMeal;
        private Button btnShowMeals;
        private GroupBox grbMeals;
        private Button btnAddNewMeal;
        private DataGridView dgvMealsInSelectedDate;
    }
}