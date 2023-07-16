namespace Login
{
    partial class signup
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            txtuser = new TextBox();
            btnsignup = new Button();
            label1 = new Label();
            txtpass = new TextBox();
            label2 = new Label();
            panellogo = new Panel();
            label5 = new Label();
            panellogin = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            txtconfirmpassword = new TextBox();
            label8 = new Label();
            linkLabelsigninpage = new LinkLabel();
            label3 = new Label();
            btnsign = new Button();
            panel8 = new Panel();
            panel9 = new Panel();
            txtemail = new TextBox();
            label7 = new Label();
            panel2 = new Panel();
            panel6 = new Panel();
            txtmobile = new TextBox();
            label6 = new Label();
            panel5 = new Panel();
            panel7 = new Panel();
            txtpassword = new TextBox();
            p = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            txtusername = new TextBox();
            label = new Label();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            panellogo.SuspendLayout();
            panellogin.SuspendLayout();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(txtuser);
            groupBox1.Controls.Add(btnsignup);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtpass);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(616, 220);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(380, 229);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtuser
            // 
            txtuser.Location = new Point(99, 44);
            txtuser.Margin = new Padding(3, 2, 3, 2);
            txtuser.Multiline = true;
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(175, 34);
            txtuser.TabIndex = 9;
            // 
            // btnsignup
            // 
            btnsignup.Location = new Point(250, 182);
            btnsignup.Margin = new Padding(3, 2, 3, 2);
            btnsignup.Name = "btnsignup";
            btnsignup.Size = new Size(66, 30);
            btnsignup.TabIndex = 11;
            btnsignup.Text = "Sign Up";
            btnsignup.UseVisualStyleBackColor = true;
            btnsignup.Click += btnsignup_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 17);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 7;
            label1.Text = "User Name : ";
            // 
            // txtpass
            // 
            txtpass.Location = new Point(99, 130);
            txtpass.Margin = new Padding(3, 2, 3, 2);
            txtpass.Multiline = true;
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(175, 32);
            txtpass.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 102);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 8;
            label2.Text = "Password : ";
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
            panellogo.Size = new Size(608, 38);
            panellogo.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(153, 9);
            label5.Name = "label5";
            label5.Size = new Size(282, 30);
            label5.TabIndex = 0;
            label5.Text = "Welcome To Sign Up Page";
            // 
            // panellogin
            // 
            panellogin.Controls.Add(panel10);
            panellogin.Controls.Add(linkLabelsigninpage);
            panellogin.Controls.Add(label3);
            panellogin.Controls.Add(btnsign);
            panellogin.Controls.Add(panel8);
            panellogin.Controls.Add(panel2);
            panellogin.Controls.Add(panel5);
            panellogin.Controls.Add(panel3);
            panellogin.Controls.Add(panel1);
            panellogin.Dock = DockStyle.Fill;
            panellogin.ForeColor = SystemColors.Control;
            panellogin.Location = new Point(0, 38);
            panellogin.Margin = new Padding(3, 2, 3, 2);
            panellogin.Name = "panellogin";
            panellogin.Size = new Size(608, 537);
            panellogin.TabIndex = 9;
            // 
            // panel10
            // 
            panel10.Controls.Add(panel11);
            panel10.Controls.Add(txtconfirmpassword);
            panel10.Controls.Add(label8);
            panel10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel10.ForeColor = SystemColors.GrayText;
            panel10.Location = new Point(36, 148);
            panel10.Margin = new Padding(3, 2, 3, 2);
            panel10.Name = "panel10";
            panel10.Size = new Size(521, 53);
            panel10.TabIndex = 26;
            // 
            // panel11
            // 
            panel11.BackColor = Color.White;
            panel11.Location = new Point(151, 40);
            panel11.Margin = new Padding(3, 2, 3, 2);
            panel11.Name = "panel11";
            panel11.Size = new Size(359, 1);
            panel11.TabIndex = 11;
            // 
            // txtconfirmpassword
            // 
            txtconfirmpassword.BackColor = Color.Black;
            txtconfirmpassword.BorderStyle = BorderStyle.None;
            txtconfirmpassword.Enabled = false;
            txtconfirmpassword.ForeColor = SystemColors.WindowFrame;
            txtconfirmpassword.ImeMode = ImeMode.NoControl;
            txtconfirmpassword.Location = new Point(151, 14);
            txtconfirmpassword.Margin = new Padding(3, 2, 3, 2);
            txtconfirmpassword.Multiline = true;
            txtconfirmpassword.Name = "txtconfirmpassword";
            txtconfirmpassword.PlaceholderText = "Confirm Password";
            txtconfirmpassword.Size = new Size(359, 26);
            txtconfirmpassword.TabIndex = 8;
            txtconfirmpassword.Leave += txtconfirmpassword_Leave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(3, 19);
            label8.Name = "label8";
            label8.Size = new Size(143, 19);
            label8.TabIndex = 7;
            label8.Text = "Confirm Password : ";
            // 
            // linkLabelsigninpage
            // 
            linkLabelsigninpage.AutoSize = true;
            linkLabelsigninpage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabelsigninpage.LinkColor = Color.FromArgb(0, 192, 0);
            linkLabelsigninpage.Location = new Point(284, 403);
            linkLabelsigninpage.Name = "linkLabelsigninpage";
            linkLabelsigninpage.Size = new Size(54, 19);
            linkLabelsigninpage.TabIndex = 25;
            linkLabelsigninpage.TabStop = true;
            linkLabelsigninpage.Text = "Sign In";
            linkLabelsigninpage.LinkClicked += linkLabelsigninpage_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 407);
            label3.Name = "label3";
            label3.Size = new Size(141, 15);
            label3.TabIndex = 24;
            label3.Text = "I have already an account";
            // 
            // btnsign
            // 
            btnsign.FlatAppearance.BorderColor = Color.Red;
            btnsign.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnsign.FlatStyle = FlatStyle.Flat;
            btnsign.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnsign.Location = new Point(116, 371);
            btnsign.Margin = new Padding(3, 2, 3, 2);
            btnsign.Name = "btnsign";
            btnsign.Size = new Size(341, 30);
            btnsign.TabIndex = 23;
            btnsign.Text = "Sign Up";
            btnsign.UseVisualStyleBackColor = true;
            btnsign.Click += btnsign_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(txtemail);
            panel8.Controls.Add(label7);
            panel8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel8.ForeColor = SystemColors.GrayText;
            panel8.Location = new Point(36, 273);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(521, 53);
            panel8.TabIndex = 22;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Location = new Point(151, 40);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(359, 1);
            panel9.TabIndex = 11;
            // 
            // txtemail
            // 
            txtemail.BackColor = Color.Black;
            txtemail.BorderStyle = BorderStyle.None;
            txtemail.ForeColor = SystemColors.WindowFrame;
            txtemail.Location = new Point(151, 14);
            txtemail.Margin = new Padding(3, 2, 3, 2);
            txtemail.Multiline = true;
            txtemail.Name = "txtemail";
            txtemail.PlaceholderText = "Enter Email";
            txtemail.Size = new Size(359, 26);
            txtemail.TabIndex = 8;
            txtemail.TextChanged += txtemail_TextChanged;
            txtemail.Enter += txtemail_Enter;
            txtemail.Leave += txtemail_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(51, 17);
            label7.Name = "label7";
            label7.Size = new Size(57, 19);
            label7.TabIndex = 7;
            label7.Text = "Email : ";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(txtmobile);
            panel2.Controls.Add(label6);
            panel2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.ForeColor = SystemColors.GrayText;
            panel2.Location = new Point(36, 207);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(521, 53);
            panel2.TabIndex = 21;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(151, 40);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(359, 1);
            panel6.TabIndex = 11;
            // 
            // txtmobile
            // 
            txtmobile.BackColor = Color.Black;
            txtmobile.BorderStyle = BorderStyle.None;
            txtmobile.ForeColor = SystemColors.WindowFrame;
            txtmobile.Location = new Point(151, 14);
            txtmobile.Margin = new Padding(3, 2, 3, 2);
            txtmobile.Multiline = true;
            txtmobile.Name = "txtmobile";
            txtmobile.PlaceholderText = "Enter Mobile no";
            txtmobile.Size = new Size(359, 26);
            txtmobile.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(51, 17);
            label6.Name = "label6";
            label6.Size = new Size(72, 19);
            label6.TabIndex = 7;
            label6.Text = "Mobile  : ";
            // 
            // panel5
            // 
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(txtpassword);
            panel5.Controls.Add(p);
            panel5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel5.ForeColor = SystemColors.GrayText;
            panel5.Location = new Point(36, 86);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(521, 53);
            panel5.TabIndex = 20;
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
            // txtpassword
            // 
            txtpassword.BackColor = Color.Black;
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.ForeColor = SystemColors.WindowFrame;
            txtpassword.Location = new Point(151, 14);
            txtpassword.Margin = new Padding(3, 2, 3, 2);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.PlaceholderText = "Password";
            txtpassword.Size = new Size(359, 26);
            txtpassword.TabIndex = 8;
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
            panel3.Location = new Point(362, 200);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(219, 1);
            panel3.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(txtusername);
            panel1.Controls.Add(label);
            panel1.Location = new Point(36, 23);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(521, 52);
            panel1.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(452, 45);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 1;
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
            // txtusername
            // 
            txtusername.BackColor = Color.Black;
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtusername.ForeColor = SystemColors.GrayText;
            txtusername.Location = new Point(158, 15);
            txtusername.Margin = new Padding(3, 2, 3, 2);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.PlaceholderText = "Enter user name";
            txtusername.Size = new Size(359, 26);
            txtusername.TabIndex = 8;
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
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(608, 575);
            Controls.Add(panellogin);
            Controls.Add(panellogo);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "signup";
            Text = "signup";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panellogo.ResumeLayout(false);
            panellogo.PerformLayout();
            panellogin.ResumeLayout(false);
            panellogin.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtuser;
        private Button btnsignup;
        private Label label1;
        private TextBox txtpass;
        private Label label2;
        private Panel panellogo;
        private Label label5;
        private Panel panellogin;
        private Panel panel8;
        private Panel panel9;
        private TextBox txtemail;
        private Label label7;
        private Panel panel2;
        private Panel panel6;
        private TextBox txtmobile;
        private Label label6;
        private Panel panel5;
        private Panel panel7;
        private TextBox txtpassword;
        private Label p;
        private Panel panel3;
        private Panel panel1;
        private Label label4;
        private Panel panel4;
        private TextBox txtusername;
        private Label label;
        private Button btnsign;
        private LinkLabel linkLabelsigninpage;
        private Label label3;
        private ErrorProvider errorProvider1;
        private Panel panel10;
        private Panel panel11;
        private TextBox txtconfirmpassword;
        private Label label8;
    }
}