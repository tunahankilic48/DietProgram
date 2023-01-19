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
            this.btnSendPassword = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.grbForgotPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbForgotPassword
            // 
            this.grbForgotPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.grbForgotPassword.Controls.Add(this.btnSendPassword);
            this.grbForgotPassword.Controls.Add(this.txtEmail);
            this.grbForgotPassword.Controls.Add(this.lblEmail);
            this.grbForgotPassword.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbForgotPassword.Location = new System.Drawing.Point(9, 9);
            this.grbForgotPassword.Margin = new System.Windows.Forms.Padding(2);
            this.grbForgotPassword.Name = "grbForgotPassword";
            this.grbForgotPassword.Padding = new System.Windows.Forms.Padding(2);
            this.grbForgotPassword.Size = new System.Drawing.Size(514, 174);
            this.grbForgotPassword.TabIndex = 1;
            this.grbForgotPassword.TabStop = false;
            this.grbForgotPassword.Text = "Forgot Password";
            // 
            // btnSendPassword
            // 
            this.btnSendPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnSendPassword.Location = new System.Drawing.Point(133, 98);
            this.btnSendPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendPassword.Name = "btnSendPassword";
            this.btnSendPassword.Size = new System.Drawing.Size(326, 42);
            this.btnSendPassword.TabIndex = 2;
            this.btnSendPassword.Text = "Send Password Reminder Mail";
            this.btnSendPassword.UseVisualStyleBackColor = false;
            this.btnSendPassword.Click += new System.EventHandler(this.btnSendPassword_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(133, 49);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(326, 36);
            this.txtEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(53, 52);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(79, 30);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-Mail:";
            // 
            // frmForgotPassword
            // 
            this.AcceptButton = this.btnSendPassword;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(534, 194);
            this.Controls.Add(this.grbForgotPassword);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DIET CHECKER";
            this.Load += new System.EventHandler(this.frmForgotPassword_Load);
            this.grbForgotPassword.ResumeLayout(false);
            this.grbForgotPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grbForgotPassword;
        private Button btnSendPassword;
        private TextBox txtEmail;
        private Label lblEmail;
    }
}