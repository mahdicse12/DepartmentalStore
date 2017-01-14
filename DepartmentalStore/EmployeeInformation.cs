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
    public partial class Form_EmployeeInformation : Form
    {
        public Form_EmployeeInformation()
        {
            InitializeComponent();       
        }

        VariousMethods vm = new VariousMethods();

        private void button_InsertInformation_Click(object sender, EventArgs e)
        {
            string eid = textBox_EI.Text;
            string ename = textBox_EN.Text;
            string etype = comboBox_ET.Text;
            int eage = Convert.ToInt32(textBox_EA.Text);
            string ejoin = dateTimePicker_JD.Text;
            string eaddress = richTextBox_Address.Text;
            string esalary = textBox_ES.Text;
            string econtact = textBox_CN.Text;

            DialogResult result = MessageBox.Show("Would you like to save this Information?", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                
            if ( result == DialogResult.Yes ) 
            {
                if (eid != "" && ename != "" && eage >= 21 && eage <= 65)
                {        
                    
                    string query = "INSERT INTO Employee VALUES('" + eid + "','" + ename + "','" + etype + "','" + eage + "','" + ejoin + "','" + eaddress + "','" + esalary + "','" + econtact + "')";
                    vm.SaveInformation(query);

                    MessageBox.Show("Employee Information Insert Successfully .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBox_EN.ResetText();
                    textBox_EI.ResetText();
                    comboBox_ET.ResetText();
                    textBox_EA.ResetText();
                    dateTimePicker_JD.ResetText();
                    richTextBox_Address.ResetText();
                    textBox_ES.ResetText();
                    textBox_CN.ResetText();
                }

            }
            else if (eage >= 65 || eage <= 21)
            {
                MessageBox.Show("Input Correct Age");
            }
            else
            {
                MessageBox.Show("Something Missing.");
            }

                
        }

        private void button_EmployeeSearch_Click(object sender, EventArgs e)
        {
            int match = 0;
            SqlConnection con1 = VariousMethods.CreateConnection();
            String query1 = "select EmployeeID from Employee";
            SqlCommand cmd = new SqlCommand(query1, con1);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["EmployeeID"].ToString() == textBox_EmployeeID.Text)
                {
                    match = 1;
                    break;
                }

            }

            con1.Close();
            if (match == 1)
            {
                if (textBox_EmployeeID.Text == "")
                {
                    MessageBox.Show("Did not match Employee Id");
                }
                else
                {
                    SqlConnection conn = VariousMethods.CreateConnection();
                    String query = "select * from Employee WHERE EmployeeID='" + textBox_EmployeeID.Text + "' ";
                    SqlDataAdapter ad = new SqlDataAdapter(query, conn);
                    DataTable ds = new DataTable();
                    ad.Fill(ds);
                    dataGridView_EmployeeInformation.DataSource = ds;
                }
            }
            else
            {
                MessageBox.Show("Did not match Employee Id");
            }
        }

        private void button_DeleteInformation_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = VariousMethods.CreateConnection();
            String query1 = "Delete from Employee where EmployeeID = '" + textBox_EmployeeID.Text + "'";
            SqlCommand cmd = new SqlCommand(query1, con1);
            MessageBox.Show("Would you like to Delete this Information?", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            cmd.ExecuteNonQuery();
            dataGridView_EmployeeInformation.Refresh();
        }

        private void textBox_ES_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            int a = 0;
            SqlConnection con1 = VariousMethods.CreateConnection();
            String query1 = "select * from Employee";
            SqlCommand cmd = new SqlCommand(query1, con1);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["EmployeeID"].ToString() == textBox_EmployeeID.Text)
                {
                    string name = reader["EmployeeName"].ToString();
                    int id = Convert.ToInt32(reader["EmployeeID"].ToString());
                    string type = reader["EmployeeType"].ToString();
                    int age = Convert.ToInt32(reader["EmployeeAge"].ToString());
                    string join = reader["EmployeeJoiningDate"].ToString();
                    string address = reader["EmployeeAddress"].ToString();
                    string salary = reader["EmployeeSalary"].ToString();
                    string phone = reader["EmployeeContactNo"].ToString();
                    textBox_EN.Text = "" + name;
                    textBox_EI.Text = "" + id;
                    comboBox_ET.Text = "" + type;
                    textBox_EA.Text = "" + age;
                    dateTimePicker_JD.Text = "" + join;
                    richTextBox_Address.Text = "" + address;
                    textBox_ES.Text = "" + salary;
                    textBox_CN.Text = "" + phone;
                    a++;

                }
               
            }
            if(a ==0 )
            {
                MessageBox.Show("Did not found!!");  

            }
                            
            con1.Close();

        }

        private void button_UpdateInformation_Click(object sender, EventArgs e)
        {
            string eid = textBox_EN.Text;
            string ename = textBox_EI.Text;
            string etype = comboBox_ET.Text;
            string eage = textBox_EA.Text;
            string ejoin = dateTimePicker_JD.Text;
            string eaddress = richTextBox_Address.Text;
            string esalary = textBox_ES.Text;
            string econtact = textBox_CN.Text;

            DialogResult result = MessageBox.Show("Would you like to Update this Information?", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                if (eid != "" && ename != "")
                {
                    string query = "UPDATE Employee SET EmployeeName='" + eid + "', EmployeeID='" + ename + "', EmployeeType='" + etype + "', EmployeeAge='" + eage + "', EmployeeJoiningDate ='" + ejoin + "', EmployeeAddress = '" + eaddress + "', EmployeeSalary='" + esalary + "', EmployeeContactNo='" + econtact + "' where EmployeeID = '" + ename + "'";
                    vm.SaveInformation(query);

                    MessageBox.Show("Employee Information Updated Successfully .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBox_EN.ResetText();
                    textBox_EI.ResetText();
                    comboBox_ET.ResetText();
                    textBox_EA.ResetText();
                    dateTimePicker_JD.ResetText();
                    richTextBox_Address.ResetText();
                    textBox_ES.ResetText();
                    textBox_CN.ResetText();

                }

            }
            else
            {
                MessageBox.Show("Something Missing");
            }
        }

    }
}
