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
    public partial class Form_PurchaseItem : Form
    {
        public Form_PurchaseItem()
        {
            InitializeComponent();
        }

        VariousMethods vm = new VariousMethods();

        private void button_View_Click(object sender, EventArgs e)
        {
            int a = 0;
            SqlConnection con1 = VariousMethods.CreateConnection();
            String query1 = "select * from Item";
            SqlCommand cmd = new SqlCommand(query1, con1);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["ItemCode"].ToString().Equals(textBox_IC.Text) || reader["ItemName"].ToString().Equals(textBox_IN.Text))
                {
                    string icode = reader["ItemCode"].ToString();
                    string iname = reader["ItemName"].ToString();
                    string gname = reader["GroupName"].ToString();
                    string cname = reader["CompanyName"].ToString();
                    string pprice = reader["PurchasePrice"].ToString();
                    string iunit = reader["ItemUnit"].ToString();
                    string sprice = reader["SalePrice"].ToString();
                    string selfno = reader["SelfNo"].ToString();
                    
                    textBox_ItemCode.Text = "" + icode;
                    textBox_ItemName.Text = "" + iname;
                    textBox_GroupName.Text = "" + gname;
                    textBox_CompanyName.Text = "" + cname;
                    textBox_PurchasePrice.Text = "" + pprice;
                    comboBox_ItemUnit.Text = "" + iunit;
                    textBox_SelfNo.Text = "" + selfno;
                    
                    a++;

                }

            }


            if (a == 0)
                MessageBox.Show("Did not found!!");

            con1.Close();

        }

        
        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_SSMS ssms = new Form_SSMS();
            ssms.Show();
        }

        
        private void textBox_PurchaseQuantity_TextChanged(object sender, EventArgs e)
        {
            string a = textBox_PurchaseQuantity.Text;
            string b = textBox_PurchasePrice.Text;
            try
            {
                if (textBox_PurchaseQuantity.Text != null)
                {
                    textBox_TotalPrice.Text = (Convert.ToDouble(a) * Convert.ToDouble(b)).ToString();
                }
                else
                {
                    textBox_TotalPrice.ResetText();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        public double readQuantity(string itemcode)
        {
            SqlConnection con=VariousMethods.CreateConnection();
            String query = "SELECT * from Item Where ItemCode ='" + itemcode + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            String availablequantity = reader["AvailableQuantity"].ToString();
            double value = Convert.ToDouble(availablequantity);
            return value;
        }
        
        private void button_Purchase_Click(object sender, EventArgs e)
        {

            string icode = textBox_ItemCode.Text;
            string pprice = textBox_PurchasePrice.Text;
            string pquantity = textBox_PurchaseQuantity.Text;
            string tprice = textBox_TotalPrice.Text;
            string pday = comboBox_Day.Text;
            string pmonth = comboBox_Month.Text;
            string pyear = comboBox_Year.Text;
            DialogResult result = MessageBox.Show("Would you like to save this Information?", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            
            if (result == DialogResult.Yes)
            {
                if (icode != "" && pprice != "" && pquantity != "" && tprice != "" && pday != "" && pmonth != "" && pyear != "" )
                {
                    
                    
                    string query = "INSERT into Purchase values('" + icode + "','" + pprice + "','" + pquantity + "','" + tprice + "','" + pday + "','" + pmonth + "','" + pyear +  "')";
                    
                    vm.SaveInformation(query);

                    MessageBox.Show("Purchased Successfully .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    double quantity=readQuantity(icode);
                    quantity = quantity + Convert.ToDouble(pquantity);
                    string query1 = "Update Item SET AvailableQuantity =    '"+ quantity.ToString() +"' WHERE ItemCode = '" + icode + "' ";
                    vm.SaveInformation(query1);
                    

                }

            }

        }
    }
}
