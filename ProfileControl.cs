using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Linq.Expressions;
using Microsoft.Data.SqlClient;


namespace DMFleetManagementSystem
{

    public partial class ProfileControl : UserControl
    {
        public ProfileControl()
        {
            InitializeComponent();

        }



        private string newImagePath = "";
        private string OriginalUsername;

        private void ProfileControl_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.UseSystemPasswordChar = true;
        }
        string imagePath = "";
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DM-FleetManagementSystem;Integrated Security=True;Encrypt=True";


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Image Files|*.jpg;.jpeg;*.png;*.bmp";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    string folder = Path.Combine(
                        Environment.GetFolderPath(
                                Environment.SpecialFolder.LocalApplicationData),
                            "MyApplication",
                            "ProfileImages"
                        );

                    Directory.CreateDirectory(folder);

                    string extension = Path.GetExtension(openFileDialog1.FileName);

                    string fileName = Guid.NewGuid().ToString() + extension;

                    imagePath = Path.Combine(folder, fileName);

                    File.Copy(openFileDialog1.FileName, imagePath, true);

                    using (Image img = Image.FromFile(imagePath))
                    {
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Image upload error: " + ex.Message);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //EMAIL VALIDATION
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                try
                {
                    var email = new System.Net.Mail.MailAddress(textBox2.Text.Trim());
                    throw new Exception();
                }
                catch
                {
                    MessageBox.Show("Please enter a valid email address.");
                    textBox2.Focus();
                    return;
                }

            }

            // PASSWORD VALIDATION
            if (!string.IsNullOrWhiteSpace(textBox3.Text) &&
                    textBox3.Text.Length < 8)
            {

                MessageBox.Show("Password must contain at least 8 characters.");

                textBox3.Focus();
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string sql = @"UPDATE Users 
                                SET
                                    Username = COALESCE(@Username, Username)
                                    Email = COALESCE(@EmailAddress, Email)
                                    Department = COALESCE(@Department, Department),
                                    [Password] = COALESCE(@Password, [Password]),
                                    ProfileImage = COALESCE(@ProfileImagePath, ProfileImage)
                            WHERE Username = @OriginalUsername";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        //USERNAME
                        string newUsername = textBox1.Text.Trim();

                        cmd.Parameters.AddWithValue(
                            "@Username",
                            string.IsNullOrWhiteSpace(newUsername)
                            ? (object)DBNull.Value : newUsername);

                        //EMAIL

                        string newEmail = textBox2.Text.Trim();
                        cmd.Parameters.AddWithValue(
                            "@Username",
                            string.IsNullOrWhiteSpace(newEmail)
                            ? (object)DBNull.Value : newEmail);

                        //Department
                        string newDepartment = textBox4.Text.Trim();

                        cmd.Parameters.AddWithValue(
                                "@Department",
                                string.IsNullOrWhiteSpace(newDepartment)
                                ? (object)DBNull.Value : newDepartment);

                        //PASSWORD
                        string newPassword = textBox3.Text;

                        if (string.IsNullOrWhiteSpace(newPassword))
                        {
                            cmd.Parameters.AddWithValue("@Password", DBNull.Value);

                        }

                        else
                        {

                            cmd.Parameters.AddWithValue("@Password", newPassword);

                        }

                        //PROFILE IMAGE
                        string newImagePath = button1.Text;
                        cmd.Parameters.AddWithValue(
                            "@ProfileImagePath",
                            string.IsNullOrWhiteSpace(newImagePath)
                            ? (object)DBNull.Value : newImagePath);

                        //ORIGINAL LOGGED-IN USERNAME
                        cmd.Parameters.AddWithValue("@OriginalUsername", OriginalUsername);

                        con.Open();

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            //Update username reference if it changed
                            if (!string.IsNullOrWhiteSpace(newUsername))
                            {
                                OriginalUsername = newUsername;

                            }

                            // Clear password textbox
                            textBox3.Clear();

                            //Clear new image selection
                            newImagePath = "";

                            MessageBox.Show("Your profile has been updated successfully!," +
                                "Profile Updated",
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                              );

                        }
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Database error: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occured: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
