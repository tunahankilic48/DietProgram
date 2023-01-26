namespace UILayer
{
    partial class frmDailyReport
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
            this.dtpDailyReport = new System.Windows.Forms.DateTimePicker();
            this.btnReport = new System.Windows.Forms.Button();
            this.grpDailyReport = new System.Windows.Forms.GroupBox();
            this.lblDailySnackCalorieResult = new System.Windows.Forms.Label();
            this.lblDinnerTotalCalorieResult = new System.Windows.Forms.Label();
            this.lblLaunchTotalCalorieResult = new System.Windows.Forms.Label();
            this.lblSnackCalorie = new System.Windows.Forms.Label();
            this.lblDinnerCalorie = new System.Windows.Forms.Label();
            this.lblLaunchCalorie = new System.Windows.Forms.Label();
            this.lblDailyTotalCalorieResult = new System.Windows.Forms.Label();
            this.lblTotalCalorie1 = new System.Windows.Forms.Label();
            this.lblBreakfastTotalCalorieResult = new System.Windows.Forms.Label();
            this.lblKahvaltiCalorie = new System.Windows.Forms.Label();
            this.dgvDailyMeals = new System.Windows.Forms.DataGridView();
            this.grpDailyReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyMeals)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDailyReport
            // 
            this.dtpDailyReport.Location = new System.Drawing.Point(5, 20);
            this.dtpDailyReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDailyReport.Name = "dtpDailyReport";
            this.dtpDailyReport.Size = new System.Drawing.Size(217, 23);
            this.dtpDailyReport.TabIndex = 1;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnReport.Location = new System.Drawing.Point(236, 20);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(216, 22);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "DAILY REPORT";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // grpDailyReport
            // 
            this.grpDailyReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.grpDailyReport.Controls.Add(this.lblDailySnackCalorieResult);
            this.grpDailyReport.Controls.Add(this.lblDinnerTotalCalorieResult);
            this.grpDailyReport.Controls.Add(this.lblLaunchTotalCalorieResult);
            this.grpDailyReport.Controls.Add(this.lblSnackCalorie);
            this.grpDailyReport.Controls.Add(this.lblDinnerCalorie);
            this.grpDailyReport.Controls.Add(this.lblLaunchCalorie);
            this.grpDailyReport.Controls.Add(this.lblDailyTotalCalorieResult);
            this.grpDailyReport.Controls.Add(this.lblTotalCalorie1);
            this.grpDailyReport.Controls.Add(this.lblBreakfastTotalCalorieResult);
            this.grpDailyReport.Controls.Add(this.lblKahvaltiCalorie);
            this.grpDailyReport.Controls.Add(this.dgvDailyMeals);
            this.grpDailyReport.Controls.Add(this.btnReport);
            this.grpDailyReport.Controls.Add(this.dtpDailyReport);
            this.grpDailyReport.Location = new System.Drawing.Point(3, 4);
            this.grpDailyReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDailyReport.Name = "grpDailyReport";
            this.grpDailyReport.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDailyReport.Size = new System.Drawing.Size(458, 371);
            this.grpDailyReport.TabIndex = 3;
            this.grpDailyReport.TabStop = false;
            this.grpDailyReport.Text = "DAILY REPORT";
            // 
            // lblDailySnackCalorieResult
            // 
            this.lblDailySnackCalorieResult.AutoSize = true;
            this.lblDailySnackCalorieResult.Location = new System.Drawing.Point(258, 327);
            this.lblDailySnackCalorieResult.Name = "lblDailySnackCalorieResult";
            this.lblDailySnackCalorieResult.Size = new System.Drawing.Size(70, 15);
            this.lblDailySnackCalorieResult.TabIndex = 13;
            this.lblDailySnackCalorieResult.Text = "0 kcal ( %0 )";
            // 
            // lblDinnerTotalCalorieResult
            // 
            this.lblDinnerTotalCalorieResult.AutoSize = true;
            this.lblDinnerTotalCalorieResult.Location = new System.Drawing.Point(258, 301);
            this.lblDinnerTotalCalorieResult.Name = "lblDinnerTotalCalorieResult";
            this.lblDinnerTotalCalorieResult.Size = new System.Drawing.Size(70, 15);
            this.lblDinnerTotalCalorieResult.TabIndex = 12;
            this.lblDinnerTotalCalorieResult.Text = "0 kcal ( %0 )";
            // 
            // lblLaunchTotalCalorieResult
            // 
            this.lblLaunchTotalCalorieResult.AutoSize = true;
            this.lblLaunchTotalCalorieResult.Location = new System.Drawing.Point(258, 275);
            this.lblLaunchTotalCalorieResult.Name = "lblLaunchTotalCalorieResult";
            this.lblLaunchTotalCalorieResult.Size = new System.Drawing.Size(70, 15);
            this.lblLaunchTotalCalorieResult.TabIndex = 11;
            this.lblLaunchTotalCalorieResult.Text = "0 kcal ( %0 )";
            // 
            // lblSnackCalorie
            // 
            this.lblSnackCalorie.AutoSize = true;
            this.lblSnackCalorie.Location = new System.Drawing.Point(86, 327);
            this.lblSnackCalorie.Name = "lblSnackCalorie";
            this.lblSnackCalorie.Size = new System.Drawing.Size(122, 15);
            this.lblSnackCalorie.TabIndex = 10;
            this.lblSnackCalorie.Text = "Total Calorie at Snack:";
            // 
            // lblDinnerCalorie
            // 
            this.lblDinnerCalorie.AutoSize = true;
            this.lblDinnerCalorie.Location = new System.Drawing.Point(86, 301);
            this.lblDinnerCalorie.Name = "lblDinnerCalorie";
            this.lblDinnerCalorie.Size = new System.Drawing.Size(126, 15);
            this.lblDinnerCalorie.TabIndex = 9;
            this.lblDinnerCalorie.Text = "Total Calorie at Dinner:";
            // 
            // lblLaunchCalorie
            // 
            this.lblLaunchCalorie.AutoSize = true;
            this.lblLaunchCalorie.Location = new System.Drawing.Point(86, 275);
            this.lblLaunchCalorie.Name = "lblLaunchCalorie";
            this.lblLaunchCalorie.Size = new System.Drawing.Size(130, 15);
            this.lblLaunchCalorie.TabIndex = 8;
            this.lblLaunchCalorie.Text = "Total Calorie at Launch:";
            // 
            // lblDailyTotalCalorieResult
            // 
            this.lblDailyTotalCalorieResult.AutoSize = true;
            this.lblDailyTotalCalorieResult.Location = new System.Drawing.Point(258, 220);
            this.lblDailyTotalCalorieResult.Name = "lblDailyTotalCalorieResult";
            this.lblDailyTotalCalorieResult.Size = new System.Drawing.Size(70, 15);
            this.lblDailyTotalCalorieResult.TabIndex = 7;
            this.lblDailyTotalCalorieResult.Text = "0 kcal ( %0 )";
            // 
            // lblTotalCalorie1
            // 
            this.lblTotalCalorie1.AutoSize = true;
            this.lblTotalCalorie1.Location = new System.Drawing.Point(86, 220);
            this.lblTotalCalorie1.Name = "lblTotalCalorie1";
            this.lblTotalCalorie1.Size = new System.Drawing.Size(78, 15);
            this.lblTotalCalorie1.TabIndex = 6;
            this.lblTotalCalorie1.Text = "Total Calorie: ";
            // 
            // lblBreakfastTotalCalorieResult
            // 
            this.lblBreakfastTotalCalorieResult.AutoSize = true;
            this.lblBreakfastTotalCalorieResult.Location = new System.Drawing.Point(258, 249);
            this.lblBreakfastTotalCalorieResult.Name = "lblBreakfastTotalCalorieResult";
            this.lblBreakfastTotalCalorieResult.Size = new System.Drawing.Size(70, 15);
            this.lblBreakfastTotalCalorieResult.TabIndex = 5;
            this.lblBreakfastTotalCalorieResult.Text = "0 kcal ( %0 )";
            // 
            // lblKahvaltiCalorie
            // 
            this.lblKahvaltiCalorie.AutoSize = true;
            this.lblKahvaltiCalorie.Location = new System.Drawing.Point(86, 249);
            this.lblKahvaltiCalorie.Name = "lblKahvaltiCalorie";
            this.lblKahvaltiCalorie.Size = new System.Drawing.Size(139, 15);
            this.lblKahvaltiCalorie.TabIndex = 4;
            this.lblKahvaltiCalorie.Text = "Total Calorie at Breakfast:";
            // 
            // dgvDailyMeals
            // 
            this.dgvDailyMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailyMeals.Location = new System.Drawing.Point(9, 81);
            this.dgvDailyMeals.Name = "dgvDailyMeals";
            this.dgvDailyMeals.RowTemplate.Height = 25;
            this.dgvDailyMeals.Size = new System.Drawing.Size(443, 132);
            this.dgvDailyMeals.TabIndex = 3;
            // 
            // frmDailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(465, 379);
            this.Controls.Add(this.grpDailyReport);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDailyReport";
            this.Text = "frmDailyReport";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDailyReport_FormClosing);
            this.grpDailyReport.ResumeLayout(false);
            this.grpDailyReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyMeals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DateTimePicker dtpDailyReport;
        private Button btnReport;
        private GroupBox grpDailyReport;
        private Label lblBreakfastTotalCalorieResult;
        private Label lblKahvaltiCalorie;
        private DataGridView dgvDailyMeals;
        private Label lblDailySnackCalorieResult;
        private Label lblDinnerTotalCalorieResult;
        private Label lblLaunchTotalCalorieResult;
        private Label lblSnackCalorie;
        private Label lblDinnerCalorie;
        private Label lblLaunchCalorie;
        private Label lblDailyTotalCalorieResult;
        private Label lblTotalCalorie1;
    }
}