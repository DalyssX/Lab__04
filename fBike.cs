using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab__04
{
    public partial class fBike : Form
    {
        public Bike TheBike;
        public fBike(Bike t)
        {

            TheBike = t;
            InitializeComponent();
        }
       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void fBike_Load(object sender, EventArgs e)
        {
            if (TheBike != null)
            {
                tbBrand.Text = TheBike.Brand;
                tbCountry.Text = TheBike.Country;
                tbRegion.Text = TheBike.Region;
                tbPrice.Text = TheBike.Price.ToString();
                tbWeight.Text = TheBike.Weight.ToString("0.00");
                tbLenghth.Text = TheBike.Lenghth.ToString("0.000");
                chbHasHydraulicBrake.Checked = TheBike.HasHydraulicBrake;
                chbHasHydraulicSeatPost.Checked = TheBike.HasHydraulicSeatPost;
            }
        }

        private void btnOk_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbLenghth_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            TheBike.Brand = tbBrand.Text.Trim();
            TheBike.Country = tbCountry.Text.Trim();
            TheBike.Region = tbRegion.Text.Trim();
            TheBike.Price = int.Parse(tbPrice.Text.Trim());
            TheBike.Weight = double.Parse(tbWeight.Text.Trim());
            TheBike.Lenghth = double.Parse(tbLenghth.Text.Trim());
            TheBike.HasHydraulicBrake = chbHasHydraulicBrake.Checked;
            TheBike.HasHydraulicSeatPost = chbHasHydraulicSeatPost.Checked;
            DialogResult = DialogResult.OK;
        }

        //private void chbHasHydraulicBrake(object sender, EventArgs e)
        //{

        //}

        private void chbHasHydraulicSeatPost_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbHasHydraulicBrake_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
