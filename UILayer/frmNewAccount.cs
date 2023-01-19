using DataAccessLayer;
using EntityLayer;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmNewAccount : Form
    {
        DietContext context;
        public frmNewAccount()
        {
            InitializeComponent();
        }

        private void frmNewAccount_Load(object sender, EventArgs e)
        {
            context = new DietContext();

            cbbCity.ValueMember = "Id";
            cbbCity.DisplayMember = "Name";
            cbbCity.DataSource = context.Cities.ToList();

            cbbCountry.ValueMember = "Id";
            cbbCountry.DisplayMember = "Name";
            cbbCountry.DataSource = context.Countries.ToList();

        }

        #region Buttons


        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            AppUser newUser = new AppUser()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                BirtDate = dtpBirthDate.Value,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                IsMale = rdbMale.Checked,
                ModifiedDate = DateTime.Now,
                CreatedDate = DateTime.Now,
                IsActive = true
            };

            Address address = new Address();

            address.CityId = (int)cbbCity.SelectedValue;
            address.ModifiedDate = DateTime.Now;
            address.CreatedDate = DateTime.Now;

            WeightsAndHeights weightsAndHeights = new WeightsAndHeights();

            weightsAndHeights.Weight = decimal.Parse(txtWeight.Text);
            weightsAndHeights.Height = int.Parse(txtHeight.Text);
            weightsAndHeights.ModifiedDate = DateTime.Now;
            weightsAndHeights.CreatedDate = DateTime.Now;


            context.AppUsers.Add(newUser);
            context.Addresses.Add(address);
            context.UsersWeightsAndHeights.Add(weightsAndHeights);
            context.SaveChanges();

            MessageBox.Show("Aşama 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            newUser.AddressId = address.Id;
            address.UserId= newUser.Id;
            weightsAndHeights.AppUserId = newUser.Id;

            context.SaveChanges();


            MessageBox.Show("Aşama2", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // newUser.Address.Country = cbbCountry -- Bir adressin 1 citysi ve bir ulkesi olur seklinde duzeltilecek


        }
        #endregion

        #region Methots
        private bool IsPasswordsSame()
        {
            return (txtPassword.Text == txtPasswordAgain.Text); //buraya password kosullari eklenebilir

        }

        private bool areRequiredDetailsFilled()
        {
            bool result = true;
            if ((rdbFemale.Checked == false) && (rdbMale.Checked == false))
            {
                result = false;
            }
            foreach (var item in grpCreateNewAccount.Controls)
            {
                if (item is TextBox)
                {
                    result = !(((TextBox)item).Text == null);
                }
                if (item is ComboBox)
                {
                    result = !(((ComboBox)item).Text == null);
                }
                //picture tarafi da eklenecek
            }
            return result;
        }
        #endregion

    }
}
