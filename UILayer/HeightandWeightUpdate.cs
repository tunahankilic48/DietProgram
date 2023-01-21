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
    public partial class HeightandWeightUpdate : Form
    {
        private WeightsAndHeights _weightsAndHeights;
        private frmMainPage _frm;
        DietContext context;
        ErrorProvider erpWeight, erpHeight;

        public HeightandWeightUpdate(WeightsAndHeights weightsAndHeights, frmMainPage frm)
        {
            InitializeComponent();
            _weightsAndHeights = weightsAndHeights;
            _frm = frm;
        }

        private void HeightandWeightUpdate_Load(object sender, EventArgs e)
        {
            context = new DietContext();
            erpWeight = new ErrorProvider();
            erpWeight = new ErrorProvider();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            decimal weight = 0;
            int height = 0;
            if (decimal.TryParse(txtWeight.Text, out weight) && int.TryParse(txtHeight.Text, out height) && !string.IsNullOrEmpty(txtWeight.Text) && !string.IsNullOrEmpty(txtHeight.Text) && weight > 0 && height > 0)
            {
                if (!(_weightsAndHeights.Weight == weight && _weightsAndHeights.Height == height))
                {
                    WeightsAndHeights weightsAndHeights = new WeightsAndHeights();
                    weightsAndHeights.Weight = weight;
                    weightsAndHeights.Height = height;
                    weightsAndHeights.UserId = _weightsAndHeights.UserId;
                    try
                    {
                        context.UsersWeightsAndHeights.Add(weightsAndHeights);
                        context.SaveChanges();
                        MessageBox.Show("Height and weight have updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _frm.Show();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Height and weight cannot be same with the current height and weight.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (weight <= 0)
                {
                    erpWeight.SetError(txtWeight, "Weight must be positive decimal");
                }
                else
                {
                    erpWeight.Clear();
                }
                if (height <= 0)
                {
                    erpHeight.SetError(txtHeight, "Height must bepositive integer");
                }
                else
                {
                    erpHeight.Clear();
                }
            }

        }
    }
}
