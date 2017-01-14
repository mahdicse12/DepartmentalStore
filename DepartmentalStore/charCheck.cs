using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentalStore
{
    class charCheck
    {
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
