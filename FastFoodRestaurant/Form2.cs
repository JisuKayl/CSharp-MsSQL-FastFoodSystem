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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FastFoodRestaurant
{
    public partial class registerForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-LR37DFI\\MSSQLSERVER01;Initial Catalog=FastFoodSystemDB;Integrated Security=True";

        public registerForm()
        {
            InitializeComponent();
        }

        private bool SignUpUser(string fullName, string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Users (FullName, Username, Password) VALUES (@fullName, @username, @password)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@fullName", fullName);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        return true; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sign-up failed: " + ex.Message);
                return false; 
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string fullName = fullnameUp.Text;
            string username = userUp.Text;
            string password = passwordUp.Text;

            if (SignUpUser(fullName, username, password))
            {
                MessageBox.Show("Sign-up successful!");
                loginForm login = new loginForm();
                login.ReceivedUsername = username; 
                this.Hide(); 
                login.Show(); 
            }
            else
            {
                MessageBox.Show("Failed to sign up. Please try again.");
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            loginForm login = new loginForm();
            login.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) 
            {
                passwordUp.UseSystemPasswordChar = false;
            }
            else
            {
                passwordUp.UseSystemPasswordChar = true;
            }
        }
    }
}
