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
    public partial class Form_BalanceSheet : Form
    {
        public Form_BalanceSheet()
        {
            InitializeComponent();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_View_Click(object sender, EventArgs e)
        {
            if (comboBox_Day.Text != "" && comboBox_Month.Text != "" && comboBox_Year.Text != "")
            {

                SqlConnection conne1 = VariousMethods.CreateConnection();
                string query = "SELECT sum(TotalPrice) as TP from Purchase Where PurchaseDay = '" + comboBox_Day.Text + "' and PurchaseMonth = '" + comboBox_Month.Text + "' and PurchaseYear = '" + comboBox_Year.Text + "'";
                using (SqlCommand command = new SqlCommand(query, conne1))
                {
                    label_TP.Text = command.ExecuteScalar().ToString();
                }
                conne1.Close();

                SqlConnection conne = VariousMethods.CreateConnection();
                string SQL1 = "SELECT sum(TotalPrice) as TP from SalesReport Where SalesDay = '" + comboBox_Day.Text + "' and SalesMonth = '" + comboBox_Month.Text + "' and SalesYear = '" + comboBox_Year.Text + "'";
                using (SqlCommand command = new SqlCommand(SQL1, conne))
                {
                    label_TS.Text = command.ExecuteScalar().ToString();
                }
                conne.Close();


                SqlConnection conne2 = VariousMethods.CreateConnection();
                string query1 = "SELECT sum(TransactionAmount) as TA from ExpenditureReport Where TransactionDay = '" + comboBox_Day.Text + "' and TransactionMonth = '" + comboBox_Month.Text + "' and TransactionYear = '" + comboBox_Year.Text + "'";
                using (SqlCommand command = new SqlCommand(query1, conne2))
                {
                    label_TE.Text = command.ExecuteScalar().ToString();
                }
                conne2.Close();
            }
        }

        private void button_TotalView_Click(object sender, EventArgs e)
        {
            SqlConnection conne1 = VariousMethods.CreateConnection();
            string query = "SELECT sum(TotalPrice) as TP from Purchase ";
            using (SqlCommand command = new SqlCommand(query, conne1))
            {
                label_TP.Text = command.ExecuteScalar().ToString();
            }
            conne1.Close();

            SqlConnection conne = VariousMethods.CreateConnection();
            string SQL1 = "SELECT sum(TotalPrice) as TP from SalesReport ";
            using (SqlCommand command = new SqlCommand(SQL1, conne))
            {
                label_TS.Text = command.ExecuteScalar().ToString();
            }
            conne.Close();


            SqlConnection conne2 = VariousMethods.CreateConnection();
            string query1 = "SELECT sum(TransactionAmount) as TA from ExpenditureReport ";
            using (SqlCommand command = new SqlCommand(query1, conne2))
            {
                label_TE.Text = command.ExecuteScalar().ToString();
            }
            conne2.Close();
        }
    }
}
