using FontAwesome.Sharp;
using LeXus.Forms;
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


namespace LeXus
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void projectName_Click(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimizedIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void notifBtn_Click(object sender, EventArgs e)
        {

        }

        private void accountSettingBtn_Click(object sender, EventArgs e)
        {

        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }


        private void informationContainer_Click(object sender, EventArgs e)
        {

        }

        private void tenantTxt_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {
 
        }

        private void sideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            PropertyPage newWindow = new PropertyPage();
            newWindow.Show();
            this.Close();
        }



        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void genderDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Dashboard newWindow = new Dashboard();
            newWindow.Show();
            this.Close();

        }

        private void birthDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=LexusDB;Integrated Security=True;Encrypt=False");
                con.Open();

                string updateQuery = "UPDATE userInfo SET FirstName = @FirstName, LastNamee = @LastNamee, MiddleIN = @MiddleIN, Age = @Age, Sex = @Sex, Birthday = @Birthday, PhoneNumber = @PhoneNumber, ValidIDType = @ValidIDType, IDNumber = @IDNumber, Occupation = @Occupation WHERE LeaseID = @LeaseID";

                SqlCommand cmd = new SqlCommand(updateQuery, con);

                // Adding parameters with values from the text boxes
                cmd.Parameters.AddWithValue("@LeaseID", userIDSearchBox.Text);
                cmd.Parameters.AddWithValue("@FirstName", FirstnameTxtBox.Text);
                cmd.Parameters.AddWithValue("@LastNamee", LastnameTxtBox.Text);
                cmd.Parameters.AddWithValue("@MiddleIN", MiddleTxtBox.Text);
                cmd.Parameters.AddWithValue("@Age", AgeTxtBox.Text);
                cmd.Parameters.AddWithValue("@Sex", SexTxtBox.Text);
                cmd.Parameters.AddWithValue("@Birthday", BirthdateTxtBox.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumberTxtBox.Text);
                cmd.Parameters.AddWithValue("@ValidIDType", IDTypeTxtBox.Text);
                cmd.Parameters.AddWithValue("@IDNumber", IDNumberTxtBox.Text);
                cmd.Parameters.AddWithValue("@Occupation", OccupationTxtBox.Text);

                try
                {
                    int rowsUpdated = cmd.ExecuteNonQuery();
                    if (rowsUpdated > 0)
                    {
                        MessageBox.Show("Record Updated Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Record not found or no changes made");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            FillUserInfoGrid();

        }


        private void lastNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            FillUserInfoGrid();
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=LexusDB;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select FirstName, LastNamee, MiddleIN, Age, Sex, Birthday, PhoneNumber, ValidIDType, IDNumber, Occupation from userInfo where LeaseID=@LeaseID", con);
            cmd1.Parameters.AddWithValue("@LeaseID", userIDSearchBox.Text);
            SqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
            {
                FirstnameTxtBox.Text = reader1["FirstName"].ToString();
                LastnameTxtBox.Text = reader1["LastNamee"].ToString();
                MiddleTxtBox.Text = reader1["MiddleIN"].ToString();
                AgeTxtBox.Text = reader1["Age"].ToString();
                SexTxtBox.Text = reader1["Sex"].ToString();
                BirthdateTxtBox.Text = reader1["Birthday"].ToString();
                PhoneNumberTxtBox.Text = reader1["PhoneNumber"].ToString();
                IDTypeTxtBox.Text = reader1["ValidIDType"].ToString();
                IDNumberTxtBox.Text = reader1["IDNumber"].ToString();
                OccupationTxtBox.Text = reader1["Occupation"].ToString();

            }
            else
            {
                MessageBox.Show("No Data Found!");
            }
            con.Close();
        }


        private void idNunberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void idNumberTxt_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // Connection string
            string connectionString = "Data Source=JLOMBLERO\\SQLEXPRESS;Initial Catalog=LexusDB;Integrated Security=True;Encrypt=False";
            // SQL command - ID is auto-generated, so it's not included in the INSERT statement
            string commandText = "INSERT INTO USERINFO (FirstName, LastNamee, MiddleIN, Age, Sex, Birthday, PhoneNumber, ValidIDType, IDNumber, Occupation) VALUES (@FirstName, @LastNamee, @MiddleIN, @Age, @Sex, @Birthday, @PhoneNumber, @ValidIDType, @IDNumber, @Occupation)";

            try
            {
                // Using statement ensures that the SqlConnection object is disposed correctly
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Using statement for the SqlCommand
                    using (SqlCommand cmd = new SqlCommand(commandText, con))
                    {
                        // Adding parameters with values
                        cmd.Parameters.AddWithValue("@FirstName", FirstnameTxtBox.Text);
                        cmd.Parameters.AddWithValue("@LastNamee", LastnameTxtBox.Text); // Column name is "LastNamee" as per your schema
                        cmd.Parameters.AddWithValue("@MiddleIN", MiddleTxtBox.Text);
                        cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(AgeTxtBox.Text)); // Age is an INT in the database
                        cmd.Parameters.AddWithValue("@Sex", SexTxtBox.Text);
                        cmd.Parameters.AddWithValue("@Birthday", BirthdateTxtBox.Text); // Assuming you are storing birthdays as text
                        cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumberTxtBox.Text);
                        cmd.Parameters.AddWithValue("@ValidIDType", IDTypeTxtBox.Text);
                        cmd.Parameters.AddWithValue("@IDNumber", IDNumberTxtBox.Text);
                        cmd.Parameters.AddWithValue("@Occupation", OccupationTxtBox.Text);
                        // CreationTime is automatically set by the database

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Successfully Saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            FillUserInfoGrid();
        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=LexusDB;Integrated Security=True;Encrypt=False");
            con.Open();

            string deleteQuery = "DELETE FROM USERINFO WHERE LeaseID = @LeaseID";

            SqlCommand cmd = new SqlCommand(deleteQuery, con);
            cmd.Parameters.AddWithValue("@LeaseID", userIDSearchBox.Text);

            try
            {
                int rowsDeleted = cmd.ExecuteNonQuery();
                if (rowsDeleted > 0)
                {
                    MessageBox.Show("Record Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            FillUserInfoGrid();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            // Clearing all the text boxes
            userIDSearchBox.Text = "";
            FirstnameTxtBox.Text = "";
            LastnameTxtBox.Text = "";
            MiddleTxtBox.Text = "";
            AgeTxtBox.Text = "";
            SexTxtBox.Text = "";
            BirthdateTxtBox.Text = "";
            PhoneNumberTxtBox.Text = "";
            IDTypeTxtBox.Text = "";
            IDNumberTxtBox.Text = "";
            OccupationTxtBox.Text = "";

            // Optionally, you can also reset other controls if you have any,
            // such as ComboBoxes, CheckBoxes, etc.

            // For example, if you have a ComboBox:
            // yourComboBox.SelectedIndex = -1; // Resets to no selection

            // And for a CheckBox:
            // yourCheckBox.Checked = false;
        }

        private void OccupationTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AgeTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SexTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void IDTypeTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneNumberTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BirthdateTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MiddleTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void FirstnameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void idTypeText_Click(object sender, EventArgs e)
        {

        }

        private void phoneNumberTxt_Click(object sender, EventArgs e)
        {

        }

        private void birthTxt_Click(object sender, EventArgs e)
        {

        }

        private void genderTxt_Click(object sender, EventArgs e)
        {

        }

        private void middleINTxt_Click(object sender, EventArgs e)
        {

        }

        private void lastNameTxt_Click(object sender, EventArgs e)
        {

        }

        private void firstNameTxt_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chnageInfoTxt_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void FillUserInfoGrid()
        {
            // Check if your DataGridView control is null or disposed
            if (UserInfoGrid == null || UserInfoGrid.IsDisposed)
            {
                // Handle the situation (e.g., show an error message or log)
                return;
            }

            // Connection string
            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=LexusDB;Integrated Security=True;Encrypt=False";

            // SQL query
            string query = "Select * From USERINFO";

            // DataTable to hold the data
            DataTable dt = new DataTable();

            // Using statement for resource management
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        // Fill the DataTable
                        da.Fill(dt);
                    }
                }

                // Assigning the DataTable as the DataSource for your DataGridView control
                UserInfoGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                MessageBox.Show("An error occurred while filling the grid: " + ex.Message);
            }
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void billBtn_Click(object sender, EventArgs e)
        {
            Bill newWindow = new Bill();
            newWindow.Show();
            this.Close();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void UserInfoGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MaintenanceBtn_Click(object sender, EventArgs e)
        {
            Agreement newWindow = new Agreement();
            newWindow.Show();
            this.Close();
        }

        private void ViewData_Click(object sender, EventArgs e)
        {
            FillUserInfoGrid();
        }
    }

}
