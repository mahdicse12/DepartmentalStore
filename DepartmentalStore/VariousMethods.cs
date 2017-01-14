using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentalStore
{
    class VariousMethods
    {
        public static SqlConnection CreateConnection()
        {
            string ConnString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mahdi\Documents\Visual Studio 2013\Projects\DepartmentalStore\DepartmentalStore\Departmental Store.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection Conn = new SqlConnection(ConnString);
            Conn.Open();
            return Conn;
        }
        public void disconnect(SqlConnection conn)
        {
            conn.Close();
        }


        public Boolean Search(string a)
        {
            int sh = 0;
            SqlConnection conn = VariousMethods.CreateConnection();
            SqlCommand cmd = new SqlCommand(a, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            sh = dt.Rows.Count;
            if (sh != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SaveInformation(string query)
        {
            try
            {
                SqlConnection Conn = VariousMethods.CreateConnection();
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.ExecuteNonQuery();
                Conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void NotChar(System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Input between 0-9 from numeric keypad");
            }
        }

        public void NotInt(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 65 || e.KeyChar > 122) && e.KeyChar != 8 && e.KeyChar != 43 && e.KeyChar != 45 && e.KeyChar != 46 && e.KeyChar != 32)
            {
                e.Handled = true;
                MessageBox.Show("Please Press Alphabet From Keyboard");
            }
        }
        public void tk(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Input Numeric Number In Taka");
            }
        }


    }
}
