using login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Login
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {

        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            string msql;

            msql = "insert into user_profile values('" + txtusername.Text + "','" + txtpassword.Text + "','" + txtemail.Text + "','" + txtmobile.Text + "')";

            try
            {
                MyConnect.cmd = new MySqlCommand(msql, MyConnect.conn);
                MyConnect.cmd.ExecuteNonQuery();
                MessageBox.Show("Sign up successful");
                new Form1().Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void linkLabelsigninpage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {


        }



        private void txtemail_Enter(object sender, EventArgs e)
        {

        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            string regx = "/^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\\.[a-zA-Z0-9-]+)*$/.";
            if (Regex.IsMatch(regx, txtemail.Text) == false)
            {
                txtemail.Focus();
                errorProvider1.SetError(this.txtemail, "Invalid Email");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            /*string reg = "^(?=.*[A - Z])(?=.*[!@#$&*])(?=.*[0-9])(?=.*[a-z]).{4}$";
            if (Regex.IsMatch(reg, txtpassword.Text) == false)
            {
                txtpassword.Focus();
                errorProvider1.SetError(this.txtpassword, "Uppercase,Lowercase,Number,Special Character");
            }
            else
            {
                txtpassword.Clear();
            }*/
        }

        private void txtconfirmpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text != txtconfirmpassword.Text)
            {

                errorProvider1.SetError(this.txtconfirmpassword, "Password is not identical!!!");
            }
            else
            {
                txtconfirmpassword.Clear();
            }
        }
    }
}
