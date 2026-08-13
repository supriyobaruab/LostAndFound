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
            this.btn_Bag = new System.Windows.Forms.Button();
            this.btn_Electronics = new System.Windows.Forms.Button();
            this.btn_Wallet = new System.Windows.Forms.Button();
            this.btn_ID = new System.Windows.Forms.Button();
            this.btn_Books = new System.Windows.Forms.Button();
            this.btn_Key = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_Clothing = new System.Windows.Forms.Button();
            this.btn_Others = new System.Windows.Forms.Button();
            this.IMG_Itemimg = new System.Windows.Forms.DataGridView();
            this.colImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateFound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFoundLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colView = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Itemimg)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Finditem
            // 
            this.LB_Finditem.AutoSize = true;
            this.LB_Finditem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Finditem.Location = new System.Drawing.Point(172, 35);
            this.LB_Finditem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Finditem.Name = "LB_Finditem";
            this.LB_Finditem.Size = new System.Drawing.Size(74, 15);
            this.LB_Finditem.TabIndex = 0;
            this.LB_Finditem.Text = "Find Items";
            this.LB_Finditem.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Bag
            // 
            this.btn_Bag.Location = new System.Drawing.Point(48, 83);
            this.btn_Bag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Bag.Name = "btn_Bag";
            this.btn_Bag.Size = new System.Drawing.Size(70, 34);
            this.btn_Bag.TabIndex = 1;
            this.btn_Bag.Text = "Bags";
            this.btn_Bag.UseVisualStyleBackColor = true;
            this.btn_Bag.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Electronics
            // 
            this.btn_Electronics.Location = new System.Drawing.Point(48, 142);
            this.btn_Electronics.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Electronics.Name = "btn_Electronics";
            this.btn_Electronics.Size = new System.Drawing.Size(70, 33);
            this.btn_Electronics.TabIndex = 2;
            this.btn_Electronics.Text = "Electronics";
            this.btn_Electronics.UseVisualStyleBackColor = true;
            this.btn_Electronics.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Wallet
            // 
            this.btn_Wallet.Location = new System.Drawing.Point(48, 215);
            this.btn_Wallet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Wallet.Name = "btn_Wallet";
            this.btn_Wallet.Size = new System.Drawing.Size(70, 30);
            this.btn_Wallet.TabIndex = 3;
            this.btn_Wallet.Text = "Wallets";
            this.btn_Wallet.UseVisualStyleBackColor = true;
            this.btn_Wallet.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_ID
            // 
            this.btn_ID.Location = new System.Drawing.Point(48, 277);
            this.btn_ID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ID.Name = "btn_ID";
            this.btn_ID.Size = new System.Drawing.Size(70, 25);
            this.btn_ID.TabIndex = 4;
            this.btn_ID.Text = "ID Cards";
            this.btn_ID.UseVisualStyleBackColor = true;
            this.btn_ID.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_Books
            // 
            this.btn_Books.Location = new System.Drawing.Point(278, 83);
            this.btn_Books.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Books.Name = "btn_Books";
            this.btn_Books.Size = new System.Drawing.Size(78, 34);
            this.btn_Books.TabIndex = 5;
            this.btn_Books.Text = "Books";
            this.btn_Books.UseVisualStyleBackColor = true;
            this.btn_Books.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_Key
            // 
            this.btn_Key.Location = new System.Drawing.Point(278, 152);
            this.btn_Key.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Key.Name = "btn_Key";
            this.btn_Key.Size = new System.Drawing.Size(78, 23);
            this.btn_Key.TabIndex = 6;
            this.btn_Key.Text = "Keys";
            this.btn_Key.UseVisualStyleBackColor = true;
            this.btn_Key.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_Clothing
            // 
            this.btn_Clothing.Location = new System.Drawing.Point(278, 218);
            this.btn_Clothing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Clothing.Name = "btn_Clothing";
            this.btn_Clothing.Size = new System.Drawing.Size(78, 25);
            this.btn_Clothing.TabIndex = 7;
            this.btn_Clothing.Text = "Clothing";
            this.btn_Clothing.UseVisualStyleBackColor = true;
            this.btn_Clothing.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_Others
            // 
            this.btn_Others.Location = new System.Drawing.Point(278, 276);
            this.btn_Others.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Others.Name = "btn_Others";
            this.btn_Others.Size = new System.Drawing.Size(79, 26);
            this.btn_Others.TabIndex = 8;
            this.btn_Others.Text = "Others";
            this.btn_Others.UseVisualStyleBackColor = true;
            this.btn_Others.Click += new System.EventHandler(this.button8_Click);
            // 
            // IMG_Itemimg
            // 
            this.IMG_Itemimg.AllowDrop = true;
            this.IMG_Itemimg.AllowUserToAddRows = false;
            this.IMG_Itemimg.AllowUserToDeleteRows = false;
            this.IMG_Itemimg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IMG_Itemimg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colImage,
            this.colItemName,
            this.colDateFound,
            this.colFoundLocation,
            this.colStatus,
            this.colView});
            this.IMG_Itemimg.Location = new System.Drawing.Point(447, 83);
            this.IMG_Itemimg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IMG_Itemimg.Name = "IMG_Itemimg";
            this.IMG_Itemimg.ReadOnly = true;
            this.IMG_Itemimg.RowHeadersWidth = 82;
            this.IMG_Itemimg.RowTemplate.Height = 33;
            this.IMG_Itemimg.Size = new System.Drawing.Size(159, 156);
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
            // SearchItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 448);
            this.Controls.Add(this.IMG_Itemimg);
            this.Controls.Add(this.btn_Others);
            this.Controls.Add(this.btn_Clothing);
            this.Controls.Add(this.btn_Key);
            this.Controls.Add(this.btn_Books);
            this.Controls.Add(this.btn_ID);
            this.Controls.Add(this.btn_Wallet);
            this.Controls.Add(this.btn_Electronics);
            this.Controls.Add(this.btn_Bag);
            this.Controls.Add(this.LB_Finditem);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SearchItemForm";
            this.Text = "SearchItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Itemimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Finditem;
        private System.Windows.Forms.Button btn_Bag;
        private System.Windows.Forms.Button btn_Electronics;
        private System.Windows.Forms.Button btn_Wallet;
        private System.Windows.Forms.Button btn_ID;
        private System.Windows.Forms.Button btn_Books;
        private System.Windows.Forms.Button btn_Key;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_Clothing;
        private System.Windows.Forms.Button btn_Others;
        private System.Windows.Forms.DataGridView IMG_Itemimg;
        private System.Windows.Forms.DataGridViewImageColumn colImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateFound;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFoundLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colView;
    }
}