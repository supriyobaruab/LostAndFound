using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace lostandfound.cs
{
    public partial class ViewReports : Form
    {
        // ==========================================
        // LOGGED-IN USER
        // ==========================================

        private string loggedUser;


        // ==========================================
        // DATABASE CONNECTION
        // ==========================================

        private string connectionString =
            "Server=localhost;Database=LostAndFound;Trusted_Connection=True;TrustServerCertificate=True;";


        // ==========================================
        // CONSTRUCTOR
        // ==========================================

        public ViewReports(string User_ID)
        {
            InitializeComponent();

            // Store logged-in user's ID
            loggedUser = User_ID;

            GRD_Lost.CellContentClick += GRD_Lost_CellContentClick;
            GRD_Found.CellContentClick += GRD_Found_CellContentClick;


            // ==========================================
            // LOST GRID SETTINGS
            // ==========================================

            GRD_Lost.AutoGenerateColumns = false;

            GRD_Lost.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            GRD_Lost.ReadOnly = true;

            GRD_Lost.AllowUserToAddRows = false;

            GRD_Lost.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            GRD_Lost.MultiSelect = false;

            GRD_Lost.RowTemplate.Height = 90;


            // Remove blue selection
            GRD_Lost.DefaultCellStyle.SelectionBackColor =
                Color.White;

            GRD_Lost.DefaultCellStyle.SelectionForeColor =
                Color.Black;


            // ==========================================
            // FOUND GRID SETTINGS
            // ==========================================

            GRD_Found.AutoGenerateColumns = false;

            GRD_Found.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            GRD_Found.ReadOnly = true;

            GRD_Found.AllowUserToAddRows = false;

            GRD_Found.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            GRD_Found.MultiSelect = false;

            GRD_Found.RowTemplate.Height = 90;


            // Remove blue selection
            GRD_Found.DefaultCellStyle.SelectionBackColor =
                Color.White;

            GRD_Found.DefaultCellStyle.SelectionForeColor =
                Color.Black;


            // ==========================================
            // IMAGE COLUMN SETTINGS
            // ==========================================

            SetImageColumnZoom(GRD_Lost);
            SetImageColumnZoom(GRD_Found);
        }


        // ==========================================
        // SET IMAGE COLUMN TO ZOOM
        // ==========================================

        private void SetImageColumnZoom(DataGridView grid)
        {
            foreach (DataGridViewColumn column in grid.Columns)
            {
                if (column is DataGridViewImageColumn imageColumn)
                {
                    imageColumn.ImageLayout =
                        DataGridViewImageCellLayout.Zoom;

                    imageColumn.DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleCenter;

                    break;
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
        // FORM LOAD
        // ==========================================

        private void ViewReports_Load(object sender, EventArgs e)
        {
            LoadLostReports();
            LoadFoundReports();
        }


        // ==========================================
        // LOAD LOST REPORTS
        // ==========================================

        private void LoadLostReports()
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
                FROM LostItems
                WHERE User_ID = @User_ID";


            SqlConnection connection = null;
            SqlCommand command = null;
            SqlDataReader reader = null;


            try
            {
                // ==========================================
                // CREATE CONNECTION
                // ==========================================

                connection =
                    new SqlConnection(connectionString);


                // ==========================================
                // OPEN CONNECTION
                // ==========================================

                connection.Open();


                // ==========================================
                // CREATE COMMAND
                // ==========================================

                command =
                    new SqlCommand(query, connection);


                // ==========================================
                // ADD USER ID
                // ==========================================

                command.Parameters.Add(
                    "@User_ID",
                    System.Data.SqlDbType.VarChar,
                    50
                );

                command.Parameters["@User_ID"].Value =
                    loggedUser;


                // ==========================================
                // EXECUTE QUERY
                // ==========================================

                reader =
                    command.ExecuteReader();


                // ==========================================
                // CLEAR OLD ROWS
                // ==========================================

                GRD_Lost.Rows.Clear();


                // ==========================================
                // READ DATABASE
                // ==========================================

                while (reader.Read())
                {
                    Image itemImage = null;


                    // ==========================================
                    // IMAGE PATH
                    // ==========================================

                    string imagePath =
                        reader["Image_Path"].ToString();


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
                                Image tempImage =
                                    Image.FromFile(fullImagePath);

                                itemImage =
                                    new Bitmap(tempImage);

                                tempImage.Dispose();
                            }
                            catch
                            {
                                itemImage = null;
                            }
                        }
                    }


                    // ==========================================
                    // ADD TO LOST GRID
                    // ==========================================

                    GRD_Lost.Rows.Add(
                        itemImage,
                        reader["Item_Name"].ToString(),
                        reader["Date_Lost"].ToString(),
                        reader["Lost_Location"].ToString(),
                        reader["Description"].ToString(),
                        reader["Status"].ToString(),
                        
                        "Delete"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lost Reports Database Error:\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                // ==========================================
                // CLEAN UP READER
                // ==========================================

                if (reader != null)
                {
                    reader.Close();
                    reader.Dispose();
                }


                // ==========================================
                // CLEAN UP COMMAND
                // ==========================================

                if (command != null)
                {
                    command.Dispose();
                }


                // ==========================================
                // CLEAN UP CONNECTION
                // ==========================================

                if (connection != null)
                {
                    if (connection.State !=
                        System.Data.ConnectionState.Closed)
                    {
                        connection.Close();
                    }

                    connection.Dispose();
                }
            }
        }


        // ==========================================
        // LOAD FOUND REPORTS
        // ==========================================

        private void LoadFoundReports()
        {
            string query = @"
                SELECT
                    Item_Name,
                    Found_Location,
                    Category,
                    Date_Found,
                    Description,
                    Image_Path,
                    Status
                FROM FoundItems
                WHERE User_ID = @User_ID";


            SqlConnection connection = null;
            SqlCommand command = null;
            SqlDataReader reader = null;


            try
            {
                // ==========================================
                // CREATE CONNECTION
                // ==========================================

                connection =
                    new SqlConnection(connectionString);


                // ==========================================
                // OPEN CONNECTION
                // ==========================================

                connection.Open();


                // ==========================================
                // CREATE COMMAND
                // ==========================================

                command =
                    new SqlCommand(query, connection);


                // ==========================================
                // ADD USER ID
                // ==========================================

                command.Parameters.Add(
                    "@User_ID",
                    System.Data.SqlDbType.VarChar,
                    50
                );

                command.Parameters["@User_ID"].Value =
                    loggedUser;


                // ==========================================
                // EXECUTE QUERY
                // ==========================================

                reader =
                    command.ExecuteReader();


                // ==========================================
                // CLEAR OLD ROWS
                // ==========================================

                GRD_Found.Rows.Clear();


                // ==========================================
                // READ DATABASE
                // ==========================================

                while (reader.Read())
                {
                    Image itemImage = null;


                    // ==========================================
                    // IMAGE PATH
                    // ==========================================

                    string imagePath =
                        reader["Image_Path"].ToString();


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
                                Image tempImage =
                                    Image.FromFile(fullImagePath);

                                itemImage =
                                    new Bitmap(tempImage);

                                tempImage.Dispose();
                            }
                            catch
                            {
                                itemImage = null;
                            }
                        }
                    }


                    // ==========================================
                    // ADD TO FOUND GRID
                    // ==========================================

                    GRD_Found.Rows.Add(
                        itemImage,
                        reader["Item_Name"].ToString(),
                        reader["Date_Found"].ToString(),
                        reader["Found_Location"].ToString(),
                        reader["Description"].ToString(),
                        reader["Status"].ToString(),
                       
                        "Delete"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Found Reports Database Error:\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                // ==========================================
                // CLEAN UP READER
                // ==========================================

                if (reader != null)
                {
                    reader.Close();
                    reader.Dispose();
                }


                // ==========================================
                // CLEAN UP COMMAND
                // ==========================================

                if (command != null)
                {
                    command.Dispose();
                }


                // ==========================================
                // CLEAN UP CONNECTION
                // ==========================================

                if (connection != null)
                {
                    if (connection.State !=
                        System.Data.ConnectionState.Closed)
                    {
                        connection.Close();
                    }

                    connection.Dispose();
                }
            }
        }


        // ==========================================
        // CLOSE BUTTON
        // ==========================================

        private void GRD_Lost_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (GRD_Lost.Columns[e.ColumnIndex].Name == "DeleteL")
            {
                string itemName =
                    GRD_Lost.Rows[e.RowIndex].Cells["colItemName"].Value?.ToString();

                DeleteReport("LostItems", itemName);
                LoadLostReports();
            }
        }

        private void GRD_Found_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (GRD_Found.Columns[e.ColumnIndex].Name == "DeleteF")
            {
                string itemName =
                    GRD_Found.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value?.ToString();

                DeleteReport("FoundItems", itemName);
                LoadFoundReports();
            }
        }

        private void DeleteReport(string tableName, string itemName)
        {
            if (string.IsNullOrWhiteSpace(itemName))
                return;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this report?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
                return;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $@"
                    DELETE FROM {tableName}
                    WHERE Item_Name = @ItemName
                    AND User_ID = @User_ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ItemName", itemName);
                    command.Parameters.AddWithValue("@User_ID", loggedUser);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Report deleted successfully!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
