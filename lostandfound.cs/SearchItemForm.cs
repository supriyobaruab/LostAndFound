using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace lostandfound.cs
{
    public partial class SearchItemForm : Form
    {
        string connectionString = "Server=localhost;Database=LostAndFound;Trusted_Connection=True;TrustServerCertificate=True;";
        private readonly string loggedUser;

        private class ItemRowData
        {
            public int FoundItemId { get; set; }
            public Image Image { get; set; }
            public bool IsClaimedByCurrentUser { get; set; }
        }

        public SearchItemForm(string userId)
        {
            InitializeComponent();
            loggedUser = userId;

            // The selected item's photo is displayed in the panel beside the table.
            Find_Items.RowTemplate.Height = 42;


            // ==============================
            // CATEGORY
            // ==============================

            SelectItem.Items.AddRange(new string[]
            {
                "Bag",
                "Electronics",
                "Keys",
                "ID card",
                "Books",
                "Wallet",
                "Cloth",
                "Other"
            });

            SelectItem.SelectedIndex = -1;


            // ==============================
            // LOAD ITEMS
            // ==============================

            LoadAllItems();
        }


        // =====================================
        // GET IMAGE FROM DATABASE PATH
        // =====================================
        private Image GetItemImage(string imagePath)
        {
            if (string.IsNullOrWhiteSpace(imagePath))
                return null;


            // Database stores:
            // Images/FoundItems/example.png

            // Convert it to:
            // Application folder + Images/FoundItems/example.png

            string fullPath = Path.Combine(
                Application.StartupPath,
                imagePath.Replace("/", "\\")
            );


            // Check if image exists
            if (!File.Exists(fullPath))
            {
                return null;
            }


            try
            {
                // Load image
                Image tempImage = Image.FromFile(fullPath);

                // Create independent copy
                Image image = new Bitmap(tempImage);

                // Release original file
                tempImage.Dispose();

                return image;
            }
            catch
            {
                return null;
            }
        }


        // =====================================
        // LOAD ALL ITEMS
        // =====================================
        private void LoadAllItems()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();


                string query = @"
                    SELECT 
                        FoundItem_ID,
                        image_Path,
                        item_name,
                        date_found,
                        found_location,
                        status,
                        description,
                        CASE WHEN EXISTS
                        (
                            SELECT 1 FROM ItemClaims
                            WHERE ItemClaims.FoundItem_ID = FoundItems.FoundItem_ID
                              AND ItemClaims.User_ID = @UserId
                        ) THEN 1 ELSE 0 END AS IsClaimedByCurrentUser
                    FROM FoundItems";


                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserId", loggedUser);

                SqlDataReader reader = cmd.ExecuteReader();


                ClearItemRows();


                while (reader.Read())
                {
                    // Get image path from database
                    string imagePath = reader["image_Path"].ToString();


                    // Convert path into actual Image
                    Image itemImage = GetItemImage(imagePath);


                    // Add row
                    int rowIndex = Find_Items.Rows.Add(
                        reader["item_name"].ToString(),
                        reader["date_found"].ToString(),
                        reader["found_location"].ToString(),
                        reader["description"].ToString(),
                        reader["status"].ToString()
                        
                    );


                    Find_Items.Rows[rowIndex].Tag = new ItemRowData
                    {
                        FoundItemId = Convert.ToInt32(reader["FoundItem_ID"]),
                        Image = itemImage,
                        IsClaimedByCurrentUser = Convert.ToBoolean(reader["IsClaimedByCurrentUser"])
                    };
                    Find_Items.Rows[rowIndex].Cells[colView.Index].Value =
                        Convert.ToBoolean(reader["IsClaimedByCurrentUser"]) ? "Claimed" : "Claim";
                }


                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                conn.Close();
            }
        }


        // =====================================
        // CATEGORY FILTER
        // =====================================
        private void SelectItem_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (SelectItem.SelectedItem == null)
                return;


            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();


                string query = @"
                    SELECT 
                        FoundItem_ID,
                        image_Path,
                        item_name,
                        date_found,
                        found_location,
                        status,
                        description,
                        CASE WHEN EXISTS
                        (
                            SELECT 1 FROM ItemClaims
                            WHERE ItemClaims.FoundItem_ID = FoundItems.FoundItem_ID
                              AND ItemClaims.User_ID = @UserId
                        ) THEN 1 ELSE 0 END AS IsClaimedByCurrentUser
                    FROM FoundItems
                    WHERE Category = @Category";


                SqlCommand cmd = new SqlCommand(query, conn);


                cmd.Parameters.AddWithValue(
                    "@Category",
                    SelectItem.SelectedItem.ToString()
                );
                cmd.Parameters.AddWithValue("@UserId", loggedUser);


                SqlDataReader reader = cmd.ExecuteReader();


                ClearItemRows();


                while (reader.Read())
                {
                    // Get image path
                    string imagePath = reader["image_Path"].ToString();


                    // Get actual image
                    Image itemImage = GetItemImage(imagePath);


                    // Add row
                    int rowIndex = Find_Items.Rows.Add(
                        reader["item_name"].ToString(),
                        reader["date_found"].ToString(),
                        reader["found_location"].ToString(),
                        reader["description"].ToString(),
                        reader["status"].ToString()
                        
                    );


                    Find_Items.Rows[rowIndex].Tag = new ItemRowData
                    {
                        FoundItemId = Convert.ToInt32(reader["FoundItem_ID"]),
                        Image = itemImage,
                        IsClaimedByCurrentUser = Convert.ToBoolean(reader["IsClaimedByCurrentUser"])
                    };
                    Find_Items.Rows[rowIndex].Cells[colView.Index].Value =
                        Convert.ToBoolean(reader["IsClaimedByCurrentUser"]) ? "Claimed" : "Claim";
                }


                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                conn.Close();
            }
        }

        private void ClearItemRows()
        {
            foreach (DataGridViewRow row in Find_Items.Rows)
            {
                ItemRowData itemData = row.Tag as ItemRowData;
                Image image = itemData?.Image;
                if (image != null)
                    image.Dispose();
            }

            Find_Items.Rows.Clear();
            SelectedItemImage.Image = null;
        }

        private void Find_Items_SelectionChanged(object sender, EventArgs e)
        {
            if (Find_Items.SelectedRows.Count == 0)
            {
                SelectedItemImage.Image = null;
                return;
            }

            ItemRowData itemData = Find_Items.SelectedRows[0].Tag as ItemRowData;
            SelectedItemImage.Image = itemData?.Image;
        }

        private void Find_Items_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colView.Index)
                return;

            ItemRowData itemData = Find_Items.Rows[e.RowIndex].Tag as ItemRowData;
            if (itemData == null || string.IsNullOrWhiteSpace(loggedUser))
            {
                MessageBox.Show("Please sign in before claiming an item.", "Sign in required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (itemData.IsClaimedByCurrentUser)
            {
                MessageBox.Show("You have already claimed this item.", "Already claimed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            const string query = @"
                IF NOT EXISTS
                (
                    SELECT 1
                    FROM ItemClaims
                    WHERE FoundItem_ID = @FoundItemId AND User_ID = @UserId
                )
                BEGIN
                    INSERT INTO ItemClaims (FoundItem_ID, User_ID, Claim_Status, Claimed_At)
                    VALUES (@FoundItemId, @UserId, 'Claimed', GETDATE())
                    SELECT CAST(1 AS int)
                END
                ELSE
                    SELECT CAST(0 AS int)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FoundItemId", itemData.FoundItemId);
                    cmd.Parameters.AddWithValue("@UserId", loggedUser);
                    conn.Open();

                    bool claimWasInserted = Convert.ToInt32(cmd.ExecuteScalar()) == 1;
                    if (claimWasInserted)
                    {
                        itemData.IsClaimedByCurrentUser = true;
                        Find_Items.Rows[e.RowIndex].Cells[colView.Index].Value = "Claimed";
                    }

                    string message = claimWasInserted
                        ? "Your claim has been submitted for staff verification."
                        : "You have already claimed this item.";

                    MessageBox.Show(message, "Claim item", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not submit your claim:\n" + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
