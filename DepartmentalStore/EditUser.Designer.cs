namespace DepartmentalStore
{
    partial class Form_EditUser
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
            this.tabControl_EditUser = new System.Windows.Forms.TabControl();
            this.tabPage_ChangePassword = new System.Windows.Forms.TabPage();
            this.button_ChangePassword = new System.Windows.Forms.Button();
            this.textBox_NewPassword = new System.Windows.Forms.TextBox();
            this.label_NewPassword = new System.Windows.Forms.Label();
            this.textBox_OldPassword = new System.Windows.Forms.TextBox();
            this.label_OldPassword = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.label_UserName = new System.Windows.Forms.Label();
            this.tabPage_DeleteUser = new System.Windows.Forms.TabPage();
            this.button_DeleteUser = new System.Windows.Forms.Button();
            this.textBox_AC = new System.Windows.Forms.TextBox();
            this.label_AC = new System.Windows.Forms.Label();
            this.textBox_UN = new System.Windows.Forms.TextBox();
            this.label_UN = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControl_EditUser.SuspendLayout();
            this.tabPage_ChangePassword.SuspendLayout();
            this.tabPage_DeleteUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_EditUser
            // 
            this.tabControl_EditUser.Controls.Add(this.tabPage_ChangePassword);
            this.tabControl_EditUser.Controls.Add(this.tabPage_DeleteUser);
            this.tabControl_EditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_EditUser.Location = new System.Drawing.Point(12, 12);
            this.tabControl_EditUser.Name = "tabControl_EditUser";
            this.tabControl_EditUser.SelectedIndex = 0;
            this.tabControl_EditUser.Size = new System.Drawing.Size(460, 437);
            this.tabControl_EditUser.TabIndex = 0;
            // 
            // tabPage_ChangePassword
            // 
            this.tabPage_ChangePassword.Controls.Add(this.button_ChangePassword);
            this.tabPage_ChangePassword.Controls.Add(this.textBox_NewPassword);
            this.tabPage_ChangePassword.Controls.Add(this.label_NewPassword);
            this.tabPage_ChangePassword.Controls.Add(this.textBox_OldPassword);
            this.tabPage_ChangePassword.Controls.Add(this.label_OldPassword);
            this.tabPage_ChangePassword.Controls.Add(this.textBox_UserName);
            this.tabPage_ChangePassword.Controls.Add(this.label_UserName);
            this.tabPage_ChangePassword.Location = new System.Drawing.Point(4, 29);
            this.tabPage_ChangePassword.Name = "tabPage_ChangePassword";
            this.tabPage_ChangePassword.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ChangePassword.Size = new System.Drawing.Size(452, 404);
            this.tabPage_ChangePassword.TabIndex = 0;
            this.tabPage_ChangePassword.Text = "Change Password";
            this.tabPage_ChangePassword.UseVisualStyleBackColor = true;
            // 
            // button_ChangePassword
            // 
            this.button_ChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ChangePassword.Location = new System.Drawing.Point(196, 220);
            this.button_ChangePassword.Name = "button_ChangePassword";
            this.button_ChangePassword.Size = new System.Drawing.Size(211, 32);
            this.button_ChangePassword.TabIndex = 19;
            this.button_ChangePassword.Text = "Change Password";
            this.button_ChangePassword.UseVisualStyleBackColor = true;
            this.button_ChangePassword.Click += new System.EventHandler(this.button_ChangePassword_Click);
            // 
            // textBox_NewPassword
            // 
            this.textBox_NewPassword.Location = new System.Drawing.Point(196, 144);
            this.textBox_NewPassword.Name = "textBox_NewPassword";
            this.textBox_NewPassword.Size = new System.Drawing.Size(211, 26);
            this.textBox_NewPassword.TabIndex = 15;
            this.textBox_NewPassword.UseSystemPasswordChar = true;
            // 
            // label_NewPassword
            // 
            this.label_NewPassword.AutoSize = true;
            this.label_NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NewPassword.Location = new System.Drawing.Point(19, 144);
            this.label_NewPassword.Name = "label_NewPassword";
            this.label_NewPassword.Size = new System.Drawing.Size(135, 20);
            this.label_NewPassword.TabIndex = 18;
            this.label_NewPassword.Text = "New Password :";
            // 
            // textBox_OldPassword
            // 
            this.textBox_OldPassword.Location = new System.Drawing.Point(196, 100);
            this.textBox_OldPassword.Name = "textBox_OldPassword";
            this.textBox_OldPassword.Size = new System.Drawing.Size(211, 26);
            this.textBox_OldPassword.TabIndex = 14;
            this.textBox_OldPassword.UseSystemPasswordChar = true;
            // 
            // label_OldPassword
            // 
            this.label_OldPassword.AutoSize = true;
            this.label_OldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_OldPassword.Location = new System.Drawing.Point(26, 100);
            this.label_OldPassword.Name = "label_OldPassword";
            this.label_OldPassword.Size = new System.Drawing.Size(128, 20);
            this.label_OldPassword.TabIndex = 17;
            this.label_OldPassword.Text = "Old Password :";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(196, 63);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(211, 26);
            this.textBox_UserName.TabIndex = 13;
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserName.Location = new System.Drawing.Point(36, 63);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(108, 20);
            this.label_UserName.TabIndex = 16;
            this.label_UserName.Text = "User Name :";
            // 
            // tabPage_DeleteUser
            // 
            this.tabPage_DeleteUser.Controls.Add(this.button_DeleteUser);
            this.tabPage_DeleteUser.Controls.Add(this.textBox_AC);
            this.tabPage_DeleteUser.Controls.Add(this.label_AC);
            this.tabPage_DeleteUser.Controls.Add(this.textBox_UN);
            this.tabPage_DeleteUser.Controls.Add(this.label_UN);
            this.tabPage_DeleteUser.Location = new System.Drawing.Point(4, 29);
            this.tabPage_DeleteUser.Name = "tabPage_DeleteUser";
            this.tabPage_DeleteUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DeleteUser.Size = new System.Drawing.Size(452, 404);
            this.tabPage_DeleteUser.TabIndex = 1;
            this.tabPage_DeleteUser.Text = "DeleteUser";
            this.tabPage_DeleteUser.UseVisualStyleBackColor = true;
            // 
            // button_DeleteUser
            // 
            this.button_DeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteUser.Location = new System.Drawing.Point(211, 248);
            this.button_DeleteUser.Name = "button_DeleteUser";
            this.button_DeleteUser.Size = new System.Drawing.Size(211, 32);
            this.button_DeleteUser.TabIndex = 17;
            this.button_DeleteUser.Text = "Delete User";
            this.button_DeleteUser.UseVisualStyleBackColor = true;
            this.button_DeleteUser.Click += new System.EventHandler(this.button_DeleteUser_Click);
            // 
            // textBox_AC
            // 
            this.textBox_AC.Location = new System.Drawing.Point(211, 161);
            this.textBox_AC.Name = "textBox_AC";
            this.textBox_AC.Size = new System.Drawing.Size(211, 26);
            this.textBox_AC.TabIndex = 15;
            this.textBox_AC.UseSystemPasswordChar = true;
            // 
            // label_AC
            // 
            this.label_AC.AutoSize = true;
            this.label_AC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AC.Location = new System.Drawing.Point(34, 161);
            this.label_AC.Name = "label_AC";
            this.label_AC.Size = new System.Drawing.Size(116, 20);
            this.label_AC.TabIndex = 16;
            this.label_AC.Text = "Admin Code :";
            // 
            // textBox_UN
            // 
            this.textBox_UN.Location = new System.Drawing.Point(211, 97);
            this.textBox_UN.Name = "textBox_UN";
            this.textBox_UN.Size = new System.Drawing.Size(211, 26);
            this.textBox_UN.TabIndex = 7;
            // 
            // label_UN
            // 
            this.label_UN.AutoSize = true;
            this.label_UN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UN.Location = new System.Drawing.Point(42, 97);
            this.label_UN.Name = "label_UN";
            this.label_UN.Size = new System.Drawing.Size(108, 20);
            this.label_UN.TabIndex = 8;
            this.label_UN.Text = "User Name :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form_EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.tabControl_EditUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form_EditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit User";
            this.tabControl_EditUser.ResumeLayout(false);
            this.tabPage_ChangePassword.ResumeLayout(false);
            this.tabPage_ChangePassword.PerformLayout();
            this.tabPage_DeleteUser.ResumeLayout(false);
            this.tabPage_DeleteUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_EditUser;
        private System.Windows.Forms.TabPage tabPage_ChangePassword;
        private System.Windows.Forms.TabPage tabPage_DeleteUser;
        private System.Windows.Forms.TextBox textBox_NewPassword;
        private System.Windows.Forms.Label label_NewPassword;
        private System.Windows.Forms.TextBox textBox_OldPassword;
        private System.Windows.Forms.Label label_OldPassword;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.Button button_ChangePassword;
        private System.Windows.Forms.TextBox textBox_UN;
        private System.Windows.Forms.Label label_UN;
        private System.Windows.Forms.TextBox textBox_AC;
        private System.Windows.Forms.Label label_AC;
        private System.Windows.Forms.Button button_DeleteUser;
        private System.Windows.Forms.MenuStrip menuStrip1;

    }
}