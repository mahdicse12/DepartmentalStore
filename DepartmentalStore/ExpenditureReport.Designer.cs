namespace DepartmentalStore
{
    partial class Form_ExpenditureReport
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
            this.label_TA = new System.Windows.Forms.Label();
            this.label_TotalAmount = new System.Windows.Forms.Label();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_CalculateTotal = new System.Windows.Forms.Button();
            this.button_View = new System.Windows.Forms.Button();
            this.comboBox_Year = new System.Windows.Forms.ComboBox();
            this.comboBox_Month = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_SR = new System.Windows.Forms.DataGridView();
            this.comboBox_Day = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SR)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_TA
            // 
            this.label_TA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TA.Location = new System.Drawing.Point(636, 16);
            this.label_TA.Name = "label_TA";
            this.label_TA.Size = new System.Drawing.Size(175, 26);
            this.label_TA.TabIndex = 69;
            this.label_TA.Text = "0";
            // 
            // label_TotalAmount
            // 
            this.label_TotalAmount.AutoSize = true;
            this.label_TotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalAmount.Location = new System.Drawing.Point(492, 16);
            this.label_TotalAmount.Name = "label_TotalAmount";
            this.label_TotalAmount.Size = new System.Drawing.Size(126, 20);
            this.label_TotalAmount.TabIndex = 68;
            this.label_TotalAmount.Text = "Total Amount :";
            // 
            // button_Refresh
            // 
            this.button_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Refresh.Location = new System.Drawing.Point(898, 54);
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
            this.button_Close.Location = new System.Drawing.Point(1058, 52);
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
            this.button_CalculateTotal.Location = new System.Drawing.Point(732, 56);
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
            this.button_View.Location = new System.Drawing.Point(472, 45);
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
            this.comboBox_Year.Location = new System.Drawing.Point(316, 52);
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
            this.comboBox_Month.Location = new System.Drawing.Point(179, 52);
            this.comboBox_Month.Name = "comboBox_Month";
            this.comboBox_Month.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Month.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Red;
            this.groupBox4.Controls.Add(this.label_TA);
            this.groupBox4.Controls.Add(this.label_TotalAmount);
            this.groupBox4.Location = new System.Drawing.Point(12, 212);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1160, 50);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_SR);
            this.groupBox1.Location = new System.Drawing.Point(12, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 250);
            this.groupBox1.TabIndex = 10;
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
            this.comboBox_Day.Location = new System.Drawing.Point(40, 52);
            this.comboBox_Day.Name = "comboBox_Day";
            this.comboBox_Day.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Day.TabIndex = 3;
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
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1154, 116);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(12, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1160, 41);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // Form_ExpenditureReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form_ExpenditureReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExpenditureReport";
            this.Load += new System.EventHandler(this.Form_ExpenditureReport_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SR)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_TA;
        private System.Windows.Forms.Label label_TotalAmount;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_CalculateTotal;
        private System.Windows.Forms.Button button_View;
        private System.Windows.Forms.ComboBox comboBox_Year;
        private System.Windows.Forms.ComboBox comboBox_Month;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_SR;
        private System.Windows.Forms.ComboBox comboBox_Day;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}