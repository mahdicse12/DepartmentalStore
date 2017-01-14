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
    public partial class Form_SSMS : Form
    {
        public Form_SSMS()
        {
            InitializeComponent();
            timer_SSMS.Enabled = true;
            timer_SSMS.Interval = 1000;
            autoincrement();
        }
        public void autoincrement() { 
            SqlConnection con11 = VariousMethods.CreateConnection();
            String query1 = "select * from SalesReport";
            SqlCommand cmd = new SqlCommand(query1, con11);
            SqlDataReader reader = cmd.ExecuteReader();
            int i = 1;
            while(reader.Read())
            {
                i++;
            }
            label_InvoiceNo.Text = Convert.ToString(i);
            con11.Close();
            
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {

            label_UserName.Text = Form_LogIn.un;
            label_Time.Text = System.DateTime.Now.ToLongTimeString();
            label_Date.Text = System.DateTime.Now.ToLongDateString();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (exitToolStripMenuItem.CanSelect == true)
            {

                DialogResult result = MessageBox.Show("Are you sure want to exit ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }

            }

        }

        private void button_AddItem_Click(object sender, EventArgs e)
        {
            Form_AddManageItem ami = new Form_AddManageItem();
            ami.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AboutBox ab = new Form_AboutBox();
            ab.Show();
        }

        private void button_EmployeeInformation_Click(object sender, EventArgs e)
        {
            Form_EmployeeInformation employee = new Form_EmployeeInformation();
            employee.Show();
        }

        private void button_PurchaseItem_Click(object sender, EventArgs e)
        {
            Form_PurchaseItem pi = new Form_PurchaseItem();
            pi.Show();
        }

        private void button_PurchaseReport_Click(object sender, EventArgs e)
        {
            Form_PurchaseReport pr = new Form_PurchaseReport();
            pr.Show();
        }

        
        private void button_CheckBalance_Click(object sender, EventArgs e)
        {
            Form_CurrentItemBalance cib = new Form_CurrentItemBalance();
            cib.Show();

        }

        private void button_Expenditure_Click(object sender, EventArgs e)
        {
            Form_ExpenditureRecite er = new Form_ExpenditureRecite();
            er.Show();
        }

        private void button_ItemSalesReport_Click(object sender, EventArgs e)
        {
            Form_ItemSalesReport isr = new Form_ItemSalesReport();
            isr.Show();
        }

        private void button_SalesReport_Click(object sender, EventArgs e)
        {
            Form_SalesReport sr = new Form_SalesReport();
            sr.Show();
        }

        private void ToolStripMenuItem_AddNewItem_Click(object sender, EventArgs e)
        {
            Form_AddManageItem ami = new Form_AddManageItem();
            ami.Show();
        }

        private void ToolStripMenuItem_CheckItemBalance_Click(object sender, EventArgs e)
        {
            Form_CurrentItemBalance cib = new Form_CurrentItemBalance();
            cib.Show();
        }

        private void ToolStripMenuItem_PurchaseAnItem_Click(object sender, EventArgs e)
        {
            Form_PurchaseItem pi = new Form_PurchaseItem();
            pi.Show();
        }

        private void ToolStripMenuItem_PurchaseReport_Click(object sender, EventArgs e)
        {
            Form_PurchaseReport pr = new Form_PurchaseReport();
            pr.Show();
        }

        private void ToolStripMenuItem_DateSalesReport_Click(object sender, EventArgs e)
        {
            Form_SalesReport sr = new Form_SalesReport();
            sr.Show();
        }

        private void ToolStripMenuItem_ItemSalesReport_Click(object sender, EventArgs e)
        {
            Form_ItemSalesReport isr = new Form_ItemSalesReport();
            isr.Show();
        }

        private void ToolStripMenuItem_BalanceSheet_Click(object sender, EventArgs e)
        {
            Form_BalanceSheet bs = new Form_BalanceSheet();
            bs.Show();
        }

        private void ToolStripMenuItem_EmployeeInformation_Click(object sender, EventArgs e)
        {
            Form_EmployeeInformation ei = new Form_EmployeeInformation();
            ei.Show();
        }

        private void ToolStripMenuItem_AddUser_Click(object sender, EventArgs e)
        {
            Form_AddUser au = new Form_AddUser();
            au.Show();
            this.Hide();
        }

        private void ToolStripMenuItem_EditUser_Click(object sender, EventArgs e)
        {
            Form_EditUser eu = new Form_EditUser();
            eu.Show();
            this.Hide();

        }

        private void textBox_ItemName_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con1 = VariousMethods.CreateConnection();
            String query1 = "select * from Item";
            SqlCommand cmd = new SqlCommand(query1, con1);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["ItemName"].ToString().Equals( textBox_ItemName.Text))
                {
                    
                    string icode = reader["ItemCode"].ToString();
                    string iname = reader["ItemName"].ToString();
                    string gname = reader["GroupName"].ToString();
                    string cname = reader["CompanyName"].ToString();
                    string iunit = reader["ItemUnit"].ToString();
                    string sprice = reader["SalePrice"].ToString();
                    string selfno = reader["SelfNo"].ToString();
                    string aq = reader["AvailableQuantity"].ToString();
                    label_IC.Text = icode;
                    label_IN.Text = iname;
                    label_GN.Text = gname;
                    label_CN.Text = cname;
                    label_IU.Text = iunit;
                    label_SN.Text = selfno;
                    label_AQ.Text = aq;
                    textBox_ItemSalePrice.Text = sprice;

                }

            }
            //if (a == 0)
            //    MessageBox.Show("Did not found!!");

            con1.Close();

        }

        private void textBox_ItemSaleQuantity_TextChanged(object sender, EventArgs e)
        {
            if(textBox_ItemSaleQuantity.Text == "")
            {

            }
            else if(Convert.ToDouble(textBox_ItemSaleQuantity.Text) <= Convert.ToDouble(label_AQ.Text))
            {
                string a = textBox_ItemSaleQuantity.Text;
                string b = textBox_ItemSalePrice.Text;
                
                try
                {
                    if (textBox_ItemSaleQuantity.Text != null)
                    {
                        textBox_ItemTotalPrice.Text = (Convert.ToDouble(a) * Convert.ToDouble(b)).ToString();
                    }
                    else
                    {
                        textBox_ItemTotalPrice.ResetText();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {

                DialogResult result = MessageBox.Show("Not Available Quantity", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (result == DialogResult.OK)
                {
                    textBox_ItemSaleQuantity.ResetText();
                    textBox_ItemTotalPrice.ResetText();
                }
            }
            
        }

        private void timer_SystemTime_Tick(object sender, EventArgs e)
        {
            label_Time.Text = DateTime.Now.ToLongTimeString();
        }

        
        VariousMethods vm = new VariousMethods();

        public double readQuantity(string itemcode)
        {
            SqlConnection con = VariousMethods.CreateConnection();
            String query = "SELECT * from Item Where ItemCode ='" + itemcode + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            String availablequantity = reader["AvailableQuantity"].ToString();
            double value = Convert.ToDouble(availablequantity);
            return value;
        }

        public double readPurchasePrice(string itemcode)
        {
            SqlConnection con = VariousMethods.CreateConnection();
            String query = "SELECT * from Item Where ItemCode ='" + itemcode + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            String pp = reader["PurchasePrice"].ToString();
            double r = Convert.ToDouble(pp);
            return r;
        }
        private void button_AddToInvoice_Click(object sender, EventArgs e)
        {
            string invno = label_InvoiceNo.Text;
            string icode = label_IC.Text;
            string isq = textBox_ItemSaleQuantity.Text;
            string pr = textBox_ItemSalePrice.Text;
            string tp = textBox_ItemTotalPrice.Text;
            double purchaseprice = readPurchasePrice(icode);
            double profit = (Convert.ToDouble(textBox_ItemSalePrice.Text) - Convert.ToDouble(purchaseprice))*Convert.ToDouble(textBox_ItemSaleQuantity.Text);

            string query = "INSERT into ItemSalesReport values('" + invno + "','" + icode + "','" + isq + "','" + pr + "','" + tp + "','" + profit + "')";
            vm.SaveInformation(query);


            double quantity = readQuantity(icode);
            quantity = quantity - Convert.ToDouble(isq);
            string q = "Update Item SET AvailableQuantity =    '" + quantity.ToString() + "' WHERE ItemCode = '" + icode + "' ";
            vm.SaveInformation(q);
            
            DialogResult result = MessageBox.Show("Item Has Been Added To Invoice Successfully .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {


                SqlConnection conn = VariousMethods.CreateConnection();
                
                String query1 = "SELECT InvoiceNo , ISR.ItemCode , ItemName , ItemUnit , ItemQuantity , PriceRate , TotalPrice from ItemSalesReport as ISR , Item as I Where ISR.ItemCode = I.ItemCode and InvoiceNo ='" + label_InvoiceNo.Text + "' ";
                SqlCommand cmd = new SqlCommand(query1, conn);
                    
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView_SSMS.DataSource = dt;
                    //conn.Close();
                     
                }
            }


            SqlConnection conne = VariousMethods.CreateConnection();
            string SQL = "SELECT sum(ItemQuantity) as TI from ItemSalesReport Where InvoiceNo ='" + label_InvoiceNo.Text + "' ";           
            using (SqlCommand command = new SqlCommand(SQL, conne))
            {
                label_TI.Text = command.ExecuteScalar().ToString() ;
            }
            conne.Close();

            SqlConnection conne1 = VariousMethods.CreateConnection();
            string SQL1 = "SELECT sum(TotalPrice) as TP from ItemSalesReport Where InvoiceNo ='" + label_InvoiceNo.Text + "' ";
            using (SqlCommand command = new SqlCommand(SQL1, conne1))
            {
                label_TP.Text = command.ExecuteScalar().ToString();
            }
            conne1.Close();

            
        }

        
        private void button_Payment_Click(object sender, EventArgs e)
        {
            string paid = textBox_Paid.Text;
            double cm = Convert.ToDouble(textBox_Paid.Text) - Convert.ToDouble(label_TP.Text);
            string salesDay = DateTime.Now.Day.ToString();
            string salesMonth = DateTime.Now.Month.ToString();
            string salesYear = DateTime.Now.Year.ToString();
            string salesTime = DateTime.Now.ToLongTimeString();


            string q = "INSERT into SalesReport values('" + label_InvoiceNo.Text + "','" + label_TI.Text + "','" + label_TP.Text + "','" + textBox_Paid.Text + "','" + cm + "','" + salesDay + "','" + salesMonth + "','" + salesYear + "','" + salesTime + "','" + label_UserName.Text + "')";
            vm.SaveInformation(q);

            MessageBox.Show("Payment Has Been Complete Successfully . Give The Change Ammount .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            autoincrement();

            label_TItem.Text = label_TI.Text;
            label_TotalP.Text = label_TP.Text;
            label_P.Text = textBox_Paid.Text;
            label_C.Text = cm.ToString();

            textBox_ItemName.ResetText();
            label_IC.ResetText();
            label_IN.ResetText();
            label_GN.ResetText();
            label_CN.ResetText();
            label_IU.ResetText();
            label_SN.ResetText();
            label_AQ.ResetText();
            textBox_ItemSalePrice.ResetText();
            textBox_ItemSaleQuantity.ResetText();
            label_TI.ResetText();
            label_TP.ResetText();
            textBox_ItemTotalPrice.ResetText();
            textBox_Paid.ResetText();

        }

        private void button_ExpenditureReport_Click(object sender, EventArgs e)
        {
            Form_ExpenditureReport fer = new Form_ExpenditureReport();
            fer.Show();
        }

        private void button_RefreshList_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = VariousMethods.CreateConnection();
            String query1 = "Delete from ItemSalesReport ";
            SqlCommand cmd = new SqlCommand(query1, con1);
            MessageBox.Show("Would you like to Delete this Information?", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            cmd.ExecuteNonQuery();
            textBox_ItemName.ResetText();
            label_IC.ResetText();
            label_IN.ResetText();
            label_GN.ResetText();
            label_CN.ResetText();
            label_IU.ResetText();
            label_SN.ResetText();
            label_AQ.ResetText();
            textBox_ItemSalePrice.ResetText();
            textBox_ItemSaleQuantity.ResetText();
            label_TI.ResetText();
            label_TP.ResetText();
            textBox_ItemTotalPrice.ResetText();
            textBox_Paid.ResetText();
            dataGridView_SSMS.Rows.Clear();
            

        }

        
        private void ToolStripMenuItem_ExpenditureRecite_Click(object sender, EventArgs e)
        {
            Form_ExpenditureRecite er = new Form_ExpenditureRecite();
            er.Show();
        }

        private void ToolStripMenuItem_ExpenditureReport_Click(object sender, EventArgs e)
        {
            Form_ExpenditureReport fer = new Form_ExpenditureReport();
            fer.Show();
        }

        private void button_BalanceSheet_Click(object sender, EventArgs e)
        {
            Form_BalanceSheet bs = new Form_BalanceSheet();
            bs.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

    }
}