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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.colImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateFound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFoundLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colView = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find Items";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Bags";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 64);
            this.button2.TabIndex = 2;
            this.button2.Text = "Electronics";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(97, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 57);
            this.button3.TabIndex = 3;
            this.button3.Text = "Wallets";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(97, 454);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 48);
            this.button4.TabIndex = 4;
            this.button4.Text = "ID Cards";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(559, 137);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 48);
            this.button5.TabIndex = 5;
            this.button5.Text = "Books";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(558, 259);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(157, 44);
            this.button6.TabIndex = 6;
            this.button6.Text = "Keys";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(559, 345);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(157, 48);
            this.button7.TabIndex = 7;
            this.button7.Text = "Clothing";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(558, 452);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(158, 50);
            this.button8.TabIndex = 8;
            this.button8.Text = "Others";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.AllowDrop = true;
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colImage,
            this.colItemName,
            this.colDateFound,
            this.colFoundLocation,
            this.colStatus,
            this.colView});
            this.dgvItems.Location = new System.Drawing.Point(861, 164);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersWidth = 82;
            this.dgvItems.RowTemplate.Height = 33;
            this.dgvItems.Size = new System.Drawing.Size(234, 258);
            this.dgvItems.TabIndex = 9;
            
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 772);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "SearchItemForm";
            this.Text = "SearchItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewImageColumn colImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateFound;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFoundLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colView;
    }
}