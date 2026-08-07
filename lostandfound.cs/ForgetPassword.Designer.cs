namespace lostandfound.cs
{
    partial class ForgetPassword
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
            this.ForgetPass = new System.Windows.Forms.Label();
            this.FindAccount = new System.Windows.Forms.Button();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.UserID = new System.Windows.Forms.Label();
            this.PassBanner = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.RecoverBtn = new System.Windows.Forms.Button();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.White;
            this.LoginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginPanel.Controls.Add(this.RecoverBtn);
            this.LoginPanel.Controls.Add(this.TxtPassword);
            this.LoginPanel.Controls.Add(this.LabelPassword);
            this.LoginPanel.Controls.Add(this.PassBanner);
            this.LoginPanel.Controls.Add(this.ForgetPass);
            this.LoginPanel.Controls.Add(this.FindAccount);
            this.LoginPanel.Controls.Add(this.TxtUser);
            this.LoginPanel.Controls.Add(this.UserID);
            this.LoginPanel.Location = new System.Drawing.Point(35, 34);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(598, 343);
            this.LoginPanel.TabIndex = 8;
            // 
            // ForgetPass
            // 
            this.ForgetPass.AutoSize = true;
            this.ForgetPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForgetPass.Location = new System.Drawing.Point(24, 17);
            this.ForgetPass.Name = "ForgetPass";
            this.ForgetPass.Size = new System.Drawing.Size(126, 21);
            this.ForgetPass.TabIndex = 5;
            this.ForgetPass.Text = "Recover Account";
            this.ForgetPass.Click += new System.EventHandler(this.label4_Click);
            // 
            // FindAccount
            // 
            this.FindAccount.Location = new System.Drawing.Point(129, 196);
            this.FindAccount.Margin = new System.Windows.Forms.Padding(2);
            this.FindAccount.Name = "FindAccount";
            this.FindAccount.Size = new System.Drawing.Size(328, 31);
            this.FindAccount.TabIndex = 4;
            this.FindAccount.Text = "Find Account";
            this.FindAccount.UseVisualStyleBackColor = true;
            this.FindAccount.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtUser
            // 
            this.TxtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TxtUser.Location = new System.Drawing.Point(254, 134);
            this.TxtUser.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(181, 23);
            this.TxtUser.TabIndex = 2;
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.UserID.Location = new System.Drawing.Point(152, 137);
            this.UserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(52, 16);
            this.UserID.TabIndex = 0;
            this.UserID.Text = "User ID";
            // 
            // PassBanner
            // 
            this.PassBanner.AutoSize = true;
            this.PassBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.PassBanner.Location = new System.Drawing.Point(157, 78);
            this.PassBanner.Name = "PassBanner";
            this.PassBanner.Size = new System.Drawing.Size(279, 22);
            this.PassBanner.TabIndex = 6;
            this.PassBanner.Text = "Enter User ID To Change Password";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TxtPassword.Location = new System.Drawing.Point(255, 134);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(181, 23);
            this.TxtPassword.TabIndex = 8;
            this.TxtPassword.Visible = false;
            this.TxtPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.LabelPassword.Location = new System.Drawing.Point(153, 137);
            this.LabelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(97, 16);
            this.LabelPassword.TabIndex = 7;
            this.LabelPassword.Text = "New Password";
            this.LabelPassword.Visible = false;
            // 
            // RecoverBtn
            // 
            this.RecoverBtn.Location = new System.Drawing.Point(129, 196);
            this.RecoverBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RecoverBtn.Name = "RecoverBtn";
            this.RecoverBtn.Size = new System.Drawing.Size(328, 31);
            this.RecoverBtn.TabIndex = 9;
            this.RecoverBtn.Text = "Recover Account";
            this.RecoverBtn.UseVisualStyleBackColor = true;
            this.RecoverBtn.Visible = false;
            this.RecoverBtn.Click += new System.EventHandler(this.RecoverBtn_Click);
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 406);
            this.Controls.Add(this.LoginPanel);
            this.Name = "ForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPassword";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label ForgetPass;
        private System.Windows.Forms.Button FindAccount;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Label PassBanner;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Button RecoverBtn;
    }
}