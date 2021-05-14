using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab__04
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?",
        "Припинити роботу", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void btnAddBike_Click(object sender, EventArgs e)
        {
            Bike bike = new Bike();
            fBike ft = new fBike(bike);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                tbBikeInfo.Text +=
  string.Format("{0}, {1}, {2}. Ціна, грн: {3}. Вага:{4:0.00} Г. Довжина: {5:0.000} См. [{6} | {7}] | Вартість одного Г: {8:0.00}грн\r\n",
  bike.Brand, bike.Country, bike.Region,
bike.Price, bike.Weight, bike.Lenghth,
bike.HasHydraulicBrake ? "Є гідравлічні гальма" : "Немає гідравлічних гальм",
bike.HasHydraulicSeatPost ? "Є гідравлічний підсидільний штир" : "Немає гідравлічного підсидільного штиря",
bike.GetYearIncomePerInhabitant());

            }
        }
    }
}
