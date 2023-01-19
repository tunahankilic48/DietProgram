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
        }

        #region Buttons


        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            if (areRequiredDetailsFilled() && IsPasswordsSame())
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
                };


                context.AppUsers.Add(newUser);
                context.SaveChanges();

                Address adres= new Address
                {

                    AppUser = newUser,
                    UserId = newUser.Id

                };

                

                newUser.WeightsAndHeights.Add(new WeightsAndHeights
                {
                    Height = Convert.ToInt32(txtHeight.Text),
                    Weight = Convert.ToDecimal(txtWeight.Text),
                    AppUserId = newUser.Id,
                    ModifiedDate= DateTime.Now,
                    CreatedDate = DateTime.Now,


                });



                // newUser.Address.Country = cbbCountry -- Bir adressin 1 citysi ve bir ulkesi olur seklinde duzeltilecek





                newUser.BirtDate = dtpBirthDate.Value;
                context.AppUsers.Add(newUser);
                context.SaveChanges();
                MessageBox.Show("New User was created.");
            }
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
