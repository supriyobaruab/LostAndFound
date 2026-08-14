using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Data.SqlClient;

namespace lostandfound.cs
{
    public partial class SearchItemForm : Form
    {
        public SearchItemForm()
        {
            InitializeComponent();

            SelectItem.Items.AddRange(new string[]
                {
                    "Bag",
                    "Phone",
                    "Wallet",
                    "Laptop"
                 });
            SelectItem.SelectedIndex = -1;

            LoadAllItems();

        }
        private void LoadAllItems()
        {
            string connectionString = "Server=localhost;Database=LostAndFound;Trusted_Connection=True;TrustServerCertificate=True;";

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = @"SELECT image_Path, item_name, date_found,
                                found_location, status
                         FROM FoundItems";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                Find_Items.Rows.Clear();

                while (reader.Read())
                {
                    object ImagePath = reader["image_Path"];

                    Find_Items.Rows.Add(
                        ImagePath,
                        reader["item_name"].ToString(),
                        reader["date_found"].ToString(),
                        reader["found_location"].ToString(),
                        reader["status"].ToString()
                    );
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void SelectItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectItem.SelectedItem == null)
                return;

            string connectionString = "Server=localhost;Database=LostAndFound;Trusted_Connection=True;TrustServerCertificate=True;";

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = @"SELECT image_Path, item_name, date_found,
                                found_location, status
                         FROM FoundItems
                         WHERE Category = @Category";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue(
                    "@Category",
                    SelectItem.SelectedItem.ToString()
                );

                SqlDataReader reader = cmd.ExecuteReader();

                Find_Items.Rows.Clear();

                while (reader.Read())
                {
                    object ImagePath = reader["image_Path"];

                    Find_Items.Rows.Add(
                        ImagePath,
                        reader["item_name"].ToString(),
                        reader["date_found"].ToString(),
                        reader["found_location"].ToString(),
                        reader["status"].ToString()
                    );
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
    }

