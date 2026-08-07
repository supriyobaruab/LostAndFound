using System;
using System.Windows.Forms;
using System.Data;
using Microsoft.Data.SqlClient;

namespace lostandfound.cs
{
    public partial class Login : Form
    {
        public bool UseSystemPassword { get; private set; }

        public Login()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
           
            string connectionString = "Server=localhost;Database=LostAndFound;Trusted_Connection=True;TrustServerCertificate=True;";

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = "SELECT Role FROM Login WHERE User_ID = @User_ID AND Password = @Password";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@User_ID", textBox1.Text);
                cmd.Parameters.AddWithValue("@Password", textBox2.Text);


                object result = cmd.ExecuteScalar();
       

                if (result != null)

                {
                    string role = result.ToString().Trim();
                    MessageBox.Show(role);

                    if (role == "admin")
                    {
                        //Admin admin = new Admin();
                        //admin.Show();
                        //this.Hide();
                    }
                    else if (role == "user")
                    {
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    //else
                    //{
                    //    MessageBox.Show("Invalid UserID or Password. Please try again.");
                    //}
                }
                else
                {
                    MessageBox.Show("Invalid UserID or Password. Please try again.");
                }

            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conn.Close();
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }

        private void Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
        }
    }
    }


