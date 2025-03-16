using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CleaningPro
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=cleaningpro;user=root;password=root;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // email availability check
                    string checkEmailQuery = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkEmailQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("This email is already registered. Please use another one.");
                            return;
                        }
                    }

                    // password validation
                    if (!IsValidPassword(txtPassword.Text))
                    {
                        MessageBox.Show("Password must be at least 12 characters long, contain at least one uppercase letter, and one special character.");
                        return;
                    }

                    // gender selection
                    string gender = GetSelectedGender();
                    if (string.IsNullOrEmpty(gender))
                    {
                        MessageBox.Show("Please select a gender.");
                        return;
                    }

                    // security question and answer
                    string securityQuestion = cmbSecQ.SelectedItem.ToString();
                    string securityAnswer = txtAnswer.Text.Trim();

                    if (string.IsNullOrEmpty(securityAnswer))
                    {
                        MessageBox.Show("Please provide an answer to the security question.");
                        return;
                    }

                    // salt generation and password hashing
                    string salt = GenerateSalt();
                    string hashedPassword = HashPassword(txtPassword.Text, salt);

                    // user registration query
                    string query = "INSERT INTO Users (Name, Email, Password, Salt, Phone, Gender, SecurityQuestion, SecurityAnswer) " +
                                   "VALUES (@Name, @Email, @Password, @Salt, @Phone, @Gender, @SecurityQuestion, @SecurityAnswer)";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Name", txtName.Text);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@Password", hashedPassword);
                        command.Parameters.AddWithValue("@Salt", salt);
                        command.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@SecurityQuestion", securityQuestion);
                        command.Parameters.AddWithValue("@SecurityAnswer", securityAnswer);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration successful. Redirecting to login...");

                            LoginForm loginForm = new LoginForm();
                            loginForm.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Registration failed. Please try again.");
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

        // Generate salt
        private string GenerateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
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

        // Password validation
        private bool IsValidPassword(string password)
        {
            return password.Length >= 12 &&
                   Regex.IsMatch(password, @"[A-Z]") &&
                   Regex.IsMatch(password, @"[!@#$%^&*(),.?""\:|<>]");
        }

        // Get selected gender
        private string GetSelectedGender()
        {
            foreach (Control control in grpBoxGender.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }
            return string.Empty;
        }

        // Cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
    }
}
