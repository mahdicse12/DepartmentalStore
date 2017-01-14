using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentalStore
{
    public partial class Form_LogIn : Form
    {
        public static string un = "";
        VariousMethods vm = new VariousMethods();
        public Form_LogIn()
        {
            InitializeComponent();
        }

        
        private void button_LClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void button_Login_Click(object sender, EventArgs e)
        {
            string username = textBox_UserName.Text;
            string password = textBox_Password.Text;
            string query = "SELECT * from LogIn where UserName = '" + username + "'and Password ='" + password + "'";

            Boolean check = vm.Search(query);
            if (check)
            {
                un = textBox_UserName.Text;
                Form_SSMS m = new Form_SSMS();
                m.Show();
                this.Hide();
            }
            else if (username == "" || password == "")
            {
                DialogResult result = MessageBox.Show("Please Enter Username and Password And Try Again .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (!check)
            {
                DialogResult result = MessageBox.Show("Username And Password Don't Match . Please Try Again . .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_UserName.ResetText();
                textBox_Password.ResetText();
            }
        }


        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_AddUser su = new Form_AddUser();
            su.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserToolStripMenuItem_Edit_Click(object sender, EventArgs e)
        {
            Form_EditUser euser = new Form_EditUser();
            euser.Show();
            this.Hide();
        }

    }
}
