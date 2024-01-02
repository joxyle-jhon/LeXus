using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeXus.Forms
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTxtBox.Text;
            string password = PasswordTxtBox.Text;
            string secretCode = SecretCodeTxtBox.Text;

            // Define your secret developer code
            const string developerSecretCode = "ComSciCDO";

            if (secretCode.Equals(developerSecretCode))
            {
                // Developer login logic
                MessageBox.Show("Developer login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenDashboard();
            }
            else
            {
                // User login logic
                string connectionString = "Data Source=JLOMBLERO\\SQLEXPRESS;Initial Catalog=LexusDB;Integrated Security=True;Encrypt=False";
                bool isLoginSuccessful = false;

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    string query = "SELECT COUNT(1) FROM USERS WHERE Username=@username AND Password=@password";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlConnection);
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Parameters.AddWithValue("@username", username);
                    sqlCmd.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                    if (count == 1)
                    {
                        isLoginSuccessful = true;
                    }

                    sqlConnection.Close();
                }

                if (isLoginSuccessful)
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OpenDashboard();
                }
                else
                {
                    MessageBox.Show("Login failed. Please check your username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OpenDashboard()
        {
            Dashboard dashboard = new Dashboard();
            this.Hide(); // Optionally hide the current form
            dashboard.Show();
        }



        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void projectName_Click(object sender, EventArgs e)
        {

        }

        private void minimizedIcon_Click(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void containerForm_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void description_Click(object sender, EventArgs e)
        {

        }

        private void furnitureArt_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void sideBar_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginWindow newWindow = new LoginWindow();
            newWindow.Show();
            this.Hide();


        }
    }
}
