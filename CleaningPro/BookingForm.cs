using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CleaningPro
{
    public partial class BookingForm : Form
    {
        private string connectionString = "server=localhost;port=3306;database=cleaningpro;user=root;password=root;";

        public BookingForm()
        {
            InitializeComponent();
            LoadBookings();
        }

        private void LoadBookings()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Bookings";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvBookings.DataSource = dt;
                }
            }
        }//end

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtAddress.Text) ||
                cmbCleaningType.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields.", "Input Error");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Bookings (Name, Email, Address, CleaningType, BookingDateTime) VALUES (@Name, @Email, @Address, @CleaningType, @BookingDateTime)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@CleaningType", cmbCleaningType.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@BookingDateTime", dtpDateTime.Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking added successfully!", "Success");
                    LoadBookings(); // Refresh DataGridView
                }
            }
        }//end
        private void dgvBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure row is selected
            {
                DataGridViewRow row = dgvBookings.Rows[e.RowIndex];

                txtName.Text = row.Cells["Name"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                cmbCleaningType.SelectedItem = row.Cells["CleaningType"].Value.ToString();
                dtpDateTime.Value = Convert.ToDateTime(row.Cells["BookingDateTime"].Value);
            }
        }//end
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to update.", "Selection Error");
                return;
            }

            int bookingID = Convert.ToInt32(dgvBookings.SelectedRows[0].Cells["BookingID"].Value);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Bookings SET Name=@Name, Email=@Email, Address=@Address, CleaningType=@CleaningType, BookingDateTime=@BookingDateTime WHERE BookingID=@BookingID";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@CleaningType", cmbCleaningType.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@BookingDateTime", dtpDateTime.Value);
                    cmd.Parameters.AddWithValue("@BookingID", bookingID);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking updated successfully!", "Success");
                    LoadBookings();
                }
            }
        }//end
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to delete.", "Selection Error");
                return;
            }

            int bookingID = Convert.ToInt32(dgvBookings.SelectedRows[0].Cells["BookingID"].Value);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Bookings WHERE BookingID=@BookingID";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BookingID", bookingID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking deleted successfully!", "Success");
                    LoadBookings();
                }
            }
        }//end
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.Trim();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Bookings WHERE Name LIKE @SearchName";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchName", "%" + searchQuery + "%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvBookings.DataSource = dt;
                }
            }
        }//end
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Redirect to MainForm
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
    }
}
