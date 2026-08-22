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

            // ==============================
            // DATAGRIDVIEW IMAGE SETTINGS
            // ==============================

            // Image is the first column
            Find_Items.Columns[0].Width = 220;

            // Default row height
            Find_Items.RowTemplate.Height = 130;

            // Set image layout to Zoom
            DataGridViewImageColumn imageColumn =
                (DataGridViewImageColumn)Find_Items.Columns[0];

            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;


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


                // Clear old rows
                Find_Items.Rows.Clear();


                while (reader.Read())
                {
                    // Get image path from database
                    string imagePath = reader["image_Path"].ToString();


                    // Convert path into actual Image
                    Image itemImage = GetItemImage(imagePath);


                    // Add row
                    int rowIndex = Find_Items.Rows.Add(
                        itemImage,
                        reader["item_name"].ToString(),
                        reader["date_found"].ToString(),
                        reader["found_location"].ToString(),
                        reader["description"].ToString(),
                        reader["status"].ToString()
                        
                    );


                    // Make this row bigger
                    Find_Items.Rows[rowIndex].Height = 115;
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


                // Clear existing rows
                Find_Items.Rows.Clear();


                while (reader.Read())
                {
                    // Get image path
                    string imagePath = reader["image_Path"].ToString();


                    // Get actual image
                    Image itemImage = GetItemImage(imagePath);


                    // Add row
                    int rowIndex = Find_Items.Rows.Add(
                        itemImage,
                        reader["item_name"].ToString(),
                        reader["date_found"].ToString(),
                        reader["found_location"].ToString(),
                        reader["description"].ToString(),
                        reader["status"].ToString(),
                        "claim"
                        
                    );


                    // Set row height
                    Find_Items.Rows[rowIndex].Height = 115;
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
    }
}