using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace FastFoodRestaurant
{
    public partial class adminForm : Form
    {
        string connectionString = "Data Source=DESKTOP-LR37DFI\\MSSQLSERVER01;Initial Catalog=FastFoodSystemDB;Integrated Security=True";
        DataTable dt = new DataTable();
        public adminForm()
        {
            InitializeComponent();
            sidepanel.Height = home_btn.Height;
            sidepanel.Top = home_btn.Top;
        }

        private DataTable GetMenuItems()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT ProductID, ItemName, Price FROM MenuItems";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving MenuItems: " + ex.Message);
            }

            return dt;
        }

        private void InsertItem(int productID, string itemName, decimal price)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("INSERT INTO MenuItems (ProductID, ItemName, Price) VALUES (@productID, @itemName, @price)", connection);
                    command.Parameters.AddWithValue("@productID", productID);
                    command.Parameters.AddWithValue("@itemName", itemName);
                    command.Parameters.AddWithValue("@price", price);
                    command.ExecuteNonQuery();

                    connection.Close();
                }

                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateItem(int productID, string itemName, decimal price)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("UPDATE MenuItems SET ItemName = @itemName, Price = @price WHERE ProductID = @productID", connection);
                    command.Parameters.AddWithValue("@itemName", itemName);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@productID", productID);
                    command.ExecuteNonQuery();

                    connection.Close();
                }

                RefreshDataGridView(); 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating item: " + ex.Message);
            }
        }


        private void SearchItem(int productID, string itemName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command;

                    if (productID > 0)
                    {
                        command = new SqlCommand("SELECT * FROM MenuItems WHERE ProductID = @productID", connection);
                        command.Parameters.AddWithValue("@productID", productID);
                    }
                    else if (!string.IsNullOrEmpty(itemName))
                    {
                        command = new SqlCommand("SELECT * FROM MenuItems WHERE ItemName = @itemName", connection);
                        command.Parameters.AddWithValue("@itemName", itemName);
                    }
                    else
                    {
                        dt = GetMenuItems();
                        itemList.DataSource = dt; 
                        connection.Close();
                        return;
                    }

                    SqlDataReader reader = command.ExecuteReader();
                    DataTable searchResult = new DataTable();
                    searchResult.Load(reader);

                    itemList.DataSource = searchResult; 

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteItem(int productID, string itemName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command;

                    if (productID > 0)
                    {
                        command = new SqlCommand("DELETE FROM MenuItems WHERE ProductID = @productID", connection);
                        command.Parameters.AddWithValue("@productID", productID);
                    }
                    else if (!string.IsNullOrEmpty(itemName))
                    {
                        command = new SqlCommand("DELETE FROM MenuItems WHERE ItemName = @itemName", connection);
                        command.Parameters.AddWithValue("@itemName", itemName);
                    }
                    else
                    {
                        return;
                    }

                    command.ExecuteNonQuery();

                    connection.Close();
                }

                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting item: " + ex.Message);
            }
        }


        private void home_btn_Click(object sender, EventArgs e)
        {
            sidepanel.Height = home_btn.Height;
            sidepanel.Top = home_btn.Top;
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerForm registerForm = new registerForm();
            registerForm.Show();
        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            DataTable menuItemsData = GetMenuItems();
            itemList.DataSource = menuItemsData;
        }

        private void fullnameIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void itemList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            itemList.AutoGenerateColumns = true;
        }

        private void fullnameIn_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void insert_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(prodID.Text, out int productId))
                {
                    string itemName = prodItem.Text;
                    decimal price = decimal.Parse(prodPrice.Text);

                    InsertItem(productId, itemName, price);
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric value for Product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric value for Price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void update_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                int productId = int.Parse(prodID.Text);
                string itemName = prodItem.Text;
                decimal price = decimal.Parse(prodPrice.Text);

                UpdateItem(productId, itemName, price);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for Product ID and Price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                int productId = int.Parse(prodID.Text);
                string itemName = prodItem.Text;

                DialogResult result = MessageBox.Show("Are you sure to delete it? This action can't be undone.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteItem(productId, itemName);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric value for Product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void search_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                int productId = 0;
                string itemName = null;

                if (!string.IsNullOrEmpty(prodID.Text))
                {
                    productId = int.Parse(prodID.Text);
                }

                if (!string.IsNullOrEmpty(prodItem.Text))
                {
                    itemName = prodItem.Text;
                }

                SearchItem(productId, itemName);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric value for Product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefreshDataGridView()
        {
            DataTable refreshedData = GetMenuItems();
            itemList.DataSource = refreshedData;
        }
        private void refresh_btn_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
    }
}