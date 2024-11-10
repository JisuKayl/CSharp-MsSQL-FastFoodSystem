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
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
            sidepanel.Height = home_btn.Height;
            sidepanel.Top = home_btn.Top;
            label1.BringToFront();
            label2.BringToFront();
            panel3.BringToFront();
            userControl21.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            sidepanel.Height = home_btn.Height;
            sidepanel.Top = home_btn.Top;
            ord.Show();
            userControl11.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl21.Show();
            userControl21.BringToFront();
            label1.BringToFront();
            label2.BringToFront();
            panel2.BringToFront();
            panel3.BringToFront();
            ord.BringToFront();
        }

        private void eat_btn_Click(object sender, EventArgs e)
        {
            sidepanel.Height = meal_btn.Height;
            sidepanel.Top = meal_btn.Top;
            ord.Show();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl11.Show();
            userControl11.BringToFront();
            label1.BringToFront();
            label2.BringToFront();
            panel2.BringToFront();
            panel3.BringToFront();
            ord.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void collection_btn_Click(object sender, EventArgs e)
        {
            sidepanel.Height = drinks_btn.Height;
            sidepanel.Top = drinks_btn.Top;
            ord.Show();
            userControl11.Hide();
            userControl21.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl31.Show();
            userControl31.BringToFront();
            label1.BringToFront();
            label2.BringToFront();
            panel2.BringToFront();
            panel3.BringToFront();
            ord.BringToFront();
        }

        private void Driver_btn_Click(object sender, EventArgs e)
        {
            sidepanel.Height = item_btn.Height;
            sidepanel.Top = item_btn.Top;
            ord.Hide();
            userControl11.Hide();
            userControl31.Hide();
            userControl21.Hide();
            userControl51.Hide();
            userControl41.Show();
            userControl41.BringToFront();
            label1.BringToFront();
            label2.BringToFront();
            panel2.BringToFront();
            panel3.BringToFront();
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            sidepanel.Height = order_btn.Height;
            sidepanel.Top = order_btn.Top;
            ord.Hide();
            userControl11.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl21.Hide();
            userControl51.Show();
            userControl51.BringToFront();
            label1.BringToFront();
            label2.BringToFront();
            panel2.BringToFront();
            panel3.BringToFront();
        }

        private void userControl31_Load(object sender, EventArgs e)
        {

        }

        private void userControl41_Load(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerForm registerForm = new registerForm();
            registerForm.Show();
        }

        private void ord_Click(object sender, EventArgs e)
        {
            sidepanel.Height = item_btn.Height;
            sidepanel.Top = item_btn.Top;
            ord.Hide();
            userControl11.Hide();
            userControl31.Hide();
            userControl21.Hide();
            userControl51.Hide();
            userControl41.Show();
            userControl41.BringToFront();
            label1.BringToFront();
            label2.BringToFront();
            panel2.BringToFront();
            panel3.BringToFront();
        }
    }
}
