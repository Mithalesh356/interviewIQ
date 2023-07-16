using login;
using MySql.Data.MySqlClient;
using System.Threading;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyConnect myConnect = new MyConnect();
            myConnect.connect();
            string unm, pnm, msql;
            unm = txtusername.Text;
            pnm = txtpassword.Text;
            msql = "select * from user_profile where sname='" + unm + "'";

            try
            {
                MyConnect.cmd = new MySqlCommand(msql);
                MyConnect.rd = MyConnect.cmd.ExecuteReader();
                if (MyConnect.rd.GetString(1).Equals(txtusername.Text))
                {
                    txtpassword.Text = MyConnect.rd.GetString(2);
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
        private void linksignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new signup().Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtpassword.Text) == true)
            {
                txtpassword.Focus();
                errorProvider2.SetError(this.txtpassword, "Please enter password");
            }
            else if (String.IsNullOrEmpty(txtusername.Text) == true)
            {
                txtusername.Focus();
                errorProvider1.SetError(this.txtusername, "Please Enter UserName");
            }
            else
            {
                string unm, pnm, msql;
                unm = txtusername.Text;
                pnm = txtpassword.Text;
                msql = "select * from user_profile where sname='" + unm + "'";

                try
                {
                    MyConnect.cmd = new MySqlCommand(msql, MyConnect.conn);
                    MyConnect.rd = MyConnect.cmd.ExecuteReader();

                    if (MyConnect.rd.Read())
                    {
                        if (MyConnect.rd.GetString(1).Equals(pnm))
                        {
                            // MessageBox.Show("Login Success");
                            this.Hide();
                            new loginsucessful().Show();
                            
                            
                            

                        }
                        else
                        {
                            MessageBox.Show("Invalid password");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Wrong Username");
                    }

                    MyConnect.rd.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }


        }

        private void panelinvalidpassword_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkforgetpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new resetPassword().Show();
            this.Hide();

        }

        private void panellogin_Paint(object sender, PaintEventArgs e)
        {
           
        }
        private void chkshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            bool check = chkshowpassword.Checked;
            if (check)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }
        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtusername.Text) == true)
            {
                txtusername.Focus();
                errorProvider1.SetError(this.txtusername,"please enter username!!!!!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtpassword.Text) == true)
            {
                txtpassword.Focus();
                errorProvider2.SetError(this.txtpassword, "Please enter password");
            }
            else
            {
                errorProvider2.Clear();
            }
        }
    }
}