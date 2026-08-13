namespace lostandfound.cs
{
    partial class FoundItemForm
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
            this.LB_ItemName = new System.Windows.Forms.Label();
            this.LB_Catagory = new System.Windows.Forms.Label();
            this.LB_Description = new System.Windows.Forms.Label();
            this.LB_FoundLocation = new System.Windows.Forms.Label();
            this.LB_FoundDate = new System.Windows.Forms.Label();
            this.CB_Category = new System.Windows.Forms.ComboBox();
            this.TB_Description = new System.Windows.Forms.TextBox();
            this.TB_FoundLoc = new System.Windows.Forms.TextBox();
            this.DTP_FoundDate = new System.Windows.Forms.DateTimePicker();
            this.TB_ItemName = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report Found Items";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LB_ItemName
            // 
            this.LB_ItemName.AutoSize = true;
            this.LB_ItemName.Location = new System.Drawing.Point(115, 86);
            this.LB_ItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_ItemName.Name = "LB_ItemName";
            this.LB_ItemName.Size = new System.Drawing.Size(58, 13);
            this.LB_ItemName.TabIndex = 1;
            this.LB_ItemName.Text = "Item Name";
            this.LB_ItemName.Click += new System.EventHandler(this.label2_Click);
            // 
            // LB_Catagory
            // 
            this.LB_Catagory.AutoSize = true;
            this.LB_Catagory.Location = new System.Drawing.Point(464, 89);
            this.LB_Catagory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Catagory.Name = "LB_Catagory";
            this.LB_Catagory.Size = new System.Drawing.Size(49, 13);
            this.LB_Catagory.TabIndex = 2;
            this.LB_Catagory.Text = "Category";
            this.LB_Catagory.Click += new System.EventHandler(this.label3_Click);
            // 
            // LB_Description
            // 
            this.LB_Description.AutoSize = true;
            this.LB_Description.Location = new System.Drawing.Point(115, 160);
            this.LB_Description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Description.Name = "LB_Description";
            this.LB_Description.Size = new System.Drawing.Size(60, 13);
            this.LB_Description.TabIndex = 3;
            this.LB_Description.Text = "Description";
            this.LB_Description.Click += new System.EventHandler(this.label4_Click);
            // 
            // LB_FoundLocation
            // 
            this.LB_FoundLocation.AutoSize = true;
            this.LB_FoundLocation.Location = new System.Drawing.Point(115, 307);
            this.LB_FoundLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_FoundLocation.Name = "LB_FoundLocation";
            this.LB_FoundLocation.Size = new System.Drawing.Size(81, 13);
            this.LB_FoundLocation.TabIndex = 4;
            this.LB_FoundLocation.Text = "Found Location";
            // 
            // LB_FoundDate
            // 
            this.LB_FoundDate.AutoSize = true;
            this.LB_FoundDate.Location = new System.Drawing.Point(464, 307);
            this.LB_FoundDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_FoundDate.Name = "LB_FoundDate";
            this.LB_FoundDate.Size = new System.Drawing.Size(63, 13);
            this.LB_FoundDate.TabIndex = 5;
            this.LB_FoundDate.Text = "Found Date";
            this.LB_FoundDate.Click += new System.EventHandler(this.LB_FoundDate_Click);
            // 
            // CB_Category
            // 
            this.CB_Category.FormattingEnabled = true;
            this.CB_Category.Location = new System.Drawing.Point(546, 86);
            this.CB_Category.Margin = new System.Windows.Forms.Padding(2);
            this.CB_Category.Name = "CB_Category";
            this.CB_Category.Size = new System.Drawing.Size(145, 21);
            this.CB_Category.TabIndex = 7;
            this.CB_Category.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TB_Description
            // 
            this.TB_Description.Location = new System.Drawing.Point(202, 157);
            this.TB_Description.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Description.Multiline = true;
            this.TB_Description.Name = "TB_Description";
            this.TB_Description.Size = new System.Drawing.Size(489, 104);
            this.TB_Description.TabIndex = 8;
            this.TB_Description.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TB_FoundLoc
            // 
            this.TB_FoundLoc.Location = new System.Drawing.Point(202, 304);
            this.TB_FoundLoc.Margin = new System.Windows.Forms.Padding(2);
            this.TB_FoundLoc.Name = "TB_FoundLoc";
            this.TB_FoundLoc.Size = new System.Drawing.Size(210, 20);
            this.TB_FoundLoc.TabIndex = 9;
            this.TB_FoundLoc.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // DTP_FoundDate
            // 
            this.DTP_FoundDate.Location = new System.Drawing.Point(546, 304);
            this.DTP_FoundDate.Margin = new System.Windows.Forms.Padding(2);
            this.DTP_FoundDate.Name = "DTP_FoundDate";
            this.DTP_FoundDate.Size = new System.Drawing.Size(145, 20);
            this.DTP_FoundDate.TabIndex = 10;
            this.DTP_FoundDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // TB_ItemName
            // 
            this.TB_ItemName.Location = new System.Drawing.Point(202, 86);
            this.TB_ItemName.Margin = new System.Windows.Forms.Padding(2);
            this.TB_ItemName.Name = "TB_ItemName";
            this.TB_ItemName.Size = new System.Drawing.Size(210, 20);
            this.TB_ItemName.TabIndex = 11;
            this.TB_ItemName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(112, 387);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(84, 38);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(202, 387);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(84, 38);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // FoundItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.TB_ItemName);
            this.Controls.Add(this.DTP_FoundDate);
            this.Controls.Add(this.TB_FoundLoc);
            this.Controls.Add(this.TB_Description);
            this.Controls.Add(this.CB_Category);
            this.Controls.Add(this.LB_FoundDate);
            this.Controls.Add(this.LB_FoundLocation);
            this.Controls.Add(this.LB_Description);
            this.Controls.Add(this.LB_Catagory);
            this.Controls.Add(this.LB_ItemName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FoundItemForm";
            this.Text = "FoundItemForm";
            this.Load += new System.EventHandler(this.FoundItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_ItemName;
        private System.Windows.Forms.Label LB_Catagory;
        private System.Windows.Forms.Label LB_Description;
        private System.Windows.Forms.Label LB_FoundLocation;
        private System.Windows.Forms.Label LB_FoundDate;
        private System.Windows.Forms.ComboBox CB_Category;
        private System.Windows.Forms.TextBox TB_Description;
        private System.Windows.Forms.TextBox TB_FoundLoc;
        private System.Windows.Forms.DateTimePicker DTP_FoundDate;
        private System.Windows.Forms.TextBox TB_ItemName;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
    }
}