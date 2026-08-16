namespace lostandfound.cs
{
    partial class StaffDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LB_AllReports = new System.Windows.Forms.Label();
            this.LB_ReviewandUpdate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IMG_LogoStaff = new System.Windows.Forms.PictureBox();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.LB_StaffPanel = new System.Windows.Forms.Label();
            this.LB_LFHeader = new System.Windows.Forms.Label();
            this.Grd_ReviewTable = new System.Windows.Forms.DataGridView();
            this.colAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_LogoStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ReviewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_AllReports
            // 
            this.LB_AllReports.AutoSize = true;
            this.LB_AllReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LB_AllReports.Location = new System.Drawing.Point(78, 83);
            this.LB_AllReports.Name = "LB_AllReports";
            this.LB_AllReports.Size = new System.Drawing.Size(87, 20);
            this.LB_AllReports.TabIndex = 0;
            this.LB_AllReports.Text = "All Reports";
            // 
            // LB_ReviewandUpdate
            // 
            this.LB_ReviewandUpdate.AutoSize = true;
            this.LB_ReviewandUpdate.Location = new System.Drawing.Point(79, 112);
            this.LB_ReviewandUpdate.Name = "LB_ReviewandUpdate";
            this.LB_ReviewandUpdate.Size = new System.Drawing.Size(177, 13);
            this.LB_ReviewandUpdate.TabIndex = 1;
            this.LB_ReviewandUpdate.Text = "Review and Update Reported Items";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.IMG_LogoStaff);
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.LB_StaffPanel);
            this.panel1.Controls.Add(this.LB_LFHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 60);
            this.panel1.TabIndex = 2;
            // 
            // IMG_LogoStaff
            // 
            this.IMG_LogoStaff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IMG_LogoStaff.Image = global::lostandfound.cs.Properties.Resources.images__1_;
            this.IMG_LogoStaff.Location = new System.Drawing.Point(12, 12);
            this.IMG_LogoStaff.Name = "IMG_LogoStaff";
            this.IMG_LogoStaff.Size = new System.Drawing.Size(47, 39);
            this.IMG_LogoStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMG_LogoStaff.TabIndex = 3;
            this.IMG_LogoStaff.TabStop = false;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.White;
            this.btn_Logout.FlatAppearance.BorderSize = 2;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Logout.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Logout.Location = new System.Drawing.Point(632, 17);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(60, 30);
            this.btn_Logout.TabIndex = 11;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // LB_StaffPanel
            // 
            this.LB_StaffPanel.AutoSize = true;
            this.LB_StaffPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LB_StaffPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(124)))), ((int)(((byte)(147)))));
            this.LB_StaffPanel.Location = new System.Drawing.Point(65, 36);
            this.LB_StaffPanel.Name = "LB_StaffPanel";
            this.LB_StaffPanel.Size = new System.Drawing.Size(71, 15);
            this.LB_StaffPanel.TabIndex = 10;
            this.LB_StaffPanel.Text = "- Staff Panel";
            // 
            // LB_LFHeader
            // 
            this.LB_LFHeader.AutoSize = true;
            this.LB_LFHeader.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LB_LFHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.LB_LFHeader.Location = new System.Drawing.Point(65, 17);
            this.LB_LFHeader.Name = "LB_LFHeader";
            this.LB_LFHeader.Size = new System.Drawing.Size(130, 19);
            this.LB_LFHeader.TabIndex = 9;
            this.LB_LFHeader.Text = "Lost & Found System";
            // 
            // Grd_ReviewTable
            // 
            this.Grd_ReviewTable.AllowUserToAddRows = false;
            this.Grd_ReviewTable.AllowUserToResizeRows = false;
            this.Grd_ReviewTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Grd_ReviewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_ReviewTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colRole,
            this.colEmail,
            this.colAction});
            this.Grd_ReviewTable.EnableHeadersVisualStyles = false;
            this.Grd_ReviewTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.Grd_ReviewTable.Location = new System.Drawing.Point(82, 161);
            this.Grd_ReviewTable.Name = "Grd_ReviewTable";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Grd_ReviewTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Grd_ReviewTable.Size = new System.Drawing.Size(444, 255);
            this.Grd_ReviewTable.TabIndex = 8;
            // 
            // colAction
            // 
            this.colAction.HeaderText = "Action";
            this.colAction.Name = "colAction";
            this.colAction.Width = 80;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Status";
            this.colEmail.Name = "colEmail";
            this.colEmail.Width = 80;
            // 
            // colRole
            // 
            this.colRole.HeaderText = "Reporter";
            this.colRole.Name = "colRole";
            this.colRole.Width = 150;
            // 
            // colName
            // 
            this.colName.HeaderText = "Item";
            this.colName.Name = "colName";
            this.colName.Width = 90;
            // 
            // StaffDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 497);
            this.Controls.Add(this.Grd_ReviewTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LB_ReviewandUpdate);
            this.Controls.Add(this.LB_AllReports);
            this.Name = "StaffDashboard";
            this.Text = "StaffDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_LogoStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ReviewTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_AllReports;
        private System.Windows.Forms.Label LB_ReviewandUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox IMG_LogoStaff;
        private System.Windows.Forms.DataGridView Grd_ReviewTable;
        private System.Windows.Forms.Label LB_LFHeader;
        private System.Windows.Forms.Label LB_StaffPanel;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAction;
    }
}