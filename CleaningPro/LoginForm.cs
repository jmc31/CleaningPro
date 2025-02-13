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
        //login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=cleaningpro;user=root;password=root;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1) FROM Users WHERE Email = @Email AND Password = @Password";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);
                    command.Parameters.AddWithValue("@Password", HashPassword(txtPassword.Text));

                    try
                    {
                        conn.Open();
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count == 1)
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
        }
        //pass hash
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
        //btn cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Redirect to MainForm
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
    }
}
