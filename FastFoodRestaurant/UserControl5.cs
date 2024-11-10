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

namespace FastFoodRestaurant
{
    public partial class UserControl5 : UserControl
    {

        public void AddPurchaseHistoryRow(string itemName, decimal itemPrice, int quantity, decimal totalPrice)
        {
            try
            {
                DataRow newRow = purchaseHistoryTable.NewRow();
                newRow["ItemName"] = itemName;
                newRow["Price"] = itemPrice;
                newRow["Quantity"] = quantity;
                newRow["TotalPrice"] = totalPrice;

                purchaseHistoryTable.Rows.Add(newRow);

                using (SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-LR37DFI\\MSSQLSERVER01;Initial Catalog=FastFoodSystemDB;Integrated Security=True"))
                {
                    sqlConnection.Open();

                    string query = @"INSERT INTO PurchaseHistory (ItemName, Price, Quantity, TotalPrice)
                             OUTPUT inserted.ID
                             VALUES (@ItemName, @Price, @Quantity, @TotalPrice)";

                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@ItemName", itemName);
                        sqlCommand.Parameters.AddWithValue("@Price", itemPrice);
                        sqlCommand.Parameters.AddWithValue("@Quantity", quantity);
                        sqlCommand.Parameters.AddWithValue("@TotalPrice", totalPrice);

                        int generatedID = (int)sqlCommand.ExecuteScalar();

                        newRow["ID"] = generatedID;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error adding purchase history row: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding purchase history row: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private SqlDataAdapter purchaseHistoryAdapter;
        private DataTable purchaseHistoryTable;
        public UserControl5()
        {
            InitializeComponent();

            print_btn.Click += print_btn_Click;
            purchaseHistoryAdapter = new SqlDataAdapter();
            purchaseHistoryTable = new DataTable();

            LoadPurchaseHistory();
        }

        private void LoadPurchaseHistory()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-LR37DFI\\MSSQLSERVER01;Initial Catalog=FastFoodSystemDB;Integrated Security=True"))
                {
                    sqlConnection.Open();

                    string query = "SELECT ID, ItemName, Price, Quantity, TotalPrice FROM PurchaseHistory";

                    purchaseHistoryAdapter.SelectCommand = new SqlCommand(query, sqlConnection);
                    purchaseHistoryTable.Clear();

                    purchaseHistoryAdapter.Fill(purchaseHistoryTable);

                    if (!purchaseHistoryTable.Columns.Contains("ID"))
                    {
                        purchaseHistoryTable.Columns.Add("ID", typeof(int));
                    }

                    orderHistory.DataSource = purchaseHistoryTable;

                    orderHistory.Columns["ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading purchase history: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fullnameIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {

        }

        private void delete1_btn_Click(object sender, EventArgs e)
        {

        }

        private void orderHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refresh1_Click(object sender, EventArgs e)
        {
            LoadPurchaseHistory();
        }

        private void del_his_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Are you sure you want to delete the purchase history?\nThis action cannot be undone.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-LR37DFI\\MSSQLSERVER01;Initial Catalog=FastFoodSystemDB;Integrated Security=True"))
                    {
                        sqlConnection.Open();

                        string deleteQuery = "DELETE FROM PurchaseHistory";
                        using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection))
                        {
                            deleteCommand.ExecuteNonQuery();
                        }

                        string resetIdentityQuery = "DBCC CHECKIDENT ('PurchaseHistory', RESEED, 0)";
                        using (SqlCommand resetIdentityCommand = new SqlCommand(resetIdentityQuery, sqlConnection))
                        {
                            resetIdentityCommand.ExecuteNonQuery();
                        }

                        sqlConnection.Close();
                    }

                    MessageBox.Show("Purchase history deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPurchaseHistory();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting purchase history: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            PdfPrinter.PrintToPdf(orderHistory);
        }
    }
}
