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
    public partial class Form_AddUser : Form
    {
        public Form_AddUser()
        {
            InitializeComponent();
        }

        VariousMethods vm = new VariousMethods();
        private void button_AddUser_Click(object sender, EventArgs e)
        {
            String mc = "142035";
            String uname = textBox_UserName.Text;
            String pass = textBox_Password.Text;
            String cpass = textBox_ConformPassword.Text;
            String suc = textBox_AdminCode.Text;

            DialogResult result = MessageBox.Show("Would you like to Add this User!!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (uname != "" && pass != "" && cpass != "" && pass == cpass && mc == suc)
                {

                    String query = "INSERT INTO LogIn VALUES('" + uname + "','" + pass + "')";
                    vm.SaveInformation(query);

                    textBox_UserName.ResetText();
                    textBox_Password.ResetText();
                    textBox_ConformPassword.ResetText();
                    textBox_AdminCode.ResetText();

                    Form_LogIn li = new Form_LogIn();
                    li.Show();

                    this.Close();

                }

                else
                {
                    DialogResult r = MessageBox.Show("Invalid Info", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

                    if (r == DialogResult.Retry)
                    {
                        textBox_UserName.ResetText();
                        textBox_Password.ResetText();
                        textBox_ConformPassword.ResetText();
                        textBox_AdminCode.ResetText();

                    }
                    else if (r == DialogResult.Cancel)
                    {
                        Form_LogIn l = new Form_LogIn();
                        l.Show();
                        this.Close();
                    }
                }
                
            }
            
        }
        

        private void button_LClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_LogIn li = new Form_LogIn();
            li.Show();
        }

        private void groupBox_SignUp_Enter(object sender, EventArgs e)
        {

        }

        private void Form_AddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
