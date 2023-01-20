using DataAccessLayer;
using EntityLayer;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Storage.Streams;
using Windows.Storage;
using Windows.UI.Xaml.Media.Imaging;




namespace UILayer
{
    public partial class frmNewAccount : Form
    {
        DietContext context;
        public frmNewAccount()
        {
            InitializeComponent();
        }

        private void frmNewAccount_Load(object sender, EventArgs e )
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

            newUser.AddressId = address.Id;
            address.UserId = newUser.Id;
            weightsAndHeights.AppUserId = newUser.Id;

            var image = new ImageConverter().ConvertTo(pictureBox1.Image, typeof(Byte[]));
            newUser.ProfilePhoto = (byte[])image;

            context.SaveChanges();
        }
        #endregion

        #region Methods
        #endregion

    }
}