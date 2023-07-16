using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace login
{
    internal class MyConnect
    {
        public static MySqlConnection conn;
        public  static  MySqlCommand cmd;
       public static  MySqlDataReader rd;
        

        public void connect()
        {
            try
            {
                string server = "localhost";
                string password = "";
                string database = "cimage";
                string uid = "root";
                string constring = "server=" +server+";uid="+uid+";pwd="+password+";database="+database;
                conn = new MySqlConnection(constring);
                conn.Open();
                //MessageBox.Show("Connection is ready");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection is faild="+ex.Message);

            }
        }

    }
}
