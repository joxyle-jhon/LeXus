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
    public partial class Agreement : Form
    {
        public Agreement()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void FillAgreementGrid()
        {
            // Check if your DataGridView control is null or disposed
            if (AgreementGrid == null || AgreementGrid.IsDisposed)
            {
                // Handle the situation (e.g., show an error message or log)
                return;
            }

            // Connection string
            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=LexusDB;Integrated Security=True;Encrypt=False";

            // SQL query
            string query = "Select * From AGREEMENT";

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
                AgreementGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                MessageBox.Show("An error occurred while filling the grid: " + ex.Message);
            }
        }

        private void ViewDataBtn_Click(object sender, EventArgs e)
        {
            FillAgreementGrid();
        }

        private void chnageInfoTxt_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=JLOMBLERO\\SQLEXPRESS;Initial Catalog=LexusDB;Integrated Security=True;Encrypt=False";
            string insertQuery = @"
        INSERT INTO AGREEMENT (StartDate, EndDate, RenewalTerm, RentAmmount, PaymentSchedule, Deposit) 
        VALUES (@StartDate, @EndDate, @RenewalTerm, @RentAmmount, @PaymentSchedule, @Deposit)";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        // Use a parameterized query to prevent SQL Injection
                        cmd.Parameters.AddWithValue("@StartDate", DateTime.Parse(StartDateTxtBox.Text));
                        cmd.Parameters.AddWithValue("@EndDate", DateTime.Parse(EndDateTxtBox.Text));
                        cmd.Parameters.AddWithValue("@RenewalTerm", RenewalTermTxtBox.Text);
                        cmd.Parameters.AddWithValue("@RentAmmount", decimal.Parse(RentAmmountTxtBox.Text));
                        cmd.Parameters.AddWithValue("@PaymentSchedule", PaymentScheduleTxtBox.Text);
                        cmd.Parameters.AddWithValue("@Deposit", int.Parse(DepositTxtBox.Text));

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No record was added.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            FillAgreementGrid();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=YourDataSource;Initial Catalog=YourDatabase;Integrated Security=True;Encrypt=False";
            string updateQuery = @"
        UPDATE AGREEMENT 
        SET StartDate = @StartDate, 
            EndDate = @EndDate, 
            RenewalTerm = @RenewalTerm, 
            RentAmmount = @RentAmmount, 
            PaymentSchedule = @PaymentSchedule, 
            Deposit = @Deposit, 
        WHERE AgreementID = @AgreementID";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        // Use a parameterized query to prevent SQL Injection
                        cmd.Parameters.AddWithValue("@StartDate", DateTime.Parse(StartDateTxtBox.Text));
                        cmd.Parameters.AddWithValue("@EndDate", DateTime.Parse(EndDateTxtBox.Text));
                        cmd.Parameters.AddWithValue("@RenewalTerm", RenewalTermTxtBox.Text);
                        cmd.Parameters.AddWithValue("@RentAmmount", decimal.Parse(RentAmmountTxtBox.Text));
                        cmd.Parameters.AddWithValue("@PaymentSchedule", PaymentScheduleTxtBox.Text);
                        cmd.Parameters.AddWithValue("@Deposit", int.Parse(DepositTxtBox.Text));
                        cmd.Parameters.AddWithValue("@AgreementID", int.Parse(AgreementIDTxtBox.Text));

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No record was updated.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=YourDataSource;Initial Catalog=YourDatabase;Integrated Security=True;Encrypt=False";
            string deleteQuery = "DELETE FROM AGREEMENT WHERE AgreementID = @ID"; // Replace YourTable and YourIDColumn with your table name and ID column name

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                    {
                        // Use a parameterized query to prevent SQL Injection
                        cmd.Parameters.AddWithValue("@ID", int.Parse(AgreementIDTxtBox.Text));

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No record was deleted. Please check the ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=JLOMBLERO\\SQLEXPRESS;Initial Catalog=LexusDB;Integrated Security=True;Encrypt=False";
            string searchQuery = "SELECT * FROM AGREEMENT WHERE AgreementID LIKE @AgreementID";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(searchQuery, con))
                    {
                        // Use a parameterized query to prevent SQL Injection
                        cmd.Parameters.AddWithValue("@AgreementID", "%" + AgreementIDTxtBox.Text + "%");

                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    // Assuming the names of your text boxes match the column names in your table
                                    StartDateTxtBox.Text = reader["StartDate"].ToString();
                                    EndDateTxtBox.Text = reader["EndDate"].ToString();
                                    RenewalTermTxtBox.Text = reader["RenewalTerm"].ToString();
                                    RentAmmountTxtBox.Text = reader["RentAmmount"].ToString();
                                    PaymentScheduleTxtBox.Text = reader["PaymentSchedule"].ToString();
                                    DepositTxtBox.Text = reader["Deposit"].ToString();
                                    AgreementIDTxtBox.Text = reader["AgreementID"].ToString();
                                }
                            }
                            else
                            {
                                MessageBox.Show("No records found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            FillAgreementGrid();
        }


        private void ClearBtn_Click(object sender, EventArgs e)
        {
            // Clearing the text from each specified text box
            StartDateTxtBox.Clear();
            EndDateTxtBox.Clear();
            RenewalTermTxtBox.Clear();
            RentAmmountTxtBox.Clear();
            PaymentScheduleTxtBox.Clear();
            DepositTxtBox.Clear();
            AgreementIDTxtBox.Clear();

            // If you have other controls to reset (like ComboBoxes, CheckBoxes, etc.), add them here
            // Example: comboBox1.SelectedIndex = -1; // Resets a ComboBox
            // Example: checkBox1.Checked = false;    // Unchecks a CheckBox
        }

        private void billBtn_Click(object sender, EventArgs e)
        {
            Bill newWindow = new Bill();
            newWindow.Show();
            this.Close();
        }

        private void propertyBtn_Click(object sender, EventArgs e)
        {
            PropertyPage newWindow = new PropertyPage();
            newWindow.Show();
            this.Close();
        }

        private void leaseBtn_Click(object sender, EventArgs e)
        {
            Homepage newWindow = new Homepage();
            newWindow.Show();
            this.Close();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Dashboard newWindow = new Dashboard();
            newWindow.Show();
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
