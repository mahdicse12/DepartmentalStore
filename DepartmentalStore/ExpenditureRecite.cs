using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentalStore
{
    public partial class Form_ExpenditureRecite : Form
    {
        public Form_ExpenditureRecite()
        {
            InitializeComponent();
        }
        VariousMethods vm = new VariousMethods();

        private void button_Submit_Click(object sender, EventArgs e)
        {
            string tn = textBox_TN.Text;
            string ta = textBox_TA.Text;
            string tp = richTextBox_Purpose.Text;
            string tDay = DateTime.Now.Day.ToString();
            string tMonth = DateTime.Now.Month.ToString();
            string tYear = DateTime.Now.Year.ToString();

            DialogResult result = MessageBox.Show("Would you like to save this Information?", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                if (tn != "" && ta != "")
                {


                    string query = "INSERT into ExpenditureReport values('" + tn + "','" + ta + "','" + tp + "','" + tDay + "','" + tMonth + "','" + tYear + "','" + label_TB.Text + "')";

                    vm.SaveInformation(query);

                    MessageBox.Show("Transaction Inserted .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                }

            }
        }

        private void Form_ExpenditureRecite_Load(object sender, EventArgs e)
        {
            label_TB.Text = Form_LogIn.un;
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
