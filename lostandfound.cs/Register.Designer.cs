namespace lostandfound.cs
{
    partial class Register
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
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_Registration = new System.Windows.Forms.Button();
            this.RD_Officer = new System.Windows.Forms.RadioButton();
            this.RD_Student = new System.Windows.Forms.RadioButton();
            this.SelectProf = new System.Windows.Forms.Label();
            this.Txt_UserID = new System.Windows.Forms.TextBox();
            this.LB_UserID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.LB_LastName = new System.Windows.Forms.Label();
            this.LB_FirstName = new System.Windows.Forms.Label();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.LB_Password = new System.Windows.Forms.Label();
            this.Txt_ConPassword = new System.Windows.Forms.TextBox();
            this.LB_ConPassword = new System.Windows.Forms.Label();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.White;
            this.LoginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginPanel.Controls.Add(this.Txt_ConPassword);
            this.LoginPanel.Controls.Add(this.LB_ConPassword);
            this.LoginPanel.Controls.Add(this.Txt_Password);
            this.LoginPanel.Controls.Add(this.LB_Password);
            this.LoginPanel.Controls.Add(this.Btn_Exit);
            this.LoginPanel.Controls.Add(this.Btn_Registration);
            this.LoginPanel.Controls.Add(this.RD_Officer);
            this.LoginPanel.Controls.Add(this.RD_Student);
            this.LoginPanel.Controls.Add(this.SelectProf);
            this.LoginPanel.Controls.Add(this.Txt_UserID);
            this.LoginPanel.Controls.Add(this.LB_UserID);
            this.LoginPanel.Controls.Add(this.label5);
            this.LoginPanel.Controls.Add(this.label4);
            this.LoginPanel.Controls.Add(this.TxtEmail);
            this.LoginPanel.Controls.Add(this.TxtUser);
            this.LoginPanel.Controls.Add(this.LB_LastName);
            this.LoginPanel.Controls.Add(this.LB_FirstName);
            this.LoginPanel.Location = new System.Drawing.Point(27, 25);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(655, 413);
            this.LoginPanel.TabIndex = 8;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(450, 352);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(94, 33);
            this.Btn_Exit.TabIndex = 13;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            // 
            // Btn_Registration
            // 
            this.Btn_Registration.Location = new System.Drawing.Point(108, 352);
            this.Btn_Registration.Name = "Btn_Registration";
            this.Btn_Registration.Size = new System.Drawing.Size(94, 33);
            this.Btn_Registration.TabIndex = 12;
            this.Btn_Registration.Text = "Register";
            this.Btn_Registration.UseVisualStyleBackColor = true;
            this.Btn_Registration.Click += new System.EventHandler(this.Btn_Registration_Click);
            // 
            // RD_Officer
            // 
            this.RD_Officer.AutoSize = true;
            this.RD_Officer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.RD_Officer.Location = new System.Drawing.Point(193, 310);
            this.RD_Officer.Name = "RD_Officer";
            this.RD_Officer.Size = new System.Drawing.Size(63, 20);
            this.RD_Officer.TabIndex = 11;
            this.RD_Officer.TabStop = true;
            this.RD_Officer.Text = "Officer";
            this.RD_Officer.UseVisualStyleBackColor = true;
            // 
            // RD_Student
            // 
            this.RD_Student.AutoSize = true;
            this.RD_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.RD_Student.Location = new System.Drawing.Point(108, 310);
            this.RD_Student.Name = "RD_Student";
            this.RD_Student.Size = new System.Drawing.Size(70, 20);
            this.RD_Student.TabIndex = 10;
            this.RD_Student.TabStop = true;
            this.RD_Student.Text = "Student";
            this.RD_Student.UseVisualStyleBackColor = true;
            // 
            // SelectProf
            // 
            this.SelectProf.AutoSize = true;
            this.SelectProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.SelectProf.Location = new System.Drawing.Point(105, 279);
            this.SelectProf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectProf.Name = "SelectProf";
            this.SelectProf.Size = new System.Drawing.Size(116, 16);
            this.SelectProf.TabIndex = 9;
            this.SelectProf.Text = "Select Occupation";
            // 
            // Txt_UserID
            // 
            this.Txt_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Txt_UserID.Location = new System.Drawing.Point(227, 166);
            this.Txt_UserID.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_UserID.Name = "Txt_UserID";
            this.Txt_UserID.Size = new System.Drawing.Size(317, 23);
            this.Txt_UserID.TabIndex = 8;
            // 
            // LB_UserID
            // 
            this.LB_UserID.AutoSize = true;
            this.LB_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.LB_UserID.Location = new System.Drawing.Point(105, 170);
            this.LB_UserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_UserID.Name = "LB_UserID";
            this.LB_UserID.Size = new System.Drawing.Size(52, 16);
            this.LB_UserID.TabIndex = 7;
            this.LB_UserID.Text = "User ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(605, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(24, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Registration";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TxtEmail.Location = new System.Drawing.Point(227, 127);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(317, 23);
            this.TxtEmail.TabIndex = 3;
            // 
            // TxtUser
            // 
            this.TxtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TxtUser.Location = new System.Drawing.Point(227, 87);
            this.TxtUser.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(317, 23);
            this.TxtUser.TabIndex = 2;
            // 
            // LB_LastName
            // 
            this.LB_LastName.AutoSize = true;
            this.LB_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.LB_LastName.Location = new System.Drawing.Point(105, 131);
            this.LB_LastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_LastName.Name = "LB_LastName";
            this.LB_LastName.Size = new System.Drawing.Size(41, 16);
            this.LB_LastName.TabIndex = 1;
            this.LB_LastName.Text = "Email";
            // 
            // LB_FirstName
            // 
            this.LB_FirstName.AutoSize = true;
            this.LB_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.LB_FirstName.Location = new System.Drawing.Point(105, 91);
            this.LB_FirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_FirstName.Name = "LB_FirstName";
            this.LB_FirstName.Size = new System.Drawing.Size(68, 16);
            this.LB_FirstName.TabIndex = 0;
            this.LB_FirstName.Text = "Full Name";
            // 
            // Txt_Password
            // 
            this.Txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Txt_Password.Location = new System.Drawing.Point(227, 206);
            this.Txt_Password.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.Size = new System.Drawing.Size(317, 23);
            this.Txt_Password.TabIndex = 15;
            // 
            // LB_Password
            // 
            this.LB_Password.AutoSize = true;
            this.LB_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.LB_Password.Location = new System.Drawing.Point(105, 210);
            this.LB_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Password.Name = "LB_Password";
            this.LB_Password.Size = new System.Drawing.Size(67, 16);
            this.LB_Password.TabIndex = 14;
            this.LB_Password.Text = "Password";
            // 
            // Txt_ConPassword
            // 
            this.Txt_ConPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Txt_ConPassword.Location = new System.Drawing.Point(227, 243);
            this.Txt_ConPassword.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_ConPassword.Name = "Txt_ConPassword";
            this.Txt_ConPassword.PasswordChar = '*';
            this.Txt_ConPassword.Size = new System.Drawing.Size(317, 23);
            this.Txt_ConPassword.TabIndex = 17;
            // 
            // LB_ConPassword
            // 
            this.LB_ConPassword.AutoSize = true;
            this.LB_ConPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.LB_ConPassword.Location = new System.Drawing.Point(105, 247);
            this.LB_ConPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_ConPassword.Name = "LB_ConPassword";
            this.LB_ConPassword.Size = new System.Drawing.Size(115, 16);
            this.LB_ConPassword.TabIndex = 16;
            this.LB_ConPassword.Text = "Confirm Password";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 475);
            this.Controls.Add(this.LoginPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Register";
            this.Text = "Register";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.Label LB_LastName;
        private System.Windows.Forms.Label LB_FirstName;
        private System.Windows.Forms.TextBox Txt_UserID;
        private System.Windows.Forms.Label LB_UserID;
        private System.Windows.Forms.RadioButton RD_Officer;
        private System.Windows.Forms.RadioButton RD_Student;
        private System.Windows.Forms.Label SelectProf;
        private System.Windows.Forms.Button Btn_Registration;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.TextBox Txt_ConPassword;
        private System.Windows.Forms.Label LB_ConPassword;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label LB_Password;
    }
}