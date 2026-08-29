namespace lostandfound.cs
{
    partial class ViewReports
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
            this.GRD_Lost = new System.Windows.Forms.DataGridView();
            this.colImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateFound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFoundLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteL = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GRD_Found = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteF = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LB_LostReports = new System.Windows.Forms.Label();
            this.LB_FoundReports = new System.Windows.Forms.Label();
            this.LB_MyReport = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IMG_MyReports = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GRD_Lost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRD_Found)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_MyReports)).BeginInit();
            this.SuspendLayout();
            // 
            // GRD_Lost
            // 
            this.GRD_Lost.AllowDrop = true;
            this.GRD_Lost.AllowUserToAddRows = false;
            this.GRD_Lost.AllowUserToDeleteRows = false;
            this.GRD_Lost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRD_Lost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colImage,
            this.colItemName,
            this.colDateFound,
            this.colFoundLocation,
            this.Description,
            this.colStatus,
            this.DeleteL});
            this.GRD_Lost.Location = new System.Drawing.Point(57, 129);
            this.GRD_Lost.Margin = new System.Windows.Forms.Padding(2);
            this.GRD_Lost.Name = "GRD_Lost";
            this.GRD_Lost.ReadOnly = true;
            this.GRD_Lost.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.GRD_Lost.RowTemplate.Height = 33;
            this.GRD_Lost.Size = new System.Drawing.Size(1023, 183);
            this.GRD_Lost.TabIndex = 10;
            // 
            // colImage
            // 
            this.colImage.DataPropertyName = "None";
            this.colImage.HeaderText = "Image";
            this.colImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colImage.MinimumWidth = 6;
            this.colImage.Name = "colImage";
            this.colImage.ReadOnly = true;
            this.colImage.Width = 125;
            // 
            // colItemName
            // 
            this.colItemName.DataPropertyName = "Item_Name";
            this.colItemName.HeaderText = "Item Name";
            this.colItemName.MinimumWidth = 10;
            this.colItemName.Name = "colItemName";
            this.colItemName.ReadOnly = true;
            this.colItemName.Width = 125;
            // 
            // colDateFound
            // 
            this.colDateFound.DataPropertyName = "Date_Lost";
            this.colDateFound.HeaderText = "Date  Lost";
            this.colDateFound.MinimumWidth = 10;
            this.colDateFound.Name = "colDateFound";
            this.colDateFound.ReadOnly = true;
            this.colDateFound.Width = 150;
            // 
            // colFoundLocation
            // 
            this.colFoundLocation.DataPropertyName = "Lost_Location";
            this.colFoundLocation.HeaderText = "Lost Location";
            this.colFoundLocation.MinimumWidth = 10;
            this.colFoundLocation.Name = "colFoundLocation";
            this.colFoundLocation.ReadOnly = true;
            this.colFoundLocation.Width = 200;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 150;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 10;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 125;
            // 
            // DeleteL
            // 
            this.DeleteL.HeaderText = "Delete Report";
            this.DeleteL.MinimumWidth = 6;
            this.DeleteL.Name = "DeleteL";
            this.DeleteL.ReadOnly = true;
            this.DeleteL.Text = "Edit";
            this.DeleteL.Width = 125;
            // 
            // GRD_Found
            // 
            this.GRD_Found.AllowDrop = true;
            this.GRD_Found.AllowUserToAddRows = false;
            this.GRD_Found.AllowUserToDeleteRows = false;
            this.GRD_Found.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRD_Found.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.DeleteF});
            this.GRD_Found.Location = new System.Drawing.Point(56, 372);
            this.GRD_Found.Margin = new System.Windows.Forms.Padding(2);
            this.GRD_Found.Name = "GRD_Found";
            this.GRD_Found.ReadOnly = true;
            this.GRD_Found.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.GRD_Found.RowTemplate.Height = 33;
            this.GRD_Found.Size = new System.Drawing.Size(1023, 183);
            this.GRD_Found.TabIndex = 11;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Image";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Date  found";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Found Location";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Description";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Status";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // DeleteF
            // 
            this.DeleteF.HeaderText = "Delete Report";
            this.DeleteF.MinimumWidth = 6;
            this.DeleteF.Name = "DeleteF";
            this.DeleteF.ReadOnly = true;
            this.DeleteF.Text = "Delete";
            this.DeleteF.Width = 125;
            // 
            // LB_LostReports
            // 
            this.LB_LostReports.AutoSize = true;
            this.LB_LostReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LB_LostReports.Location = new System.Drawing.Point(53, 89);
            this.LB_LostReports.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_LostReports.Name = "LB_LostReports";
            this.LB_LostReports.Size = new System.Drawing.Size(113, 20);
            this.LB_LostReports.TabIndex = 12;
            this.LB_LostReports.Text = "Lost Reports";
            // 
            // LB_FoundReports
            // 
            this.LB_FoundReports.AutoSize = true;
            this.LB_FoundReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LB_FoundReports.Location = new System.Drawing.Point(52, 340);
            this.LB_FoundReports.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_FoundReports.Name = "LB_FoundReports";
            this.LB_FoundReports.Size = new System.Drawing.Size(129, 20);
            this.LB_FoundReports.TabIndex = 13;
            this.LB_FoundReports.Text = "Found Reports";
            // 
            // LB_MyReport
            // 
            this.LB_MyReport.AutoSize = true;
            this.LB_MyReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.LB_MyReport.Location = new System.Drawing.Point(50, 9);
            this.LB_MyReport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_MyReport.Name = "LB_MyReport";
            this.LB_MyReport.Size = new System.Drawing.Size(200, 39);
            this.LB_MyReport.TabIndex = 14;
            this.LB_MyReport.Text = "My Reports";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.LB_MyReport);
            this.panel1.Controls.Add(this.IMG_MyReports);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1130, 59);
            this.panel1.TabIndex = 15;
            // 
            // IMG_MyReports
            // 
            this.IMG_MyReports.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IMG_MyReports.Image = global::lostandfound.cs.Properties.Resources.pngwing_com;
            this.IMG_MyReports.InitialImage = global::lostandfound.cs.Properties.Resources.pngwing_com;
            this.IMG_MyReports.Location = new System.Drawing.Point(12, 12);
            this.IMG_MyReports.Name = "IMG_MyReports";
            this.IMG_MyReports.Size = new System.Drawing.Size(44, 36);
            this.IMG_MyReports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMG_MyReports.TabIndex = 0;
            this.IMG_MyReports.TabStop = false;
            // 
            // ViewReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 581);
            this.Controls.Add(this.LB_FoundReports);
            this.Controls.Add(this.LB_LostReports);
            this.Controls.Add(this.GRD_Found);
            this.Controls.Add(this.GRD_Lost);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewReports";
            this.Text = "+";
            this.Load += new System.EventHandler(this.ViewReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GRD_Lost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRD_Found)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_MyReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GRD_Lost;
        private System.Windows.Forms.DataGridView GRD_Found;
        private System.Windows.Forms.Label LB_LostReports;
        private System.Windows.Forms.Label LB_FoundReports;
        private System.Windows.Forms.Label LB_MyReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox IMG_MyReports;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteF;
        private System.Windows.Forms.DataGridViewImageColumn colImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateFound;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFoundLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteL;
    }
}