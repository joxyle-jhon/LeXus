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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadUserData()
        {
            // Check if your DataGridView control is null or disposed
            if (DashBoardView == null || DashBoardView.IsDisposed)
            {
                // Handle the situation (e.g., show an error message or log)
                return;
            }

            // Connection string
            string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=LexusDB;Integrated Security=True;Encrypt=False";

            // SQL query
            string query = "Select * From Dashboard";

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
                DashBoardView.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                MessageBox.Show("An error occurred while filling the grid: " + ex.Message);
            }
        }

        private void ViewData_Click(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {

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

        private void billBtn_Click(object sender, EventArgs e)
        {
            Bill newWindow = new Bill();
            newWindow.Show();
            this.Close();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimizedIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Agreement newWindow = new Agreement();
            newWindow.Show();
            this.Close();
        }

        private void chnageInfoTxt_Click(object sender, EventArgs e)
        {

        }
    }
}
