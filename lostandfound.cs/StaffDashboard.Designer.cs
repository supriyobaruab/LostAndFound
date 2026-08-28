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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LB_AllReports = new System.Windows.Forms.Label();
            this.LB_ReviewandUpdate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.LB_StaffPanel = new System.Windows.Forms.Label();
            this.LB_LFHeader = new System.Windows.Forms.Label();
            this.Grd_ReviewTable = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IMG_LogoStaff = new System.Windows.Forms.PictureBox();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReporter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TrackingStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ReviewTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_LogoStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_AllReports
            // 
            this.LB_AllReports.AutoSize = true;
            this.LB_AllReports.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LB_AllReports.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_AllReports.Location = new System.Drawing.Point(169, 91);
            this.LB_AllReports.Name = "LB_AllReports";
            this.LB_AllReports.Size = new System.Drawing.Size(106, 23);
            this.LB_AllReports.TabIndex = 0;
            this.LB_AllReports.Text = "All Reports";
            // 
            // LB_ReviewandUpdate
            // 
            this.LB_ReviewandUpdate.AutoSize = true;
            this.LB_ReviewandUpdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LB_ReviewandUpdate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ReviewandUpdate.Location = new System.Drawing.Point(170, 120);
            this.LB_ReviewandUpdate.Name = "LB_ReviewandUpdate";
            this.LB_ReviewandUpdate.Size = new System.Drawing.Size(188, 13);
            this.LB_ReviewandUpdate.TabIndex = 1;
            this.LB_ReviewandUpdate.Text = "Review and Update Reported Items";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.IMG_LogoStaff);
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.LB_StaffPanel);
            this.panel1.Controls.Add(this.LB_LFHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 60);
            this.panel1.TabIndex = 2;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.White;
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.FlatAppearance.BorderSize = 2;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btn_Logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(75)))), ((int)(((byte)(183)))));
            this.btn_Logout.Location = new System.Drawing.Point(725, 12);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(65, 39);
            this.btn_Logout.TabIndex = 11;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // LB_StaffPanel
            // 
            this.LB_StaffPanel.AutoSize = true;
            this.LB_StaffPanel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LB_StaffPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LB_StaffPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(103)))), ((int)(((byte)(199)))));
            this.LB_StaffPanel.Location = new System.Drawing.Point(65, 36);
            this.LB_StaffPanel.Name = "LB_StaffPanel";
            this.LB_StaffPanel.Size = new System.Drawing.Size(71, 15);
            this.LB_StaffPanel.TabIndex = 10;
            this.LB_StaffPanel.Text = "- Staff Panel";
            // 
            // LB_LFHeader
            // 
            this.LB_LFHeader.AutoSize = true;
            this.LB_LFHeader.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LB_LFHeader.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LB_LFHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
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
            this.Grd_ReviewTable.BackgroundColor = System.Drawing.Color.White;
            this.Grd_ReviewTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grd_ReviewTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grd_ReviewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_ReviewTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem,
            this.colReporter,
            this.colStatus,
            this.colAction,
            this.TrackingStatus});
            this.Grd_ReviewTable.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(75)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(75)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grd_ReviewTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.Grd_ReviewTable.EnableHeadersVisualStyles = false;
            this.Grd_ReviewTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.Grd_ReviewTable.Location = new System.Drawing.Point(105, 146);
            this.Grd_ReviewTable.Name = "Grd_ReviewTable";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grd_ReviewTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Grd_ReviewTable.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Grd_ReviewTable.Size = new System.Drawing.Size(612, 276);
            this.Grd_ReviewTable.TabIndex = 8;
            this.Grd_ReviewTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grd_ReviewTable_CellContentClick);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(75)))), ((int)(((byte)(183)))));
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(465, 447);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(128, 49);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancle
            // 
            this.btn_cancle.BackColor = System.Drawing.Color.White;
            this.btn_cancle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(75)))), ((int)(((byte)(183)))));
            this.btn_cancle.Location = new System.Drawing.Point(599, 450);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(118, 43);
            this.btn_cancle.TabIndex = 10;
            this.btn_cancle.Text = "Cancel";
            this.btn_cancle.UseVisualStyleBackColor = false;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Image = global::lostandfound.cs.Properties.Resources.ChatGPT_Image_Aug_28__2026__11_09_14_PM;
            this.pictureBox1.Location = new System.Drawing.Point(93, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // IMG_LogoStaff
            // 
            this.IMG_LogoStaff.Cursor = System.Windows.Forms.Cursors.No;
            this.IMG_LogoStaff.Image = global::lostandfound.cs.Properties.Resources.ChatGPT_Image_Aug_28__2026__11_06_35_PM;
            this.IMG_LogoStaff.Location = new System.Drawing.Point(12, 12);
            this.IMG_LogoStaff.Name = "IMG_LogoStaff";
            this.IMG_LogoStaff.Size = new System.Drawing.Size(47, 39);
            this.IMG_LogoStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMG_LogoStaff.TabIndex = 3;
            this.IMG_LogoStaff.TabStop = false;
            // 
            // colItem
            // 
            this.colItem.DataPropertyName = "Item";
            this.colItem.HeaderText = "Item";
            this.colItem.Name = "colItem";
            this.colItem.Width = 90;
            // 
            // colReporter
            // 
            this.colReporter.DataPropertyName = "Reporter";
            this.colReporter.HeaderText = "Reporter";
            this.colReporter.Name = "colReporter";
            this.colReporter.Width = 150;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Width = 80;
            // 
            // colAction
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.colAction.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAction.HeaderText = "Action";
            this.colAction.Name = "colAction";
            this.colAction.Text = "Mark Returned";
            this.colAction.UseColumnTextForButtonValue = true;
            this.colAction.Width = 125;
            // 
            // TrackingStatus
            // 
            this.TrackingStatus.DataPropertyName = "TrackingStatus";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.TrackingStatus.DefaultCellStyle = dataGridViewCellStyle3;
            this.TrackingStatus.HeaderText = "Tracking Status";
            this.TrackingStatus.Items.AddRange(new object[] {
            "Match Pending",
            "Resolved",
            "Searching"});
            this.TrackingStatus.Name = "TrackingStatus";
            this.TrackingStatus.Width = 125;
            // 
            // StaffDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 537);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.Grd_ReviewTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LB_ReviewandUpdate);
            this.Controls.Add(this.LB_AllReports);
            this.Name = "StaffDashboard";
            this.Text = "StaffDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ReviewTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_LogoStaff)).EndInit();
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
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReporter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colAction;
        private System.Windows.Forms.DataGridViewComboBoxColumn TrackingStatus;
    }
}