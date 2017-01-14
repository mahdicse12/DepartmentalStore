namespace DepartmentalStore
{
    partial class Form_AddUser
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
            this.groupBox_SignUp = new System.Windows.Forms.GroupBox();
            this.textBox_AdminCode = new System.Windows.Forms.TextBox();
            this.label_SignUpCode = new System.Windows.Forms.Label();
            this.textBox_ConformPassword = new System.Windows.Forms.TextBox();
            this.label_ConformPassword = new System.Windows.Forms.Label();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_AddUser = new System.Windows.Forms.Button();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.label_UserName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox_SignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_SignUp
            // 
            this.groupBox_SignUp.Controls.Add(this.textBox_AdminCode);
            this.groupBox_SignUp.Controls.Add(this.label_SignUpCode);
            this.groupBox_SignUp.Controls.Add(this.textBox_ConformPassword);
            this.groupBox_SignUp.Controls.Add(this.label_ConformPassword);
            this.groupBox_SignUp.Controls.Add(this.button_Close);
            this.groupBox_SignUp.Controls.Add(this.button_AddUser);
            this.groupBox_SignUp.Controls.Add(this.textBox_Password);
            this.groupBox_SignUp.Controls.Add(this.label_Password);
            this.groupBox_SignUp.Controls.Add(this.textBox_UserName);
            this.groupBox_SignUp.Controls.Add(this.label_UserName);
            this.groupBox_SignUp.Location = new System.Drawing.Point(12, 178);
            this.groupBox_SignUp.Name = "groupBox_SignUp";
            this.groupBox_SignUp.Size = new System.Drawing.Size(460, 271);
            this.groupBox_SignUp.TabIndex = 0;
            this.groupBox_SignUp.TabStop = false;
            this.groupBox_SignUp.Enter += new System.EventHandler(this.groupBox_SignUp_Enter);
            // 
            // textBox_AdminCode
            // 
            this.textBox_AdminCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AdminCode.Location = new System.Drawing.Point(183, 151);
            this.textBox_AdminCode.Name = "textBox_AdminCode";
            this.textBox_AdminCode.Size = new System.Drawing.Size(211, 26);
            this.textBox_AdminCode.TabIndex = 4;
            this.textBox_AdminCode.UseSystemPasswordChar = true;
            // 
            // label_SignUpCode
            // 
            this.label_SignUpCode.AutoSize = true;
            this.label_SignUpCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SignUpCode.Location = new System.Drawing.Point(59, 151);
            this.label_SignUpCode.Name = "label_SignUpCode";
            this.label_SignUpCode.Size = new System.Drawing.Size(116, 20);
            this.label_SignUpCode.TabIndex = 14;
            this.label_SignUpCode.Text = "Admin Code :";
            // 
            // textBox_ConformPassword
            // 
            this.textBox_ConformPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ConformPassword.Location = new System.Drawing.Point(183, 108);
            this.textBox_ConformPassword.Name = "textBox_ConformPassword";
            this.textBox_ConformPassword.Size = new System.Drawing.Size(211, 26);
            this.textBox_ConformPassword.TabIndex = 3;
            this.textBox_ConformPassword.UseSystemPasswordChar = true;
            // 
            // label_ConformPassword
            // 
            this.label_ConformPassword.AutoSize = true;
            this.label_ConformPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ConformPassword.Location = new System.Drawing.Point(6, 108);
            this.label_ConformPassword.Name = "label_ConformPassword";
            this.label_ConformPassword.Size = new System.Drawing.Size(169, 20);
            this.label_ConformPassword.TabIndex = 12;
            this.label_ConformPassword.Text = "Conform Password :";
            // 
            // button_Close
            // 
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.Location = new System.Drawing.Point(314, 199);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(82, 32);
            this.button_Close.TabIndex = 6;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_LClose_Click);
            // 
            // button_AddUser
            // 
            this.button_AddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddUser.Location = new System.Drawing.Point(183, 199);
            this.button_AddUser.Name = "button_AddUser";
            this.button_AddUser.Size = new System.Drawing.Size(93, 32);
            this.button_AddUser.TabIndex = 5;
            this.button_AddUser.Text = "Add User";
            this.button_AddUser.UseVisualStyleBackColor = true;
            this.button_AddUser.Click += new System.EventHandler(this.button_AddUser_Click);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(183, 64);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(211, 26);
            this.textBox_Password.TabIndex = 2;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(79, 64);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(96, 20);
            this.label_Password.TabIndex = 8;
            this.label_Password.Text = "Password :";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UserName.Location = new System.Drawing.Point(183, 27);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(211, 26);
            this.textBox_UserName.TabIndex = 1;
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserName.Location = new System.Drawing.Point(67, 27);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(108, 20);
            this.label_UserName.TabIndex = 6;
            this.label_UserName.Text = "User Name :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(12, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 50);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // Form_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox_SignUp);
            this.MaximizeBox = false;
            this.Name = "Form_AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.Form_AddUser_Load);
            this.groupBox_SignUp.ResumeLayout(false);
            this.groupBox_SignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_SignUp;
        private System.Windows.Forms.TextBox textBox_ConformPassword;
        private System.Windows.Forms.Label label_ConformPassword;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_AddUser;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.TextBox textBox_AdminCode;
        private System.Windows.Forms.Label label_SignUpCode;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}