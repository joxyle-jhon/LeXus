namespace LeXus.Forms
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.minimizedIcon = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sideBar = new System.Windows.Forms.Panel();
            this.logoutBtn = new FontAwesome.Sharp.IconButton();
            this.homeBtn = new FontAwesome.Sharp.IconButton();
            this.billBtn = new FontAwesome.Sharp.IconButton();
            this.projectName = new System.Windows.Forms.Label();
            this.propertyBtn = new FontAwesome.Sharp.IconButton();
            this.leaseBtn = new FontAwesome.Sharp.IconButton();
            this.DashBoardView = new System.Windows.Forms.DataGridView();
            this.ViewData = new System.Windows.Forms.Button();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.furnitureArt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashBoardView)).BeginInit();
            this.SuspendLayout();
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
            this.minimizedIcon.TabIndex = 192;
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
            this.closeBtn.TabIndex = 191;
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
            this.label8.TabIndex = 193;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
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
            this.sideBar.TabIndex = 194;
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
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
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
            this.billBtn.Click += new System.EventHandler(this.billBtn_Click);
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
            this.leaseBtn.Location = new System.Drawing.Point(0, 183);
            this.leaseBtn.Name = "leaseBtn";
            this.leaseBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.leaseBtn.Size = new System.Drawing.Size(283, 53);
            this.leaseBtn.TabIndex = 187;
            this.leaseBtn.Text = "  Lease";
            this.leaseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.leaseBtn.UseVisualStyleBackColor = false;
            this.leaseBtn.Click += new System.EventHandler(this.leaseBtn_Click);
            // 
            // DashBoardView
            // 
            this.DashBoardView.BackgroundColor = System.Drawing.Color.White;
            this.DashBoardView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DashBoardView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DashBoardView.DefaultCellStyle = dataGridViewCellStyle2;
            this.DashBoardView.GridColor = System.Drawing.Color.White;
            this.DashBoardView.Location = new System.Drawing.Point(308, 146);
            this.DashBoardView.Name = "DashBoardView";
            this.DashBoardView.Size = new System.Drawing.Size(1034, 633);
            this.DashBoardView.TabIndex = 195;
            this.DashBoardView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ViewData
            // 
            this.ViewData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ViewData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewData.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.ViewData.Location = new System.Drawing.Point(308, 90);
            this.ViewData.Name = "ViewData";
            this.ViewData.Size = new System.Drawing.Size(89, 36);
            this.ViewData.TabIndex = 234;
            this.ViewData.Text = "View Data";
            this.ViewData.UseVisualStyleBackColor = false;
            this.ViewData.Click += new System.EventHandler(this.ViewData_Click);
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
            this.iconButton1.TabIndex = 235;
            this.iconButton1.Text = "Agreement";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // furnitureArt
            // 
            this.furnitureArt.BackColor = System.Drawing.Color.White;
            this.furnitureArt.Font = new System.Drawing.Font("Ageo Personal Use", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureArt.ForeColor = System.Drawing.Color.White;
            this.furnitureArt.Image = global::LeXus.Properties.Resources.icon_bg_01;
            this.furnitureArt.Location = new System.Drawing.Point(283, 171);
            this.furnitureArt.Name = "furnitureArt";
            this.furnitureArt.Size = new System.Drawing.Size(788, 968);
            this.furnitureArt.TabIndex = 236;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Ageo Personal Use", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::LeXus.Properties.Resources.icon_bg_01;
            this.label1.Location = new System.Drawing.Point(1077, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(788, 968);
            this.label1.TabIndex = 237;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.label11.Location = new System.Drawing.Point(703, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(207, 36);
            this.label11.TabIndex = 238;
            this.label11.Text = "Dashboard";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 890);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.ViewData);
            this.Controls.Add(this.DashBoardView);
            this.Controls.Add(this.minimizedIcon);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.furnitureArt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.sideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DashBoardView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minimizedIcon;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel sideBar;
        private FontAwesome.Sharp.IconButton logoutBtn;
        private FontAwesome.Sharp.IconButton homeBtn;
        private FontAwesome.Sharp.IconButton billBtn;
        private System.Windows.Forms.Label projectName;
        private FontAwesome.Sharp.IconButton propertyBtn;
        private FontAwesome.Sharp.IconButton leaseBtn;
        private System.Windows.Forms.DataGridView DashBoardView;
        private System.Windows.Forms.Button ViewData;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label furnitureArt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
    }
}