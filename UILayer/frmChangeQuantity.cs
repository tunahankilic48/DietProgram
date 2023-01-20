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
    public partial class frmChangeQuantity : Form
    {
        private frmMeal _frm;

        public frmChangeQuantity(frmMeal frm)
        {
            InitializeComponent();
            _frm = frm;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (nudQuantity.Value > 0)
            {
                _frm.newQuantity = (int)nudQuantity.Value;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select quantity as an positive integer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
