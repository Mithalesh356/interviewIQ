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
    public partial class setpassword : Form
    {

        public setpassword()
        {
            InitializeComponent();
        }

        private void txtrenewpassword_Leave(object sender, EventArgs e)
        {
            if (txtrenewpassword.Text != txtnewpassword.Text)
            {
                txtrenewpassword.Focus();
                errorProvider1.SetError(this.txtrenewpassword, "doesn't match");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            resetPassword rp = new resetPassword();
            String msql = "update user_profile set password='" + txtnewpassword.Text + "'where email='" + rp.e + "'";
            try
            {
                MyConnect.cmd = new MySqlCommand(msql, MyConnect.conn);
                MyConnect.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

        }

        private void setpassword_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int c = random.Next(0, 255);
            BackColor= Color.Red;
        }
    }
}
