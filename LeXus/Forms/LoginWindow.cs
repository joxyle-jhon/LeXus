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



    public partial class LoginWindow : Form
    {



       // SqlConnection conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=LexusDB;Integrated Security=True;Encrypt=False");

        public LoginWindow()
        {
            InitializeComponent();
        }   

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.projectName = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.sideBar = new System.Windows.Forms.Label();
            this.containerForm = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.Label();
            this.brokenLine1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Label();
            this.minimizedIcon = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataSet1 = new LeXus.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.furnitureArt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // projectName
            // 
            this.projectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.projectName.Font = new System.Drawing.Font("Ageo Personal Use ExtBd", 110F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.projectName.Location = new System.Drawing.Point(55, 183);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(482, 192);
            this.projectName.TabIndex = 0;
            this.projectName.Text = "LeXus";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Ageo Personal Use", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.White;
            this.description.Location = new System.Drawing.Point(96, 358);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(441, 44);
            this.description.TabIndex = 1;
            this.description.Text = "Streamlining property management. Simplify tenant \r\nonboarding, lease tracking, a" +
    "nd communication. ";
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.White;
            this.sideBar.Font = new System.Drawing.Font("Ageo Personal Use", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideBar.ForeColor = System.Drawing.Color.White;
            this.sideBar.Location = new System.Drawing.Point(610, -2);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(769, 895);
            this.sideBar.TabIndex = 3;
            // 
            // containerForm
            // 
            this.containerForm.Font = new System.Drawing.Font("Ageo Personal Use", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containerForm.ForeColor = System.Drawing.Color.White;
            this.containerForm.Location = new System.Drawing.Point(803, 201);
            this.containerForm.Name = "containerForm";
            this.containerForm.Size = new System.Drawing.Size(388, 499);
            this.containerForm.TabIndex = 4;
            this.containerForm.Click += new System.EventHandler(this.containerForm_Click);
            // 
            // usernameTxt
            // 
            this.usernameTxt.AutoSize = true;
            this.usernameTxt.Font = new System.Drawing.Font("Ageo Personal Use Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.usernameTxt.Location = new System.Drawing.Point(861, 299);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(81, 18);
            this.usernameTxt.TabIndex = 6;
            this.usernameTxt.Text = "Username";
            // 
            // passwordTxt
            // 
            this.passwordTxt.AutoSize = true;
            this.passwordTxt.Font = new System.Drawing.Font("Ageo Personal Use Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.passwordTxt.Location = new System.Drawing.Point(861, 401);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(74, 18);
            this.passwordTxt.TabIndex = 7;
            this.passwordTxt.Text = "Password";
            // 
            // brokenLine1
            // 
            this.brokenLine1.AutoSize = true;
            this.brokenLine1.Font = new System.Drawing.Font("Ageo Personal Use Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brokenLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.brokenLine1.Location = new System.Drawing.Point(861, 357);
            this.brokenLine1.Name = "brokenLine1";
            this.brokenLine1.Size = new System.Drawing.Size(269, 18);
            this.brokenLine1.TabIndex = 9;
            this.brokenLine1.Text = "_____________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ageo Personal Use Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label2.Location = new System.Drawing.Point(861, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "_____________________________";
            // 
            // UsernameTxtBox
            // 
            this.UsernameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.UsernameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTxtBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxtBox.ForeColor = System.Drawing.Color.White;
            this.UsernameTxtBox.Location = new System.Drawing.Point(868, 349);
            this.UsernameTxtBox.Name = "UsernameTxtBox";
            this.UsernameTxtBox.Size = new System.Drawing.Size(256, 20);
            this.UsernameTxtBox.TabIndex = 8;
            this.UsernameTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.PasswordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTxtBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxtBox.ForeColor = System.Drawing.Color.White;
            this.PasswordTxtBox.Location = new System.Drawing.Point(867, 450);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.PasswordChar = '*';
            this.PasswordTxtBox.Size = new System.Drawing.Size(256, 20);
            this.PasswordTxtBox.TabIndex = 11;
            this.PasswordTxtBox.TextChanged += new System.EventHandler(this.passwordTxtBox_TextChanged);
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Font = new System.Drawing.Font("Ageo Personal Use", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.Black;
            this.closeBtn.Location = new System.Drawing.Point(1347, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(21, 22);
            this.closeBtn.TabIndex = 12;
            this.closeBtn.Text = "X";
            this.closeBtn.Click += new System.EventHandler(this.label3_Click);
            // 
            // minimizedIcon
            // 
            this.minimizedIcon.BackColor = System.Drawing.Color.White;
            this.minimizedIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizedIcon.Font = new System.Drawing.Font("Ageo Personal Use", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizedIcon.ForeColor = System.Drawing.Color.Black;
            this.minimizedIcon.Location = new System.Drawing.Point(1318, -7);
            this.minimizedIcon.Name = "minimizedIcon";
            this.minimizedIcon.Size = new System.Drawing.Size(24, 39);
            this.minimizedIcon.TabIndex = 13;
            this.minimizedIcon.Text = "_";
            this.minimizedIcon.Click += new System.EventHandler(this.minimizedIcon_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(945, 515);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(97, 36);
            this.loginBtn.TabIndex = 14;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ageo Personal Use Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label3.Location = new System.Drawing.Point(985, 565);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "or";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            this.dataSet1BindingSource.CurrentChanged += new System.EventHandler(this.dataSet1BindingSource_CurrentChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Ageo Personal Use", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::LeXus.Properties.Resources.vectorArt;
            this.label1.Location = new System.Drawing.Point(78, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 380);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // furnitureArt
            // 
            this.furnitureArt.BackColor = System.Drawing.Color.White;
            this.furnitureArt.Font = new System.Drawing.Font("Ageo Personal Use", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureArt.ForeColor = System.Drawing.Color.White;
            this.furnitureArt.Image = global::LeXus.Properties.Resources.icon_bg_01;
            this.furnitureArt.Location = new System.Drawing.Point(609, -2);
            this.furnitureArt.Name = "furnitureArt";
            this.furnitureArt.Size = new System.Drawing.Size(788, 968);
            this.furnitureArt.TabIndex = 5;
            this.furnitureArt.Click += new System.EventHandler(this.furnitureArt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.button1.Location = new System.Drawing.Point(945, 597);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "SIGN IN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1380, 890);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.minimizedIcon);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsernameTxtBox);
            this.Controls.Add(this.brokenLine1);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.containerForm);
            this.Controls.Add(this.description);
            this.Controls.Add(this.projectName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.furnitureArt);
            this.Controls.Add(this.sideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeXus";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label projectName;
        private Label label1;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Label description;
        private Label sideBar;
        private Label containerForm;
        private Label usernameTxt;
        private Label passwordTxt;
        private Label brokenLine1;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
            
        private Label label2;
        private TextBox UsernameTxtBox;
        private TextBox PasswordTxtBox;
        private Label closeBtn;

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Label minimizedIcon;

        private void minimizedIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private Button loginBtn;
        private Label label3;


        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTxtBox.Text;
            string user_password = PasswordTxtBox.Text;

            string connectionString = "Data Source=JLOMBLERO\\SQLEXPRESS;Initial Catalog=LexusDB;Integrated Security=True;Encrypt=False";

            try
            {
                string query = "SELECT * FROM USERS WHERE Username = @Username AND Password = @password";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", user_password); // Consider using hashed passwords

                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dtable = new DataTable();
                            sda.Fill(dtable);

                            if (dtable.Rows.Count > 0)
                            {
                                Dashboard page = new Dashboard();

                                // Call the FillUserInfoGrid method
                                page.LoadUserData();

                                page.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                UsernameTxtBox.Clear();
                                PasswordTxtBox.Clear();
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        private BindingSource dataSet1BindingSource;
        private IContainer components;
        private DataSet1 dataSet1;


        private void containerForm_Click(object sender, EventArgs e)
        {

        }

        private void passwordTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void furnitureArt_Click(object sender, EventArgs e)
        {

        }

        private void dataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private Label furnitureArt;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private Button button1;

        private void button1_Click(object sender, EventArgs e)
        {
            SignIn newWindow = new SignIn();
            newWindow.Show();
            this.Hide();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
