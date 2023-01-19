namespace UILayer
{
    partial class frmResetPassword
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
            this.grbResetPassword = new System.Windows.Forms.GroupBox();
            this.lblTurnBackfrmForgetPassword = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtPasswordAgain = new System.Windows.Forms.TextBox();
            this.lblPasswordAgain = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtVerificationCode = new System.Windows.Forms.TextBox();
            this.lblVerificationCode = new System.Windows.Forms.Label();
            this.grbResetPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbResetPassword
            // 
            this.grbResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.grbResetPassword.Controls.Add(this.lblTurnBackfrmForgetPassword);
            this.grbResetPassword.Controls.Add(this.btnChangePassword);
            this.grbResetPassword.Controls.Add(this.btnCheck);
            this.grbResetPassword.Controls.Add(this.txtPasswordAgain);
            this.grbResetPassword.Controls.Add(this.lblPasswordAgain);
            this.grbResetPassword.Controls.Add(this.txtPassword);
            this.grbResetPassword.Controls.Add(this.lblPassword);
            this.grbResetPassword.Controls.Add(this.txtVerificationCode);
            this.grbResetPassword.Controls.Add(this.lblVerificationCode);
            this.grbResetPassword.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbResetPassword.Location = new System.Drawing.Point(11, 11);
            this.grbResetPassword.Margin = new System.Windows.Forms.Padding(2);
            this.grbResetPassword.Name = "grbResetPassword";
            this.grbResetPassword.Padding = new System.Windows.Forms.Padding(2);
            this.grbResetPassword.Size = new System.Drawing.Size(456, 365);
            this.grbResetPassword.TabIndex = 2;
            this.grbResetPassword.TabStop = false;
            this.grbResetPassword.Text = "Reset Password";
            // 
            // lblTurnBackfrmForgetPassword
            // 
            this.lblTurnBackfrmForgetPassword.AutoSize = true;
            this.lblTurnBackfrmForgetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTurnBackfrmForgetPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblTurnBackfrmForgetPassword.ForeColor = System.Drawing.Color.Blue;
            this.lblTurnBackfrmForgetPassword.Location = new System.Drawing.Point(29, 44);
            this.lblTurnBackfrmForgetPassword.Name = "lblTurnBackfrmForgetPassword";
            this.lblTurnBackfrmForgetPassword.Size = new System.Drawing.Size(400, 28);
            this.lblTurnBackfrmForgetPassword.TabIndex = 3;
            this.lblTurnBackfrmForgetPassword.Text = "If you don\'t have Verification code, click here";
            this.lblTurnBackfrmForgetPassword.Click += new System.EventHandler(this.lblTurnBackfrmForgetPassword_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnChangePassword.Enabled = false;
            this.btnChangePassword.Location = new System.Drawing.Point(198, 313);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(212, 42);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnCheck.Location = new System.Drawing.Point(198, 143);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(212, 42);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtPasswordAgain
            // 
            this.txtPasswordAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.txtPasswordAgain.Enabled = false;
            this.txtPasswordAgain.ForeColor = System.Drawing.Color.Black;
            this.txtPasswordAgain.Location = new System.Drawing.Point(198, 266);
            this.txtPasswordAgain.Margin = new System.Windows.Forms.Padding(2);
            this.txtPasswordAgain.Name = "txtPasswordAgain";
            this.txtPasswordAgain.PasswordChar = '*';
            this.txtPasswordAgain.Size = new System.Drawing.Size(212, 36);
            this.txtPasswordAgain.TabIndex = 4;
            // 
            // lblPasswordAgain
            // 
            this.lblPasswordAgain.AutoSize = true;
            this.lblPasswordAgain.ForeColor = System.Drawing.Color.Black;
            this.lblPasswordAgain.Location = new System.Drawing.Point(29, 272);
            this.lblPasswordAgain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswordAgain.Name = "lblPasswordAgain";
            this.lblPasswordAgain.Size = new System.Drawing.Size(169, 30);
            this.lblPasswordAgain.TabIndex = 0;
            this.lblPasswordAgain.Text = "Password Again:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.txtPassword.Enabled = false;
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(198, 219);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(212, 36);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(90, 222);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(108, 30);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password:";
            // 
            // txtVerificationCode
            // 
            this.txtVerificationCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.txtVerificationCode.ForeColor = System.Drawing.Color.Black;
            this.txtVerificationCode.Location = new System.Drawing.Point(198, 94);
            this.txtVerificationCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtVerificationCode.Name = "txtVerificationCode";
            this.txtVerificationCode.Size = new System.Drawing.Size(212, 36);
            this.txtVerificationCode.TabIndex = 1;
            // 
            // lblVerificationCode
            // 
            this.lblVerificationCode.AutoSize = true;
            this.lblVerificationCode.ForeColor = System.Drawing.Color.Black;
            this.lblVerificationCode.Location = new System.Drawing.Point(14, 94);
            this.lblVerificationCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVerificationCode.Name = "lblVerificationCode";
            this.lblVerificationCode.Size = new System.Drawing.Size(184, 30);
            this.lblVerificationCode.TabIndex = 0;
            this.lblVerificationCode.Text = "Verification Code:";
            // 
            // frmResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(478, 387);
            this.Controls.Add(this.grbResetPassword);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DIET CHECKER";
            this.Load += new System.EventHandler(this.frmResetPassword_Load);
            this.grbResetPassword.ResumeLayout(false);
            this.grbResetPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grbResetPassword;
        private Button btnCheck;
        private TextBox txtVerificationCode;
        private Label lblVerificationCode;
        private Button btnChangePassword;
        private TextBox txtPasswordAgain;
        private Label lblPasswordAgain;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label lblTurnBackfrmForgetPassword;
    }
}