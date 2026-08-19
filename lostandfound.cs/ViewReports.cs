using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace lostandfound.cs
{
    public partial class ViewReports : Form
    {
        private string connectionString =
            "Server=localhost;Database=LostAndFound;Trusted_Connection=True;TrustServerCertificate=True;";

        public ViewReports()
        {
            InitializeComponent();
            
            //lost grid
            GRD_Lost.AutoGenerateColumns = false;

            GRD_Lost.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            GRD_Lost.ReadOnly = true;

            GRD_Lost.AllowUserToAddRows = false;

            GRD_Lost.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            GRD_Lost.MultiSelect = false;

            // Make rows tall enough to display images
            GRD_Lost.RowTemplate.Height = 75;
            //found Grid
            GRD_Found.AutoGenerateColumns = false;

            GRD_Found.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            GRD_Found.ReadOnly = true;

            GRD_Found.AllowUserToAddRows = false;

            GRD_Found.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            GRD_Found.MultiSelect = false;

            // Make rows tall enough for images
            GRD_Found.RowTemplate.Height = 75;

            if (GRD_Found.Columns.Count > 0 &&
                GRD_Found.Columns[0] is DataGridViewImageColumn imageColumn)
            {
                imageColumn.ImageLayout =
                    DataGridViewImageCellLayout.Zoom;
            }

            LoadFoundItems();
        }
        private void LoadFoundItems()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
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

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        GRD_Found.Rows.Clear();

                        while (reader.Read())
                        {
                            string imagePath = reader["image_Path"] == DBNull.Value
                                ? ""
                                : reader["image_Path"].ToString();

                            Image itemImage = GetItemImage(imagePath);

                            int rowIndex = GRD_Found.Rows.Add(
                                itemImage,
                                reader["item_name"].ToString(),
                                reader["date_found"].ToString(),
                                reader["found_location"].ToString(),
                                reader["description"].ToString(),
                                reader["status"].ToString(),
                                "Edit",
                                "Delete"
                            );

                            GRD_Found.Rows[rowIndex].Height = 75;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error loading found items: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }
        private Image GetItemImage(string imagePath)
        {
            if (string.IsNullOrWhiteSpace(imagePath))
                return null;

            string fullPath = Path.Combine(
                Application.StartupPath,
                imagePath.Replace("/", "\\")
            );

            if (!File.Exists(fullPath))
                return null;

            try
            {
                using (Image tempImage = Image.FromFile(fullPath))
                {
                    return new Bitmap(tempImage);
                }
            }
            catch
            {
                return null;
            }
        }

        // ==========================================
        // LOAD REPORTS
        // ==========================================

        private void ViewReports_Load(object sender, EventArgs e)
        {
            LoadReports();
        }


        private void LoadReports()
        {
            string query = @"
                SELECT
                    Item_Name,
                    Lost_Location,
                    Category,
                    Date_Lost,
                    Description,
                    Image_Path,
                    Status
                FROM dbo.LostItems";

            try
            {
                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlDataAdapter adapter =
                           new SqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        // Clear existing rows
                        GRD_Lost.Rows.Clear();


                        // Add database records to the existing grid
                        foreach (DataRow row in table.Rows)
                        {
                            Image itemImage = null;


                            // ==================================
                            // LOAD IMAGE
                            // ==================================

                            string imagePath =
                                row["Image_Path"].ToString();

                            if (!string.IsNullOrWhiteSpace(imagePath))
                            {
                                string fullImagePath =
                                    Path.Combine(
                                        Application.StartupPath,
                                        imagePath.Replace("/", "\\")
                                    );


                                if (File.Exists(fullImagePath))
                                {
                                    try
                                    {
                                        using (Image tempImage =
                                               Image.FromFile(fullImagePath))
                                        {
                                            itemImage =
                                                new Bitmap(tempImage);
                                        }
                                    }
                                    catch
                                    {
                                        itemImage = null;
                                    }
                                }
                            }


                            // ==================================
                            // ADD ROW
                            // ==================================

                            GRD_Lost.Rows.Add(
                                itemImage,
                                row["Item_Name"].ToString(),
                                row["Date_Lost"].ToString(),
                                row["Lost_Location"].ToString(),
                                row["Description"].ToString(),
                                row["Status"].ToString(),
                                "Edit",
                                "Delete"
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database Error:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // ==========================================
        // CLOSE BUTTON
        // ==========================================

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}