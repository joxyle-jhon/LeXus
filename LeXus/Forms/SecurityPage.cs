using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeXus
{
    public partial class SecurityPage : Form
    {
        public SecurityPage()
        {
            InitializeComponent();
        }

        private void accountSettingBtn_Click(object sender, EventArgs e)
        {
            Homepage home = new LeXus.Homepage();
            this.Visible = false;
            home.ShowDialog();
            this.Close();

        }

        private void SecurityPage_Load(object sender, EventArgs e)
        {

        }

        private void accountSettingBtn_Click_1(object sender, EventArgs e)
        {
            Homepage home = new LeXus.Homepage();
            this.Visible = false;
            home.ShowDialog();
            this.Close();
        }

        private void securityBtn_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tenantTxt_Click(object sender, EventArgs e)
        {
            Homepage home = new LeXus.Homepage();
            this.Visible = false;
            home.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Homepage home = new LeXus.Homepage();
            this.Visible = false;
            home.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            PropertyPage home = new LeXus.PropertyPage();
            this.Visible = false;
            home.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            PropertyPage home = new LeXus.PropertyPage();
            this.Visible = false;
            home.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Homepage home = new LeXus.Homepage();
            this.Visible = false;
            home.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PropertyPage home = new LeXus.PropertyPage();
            this.Visible = false;
            home.ShowDialog();
            this.Close();
        }

        private void leaseBtn_Click(object sender, EventArgs e)
        {
            Homepage home = new LeXus.Homepage();
            this.Visible = false;
            home.ShowDialog();
            this.Close();
        }

        private void PropertyBtn_Click(object sender, EventArgs e)
        {
            PropertyPage home = new LeXus.PropertyPage();
            this.Visible = false;
            home.ShowDialog();
            this.Close();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Homepage home = new LeXus.Homepage();
            this.Visible = false;
            home.ShowDialog();
            this.Close();
        }

        private void propertyBtn_Click_1(object sender, EventArgs e)
        {
            PropertyPage home = new LeXus.PropertyPage();
            this.Visible = false;
            home.ShowDialog();
            this.Close();
        }

        private void leaseBtn_Click_1(object sender, EventArgs e)
        {
            Homepage home = new LeXus.Homepage();
            this.Visible = false;
            home.ShowDialog();
            this.Close();
        }
    }
}
