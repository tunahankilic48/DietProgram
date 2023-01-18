namespace UILayer
{
    partial class frmMealContentReport
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
            this.cbbChooseMeal = new System.Windows.Forms.ComboBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBeginDate = new System.Windows.Forms.DateTimePicker();
            this.lblChooseMeal = new System.Windows.Forms.Label();
            this.lblDateInterval = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.cbbChooseMeal);
            this.groupBox1.Controls.Add(this.dtpEndDate);
            this.groupBox1.Controls.Add(this.dtpBeginDate);
            this.groupBox1.Controls.Add(this.lblChooseMeal);
            this.groupBox1.Controls.Add(this.lblDateInterval);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbbChooseMeal
            // 
            this.cbbChooseMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.cbbChooseMeal.FormattingEnabled = true;
            this.cbbChooseMeal.Location = new System.Drawing.Point(165, 72);
            this.cbbChooseMeal.Name = "cbbChooseMeal";
            this.cbbChooseMeal.Size = new System.Drawing.Size(250, 38);
            this.cbbChooseMeal.TabIndex = 2;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dd   MMMM   yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(445, 26);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(250, 36);
            this.dtpEndDate.TabIndex = 1;
            // 
            // dtpBeginDate
            // 
            this.dtpBeginDate.CustomFormat = "dd   MMMM   yyyy";
            this.dtpBeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBeginDate.Location = new System.Drawing.Point(165, 26);
            this.dtpBeginDate.Name = "dtpBeginDate";
            this.dtpBeginDate.Size = new System.Drawing.Size(250, 36);
            this.dtpBeginDate.TabIndex = 1;
            // 
            // lblChooseMeal
            // 
            this.lblChooseMeal.AutoSize = true;
            this.lblChooseMeal.Location = new System.Drawing.Point(6, 75);
            this.lblChooseMeal.Name = "lblChooseMeal";
            this.lblChooseMeal.Size = new System.Drawing.Size(145, 30);
            this.lblChooseMeal.TabIndex = 0;
            this.lblChooseMeal.Text = "Choose Meal:";
            // 
            // lblDateInterval
            // 
            this.lblDateInterval.AutoSize = true;
            this.lblDateInterval.Location = new System.Drawing.Point(10, 31);
            this.lblDateInterval.Name = "lblDateInterval";
            this.lblDateInterval.Size = new System.Drawing.Size(141, 30);
            this.lblDateInterval.TabIndex = 0;
            this.lblDateInterval.Text = "Date Interval:";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnCreate.Location = new System.Drawing.Point(445, 72);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(250, 38);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // frmMealContentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(744, 507);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMealContentReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMealContentReport";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbbChooseMeal;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpBeginDate;
        private Label lblChooseMeal;
        private Label lblDateInterval;
        private Button btnCreate;
    }
}