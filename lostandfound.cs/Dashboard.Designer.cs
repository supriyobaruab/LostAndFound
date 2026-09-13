namespace lostandfound.cs
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.Txt_Welcome = new System.Windows.Forms.Label();
            this.btn_ReportLost = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_ReportItem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Btn_FindItems = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Btn_MyReports = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Welcome
            // 
            this.Txt_Welcome.AutoSize = true;
            this.Txt_Welcome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Welcome.ForeColor = System.Drawing.Color.Navy;
            this.Txt_Welcome.Location = new System.Drawing.Point(67, 99);
            this.Txt_Welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Txt_Welcome.Name = "Txt_Welcome";
            this.Txt_Welcome.Size = new System.Drawing.Size(132, 18);
            this.Txt_Welcome.TabIndex = 0;
            this.Txt_Welcome.Text = "Welcome Back, ";
            // 
            // btn_ReportLost
            // 
            this.btn_ReportLost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.btn_ReportLost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ReportLost.Location = new System.Drawing.Point(15, 80);
            this.btn_ReportLost.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ReportLost.Name = "btn_ReportLost";
            this.btn_ReportLost.Size = new System.Drawing.Size(114, 40);
            this.btn_ReportLost.TabIndex = 1;
            this.btn_ReportLost.Text = "Report Lost Item";
            this.btn_ReportLost.UseVisualStyleBackColor = false;
            this.btn_ReportLost.Click += new System.EventHandler(this.btn_ReportLost_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_ReportLost);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(70, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 139);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 38);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.Btn_ReportItem);
            this.panel2.Location = new System.Drawing.Point(408, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 139);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 38);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Btn_ReportItem
            // 
            this.Btn_ReportItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Btn_ReportItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ReportItem.Location = new System.Drawing.Point(15, 80);
            this.Btn_ReportItem.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ReportItem.Name = "Btn_ReportItem";
            this.Btn_ReportItem.Size = new System.Drawing.Size(114, 40);
            this.Btn_ReportItem.TabIndex = 1;
            this.Btn_ReportItem.Text = "Report Find Item";
            this.Btn_ReportItem.UseVisualStyleBackColor = false;
            this.Btn_ReportItem.Click += new System.EventHandler(this.Btn_ReportItem_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.Btn_FindItems);
            this.panel3.Location = new System.Drawing.Point(70, 315);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 139);
            this.panel3.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(15, 28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // Btn_FindItems
            // 
            this.Btn_FindItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Btn_FindItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_FindItems.Location = new System.Drawing.Point(15, 80);
            this.Btn_FindItems.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_FindItems.Name = "Btn_FindItems";
            this.Btn_FindItems.Size = new System.Drawing.Size(114, 40);
            this.Btn_FindItems.TabIndex = 1;
            this.Btn_FindItems.Text = "Find Items";
            this.Btn_FindItems.UseVisualStyleBackColor = false;
            this.Btn_FindItems.Click += new System.EventHandler(this.Btn_FindItems_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.Btn_MyReports);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel4.Location = new System.Drawing.Point(408, 315);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 139);
            this.panel4.TabIndex = 7;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(15, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // Btn_MyReports
            // 
            this.Btn_MyReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Btn_MyReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_MyReports.Location = new System.Drawing.Point(15, 80);
            this.Btn_MyReports.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_MyReports.Name = "Btn_MyReports";
            this.Btn_MyReports.Size = new System.Drawing.Size(114, 40);
            this.Btn_MyReports.TabIndex = 1;
            this.Btn_MyReports.Text = "My Reports";
            this.Btn_MyReports.UseVisualStyleBackColor = false;
            this.Btn_MyReports.Click += new System.EventHandler(this.Btn_MyReports_Click);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.White;
            this.Logout.Location = new System.Drawing.Point(560, 86);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(106, 40);
            this.Logout.TabIndex = 8;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::lostandfound.cs.Properties.Resources.ChatGPT_Image_Sep_13__2026__08_36_39_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 505);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Txt_Welcome);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_Welcome;
        private System.Windows.Forms.Button btn_ReportLost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Btn_ReportItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Btn_FindItems;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button Btn_MyReports;
        private System.Windows.Forms.Button Logout;
    }
}