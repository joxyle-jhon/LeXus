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
    public partial class PropertyPage : Form
    {
        public PropertyPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Homepage home = new LeXus.Homepage();
            home.ShowDialog();
            this.Close();
        }

        private void tenantTxt_Click(object sender, EventArgs e)
        {
            Homepage home = new LeXus.Homepage();
            home.ShowDialog();
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Homepage home = new LeXus.Homepage();
            home.ShowDialog();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            PropertyPage home = new LeXus.PropertyPage();
            home.ShowDialog();
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Homepage home = new LeXus.Homepage();
            home.ShowDialog();
            this.Close();
        }

        private void billBtn_Click(object sender, EventArgs e)
        {

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Dashboard newWindow = new Dashboard();
            newWindow.Show();
            this.Close();
        }

        private void propertyBtn_Click(object sender, EventArgs e)
        {

        }

        private void leaseBtn_Click(object sender, EventArgs e)
        {
            Homepage newWindow = new Homepage();
            newWindow.Show();
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // Example: Adding a new property record to a database
            string connectionString = "Data Source=JLOMBLERO\\SQLEXPRESS;Initial Catalog=LexusDB;Integrated Security=True;Encrypt=False"; // Define your database connection string
            string commandText = "INSERT INTO PROPERTY (RoomNumber, PropertyName, PropertyAddress, WBillingNumber, EBillingNumber, LandlordName, OccupancyStatus, LeaseID, AgreementID, LandlordID) VALUES (@RoomNumber, @PropertyName, @PropertyAddress, @WBillingNumber, @EBillingNumber, @LandlordID, @OccupancyStatus, @LeaseID, @AgreementID)";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(commandText, con))
                    {
                        // Check if any of the text boxes are empty
                        if (string.IsNullOrWhiteSpace(roomNumberBox.Text) ||
                            string.IsNullOrWhiteSpace(PropertyNameBox.Text) ||
                            string.IsNullOrWhiteSpace(AgreementIDTxtBox.Text) ||
                            string.IsNullOrWhiteSpace(OccupancyStatusTxtBox.Text) ||
                            string.IsNullOrWhiteSpace(propertyAddressBox.Text) ||
                            string.IsNullOrWhiteSpace(WaterBillBox.Text) ||
                            string.IsNullOrWhiteSpace(LeaseIDTxtBox.Text) ||
                            string.IsNullOrWhiteSpace(LandLordIDTxtBox.Text) ||
                            string.IsNullOrWhiteSpace(ElectricityBillBox.Text))
                        {
                            MessageBox.Show("Please fill in all the fields.");
                            return; // Exit the method if any field is empty
                        }
                        // Assuming you have text boxes for RoomNumber, PropertyName, PropertyAddress, WBillingNumber, and EBillingNumber
                        cmd.Parameters.AddWithValue("@RoomNumber", roomNumberBox.Text);
                        cmd.Parameters.AddWithValue("@AgreementID", AgreementIDTxtBox.Text);
                        cmd.Parameters.AddWithValue("@OccupancyStatus", OccupancyStatusTxtBox.Text);
                        cmd.Parameters.AddWithValue("@PropertyName", PropertyNameBox.Text);
                        cmd.Parameters.AddWithValue("@PropertyAddress", propertyAddressBox.Text);
                        cmd.Parameters.AddWithValue("@LeaseID", LeaseIDTxtBox.Text);
                        cmd.Parameters.AddWithValue("@LandlordID", LandLordIDTxtBox.Text);
                        cmd.Parameters.AddWithValue("@WBillingNumber", WaterBillBox.Text); // New field
                        cmd.Parameters.AddWithValue("@EBillingNumber", ElectricityBillBox.Text); // New field

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Property record added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            LoadUserData();
        }



        private void searchBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=JLOMBLERO\\SQLEXPRESS;Initial Catalog=LexusDB;Integrated Security=True;Encrypt=False";
            string searchQuery = "SELECT * FROM PROPERTY WHERE RoomNumber = @RoomNumber";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(searchQuery, con))
                    {
                        // Use a parameterized query to prevent SQL Injection
                        cmd.Parameters.AddWithValue("@RoomNumber", roomNumberBox.Text);


                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Assuming the columns are in the order: PropertyID, RoomNumber, PropertyName, PropertyAddress, WBillingNumber, EBillingNumber
                                PropertyIDTxtBox.Text = reader["PropertyID"].ToString();
                                LeaseIDTxtBox.Text = reader["LeaseID"].ToString();
                                AgreementIDTxtBox.Text = reader["AgreementID"].ToString();
                                roomNumberBox.Text = reader["RoomNumber"].ToString();
                                propertyAddressBox.Text = reader["PropertyAddress"].ToString();
                                PropertyNameBox.Text = reader["PropertyName"].ToString();
                                OccupancyStatusTxtBox.Text = reader["OccupancyStatus"].ToString();
                                WaterBillBox.Text = reader["WBillingNumber"].ToString();
                                LandLordIDTxtBox.Text = reader["LandlordID"].ToString();
                                ElectricityBillBox.Text = reader["EBillingNumber"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No property found with the given ID.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            LoadUserData();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=LexusDB;Integrated Security=True;Encrypt=False");
            con.Open();

            string deleteQuery = "DELETE FROM PROPERTY WHERE PropertyID = @PropertyID";

            SqlCommand cmd = new SqlCommand(deleteQuery, con);
            cmd.Parameters.AddWithValue("@PropertyID", PropertyIDTxtBox.Text);

            try
            {
                int rowsDeleted = cmd.ExecuteNonQuery();
                if (rowsDeleted > 0)
                {
                    MessageBox.Show("Property record deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Property record not found.");
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
            LoadUserData();
        }



        private void ClearBtn_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes
            roomNumberBox.Text = "";
            AgreementIDTxtBox.Text = "";
            LeaseIDTxtBox.Text = "";
            OccupancyStatusTxtBox.Text = "";
            PropertyNameBox.Text = "";
            PropertyIDTxtBox.Text = "";
            propertyAddressBox.Text = "";
            WaterBillBox.Text = "";
            LandLordIDTxtBox.Text = "";
            ElectricityBillBox.Text = "";
            // Add any other controls that need to be cleared

        }


        private void updateBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=LexusDB;Integrated Security=True;Encrypt=False";
            string updateQuery = "UPDATE PROPERTY SET RoomNumber = @RoomNumber, PropertyName = @PropertyName, PropertyAddress = @PropertyAddress, AgreementID = @AgreementID, LandlordID = @LandlordID, OccupancyStatus = @OccupancyStatus, WBillingNumber = @WBillingNumber, EBillingNumber = @EBillingNumber, LeaseID = @LeaseID WHERE PropertyID = @PropertyID";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        // Adding parameters with values from the text boxes
                        cmd.Parameters.AddWithValue("@PropertyID", PropertyIDTxtBox.Text);
                        cmd.Parameters.AddWithValue("@LeaseID", LeaseIDTxtBox.Text);
                        cmd.Parameters.AddWithValue("@LandlordID", LandLordIDTxtBox.Text);
                        cmd.Parameters.AddWithValue("@AgreementID", AgreementIDTxtBox.Text);
                        cmd.Parameters.AddWithValue("@OccupancyStatus", OccupancyStatusTxtBox.Text);
                        cmd.Parameters.AddWithValue("@RoomNumber", roomNumberBox.Text);
                        cmd.Parameters.AddWithValue("@PropertyName", PropertyNameBox.Text);
                        cmd.Parameters.AddWithValue("@PropertyAddress", propertyAddressBox.Text);
                        cmd.Parameters.AddWithValue("@WBillingNumber", WaterBillBox.Text);
                        cmd.Parameters.AddWithValue("@EBillingNumber", ElectricityBillBox.Text);

                        con.Open();
                        int rowsUpdated = cmd.ExecuteNonQuery();
                        if (rowsUpdated > 0)
                        {
                            MessageBox.Show("Property record updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Property not found or no new data to update.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


            LoadUserData(); // Assuming LoadUserData() is a method you want to call after updating
        }




        private void propertyNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadUserData();
        }


        public void LoadUserData()
        {
            // Check if your DataGridView control is null or disposed
            if (PropertyGrid == null || PropertyGrid.IsDisposed)
            {
                // Handle the situation (e.g., show an error message or log)
                return;
            }

            // Connection string
            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=LexusDB;Integrated Security=True;Encrypt=False";

            // SQL query
            string query = "Select * From PROPERTY";

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
                PropertyGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                MessageBox.Show("An error occurred while filling the grid: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void billBtn_Click_1(object sender, EventArgs e)
        {
            Bill newWindow = new Bill();
            newWindow.Show();
            this.Close();

        }

        private void ViewDataBtn_Click(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Agreement newWindow = new Agreement();
            newWindow.Show();
            this.Close();
        }

        private void ViewData_Click(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void LeaseIDTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
