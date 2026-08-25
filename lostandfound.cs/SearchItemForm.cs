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

        public SearchItemForm()
        {
            InitializeComponent();

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
                        image_Path,
                        item_name,
                        date_found,
                        found_location,
                        status,
                        description
                    FROM FoundItems";


                SqlCommand cmd = new SqlCommand(query, conn);

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


                    Find_Items.Rows[rowIndex].Tag = itemImage;
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
                        image_Path,
                        item_name,
                        date_found,
                        found_location,
                        status,
                        description
                    FROM FoundItems
                    WHERE Category = @Category";


                SqlCommand cmd = new SqlCommand(query, conn);


                cmd.Parameters.AddWithValue(
                    "@Category",
                    SelectItem.SelectedItem.ToString()
                );


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


                    Find_Items.Rows[rowIndex].Tag = itemImage;
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
                Image image = row.Tag as Image;
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

            SelectedItemImage.Image = Find_Items.SelectedRows[0].Tag as Image;
        }
    }
}
