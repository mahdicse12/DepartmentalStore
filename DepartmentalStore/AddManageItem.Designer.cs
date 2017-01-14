namespace DepartmentalStore
{
    partial class Form_AddManageItem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_UpdateInformation = new System.Windows.Forms.Button();
            this.button_InsertInformation = new System.Windows.Forms.Button();
            this.comboBox_SelfNo = new System.Windows.Forms.ComboBox();
            this.label_SelfNo = new System.Windows.Forms.Label();
            this.comboBox_ItemUnit = new System.Windows.Forms.ComboBox();
            this.textBox_SalePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_PurchasePrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_CompanyName = new System.Windows.Forms.TextBox();
            this.label_CompanyName = new System.Windows.Forms.Label();
            this.textBox_GroupName = new System.Windows.Forms.TextBox();
            this.label_GroupName = new System.Windows.Forms.Label();
            this.textBox_ItemName = new System.Windows.Forms.TextBox();
            this.label_ItemName = new System.Windows.Forms.Label();
            this.textBox_ItemCode = new System.Windows.Forms.TextBox();
            this.label_ItemCode = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_DeleteByIN = new System.Windows.Forms.Button();
            this.button_DeleteByIC = new System.Windows.Forms.Button();
            this.button_UpdateByIN = new System.Windows.Forms.Button();
            this.button_UpdateByIC = new System.Windows.Forms.Button();
            this.dataGridView_AddManageItem = new System.Windows.Forms.DataGridView();
            this.button_SearchByIN = new System.Windows.Forms.Button();
            this.button_SearchByIC = new System.Windows.Forms.Button();
            this.textBox_IN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_IC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AddManageItem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_UpdateInformation);
            this.groupBox1.Controls.Add(this.button_InsertInformation);
            this.groupBox1.Controls.Add(this.comboBox_SelfNo);
            this.groupBox1.Controls.Add(this.label_SelfNo);
            this.groupBox1.Controls.Add(this.comboBox_ItemUnit);
            this.groupBox1.Controls.Add(this.textBox_SalePrice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_PurchasePrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_CompanyName);
            this.groupBox1.Controls.Add(this.label_CompanyName);
            this.groupBox1.Controls.Add(this.textBox_GroupName);
            this.groupBox1.Controls.Add(this.label_GroupName);
            this.groupBox1.Controls.Add(this.textBox_ItemName);
            this.groupBox1.Controls.Add(this.label_ItemName);
            this.groupBox1.Controls.Add(this.textBox_ItemCode);
            this.groupBox1.Controls.Add(this.label_ItemCode);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 440);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button_UpdateInformation
            // 
            this.button_UpdateInformation.Location = new System.Drawing.Point(177, 387);
            this.button_UpdateInformation.Name = "button_UpdateInformation";
            this.button_UpdateInformation.Size = new System.Drawing.Size(175, 26);
            this.button_UpdateInformation.TabIndex = 18;
            this.button_UpdateInformation.Text = "Update Information";
            this.button_UpdateInformation.UseVisualStyleBackColor = true;
            this.button_UpdateInformation.Click += new System.EventHandler(this.button_UpdateInformation_Click);
            // 
            // button_InsertInformation
            // 
            this.button_InsertInformation.Location = new System.Drawing.Point(177, 335);
            this.button_InsertInformation.Name = "button_InsertInformation";
            this.button_InsertInformation.Size = new System.Drawing.Size(175, 26);
            this.button_InsertInformation.TabIndex = 17;
            this.button_InsertInformation.Text = "Insert Information";
            this.button_InsertInformation.UseVisualStyleBackColor = true;
            this.button_InsertInformation.Click += new System.EventHandler(this.button_InsertInformation_Click);
            // 
            // comboBox_SelfNo
            // 
            this.comboBox_SelfNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SelfNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SelfNo.FormattingEnabled = true;
            this.comboBox_SelfNo.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
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
            "30"});
            this.comboBox_SelfNo.Location = new System.Drawing.Point(177, 292);
            this.comboBox_SelfNo.Name = "comboBox_SelfNo";
            this.comboBox_SelfNo.Size = new System.Drawing.Size(175, 21);
            this.comboBox_SelfNo.TabIndex = 16;
            // 
            // label_SelfNo
            // 
            this.label_SelfNo.AutoSize = true;
            this.label_SelfNo.Location = new System.Drawing.Point(27, 292);
            this.label_SelfNo.Name = "label_SelfNo";
            this.label_SelfNo.Size = new System.Drawing.Size(78, 20);
            this.label_SelfNo.TabIndex = 15;
            this.label_SelfNo.Text = "Self No :";
            // 
            // comboBox_ItemUnit
            // 
            this.comboBox_ItemUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ItemUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ItemUnit.FormattingEnabled = true;
            this.comboBox_ItemUnit.Items.AddRange(new object[] {
            "Piece",
            "Pairs",
            "Sets",
            "Kilogram",
            "Gram",
            "Miligram",
            "Centimeter",
            "Meter",
            "Pound",
            "Inch",
            "Liter",
            "Mililiter",
            "Others"});
            this.comboBox_ItemUnit.Location = new System.Drawing.Point(177, 221);
            this.comboBox_ItemUnit.Name = "comboBox_ItemUnit";
            this.comboBox_ItemUnit.Size = new System.Drawing.Size(175, 21);
            this.comboBox_ItemUnit.TabIndex = 14;
            // 
            // textBox_SalePrice
            // 
            this.textBox_SalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SalePrice.Location = new System.Drawing.Point(177, 258);
            this.textBox_SalePrice.Name = "textBox_SalePrice";
            this.textBox_SalePrice.Size = new System.Drawing.Size(175, 26);
            this.textBox_SalePrice.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sale Price :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Item Unit :";
            // 
            // textBox_PurchasePrice
            // 
            this.textBox_PurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PurchasePrice.Location = new System.Drawing.Point(177, 185);
            this.textBox_PurchasePrice.Name = "textBox_PurchasePrice";
            this.textBox_PurchasePrice.Size = new System.Drawing.Size(175, 26);
            this.textBox_PurchasePrice.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Purchase Price :";
            // 
            // textBox_CompanyName
            // 
            this.textBox_CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CompanyName.Location = new System.Drawing.Point(177, 152);
            this.textBox_CompanyName.Name = "textBox_CompanyName";
            this.textBox_CompanyName.Size = new System.Drawing.Size(175, 26);
            this.textBox_CompanyName.TabIndex = 7;
            // 
            // label_CompanyName
            // 
            this.label_CompanyName.AutoSize = true;
            this.label_CompanyName.Location = new System.Drawing.Point(27, 152);
            this.label_CompanyName.Name = "label_CompanyName";
            this.label_CompanyName.Size = new System.Drawing.Size(144, 20);
            this.label_CompanyName.TabIndex = 6;
            this.label_CompanyName.Text = "Company Name :";
            // 
            // textBox_GroupName
            // 
            this.textBox_GroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_GroupName.Location = new System.Drawing.Point(177, 115);
            this.textBox_GroupName.Name = "textBox_GroupName";
            this.textBox_GroupName.Size = new System.Drawing.Size(175, 26);
            this.textBox_GroupName.TabIndex = 5;
            // 
            // label_GroupName
            // 
            this.label_GroupName.AutoSize = true;
            this.label_GroupName.Location = new System.Drawing.Point(27, 115);
            this.label_GroupName.Name = "label_GroupName";
            this.label_GroupName.Size = new System.Drawing.Size(120, 20);
            this.label_GroupName.TabIndex = 4;
            this.label_GroupName.Text = "Group Name :";
            // 
            // textBox_ItemName
            // 
            this.textBox_ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ItemName.Location = new System.Drawing.Point(177, 79);
            this.textBox_ItemName.Name = "textBox_ItemName";
            this.textBox_ItemName.Size = new System.Drawing.Size(175, 26);
            this.textBox_ItemName.TabIndex = 3;
            // 
            // label_ItemName
            // 
            this.label_ItemName.AutoSize = true;
            this.label_ItemName.Location = new System.Drawing.Point(27, 79);
            this.label_ItemName.Name = "label_ItemName";
            this.label_ItemName.Size = new System.Drawing.Size(106, 20);
            this.label_ItemName.TabIndex = 2;
            this.label_ItemName.Text = "Item Name :";
            // 
            // textBox_ItemCode
            // 
            this.textBox_ItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ItemCode.Location = new System.Drawing.Point(177, 42);
            this.textBox_ItemCode.Name = "textBox_ItemCode";
            this.textBox_ItemCode.Size = new System.Drawing.Size(175, 26);
            this.textBox_ItemCode.TabIndex = 1;
            // 
            // label_ItemCode
            // 
            this.label_ItemCode.AutoSize = true;
            this.label_ItemCode.Location = new System.Drawing.Point(27, 42);
            this.label_ItemCode.Name = "label_ItemCode";
            this.label_ItemCode.Size = new System.Drawing.Size(102, 20);
            this.label_ItemCode.TabIndex = 0;
            this.label_ItemCode.Text = "Item Code :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_DeleteByIN);
            this.groupBox2.Controls.Add(this.button_DeleteByIC);
            this.groupBox2.Controls.Add(this.button_UpdateByIN);
            this.groupBox2.Controls.Add(this.button_UpdateByIC);
            this.groupBox2.Controls.Add(this.dataGridView_AddManageItem);
            this.groupBox2.Controls.Add(this.button_SearchByIN);
            this.groupBox2.Controls.Add(this.button_SearchByIC);
            this.groupBox2.Controls.Add(this.textBox_IN);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_IC);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(423, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 440);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // button_DeleteByIN
            // 
            this.button_DeleteByIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteByIN.Location = new System.Drawing.Point(506, 70);
            this.button_DeleteByIN.Name = "button_DeleteByIN";
            this.button_DeleteByIN.Size = new System.Drawing.Size(77, 26);
            this.button_DeleteByIN.TabIndex = 25;
            this.button_DeleteByIN.Text = "Delete";
            this.button_DeleteByIN.UseVisualStyleBackColor = true;
            this.button_DeleteByIN.Click += new System.EventHandler(this.button_DeleteByIN_Click);
            // 
            // button_DeleteByIC
            // 
            this.button_DeleteByIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteByIC.Location = new System.Drawing.Point(506, 33);
            this.button_DeleteByIC.Name = "button_DeleteByIC";
            this.button_DeleteByIC.Size = new System.Drawing.Size(77, 26);
            this.button_DeleteByIC.TabIndex = 24;
            this.button_DeleteByIC.Text = "Delete";
            this.button_DeleteByIC.UseVisualStyleBackColor = true;
            this.button_DeleteByIC.Click += new System.EventHandler(this.button_DeleteByIC_Click);
            // 
            // button_UpdateByIN
            // 
            this.button_UpdateByIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_UpdateByIN.Location = new System.Drawing.Point(411, 70);
            this.button_UpdateByIN.Name = "button_UpdateByIN";
            this.button_UpdateByIN.Size = new System.Drawing.Size(77, 26);
            this.button_UpdateByIN.TabIndex = 23;
            this.button_UpdateByIN.Text = "Update";
            this.button_UpdateByIN.UseVisualStyleBackColor = true;
            this.button_UpdateByIN.Click += new System.EventHandler(this.button_UpdateByIN_Click);
            // 
            // button_UpdateByIC
            // 
            this.button_UpdateByIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_UpdateByIC.Location = new System.Drawing.Point(411, 33);
            this.button_UpdateByIC.Name = "button_UpdateByIC";
            this.button_UpdateByIC.Size = new System.Drawing.Size(77, 26);
            this.button_UpdateByIC.TabIndex = 22;
            this.button_UpdateByIC.Text = "Update";
            this.button_UpdateByIC.UseVisualStyleBackColor = true;
            this.button_UpdateByIC.Click += new System.EventHandler(this.button_UpdateByIC_Click);
            // 
            // dataGridView_AddManageItem
            // 
            this.dataGridView_AddManageItem.AllowUserToAddRows = false;
            this.dataGridView_AddManageItem.AllowUserToDeleteRows = false;
            this.dataGridView_AddManageItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_AddManageItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_AddManageItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_AddManageItem.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_AddManageItem.Location = new System.Drawing.Point(19, 115);
            this.dataGridView_AddManageItem.Name = "dataGridView_AddManageItem";
            this.dataGridView_AddManageItem.ReadOnly = true;
            this.dataGridView_AddManageItem.Size = new System.Drawing.Size(713, 310);
            this.dataGridView_AddManageItem.TabIndex = 20;
            // 
            // button_SearchByIN
            // 
            this.button_SearchByIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SearchByIN.Location = new System.Drawing.Point(318, 70);
            this.button_SearchByIN.Name = "button_SearchByIN";
            this.button_SearchByIN.Size = new System.Drawing.Size(77, 26);
            this.button_SearchByIN.TabIndex = 19;
            this.button_SearchByIN.Text = "Search";
            this.button_SearchByIN.UseVisualStyleBackColor = true;
            this.button_SearchByIN.Click += new System.EventHandler(this.button_INSearch_Click);
            // 
            // button_SearchByIC
            // 
            this.button_SearchByIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SearchByIC.Location = new System.Drawing.Point(318, 33);
            this.button_SearchByIC.Name = "button_SearchByIC";
            this.button_SearchByIC.Size = new System.Drawing.Size(77, 26);
            this.button_SearchByIC.TabIndex = 18;
            this.button_SearchByIC.Text = "Search";
            this.button_SearchByIC.UseVisualStyleBackColor = true;
            this.button_SearchByIC.Click += new System.EventHandler(this.button_ICSearch_Click);
            // 
            // textBox_IN
            // 
            this.textBox_IN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_IN.Location = new System.Drawing.Point(127, 70);
            this.textBox_IN.Name = "textBox_IN";
            this.textBox_IN.Size = new System.Drawing.Size(175, 26);
            this.textBox_IN.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Item Name :";
            // 
            // textBox_IC
            // 
            this.textBox_IC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_IC.Location = new System.Drawing.Point(127, 33);
            this.textBox_IC.Name = "textBox_IC";
            this.textBox_IC.Size = new System.Drawing.Size(175, 26);
            this.textBox_IC.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Item Code :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(12, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1160, 50);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // Form_AddManageItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form_AddManageItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Manage Item";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AddManageItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_CompanyName;
        private System.Windows.Forms.Label label_CompanyName;
        private System.Windows.Forms.TextBox textBox_GroupName;
        private System.Windows.Forms.Label label_GroupName;
        private System.Windows.Forms.TextBox textBox_ItemName;
        private System.Windows.Forms.Label label_ItemName;
        private System.Windows.Forms.TextBox textBox_ItemCode;
        private System.Windows.Forms.Label label_ItemCode;
        private System.Windows.Forms.Button button_UpdateInformation;
        private System.Windows.Forms.Button button_InsertInformation;
        private System.Windows.Forms.ComboBox comboBox_SelfNo;
        private System.Windows.Forms.Label label_SelfNo;
        private System.Windows.Forms.ComboBox comboBox_ItemUnit;
        private System.Windows.Forms.TextBox textBox_SalePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_PurchasePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_IN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_IC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_SearchByIN;
        private System.Windows.Forms.Button button_SearchByIC;
        private System.Windows.Forms.DataGridView dataGridView_AddManageItem;
        private System.Windows.Forms.Button button_DeleteByIN;
        private System.Windows.Forms.Button button_DeleteByIC;
        private System.Windows.Forms.Button button_UpdateByIN;
        private System.Windows.Forms.Button button_UpdateByIC;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}