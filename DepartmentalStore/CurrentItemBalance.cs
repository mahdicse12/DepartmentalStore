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
    public partial class Form_CurrentItemBalance : Form
    {
        public Form_CurrentItemBalance()
        {
            InitializeComponent();
        }

        private void button_ViewByIN_Click(object sender, EventArgs e)
        {
            SqlConnection conn = VariousMethods.CreateConnection();

            String query = "select ItemCode , ItemName , GroupName , CompanyName , ItemUnit , SelfNo , AvailableQuantity from Item WHERE ItemName ='" + textBox_IN.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView_CurrentItemBalance.DataSource = dt;
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_CurrentItemBalance_Load(object sender, EventArgs e)
        {
            SqlConnection conn = VariousMethods.CreateConnection();

            String query = "select ItemCode , ItemName , GroupName , CompanyName , ItemUnit , SelfNo , AvailableQuantity from Item ";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView_CurrentItemBalance.DataSource = dt;
            }
        }

        private void button_ViewByGN_Click(object sender, EventArgs e)
        {

            SqlConnection conn = VariousMethods.CreateConnection();

            String query = "select ItemCode , ItemName , GroupName , CompanyName , ItemUnit , SelfNo , AvailableQuantity from Item WHERE GroupName ='" + textBox_GN.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView_CurrentItemBalance.DataSource = dt;
            }
        }

        private void button_TotalBalance_Click(object sender, EventArgs e)
        {
            if (textBox_IN.Text == "" )
            {
                SqlConnection conne = VariousMethods.CreateConnection();
                string SQL = "SELECT sum(AvailableQuantity) as AQ from Item ";
                using (SqlCommand command = new SqlCommand(SQL, conne))
                {
                    label_TotalBalance.Text = command.ExecuteScalar().ToString();
                }
                conne.Close();

            }
            
            else if (textBox_IN.Text != "")
            {
                SqlConnection conne = VariousMethods.CreateConnection();
                string SQL = "SELECT sum(AvailableQuantity) as AQ from Item WHERE ItemName = '" + textBox_IN.Text + "'";
                using (SqlCommand command = new SqlCommand(SQL, conne))
                {
                    label_TotalBalance.Text = command.ExecuteScalar().ToString();
                }
                conne.Close();
            }

            else
            {
                SqlConnection conne = VariousMethods.CreateConnection();
                string SQL = "SELECT sum(AvailableQuantity) as AQ from Item ";
                using (SqlCommand command = new SqlCommand(SQL, conne))
                {
                    label_TotalBalance.Text = command.ExecuteScalar().ToString();
                }
                conne.Close();

            }

            textBox_IN.ResetText();
            
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            SqlConnection conn = VariousMethods.CreateConnection();

            String query = "select ItemCode , ItemName , GroupName , CompanyName , ItemUnit , SelfNo , AvailableQuantity from Item ";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView_CurrentItemBalance.DataSource = dt;
            }
        }

    }
}
