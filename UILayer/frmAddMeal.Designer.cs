namespace UILayer
{
    partial class frmAddMeal
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
            this.grbChooseMealAndDate = new System.Windows.Forms.GroupBox();
            this.cbbMeal = new System.Windows.Forms.ComboBox();
            this.lblMeal = new System.Windows.Forms.Label();
            this.btnCreateMeal = new System.Windows.Forms.Button();
            this.dtpMealDate = new System.Windows.Forms.DateTimePicker();
            this.lblMealDate = new System.Windows.Forms.Label();
            this.grbEditMealContent = new System.Windows.Forms.GroupBox();
            this.nudQuan = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnAddProductToMeal = new System.Windows.Forms.Button();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.lblSearchProduct = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.grbMealContent = new System.Windows.Forms.GroupBox();
            this.dgvMealContent = new System.Windows.Forms.DataGridView();
            this.btnConfirmTheMeal = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnTurnBackMealPages = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbChooseMealAndDate.SuspendLayout();
            this.grbEditMealContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.grbMealContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealContent)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbChooseMealAndDate
            // 
            this.grbChooseMealAndDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.grbChooseMealAndDate.Controls.Add(this.cbbMeal);
            this.grbChooseMealAndDate.Controls.Add(this.lblMeal);
            this.grbChooseMealAndDate.Controls.Add(this.btnCreateMeal);
            this.grbChooseMealAndDate.Controls.Add(this.dtpMealDate);
            this.grbChooseMealAndDate.Controls.Add(this.lblMealDate);
            this.grbChooseMealAndDate.Location = new System.Drawing.Point(9, 12);
            this.grbChooseMealAndDate.Name = "grbChooseMealAndDate";
            this.grbChooseMealAndDate.Size = new System.Drawing.Size(1064, 100);
            this.grbChooseMealAndDate.TabIndex = 0;
            this.grbChooseMealAndDate.TabStop = false;
            this.grbChooseMealAndDate.Text = "Choose Meal and Date";
            // 
            // cbbMeal
            // 
            this.cbbMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.cbbMeal.FormattingEnabled = true;
            this.cbbMeal.Location = new System.Drawing.Point(564, 45);
            this.cbbMeal.Name = "cbbMeal";
            this.cbbMeal.Size = new System.Drawing.Size(274, 38);
            this.cbbMeal.TabIndex = 4;
            // 
            // lblMeal
            // 
            this.lblMeal.AutoSize = true;
            this.lblMeal.Location = new System.Drawing.Point(492, 45);
            this.lblMeal.Name = "lblMeal";
            this.lblMeal.Size = new System.Drawing.Size(66, 30);
            this.lblMeal.TabIndex = 3;
            this.lblMeal.Text = "Meal:";
            // 
            // btnCreateMeal
            // 
            this.btnCreateMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnCreateMeal.Location = new System.Drawing.Point(860, 45);
            this.btnCreateMeal.Name = "btnCreateMeal";
            this.btnCreateMeal.Size = new System.Drawing.Size(198, 41);
            this.btnCreateMeal.TabIndex = 3;
            this.btnCreateMeal.Text = "Create Meal";
            this.btnCreateMeal.UseVisualStyleBackColor = false;
            this.btnCreateMeal.Click += new System.EventHandler(this.btnCreateMeal_Click);
            // 
            // dtpMealDate
            // 
            this.dtpMealDate.Location = new System.Drawing.Point(144, 45);
            this.dtpMealDate.Name = "dtpMealDate";
            this.dtpMealDate.Size = new System.Drawing.Size(330, 36);
            this.dtpMealDate.TabIndex = 2;
            // 
            // lblMealDate
            // 
            this.lblMealDate.AutoSize = true;
            this.lblMealDate.Location = new System.Drawing.Point(8, 48);
            this.lblMealDate.Name = "lblMealDate";
            this.lblMealDate.Size = new System.Drawing.Size(117, 30);
            this.lblMealDate.TabIndex = 0;
            this.lblMealDate.Text = "Meal Date:";
            // 
            // grbEditMealContent
            // 
            this.grbEditMealContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.grbEditMealContent.Controls.Add(this.nudQuan);
            this.grbEditMealContent.Controls.Add(this.lblQuantity);
            this.grbEditMealContent.Controls.Add(this.btnAddProductToMeal);
            this.grbEditMealContent.Controls.Add(this.txtProduct);
            this.grbEditMealContent.Controls.Add(this.lblSearchProduct);
            this.grbEditMealContent.Controls.Add(this.dgvProduct);
            this.grbEditMealContent.Location = new System.Drawing.Point(9, 116);
            this.grbEditMealContent.Name = "grbEditMealContent";
            this.grbEditMealContent.Size = new System.Drawing.Size(848, 555);
            this.grbEditMealContent.TabIndex = 1;
            this.grbEditMealContent.TabStop = false;
            this.grbEditMealContent.Text = "Edit Meal Content";
            // 
            // nudQuan
            // 
            this.nudQuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.nudQuan.Location = new System.Drawing.Point(112, 497);
            this.nudQuan.Name = "nudQuan";
            this.nudQuan.Size = new System.Drawing.Size(123, 36);
            this.nudQuan.TabIndex = 5;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(6, 499);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(100, 30);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity:";
            // 
            // btnAddProductToMeal
            // 
            this.btnAddProductToMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnAddProductToMeal.Location = new System.Drawing.Point(606, 488);
            this.btnAddProductToMeal.Name = "btnAddProductToMeal";
            this.btnAddProductToMeal.Size = new System.Drawing.Size(232, 52);
            this.btnAddProductToMeal.TabIndex = 3;
            this.btnAddProductToMeal.Text = "Add Product to Meal";
            this.btnAddProductToMeal.UseVisualStyleBackColor = false;
            this.btnAddProductToMeal.Click += new System.EventHandler(this.btnAddProductToMeal_Click);
            // 
            // txtProduct
            // 
            this.txtProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.txtProduct.Location = new System.Drawing.Point(175, 42);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(274, 36);
            this.txtProduct.TabIndex = 2;
            this.txtProduct.TextChanged += new System.EventHandler(this.txtProduct_TextChanged);
            // 
            // lblSearchProduct
            // 
            this.lblSearchProduct.AutoSize = true;
            this.lblSearchProduct.Location = new System.Drawing.Point(8, 45);
            this.lblSearchProduct.Name = "lblSearchProduct";
            this.lblSearchProduct.Size = new System.Drawing.Size(164, 30);
            this.lblSearchProduct.TabIndex = 1;
            this.lblSearchProduct.Text = "Search Product:";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(6, 85);
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 29;
            this.dgvProduct.Size = new System.Drawing.Size(833, 388);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // grbMealContent
            // 
            this.grbMealContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.grbMealContent.Controls.Add(this.dgvMealContent);
            this.grbMealContent.Controls.Add(this.btnConfirmTheMeal);
            this.grbMealContent.Controls.Add(this.btnDeleteProduct);
            this.grbMealContent.Location = new System.Drawing.Point(863, 116);
            this.grbMealContent.Name = "grbMealContent";
            this.grbMealContent.Size = new System.Drawing.Size(794, 555);
            this.grbMealContent.TabIndex = 2;
            this.grbMealContent.TabStop = false;
            this.grbMealContent.Text = "Meal Content";
            // 
            // dgvMealContent
            // 
            this.dgvMealContent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMealContent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.dgvMealContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealContent.Location = new System.Drawing.Point(6, 85);
            this.dgvMealContent.Name = "dgvMealContent";
            this.dgvMealContent.RowHeadersWidth = 51;
            this.dgvMealContent.RowTemplate.Height = 29;
            this.dgvMealContent.Size = new System.Drawing.Size(782, 388);
            this.dgvMealContent.TabIndex = 0;
            this.dgvMealContent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMealContent_CellClick_1);
            // 
            // btnConfirmTheMeal
            // 
            this.btnConfirmTheMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnConfirmTheMeal.Location = new System.Drawing.Point(579, 491);
            this.btnConfirmTheMeal.Name = "btnConfirmTheMeal";
            this.btnConfirmTheMeal.Size = new System.Drawing.Size(209, 52);
            this.btnConfirmTheMeal.TabIndex = 3;
            this.btnConfirmTheMeal.Text = "Confirm The Meal";
            this.btnConfirmTheMeal.UseVisualStyleBackColor = false;
            this.btnConfirmTheMeal.Click += new System.EventHandler(this.btnConfirmTheMeal_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnDeleteProduct.Location = new System.Drawing.Point(6, 491);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(390, 52);
            this.btnDeleteProduct.TabIndex = 3;
            this.btnDeleteProduct.Text = "Delete Product in the Meal Context";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnTurnBackMealPages
            // 
            this.btnTurnBackMealPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnTurnBackMealPages.Location = new System.Drawing.Point(322, 38);
            this.btnTurnBackMealPages.Name = "btnTurnBackMealPages";
            this.btnTurnBackMealPages.Size = new System.Drawing.Size(245, 50);
            this.btnTurnBackMealPages.TabIndex = 3;
            this.btnTurnBackMealPages.Text = "Turn Back Meal Pages";
            this.btnTurnBackMealPages.UseVisualStyleBackColor = false;
            this.btnTurnBackMealPages.Click += new System.EventHandler(this.btnTurnBackMealPages_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.groupBox1.Controls.Add(this.btnTurnBackMealPages);
            this.groupBox1.Location = new System.Drawing.Point(1079, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // frmAddMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1669, 687);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbMealContent);
            this.Controls.Add(this.grbEditMealContent);
            this.Controls.Add(this.grbChooseMealAndDate);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmAddMeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddMeal";
            this.Load += new System.EventHandler(this.frmAddMeal_Load);
            this.grbChooseMealAndDate.ResumeLayout(false);
            this.grbChooseMealAndDate.PerformLayout();
            this.grbEditMealContent.ResumeLayout(false);
            this.grbEditMealContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.grbMealContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealContent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grbChooseMealAndDate;
        private DateTimePicker dtpMealDate;
        private Label lblMealDate;
        private GroupBox grbEditMealContent;
        private Button btnAddProductToMeal;
        private TextBox txtProduct;
        private Label lblSearchProduct;
        private DataGridView dgvProduct;
        private NumericUpDown nudQuan;
        private Label lblQuantity;
        private GroupBox grbMealContent;
        private DataGridView dgvMealContent;
        private Button btnDeleteProduct;
        private Button btnConfirmTheMeal;
        private ComboBox cbbMeal;
        private Label lblMeal;
        private Button btnTurnBackMealPages;
        private GroupBox groupBox1;
        private Button btnCreateMeal;
    }
}