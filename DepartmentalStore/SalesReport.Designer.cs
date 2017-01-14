namespace DepartmentalStore
{
    partial class Form_SalesReport
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
            this.dataGridView_SR = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_CalculateTotal = new System.Windows.Forms.Button();
            this.button_View = new System.Windows.Forms.Button();
            this.comboBox_Year = new System.Windows.Forms.ComboBox();
            this.comboBox_Month = new System.Windows.Forms.ComboBox();
            this.comboBox_Day = new System.Windows.Forms.ComboBox();
            this.button_ViewByIN = new System.Windows.Forms.Button();
            this.textBox_IN = new System.Windows.Forms.TextBox();
            this.label_IN = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label_TP = new System.Windows.Forms.Label();
            this.label_TotalPrice = new System.Windows.Forms.Label();
            this.label_TI = new System.Windows.Forms.Label();
            this.label_TotalItem = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SR)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_SR);
            this.groupBox1.Location = new System.Drawing.Point(12, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView_SR
            // 
            this.dataGridView_SR.AllowUserToAddRows = false;
            this.dataGridView_SR.AllowUserToDeleteRows = false;
            this.dataGridView_SR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_SR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SR.Location = new System.Drawing.Point(10, 19);
            this.dataGridView_SR.Name = "dataGridView_SR";
            this.dataGridView_SR.ReadOnly = true;
            this.dataGridView_SR.Size = new System.Drawing.Size(1144, 223);
            this.dataGridView_SR.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Refresh);
            this.groupBox2.Controls.Add(this.button_Close);
            this.groupBox2.Controls.Add(this.button_CalculateTotal);
            this.groupBox2.Controls.Add(this.button_View);
            this.groupBox2.Controls.Add(this.comboBox_Year);
            this.groupBox2.Controls.Add(this.comboBox_Month);
            this.groupBox2.Controls.Add(this.comboBox_Day);
            this.groupBox2.Controls.Add(this.button_ViewByIN);
            this.groupBox2.Controls.Add(this.textBox_IN);
            this.groupBox2.Controls.Add(this.label_IN);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1154, 116);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Refresh.Location = new System.Drawing.Point(762, 67);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(110, 36);
            this.button_Refresh.TabIndex = 7;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_Close
            // 
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.Location = new System.Drawing.Point(1058, 69);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 32);
            this.button_Close.TabIndex = 9;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_CalculateTotal
            // 
            this.button_CalculateTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CalculateTotal.Location = new System.Drawing.Point(908, 69);
            this.button_CalculateTotal.Name = "button_CalculateTotal";
            this.button_CalculateTotal.Size = new System.Drawing.Size(144, 32);
            this.button_CalculateTotal.TabIndex = 8;
            this.button_CalculateTotal.Text = "Calculate Total";
            this.button_CalculateTotal.UseVisualStyleBackColor = true;
            this.button_CalculateTotal.Click += new System.EventHandler(this.button_CalculateTotal_Click);
            // 
            // button_View
            // 
            this.button_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_View.Location = new System.Drawing.Point(1062, 24);
            this.button_View.Name = "button_View";
            this.button_View.Size = new System.Drawing.Size(75, 31);
            this.button_View.TabIndex = 6;
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
            this.comboBox_Year.Location = new System.Drawing.Point(921, 24);
            this.comboBox_Year.Name = "comboBox_Year";
            this.comboBox_Year.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Year.TabIndex = 5;
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
            this.comboBox_Month.Location = new System.Drawing.Point(784, 24);
            this.comboBox_Month.Name = "comboBox_Month";
            this.comboBox_Month.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Month.TabIndex = 4;
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
            this.comboBox_Day.Location = new System.Drawing.Point(645, 24);
            this.comboBox_Day.Name = "comboBox_Day";
            this.comboBox_Day.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Day.TabIndex = 3;
            // 
            // button_ViewByIN
            // 
            this.button_ViewByIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ViewByIN.Location = new System.Drawing.Point(354, 24);
            this.button_ViewByIN.Name = "button_ViewByIN";
            this.button_ViewByIN.Size = new System.Drawing.Size(75, 31);
            this.button_ViewByIN.TabIndex = 2;
            this.button_ViewByIN.Text = "View";
            this.button_ViewByIN.UseVisualStyleBackColor = true;
            this.button_ViewByIN.Click += new System.EventHandler(this.button_ViewByIN_Click);
            // 
            // textBox_IN
            // 
            this.textBox_IN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_IN.Location = new System.Drawing.Point(118, 27);
            this.textBox_IN.Name = "textBox_IN";
            this.textBox_IN.Size = new System.Drawing.Size(194, 26);
            this.textBox_IN.TabIndex = 1;
            // 
            // label_IN
            // 
            this.label_IN.AutoSize = true;
            this.label_IN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IN.Location = new System.Drawing.Point(6, 27);
            this.label_IN.Name = "label_IN";
            this.label_IN.Size = new System.Drawing.Size(103, 20);
            this.label_IN.TabIndex = 0;
            this.label_IN.Text = "Invoice No#";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(12, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1160, 41);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Red;
            this.groupBox4.Controls.Add(this.label_TP);
            this.groupBox4.Controls.Add(this.label_TotalPrice);
            this.groupBox4.Controls.Add(this.label_TI);
            this.groupBox4.Controls.Add(this.label_TotalItem);
            this.groupBox4.Location = new System.Drawing.Point(12, 243);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1160, 50);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // label_TP
            // 
            this.label_TP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TP.Location = new System.Drawing.Point(916, 16);
            this.label_TP.Name = "label_TP";
            this.label_TP.Size = new System.Drawing.Size(175, 26);
            this.label_TP.TabIndex = 69;
            this.label_TP.Text = "0";
            // 
            // label_TotalPrice
            // 
            this.label_TotalPrice.AutoSize = true;
            this.label_TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalPrice.Location = new System.Drawing.Point(772, 16);
            this.label_TotalPrice.Name = "label_TotalPrice";
            this.label_TotalPrice.Size = new System.Drawing.Size(104, 20);
            this.label_TotalPrice.TabIndex = 68;
            this.label_TotalPrice.Text = "Total Price :";
            // 
            // label_TI
            // 
            this.label_TI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TI.Location = new System.Drawing.Point(499, 16);
            this.label_TI.Name = "label_TI";
            this.label_TI.Size = new System.Drawing.Size(177, 26);
            this.label_TI.TabIndex = 67;
            this.label_TI.Text = "0";
            // 
            // label_TotalItem
            // 
            this.label_TotalItem.AutoSize = true;
            this.label_TotalItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalItem.Location = new System.Drawing.Point(355, 16);
            this.label_TotalItem.Name = "label_TotalItem";
            this.label_TotalItem.Size = new System.Drawing.Size(100, 20);
            this.label_TotalItem.TabIndex = 66;
            this.label_TotalItem.Text = "Total Item :";
            // 
            // Form_SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form_SalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.Form_SalesReport_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SR)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_SR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_CalculateTotal;
        private System.Windows.Forms.Button button_View;
        private System.Windows.Forms.ComboBox comboBox_Year;
        private System.Windows.Forms.ComboBox comboBox_Month;
        private System.Windows.Forms.ComboBox comboBox_Day;
        private System.Windows.Forms.Button button_ViewByIN;
        private System.Windows.Forms.TextBox textBox_IN;
        private System.Windows.Forms.Label label_IN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label_TP;
        private System.Windows.Forms.Label label_TotalPrice;
        private System.Windows.Forms.Label label_TI;
        private System.Windows.Forms.Label label_TotalItem;
    }
}