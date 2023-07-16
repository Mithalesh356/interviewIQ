namespace Login
{
    partial class resetPassword
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
            panel1 = new Panel();
            btnresetpass = new Button();
            txtemail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnresetpass);
            panel1.Controls.Add(txtemail);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(102, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(658, 312);
            panel1.TabIndex = 0;
            // 
            // btnresetpass
            // 
            btnresetpass.BackColor = Color.FromArgb(12, 75, 97);
            btnresetpass.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnresetpass.ForeColor = SystemColors.ButtonHighlight;
            btnresetpass.Location = new Point(158, 176);
            btnresetpass.Name = "btnresetpass";
            btnresetpass.Size = new Size(297, 49);
            btnresetpass.TabIndex = 4;
            btnresetpass.Text = "Reset My Password";
            btnresetpass.UseVisualStyleBackColor = false;
            btnresetpass.Click += btnresetpass_Click;
            // 
            // txtemail
            // 
            txtemail.BackColor = SystemColors.InactiveCaption;
            txtemail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtemail.ForeColor = SystemColors.WindowFrame;
            txtemail.Location = new Point(74, 99);
            txtemail.Multiline = true;
            txtemail.Name = "txtemail";
            txtemail.PlaceholderText = "Enter your Email";
            txtemail.Size = new Size(502, 44);
            txtemail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(12, 75, 97);
            label2.Location = new Point(167, 28);
            label2.Name = "label2";
            label2.Size = new Size(235, 38);
            label2.TabIndex = 2;
            label2.Text = "Forgot Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(222, 25);
            label1.Name = "label1";
            label1.Size = new Size(358, 46);
            label1.TabIndex = 1;
            label1.Text = "Reset Password Form";
            label1.Click += label1_Click;
            // 
            // resetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 75, 97);
            ClientSize = new Size(952, 609);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "resetPassword";
            Text = "resetPassword";
            Load += resetPassword_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox txtemail;
        private Button btnresetpass;
    }
}