using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DMFleetManagementSystem
{
    public partial class NotificationControl : UserControl
    {
        public NotificationControl()
        {
            InitializeComponent();
        }
        private void LoadNotifications()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DM-FleetManagementSystem;Integrated Security=True;Encrypt=True";
            string query = @"SELECT
                           Status,
                           Message,
                           DateSent
                           FROM Notifications
                           WHERE UserID = @UserID
                           ORDER BY DateSent DESC";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(@"UserID", UserSession.CurrentUserID);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    dgvNotifications.DataSource = dt;

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void NotificationControl_Load(object sender, EventArgs e)
        {
            LoadNotifications();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DM-FleetManagementSystem;Integrated Security=True;Encrypt=True";

            string query = @"UPDATE Notifications
                           SET Status = 'Read'
                           WHERE UserID = @UserID";
            using (SqlConnection conn = new SqlConnection(connectionString)) { 
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("UserID", UserSession.CurrentUserID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadNotifications();
            MessageBox.Show("Notifications marked as read");
        }
    }
}
