using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FastFoodRestaurant
{
    public partial class UserControl4 : UserControl
    {
        private UserControl5 userControl5Instance;
        private SqlDataAdapter menuItemsAdapter;
        private DataTable menuItemsTable;

        public UserControl4(UserControl5 userControl5)
        {
            InitializeComponent();
            userControl5Instance = userControl5;

            menuItemsAdapter = new SqlDataAdapter();
            menuItemsTable = new DataTable();

            LoadMenuItems();
        }

        public void LoadMenuItems()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-LR37DFI\\MSSQLSERVER01;Initial Catalog=FastFoodSystemDB;Integrated Security=True;"))
                {
                    sqlConnection.Open();
                    string query = "SELECT * FROM dbo.MenuItems";

                    menuItemsAdapter.SelectCommand = new SqlCommand(query, sqlConnection);
                    menuItemsAdapter.Fill(menuItemsTable);

                    itemList1.DataSource = menuItemsTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading menu items: " + ex.Message);
            }
        }

        private decimal GetItemPrice(string itemName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-LR37DFI\\MSSQLSERVER01;Initial Catalog=FastFoodSystemDB;Integrated Security=True;"))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT Price FROM MenuItems WHERE ItemName = @itemName", connection);
                    command.Parameters.AddWithValue("@itemName", itemName);

                    object result = command.ExecuteScalar();

                    if (result != null && decimal.TryParse(result.ToString(), out decimal itemPrice))
                    {
                        return itemPrice;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting item price: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0.0M;
        }


        private void buy1_btn_Click(object sender, EventArgs e)
        {
            string itemName = itemSearch.Text;
            decimal itemPrice = GetItemPrice(itemName);

            purchaseForm purchaseForm = new purchaseForm(itemName, itemPrice, this.userControl5Instance);
            purchaseForm.ShowDialog();
        }

        private void SearchItems(string itemName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-LR37DFI\\MSSQLSERVER01;Initial Catalog=FastFoodSystemDB;Integrated Security=True;"))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM MenuItems WHERE ItemName LIKE @itemName", connection);
                    command.Parameters.AddWithValue("@itemName", "%" + itemName + "%");

                    SqlDataReader reader = command.ExecuteReader();
                    DataTable searchResult = new DataTable();
                    searchResult.Load(reader);

                    itemList1.DataSource = searchResult;

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = itemSearch.Text;

                SearchItems(itemName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGridView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-LR37DFI\\MSSQLSERVER01;Initial Catalog=FastFoodSystemDB;Integrated Security=True;"))
                {
                    connection.Open();

                    string query = "SELECT ProductID, ItemName, Price FROM MenuItems";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable refreshedData = new DataTable();
                        adapter.Fill(refreshedData);

                        itemList1.DataSource = refreshedData;
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refresh1_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshDataGridView();
                itemSearch.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void itemList1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void fullnameIn_TextChanged(object sender, EventArgs e)
        {
           
        }

    }
}
