using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lostandfound.cs
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=LostAndFound;Trusted_Connection=True;TrustServerCertificate=True;";

            SqlConnection conn = new SqlConnection(connectionString);

            if(string.IsNullOrWhiteSpace(TxtUser.Text))
            {
                MessageBox.Show("User ID cannot be empty.");
                return;
            }

            try
            {
                conn.Open();

                string query = "SELECT [User] FROM Login WHERE User_ID = @User_ID";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@User_ID", TxtUser.Text);

                object result = cmd.ExecuteScalar();

                
                if(result == null)
                {
                    MessageBox.Show("User ID does not exist.");
                    return;
                }
                
                string role = result.ToString().Trim();

                if (role == "admin")
                {
                    MessageBox.Show("Admin accounts cannot reset passwords here.");
                    return;
                }
                else 
                {
                    //MessageBox.Show("User ID exists. You can reset your password.");
                    IsExist.Visible = true;
                    UserID.Visible = false;
                    TxtUser.Visible = false;
                    LabelPassword.Visible = true;
                    TxtPassword.Visible = true;
                    PassBanner.Text = "Please enter your new password.";
                    RecoverBtn.Visible = true;
                    FindAccount.Visible = false;
                    TxtPassword.PasswordChar = '*';

                }

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RecoverBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=LostAndFound;Trusted_Connection=True;TrustServerCertificate=True;";
            if (string.IsNullOrWhiteSpace(TxtPassword.Text))
            {
                MessageBox.Show("Password cannot be empty.");
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = "Update [User] SET Password = @Password WHERE User_ID = @User_ID";

                SqlCommand cmd = new SqlCommand(query, conn);

                //MessageBox.Show("User ID: " + TxtUser.Text + "\nNew Password: " + TxtPassword.Text);

                cmd.Parameters.AddWithValue("@User_ID", TxtUser.Text);
                cmd.Parameters.AddWithValue("@Password", TxtPassword.Text);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Password updated successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("User ID not found. Nothing was updated.");
                }

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
