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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void chnageInfoTxt_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bills_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ElectricityGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=LexusDB;Integrated Security=True;Encrypt=False";
            string query = @"INSERT INTO INVOICE (PropertyID, DueDate, TotalAmount, PaymentStatus, PaymentType, DatePaid)
                     VALUES (@PropertyID, @DueDate, @TotalAmount, @PaymentStatus, @PaymentType, @DatePaid)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Convert text to appropriate data types and add them as parameters
                    cmd.Parameters.AddWithValue("@PropertyID", int.Parse(PropertyIDTxtBox.Text));
                    cmd.Parameters.AddWithValue("@DueDate", DateTime.Parse(DueDateTxtBox.Text));
                    cmd.Parameters.AddWithValue("@TotalAmount", decimal.Parse(AmmountTxtBox.Text));
                    cmd.Parameters.AddWithValue("@PaymentStatus", PaymentStatusTxtBox.Text);
                    cmd.Parameters.AddWithValue("@PaymentType", PaymentTypeTxtBox.Text);
                    cmd.Parameters.AddWithValue("@DatePaid", DateTime.Parse(DatePaidTxtBox.Text));

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Invoice added successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No invoice was added.");
                    }
                }
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Formatting Error: " + fex.Message);
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("Database Error: " + sqlex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            LoadUserData();
        }



        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void PaymentTypeTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=LexusDB;Integrated Security=True;Encrypt=False"; // Replace with your connection string
            string query = "SELECT * FROM INVOICE WHERE InvoiceID = @InvoiceID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@InvoiceID", int.Parse(InvoiceIDTxtBox.Text)); // Assuming you have a TextBox named InvoiceIDTxtBox

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];

                        // Update the text boxes with the data
                        PropertyIDTxtBox.Text = row["PropertyID"].ToString();
                        DueDateTxtBox.Text = row["DueDate"].ToString();
                        DatePaidTxtBox.Text = row["DatePaid"].ToString();
                        AmmountTxtBox.Text = row["TotalAmount"].ToString();
                        PaymentStatusTxtBox.Text = row["PaymentStatus"].ToString();
                        PaymentTypeTxtBox.Text = row["PaymentType"].ToString();
                        // Add any other fields you need to display
                    }
                    else
                    {
                        MessageBox.Show("No records found.");
                    }
                    LoadUserData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=LexusDB;Integrated Security=True;Encrypt=False"; // Replace with your connection string
            string query = @"UPDATE INVOICE SET PropertyID = @PropertyID, DatePaid = @DatePaid, DueDate = @DueDate, TotalAmount = @TotalAmount, PaymentStatus = @PaymentStatus, 
                     PaymentType = @PaymentType WHERE InvoiceID = @InvoiceID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Use the text box values for parameters
                    cmd.Parameters.AddWithValue("@PropertyID", PropertyIDTxtBox.Text);
                    cmd.Parameters.AddWithValue("@DueDate", DueDateTxtBox.Text);
                    cmd.Parameters.AddWithValue("@DatePaid", DatePaidTxtBox.Text); 
                    cmd.Parameters.AddWithValue("@TotalAmount", AmmountTxtBox.Text);
                    cmd.Parameters.AddWithValue("@PaymentStatus", PaymentStatusTxtBox.Text);
                    cmd.Parameters.AddWithValue("@PaymentType", PaymentTypeTxtBox.Text);
                    cmd.Parameters.AddWithValue("@InvoiceID", InvoiceIDTxtBox.Text); 

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Invoice updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No invoice was updated. Please check the Invoice ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LoadUserData();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=LexusDB;Integrated Security=True;Encrypt=False"; // Replace with your connection string
            string query = "DELETE FROM INVOICE WHERE InvoiceID = @InvoiceID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Assuming you have a TextBox for InvoiceID
                    cmd.Parameters.AddWithValue("@InvoiceID", int.Parse(InvoiceIDTxtBox.Text));

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Invoice deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No invoice was deleted. Check if the InvoiceID exists.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LoadUserData();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            // Clear text boxes
            PropertyIDTxtBox.Text = "";
            DueDateTxtBox.Text = "";
            AmmountTxtBox.Text = "";
            PaymentStatusTxtBox.Text = "";
            PaymentTypeTxtBox.Text = "";
            // Add any other controls that you need to reset

            // If you have any other types of controls (like ComboBoxes, CheckBoxes, etc.), reset them as well
            // For example:
            // myComboBox.SelectedIndex = -1;  // Resets a ComboBox
            // myCheckBox.Checked = false;     // Unchecks a CheckBox

            // Optionally, you can set the focus to the first input field
            PropertyIDTxtBox.Focus();
        }

        private void InvoiceGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void LoadUserData()
        {
            // Check if your DataGridView control is null or disposed
            if (InvoiceGrid == null || InvoiceGrid.IsDisposed)
            {
                // Handle the situation (e.g., show an error message or log)
                return;
            }

            // Connection string
            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=LexusDB;Integrated Security=True;Encrypt=False";

            // SQL query
            string query = "Select * From INVOICE";

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
                InvoiceGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                MessageBox.Show("An error occurred while filling the grid: " + ex.Message);
            }
        }

        private void AmmountTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
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

        private void leaseBtn_Click(object sender, EventArgs e)
        {
            Homepage newWindow = new Homepage();
            newWindow.Show();
            this.Close();
        }

        private void propertyBtn_Click(object sender, EventArgs e)
        {
            PropertyPage newWindow = new PropertyPage();
            newWindow.Show();
            this.Close();
        }

        private void ViewDataBtn_Click(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Agreement newWindow = new Agreement();
            newWindow.Show();
            this.Close();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Dashboard newWindow = new Dashboard();
            newWindow.Show();
            this.Close();
        }
    }
}
