namespace UILayer
{
    partial class frmNewAccountConfirmation
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtConfirmationCode = new System.Windows.Forms.TextBox();
            this.lblConfirmationCode = new System.Windows.Forms.Label();
            this.grbResetPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbResetPassword
            // 
            this.grbResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.grbResetPassword.Controls.Add(this.btnCheck);
            this.grbResetPassword.Controls.Add(this.txtConfirmationCode);
            this.grbResetPassword.Controls.Add(this.lblConfirmationCode);
            this.grbResetPassword.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbResetPassword.Location = new System.Drawing.Point(11, 11);
            this.grbResetPassword.Margin = new System.Windows.Forms.Padding(2);
            this.grbResetPassword.Name = "grbResetPassword";
            this.grbResetPassword.Padding = new System.Windows.Forms.Padding(2);
            this.grbResetPassword.Size = new System.Drawing.Size(456, 150);
            this.grbResetPassword.TabIndex = 3;
            this.grbResetPassword.TabStop = false;
            this.grbResetPassword.Text = "E-mail Confirmation";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnCheck.Location = new System.Drawing.Point(198, 87);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(212, 42);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtConfirmationCode
            // 
            this.txtConfirmationCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.txtConfirmationCode.ForeColor = System.Drawing.Color.Black;
            this.txtConfirmationCode.Location = new System.Drawing.Point(198, 38);
            this.txtConfirmationCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmationCode.Name = "txtConfirmationCode";
            this.txtConfirmationCode.Size = new System.Drawing.Size(212, 36);
            this.txtConfirmationCode.TabIndex = 1;
            // 
            // lblConfirmationCode
            // 
            this.lblConfirmationCode.AutoSize = true;
            this.lblConfirmationCode.ForeColor = System.Drawing.Color.Black;
            this.lblConfirmationCode.Location = new System.Drawing.Point(2, 39);
            this.lblConfirmationCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmationCode.Name = "lblConfirmationCode";
            this.lblConfirmationCode.Size = new System.Drawing.Size(202, 30);
            this.lblConfirmationCode.TabIndex = 0;
            this.lblConfirmationCode.Text = "Confirmation Code:";
            // 
            // frmNewAccountConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(478, 175);
            this.Controls.Add(this.grbResetPassword);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmNewAccountConfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DIET CHECKER";
            this.grbResetPassword.ResumeLayout(false);
            this.grbResetPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grbResetPassword;
        private Button btnCheck;
        private TextBox txtConfirmationCode;
        private Label lblConfirmationCode;
    }
}