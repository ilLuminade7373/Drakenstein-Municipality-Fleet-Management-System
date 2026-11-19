using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Data.SqlClient;
using System.Configuration;


namespace DMFleetManagementSystem
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            textBox5.UseSystemPasswordChar = true;
            textBox6.UseSystemPasswordChar = true;

            Font appFont = new Font("Bahnschrift", 10F);
            textBox1.Font = appFont;
            textBox2.Font = appFont;
            textBox3.Font = appFont;
            textBox4.Font = appFont;
            textBox5.Font = appFont;
            textBox6.Font = appFont;

            this.StartPosition = FormStartPosition.CenterScreen;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Enter your username.");
                textBox1.Focus();
                return;
            }

            if (!Regex.IsMatch(textBox2.Text,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Enter a valid email address.");
                textBox2.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Enter your department.");
                textBox3.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Enter your license number.");
                textBox4.Focus();
                return;
            }

            if (textBox5.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters.");
                textBox5.Focus();
                return;
            }

            if (textBox6.Text != textBox5.Text)
            {
                MessageBox.Show("Passwords do not match.");
                textBox6.Focus();
                return;

            }


            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DM-FleetManagementSystem;Integrated Security=True;Trust Server Certificate=True";

            string query = @"INSERT INTO Users
                           (UserName, EmailAddress, Department, Password)
                            VALUES
                           (@UserName, @EmailAddress, @Department, @Password)";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@UserName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@EmailAddress", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Department", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Password", textBox5.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Account registered succesfully!, You can now log in.", "Registration Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login loginform = new Login();
                    loginform.ShowDialog();
                    this.Hide();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private bool passwordVisible = false;

        private void picEye_Click(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;

            textBox5.UseSystemPasswordChar = !passwordVisible;
            textBox6.UseSystemPasswordChar = !passwordVisible;
        }

        private void picEye_MouseDown(object sender, MouseEventArgs e)
        {

            textBox5.UseSystemPasswordChar = true;
            textBox6.UseSystemPasswordChar = true;
        }


        private void picEye_MouseUp(object sender, MouseEventArgs e)
        {

            textBox5.UseSystemPasswordChar = true;
            textBox6.UseSystemPasswordChar = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
