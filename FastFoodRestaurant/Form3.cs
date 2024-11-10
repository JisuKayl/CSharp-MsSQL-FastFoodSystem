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
    public partial class loginForm : Form
    {
        public string ReceivedUsername { get; set; }
        public string ReceivedPassword { get; set; }
        private int loginAttempts = 0;
        private string connectionString = "Data Source=DESKTOP-LR37DFI\\MSSQLSERVER01;Initial Catalog=FastFoodSystemDB;Integrated Security=True"; 
        public loginForm()
        {
            InitializeComponent();
        }

        private bool CheckLogin(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT FullName FROM Users WHERE Username = @username AND Password = @password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();
                        bool loginSuccessful = reader.HasRows;

                        connection.Close();

                        return loginSuccessful;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in CheckLogin: " + ex.Message); 
                return false;
            }
        }
  
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                passwordIn.UseSystemPasswordChar = false;
            }
            else
            {
                passwordIn.UseSystemPasswordChar = true;
            }
        }

        private void linkIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            registerForm register = new registerForm();
            register.Show();
        }

        private string GetFullName(string username)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT FullName FROM Users WHERE Username = @username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        connection.Open();
                        string fullName = command.ExecuteScalar().ToString();
                        connection.Close();
                        return fullName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in GetFullName: " + ex.Message);
                return "";
            }
        }
        private void login_btn_Click(object sender, EventArgs e)
        {
            string enteredUsername = usernameIn.Text;
            string enteredPassword = passwordIn.Text;

            if (loginAttempts < 3)
            {
                if (CheckLogin(enteredUsername, enteredPassword))
                {
                    loginAttempts = 0;
                    if (enteredUsername == "Admin")
                    {
                        this.Hide(); 
                        using (adminForm adminForm = new adminForm()) 
                        {
                            adminForm.ShowDialog();
                        }
                    }
                    else
                    {
                        this.Hide();
                        homeForm homeForm = new homeForm();
                        homeForm.displayName.Text = GetFullName(enteredUsername);
                        homeForm.Show();
                    }
                }
                else
                {
                    loginAttempts++;
                    if (loginAttempts >= 3)
                    {
                        MessageBox.Show("Too many attempts! Try again later.");
                        loginAttempts = 0;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials. Please try again.");
                    }
                }
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ReceivedUsername) && !string.IsNullOrEmpty(ReceivedPassword))
            {
                usernameIn.Text = ReceivedUsername;
                passwordIn.Text = ReceivedPassword;
            }
        }
    }
}
