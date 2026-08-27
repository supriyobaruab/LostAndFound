using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace lostandfound.cs
{
    public partial class AdminDashboard : Form
    {
        //assuming that admin isnt editing at beggining 
        bool isEditing = false;
        //original user id storing inorder to let the compiler find the previous uid instead of trying to compare it with the updated one
        string originalUserID = "";

        string connectionString =
        "Server=localhost;Database=LostAndFound;Trusted_Connection=True;TrustServerCertificate=True;";

        public AdminDashboard()
        {
            InitializeComponent();
            //saving Tracking status
            Grd_Items.CellValueChanged += Grd_Items_CellValueChanged;
            Grd_Items.CurrentCellDirtyStateChanged += Grd_Items_CurrentCellDirtyStateChanged;
            
            
            DataGridViewComboBoxColumn trackingColumn =
    (DataGridViewComboBoxColumn)Grd_Items.Columns["TrackingStatus"];

            TrackingStatus.Items.Clear();
            TrackingStatus.Items.Add("Searching");
            TrackingStatus.Items.Add("Match Pending");
            TrackingStatus.Items.Add("Resolved");


            Grd_User.AutoGenerateColumns = false;
            //clicking cell items colour change problem solve
            Grd_User.DefaultCellStyle.SelectionBackColor =
            Grd_User.DefaultCellStyle.BackColor;

            Grd_User.DefaultCellStyle.SelectionForeColor =
            Grd_User.DefaultCellStyle.ForeColor;
            //method call
            LoadUsers();
            LoadItems();
            SetMemberPanelReadOnly(true);
        }
        private void LoadUsers()
        {
            string query = "SELECT User_ID, Name, Email, Role FROM [User]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        Grd_User.DataSource = table;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error loading users: " + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }
        private void SetMemberPanelReadOnly(bool readOnly)
        {
            TB_Name.ReadOnly = readOnly;
            TB_Email.ReadOnly = readOnly;
            TB_UID.ReadOnly = readOnly;
            TB_Password.ReadOnly = readOnly;
            //combobox
            CB_Role.Enabled = !readOnly;
            //button
            btn_Save.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Clear.Enabled = false;
        }


        //Load items table 

        private void LoadItems()
        {
            string query = @"
SELECT
    L.LostItem_ID AS ItemID,
    L.Item_Name AS Item,
    U.Name AS Reporter,
    'Lost' AS Status,
    L.TrackingStatus AS TrackingStatus,
    L.User_ID AS UserID
FROM LostItems L
INNER JOIN [User] U ON L.User_ID = U.User_ID

UNION ALL

SELECT
    F.FoundItem_ID AS ItemID,
    F.Item_Name AS Item,
    U.Name AS Reporter,
    'Found' AS Status,
    F.TrackingStatus AS TrackingStatus,
    F.User_ID AS UserID
FROM FoundItems F
INNER JOIN [User] U ON F.User_ID = U.User_ID;
";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlDataAdapter adapter =
                           new SqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        Grd_Items.DataSource = table;
                        Grd_Items.Columns["ItemID"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error loading items: " + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }




        //================================================================================================================================================
        //Update Value for Items Table in the Database
        //================================================================================================================================================



        private void Grd_Items_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (Grd_Items.Columns[e.ColumnIndex].Name == "TrackingStatus")
            {
                string itemID = Grd_Items.Rows[e.RowIndex].Cells["ItemID"].Value?.ToString();
                string status = Grd_Items.Rows[e.RowIndex].Cells["colStatus"].Value.ToString();
                string tracking = Grd_Items.Rows[e.RowIndex].Cells["TrackingStatus"].Value.ToString();

                if (string.IsNullOrEmpty(itemID) || string.IsNullOrEmpty(status))
                    return;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query;

                    if (status == "Lost")
                    {
                        query = @"
                UPDATE LostItems
                SET TrackingStatus = @tracking
                WHERE LostItem_ID = @itemID";
                    }
                    else
                    {
                        query = @"
                UPDATE FoundItems
                SET TrackingStatus = @tracking
                WHERE FoundItem_ID = @itemID";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@tracking", tracking);
                        cmd.Parameters.AddWithValue("@itemID", itemID);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        //================================================================================================================================================
        //Update Value for User Table in the Database
        //================================================================================================================================================

        private void Grd_User_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (Grd_User.Columns[e.ColumnIndex].Name == "Update")
            {
                isEditing = true;
               
                // Get selected user's information
                TB_Name.Text = Grd_User.Rows[e.RowIndex].Cells["colName"].Value?.ToString();
                TB_Email.Text = Grd_User.Rows[e.RowIndex].Cells["colEmail"].Value?.ToString();
                TB_UID.Text = Grd_User.Rows[e.RowIndex].Cells["UID"].Value?.ToString();
                CB_Role.Text = Grd_User.Rows[e.RowIndex].Cells["colRole"].Value?.ToString();

                //store original user id 

                originalUserID = TB_UID.Text;



                // Enable editing
                SetMemberPanelReadOnly(false);
                GRP_SelectedMember.Enabled = true;
                btn_Save.Enabled = true;
                btn_Delete.Enabled = true;
                btn_Clear.Enabled = true;
            }
            }




        //================================================================================================================================================
        //DYNAMIC update after changing a value inside dropdown to fire Items_CellContentClick       
        //================================================================================================================================================


        private void Grd_Items_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (Grd_Items.IsCurrentCellDirty)
            {
                Grd_Items.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        //=======================================================================================================================================================================================
        //ADD User
        //======================================================================================================================================================================================


        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            // Not editing
            isEditing = false;

            TB_Name.Clear();
            TB_Email.Clear();
            TB_UID.Clear();
            TB_Password.Clear();
            CB_Role.SelectedIndex = -1;

            TB_Name.Focus();

            //enable editing
            SetMemberPanelReadOnly(false);
            GRP_SelectedMember.Enabled = true;
            btn_Save.Enabled = true;
            btn_Clear.Enabled = true;
            btn_Delete.Enabled = false;
        }


        //============================================================================================================================================================================================
        //SAVE
        //============================================================================================================================================================================================


        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (TB_Name.Text == "" ||
       TB_Email.Text == "" ||
       TB_UID.Text == "" ||
       CB_Role.Text == "")
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            if (isEditing == false)
            {
                // ADD NEW USER

                string checkQuery = "SELECT COUNT(*) FROM [User] WHERE user_id = @user_id";

                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@user_id", TB_UID.Text);

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("This User ID already exists.");
                    con.Close();
                    return;
                }

                string query = @"INSERT INTO [User]
                         (name, email, user_id, password, role)
                         VALUES
                         (@name, @email, @user_id, @password, @role)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@name", TB_Name.Text);
                cmd.Parameters.AddWithValue("@email", TB_Email.Text);
                cmd.Parameters.AddWithValue("@user_id", TB_UID.Text);
                cmd.Parameters.AddWithValue("@password", TB_Password.Text);
                


                //Issues with Login form Bug Fix for Small and Capital role fix for Login


                string role;

                if (CB_Role.Text == "Officer")
                {
                    role = "officer";
                }
                else
                {
                    role = "student";
                }

                cmd.Parameters.AddWithValue("@role", role);

                cmd.ExecuteNonQuery();

                MessageBox.Show("User added successfully!");
            }
            else
            {
                // UPDATE EXISTING USER

                // Check if the NEW User ID already exists
                string checkQuery = @"SELECT COUNT(*)
                          FROM [User]
                          WHERE user_id = @newUserID
                          AND user_id <> @originalUserID";

                SqlCommand checkCmd = new SqlCommand(checkQuery, con);

                checkCmd.Parameters.AddWithValue("@newUserID", TB_UID.Text);
                checkCmd.Parameters.AddWithValue("@originalUserID", originalUserID);

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show(
                        "This User ID already exists. Please choose another User ID.",
                        "Duplicate User ID",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    con.Close();
                    return;
                }


                string query = @"UPDATE [User]
                 SET name = @name,
                     email = @email,
                     user_id = @newUserID,
                     password = @password,
                     role = @role
                 WHERE user_id = @originalUserID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@name", TB_Name.Text);
                cmd.Parameters.AddWithValue("@email", TB_Email.Text);
                cmd.Parameters.AddWithValue("@newUserID", TB_UID.Text);
                cmd.Parameters.AddWithValue("@password", TB_Password.Text);
                cmd.Parameters.AddWithValue("@role", CB_Role.Text);
                cmd.Parameters.AddWithValue("@originalUserID", originalUserID);

                cmd.ExecuteNonQuery();

                MessageBox.Show("User updated successfully!");
            }

            con.Close();

            LoadUsers();
            TB_Name.Clear();
            TB_Email.Clear();
            TB_UID.Clear();
            TB_Password.Clear();
            CB_Role.SelectedIndex = -1;

            GRP_SelectedMember.Enabled = false;

            isEditing = false;
        }

        //======================================================================================================================
        // Delete Functions
        //======================================================================================================================

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TB_UID.Text))
            {
                MessageBox.Show("Please select a user first.");
                return;
            }

            // Check whether the selected user is an Admin
            if (CB_Role.Text == "admin")
            {
                MessageBox.Show(
                    "Admin users cannot be deleted.",
                    "Delete Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }



            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this user?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
            {
                return;
            }

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = "DELETE FROM [User] WHERE user_id = @user_id";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@user_id", originalUserID);

            int rowsAffected = cmd.ExecuteNonQuery();

            con.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show(
                    "User deleted successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadUsers();

                TB_Name.Clear();
                TB_Email.Clear();
                TB_UID.Clear();
                TB_Password.Clear();
                CB_Role.SelectedIndex = -1;

                GRP_SelectedMember.Enabled = false;

                btn_Save.Enabled = false;
                btn_Delete.Enabled = false;
                btn_Clear.Enabled = false;

                isEditing = false;
                originalUserID = "";
            }
            else
            {
                MessageBox.Show(
                    "User could not be deleted.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // ====================================================================================================================================================================
        //CLEAR
        // ====================================================================================================================================================================



        private void btn_Clear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
       "Are you sure you want to clear all the information?",
       "Confirm Clear",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Warning
   );

            if (result == DialogResult.No)
            {
                return;
            }

            TB_Name.Clear();
            TB_Email.Clear();
            TB_UID.Clear();
            TB_Password.Clear();
            CB_Role.SelectedIndex = -1;

            isEditing = false;
            originalUserID = "";

            
        }

        //======================================================================================================================================================================
        //LOGOUT
        //======================================================================================================================================================================

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
      "Are you sure you want to logout?",
      "Confirm Logout",
      MessageBoxButtons.YesNo,
      MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();

                this.Close();
            }
        }


        //======================================================================================================================================================================
        //DELETE  Items
        //======================================================================================================================================================================


        private void Grd_Items_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (Grd_Items.Columns[e.ColumnIndex].Name == "colDelete")
            {
                string itemID = Grd_Items.Rows[e.RowIndex].Cells["ItemID"].Value?.ToString();

                string status = Grd_Items.Rows[e.RowIndex].Cells["colStatus"].Value?.ToString();

                if (string.IsNullOrEmpty(itemID))
                    return;

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this item?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.No)
                    return;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query;

                    if (status == "Lost")
                    {
                        query = @"
        DELETE FROM LostItems
        WHERE LostItem_ID = @itemID";
                    }
                    else
                    {
                        query = @"
        DELETE FROM FoundItems
        WHERE FoundItem_ID = @itemID";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@itemID", itemID);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Item deleted successfully!");

                LoadItems();
            }
        }
    }
}
