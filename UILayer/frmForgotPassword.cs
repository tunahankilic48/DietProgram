using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using DataAccessLayer;
using EntityLayer;

namespace UILayer
{
    public partial class frmForgotPassword : Form
    {
        public frmForgotPassword(frmLoginPanel frmLogin)
        {
            InitializeComponent();
            _frmLogin = frmLogin;
        }

        DietContext context;
        Random rnd;
        private frmLoginPanel _frmLogin;

        private void frmForgotPassword_Load(object sender, EventArgs e)
        {
            context = new DietContext();
            rnd = new Random();
        }
        private void btnSendPassword_Click(object sender, EventArgs e)
        {
            AppUser? user = context.AppUsers.Where(x => x.Email == txtEmail.Text).FirstOrDefault();

            if (user != null)
            {
                string from, userMail, password, messageBody, verificationCode;
                verificationCode = rnd.Next(10000, 100000).ToString();
                MailMessage message = new MailMessage();

                from = "dietchecker3@gmail.com";
                message.From = new MailAddress(from);
                message.Subject = "Password Reset Code";
                password = "kyfntyomzlhyflol";
                messageBody = "Your reset code is " + verificationCode;

                userMail = txtEmail.Text;
                message.To.Add(userMail);
                message.Body = messageBody;

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Credentials = new NetworkCredential(from, password);
                smtpClient.EnableSsl = true;
                try
                {
                    smtpClient.Send(message);
                    MessageBox.Show("Verification code was send to your E-mail address.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmResetPassword frm = new frmResetPassword(user, verificationCode, this, _frmLogin);
                    frm.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Mail address is not correct. Please check the E-mail address and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Method.CleanTheControls(this);
            }
        }
    }
}
