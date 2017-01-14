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
    public partial class Form_AddManageItem : Form
    {
        public Form_AddManageItem()
        {
            InitializeComponent();
        }

        VariousMethods vm = new VariousMethods();


        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_SSMS m = new Form_SSMS();
            m.Show();
        }

        private void button_InsertInformation_Click(object sender, EventArgs e)
        {
            string icode = textBox_ItemCode.Text;
            string iname = textBox_ItemName.Text;
            string gname = textBox_GroupName.Text;
            string cname = textBox_CompanyName.Text;
            string pprice = textBox_PurchasePrice.Text;
            string iunit = comboBox_ItemUnit.Text;
            string sprice = textBox_SalePrice.Text;
            string selfno = comboBox_SelfNo.Text;
            double aq =  0;
            
            //Save data into item table
            DialogResult result = MessageBox.Show("Would you like to save this Information?", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if(result == DialogResult.Yes)
            {
                if (icode != "" && iname != "" && pprice != "" && iunit != "" && sprice != "")
                {
                    string query = "INSERT into Item values('" + icode + "','" + iname + "','" + gname + "','" + cname + "','" + pprice + "','" + iunit + "','" + sprice + "','" + selfno + "','"+aq+"')";
                    vm.SaveInformation(query);

                    MessageBox.Show("Item Has Been Inserted Successfully .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBox_ItemCode.ResetText();
                    textBox_ItemName.ResetText();
                    textBox_GroupName.ResetText();
                    textBox_CompanyName.ResetText();
                    textBox_PurchasePrice.ResetText();
                    comboBox_ItemUnit.SelectedIndex = -1;
                    textBox_SalePrice.ResetText();
                    comboBox_SelfNo.SelectedIndex = -1;
                    //label_profit.ResetText();

                }

            }
            
            else
            {
                MessageBox.Show("Something Missing");
            }
        }

        
        private void button_ICSearch_Click(object sender, EventArgs e)
        {
            int match = 0;
            SqlConnection con1 = VariousMethods.CreateConnection();
            String query1 = "select ItemCode from Item";
            SqlCommand cmd = new SqlCommand(query1, con1);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["ItemCode"].ToString() == textBox_IC.Text)
                {
                    match = 1;
                    break;
                }

            }

            con1.Close();
            if (match == 1)
            {
                if (textBox_IC.Text == "")
                {
                    MessageBox.Show("Please Input Item Code");
                }
                else
                {
                    SqlConnection conn = VariousMethods.CreateConnection();
                    String query = "select * from Item where ItemCode='" + textBox_IC.Text + "' ";
                    SqlDataAdapter ad = new SqlDataAdapter(query, conn);
                    DataTable ds = new DataTable();
                    ad.Fill(ds);
                    dataGridView_AddManageItem.DataSource = ds;
                }
            }
            else
            {
                MessageBox.Show("Did Not Match Item Code");
            }
        }

        private void button_INSearch_Click(object sender, EventArgs e)
        {
            int match = 0;
            SqlConnection con1 = VariousMethods.CreateConnection();
            String query1 = "select ItemName from Item";
            SqlCommand cmd = new SqlCommand(query1, con1);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["ItemName"].ToString() == textBox_IN.Text)
                {
                    match = 1;
                    break;
                }

            }

            con1.Close();
            if (match == 1)
            {
                if (textBox_IN.Text == "")
                {
                    MessageBox.Show("Please Input Item Name");
                }
                else
                {
                    SqlConnection conn = VariousMethods.CreateConnection();
                    String query = "select * from Item where ItemName='" + textBox_IN.Text + "' ";
                    SqlDataAdapter ad = new SqlDataAdapter(query, conn);
                    DataTable ds = new DataTable();
                    ad.Fill(ds);
                    dataGridView_AddManageItem.DataSource = ds;
                }
            }
            else
            {
                MessageBox.Show("Did Not Match Item Name");
            }
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            dataGridView_AddManageItem.Refresh();
        }

        private void button_UpdateInformation_Click(object sender, EventArgs e)
        {
            string icode = textBox_ItemCode.Text;
            string iname = textBox_ItemName.Text;
            string gname = textBox_GroupName.Text;
            string cname = textBox_CompanyName.Text;
            string pprice = textBox_PurchasePrice.Text;
            string iunit = comboBox_ItemUnit.Text;
            string sprice = textBox_SalePrice.Text;
            string selfno = comboBox_SelfNo.Text;

            if (icode != "" && iname != "")
            {
                DialogResult result = MessageBox.Show("Would you like to Update this Information?", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if ( result == DialogResult.Yes )
                {
                    string query = "UPDATE Item SET ItemCode='" + icode + "', ItemName='" + iname + "', GroupName='" + gname + "', CompanyName='" + cname + "', PurchasePrice='" + pprice + "', ItemUnit = '" + iunit + "', SalePrice='" + sprice + "', SelfNo='" + selfno + "' where ItemCode='" + icode + "'";
                   
                    vm.SaveInformation(query);

                    MessageBox.Show("Item Has Been Updated Successfully .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_ItemCode.ResetText();
                    textBox_ItemName.ResetText();
                    textBox_GroupName.ResetText();
                    textBox_CompanyName.ResetText();
                    textBox_PurchasePrice.ResetText();
                    comboBox_ItemUnit.SelectedIndex = -1;
                    textBox_SalePrice.ResetText();
                    comboBox_SelfNo.SelectedIndex = -1;

                }

            }
            else
            {
                MessageBox.Show("Something Missing");
            }
        }

        private void button_UpdateByIC_Click(object sender, EventArgs e)
        {
            int a = 0;
            SqlConnection con1 = VariousMethods.CreateConnection();
            String query1 = "select * from Item";
            SqlCommand cmd = new SqlCommand(query1, con1);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["ItemCode"].ToString() == textBox_IC.Text)
                {

                    string icode = reader["ItemCode"].ToString();
                    string iname = reader["ItemName"].ToString();
                    string gname = reader["GroupName"].ToString();
                    string cname = reader["CompanyName"].ToString();
                    string pprice = reader["PurchasePrice"].ToString();
                    string iunit= reader["ItemUnit"].ToString();
                    string sprice = reader["SalePrice"].ToString();
                    string selfno = reader["SelfNo"].ToString();
                    textBox_ItemCode.Text = icode;
                    textBox_ItemName.Text = iname;
                    textBox_GroupName.Text = gname;
                    textBox_CompanyName.Text = cname;
                    textBox_PurchasePrice.Text = pprice;
                    comboBox_ItemUnit.Text = iunit;
                    textBox_SalePrice.Text = sprice;
                    comboBox_SelfNo.Text = selfno;
                    a++;

                }

            }
            if (a == 0)
                MessageBox.Show("Did not found!!");

            con1.Close();

        }

        private void button_UpdateByIN_Click(object sender, EventArgs e)
        {
            int a = 0;
            SqlConnection con1 = VariousMethods.CreateConnection();
            String query1 = "select * from Item";
            SqlCommand cmd = new SqlCommand(query1, con1);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["ItemName"].ToString() == textBox_IN.Text)
                {

                    string icode = reader["ItemCode"].ToString();
                    string iname = reader["ItemName"].ToString();
                    string gname = reader["GroupName"].ToString();
                    string cname = reader["CompanyName"].ToString();
                    string pprice = reader["PurchasePrice"].ToString();
                    string iunit = reader["ItemUnit"].ToString();
                    string sprice = reader["SalePrice"].ToString();
                    string selfno = reader["SelfNo"].ToString();
                    textBox_ItemCode.Text = icode;
                    textBox_ItemName.Text = iname;
                    textBox_GroupName.Text = gname;
                    textBox_CompanyName.Text = cname;
                    textBox_PurchasePrice.Text = pprice;
                    comboBox_ItemUnit.Text = iunit;
                    textBox_SalePrice.Text = sprice;
                    comboBox_SelfNo.Text = selfno;
                    a++;

                }

            }
            if (a == 0)
                MessageBox.Show("Did not found!!");

            con1.Close();
        }

        private void button_DeleteByIC_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like to Delete this Information?", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if( result == DialogResult.Yes )
            {
                SqlConnection con1 = VariousMethods.CreateConnection();
                String query1 = "Delete from Item where ItemCode = '" + textBox_IC.Text + "'";
                SqlCommand cmd = new SqlCommand(query1, con1);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                dataGridView_AddManageItem.Refresh();
                dataGridView_AddManageItem.Parent.Refresh();

            }
            
        }

        private void button_DeleteByIN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like to Delete this Information?", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                SqlConnection con1 = VariousMethods.CreateConnection();
                String query1 = "Delete from Item where ItemName = '" + textBox_IN.Text + "'";
                SqlCommand cmd = new SqlCommand(query1, con1);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                dataGridView_AddManageItem.Refresh();
                dataGridView_AddManageItem.Parent.Refresh();

            }
        }

    }
}
