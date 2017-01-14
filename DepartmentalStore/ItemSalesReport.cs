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
    public partial class Form_ItemSalesReport : Form
    {
        public Form_ItemSalesReport()
        {
            InitializeComponent();
        }

        VariousMethods vm = new VariousMethods();
        private void button_INView_Click(object sender, EventArgs e)
        {
            SqlConnection conn = VariousMethods.CreateConnection();

            String query = "select InvoiceNo , ISR.ItemCode , I.ItemName , I.ItemUnit , ISR.ItemQuantity , ISR.PriceRate , ISR.TotalPrice , ISR.Profit from ItemSalesReport ISR , Item I WHERE ISR.ItemCode = I.ItemCode and ItemName ='" + textBox_IN.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView_ISR.DataSource = dt;
            }
        }

        private void button_CalculateTotal_Click(object sender, EventArgs e)
        {
            if (textBox_IN.Text == "")
            {
                SqlConnection conne = VariousMethods.CreateConnection();
                string SQL = "SELECT sum(ItemQuantity) as TI from ItemSalesReport ISR, Item I Where ISR.ItemCode = I.ItemCode ";
                using (SqlCommand command = new SqlCommand(SQL, conne))
                {
                    label_TI.Text = command.ExecuteScalar().ToString();
                }
                conne.Close();

                SqlConnection conne1 = VariousMethods.CreateConnection();
                string SQL1 = "SELECT sum(TotalPrice) as TP from ItemSalesReport ISR, Item I Where ISR.ItemCode = I.ItemCode ";
                using (SqlCommand command = new SqlCommand(SQL1, conne1))
                {
                    label_TP.Text = command.ExecuteScalar().ToString();
                }
                conne1.Close();

                SqlConnection conne2 = VariousMethods.CreateConnection();
                string SQL2 = "SELECT sum(Profit) as TotalProfit from ItemSalesReport ISR, Item I Where ISR.ItemCode = I.ItemCode ";
                using (SqlCommand command = new SqlCommand(SQL2, conne2))
                {
                    label_TotalProfit.Text = command.ExecuteScalar().ToString();
                }
                conne2.Close();
 
            }
            else 
            {
                SqlConnection conne = VariousMethods.CreateConnection();
                string SQL = "SELECT sum(ItemQuantity) as TI from ItemSalesReport ISR, Item I Where ISR.ItemCode = I.ItemCode and ItemName ='" + textBox_IN.Text + "' ";
                using (SqlCommand command = new SqlCommand(SQL, conne))
                {
                    label_TI.Text = command.ExecuteScalar().ToString();
                }
                conne.Close();

                SqlConnection conne1 = VariousMethods.CreateConnection();
                string SQL1 = "SELECT sum(TotalPrice) as TP from ItemSalesReport ISR, Item I Where ISR.ItemCode = I.ItemCode and ItemName ='" + textBox_IN.Text + "' ";
                using (SqlCommand command = new SqlCommand(SQL1, conne1))
                {
                    label_TP.Text = command.ExecuteScalar().ToString();
                }
                conne1.Close();

                SqlConnection conne2 = VariousMethods.CreateConnection();
                string SQL2 = "SELECT sum(Profit) as TotalProfit from ItemSalesReport ISR, Item I Where ISR.ItemCode = I.ItemCode and ItemName ='" + textBox_IN.Text + "' ";
                using (SqlCommand command = new SqlCommand(SQL2, conne2))
                {
                    label_TotalProfit.Text = command.ExecuteScalar().ToString();
                }
                conne2.Close();
 
            }
            
        }

        
        private void Form_ItemSalesReport_Load(object sender, EventArgs e)
        {
            SqlConnection conn = VariousMethods.CreateConnection();

            String query = "select InvoiceNo , ISR.ItemCode , I.ItemName , I.ItemUnit , ISR.ItemQuantity , ISR.PriceRate , ISR.TotalPrice , ISR.Profit from ItemSalesReport ISR , Item I WHERE ISR.ItemCode = I.ItemCode ";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView_ISR.DataSource = dt;
            }

        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            textBox_IN.ResetText();

            SqlConnection conn = VariousMethods.CreateConnection();

            String query = "select InvoiceNo , ISR.ItemCode , I.ItemName , I.ItemUnit , ISR.ItemQuantity , ISR.PriceRate , ISR.TotalPrice , ISR.Profit from ItemSalesReport ISR , Item I WHERE ISR.ItemCode = I.ItemCode ";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView_ISR.DataSource = dt;
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
