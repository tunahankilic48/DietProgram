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
    public partial class frmNewAccountConfirmation : Form
    {
        private string _confirmationCode;

        public frmNewAccountConfirmation(string confirmationCode)
        {
            InitializeComponent();
            _confirmationCode = confirmationCode;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if(txtConfirmationCode.Text == _confirmationCode)
            {
                MessageBox.Show("Confirmation code is correct.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Confirmation code is not correct.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
