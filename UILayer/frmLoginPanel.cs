using DataAccessLayer;
using EntityLayer;

namespace UILayer
{
    public partial class frmLoginPanel : Form
    {
        DietContext context;
        public frmLoginPanel()
        {
            InitializeComponent();
        }

        private void frmLoginPanel_Load(object sender, EventArgs e)
        {
            context = new DietContext();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            AppUser? user = context.AppUsers.Where(x => x.Email == txtEmail.Text).ToList().FirstOrDefault(); // Email check from database
            if (user != null)
            {
                if (user.Password == txtPassword.Text) // Password check
                {
                    frmMainPage frm = new frmMainPage(user);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password is not correct. Please check the password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Method.CleanTheControls(this);
                }

            }
            else
            {
                MessageBox.Show("Mail address is not correct. Please check the E-mail address or create a new account.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Method.CleanTheControls(this);
            }
        }
        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            frmForgotPassword frm = new frmForgotPassword(this);
            frm.Show();
            this.Hide();
        }
        private void lblCreateANewAccount_Click(object sender, EventArgs e)
        {
            frmNewAccount frm = new frmNewAccount(); // to do: içerisine bu form verilecek sonrasında
            frm.Show();
            this.Hide();
        }
    }
}
