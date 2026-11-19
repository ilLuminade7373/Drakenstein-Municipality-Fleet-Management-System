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
    public partial class TripsControl : UserControl
    {
        public TripsControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TripsControl_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DM-FleetManagementSystem;Integrated Security=True;Encrypt=True";

            string query = @"SELECT
                            TripDate,
                            StartLocation,
                            Destination,
                            DistanceKm
                            FROM Trips
                            WHERE UserID = @UserID";

            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(@"UserID",UserSession.CurrentUserID);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);
                    dgvTrips.DataSource = dt;
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
