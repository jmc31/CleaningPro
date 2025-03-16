using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CleaningPro
{
    public partial class ForgotPassword : Form
    {
        private string generatedOtp;
        private string userEmail; // Store email for OTP validation

        public ForgotPassword()
        {
            InitializeComponent();
        }

        // Generate OTP and show in a MessageBox
        private void btnSendOtp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtNewPassword.Text) || string.IsNullOrEmpty(cmbSecQ.Text) || string.IsNullOrEmpty(txtAnswer.Text))
            {
                MessageBox.Show("Please enter your email, new password, security question, and answer.", "Input Error");
                return;
            }

            if (!IsEmailRegistered(txtEmail.Text))
            {
                MessageBox.Show("This email is not registered.", "Error");
                return;
            }

            // Verify the security question answer
            if (!IsAnswerCorrect(txtEmail.Text, cmbSecQ.SelectedItem.ToString(), txtAnswer.Text))
            {
                MessageBox.Show("Incorrect answer to the security question.", "Error");
                return;
            }

            // Generate OTP
            Random random = new Random();
            generatedOtp = random.Next(100000, 999999).ToString(); // 6-digit OTP
            userEmail = txtEmail.Text; // Store email for verification

            MessageBox.Show($"Your OTP is: {generatedOtp}", "OTP Verification");
        }

        // Confirm OTP and update password
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOtp.Text))
            {
                MessageBox.Show("Please enter the OTP.", "Error");
                return;
            }

            if (txtOtp.Text == generatedOtp && txtEmail.Text == userEmail)
            {
                if (IsValidPassword(txtNewPassword.Text))
                {
                    UpdatePassword(txtEmail.Text, txtNewPassword.Text);
                }
                else
                {
                    MessageBox.Show("Password must be at least 12 characters long, contain at least one uppercase letter, and one special character.", "Weak Password");
                }
            }
            else
            {
                MessageBox.Show("Incorrect OTP or email does not match. Please try again.", "Invalid OTP");
            }
        }

        // Check if email exists in the database
        private bool IsEmailRegistered(string email)
        {
            string connectionString = "server=localhost;port=3306;database=cleaningpro;user=root;password=root;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        // Check if the provided answer matches the stored answer in the database
        private bool IsAnswerCorrect(string email, string securityQuestion, string answer)
        {
            string connectionString = "server=localhost;port=3306;database=cleaningpro;user=root;password=root;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT SecurityAnswer FROM Users WHERE Email = @Email AND SecurityQuestion = @SecurityQuestion";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@SecurityQuestion", securityQuestion);

                    string storedAnswer = Convert.ToString(cmd.ExecuteScalar());
                    return storedAnswer != null && storedAnswer.Equals(answer, StringComparison.OrdinalIgnoreCase);
                }
            }
        }

        // Update password in the database with a new salt
        private void UpdatePassword(string email, string newPassword)
        {
            string connectionString = "server=localhost;port=3306;database=cleaningpro;user=root;password=root;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Generate new salt
                    string newSalt = GenerateSalt();
                    string hashedPassword = HashPassword(newPassword, newSalt);

                    string query = "UPDATE Users SET Password = @Password, Salt = @Salt WHERE Email = @Email";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Password", hashedPassword);
                        command.Parameters.AddWithValue("@Salt", newSalt);
                        command.Parameters.AddWithValue("@Email", email);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password reset successful. Redirecting to login...", "Success");

                            // Redirect to LoginForm
                            LoginForm loginForm = new LoginForm();
                            loginForm.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Password reset failed. Please try again.", "Error");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Database Error");
                }
            }
        }

        // Generate a new salt
        private string GenerateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
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

        // Validate password strength
        private bool IsValidPassword(string password)
        {
            return password.Length >= 12 &&
                   Regex.IsMatch(password, @"[A-Z]") &&
                   Regex.IsMatch(password, @"[!@#$%^&*(),.?""\:|<>]");
        }
    }
}
