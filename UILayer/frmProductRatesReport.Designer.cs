namespace UILayer
{
    partial class frmProductRatesReport
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbBreakfasts = new System.Windows.Forms.RadioButton();
            this.rdbLaunch = new System.Windows.Forms.RadioButton();
            this.rdbDinners = new System.Windows.Forms.RadioButton();
            this.rdbSnacks = new System.Windows.Forms.RadioButton();
            this.rdbAllMeals = new System.Windows.Forms.RadioButton();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerateResult = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.groupBox1.Controls.Add(this.btnGenerateResult);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.dtpEndDate);
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Controls.Add(this.rdbAllMeals);
            this.groupBox1.Controls.Add(this.rdbSnacks);
            this.groupBox1.Controls.Add(this.rdbDinners);
            this.groupBox1.Controls.Add(this.rdbLaunch);
            this.groupBox1.Controls.Add(this.rdbBreakfasts);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meal Content Report";
            // 
            // rdbBreakfasts
            // 
            this.rdbBreakfasts.AutoSize = true;
            this.rdbBreakfasts.Location = new System.Drawing.Point(22, 145);
            this.rdbBreakfasts.Name = "rdbBreakfasts";
            this.rdbBreakfasts.Size = new System.Drawing.Size(78, 19);
            this.rdbBreakfasts.TabIndex = 0;
            this.rdbBreakfasts.TabStop = true;
            this.rdbBreakfasts.Text = "Breakfasts";
            this.rdbBreakfasts.UseVisualStyleBackColor = true;
            // 
            // rdbLaunch
            // 
            this.rdbLaunch.AutoSize = true;
            this.rdbLaunch.Location = new System.Drawing.Point(22, 180);
            this.rdbLaunch.Name = "rdbLaunch";
            this.rdbLaunch.Size = new System.Drawing.Size(69, 19);
            this.rdbLaunch.TabIndex = 1;
            this.rdbLaunch.TabStop = true;
            this.rdbLaunch.Text = "Lunches";
            this.rdbLaunch.UseVisualStyleBackColor = true;
            // 
            // rdbDinners
            // 
            this.rdbDinners.AutoSize = true;
            this.rdbDinners.Location = new System.Drawing.Point(22, 215);
            this.rdbDinners.Name = "rdbDinners";
            this.rdbDinners.Size = new System.Drawing.Size(65, 19);
            this.rdbDinners.TabIndex = 2;
            this.rdbDinners.TabStop = true;
            this.rdbDinners.Text = "Dinners";
            this.rdbDinners.UseVisualStyleBackColor = true;
            // 
            // rdbSnacks
            // 
            this.rdbSnacks.AutoSize = true;
            this.rdbSnacks.Location = new System.Drawing.Point(22, 250);
            this.rdbSnacks.Name = "rdbSnacks";
            this.rdbSnacks.Size = new System.Drawing.Size(61, 19);
            this.rdbSnacks.TabIndex = 3;
            this.rdbSnacks.TabStop = true;
            this.rdbSnacks.Text = "Snacks";
            this.rdbSnacks.UseVisualStyleBackColor = true;
            // 
            // rdbAllMeals
            // 
            this.rdbAllMeals.AutoSize = true;
            this.rdbAllMeals.Location = new System.Drawing.Point(22, 110);
            this.rdbAllMeals.Name = "rdbAllMeals";
            this.rdbAllMeals.Size = new System.Drawing.Size(73, 19);
            this.rdbAllMeals.TabIndex = 4;
            this.rdbAllMeals.TabStop = true;
            this.rdbAllMeals.Text = "All Meals";
            this.rdbAllMeals.UseVisualStyleBackColor = true;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(118, 30);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(269, 23);
            this.dtpStartDate.TabIndex = 5;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(118, 69);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(269, 23);
            this.dtpEndDate.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(118, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(269, 162);
            this.dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "End Date: ";
            // 
            // btnGenerateResult
            // 
            this.btnGenerateResult.Location = new System.Drawing.Point(22, 297);
            this.btnGenerateResult.Name = "btnGenerateResult";
            this.btnGenerateResult.Size = new System.Drawing.Size(365, 37);
            this.btnGenerateResult.TabIndex = 10;
            this.btnGenerateResult.Text = "Ganerate Results";
            this.btnGenerateResult.UseVisualStyleBackColor = true;
            this.btnGenerateResult.Click += new System.EventHandler(this.btnGenerateResult_Click);
            // 
            // frmProductRatesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(434, 385);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmProductRatesReport";
            this.Text = "frmProductRatesReport";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProductRatesReport_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnGenerateResult;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private RadioButton rdbAllMeals;
        private RadioButton rdbSnacks;
        private RadioButton rdbDinners;
        private RadioButton rdbLaunch;
        private RadioButton rdbBreakfasts;
    }
}