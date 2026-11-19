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
    public partial class LogbookControl : UserControl
    {
        public LogbookControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogbookControl_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DM-FleetManagementSystem;Integrated Security=True;Encrypt=True";

            string query = @"SELECT
                            LogID,
                            UserID,
                            VehicleID,
                            LogDate,
                            OdemeterStart,
                            OdemeterEnd,
                            Purpose
                        FROM Logbook
                        WHERE UserID = @UserID
                        ORDER BY LogDate DESC";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", UserSession.CurrentUserID);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    dgvLogbook.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
} 