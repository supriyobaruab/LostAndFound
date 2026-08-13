namespace lostandfound.cs
{
    partial class LostItemForm
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
            this.LB_LostLoc = new System.Windows.Forms.Label();
            this.TB_ItemName = new System.Windows.Forms.TextBox();
            this.TB_Description = new System.Windows.Forms.TextBox();
            this.TB_LostLoc = new System.Windows.Forms.TextBox();
            this.LB_LostDate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CB_Catagory = new System.Windows.Forms.ComboBox();
            this.DTP_LostDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report Lost Item";
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
            // LB_LostLoc
            // 
            this.LB_LostLoc.AutoSize = true;
            this.LB_LostLoc.Location = new System.Drawing.Point(115, 307);
            this.LB_LostLoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_LostLoc.Name = "LB_LostLoc";
            this.LB_LostLoc.Size = new System.Drawing.Size(71, 13);
            this.LB_LostLoc.TabIndex = 4;
            this.LB_LostLoc.Text = "Lost Location";
            this.LB_LostLoc.Click += new System.EventHandler(this.label5_Click);
            // 
            // TB_ItemName
            // 
            this.TB_ItemName.Location = new System.Drawing.Point(203, 83);
            this.TB_ItemName.Margin = new System.Windows.Forms.Padding(2);
            this.TB_ItemName.Name = "TB_ItemName";
            this.TB_ItemName.Size = new System.Drawing.Size(229, 20);
            this.TB_ItemName.TabIndex = 5;
            this.TB_ItemName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TB_Description
            // 
            this.TB_Description.Location = new System.Drawing.Point(203, 157);
            this.TB_Description.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Description.Multiline = true;
            this.TB_Description.Name = "TB_Description";
            this.TB_Description.Size = new System.Drawing.Size(489, 104);
            this.TB_Description.TabIndex = 7;
            this.TB_Description.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TB_LostLoc
            // 
            this.TB_LostLoc.Location = new System.Drawing.Point(203, 304);
            this.TB_LostLoc.Margin = new System.Windows.Forms.Padding(2);
            this.TB_LostLoc.Name = "TB_LostLoc";
            this.TB_LostLoc.Size = new System.Drawing.Size(229, 20);
            this.TB_LostLoc.TabIndex = 8;
            this.TB_LostLoc.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // LB_LostDate
            // 
            this.LB_LostDate.AutoSize = true;
            this.LB_LostDate.Location = new System.Drawing.Point(460, 307);
            this.LB_LostDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_LostDate.Name = "LB_LostDate";
            this.LB_LostDate.Size = new System.Drawing.Size(53, 13);
            this.LB_LostDate.TabIndex = 9;
            this.LB_LostDate.Text = "Lost Date";
            this.LB_LostDate.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 383);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(206, 383);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 38);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CB_Catagory
            // 
            this.CB_Catagory.FormattingEnabled = true;
            this.CB_Catagory.Location = new System.Drawing.Point(547, 86);
            this.CB_Catagory.Margin = new System.Windows.Forms.Padding(2);
            this.CB_Catagory.Name = "CB_Catagory";
            this.CB_Catagory.Size = new System.Drawing.Size(145, 21);
            this.CB_Catagory.TabIndex = 13;
            this.CB_Catagory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DTP_LostDate
            // 
            this.DTP_LostDate.Location = new System.Drawing.Point(547, 304);
            this.DTP_LostDate.Margin = new System.Windows.Forms.Padding(2);
            this.DTP_LostDate.Name = "DTP_LostDate";
            this.DTP_LostDate.Size = new System.Drawing.Size(145, 20);
            this.DTP_LostDate.TabIndex = 14;
            this.DTP_LostDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // LostItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DTP_LostDate);
            this.Controls.Add(this.CB_Catagory);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LB_LostDate);
            this.Controls.Add(this.TB_LostLoc);
            this.Controls.Add(this.TB_Description);
            this.Controls.Add(this.TB_ItemName);
            this.Controls.Add(this.LB_LostLoc);
            this.Controls.Add(this.LB_Description);
            this.Controls.Add(this.LB_Catagory);
            this.Controls.Add(this.LB_ItemName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LostItemForm";
            this.Text = "LostItemForm";
            this.Load += new System.EventHandler(this.LostItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_ItemName;
        private System.Windows.Forms.Label LB_Catagory;
        private System.Windows.Forms.Label LB_Description;
        private System.Windows.Forms.Label LB_LostLoc;
        private System.Windows.Forms.TextBox TB_ItemName;
        private System.Windows.Forms.TextBox TB_Description;
        private System.Windows.Forms.TextBox TB_LostLoc;
        private System.Windows.Forms.Label LB_LostDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox CB_Catagory;
        private System.Windows.Forms.DateTimePicker DTP_LostDate;
    }
}