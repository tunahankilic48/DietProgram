namespace UILayer
{
    partial class frmForgotPassword
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
            this.grbForgotPassword = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.grbForgotPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbForgotPassword
            // 
            this.grbForgotPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.grbForgotPassword.Controls.Add(this.btnLogin);
            this.grbForgotPassword.Controls.Add(this.txtEmail);
            this.grbForgotPassword.Controls.Add(this.lblEmail);
            this.grbForgotPassword.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbForgotPassword.Location = new System.Drawing.Point(9, 9);
            this.grbForgotPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbForgotPassword.Name = "grbForgotPassword";
            this.grbForgotPassword.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbForgotPassword.Size = new System.Drawing.Size(415, 136);
            this.grbForgotPassword.TabIndex = 1;
            this.grbForgotPassword.TabStop = false;
            this.grbForgotPassword.Text = "Forgot Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnLogin.Location = new System.Drawing.Point(108, 71);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(255, 42);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Send Password Reminder Mail";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(108, 30);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(256, 31);
            this.txtEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(26, 32);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(65, 25);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-Mail:";
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(434, 154);
            this.Controls.Add(this.grbForgotPassword);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmForgotPassword";
            this.Text = "frmForgotPassword";
            this.grbForgotPassword.ResumeLayout(false);
            this.grbForgotPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grbForgotPassword;
        private Button btnLogin;
        private TextBox txtEmail;
        private Label lblEmail;
    }
}