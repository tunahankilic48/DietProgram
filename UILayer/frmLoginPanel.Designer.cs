namespace UILayer
{
    partial class frmLoginPanel
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblCreateANewAccount = new System.Windows.Forms.Label();
            this.lblForgetPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.lblCreateANewAccount);
            this.groupBox1.Controls.Add(this.lblForgetPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnLogin.Location = new System.Drawing.Point(123, 208);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(340, 44);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(123, 73);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(340, 31);
            this.txtPassword.TabIndex = 1;
            // 
            // lblCreateANewAccount
            // 
            this.lblCreateANewAccount.AutoSize = true;
            this.lblCreateANewAccount.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblCreateANewAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(212)))));
            this.lblCreateANewAccount.Location = new System.Drawing.Point(123, 165);
            this.lblCreateANewAccount.Name = "lblCreateANewAccount";
            this.lblCreateANewAccount.Size = new System.Drawing.Size(186, 25);
            this.lblCreateANewAccount.TabIndex = 0;
            this.lblCreateANewAccount.Text = "Create a New Account";
            // 
            // lblForgetPassword
            // 
            this.lblForgetPassword.AutoSize = true;
            this.lblForgetPassword.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblForgetPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(212)))));
            this.lblForgetPassword.Location = new System.Drawing.Point(123, 122);
            this.lblForgetPassword.Name = "lblForgetPassword";
            this.lblForgetPassword.Size = new System.Drawing.Size(144, 25);
            this.lblForgetPassword.TabIndex = 0;
            this.lblForgetPassword.Text = "Forget Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(123, 24);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(340, 31);
            this.txtEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(52, 27);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(65, 25);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-Mail:";
            // 
            // frmLoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(522, 297);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLoginPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogInPanel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label lblCreateANewAccount;
        private Label lblForgetPassword;
        private Label label1;
        private TextBox txtEmail;
        private Label lblEmail;
    }
}