using System;
using System.Windows.Forms;

namespace CleaningPro
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            // Confirm logout
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // direct to loginform
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                this.Close(); // Close HomePage
            }
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Home Page Clicked.");
        }

        private void lblBookNow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Book Now Clicked.");
        }

        private void lblAboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("About Us Clicked.");
        }

        private void lblContactUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact Us Clicked.");
        }

        private void lblServices_Click(object sender, EventArgs e)
        {

        }
    }
}
