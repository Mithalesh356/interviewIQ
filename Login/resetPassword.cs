using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using login;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class resetPassword : Form
    {
     
        public   string e;
        public resetPassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnresetpass_Click(object sender, EventArgs e)
        {

            string msql=Select * from user_profile whrhe


            /*string msql = "select * from user_profile where email='" + txtemail.Text + "' ";
            try
            {
                MyConnect.cmd = new MySqlCommand(msql, MyConnect.conn);
                MyConnect.rd = MyConnect.cmd.ExecuteReader();

                resetPassword r = new resetPassword();
                r.e=txtemail.Text;

                if (MyConnect.rd.GetString(2).Equals(txtemail.Text))
                {
                    new setpassword().Show();
                    this.Hide();
                }

                MyConnect.rd.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show("Error "+ ex.Message);
            }*/
        }

        private void resetPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
