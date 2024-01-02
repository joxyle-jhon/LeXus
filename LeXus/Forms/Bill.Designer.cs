namespace LeXus.Forms
{
    partial class Bill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sideBar = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.logoutBtn = new FontAwesome.Sharp.IconButton();
            this.homeBtn = new FontAwesome.Sharp.IconButton();
            this.billBtn = new FontAwesome.Sharp.IconButton();
            this.projectName = new System.Windows.Forms.Label();
            this.propertyBtn = new FontAwesome.Sharp.IconButton();
            this.leaseBtn = new FontAwesome.Sharp.IconButton();
            this.minimizedIcon = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DueDateTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PaymentTypeTxtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PropertyIDTxtBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.InvoiceIDTxtBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.AmmountTxtBox = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.DatePaidTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PaymentStatusTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chnageInfoTxt = new System.Windows.Forms.Label();
            this.InvoiceGrid = new System.Windows.Forms.DataGridView();
            this.ViewDataBtn = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.sideBar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.sideBar.Controls.Add(this.iconButton1);
            this.sideBar.Controls.Add(this.logoutBtn);
            this.sideBar.Controls.Add(this.homeBtn);
            this.sideBar.Controls.Add(this.billBtn);
            this.sideBar.Controls.Add(this.projectName);
            this.sideBar.Controls.Add(this.propertyBtn);
            this.sideBar.Controls.Add(this.leaseBtn);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(283, 890);
            this.sideBar.TabIndex = 191;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 43;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(3, 399);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(280, 53);
            this.iconButton1.TabIndex = 193;
            this.iconButton1.Text = "Agreement";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.logoutBtn.IconColor = System.Drawing.Color.White;
            this.logoutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoutBtn.IconSize = 43;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(0, 825);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.logoutBtn.Size = new System.Drawing.Size(280, 53);
            this.logoutBtn.TabIndex = 191;
            this.logoutBtn.Text = "    Logout";
            this.logoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutBtn.UseVisualStyleBackColor = false;
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.IconChar = FontAwesome.Sharp.IconChar.House;
            this.homeBtn.IconColor = System.Drawing.Color.White;
            this.homeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(3, 115);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.homeBtn.Size = new System.Drawing.Size(283, 53);
            this.homeBtn.TabIndex = 190;
            this.homeBtn.Text = "  Home";
            this.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // billBtn
            // 
            this.billBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.billBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.billBtn.FlatAppearance.BorderSize = 0;
            this.billBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billBtn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billBtn.ForeColor = System.Drawing.Color.White;
            this.billBtn.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.billBtn.IconColor = System.Drawing.Color.White;
            this.billBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.billBtn.IconSize = 43;
            this.billBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.billBtn.Location = new System.Drawing.Point(0, 335);
            this.billBtn.Name = "billBtn";
            this.billBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.billBtn.Size = new System.Drawing.Size(280, 53);
            this.billBtn.TabIndex = 189;
            this.billBtn.Text = "    Invoice";
            this.billBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.billBtn.UseVisualStyleBackColor = false;
            // 
            // projectName
            // 
            this.projectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.projectName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectName.Font = new System.Drawing.Font("Ageo Personal Use ExtBd", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.projectName.Location = new System.Drawing.Point(-3, 20);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(283, 76);
            this.projectName.TabIndex = 16;
            this.projectName.Text = "LeXus";
            this.projectName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // propertyBtn
            // 
            this.propertyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.propertyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.propertyBtn.FlatAppearance.BorderSize = 0;
            this.propertyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.propertyBtn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyBtn.ForeColor = System.Drawing.Color.White;
            this.propertyBtn.IconChar = FontAwesome.Sharp.IconChar.BuildingUser;
            this.propertyBtn.IconColor = System.Drawing.Color.White;
            this.propertyBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.propertyBtn.IconSize = 52;
            this.propertyBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.propertyBtn.Location = new System.Drawing.Point(3, 257);
            this.propertyBtn.Name = "propertyBtn";
            this.propertyBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.propertyBtn.Size = new System.Drawing.Size(280, 53);
            this.propertyBtn.TabIndex = 188;
            this.propertyBtn.Text = " Property";
            this.propertyBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.propertyBtn.UseVisualStyleBackColor = false;
            this.propertyBtn.Click += new System.EventHandler(this.propertyBtn_Click);
            // 
            // leaseBtn
            // 
            this.leaseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.leaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leaseBtn.FlatAppearance.BorderSize = 0;
            this.leaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaseBtn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaseBtn.ForeColor = System.Drawing.Color.White;
            this.leaseBtn.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.leaseBtn.IconColor = System.Drawing.Color.White;
            this.leaseBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.leaseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.leaseBtn.Location = new System.Drawing.Point(-3, 183);
            this.leaseBtn.Name = "leaseBtn";
            this.leaseBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.leaseBtn.Size = new System.Drawing.Size(283, 53);
            this.leaseBtn.TabIndex = 187;
            this.leaseBtn.Text = "  Lease";
            this.leaseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.leaseBtn.UseVisualStyleBackColor = false;
            this.leaseBtn.Click += new System.EventHandler(this.leaseBtn_Click);
            // 
            // minimizedIcon
            // 
            this.minimizedIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.minimizedIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizedIcon.Font = new System.Drawing.Font("Ageo Personal Use", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizedIcon.ForeColor = System.Drawing.Color.White;
            this.minimizedIcon.Location = new System.Drawing.Point(1318, -7);
            this.minimizedIcon.Name = "minimizedIcon";
            this.minimizedIcon.Size = new System.Drawing.Size(24, 39);
            this.minimizedIcon.TabIndex = 193;
            this.minimizedIcon.Text = "_";
            this.minimizedIcon.Click += new System.EventHandler(this.minimizedIcon_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Font = new System.Drawing.Font("Ageo Personal Use", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(1347, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(21, 22);
            this.closeBtn.TabIndex = 192;
            this.closeBtn.Text = "X";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(282, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1100, 43);
            this.label8.TabIndex = 194;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.panel3.Controls.Add(this.DueDateTxtBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.PaymentTypeTxtBox);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.PropertyIDTxtBox);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.InvoiceIDTxtBox);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.ClearBtn);
            this.panel3.Controls.Add(this.AddBtn);
            this.panel3.Controls.Add(this.AmmountTxtBox);
            this.panel3.Controls.Add(this.DeleteBtn);
            this.panel3.Controls.Add(this.SearchBtn);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.UpdateBtn);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.DatePaidTxtBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.PaymentStatusTxtBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.chnageInfoTxt);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.panel3.Location = new System.Drawing.Point(358, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(954, 358);
            this.panel3.TabIndex = 196;
            // 
            // DueDateTxtBox
            // 
            this.DueDateTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.DueDateTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DueDateTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDateTxtBox.ForeColor = System.Drawing.Color.White;
            this.DueDateTxtBox.Location = new System.Drawing.Point(356, 123);
            this.DueDateTxtBox.Name = "DueDateTxtBox";
            this.DueDateTxtBox.Size = new System.Drawing.Size(178, 19);
            this.DueDateTxtBox.TabIndex = 260;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label1.Location = new System.Drawing.Point(351, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 40);
            this.label1.TabIndex = 262;
            this.label1.Text = "_____________________________________________";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label2.Location = new System.Drawing.Point(352, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 261;
            this.label2.Text = "Due Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PaymentTypeTxtBox
            // 
            this.PaymentTypeTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.PaymentTypeTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PaymentTypeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentTypeTxtBox.ForeColor = System.Drawing.Color.White;
            this.PaymentTypeTxtBox.Location = new System.Drawing.Point(257, 210);
            this.PaymentTypeTxtBox.Name = "PaymentTypeTxtBox";
            this.PaymentTypeTxtBox.Size = new System.Drawing.Size(171, 19);
            this.PaymentTypeTxtBox.TabIndex = 251;
            this.PaymentTypeTxtBox.TextChanged += new System.EventHandler(this.PaymentTypeTxtBox_TextChanged);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label10.Location = new System.Drawing.Point(252, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 40);
            this.label10.TabIndex = 253;
            this.label10.Text = "_____________________________________________";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label11.Location = new System.Drawing.Point(253, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 25);
            this.label11.TabIndex = 252;
            this.label11.Text = "Payment Type";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // PropertyIDTxtBox
            // 
            this.PropertyIDTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.PropertyIDTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PropertyIDTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropertyIDTxtBox.ForeColor = System.Drawing.Color.White;
            this.PropertyIDTxtBox.Location = new System.Drawing.Point(48, 123);
            this.PropertyIDTxtBox.Name = "PropertyIDTxtBox";
            this.PropertyIDTxtBox.Size = new System.Drawing.Size(91, 19);
            this.PropertyIDTxtBox.TabIndex = 247;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.label14.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label14.Location = new System.Drawing.Point(43, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 40);
            this.label14.TabIndex = 249;
            this.label14.Text = "_____________________________________________";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.label15.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label15.Location = new System.Drawing.Point(44, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 25);
            this.label15.TabIndex = 248;
            this.label15.Text = "Property ID";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InvoiceIDTxtBox
            // 
            this.InvoiceIDTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.InvoiceIDTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InvoiceIDTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceIDTxtBox.ForeColor = System.Drawing.Color.White;
            this.InvoiceIDTxtBox.Location = new System.Drawing.Point(809, 42);
            this.InvoiceIDTxtBox.Name = "InvoiceIDTxtBox";
            this.InvoiceIDTxtBox.Size = new System.Drawing.Size(82, 19);
            this.InvoiceIDTxtBox.TabIndex = 244;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.label12.Location = new System.Drawing.Point(804, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 40);
            this.label12.TabIndex = 246;
            this.label12.Text = "_____________________________________________";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.label13.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.label13.Location = new System.Drawing.Point(804, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 25);
            this.label13.TabIndex = 245;
            this.label13.Text = "Invoice ID";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.ClearBtn.Location = new System.Drawing.Point(743, 270);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(148, 53);
            this.ClearBtn.TabIndex = 243;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.AddBtn.Location = new System.Drawing.Point(225, 270);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(148, 53);
            this.AddBtn.TabIndex = 242;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // AmmountTxtBox
            // 
            this.AmmountTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.AmmountTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AmmountTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmmountTxtBox.ForeColor = System.Drawing.Color.White;
            this.AmmountTxtBox.Location = new System.Drawing.Point(204, 123);
            this.AmmountTxtBox.Name = "AmmountTxtBox";
            this.AmmountTxtBox.Size = new System.Drawing.Size(88, 19);
            this.AmmountTxtBox.TabIndex = 183;
            this.AmmountTxtBox.TextChanged += new System.EventHandler(this.AmmountTxtBox_TextChanged);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.DeleteBtn.Location = new System.Drawing.Point(578, 270);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(148, 53);
            this.DeleteBtn.TabIndex = 241;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.SearchBtn.Location = new System.Drawing.Point(57, 270);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(148, 53);
            this.SearchBtn.TabIndex = 240;
            this.SearchBtn.Text = "Search ID";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label7.Location = new System.Drawing.Point(198, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 40);
            this.label7.TabIndex = 185;
            this.label7.Text = "_____________________________________________";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.UpdateBtn.Location = new System.Drawing.Point(403, 270);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(148, 53);
            this.UpdateBtn.TabIndex = 239;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label9.Location = new System.Drawing.Point(199, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 25);
            this.label9.TabIndex = 184;
            this.label9.Text = "Ammount";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // DatePaidTxtBox
            // 
            this.DatePaidTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.DatePaidTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatePaidTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePaidTxtBox.ForeColor = System.Drawing.Color.White;
            this.DatePaidTxtBox.Location = new System.Drawing.Point(583, 123);
            this.DatePaidTxtBox.Name = "DatePaidTxtBox";
            this.DatePaidTxtBox.Size = new System.Drawing.Size(196, 19);
            this.DatePaidTxtBox.TabIndex = 180;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label5.Location = new System.Drawing.Point(578, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 40);
            this.label5.TabIndex = 182;
            this.label5.Text = "_____________________________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label6.Location = new System.Drawing.Point(579, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 25);
            this.label6.TabIndex = 181;
            this.label6.Text = "Date Paid";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PaymentStatusTxtBox
            // 
            this.PaymentStatusTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.PaymentStatusTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PaymentStatusTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentStatusTxtBox.ForeColor = System.Drawing.Color.White;
            this.PaymentStatusTxtBox.Location = new System.Drawing.Point(48, 210);
            this.PaymentStatusTxtBox.Name = "PaymentStatusTxtBox";
            this.PaymentStatusTxtBox.Size = new System.Drawing.Size(171, 19);
            this.PaymentStatusTxtBox.TabIndex = 177;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label3.Location = new System.Drawing.Point(43, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 40);
            this.label3.TabIndex = 179;
            this.label3.Text = "_____________________________________________";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.label4.Location = new System.Drawing.Point(44, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 178;
            this.label4.Text = "Payment Status";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chnageInfoTxt
            // 
            this.chnageInfoTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.chnageInfoTxt.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chnageInfoTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.chnageInfoTxt.Location = new System.Drawing.Point(43, 13);
            this.chnageInfoTxt.Name = "chnageInfoTxt";
            this.chnageInfoTxt.Size = new System.Drawing.Size(105, 48);
            this.chnageInfoTxt.TabIndex = 173;
            this.chnageInfoTxt.Text = "Invoice";
            this.chnageInfoTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chnageInfoTxt.Click += new System.EventHandler(this.chnageInfoTxt_Click);
            // 
            // InvoiceGrid
            // 
            this.InvoiceGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InvoiceGrid.BackgroundColor = System.Drawing.Color.White;
            this.InvoiceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceGrid.Location = new System.Drawing.Point(358, 518);
            this.InvoiceGrid.Name = "InvoiceGrid";
            this.InvoiceGrid.Size = new System.Drawing.Size(954, 326);
            this.InvoiceGrid.TabIndex = 197;
            this.InvoiceGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InvoiceGrid_CellContentClick);
            // 
            // ViewDataBtn
            // 
            this.ViewDataBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ViewDataBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewDataBtn.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDataBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.ViewDataBtn.Location = new System.Drawing.Point(358, 479);
            this.ViewDataBtn.Name = "ViewDataBtn";
            this.ViewDataBtn.Size = new System.Drawing.Size(89, 36);
            this.ViewDataBtn.TabIndex = 230;
            this.ViewDataBtn.Text = "View Data";
            this.ViewDataBtn.UseVisualStyleBackColor = false;
            this.ViewDataBtn.Click += new System.EventHandler(this.ViewDataBtn_Click);
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.label25.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.label25.Location = new System.Drawing.Point(744, 2);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(207, 36);
            this.label25.TabIndex = 244;
            this.label25.Text = "Invoice";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 890);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.ViewDataBtn);
            this.Controls.Add(this.InvoiceGrid);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.minimizedIcon);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bills";
            this.Load += new System.EventHandler(this.Bills_Load);
            this.sideBar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sideBar;
        private FontAwesome.Sharp.IconButton logoutBtn;
        private FontAwesome.Sharp.IconButton homeBtn;
        private FontAwesome.Sharp.IconButton billBtn;
        private System.Windows.Forms.Label projectName;
        private FontAwesome.Sharp.IconButton propertyBtn;
        private FontAwesome.Sharp.IconButton leaseBtn;
        private System.Windows.Forms.Label minimizedIcon;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label chnageInfoTxt;
        private System.Windows.Forms.TextBox AmmountTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DatePaidTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PaymentStatusTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.TextBox InvoiceIDTxtBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PropertyIDTxtBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DueDateTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PaymentTypeTxtBox;
        private System.Windows.Forms.DataGridView InvoiceGrid;
        private System.Windows.Forms.Button ViewDataBtn;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label25;
    }
}