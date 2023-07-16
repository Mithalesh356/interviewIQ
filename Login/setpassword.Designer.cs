namespace Login
{
    partial class setpassword
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
            label1 = new Label();
            panel1 = new Panel();
            txtrenewpassword = new TextBox();
            btnsubmit = new Button();
            txtnewpassword = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(191, 38);
            label1.Name = "label1";
            label1.Size = new Size(322, 46);
            label1.TabIndex = 3;
            label1.Text = "Set Your Password ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtrenewpassword);
            panel1.Controls.Add(btnsubmit);
            panel1.Controls.Add(txtnewpassword);
            panel1.Location = new Point(71, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(658, 312);
            panel1.TabIndex = 2;
            // 
            // txtrenewpassword
            // 
            txtrenewpassword.BackColor = SystemColors.InactiveCaption;
            txtrenewpassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtrenewpassword.ForeColor = SystemColors.WindowFrame;
            txtrenewpassword.Location = new Point(69, 114);
            txtrenewpassword.Multiline = true;
            txtrenewpassword.Name = "txtrenewpassword";
            txtrenewpassword.PlaceholderText = "Re-enter New Password";
            txtrenewpassword.Size = new Size(502, 44);
            txtrenewpassword.TabIndex = 5;
            txtrenewpassword.TextAlign = HorizontalAlignment.Center;
            txtrenewpassword.Leave += txtrenewpassword_Leave;
            // 
            // btnsubmit
            // 
            btnsubmit.BackColor = Color.FromArgb(12, 75, 97);
            btnsubmit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnsubmit.ForeColor = SystemColors.ButtonHighlight;
            btnsubmit.Location = new Point(165, 198);
            btnsubmit.Name = "btnsubmit";
            btnsubmit.Size = new Size(297, 49);
            btnsubmit.TabIndex = 4;
            btnsubmit.Text = "Submit";
            btnsubmit.UseVisualStyleBackColor = false;
            btnsubmit.Click += btnsubmit_Click;
            // 
            // txtnewpassword
            // 
            txtnewpassword.BackColor = SystemColors.InactiveCaption;
            txtnewpassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtnewpassword.ForeColor = Color.FloralWhite;
            txtnewpassword.Location = new Point(69, 28);
            txtnewpassword.Multiline = true;
            txtnewpassword.Name = "txtnewpassword";
            txtnewpassword.PlaceholderText = "Enter new Password";
            txtnewpassword.ScrollBars = ScrollBars.Horizontal;
            txtnewpassword.Size = new Size(502, 44);
            txtnewpassword.TabIndex = 3;
            txtnewpassword.TextAlign = HorizontalAlignment.Center;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // setpassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 75, 97);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "setpassword";
            Text = "setpassword";
            Load += setpassword_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnsubmit;
        private TextBox txtnewpassword;
        private TextBox txtrenewpassword;
        private ErrorProvider errorProvider1;
    }
}