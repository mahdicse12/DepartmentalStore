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
    public partial class Form_EditUser : Form
    {
        public Form_EditUser()
        {
            InitializeComponent();
        }

        VariousMethods vm = new VariousMethods();
        private void button_DeleteUser_Click(object sender, EventArgs e)
        {
            String username = textBox_UN.Text;

            SqlConnection con1 = VariousMethods.CreateConnection();
            DialogResult result = MessageBox.Show("Would you like to Delete this User?", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                String query1 = "Delete from LogIn where UserName = '" + textBox_UN.Text + "'";
                SqlCommand cmd = new SqlCommand(query1, con1);
                cmd.ExecuteNonQuery();
                DialogResult r =MessageBox.Show("Deleted Successfully .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if( r == DialogResult.OK)
                {
                    Form_LogIn l = new Form_LogIn();
                    l.Show();
                    this.Close();
                }
            }
        }

        private void button_ChangePassword_Click(object sender, EventArgs e)
        {
            String un = textBox_UserName.Text;
            String op = textBox_OldPassword.Text;
            String np = textBox_NewPassword.Text;
            
            SqlConnection con1 = VariousMethods.CreateConnection();
            String query1 = "select * from LogIn";
            SqlCommand cmd = new SqlCommand(query1, con1);
            SqlDataReader reader = cmd.ExecuteReader();
            
            if (un == "" || op == "" || np == "")
            {        
                MessageBox.Show("Put corrrect user name and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //textBox_UserName.ResetText();
                //textBox_OldPassword.ResetText();
                //textBox_NewPassword.ResetText();
            }
            else
            {
                DialogResult result = MessageBox.Show("Would you like to Change Password?", "Save Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                        
                    while(reader.Read())
                    {

                        if (reader["UserName"].ToString() == un && reader["Password"].ToString() == op)
                        {
                            String query = "UPDATE LogIn SET UserName='" + un + "', Password='" + np + "' where UserName = '" + un + "'";
                            vm.SaveInformation(query);

                            MessageBox.Show("Password Changed Successfully .", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form_SSMS ssms = new Form_SSMS();
                            ssms.Show();
                            this.Close();
                            //textBox_UserName.ResetText();
                            //textBox_OldPassword.ResetText();
                            //textBox_NewPassword.ResetText();


                        }
                    }
                    
                }

            }

        }
    }
}
