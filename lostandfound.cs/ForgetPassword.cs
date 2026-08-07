using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

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

            try
            {
                conn.Open();

                string query = "SELECT Count(*) FROM Login WHERE User_ID = @User_ID";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue(@"User_ID", TxtUser.Text);

                object result = cmd.ExecuteScalar();

               int count = Convert.ToInt32(result);

                if (count>0) { 
                    //MessageBox.Show("User ID exists. You can reset your password.");
                    UserID.Visible = false;
                    TxtUser.Visible = false;
                    MessageBox.Show("User ID exists. You can reset your password.");
                    LabelPassword.Visible = true;
                    TxtPassword.Visible = true;
                    PassBanner.Text = "Please enter your new password.";
                    

                }
                else
                {
                    MessageBox.Show("User ID does not exist. Please check your User ID.");
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

            SqlConnection conn = new SqlConnection(connectionString);

        }
    }
}
