namespace DepartmentalStore
{
    partial class Form_BalanceSheet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_TotalView = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_View = new System.Windows.Forms.Button();
            this.comboBox_Year = new System.Windows.Forms.ComboBox();
            this.comboBox_Month = new System.Windows.Forms.ComboBox();
            this.comboBox_Day = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_TE = new System.Windows.Forms.Label();
            this.label_TotalExpenditure = new System.Windows.Forms.Label();
            this.label_TS = new System.Windows.Forms.Label();
            this.label_TotalSales = new System.Windows.Forms.Label();
            this.label_TP = new System.Windows.Forms.Label();
            this.label_TotalPurchase = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_TotalView);
            this.groupBox1.Controls.Add(this.button_Close);
            this.groupBox1.Controls.Add(this.button_View);
            this.groupBox1.Controls.Add(this.comboBox_Year);
            this.groupBox1.Controls.Add(this.comboBox_Month);
            this.groupBox1.Controls.Add(this.comboBox_Day);
            this.groupBox1.Location = new System.Drawing.Point(12, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button_TotalView
            // 
            this.button_TotalView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TotalView.Location = new System.Drawing.Point(112, 21);
            this.button_TotalView.Name = "button_TotalView";
            this.button_TotalView.Size = new System.Drawing.Size(100, 31);
            this.button_TotalView.TabIndex = 14;
            this.button_TotalView.Text = "Total View";
            this.button_TotalView.UseVisualStyleBackColor = true;
            this.button_TotalView.Click += new System.EventHandler(this.button_TotalView_Click);
            // 
            // button_Close
            // 
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.Location = new System.Drawing.Point(1055, 20);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 32);
            this.button_Close.TabIndex = 13;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_View
            // 
            this.button_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_View.Location = new System.Drawing.Point(958, 20);
            this.button_View.Name = "button_View";
            this.button_View.Size = new System.Drawing.Size(75, 31);
            this.button_View.TabIndex = 12;
            this.button_View.Text = "View";
            this.button_View.UseVisualStyleBackColor = true;
            this.button_View.Click += new System.EventHandler(this.button_View_Click);
            // 
            // comboBox_Year
            // 
            this.comboBox_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Year.FormattingEnabled = true;
            this.comboBox_Year.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.comboBox_Year.Location = new System.Drawing.Point(789, 24);
            this.comboBox_Year.Name = "comboBox_Year";
            this.comboBox_Year.Size = new System.Drawing.Size(125, 21);
            this.comboBox_Year.TabIndex = 11;
            // 
            // comboBox_Month
            // 
            this.comboBox_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Month.FormattingEnabled = true;
            this.comboBox_Month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox_Month.Location = new System.Drawing.Point(641, 24);
            this.comboBox_Month.Name = "comboBox_Month";
            this.comboBox_Month.Size = new System.Drawing.Size(125, 21);
            this.comboBox_Month.TabIndex = 10;
            // 
            // comboBox_Day
            // 
            this.comboBox_Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Day.FormattingEnabled = true;
            this.comboBox_Day.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBox_Day.Location = new System.Drawing.Point(487, 24);
            this.comboBox_Day.Name = "comboBox_Day";
            this.comboBox_Day.Size = new System.Drawing.Size(125, 21);
            this.comboBox_Day.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_TE);
            this.groupBox2.Controls.Add(this.label_TotalExpenditure);
            this.groupBox2.Controls.Add(this.label_TS);
            this.groupBox2.Controls.Add(this.label_TotalSales);
            this.groupBox2.Controls.Add(this.label_TP);
            this.groupBox2.Controls.Add(this.label_TotalPurchase);
            this.groupBox2.Location = new System.Drawing.Point(12, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1160, 321);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label_TE
            // 
            this.label_TE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TE.Location = new System.Drawing.Point(580, 182);
            this.label_TE.Name = "label_TE";
            this.label_TE.Size = new System.Drawing.Size(186, 30);
            this.label_TE.TabIndex = 5;
            this.label_TE.Text = "0";
            // 
            // label_TotalExpenditure
            // 
            this.label_TotalExpenditure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalExpenditure.Location = new System.Drawing.Point(344, 182);
            this.label_TotalExpenditure.Name = "label_TotalExpenditure";
            this.label_TotalExpenditure.Size = new System.Drawing.Size(230, 30);
            this.label_TotalExpenditure.TabIndex = 4;
            this.label_TotalExpenditure.Text = "Total Expenditure :";
            // 
            // label_TS
            // 
            this.label_TS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TS.Location = new System.Drawing.Point(580, 138);
            this.label_TS.Name = "label_TS";
            this.label_TS.Size = new System.Drawing.Size(186, 30);
            this.label_TS.TabIndex = 3;
            this.label_TS.Text = "0";
            // 
            // label_TotalSales
            // 
            this.label_TotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalSales.Location = new System.Drawing.Point(344, 138);
            this.label_TotalSales.Name = "label_TotalSales";
            this.label_TotalSales.Size = new System.Drawing.Size(186, 30);
            this.label_TotalSales.TabIndex = 2;
            this.label_TotalSales.Text = "Total Sales :";
            // 
            // label_TP
            // 
            this.label_TP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TP.Location = new System.Drawing.Point(580, 87);
            this.label_TP.Name = "label_TP";
            this.label_TP.Size = new System.Drawing.Size(186, 30);
            this.label_TP.TabIndex = 1;
            this.label_TP.Text = "0";
            // 
            // label_TotalPurchase
            // 
            this.label_TotalPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalPurchase.Location = new System.Drawing.Point(344, 87);
            this.label_TotalPurchase.Name = "label_TotalPurchase";
            this.label_TotalPurchase.Size = new System.Drawing.Size(186, 30);
            this.label_TotalPurchase.TabIndex = 0;
            this.label_TotalPurchase.Text = "Total Purchase :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(12, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1160, 50);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // Form_BalanceSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_BalanceSheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance Sheet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_View;
        private System.Windows.Forms.ComboBox comboBox_Year;
        private System.Windows.Forms.ComboBox comboBox_Month;
        private System.Windows.Forms.ComboBox comboBox_Day;
        private System.Windows.Forms.Label label_TS;
        private System.Windows.Forms.Label label_TotalSales;
        private System.Windows.Forms.Label label_TP;
        private System.Windows.Forms.Label label_TotalPurchase;
        private System.Windows.Forms.Label label_TE;
        private System.Windows.Forms.Label label_TotalExpenditure;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_TotalView;
    }
}