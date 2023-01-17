namespace UILayer
{
    partial class frmMainPage
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
            this.btnMeal = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.grpUserInformation = new System.Windows.Forms.GroupBox();
            this.lblBodyMassIndex = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblCaloriesTakenToday2 = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblCaloriesTakenToday = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblCaloriesNeeded2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCaloriesNeeded = new System.Windows.Forms.Label();
            this.btnHeightandWeightUpdate = new System.Windows.Forms.Button();
            this.btnUpdateAccountInformation = new System.Windows.Forms.Button();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblSurname2 = new System.Windows.Forms.Label();
            this.lblHeight2 = new System.Windows.Forms.Label();
            this.lblWeight2 = new System.Windows.Forms.Label();
            this.lblBodyMassIndex2 = new System.Windows.Forms.Label();
            this.grpUserInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMeal
            // 
            this.btnMeal.Location = new System.Drawing.Point(12, 450);
            this.btnMeal.Name = "btnMeal";
            this.btnMeal.Size = new System.Drawing.Size(216, 86);
            this.btnMeal.TabIndex = 0;
            this.btnMeal.Text = "MEAL";
            this.btnMeal.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(234, 450);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(235, 86);
            this.btnReports.TabIndex = 0;
            this.btnReports.Text = "REPORTS";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // grpUserInformation
            // 
            this.grpUserInformation.Controls.Add(this.lblBodyMassIndex2);
            this.grpUserInformation.Controls.Add(this.lblWeight2);
            this.grpUserInformation.Controls.Add(this.lblHeight2);
            this.grpUserInformation.Controls.Add(this.lblSurname2);
            this.grpUserInformation.Controls.Add(this.lblName2);
            this.grpUserInformation.Controls.Add(this.lblBodyMassIndex);
            this.grpUserInformation.Controls.Add(this.lblWeight);
            this.grpUserInformation.Controls.Add(this.lblCaloriesTakenToday2);
            this.grpUserInformation.Controls.Add(this.lblSurname);
            this.grpUserInformation.Controls.Add(this.lblCaloriesTakenToday);
            this.grpUserInformation.Controls.Add(this.lblHeight);
            this.grpUserInformation.Controls.Add(this.lblCaloriesNeeded2);
            this.grpUserInformation.Controls.Add(this.lblName);
            this.grpUserInformation.Controls.Add(this.lblCaloriesNeeded);
            this.grpUserInformation.Location = new System.Drawing.Point(12, 12);
            this.grpUserInformation.Name = "grpUserInformation";
            this.grpUserInformation.Size = new System.Drawing.Size(457, 414);
            this.grpUserInformation.TabIndex = 1;
            this.grpUserInformation.TabStop = false;
            this.grpUserInformation.Text = "User Information";
            // 
            // lblBodyMassIndex
            // 
            this.lblBodyMassIndex.AutoSize = true;
            this.lblBodyMassIndex.Location = new System.Drawing.Point(4, 174);
            this.lblBodyMassIndex.Name = "lblBodyMassIndex";
            this.lblBodyMassIndex.Size = new System.Drawing.Size(123, 20);
            this.lblBodyMassIndex.TabIndex = 0;
            this.lblBodyMassIndex.Text = "Body Mass Index:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(68, 137);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(59, 20);
            this.lblWeight.TabIndex = 0;
            this.lblWeight.Text = "Weigth:";
            // 
            // lblCaloriesTakenToday2
            // 
            this.lblCaloriesTakenToday2.AutoSize = true;
            this.lblCaloriesTakenToday2.Location = new System.Drawing.Point(203, 280);
            this.lblCaloriesTakenToday2.Name = "lblCaloriesTakenToday2";
            this.lblCaloriesTakenToday2.Size = new System.Drawing.Size(106, 20);
            this.lblCaloriesTakenToday2.TabIndex = 0;
            this.lblCaloriesTakenToday2.Text = "Calories Intake";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(57, 69);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(70, 20);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Surname:";
            // 
            // lblCaloriesTakenToday
            // 
            this.lblCaloriesTakenToday.AutoSize = true;
            this.lblCaloriesTakenToday.Location = new System.Drawing.Point(6, 280);
            this.lblCaloriesTakenToday.Name = "lblCaloriesTakenToday";
            this.lblCaloriesTakenToday.Size = new System.Drawing.Size(150, 20);
            this.lblCaloriesTakenToday.TabIndex = 0;
            this.lblCaloriesTakenToday.Text = "Calories Taken Today:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(70, 104);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(57, 20);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "Height:";
            this.lblHeight.Click += new System.EventHandler(this.lblHeight_Click);
            // 
            // lblCaloriesNeeded2
            // 
            this.lblCaloriesNeeded2.AutoSize = true;
            this.lblCaloriesNeeded2.Location = new System.Drawing.Point(203, 250);
            this.lblCaloriesNeeded2.Name = "lblCaloriesNeeded2";
            this.lblCaloriesNeeded2.Size = new System.Drawing.Size(113, 20);
            this.lblCaloriesNeeded2.TabIndex = 0;
            this.lblCaloriesNeeded2.Text = "Calories to Take";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(75, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblCaloriesNeeded
            // 
            this.lblCaloriesNeeded.AutoSize = true;
            this.lblCaloriesNeeded.Location = new System.Drawing.Point(34, 250);
            this.lblCaloriesNeeded.Name = "lblCaloriesNeeded";
            this.lblCaloriesNeeded.Size = new System.Drawing.Size(122, 20);
            this.lblCaloriesNeeded.TabIndex = 0;
            this.lblCaloriesNeeded.Text = "Calories Needed:";
            // 
            // btnHeightandWeightUpdate
            // 
            this.btnHeightandWeightUpdate.Location = new System.Drawing.Point(12, 541);
            this.btnHeightandWeightUpdate.Name = "btnHeightandWeightUpdate";
            this.btnHeightandWeightUpdate.Size = new System.Drawing.Size(216, 86);
            this.btnHeightandWeightUpdate.TabIndex = 0;
            this.btnHeightandWeightUpdate.Text = "HEIGHT AND WEIGHT UPDATE";
            this.btnHeightandWeightUpdate.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAccountInformation
            // 
            this.btnUpdateAccountInformation.Location = new System.Drawing.Point(234, 542);
            this.btnUpdateAccountInformation.Name = "btnUpdateAccountInformation";
            this.btnUpdateAccountInformation.Size = new System.Drawing.Size(235, 86);
            this.btnUpdateAccountInformation.TabIndex = 0;
            this.btnUpdateAccountInformation.Text = "UPDATE ACCOUNT INFORMATION";
            this.btnUpdateAccountInformation.UseVisualStyleBackColor = true;
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Location = new System.Drawing.Point(206, 36);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(50, 20);
            this.lblName2.TabIndex = 1;
            this.lblName2.Text = "label1";
            // 
            // lblSurname2
            // 
            this.lblSurname2.AutoSize = true;
            this.lblSurname2.Location = new System.Drawing.Point(206, 69);
            this.lblSurname2.Name = "lblSurname2";
            this.lblSurname2.Size = new System.Drawing.Size(50, 20);
            this.lblSurname2.TabIndex = 2;
            this.lblSurname2.Text = "label3";
            // 
            // lblHeight2
            // 
            this.lblHeight2.AutoSize = true;
            this.lblHeight2.Location = new System.Drawing.Point(206, 104);
            this.lblHeight2.Name = "lblHeight2";
            this.lblHeight2.Size = new System.Drawing.Size(50, 20);
            this.lblHeight2.TabIndex = 3;
            this.lblHeight2.Text = "label5";
            // 
            // lblWeight2
            // 
            this.lblWeight2.AutoSize = true;
            this.lblWeight2.Location = new System.Drawing.Point(206, 137);
            this.lblWeight2.Name = "lblWeight2";
            this.lblWeight2.Size = new System.Drawing.Size(50, 20);
            this.lblWeight2.TabIndex = 4;
            this.lblWeight2.Text = "label6";
            // 
            // lblBodyMassIndex2
            // 
            this.lblBodyMassIndex2.AutoSize = true;
            this.lblBodyMassIndex2.Location = new System.Drawing.Point(206, 174);
            this.lblBodyMassIndex2.Name = "lblBodyMassIndex2";
            this.lblBodyMassIndex2.Size = new System.Drawing.Size(50, 20);
            this.lblBodyMassIndex2.TabIndex = 5;
            this.lblBodyMassIndex2.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(490, 639);
            this.Controls.Add(this.grpUserInformation);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnUpdateAccountInformation);
            this.Controls.Add(this.btnHeightandWeightUpdate);
            this.Controls.Add(this.btnMeal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpUserInformation.ResumeLayout(false);
            this.grpUserInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnMeal;
        private Button btnReports;
        private GroupBox grpUserInformation;
        private Label lblBodyMassIndex;
        private Label lblWeight;
        private Label lblCaloriesTakenToday2;
        private Label lblSurname;
        private Label lblCaloriesTakenToday;
        private Label lblHeight;
        private Label lblCaloriesNeeded2;
        private Label lblName;
        private Label lblCaloriesNeeded;
        private Button btnHeightandWeightUpdate;
        private Button btnUpdateAccountInformation;
        private Label lblBodyMassIndex2;
        private Label lblWeight2;
        private Label lblHeight2;
        private Label lblSurname2;
        private Label lblName2;
    }
}