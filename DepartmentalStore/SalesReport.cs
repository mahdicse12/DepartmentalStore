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
    public partial class Form_SalesReport : Form
    {
        public Form_SalesReport()
        {
            InitializeComponent();
        }

        VariousMethods vm = new VariousMethods();
        private void button_ViewByIN_Click(object sender, EventArgs e)
        {
            SqlConnection conn = VariousMethods.CreateConnection();

            String query = "select * from SalesReport Where InvoiceNo = '" + textBox_IN.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView_SR.DataSource = dt;
            }
        }

        private void Form_SalesReport_Load(object sender, EventArgs e)
        {
            SqlConnection conn = VariousMethods.CreateConnection();

            String query = "select * from SalesReport ";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView_SR.DataSource = dt;
            }

        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            textBox_IN.ResetText();

            SqlConnection conn = VariousMethods.CreateConnection();

            String query = "select * from SalesReport ";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView_SR.DataSource = dt;
            }
        }

        
        private void button_CalculateTotal_Click(object sender, EventArgs e)
        {
           
            if (textBox_IN.Text == "" && comboBox_Day.Text == "" && comboBox_Month.Text == "" && comboBox_Year.Text == "")
            {
                SqlConnection conne = VariousMethods.CreateConnection();
                string SQL = "SELECT sum(TotalItem) as TI from SalesReport ";
                using (SqlCommand command = new SqlCommand(SQL, conne))
                {
                    label_TI.Text = command.ExecuteScalar().ToString();
                }
                conne.Close();

                SqlConnection conne1 = VariousMethods.CreateConnection();
                string SQL1 = "SELECT sum(TotalPrice) as TP from SalesReport ";
                using (SqlCommand command = new SqlCommand(SQL1, conne1))
                {
                    label_TP.Text = command.ExecuteScalar().ToString();
                }
                conne1.Close();

            }

            else if (textBox_IN.Text != "")
            {
                SqlConnection conne = VariousMethods.CreateConnection();
                string SQL = "SELECT sum(TotalItem) as TI from SalesReport Where InvoiceNo = '" + textBox_IN.Text + "'";
                using (SqlCommand command = new SqlCommand(SQL, conne))
                {
                    label_TI.Text = command.ExecuteScalar().ToString();
                }
                conne.Close();

                SqlConnection conne1 = VariousMethods.CreateConnection();
                string SQL1 = "SELECT sum(TotalPrice) as TP from SalesReport Where InvoiceNo = '" + textBox_IN.Text + "'";
                using (SqlCommand command = new SqlCommand(SQL1, conne1))
                {
                    label_TP.Text = command.ExecuteScalar().ToString();
                }
                conne1.Close();        

            }
            else if (comboBox_Day.Text !="" && comboBox_Month.Text != "" && comboBox_Year.Text != "")
            {
                SqlConnection conne = VariousMethods.CreateConnection();
                string SQL = "SELECT sum(TotalItem) as TI from SalesReport Where Day = '" + comboBox_Day.Text + "' and Month = '" + comboBox_Month.Text + "' and Year = '" + comboBox_Year.Text + "'";
                using (SqlCommand command = new SqlCommand(SQL, conne))
                {
                    label_TI.Text = command.ExecuteScalar().ToString();
                }
                conne.Close();

                SqlConnection conne1 = VariousMethods.CreateConnection();
                string SQL1 = "SELECT sum(TotalPrice) as TP from SalesReport Where Day = '" + comboBox_Day.Text + "' and Month = '" + comboBox_Month.Text + "' and Year = '" + comboBox_Year.Text + "'";
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

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_View_Click(object sender, EventArgs e)
        {
            SqlConnection conn = VariousMethods.CreateConnection();

            String query = "select * from SalesReport Where Day = '" + comboBox_Day.Text + "' and Month = '" + comboBox_Month.Text + "' and Year = '" + comboBox_Year.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView_SR.DataSource = dt;
            }
        }
    }
}
