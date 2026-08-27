namespace lostandfound.cs
{
    partial class AdminDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.LB_User = new System.Windows.Forms.Label();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.LB_AdminP = new System.Windows.Forms.Label();
            this.LB_LFHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LB_rUsers = new System.Windows.Forms.Label();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.Grd_User = new System.Windows.Forms.DataGridView();
            this.LB_AItems = new System.Windows.Forms.Label();
            this.LB_AllLFReport = new System.Windows.Forms.Label();
            this.Grd_Items = new System.Windows.Forms.DataGridView();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReporter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TrackingStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.LB_MemberManagement = new System.Windows.Forms.Label();
            this.GRP_SelectedMember = new System.Windows.Forms.GroupBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.LB_Password = new System.Windows.Forms.Label();
            this.TB_UID = new System.Windows.Forms.TextBox();
            this.LB_UID = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.CB_Role = new System.Windows.Forms.ComboBox();
            this.LB_Role = new System.Windows.Forms.Label();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.LB_Email = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.LB_Name = new System.Windows.Forms.Label();
            this.Panel_Member = new System.Windows.Forms.Panel();
            this.UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.IMG_LogoStaff = new System.Windows.Forms.PictureBox();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Items)).BeginInit();
            this.GRP_SelectedMember.SuspendLayout();
            this.Panel_Member.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_LogoStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_User
            // 
            this.LB_User.AutoSize = true;
            this.LB_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.LB_User.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LB_User.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.LB_User.Location = new System.Drawing.Point(113, 87);
            this.LB_User.Name = "LB_User";
            this.LB_User.Size = new System.Drawing.Size(42, 21);
            this.LB_User.TabIndex = 1;
            this.LB_User.Text = "User";
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelHeader.Controls.Add(this.IMG_LogoStaff);
            this.PanelHeader.Controls.Add(this.btn_Logout);
            this.PanelHeader.Controls.Add(this.LB_AdminP);
            this.PanelHeader.Controls.Add(this.LB_LFHeader);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(1169, 52);
            this.PanelHeader.TabIndex = 2;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.White;
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(75)))), ((int)(((byte)(183)))));
            this.btn_Logout.Location = new System.Drawing.Point(1087, 11);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(70, 30);
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.Text = "Log-out";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // LB_AdminP
            // 
            this.LB_AdminP.AutoSize = true;
            this.LB_AdminP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LB_AdminP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LB_AdminP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(75)))), ((int)(((byte)(183)))));
            this.LB_AdminP.Location = new System.Drawing.Point(209, 22);
            this.LB_AdminP.Name = "LB_AdminP";
            this.LB_AdminP.Size = new System.Drawing.Size(83, 15);
            this.LB_AdminP.TabIndex = 5;
            this.LB_AdminP.Text = "- Admin Panel";
            // 
            // LB_LFHeader
            // 
            this.LB_LFHeader.AutoSize = true;
            this.LB_LFHeader.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LB_LFHeader.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LB_LFHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.LB_LFHeader.Location = new System.Drawing.Point(68, 17);
            this.LB_LFHeader.Name = "LB_LFHeader";
            this.LB_LFHeader.Size = new System.Drawing.Size(146, 21);
            this.LB_LFHeader.TabIndex = 5;
            this.LB_LFHeader.Text = "Lost & Found System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 1);
            this.panel1.TabIndex = 3;
            // 
            // LB_rUsers
            // 
            this.LB_rUsers.AutoSize = true;
            this.LB_rUsers.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LB_rUsers.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_rUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.LB_rUsers.Location = new System.Drawing.Point(114, 107);
            this.LB_rUsers.Name = "LB_rUsers";
            this.LB_rUsers.Size = new System.Drawing.Size(98, 13);
            this.LB_rUsers.TabIndex = 5;
            this.LB_rUsers.Text = "4 registered users";
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btn_AddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(75)))), ((int)(((byte)(183)))));
            this.btn_AddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddUser.Location = new System.Drawing.Point(1010, 92);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(103, 35);
            this.btn_AddUser.TabIndex = 6;
            this.btn_AddUser.Text = "+ Add User";
            this.btn_AddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_AddUser.UseMnemonic = false;
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // Grd_User
            // 
            this.Grd_User.AllowUserToAddRows = false;
            this.Grd_User.AllowUserToResizeRows = false;
            this.Grd_User.BackgroundColor = System.Drawing.Color.White;
            this.Grd_User.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Grd_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_User.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UID,
            this.colName,
            this.colRole,
            this.colEmail,
            this.Update});
            this.Grd_User.EnableHeadersVisualStyles = false;
            this.Grd_User.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            this.Grd_User.Location = new System.Drawing.Point(58, 134);
            this.Grd_User.Name = "Grd_User";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Grd_User.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.Grd_User.Size = new System.Drawing.Size(501, 144);
            this.Grd_User.TabIndex = 7;
            this.Grd_User.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grd_User_CellContentClick);
            // 
            // LB_AItems
            // 
            this.LB_AItems.AutoSize = true;
            this.LB_AItems.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LB_AItems.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LB_AItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.LB_AItems.Location = new System.Drawing.Point(113, 341);
            this.LB_AItems.Name = "LB_AItems";
            this.LB_AItems.Size = new System.Drawing.Size(67, 20);
            this.LB_AItems.TabIndex = 8;
            this.LB_AItems.Text = "All Items";
            // 
            // LB_AllLFReport
            // 
            this.LB_AllLFReport.AutoSize = true;
            this.LB_AllLFReport.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LB_AllLFReport.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.LB_AllLFReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.LB_AllLFReport.Location = new System.Drawing.Point(114, 361);
            this.LB_AllLFReport.Name = "LB_AllLFReport";
            this.LB_AllLFReport.Size = new System.Drawing.Size(147, 13);
            this.LB_AllLFReport.TabIndex = 9;
            this.LB_AllLFReport.Text = "All Lost and Found Reports";
            // 
            // Grd_Items
            // 
            this.Grd_Items.AllowUserToAddRows = false;
            this.Grd_Items.BackgroundColor = System.Drawing.Color.White;
            this.Grd_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem,
            this.colReporter,
            this.colStatus,
            this.colDelete,
            this.TrackingStatus});
            this.Grd_Items.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(215)))), ((int)(((byte)(227)))));
            this.Grd_Items.Location = new System.Drawing.Point(58, 381);
            this.Grd_Items.Name = "Grd_Items";
            this.Grd_Items.Size = new System.Drawing.Size(501, 144);
            this.Grd_Items.TabIndex = 10;
            this.Grd_Items.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grd_Items_CellContentClick);
            this.Grd_Items.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grd_Items_CellValueChanged);
            // 
            // colItem
            // 
            this.colItem.DataPropertyName = "Item";
            this.colItem.HeaderText = "Item";
            this.colItem.Name = "colItem";
            this.colItem.Width = 80;
            // 
            // colReporter
            // 
            this.colReporter.DataPropertyName = "Reporter";
            this.colReporter.HeaderText = "Reporter";
            this.colReporter.Name = "colReporter";
            this.colReporter.Width = 125;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "Delete";
            this.colDelete.Name = "colDelete";
            this.colDelete.Text = "Delete";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.Width = 45;
            // 
            // TrackingStatus
            // 
            this.TrackingStatus.DataPropertyName = "TrackingStatus";
            this.TrackingStatus.HeaderText = "Tracking Status";
            this.TrackingStatus.Items.AddRange(new object[] {
            "Match Pending",
            "Resolved",
            "Searching"});
            this.TrackingStatus.Name = "TrackingStatus";
            this.TrackingStatus.Width = 105;
            // 
            // LB_MemberManagement
            // 
            this.LB_MemberManagement.AutoSize = true;
            this.LB_MemberManagement.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LB_MemberManagement.Font = new System.Drawing.Font("Times New Roman", 18.75F);
            this.LB_MemberManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.LB_MemberManagement.Location = new System.Drawing.Point(769, 98);
            this.LB_MemberManagement.Name = "LB_MemberManagement";
            this.LB_MemberManagement.Size = new System.Drawing.Size(235, 29);
            this.LB_MemberManagement.TabIndex = 12;
            this.LB_MemberManagement.Text = "Member Management";
            // 
            // GRP_SelectedMember
            // 
            this.GRP_SelectedMember.BackColor = System.Drawing.Color.White;
            this.GRP_SelectedMember.Controls.Add(this.TB_Password);
            this.GRP_SelectedMember.Controls.Add(this.LB_Password);
            this.GRP_SelectedMember.Controls.Add(this.TB_UID);
            this.GRP_SelectedMember.Controls.Add(this.LB_UID);
            this.GRP_SelectedMember.Controls.Add(this.btn_Clear);
            this.GRP_SelectedMember.Controls.Add(this.btn_Delete);
            this.GRP_SelectedMember.Controls.Add(this.btn_Save);
            this.GRP_SelectedMember.Controls.Add(this.CB_Role);
            this.GRP_SelectedMember.Controls.Add(this.LB_Role);
            this.GRP_SelectedMember.Controls.Add(this.TB_Email);
            this.GRP_SelectedMember.Controls.Add(this.LB_Email);
            this.GRP_SelectedMember.Controls.Add(this.TB_Name);
            this.GRP_SelectedMember.Controls.Add(this.LB_Name);
            this.GRP_SelectedMember.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRP_SelectedMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.GRP_SelectedMember.Location = new System.Drawing.Point(28, 20);
            this.GRP_SelectedMember.Name = "GRP_SelectedMember";
            this.GRP_SelectedMember.Size = new System.Drawing.Size(445, 357);
            this.GRP_SelectedMember.TabIndex = 0;
            this.GRP_SelectedMember.TabStop = false;
            this.GRP_SelectedMember.Text = "Selected Member";
            // 
            // TB_Password
            // 
            this.TB_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Password.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.TB_Password.Location = new System.Drawing.Point(103, 196);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(324, 21);
            this.TB_Password.TabIndex = 25;
            // 
            // LB_Password
            // 
            this.LB_Password.AutoSize = true;
            this.LB_Password.BackColor = System.Drawing.Color.White;
            this.LB_Password.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.LB_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.LB_Password.Location = new System.Drawing.Point(17, 199);
            this.LB_Password.Name = "LB_Password";
            this.LB_Password.Size = new System.Drawing.Size(79, 21);
            this.LB_Password.TabIndex = 24;
            this.LB_Password.Text = "Password";
            // 
            // TB_UID
            // 
            this.TB_UID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_UID.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.TB_UID.Location = new System.Drawing.Point(103, 154);
            this.TB_UID.Name = "TB_UID";
            this.TB_UID.Size = new System.Drawing.Size(324, 21);
            this.TB_UID.TabIndex = 23;
            // 
            // LB_UID
            // 
            this.LB_UID.AutoSize = true;
            this.LB_UID.BackColor = System.Drawing.Color.White;
            this.LB_UID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.LB_UID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.LB_UID.Location = new System.Drawing.Point(17, 157);
            this.LB_UID.Name = "LB_UID";
            this.LB_UID.Size = new System.Drawing.Size(63, 21);
            this.LB_UID.TabIndex = 22;
            this.LB_UID.Text = "User ID";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(75)))), ((int)(((byte)(183)))));
            this.btn_Clear.Location = new System.Drawing.Point(295, 306);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(100, 35);
            this.btn_Clear.TabIndex = 21;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(75)))), ((int)(((byte)(183)))));
            this.btn_Delete.Location = new System.Drawing.Point(189, 306);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(100, 35);
            this.btn_Delete.TabIndex = 20;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // CB_Role
            // 
            this.CB_Role.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.CB_Role.FormattingEnabled = true;
            this.CB_Role.Items.AddRange(new object[] {
            "Student",
            "Officer"});
            this.CB_Role.Location = new System.Drawing.Point(103, 239);
            this.CB_Role.Name = "CB_Role";
            this.CB_Role.Size = new System.Drawing.Size(324, 23);
            this.CB_Role.TabIndex = 18;
            // 
            // LB_Role
            // 
            this.LB_Role.AutoSize = true;
            this.LB_Role.BackColor = System.Drawing.Color.White;
            this.LB_Role.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.LB_Role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.LB_Role.Location = new System.Drawing.Point(17, 240);
            this.LB_Role.Name = "LB_Role";
            this.LB_Role.Size = new System.Drawing.Size(43, 21);
            this.LB_Role.TabIndex = 17;
            this.LB_Role.Text = "Role";
            // 
            // TB_Email
            // 
            this.TB_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Email.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.TB_Email.Location = new System.Drawing.Point(103, 114);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(324, 21);
            this.TB_Email.TabIndex = 16;
            // 
            // LB_Email
            // 
            this.LB_Email.AutoSize = true;
            this.LB_Email.BackColor = System.Drawing.Color.White;
            this.LB_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.LB_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.LB_Email.Location = new System.Drawing.Point(17, 114);
            this.LB_Email.Name = "LB_Email";
            this.LB_Email.Size = new System.Drawing.Size(48, 21);
            this.LB_Email.TabIndex = 15;
            this.LB_Email.Text = "Email";
            // 
            // TB_Name
            // 
            this.TB_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Name.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Name.Location = new System.Drawing.Point(103, 67);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(324, 21);
            this.TB_Name.TabIndex = 14;
            // 
            // LB_Name
            // 
            this.LB_Name.AutoSize = true;
            this.LB_Name.BackColor = System.Drawing.Color.White;
            this.LB_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.LB_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.LB_Name.Location = new System.Drawing.Point(17, 67);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(82, 21);
            this.LB_Name.TabIndex = 13;
            this.LB_Name.Text = "Full Name";
            // 
            // Panel_Member
            // 
            this.Panel_Member.BackColor = System.Drawing.Color.White;
            this.Panel_Member.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Member.Controls.Add(this.GRP_SelectedMember);
            this.Panel_Member.Location = new System.Drawing.Point(611, 134);
            this.Panel_Member.Name = "Panel_Member";
            this.Panel_Member.Size = new System.Drawing.Size(502, 402);
            this.Panel_Member.TabIndex = 11;
            // 
            // UID
            // 
            this.UID.DataPropertyName = "User_ID";
            this.UID.HeaderText = "User ID";
            this.UID.Name = "UID";
            this.UID.Width = 90;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // colRole
            // 
            this.colRole.DataPropertyName = "Role";
            this.colRole.HeaderText = "Role";
            this.colRole.Name = "colRole";
            this.colRole.Width = 80;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            this.Update.Width = 68;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox2.Image = global::lostandfound.cs.Properties.Resources.ChatGPT_Image_Aug_28__2026__04_58_56_AM;
            this.pictureBox2.Location = new System.Drawing.Point(58, 326);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(75)))), ((int)(((byte)(185)))));
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(68, 304);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(115, 37);
            this.btn_Save.TabIndex = 19;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // IMG_LogoStaff
            // 
            this.IMG_LogoStaff.Cursor = System.Windows.Forms.Cursors.No;
            this.IMG_LogoStaff.Image = global::lostandfound.cs.Properties.Resources.f44e0342_841c_449b_be84_f09f0c9d667f;
            this.IMG_LogoStaff.Location = new System.Drawing.Point(0, -3);
            this.IMG_LogoStaff.Name = "IMG_LogoStaff";
            this.IMG_LogoStaff.Size = new System.Drawing.Size(71, 53);
            this.IMG_LogoStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMG_LogoStaff.TabIndex = 11;
            this.IMG_LogoStaff.TabStop = false;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1169, 567);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LB_MemberManagement);
            this.Controls.Add(this.Panel_Member);
            this.Controls.Add(this.Grd_Items);
            this.Controls.Add(this.LB_AllLFReport);
            this.Controls.Add(this.LB_AItems);
            this.Controls.Add(this.Grd_User);
            this.Controls.Add(this.btn_AddUser);
            this.Controls.Add(this.LB_rUsers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.LB_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AdminDashboard";
            this.RightToLeftLayout = true;
            this.Text = "AdminDashboard";
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Items)).EndInit();
            this.GRP_SelectedMember.ResumeLayout(false);
            this.GRP_SelectedMember.PerformLayout();
            this.Panel_Member.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_LogoStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_User;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LB_LFHeader;
        private System.Windows.Forms.Label LB_AdminP;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label LB_rUsers;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.DataGridView Grd_User;
        private System.Windows.Forms.Label LB_AItems;
        private System.Windows.Forms.Label LB_AllLFReport;
        private System.Windows.Forms.DataGridView Grd_Items;
        private System.Windows.Forms.PictureBox IMG_LogoStaff;
        private System.Windows.Forms.Label LB_MemberManagement;
        private System.Windows.Forms.GroupBox GRP_SelectedMember;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox CB_Role;
        private System.Windows.Forms.Label LB_Role;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.Label LB_Email;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.Panel Panel_Member;
        private System.Windows.Forms.TextBox TB_UID;
        private System.Windows.Forms.Label LB_UID;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Label LB_Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReporter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.DataGridViewComboBoxColumn TrackingStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
    }
}