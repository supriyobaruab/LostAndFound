namespace lostandfound.cs
{
    partial class SearchItemForm
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
            this.LB_Finditem = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.IMG_Itemimg = new System.Windows.Forms.DataGridView();
            this.colImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateFound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFoundLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectItem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Itemimg)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Finditem
            // 
            this.LB_Finditem.AutoSize = true;
            this.LB_Finditem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LB_Finditem.Location = new System.Drawing.Point(27, 22);
            this.LB_Finditem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Finditem.Name = "LB_Finditem";
            this.LB_Finditem.Size = new System.Drawing.Size(94, 20);
            this.LB_Finditem.TabIndex = 0;
            this.LB_Finditem.Text = "Find Items";
            // 
            // IMG_Itemimg
            // 
            this.IMG_Itemimg.AllowDrop = true;
            this.IMG_Itemimg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IMG_Itemimg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colImage,
            this.colItemName,
            this.colDateFound,
            this.colFoundLocation,
            this.colStatus,
            this.colView});
            this.IMG_Itemimg.Location = new System.Drawing.Point(20, 120);
            this.IMG_Itemimg.Margin = new System.Windows.Forms.Padding(2);
            this.IMG_Itemimg.Name = "IMG_Itemimg";
            this.IMG_Itemimg.ReadOnly = true;
            this.IMG_Itemimg.RowHeadersWidth = 82;
            this.IMG_Itemimg.RowTemplate.Height = 33;
            this.IMG_Itemimg.Size = new System.Drawing.Size(1090, 458);
            this.IMG_Itemimg.TabIndex = 9;
            // 
            // colImage
            // 
            this.colImage.HeaderText = "Image";
            this.colImage.MinimumWidth = 10;
            this.colImage.Name = "colImage";
            this.colImage.ReadOnly = true;
            this.colImage.Width = 200;
            // 
            // colItemName
            // 
            this.colItemName.HeaderText = "Item Name";
            this.colItemName.MinimumWidth = 10;
            this.colItemName.Name = "colItemName";
            this.colItemName.ReadOnly = true;
            this.colItemName.Width = 200;
            // 
            // colDateFound
            // 
            this.colDateFound.HeaderText = "Date  found";
            this.colDateFound.MinimumWidth = 10;
            this.colDateFound.Name = "colDateFound";
            this.colDateFound.ReadOnly = true;
            this.colDateFound.Width = 200;
            // 
            // colFoundLocation
            // 
            this.colFoundLocation.HeaderText = "Found Location";
            this.colFoundLocation.MinimumWidth = 10;
            this.colFoundLocation.Name = "colFoundLocation";
            this.colFoundLocation.ReadOnly = true;
            this.colFoundLocation.Width = 200;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 10;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 200;
            // 
            // colView
            // 
            this.colView.HeaderText = "ViewDetails";
            this.colView.MinimumWidth = 10;
            this.colView.Name = "colView";
            this.colView.ReadOnly = true;
            this.colView.Text = "View";
            this.colView.UseColumnTextForButtonValue = true;
            this.colView.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(28, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select Catagory";
            // 
            // SelectItem
            // 
            this.SelectItem.AllowDrop = true;
            this.SelectItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.SelectItem.FormattingEnabled = true;
            this.SelectItem.Location = new System.Drawing.Point(136, 52);
            this.SelectItem.Name = "SelectItem";
            this.SelectItem.Size = new System.Drawing.Size(156, 23);
            this.SelectItem.TabIndex = 11;
            // 
            // SearchItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 614);
            this.Controls.Add(this.SelectItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IMG_Itemimg);
            this.Controls.Add(this.LB_Finditem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchItemForm";
            this.Text = "SearchItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Itemimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Finditem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView IMG_Itemimg;
        private System.Windows.Forms.DataGridViewImageColumn colImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateFound;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFoundLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SelectItem;
    }
}