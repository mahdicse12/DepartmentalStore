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
    public partial class Form_ExpenditureReport : Form
    {
        public Form_ExpenditureReport()
        {
            InitializeComponent();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            SqlConnection conn = VariousMethods.CreateConnection();

            String query = "select * from ExpenditureReport ";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView_SR.DataSource = dt;
            }
        }

        private void Form_ExpenditureReport_Load(object sender, EventArgs e)
        {
            SqlConnection conn = VariousMethods.CreateConnection();

            String query = "select * from ExpenditureReport ";
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
            if (comboBox_Day.Text == "" && comboBox_Month.Text == "" && comboBox_Year.Text == "")
            {
                
                SqlConnection conne1 = VariousMethods.CreateConnection();
                string SQL1 = "SELECT sum(TransactionAmount) as TA from ExpenditureReport ";
                using (SqlCommand command = new SqlCommand(SQL1, conne1))
                {
                    label_TA.Text = command.ExecuteScalar().ToString();
                }
                conne1.Close();

            }

            else
            {
                
                SqlConnection conne1 = VariousMethods.CreateConnection();
                string SQL1 = "SELECT sum(TransactionAmount) as TA from ExpenditureReport Where TransactionDay = '" + comboBox_Day.Text + "' and TransactionMonth = '" + comboBox_Month.Text + "' and TransactionYear = '" + comboBox_Year.Text + "'";
                using (SqlCommand command = new SqlCommand(SQL1, conne1))
                {
                    label_TA.Text = command.ExecuteScalar().ToString();
                }
                conne1.Close();


            }

            
            comboBox_Day.SelectedIndex = -1;
            comboBox_Month.SelectedIndex = -1; ;
            comboBox_Year.SelectedIndex = -1;

        }

        private void button_View_Click(object sender, EventArgs e)
        {
            SqlConnection conn = VariousMethods.CreateConnection();

            String query = "select * from ExpenditureReport Where TransactionDay = '" + comboBox_Day.Text + "' and TransactionMonth = '" + comboBox_Month.Text + "' and TransactionYear = '" + comboBox_Year.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView_SR.DataSource = dt;
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
