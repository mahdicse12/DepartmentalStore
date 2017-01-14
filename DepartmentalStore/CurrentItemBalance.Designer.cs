namespace DepartmentalStore
{
    partial class Form_CurrentItemBalance
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
            this.button_Close = new System.Windows.Forms.Button();
            this.button_TotalBalance = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_ViewByIN = new System.Windows.Forms.Button();
            this.textBox_IN = new System.Windows.Forms.TextBox();
            this.label_IN = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_CurrentItemBalance = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_TotalBalance = new System.Windows.Forms.Label();
            this.button_ViewByGN = new System.Windows.Forms.Button();
            this.textBox_GN = new System.Windows.Forms.TextBox();
            this.label_GroupName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CurrentItemBalance)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Close
            // 
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.Location = new System.Drawing.Point(1079, 57);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 32);
            this.button_Close.TabIndex = 7;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_TotalBalance
            // 
            this.button_TotalBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TotalBalance.Location = new System.Drawing.Point(1010, 19);
            this.button_TotalBalance.Name = "button_TotalBalance";
            this.button_TotalBalance.Size = new System.Drawing.Size(144, 32);
            this.button_TotalBalance.TabIndex = 6;
            this.button_TotalBalance.Text = "Total Balance";
            this.button_TotalBalance.UseVisualStyleBackColor = true;
            this.button_TotalBalance.Click += new System.EventHandler(this.button_TotalBalance_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Refresh.Location = new System.Drawing.Point(842, 19);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(144, 31);
            this.button_Refresh.TabIndex = 5;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_ViewByIN
            // 
            this.button_ViewByIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ViewByIN.Location = new System.Drawing.Point(354, 19);
            this.button_ViewByIN.Name = "button_ViewByIN";
            this.button_ViewByIN.Size = new System.Drawing.Size(101, 32);
            this.button_ViewByIN.TabIndex = 2;
            this.button_ViewByIN.Text = "View";
            this.button_ViewByIN.UseVisualStyleBackColor = true;
            this.button_ViewByIN.Click += new System.EventHandler(this.button_ViewByIN_Click);
            // 
            // textBox_IN
            // 
            this.textBox_IN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_IN.Location = new System.Drawing.Point(132, 22);
            this.textBox_IN.Name = "textBox_IN";
            this.textBox_IN.Size = new System.Drawing.Size(194, 26);
            this.textBox_IN.TabIndex = 1;
            // 
            // label_IN
            // 
            this.label_IN.AutoSize = true;
            this.label_IN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IN.Location = new System.Drawing.Point(6, 22);
            this.label_IN.Name = "label_IN";
            this.label_IN.Size = new System.Drawing.Size(106, 20);
            this.label_IN.TabIndex = 0;
            this.label_IN.Text = "Item Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_CurrentItemBalance);
            this.groupBox2.Location = new System.Drawing.Point(12, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1160, 321);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView_CurrentItemBalance
            // 
            this.dataGridView_CurrentItemBalance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_CurrentItemBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CurrentItemBalance.Location = new System.Drawing.Point(6, 10);
            this.dataGridView_CurrentItemBalance.Name = "dataGridView_CurrentItemBalance";
            this.dataGridView_CurrentItemBalance.Size = new System.Drawing.Size(1148, 305);
            this.dataGridView_CurrentItemBalance.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_TotalBalance);
            this.groupBox1.Controls.Add(this.button_ViewByGN);
            this.groupBox1.Controls.Add(this.textBox_GN);
            this.groupBox1.Controls.Add(this.label_GroupName);
            this.groupBox1.Controls.Add(this.button_Close);
            this.groupBox1.Controls.Add(this.button_TotalBalance);
            this.groupBox1.Controls.Add(this.button_Refresh);
            this.groupBox1.Controls.Add(this.button_ViewByIN);
            this.groupBox1.Controls.Add(this.textBox_IN);
            this.groupBox1.Controls.Add(this.label_IN);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label_TotalBalance
            // 
            this.label_TotalBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalBalance.Location = new System.Drawing.Point(522, 25);
            this.label_TotalBalance.Name = "label_TotalBalance";
            this.label_TotalBalance.Size = new System.Drawing.Size(258, 36);
            this.label_TotalBalance.TabIndex = 12;
            // 
            // button_ViewByGN
            // 
            this.button_ViewByGN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ViewByGN.Location = new System.Drawing.Point(354, 57);
            this.button_ViewByGN.Name = "button_ViewByGN";
            this.button_ViewByGN.Size = new System.Drawing.Size(101, 27);
            this.button_ViewByGN.TabIndex = 4;
            this.button_ViewByGN.Text = "View";
            this.button_ViewByGN.UseVisualStyleBackColor = true;
            this.button_ViewByGN.Click += new System.EventHandler(this.button_ViewByGN_Click);
            // 
            // textBox_GN
            // 
            this.textBox_GN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_GN.Location = new System.Drawing.Point(132, 64);
            this.textBox_GN.Name = "textBox_GN";
            this.textBox_GN.Size = new System.Drawing.Size(194, 26);
            this.textBox_GN.TabIndex = 3;
            // 
            // label_GroupName
            // 
            this.label_GroupName.AutoSize = true;
            this.label_GroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GroupName.Location = new System.Drawing.Point(6, 64);
            this.label_GroupName.Name = "label_GroupName";
            this.label_GroupName.Size = new System.Drawing.Size(120, 20);
            this.label_GroupName.TabIndex = 9;
            this.label_GroupName.Text = "Group Name :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(12, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1160, 50);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // Form_CurrentItemBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form_CurrentItemBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Current Item Balance";
            this.Load += new System.EventHandler(this.Form_CurrentItemBalance_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CurrentItemBalance)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_TotalBalance;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button button_ViewByIN;
        private System.Windows.Forms.TextBox textBox_IN;
        private System.Windows.Forms.Label label_IN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_ViewByGN;
        private System.Windows.Forms.TextBox textBox_GN;
        private System.Windows.Forms.Label label_GroupName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView_CurrentItemBalance;
        private System.Windows.Forms.Label label_TotalBalance;
    }
}