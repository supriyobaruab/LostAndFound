namespace lostandfound.cs
{
    partial class AdminDashboard
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
            this.LB_User = new System.Windows.Forms.Label();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogoHeader = new System.Windows.Forms.Panel();
            this.LB_LFHeader = new System.Windows.Forms.Label();
            this.LB_AdminP = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.PanelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_User
            // 
            this.LB_User.AutoSize = true;
            this.LB_User.BackColor = System.Drawing.SystemColors.Control;
            this.LB_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LB_User.Location = new System.Drawing.Point(54, 88);
            this.LB_User.Name = "LB_User";
            this.LB_User.Size = new System.Drawing.Size(43, 20);
            this.LB_User.TabIndex = 1;
            this.LB_User.Text = "User";
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.Silver;
            this.PanelHeader.Controls.Add(this.btn_Logout);
            this.PanelHeader.Controls.Add(this.LB_AdminP);
            this.PanelHeader.Controls.Add(this.LB_LFHeader);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(800, 52);
            this.PanelHeader.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 1);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LogoHeader
            // 
            this.LogoHeader.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LogoHeader.Location = new System.Drawing.Point(24, 12);
            this.LogoHeader.Name = "LogoHeader";
            this.LogoHeader.Size = new System.Drawing.Size(28, 28);
            this.LogoHeader.TabIndex = 4;
            // 
            // LB_LFHeader
            // 
            this.LB_LFHeader.AutoSize = true;
            this.LB_LFHeader.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LB_LFHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.LB_LFHeader.Location = new System.Drawing.Point(68, 17);
            this.LB_LFHeader.Name = "LB_LFHeader";
            this.LB_LFHeader.Size = new System.Drawing.Size(130, 19);
            this.LB_LFHeader.TabIndex = 5;
            this.LB_LFHeader.Text = "Lost & Found System";
            this.LB_LFHeader.Click += new System.EventHandler(this.label1_Click);
            // 
            // LB_AdminP
            // 
            this.LB_AdminP.AutoSize = true;
            this.LB_AdminP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LB_AdminP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(124)))), ((int)(((byte)(147)))));
            this.LB_AdminP.Location = new System.Drawing.Point(195, 21);
            this.LB_AdminP.Name = "LB_AdminP";
            this.LB_AdminP.Size = new System.Drawing.Size(83, 15);
            this.LB_AdminP.TabIndex = 5;
            this.LB_AdminP.Text = "- Admin Panel";
            this.LB_AdminP.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.White;
            this.btn_Logout.FlatAppearance.BorderSize = 2;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(138)))));
            this.btn_Logout.Location = new System.Drawing.Point(728, 13);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(60, 30);
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogoHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.LB_User);
            this.Name = "AdminDashboard";
            this.RightToLeftLayout = true;
            this.Text = "AdminDashboard";
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_User;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel LogoHeader;
        private System.Windows.Forms.Label LB_LFHeader;
        private System.Windows.Forms.Label LB_AdminP;
        private System.Windows.Forms.Button btn_Logout;
    }
}