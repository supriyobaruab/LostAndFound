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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ReportLost = new System.Windows.Forms.Button();
            this.btn_ReportFound = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_ViewReport = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lost And Found Management";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btn_ReportLost
            // 
            this.btn_ReportLost.Location = new System.Drawing.Point(113, 102);
            this.btn_ReportLost.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ReportLost.Name = "btn_ReportLost";
            this.btn_ReportLost.Size = new System.Drawing.Size(165, 64);
            this.btn_ReportLost.TabIndex = 1;
            this.btn_ReportLost.Text = "Report Lost Item";
            this.btn_ReportLost.UseVisualStyleBackColor = true;
            this.btn_ReportLost.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ReportFound
            // 
            this.btn_ReportFound.Location = new System.Drawing.Point(514, 102);
            this.btn_ReportFound.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ReportFound.Name = "btn_ReportFound";
            this.btn_ReportFound.Size = new System.Drawing.Size(165, 64);
            this.btn_ReportFound.TabIndex = 2;
            this.btn_ReportFound.Text = "Report Found Item";
            this.btn_ReportFound.UseVisualStyleBackColor = true;
            this.btn_ReportFound.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(113, 225);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(165, 64);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search Item";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_ViewReport
            // 
            this.btn_ViewReport.Location = new System.Drawing.Point(514, 221);
            this.btn_ViewReport.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ViewReport.Name = "btn_ViewReport";
            this.btn_ViewReport.Size = new System.Drawing.Size(165, 64);
            this.btn_ViewReport.TabIndex = 4;
            this.btn_ViewReport.Text = " View All Reports";
            this.btn_ViewReport.UseVisualStyleBackColor = true;
            this.btn_ViewReport.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(297, 337);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(67, 37);
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.Text = "Log-out";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(418, 337);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(67, 37);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.button6_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_ViewReport);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_ReportFound);
            this.Controls.Add(this.btn_ReportLost);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ReportLost;
        private System.Windows.Forms.Button btn_ReportFound;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_ViewReport;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Exit;
    }
}