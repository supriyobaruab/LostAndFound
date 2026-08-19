
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace lostandfound.cs
{
    public partial class LostItemForm : Form
    {
        private string selectedImagePath = "";

        private string connectionString =
            "Server=localhost;Database=LostAndFound;Trusted_Connection=True;TrustServerCertificate=True;";


        // ==========================================
        // CONSTRUCTOR
        // ==========================================

        public LostItemForm()
        {
            InitializeComponent();

            // Add categories
            CB_Category.Items.AddRange(new string[]
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

            CB_Category.SelectedIndex = -1;
        }


        // ==========================================
        // UPLOAD IMAGE
        // ==========================================

        private void Upload_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter =
                "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            dialog.Title = "Select Lost Item Image";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = dialog.FileName;

                try
                {
                    using (Image tempImage =
                           Image.FromFile(selectedImagePath))
                    {
                        Upload_Image.Image = new Bitmap(tempImage);
                    }

                    Upload_Image.SizeMode =
                        PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Could not load image:\n" + ex.Message,
                        "Image Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }


        // ==========================================
        // SAVE LOST ITEM
        // ==========================================

        private void btn_Save_Click(object sender, EventArgs e)
        {
            // --------------------------------------
            // CHECK ITEM NAME
            // --------------------------------------

            if (string.IsNullOrWhiteSpace(TB_ItemName.Text))
            {
                MessageBox.Show(
                    "Please enter the item name.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                TB_ItemName.Focus();
                return;
            }


            // --------------------------------------
            // CHECK LOST LOCATION
            // --------------------------------------

            if (string.IsNullOrWhiteSpace(TB_LostLoc.Text))
            {
                MessageBox.Show(
                    "Please enter the lost location.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                TB_LostLoc.Focus();
                return;
            }


            // --------------------------------------
            // CHECK CATEGORY
            // --------------------------------------

            if (CB_Category.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a category.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                CB_Category.Focus();
                return;
            }


            // --------------------------------------
            // CHECK DESCRIPTION
            // --------------------------------------

            if (string.IsNullOrWhiteSpace(TB_Description.Text))
            {
                MessageBox.Show(
                    "Please enter a description.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                TB_Description.Focus();
                return;
            }


            // ======================================
            // IMAGE HANDLING
            // ======================================

            string imagePath = "";

            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                try
                {
                    string imageFolder = Path.Combine(
                        Application.StartupPath,
                        "Images",
                        "LostItems"
                    );

                    if (!Directory.Exists(imageFolder))
                    {
                        Directory.CreateDirectory(imageFolder);
                    }


                    // Get image extension
                    string extension =
                        Path.GetExtension(selectedImagePath);


                    // Generate unique filename
                    string fileName =
                        Guid.NewGuid().ToString() + extension;


                    // Destination path
                    string destinationPath =
                        Path.Combine(
                            imageFolder,
                            fileName
                        );


                    // Copy image
                    File.Copy(
                        selectedImagePath,
                        destinationPath,
                        true
                    );


                    // Path stored in database
                    imagePath = Path.Combine(
                        "Images",
                        "LostItems",
                        fileName
                    );


                    // Use forward slash
                    imagePath =
                        imagePath.Replace("\\", "/");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error uploading image:\n" + ex.Message,
                        "Image Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }
            }


            // ======================================
            // DATABASE INSERT
            // ======================================

            string query = @"
    INSERT INTO LostItems
    (
        Item_Name,
        Lost_Location,
        Category,
        Date_Lost,
        Description,
        Image_Path,
        Status
    )
    VALUES
    (
        @ItemName,
        @LostLocation,
        @Category,
        @LostDate,
        @Description,
        @ImagePath,
        'Lost'
    )";

            try
            {
                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@ItemName",
                            TB_ItemName.Text.Trim()
                        );

                        command.Parameters.AddWithValue(
                            "@LostLocation",
                            TB_LostLoc.Text.Trim()
                        );

                        command.Parameters.AddWithValue(
                            "@Category",
                            CB_Category.Text
                        );

                        command.Parameters.AddWithValue(
                            "@LostDate",
                            DTP_LostDate.Value.Date
                        );

                        command.Parameters.AddWithValue(
                            "@Description",
                            TB_Description.Text.Trim()
                        );

                        command.Parameters.AddWithValue(
                            "@ImagePath",
                            imagePath
                        );
                        

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Lost item saved successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.Close();
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
        // CANCEL BUTTON
        // ==========================================

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // ==========================================
        // OPTIONAL EVENT HANDLERS
        // ==========================================

        private void LostItemForm_Load(object sender, EventArgs e)
        {
        }

        private void CB_Category_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }

        private void DTP_LostDate_ValueChanged(
            object sender,
            EventArgs e)
        {
        }

        private void TB_ItemName_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        private void TB_LostLoc_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        private void TB_Description_TextChanged(
            object sender,
            EventArgs e)
        {
        }
    }
}