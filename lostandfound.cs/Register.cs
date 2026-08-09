using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lostandfound.cs
{
    public partial class Register : Form
    {
        public object UseSystemPasswordChar { get; private set; }
        public object True { get; private set; }

        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Registration_Click(object sender, EventArgs e)
        {
            bool IsValidEmail(string email)
            {
                return email.Contains("@") && email.Contains(".");
            }

            if (string.IsNullOrWhiteSpace(TxtUser.Text) || string.IsNullOrWhiteSpace(TxtEmail.Text) || string.IsNullOrWhiteSpace(Txt_UserID.Text) || string.IsNullOrWhiteSpace(Txt_Password.Text) || string.IsNullOrWhiteSpace(Txt_ConPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (!Regex.IsMatch(Txt_UserID.Text, @"^[a-zA-Z0-9_-]+$"))
            {
                MessageBox.Show("User ID can only contain letters, numbers, and underscores.");
                return;
            }

            if (!IsValidEmail(TxtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            if (RD_Student.Checked || RD_Officer.Checked)
            {
                if (Txt_Password.Text != Txt_ConPassword.Text)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }
                else
                {
                    string connectionString = "Server=localhost;Database=LostAndFound;Trusted_Connection=true; TrustServerCertificate=true;";
                    SqlConnection conn = new SqlConnection(connectionString);

                    try
                    {
                        conn.Open();
                        //Check User
                        string queryCheck = "SELECT COUNT(*) FROM [User] WHERE User_ID = @User_ID";
                        SqlCommand cmdCheck = new SqlCommand(queryCheck, conn);

                        cmdCheck.Parameters.AddWithValue("@User_ID", Txt_UserID.Text);
                        

                        int count = (int)cmdCheck.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("User ID already exists. Please reset your Password.");
                            return;
                        }

                        //Insert User
                        string query = "INSERT INTO [User] (Name, Email, User_ID, Password, Role) VALUES (@Name, @Email, @User_ID, @Password, @Role)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Name", TxtUser.Text);
                        cmd.Parameters.AddWithValue("@Email", TxtEmail.Text);
                        cmd.Parameters.AddWithValue("@User_ID", Txt_UserID.Text);
                        cmd.Parameters.AddWithValue("@Password", Txt_Password.Text);
                        cmd.Parameters.AddWithValue("@Role", RD_Student.Checked ? "student" : "officer");
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Registration successful!");
                    }
                    catch(Exception Error) {
                        MessageBox.Show(Error.Message);
                    }
                    finally
                    {
                        conn.Close();
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Occupation.");
                return;
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

