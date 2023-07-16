namespace Login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnlogin = new Button();
            linksignup = new LinkLabel();
            linkforgetpassword = new LinkLabel();
            panellogo = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            panellogin = new Panel();
            label2 = new Label();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel5 = new Panel();
            chkshowpassword = new CheckBox();
            panel7 = new Panel();
            pictureBox2 = new PictureBox();
            txtpassword = new TextBox();
            p = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            txtusername = new TextBox();
            label = new Label();
            label4 = new Label();
            fontDialog1 = new FontDialog();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            panellogo.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panellogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // btnlogin
            // 
            btnlogin.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnlogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnlogin.Location = new Point(340, 347);
            btnlogin.Margin = new Padding(3, 2, 3, 2);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(159, 30);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // linksignup
            // 
            linksignup.AutoSize = true;
            linksignup.LinkColor = Color.Yellow;
            linksignup.Location = new Point(356, 390);
            linksignup.Name = "linksignup";
            linksignup.Size = new Size(116, 15);
            linksignup.TabIndex = 8;
            linksignup.TabStop = true;
            linksignup.Text = "Create New Account";
            linksignup.LinkClicked += linksignup_LinkClicked;
            // 
            // linkforgetpassword
            // 
            linkforgetpassword.AutoSize = true;
            linkforgetpassword.LinkColor = Color.Yellow;
            linkforgetpassword.Location = new Point(151, 43);
            linkforgetpassword.Name = "linkforgetpassword";
            linkforgetpassword.Size = new Size(103, 15);
            linkforgetpassword.TabIndex = 6;
            linkforgetpassword.TabStop = true;
            linkforgetpassword.Text = "Forgot Password ?";
            linkforgetpassword.LinkClicked += linkforgetpassword_LinkClicked;
            // 
            // panellogo
            // 
            panellogo.BackColor = Color.FromArgb(12, 75, 97);
            panellogo.Controls.Add(label5);
            panellogo.Dock = DockStyle.Top;
            panellogo.Location = new Point(0, 0);
            panellogo.Margin = new Padding(3, 2, 3, 2);
            panellogo.Name = "panellogo";
            panellogo.Padding = new Padding(4);
            panellogo.Size = new Size(1058, 38);
            panellogo.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(382, 7);
            label5.Name = "label5";
            label5.Size = new Size(258, 30);
            label5.TabIndex = 0;
            label5.Text = "Welcome To Login Page";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(12, 75, 97);
            panel2.Controls.Add(pictureBox3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 38);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(461, 489);
            panel2.TabIndex = 7;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Left;
            pictureBox3.Image = Properties.Resources._278972890;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(461, 489);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panellogin
            // 
            panellogin.Controls.Add(label2);
            panellogin.Controls.Add(pictureBox7);
            panellogin.Controls.Add(pictureBox6);
            panellogin.Controls.Add(pictureBox4);
            panellogin.Controls.Add(linksignup);
            panellogin.Controls.Add(panel5);
            panellogin.Controls.Add(panel3);
            panellogin.Controls.Add(panel1);
            panellogin.Controls.Add(label4);
            panellogin.Controls.Add(btnlogin);
            panellogin.Dock = DockStyle.Fill;
            panellogin.ForeColor = SystemColors.Control;
            panellogin.Location = new Point(461, 38);
            panellogin.Margin = new Padding(3, 2, 3, 2);
            panellogin.Name = "panellogin";
            panellogin.Size = new Size(597, 489);
            panellogin.TabIndex = 8;
            panellogin.Paint += panellogin_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(304, 448);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 16;
            label2.Text = "Login  via  ";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources._5a22b43e909176_0984090415122238065922;
            pictureBox7.Location = new Point(392, 425);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(45, 33);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 15;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources._5a3550d6b9a7f5_4237508715134435427605;
            pictureBox6.Location = new Point(454, 425);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(53, 40);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.kisspng_google_account_google_search_customer_service_goog_login_button_5acdd8deb0ea94_8977932715234398387247;
            pictureBox4.Location = new Point(214, 50);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(101, 82);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(chkshowpassword);
            panel5.Controls.Add(linkforgetpassword);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(txtpassword);
            panel5.Controls.Add(p);
            panel5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel5.ForeColor = SystemColors.GrayText;
            panel5.Location = new Point(31, 260);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(521, 73);
            panel5.TabIndex = 11;
            // 
            // chkshowpassword
            // 
            chkshowpassword.AutoSize = true;
            chkshowpassword.ForeColor = SystemColors.ButtonHighlight;
            chkshowpassword.Location = new Point(454, 11);
            chkshowpassword.Margin = new Padding(3, 2, 3, 2);
            chkshowpassword.Name = "chkshowpassword";
            chkshowpassword.Size = new Size(56, 19);
            chkshowpassword.TabIndex = 12;
            chkshowpassword.Text = "Show";
            chkshowpassword.UseVisualStyleBackColor = true;
            chkshowpassword.CheckedChanged += chkshowpassword_CheckedChanged;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(151, 40);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(359, 1);
            panel7.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.lock_gadcfa3e08_1280;
            pictureBox2.Location = new Point(4, 11);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.Black;
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.ForeColor = SystemColors.WindowFrame;
            txtpassword.Location = new Point(151, 14);
            txtpassword.Margin = new Padding(3, 2, 3, 2);
            txtpassword.Name = "txtpassword";
            txtpassword.PlaceholderText = "Password";
            txtpassword.Size = new Size(359, 16);
            txtpassword.TabIndex = 8;
            txtpassword.UseSystemPasswordChar = true;
            txtpassword.Leave += txtpassword_Leave;
            // 
            // p
            // 
            p.AutoSize = true;
            p.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            p.ForeColor = SystemColors.ButtonFace;
            p.Location = new Point(51, 17);
            p.Name = "p";
            p.Size = new Size(85, 19);
            p.TabIndex = 7;
            p.Text = "Password : ";
            // 
            // panel3
            // 
            panel3.Location = new Point(158, 274);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(219, 1);
            panel3.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtusername);
            panel1.Controls.Add(label);
            panel1.Location = new Point(31, 181);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(521, 73);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(452, 45);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(151, 40);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(359, 1);
            panel4.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.avatar_gf4a389cf3_1280;
            pictureBox1.Location = new Point(4, 12);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.Black;
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtusername.ForeColor = SystemColors.GrayText;
            txtusername.Location = new Point(149, 17);
            txtusername.Margin = new Padding(3, 2, 3, 2);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.PlaceholderText = "Enter user name";
            txtusername.Size = new Size(359, 26);
            txtusername.TabIndex = 8;
            txtusername.Leave += txtusername_Leave;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label.Location = new Point(51, 17);
            label.Name = "label";
            label.Size = new Size(92, 19);
            label.TabIndex = 7;
            label.Text = "User name : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(234, 14);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 6;
            label4.Text = "Login";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 10, 5);
            ClientSize = new Size(1058, 527);
            Controls.Add(panellogin);
            Controls.Add(panel2);
            Controls.Add(panellogo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panellogo.ResumeLayout(false);
            panellogo.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panellogin.ResumeLayout(false);
            panellogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Button btnlogin;
        private GroupBox groupBox1;
        private LinkLabel linkforgetpassword;
        private Label label3;
        private LinkLabel linksignup;
        private Panel panellogo;
        private Panel panel2;
        private Panel panellogin;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label;
        private Label label4;
        private Panel panel4;
        private Panel panel3;
        private FontDialog fontDialog1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Panel panel5;
        private Panel panel7;
        private PictureBox pictureBox2;
        private TextBox textBox2;
        private Label p;
        private Label label5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private CheckBox chkshowpassword;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}