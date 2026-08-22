using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace lostandfound.cs
{
    public partial class FoundItemForm : Form
    {
        private string selectedImagePath = "";
        private string loggedUser;
        string connectionString = "Server=localhost;Database=LostAndFound;Trusted_Connection=True;TrustServerCertificate=True;";
        public FoundItemForm(string User_ID)

        {
            InitializeComponent();

            loggedUser = User_ID;

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

       

        private void Upload_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            dialog.Title = "Select Found Item Image";

           

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = dialog.FileName;

                // Display image
                Upload_Image.Image = Image.FromFile(selectedImagePath);
                //Upload_Image.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            // Check Item Name
            if (string.IsNullOrWhiteSpace(TB_ItemName.Text))
            {
                MessageBox.Show("Please enter the item name.");
                TB_ItemName.Focus();
                return;
            }

            // Check Location
            if (string.IsNullOrWhiteSpace(TB_FoundLoc.Text))
            {
                MessageBox.Show("Please enter the found location.");
                TB_FoundLoc.Focus();
                return;
            }

            // Check Category
            if (CB_Category.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.");
                CB_Category.Focus();
                return;
            }

            // Check Description
            if (string.IsNullOrWhiteSpace(TB_Description.Text))
            {
                MessageBox.Show("Please enter a description.");
                TB_Description.Focus();
                return;
            }


            // =========================
            // IMAGE HANDLING
            // =========================

            string imagePath = "";

            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                try
                {
                    // Create:
                    // Images
                    //     └── FoundItems

                    string imageFolder = Path.Combine(
                        Application.StartupPath,
                        "Images",
                        "FoundItems"
                    );

                    if (!Directory.Exists(imageFolder))
                    {
                        Directory.CreateDirectory(imageFolder);
                    }


                    // Get image extension
                    string extension = Path.GetExtension(selectedImagePath);


                    // Generate unique filename
                    string fileName = Guid.NewGuid().ToString() + extension;


                    // Full destination path
                    string destinationPath = Path.Combine(
                        imageFolder,
                        fileName
                    );


                    // Copy image
                    File.Copy(
                        selectedImagePath,
                        destinationPath,
                        true
                    );


                    // This is what will be stored in database
                    imagePath = Path.Combine(
                        "Images",
                        "FoundItems",
                        fileName
                    );

                    // Make path use /
                    imagePath = imagePath.Replace("\\", "/");
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


            // =========================
            // DATABASE INSERT
            // =========================

            string query = @"
                INSERT INTO FoundItems
                (
                    Item_Name,
                    Found_Location,
                    Category,
                    Date_Found,
                    Description,
                    Image_Path,
                    Status,
                    User_ID
                )
                VALUES
                (
                    @ItemName,
                    @FoundLocation,
                    @Category,
                    @FoundDate,
                    @Description,
                    @ImagePath,
                    @Status,
                    @User_ID
                )";


            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue(
                    "@ItemName",
                    TB_ItemName.Text.Trim()
                );

                command.Parameters.AddWithValue(
                    "@FoundLocation",
                    TB_FoundLoc.Text.Trim()
                );

                command.Parameters.AddWithValue(
                    "@Category",
                    CB_Category.Text
                );

                command.Parameters.AddWithValue(
                    "@FoundDate",
                    DTP_FoundDate.Value.Date
                );
                command.Parameters.AddWithValue(
                    "@Status","Found");

                command.Parameters.AddWithValue(
                    "@Description",
                    TB_Description.Text.Trim()
                );

                command.Parameters.AddWithValue(
                    "@ImagePath",
                    imagePath
                );
                command.Parameters.AddWithValue(
                  "@User_ID",
                  loggedUser
              );


                command.ExecuteNonQuery();


                MessageBox.Show(
                    "Found item reported successfully!",
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
            finally
            {
                connection.Close();
            }
        }
    
    }
}
