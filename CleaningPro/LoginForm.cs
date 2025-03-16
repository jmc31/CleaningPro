using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CleaningPro
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=cleaningpro;user=root;password=root;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // salt and hash retrieval
                    string query = "SELECT Password, Salt FROM Users WHERE Email = @Email";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHashedPassword = reader["Password"].ToString();
                                string storedSalt = reader["Salt"].ToString();

                                // Hash the entered password with the stored salt
                                string enteredHashedPassword = HashPassword(txtPassword.Text, storedSalt);

                                if (enteredHashedPassword == storedHashedPassword)
                                {
                                    MessageBox.Show("Login successful!");

                                    HomePage homepageForm = new HomePage();
                                    homepageForm.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid email or password.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password.");
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        // Hash password with salt
        private string HashPassword(string password, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] combinedBytes = Encoding.UTF8.GetBytes(password + salt);
                byte[] hashBytes = sha256.ComputeHash(combinedBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }

        // Cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Redirect to MainForm
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPasswordForm = new ForgotPassword();
            forgotPasswordForm.Show();
            this.Hide();
        }
    }
}