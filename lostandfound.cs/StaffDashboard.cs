using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lostandfound.cs
{
    public partial class StaffDashboard : Form
    {
        string connectionString =
        "Server=localhost;Database=LostAndFound;Trusted_Connection=True;TrustServerCertificate=True;";
        public StaffDashboard()
        {
            InitializeComponent();
            //saving Tracking status
            Grd_ReviewTable.CellValueChanged += Grd_Items_CellValueChanged;
            

            DataGridViewComboBoxColumn trackingColumn =
    (DataGridViewComboBoxColumn)Grd_ReviewTable.Columns["TrackingStatus"];

            trackingColumn.Items.Clear();
            trackingColumn.Items.Add("Searching");
            trackingColumn.Items.Add("Match Pending");
            trackingColumn.Items.Add("Resolved");


            //clicking cell items colour change problem solve
            Grd_ReviewTable.DefaultCellStyle.SelectionBackColor =
            Grd_ReviewTable.DefaultCellStyle.BackColor;

            Grd_ReviewTable.DefaultCellStyle.SelectionForeColor =
            Grd_ReviewTable.DefaultCellStyle.ForeColor;
            //keep columns readonly
            Grd_ReviewTable.Columns["colItem"].ReadOnly = true;
            Grd_ReviewTable.Columns["colReporter"].ReadOnly = true;
            Grd_ReviewTable.Columns["colStatus"].ReadOnly = true;
            LoadReports();
        }



        //==============================================================================================================================================
        //LOAD Items 
        //==============================================================================================================================================


        private void LoadReports()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    string query = @"
SELECT
    L.LostItem_ID AS ItemID,
    L.Item_Name AS Item,
    U.Name AS Reporter,
    'Lost' AS Status,
    L.TrackingStatus AS TrackingStatus
FROM LostItems L
INNER JOIN [User] U ON L.User_ID = U.User_ID

UNION ALL

SELECT
    F.FoundItem_ID AS ItemID,
    F.Item_Name AS Item,
    U.Name AS Reporter,
    'Found' AS Status,
    F.TrackingStatus AS TrackingStatus
FROM FoundItems F
INNER JOIN [User] U ON F.User_ID = U.User_ID;
";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        Grd_ReviewTable.DataSource = table;
                        Grd_ReviewTable.Columns["ItemID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reports: " + ex.Message);
            }
        }




        private void Grd_Items_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (Grd_ReviewTable.Columns[e.ColumnIndex].Name == "TrackingStatus")
            {
            }    
                
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

        //============================================================================================================================================================================================
        //SAVE
        //============================================================================================================================================================================================

        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult save = MessageBox.Show("Are you sure you want to save the changed Status ?", "Update Status",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (save == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        foreach (DataGridViewRow row in Grd_ReviewTable.Rows)
                        {
                            if (row.IsNewRow)
                                continue;
                            string itemID = row.Cells["ItemID"].Value?.ToString();
                            string status = row.Cells["colStatus"].Value?.ToString();
                            string tracking = row.Cells["TrackingStatus"].Value?.ToString();

                            if (string.IsNullOrEmpty(itemID) || string.IsNullOrEmpty(status))
                                continue;

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


                    MessageBox.Show("Changes saved successfully.");

                    LoadReports();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving changes: " + ex.Message);
                }
            }
        }



        //============================================================================================================================================================================================
        //Resolved - Mark Returned Button (Action)
        //============================================================================================================================================================================================




        private void Grd_ReviewTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (Grd_ReviewTable.Columns[e.ColumnIndex].Name == "colAction")
            {
                Grd_ReviewTable.Rows[e.RowIndex].Cells["TrackingStatus"].Value = "Resolved";

                MessageBox.Show("Item marked as returned. Click Save to confirm the change.");
            }
        }


        //============================================================================================================================================================================================
        //Cancel
        //============================================================================================================================================================================================



        private void btn_cancle_Click(object sender, EventArgs e)
        {
            DialogResult cancel = MessageBox.Show("Are you sure you want to restore to default settings ?", "Restore Default",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cancel==DialogResult.Yes)
            {
                LoadReports();

            }
        }
    }






}
