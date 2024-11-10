using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodRestaurant
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void drink1_Click(object sender, EventArgs e)
        {
            purchaseForm purchaseForm = new purchaseForm();
            purchaseForm.Show();
        }

        private void drink2_Click(object sender, EventArgs e)
        {
            purchaseForm purchaseForm = new purchaseForm();
            purchaseForm.Show();
        }

        private void drink3_Click(object sender, EventArgs e)
        {
            purchaseForm purchaseForm = new purchaseForm();
            purchaseForm.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
