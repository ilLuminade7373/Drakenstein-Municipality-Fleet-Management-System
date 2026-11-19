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
    public partial class VehicleControl : UserControl
    {
        public VehicleControl()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void VehicleControl_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DM-FleetManagementSystem;Integrated Security=True;Encrypt=True";

            string query = @"SELECT VehicleName,
                            RegistrationNumber,
                            VehicleType,
                            FuelType,
                            Status
                    FROM Vehicles
                    WHERE UserID = @UserID";

            try
            {

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", UserSession.CurrentUserID);

                    conn.Open();
                    
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    { 
                        lblVehicleName.Text = reader["VehicleName"].ToString();
                        lblRegistrationNumber.Text = reader["RegistrationNumber"].ToString();
                        lblVehicleType.Text = reader["VehicleType"].ToString();
                        lblFuelType.Text = reader["FuelType"].ToString();
                        lblStatus.Text = reader["Status"].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
