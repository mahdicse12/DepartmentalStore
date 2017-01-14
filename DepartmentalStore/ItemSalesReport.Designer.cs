namespace DepartmentalStore
{
    partial class Form_ItemSalesReport
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
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_CalculateTotal = new System.Windows.Forms.Button();
            this.button_INView = new System.Windows.Forms.Button();
            this.textBox_IN = new System.Windows.Forms.TextBox();
            this.label_IN = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_ISR = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_TotalProfit = new System.Windows.Forms.Label();
            this.label_TProfit = new System.Windows.Forms.Label();
            this.label_TP = new System.Windows.Forms.Label();
            this.label_TotalPrice = new System.Windows.Forms.Label();
            this.label_TI = new System.Windows.Forms.Label();
            this.label_TotalItem = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ISR)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Refresh);
            this.groupBox1.Controls.Add(this.button_Close);
            this.groupBox1.Controls.Add(this.button_CalculateTotal);
            this.groupBox1.Controls.Add(this.button_INView);
            this.groupBox1.Controls.Add(this.textBox_IN);
            this.groupBox1.Controls.Add(this.label_IN);
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 73);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Refresh.Location = new System.Drawing.Point(566, 24);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(110, 36);
            this.button_Refresh.TabIndex = 3;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_Close
            // 
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.Location = new System.Drawing.Point(1016, 28);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 32);
            this.button_Close.TabIndex = 5;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_CalculateTotal
            // 
            this.button_CalculateTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CalculateTotal.Location = new System.Drawing.Point(857, 30);
            this.button_CalculateTotal.Name = "button_CalculateTotal";
            this.button_CalculateTotal.Size = new System.Drawing.Size(144, 32);
            this.button_CalculateTotal.TabIndex = 4;
            this.button_CalculateTotal.Text = "Calculate Total";
            this.button_CalculateTotal.UseVisualStyleBackColor = true;
            this.button_CalculateTotal.Click += new System.EventHandler(this.button_CalculateTotal_Click);
            // 
            // button_INView
            // 
            this.button_INView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_INView.Location = new System.Drawing.Point(447, 23);
            this.button_INView.Name = "button_INView";
            this.button_INView.Size = new System.Drawing.Size(75, 36);
            this.button_INView.TabIndex = 2;
            this.button_INView.Text = "View";
            this.button_INView.UseVisualStyleBackColor = true;
            this.button_INView.Click += new System.EventHandler(this.button_INView_Click);
            // 
            // textBox_IN
            // 
            this.textBox_IN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_IN.Location = new System.Drawing.Point(144, 33);
            this.textBox_IN.Name = "textBox_IN";
            this.textBox_IN.Size = new System.Drawing.Size(194, 26);
            this.textBox_IN.TabIndex = 1;
            // 
            // label_IN
            // 
            this.label_IN.AutoSize = true;
            this.label_IN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IN.Location = new System.Drawing.Point(32, 33);
            this.label_IN.Name = "label_IN";
            this.label_IN.Size = new System.Drawing.Size(106, 20);
            this.label_IN.TabIndex = 3;
            this.label_IN.Text = "Item Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_ISR);
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1160, 302);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView_ISR
            // 
            this.dataGridView_ISR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ISR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ISR.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_ISR.Name = "dataGridView_ISR";
            this.dataGridView_ISR.Size = new System.Drawing.Size(1148, 274);
            this.dataGridView_ISR.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Red;
            this.groupBox4.Location = new System.Drawing.Point(12, 38);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1160, 50);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Red;
            this.groupBox3.Controls.Add(this.label_TotalProfit);
            this.groupBox3.Controls.Add(this.label_TProfit);
            this.groupBox3.Controls.Add(this.label_TP);
            this.groupBox3.Controls.Add(this.label_TotalPrice);
            this.groupBox3.Controls.Add(this.label_TI);
            this.groupBox3.Controls.Add(this.label_TotalItem);
            this.groupBox3.Location = new System.Drawing.Point(12, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1160, 50);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // label_TotalProfit
            // 
            this.label_TotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalProfit.Location = new System.Drawing.Point(934, 16);
            this.label_TotalProfit.Name = "label_TotalProfit";
            this.label_TotalProfit.Size = new System.Drawing.Size(175, 26);
            this.label_TotalProfit.TabIndex = 71;
            this.label_TotalProfit.Text = "0";
            // 
            // label_TProfit
            // 
            this.label_TProfit.AutoSize = true;
            this.label_TProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TProfit.Location = new System.Drawing.Point(790, 16);
            this.label_TProfit.Name = "label_TProfit";
            this.label_TProfit.Size = new System.Drawing.Size(107, 20);
            this.label_TProfit.TabIndex = 70;
            this.label_TProfit.Text = "Total Profit :";
            // 
            // label_TP
            // 
            this.label_TP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TP.Location = new System.Drawing.Point(587, 16);
            this.label_TP.Name = "label_TP";
            this.label_TP.Size = new System.Drawing.Size(175, 26);
            this.label_TP.TabIndex = 69;
            this.label_TP.Text = "0";
            // 
            // label_TotalPrice
            // 
            this.label_TotalPrice.AutoSize = true;
            this.label_TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalPrice.Location = new System.Drawing.Point(443, 16);
            this.label_TotalPrice.Name = "label_TotalPrice";
            this.label_TotalPrice.Size = new System.Drawing.Size(104, 20);
            this.label_TotalPrice.TabIndex = 68;
            this.label_TotalPrice.Text = "Total Price :";
            // 
            // label_TI
            // 
            this.label_TI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TI.Location = new System.Drawing.Point(284, 16);
            this.label_TI.Name = "label_TI";
            this.label_TI.Size = new System.Drawing.Size(177, 26);
            this.label_TI.TabIndex = 67;
            this.label_TI.Text = "0";
            // 
            // label_TotalItem
            // 
            this.label_TotalItem.AutoSize = true;
            this.label_TotalItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalItem.Location = new System.Drawing.Point(140, 16);
            this.label_TotalItem.Name = "label_TotalItem";
            this.label_TotalItem.Size = new System.Drawing.Size(100, 20);
            this.label_TotalItem.TabIndex = 66;
            this.label_TotalItem.Text = "Total Item :";
            // 
            // Form_ItemSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.Name = "Form_ItemSalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Sales Report";
            this.Load += new System.EventHandler(this.Form_ItemSalesReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ISR)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_CalculateTotal;
        private System.Windows.Forms.Button button_INView;
        private System.Windows.Forms.TextBox textBox_IN;
        private System.Windows.Forms.Label label_IN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_ISR;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_TI;
        private System.Windows.Forms.Label label_TotalItem;
        private System.Windows.Forms.Label label_TP;
        private System.Windows.Forms.Label label_TotalPrice;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Label label_TotalProfit;
        private System.Windows.Forms.Label label_TProfit;

    }
}