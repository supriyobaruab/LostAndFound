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