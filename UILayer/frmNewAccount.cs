using DataAccessLayer;
using EntityLayer;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System.Text.RegularExpressions;

namespace UILayer
{
    public partial class frmNewAccount : Form
    {
        DietContext context;
        public frmNewAccount()
        {
            InitializeComponent();
        }
        string password = "";
        string letters = "QWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇqwertyuıopğüasdfghjklşizxcvbnmöç";
        string numbers = "1234567890";
        string specialCharacters = "!'^+%&/()=?_>£#$½{[]}<.:@€₺i¨~æß´`;,";

        bool LetterTrue = false;
        bool NumberTrue = false;
        bool SpecialCharacterTrue = false;
        private void frmNewAccount_Load(object sender, EventArgs e)
        {
            context = new DietContext();

            cbbCity.ValueMember = "Id";
            cbbCity.DisplayMember = "Name";
            cbbCity.DataSource = context.Cities.ToList();

            cbbCountry.ValueMember = "Id";
            cbbCountry.DisplayMember = "Name";
            cbbCountry.DataSource = context.Countries.ToList();

            lblPasword.Visible = false;
        }

        #region Buttons

        private void btnUploadPic_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.FileName = "";
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Load(open.FileName);
            }
        }

        private async void btnCreate_Click_1(object sender, EventArgs e)
        {
            AppUser newUser = new AppUser()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                BirtDate = dtpBirthDate.Value,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                IsMale = rdbMale.Checked,
                IsActive = true
            };

            Address address = new Address();

            address.CityId = (int)cbbCity.SelectedValue;

            WeightsAndHeights weightsAndHeights = new WeightsAndHeights();

            weightsAndHeights.Weight = decimal.Parse(txtWeight.Text);
            weightsAndHeights.Height = int.Parse(txtHeight.Text);

            context.AppUsers.Add(newUser);
            context.Addresses.Add(address);
            context.UsersWeightsAndHeights.Add(weightsAndHeights);
            context.SaveChanges();

            newUser.AddressId = address.Id;
            address.UserId = newUser.Id;
            weightsAndHeights.UserId = newUser.Id;

            var image = new ImageConverter().ConvertTo(pictureBox1.Image, typeof(Byte[]));
            newUser.ProfilePhoto = (byte[])image;

            context.SaveChanges();
        }
        #endregion

        #region Methods
        public void PasswordControl()
        {
            password = txtPassword.Text;
            if (password.Length < 6)
            {
                lblPasword.Text = "Weak Password";
            }
            else
            {
                foreach (char item in password)
                {
                    if (letters.IndexOf(item) != -1)
                    {
                        LetterTrue = true;
                    }
                    if (numbers.IndexOf(item) != -1)
                    {
                        NumberTrue = true;
                    }
                    if (specialCharacters.IndexOf(item) != -1)
                    {
                        SpecialCharacterTrue = true;
                    }
                }
                if (LetterTrue == true && NumberTrue == true && SpecialCharacterTrue == true)
                {
                    lblPasword.Text = "Strong Password";
                }
                else if (LetterTrue == true && NumberTrue == true || LetterTrue == true && SpecialCharacterTrue == true || NumberTrue == true && SpecialCharacterTrue == true)
                {
                    lblPasword.Text = "Medium Password";
                }
                else
                {
                    lblPasword.Text = "Weak Password";
                }
            }
        }

        public static bool IsValidEmail(string email)
        {

            Regex emailRegex = new Regex(@"^([\w.-]+)@([\w-]+)((.(\w){2,3})+)$", RegexOptions.IgnoreCase);
            return emailRegex.IsMatch(email);

        }
        #endregion

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblPasword.Visible = true;
            PasswordControl();
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            lblPasword.Visible = false;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (IsValidEmail(txtEmail.Text) == false)
            {
                DialogResult result = MessageBox.Show("Are you sure you entered the e-mail address correctly?", "E-Mail Check", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Abort)
                {
                    this.Close();
                }
                else if (result == DialogResult.Retry)
                {

                }
                else
                {

                }
            }
        }
    }
}