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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPassword));
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.UserID = new System.Windows.Forms.Label();
            this.IsExist = new System.Windows.Forms.Label();
            this.RecoverBtn = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.PassBanner = new System.Windows.Forms.Label();
            this.ForgetPass = new System.Windows.Forms.Label();
            this.FindAccount = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.LoginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginPanel.Controls.Add(this.pictureBox3);
            this.LoginPanel.Controls.Add(this.pictureBox2);
            this.LoginPanel.Controls.Add(this.pictureBox1);
            this.LoginPanel.Controls.Add(this.TxtUser);
            this.LoginPanel.Controls.Add(this.UserID);
            this.LoginPanel.Controls.Add(this.IsExist);
            this.LoginPanel.Controls.Add(this.RecoverBtn);
            this.LoginPanel.Controls.Add(this.TxtPassword);
            this.LoginPanel.Controls.Add(this.LabelPassword);
            this.LoginPanel.Controls.Add(this.PassBanner);
            this.LoginPanel.Controls.Add(this.ForgetPass);
            this.LoginPanel.Controls.Add(this.FindAccount);
            this.LoginPanel.Location = new System.Drawing.Point(35, 34);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(706, 387);
            this.LoginPanel.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(126, 135);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // TxtUser
            // 
            this.TxtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TxtUser.Location = new System.Drawing.Point(121, 167);
            this.TxtUser.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(510, 29);
            this.TxtUser.TabIndex = 2;
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.UserID.Location = new System.Drawing.Point(148, 138);
            this.UserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(52, 16);
            this.UserID.TabIndex = 0;
            this.UserID.Text = "User ID";
            // 
            // IsExist
            // 
            this.IsExist.AutoSize = true;
            this.IsExist.BackColor = System.Drawing.Color.White;
            this.IsExist.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsExist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(91)))), ((int)(((byte)(205)))));
            this.IsExist.Location = new System.Drawing.Point(117, 96);
            this.IsExist.Name = "IsExist";
            this.IsExist.Size = new System.Drawing.Size(113, 22);
            this.IsExist.TabIndex = 10;
            this.IsExist.Text = "⚫ Account Exist";
            this.IsExist.Visible = false;
            // 
            // RecoverBtn
            // 
            this.RecoverBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(91)))), ((int)(((byte)(205)))));
            this.RecoverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.RecoverBtn.ForeColor = System.Drawing.Color.White;
            this.RecoverBtn.Location = new System.Drawing.Point(121, 289);
            this.RecoverBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RecoverBtn.Name = "RecoverBtn";
            this.RecoverBtn.Size = new System.Drawing.Size(510, 46);
            this.RecoverBtn.TabIndex = 9;
            this.RecoverBtn.Text = "Recover Account";
            this.RecoverBtn.UseVisualStyleBackColor = false;
            this.RecoverBtn.Visible = false;
            this.RecoverBtn.Click += new System.EventHandler(this.RecoverBtn_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Enabled = false;
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TxtPassword.Location = new System.Drawing.Point(121, 234);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(510, 29);
            this.TxtPassword.TabIndex = 8;
            this.TxtPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.LabelPassword.Location = new System.Drawing.Point(148, 207);
            this.LabelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(97, 16);
            this.LabelPassword.TabIndex = 7;
            this.LabelPassword.Text = "New Password";
            this.LabelPassword.Click += new System.EventHandler(this.LabelPassword_Click);
            // 
            // PassBanner
            // 
            this.PassBanner.AutoSize = true;
            this.PassBanner.Font = new System.Drawing.Font("Poppins", 10F);
            this.PassBanner.Location = new System.Drawing.Point(178, 59);
            this.PassBanner.Name = "PassBanner";
            this.PassBanner.Size = new System.Drawing.Size(243, 25);
            this.PassBanner.TabIndex = 6;
            this.PassBanner.Text = "Enter User ID To Change Password";
            // 
            // ForgetPass
            // 
            this.ForgetPass.AutoSize = true;
            this.ForgetPass.Font = new System.Drawing.Font("Poppins Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgetPass.Location = new System.Drawing.Point(173, 22);
            this.ForgetPass.Name = "ForgetPass";
            this.ForgetPass.Size = new System.Drawing.Size(266, 48);
            this.ForgetPass.TabIndex = 5;
            this.ForgetPass.Text = "Recover Account";
            this.ForgetPass.Click += new System.EventHandler(this.label4_Click);
            // 
            // FindAccount
            // 
            this.FindAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.FindAccount.Location = new System.Drawing.Point(121, 289);
            this.FindAccount.Margin = new System.Windows.Forms.Padding(2);
            this.FindAccount.Name = "FindAccount";
            this.FindAccount.Size = new System.Drawing.Size(510, 46);
            this.FindAccount.TabIndex = 4;
            this.FindAccount.Text = "Find Account";
            this.FindAccount.UseVisualStyleBackColor = true;
            this.FindAccount.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(126, 205);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(18, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(780, 462);
            this.Controls.Add(this.LoginPanel);
            this.Name = "ForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Label IsExist;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}