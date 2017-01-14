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
    public partial class Form_PurchaseReport : Form
    {
        public Form_PurchaseReport()
        {
            InitializeComponent();
        }

        VariousMethods vm = new VariousMethods();

        private void Form_PurchaseReport_Load(object sender, EventArgs e)
        {
            SqlConnection conn = VariousMethods.CreateConnection();

            String query1 = "select I.ItemCode , I.ItemName , I.ItemUnit , P.PurchasePrice , P.PurchaseQuantity , P.TotalPrice , P.PurchaseDay , P.PurchaseMonth , P.PurchaseYear from Item I , Purchase P WHERE I.ItemCode = P.ItemCode";
            SqlCommand cmd = new SqlCommand(query1, conn);

            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView_PurchaseReport.DataSource = dt;
            }
        }

        
        private void button_View_Click(object sender, EventArgs e)
        {
            SqlConnection conn = VariousMethods.CreateConnection();

            String query1 = "select I.ItemCode , I.ItemName , I.ItemUnit , P.PurchasePrice , P.PurchaseQuantity , P.TotalPrice , P.PurchaseDay , P.PurchaseMonth , P.PurchaseYear from Item I , Purchase P WHERE I.ItemCode = P.ItemCode and P.PurchaseDay ='" + comboBox_Day.Text + "' and P.PurchaseMonth ='" + comboBox_Month.Text + "' and P.PurchaseYear ='" + comboBox_Year.Text + "' ";
            SqlCommand cmd = new SqlCommand(query1, conn);

            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView_PurchaseReport.DataSource = dt;
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void button_INView_Click(object sender, EventArgs e)
        {
            SqlConnection conn = VariousMethods.CreateConnection();

            String query1 = "select I.ItemCode , I.ItemName , I.ItemUnit , P.PurchasePrice , P.PurchaseQuantity , P.TotalPrice , P.PurchaseDay , P.PurchaseMonth , P.PurchaseYear from Item I , Purchase P WHERE I.ItemCode = P.ItemCode and I.ItemName ='" + textBox_IN.Text + "' ";
            SqlCommand cmd = new SqlCommand(query1, conn);

            SqlDataReader reader = cmd.ExecuteReader();
                

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView_PurchaseReport.DataSource = dt;
            }

        }

        private void button_CalculateTotal_Click(object sender, EventArgs e)
        {
                
            if (textBox_IN.Text == "" && comboBox_Day.Text == "" && comboBox_Month.Text == "" && comboBox_Year.Text == "")
            {
                SqlConnection conne = VariousMethods.CreateConnection();
                string SQL = "SELECT sum(PurchaseQuantity) as PQ from Purchase ";
                using (SqlCommand command = new SqlCommand(SQL, conne))
                {
                    label_TI.Text = command.ExecuteScalar().ToString();
                }
                conne.Close();

                SqlConnection conne1 = VariousMethods.CreateConnection();
                string SQL1 = "SELECT sum(TotalPrice) as TP from Purchase ";
                using (SqlCommand command = new SqlCommand(SQL1, conne1))
                {
                    label_TP.Text = command.ExecuteScalar().ToString();
                }
                conne1.Close();

            }

            else if (textBox_IN.Text != "")
            {
                SqlConnection conne = VariousMethods.CreateConnection();
                string SQL = "SELECT sum(PurchaseQuantity) as PQ from Purchase P , Item I Where P.ItemCode = I.ItemCode and I.ItemName = '" + textBox_IN.Text + "'";
                using (SqlCommand command = new SqlCommand(SQL, conne))
                {
                    label_TI.Text = command.ExecuteScalar().ToString();
                }
                conne.Close();

                SqlConnection conne1 = VariousMethods.CreateConnection();
                string SQL1 = "SELECT sum(TotalPrice) as PQ from Purchase P , Item I Where P.ItemCode = I.ItemCode and I.ItemName = '" + textBox_IN.Text + "'";
                using (SqlCommand command = new SqlCommand(SQL1, conne1))
                {
                    label_TP.Text = command.ExecuteScalar().ToString();
                }
                conne1.Close();

            }
            else if (comboBox_Day.Text != "" && comboBox_Month.Text != "" && comboBox_Year.Text != "")
            {
                SqlConnection conne = VariousMethods.CreateConnection();
                string SQL = "SELECT sum(PurchaseQuantity) as PQ from Purchase  Where PurchaseDay = '" + comboBox_Day.Text + "' and PurchaseMonth = '" + comboBox_Month.Text + "' and PurchaseYear = '" + comboBox_Year.Text + "'";
                using (SqlCommand command = new SqlCommand(SQL, conne))
                {
                    label_TI.Text = command.ExecuteScalar().ToString();
                }
                conne.Close();

                SqlConnection conne1 = VariousMethods.CreateConnection();
                string SQL1 = "SELECT sum(TotalPrice) as TP from Purchase  Where PurchaseDay = '" + comboBox_Day.Text + "' and PurchaseMonth = '" + comboBox_Month.Text + "' and PurchaseYear = '" + comboBox_Year.Text + "'";
                using (SqlCommand command = new SqlCommand(SQL1, conne1))
                {
                    label_TP.Text = command.ExecuteScalar().ToString();
                }
                conne1.Close();


            }

            textBox_IN.ResetText();
            comboBox_Day.SelectedIndex = -1;
            comboBox_Month.SelectedIndex = -1; ;
            comboBox_Year.SelectedIndex = -1;

            
        }
    }
}
