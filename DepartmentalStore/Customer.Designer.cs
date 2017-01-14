namespace DepartmentalStore
{
    partial class Customer
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
            this.groupBox_Customer = new System.Windows.Forms.GroupBox();
            this.CadressBox = new System.Windows.Forms.RichTextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.CidBox = new System.Windows.Forms.TextBox();
            this.textBox_CustomerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_Customer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Customer
            // 
            this.groupBox_Customer.Controls.Add(this.CadressBox);
            this.groupBox_Customer.Controls.Add(this.CancelButton);
            this.groupBox_Customer.Controls.Add(this.Savebutton);
            this.groupBox_Customer.Controls.Add(this.textBox_Phone);
            this.groupBox_Customer.Controls.Add(this.CidBox);
            this.groupBox_Customer.Controls.Add(this.textBox_CustomerName);
            this.groupBox_Customer.Controls.Add(this.label5);
            this.groupBox_Customer.Controls.Add(this.label4);
            this.groupBox_Customer.Controls.Add(this.label3);
            this.groupBox_Customer.Controls.Add(this.label2);
            this.groupBox_Customer.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Customer.ForeColor = System.Drawing.Color.Blue;
            this.groupBox_Customer.Location = new System.Drawing.Point(100, 78);
            this.groupBox_Customer.Name = "groupBox_Customer";
            this.groupBox_Customer.Size = new System.Drawing.Size(684, 404);
            this.groupBox_Customer.TabIndex = 1;
            this.groupBox_Customer.TabStop = false;
            // 
            // CadressBox
            // 
            this.CadressBox.Location = new System.Drawing.Point(218, 182);
            this.CadressBox.Name = "CadressBox";
            this.CadressBox.Size = new System.Drawing.Size(221, 70);
            this.CadressBox.TabIndex = 10;
            this.CadressBox.Text = "";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(355, 258);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(84, 27);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // Savebutton
            // 
            this.Savebutton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebutton.ForeColor = System.Drawing.Color.Black;
            this.Savebutton.Location = new System.Drawing.Point(218, 258);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(84, 27);
            this.Savebutton.TabIndex = 8;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Phone.Location = new System.Drawing.Point(218, 131);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(221, 21);
            this.textBox_Phone.TabIndex = 6;
            this.textBox_Phone.Text = "+880";
            // 
            // CidBox
            // 
            this.CidBox.Location = new System.Drawing.Point(218, 92);
            this.CidBox.Name = "CidBox";
            this.CidBox.Size = new System.Drawing.Size(221, 28);
            this.CidBox.TabIndex = 5;
            // 
            // textBox_CustomerName
            // 
            this.textBox_CustomerName.Location = new System.Drawing.Point(218, 58);
            this.textBox_CustomerName.Name = "textBox_CustomerName";
            this.textBox_CustomerName.Size = new System.Drawing.Size(221, 28);
            this.textBox_CustomerName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(40, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Customer Address :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(55, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Customer Phone :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(90, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(60, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Name :";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.groupBox_Customer);
            this.MaximizeBox = false;
            this.Name = "Customer";
            this.Text = "Customer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox_Customer.ResumeLayout(false);
            this.groupBox_Customer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Customer;
        private System.Windows.Forms.RichTextBox CadressBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.TextBox CidBox;
        private System.Windows.Forms.TextBox textBox_CustomerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}