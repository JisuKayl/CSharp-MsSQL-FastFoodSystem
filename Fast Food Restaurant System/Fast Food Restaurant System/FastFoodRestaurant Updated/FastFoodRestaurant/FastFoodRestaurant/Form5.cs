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
    public partial class purchaseForm : Form
    {
        private decimal itemPrice;
        private UserControl5 userControl5Instance;

        public purchaseForm(string itemName, decimal itemPrice, UserControl5 userControl5Instance)
        {
            InitializeComponent();

            this.userControl5Instance = userControl5Instance;

            item_name.Text = itemName;
            this.itemPrice = itemPrice;
            item_price.Text = itemPrice.ToString("0.00");

            item_name.ReadOnly = true;
            item_price.ReadOnly = true;
        }

        private void item_quantity_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            try
            {
                int quantity = int.Parse(item_quantity.Text);
                decimal totalPrice = itemPrice * quantity;
                item_price.Text = totalPrice.ToString("0.00");
            }
            catch (FormatException)
            {
                item_price.Text = "Invalid Quantity";
            }
        }
        public purchaseForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = item_name.Text;
                decimal itemPrice = decimal.Parse(item_price.Text);

                if (!int.TryParse(item_quantity.Text, out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Please enter a valid numeric quantity greater than 0.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;  
                }

                decimal totalPrice = itemPrice * quantity;

                MessageBox.Show("Purchase order was successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (userControl5Instance != null)
                {
                    userControl5Instance.AddPurchaseHistoryRow(itemName, itemPrice, quantity, totalPrice);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing purchase: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void fullnameIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void delete1_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
