using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UILayer
{
    public partial class frmResetPassword : Form
    {
        private AppUser _user;
        private string _verificationCode;
        private frmForgotPassword _frmForgetPassword;
        private frmLoginPanel _frmLogin;
        DietContext context;

        public frmResetPassword(AppUser user, string verificationCode, frmForgotPassword frmForgetPassword, frmLoginPanel frmLogin)
        {
            InitializeComponent();
            _user = user;
            _verificationCode = verificationCode;
            _frmForgetPassword = frmForgetPassword;
            _frmLogin = frmLogin;
        }

        private void frmResetPassword_Load(object sender, EventArgs e)
        {
            context = new DietContext();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtVerificationCode.Text == _verificationCode)
            {
                MessageBox.Show("Verification code is correct. You can change your password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCheck.Enabled = false;
                txtVerificationCode.Enabled = false;
                btnChangePassword.Enabled = true;
                txtPassword.Enabled = true;
                txtPasswordAgain.Enabled = true;
                Method.CleanTheControls(this);
            }
            else
            {
                MessageBox.Show("Verification code is not correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Method.CleanTheControls(this);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtPasswordAgain.Text)
            {
                try
                {
                    _user.Password = txtPasswordAgain.Text;
                    context.AppUsers.Update(_user);
                    context.SaveChanges();
                    MessageBox.Show("Password has changed successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _frmLogin.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Passwords are not same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Method.CleanTheControls(this);
            }
        }

        private void lblTurnBackfrmForgetPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Redirected to forget password page.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _frmForgetPassword.Show();
            this.Close();

        }


    }
}
