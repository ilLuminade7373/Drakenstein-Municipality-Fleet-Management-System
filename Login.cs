using Microsoft.Win32;
using Microsoft.Data.SqlClient;
namespace DMFleetManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            Font appFont = new Font("Bahnschrift", 10F);
            textBox1.Font = appFont;
            textBox2.Font = appFont;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form loginForm = new Register();
            loginForm.FormClosed += (s, args) => this.Show();
            loginForm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DM-FleetManagementSystem;Integrated Security=True;Encrypt=True";

            string query = @"SELECT UserID
                            FROM Users
                            WHERE UserName = @UserName
                            AND Password = @Password";


            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    {
                        
                       
                        cmd.Parameters.AddWithValue("@UserName", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", textBox2.Text.Trim());

                        conn.Open();
                       

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            UserSession.CurrentUser =
                                 textBox1.Text;
                            UserSession.CurrentUserID =
                                Convert.ToInt32(result);

                            MessageBox.Show("Login Successful");

                            MainPage mainPage = new MainPage();
                            mainPage.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid username or password. ");
            }
        }
         
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
            
   

