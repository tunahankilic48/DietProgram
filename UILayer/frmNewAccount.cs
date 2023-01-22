using DataAccessLayer;
using EntityLayer;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;

namespace UILayer
{
    public partial class frmNewAccount : Form
    {
        DietContext context;
        private frmLoginPanel _frm;
        string password, capitalCase, lowerCase, numbers, specialCharacters;
        bool capitalCaseTrue, lowerCaseTrue, numberTrue, specialCharacterTrue;
        ErrorProvider erpFirstName, erpMiddleName, erpLastName, erpEmail, erpPassword, erpPasswordAgain, erpHeight, erpWeight;
        public frmNewAccount(frmLoginPanel frm)
        {
            InitializeComponent();
            _frm = frm;
        }
        private void frmNewAccount_Load(object sender, EventArgs e)
        {
            context = new DietContext();


            password = "";
            capitalCase = "QWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇ";
            lowerCase = "qwertyuıopğüasdfghjklşizxcvbnmöç";
            numbers = "1234567890";
            specialCharacters = "!'^+%&/()=?_>£#$½{[]}<.:@€₺i¨~æß´`;,";

            capitalCaseTrue = false;
            lowerCaseTrue = false;
            numberTrue = false;
            specialCharacterTrue = false;
            
            erpFirstName = new ErrorProvider();
            erpMiddleName = new ErrorProvider();
            erpLastName = new ErrorProvider();
            erpEmail = new ErrorProvider();
            erpPassword = new ErrorProvider();
            erpPasswordAgain = new ErrorProvider();
            erpHeight = new ErrorProvider();
            erpWeight = new ErrorProvider();

            cbbCity.ValueMember = "Id";
            cbbCity.DisplayMember = "Name";
            cbbCity.DataSource = context.Cities.ToList();
            cbbCity.SelectedIndex = -1;

            cbbCountry.ValueMember = "Id";
            cbbCountry.DisplayMember = "Name";
            cbbCountry.DataSource = context.Countries.ToList();
            cbbCountry.SelectedIndex = -1;

            dtpBirthDate.MaxDate = DateTime.Now;
            dtpBirthDate.Value = DateTime.Now.Date;

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
            AppUser? user = context.AppUsers.Where(x => x.Email == txtEmail.Text).FirstOrDefault();


            if (string.IsNullOrEmpty(erpFirstName.GetError(txtFirstName)) && string.IsNullOrEmpty(erpMiddleName.GetError(txtMiddleName)) && string.IsNullOrEmpty(erpLastName.GetError(txtLastName)) && string.IsNullOrEmpty(erpEmail.GetError(txtEmail)) && string.IsNullOrEmpty(erpPassword.GetError(txtPassword)) && string.IsNullOrEmpty(erpPasswordAgain.GetError(txtPasswordAgain)) && string.IsNullOrEmpty(erpHeight.GetError(txtHeight)) && string.IsNullOrEmpty(erpWeight.GetError(txtWeight)) && (rdbMale.Checked || rdbFemale.Checked) && cbbCity.SelectedIndex != -1 && cbbCountry.SelectedIndex != -1 && user == null && !(string.IsNullOrEmpty(txtFirstName.Text.Trim()) || string.IsNullOrEmpty(txtLastName.Text.Trim()) || string.IsNullOrEmpty(txtEmail.Text.Trim()) || string.IsNullOrEmpty(txtPassword.Text.Trim()) || string.IsNullOrEmpty(txtPasswordAgain.Text.Trim()) || string.IsNullOrEmpty(txtHeight.Text.Trim()) || string.IsNullOrEmpty(txtWeight.Text.Trim())))
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
                try
                {
                    context.SaveChanges();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                newUser.AddressId = address.Id;
                address.UserId = newUser.Id;
                weightsAndHeights.UserId = newUser.Id;

                var image = new ImageConverter().ConvertTo(pictureBox1.Image, typeof(Byte[]));
                newUser.ProfilePhoto = (byte[])image;

                Random rnd = new Random();

                string from, userMail, password, messageBody, verificationCode;

                verificationCode = rnd.Next(100000, 1000000).ToString();

                MailMessage message = new MailMessage();

                from = "dietchecker3@gmail.com";
                message.From = new MailAddress(from);
                message.Subject = "Password Reset Code";
                password = "kyfntyomzlhyflol";
                messageBody = "Your confirmation code is " + verificationCode;

                userMail = txtEmail.Text;
                message.To.Add(userMail);
                message.Body = messageBody;

                // Auto Mail for verificaiton code

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Credentials = new NetworkCredential(from, password);
                smtpClient.EnableSsl = true;
                try
                {
                    smtpClient.Send(message);
                    MessageBox.Show("Confirmation code was send to your E-mail address.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmNewAccountConfirmation frm = new frmNewAccountConfirmation(verificationCode);
                    frm.ShowDialog();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                try
                {
                    context.SaveChanges();
                    MessageBox.Show("New account created successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _frm.Show();
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtFirstName.Text.Trim()) || string.IsNullOrEmpty(txtLastName.Text.Trim()) || string.IsNullOrEmpty(txtEmail.Text.Trim()) || string.IsNullOrEmpty(txtPassword.Text.Trim()) || string.IsNullOrEmpty(txtPasswordAgain.Text.Trim()) || string.IsNullOrEmpty(txtHeight.Text.Trim()) || string.IsNullOrEmpty(txtWeight.Text.Trim()))
                {
                    MessageBox.Show("First name, last name, email, password, height and weight cannot be null", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!(rdbMale.Checked || rdbFemale.Checked))
                {
                    MessageBox.Show("Gender must select.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cbbCity.SelectedIndex == -1 || cbbCountry.SelectedIndex == -1)
                {
                    MessageBox.Show("Country and city cannot be null.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (user != null)
                {
                    MessageBox.Show("Email address has already used.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Please check the errors and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
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
                    if (capitalCase.IndexOf(item) != -1)
                    {
                        capitalCaseTrue = true;
                    }
                    if (lowerCase.IndexOf(item) != -1)
                    {
                        lowerCaseTrue = true;
                    }
                    if (numbers.IndexOf(item) != -1)
                    {
                        numberTrue = true;
                    }
                    if (specialCharacters.IndexOf(item) != -1)
                    {
                        specialCharacterTrue = true;
                    }
                }
                if (capitalCaseTrue == true && lowerCaseTrue == true && numberTrue == true && specialCharacterTrue == true)
                {
                    lblPasword.Text = "Strong Password";
                }
                else if ((capitalCaseTrue == true && lowerCaseTrue == true && numberTrue == true) || (lowerCaseTrue == true && numberTrue == true && specialCharacterTrue == true) || (capitalCaseTrue == true && numberTrue == true && specialCharacterTrue == true) || (capitalCaseTrue == true && lowerCaseTrue == true && specialCharacterTrue == true))
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

        #region TextChanged
        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Length > 20 || string.IsNullOrEmpty(txtFirstName.Text.Trim()))
            {
                erpFirstName.SetError(txtFirstName, "First Name cannot be empty or the length more than 20 characters.");
            }
            else
            {
                erpFirstName.Clear();
            }
        }
        private void txtMiddleName_TextChanged(object sender, EventArgs e)
        {
            if (txtMiddleName.Text.Length > 20)
            {
                erpMiddleName.SetError(txtMiddleName, "Middle Name cannot more than 20 characters.");
            }
            else
            {
                erpMiddleName.Clear();
            }
        }
        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtLastName.Text.Length > 20)
            {
                erpLastName.SetError(txtLastName, "First Name cannot be empty or the length more than 30 characters.");
            }
            else
            {
                erpLastName.Clear();
            }
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtEmail.Text))
            {
                erpEmail.SetError(txtEmail, "Entered E-mail address not in proper format.");
            }
            else
            {
                erpEmail.Clear();
            }

        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblPasword.Visible = true;
            capitalCaseTrue = false;
            lowerCaseTrue = false;
            specialCharacterTrue = false;
            numberTrue = false;
            PasswordControl();
            if (lblPasword.Text != "Strong Password")
            {
                erpPassword.SetError(txtPassword, "Password must contain a capital case, lower case, number and special character and it must be longer than 6 characters");
            }
            else
            {
                erpPassword.Clear();
            }
            if (txtPasswordAgain.Text.Length != 0)
            {
                if (txtPassword.Text != txtPasswordAgain.Text)
                {
                    erpPasswordAgain.SetError(txtPasswordAgain, "Passwords do not match.");
                }
                else
                {
                    erpPasswordAgain.Clear();
                }
            }

        }
        private void txtPasswordAgain_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPasswordAgain.Text)
            {
                erpPasswordAgain.SetError(txtPasswordAgain, "Passwords do not match.");
            }
            else
            {
                erpPasswordAgain.Clear();
            }
        }
        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            int height = 0;
            if (!(int.TryParse(txtHeight.Text, out height) && height > 0))
            {
                erpHeight.SetError(txtHeight, "Height must be positive integer.");
            }
            else
            {
                erpHeight.Clear();
            }
        }
        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            decimal weight = 0;
            if (!(decimal.TryParse(txtWeight.Text, out weight) && weight > 0))
            {
                erpWeight.SetError(txtWeight, "weight must be positive integer.");
            }
            else
            {
                erpWeight.Clear();
            }
        }
        #endregion

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            lblPasword.Visible = false;
        }
        private void cbbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCountry.SelectedIndex != -1)
            {
                var cities = context.Cities.Where(x => x.CountryId == (int)cbbCountry.SelectedValue);
                cbbCity.ValueMember = "Id";
                cbbCity.DisplayMember = "Name";
                cbbCity.DataSource = cities.ToList();
                cbbCity.SelectedIndex = -1;
            }
        }

    }
}