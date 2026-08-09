using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if (!Regex.IsMatch(Txt_UserID.Text, @"^[a-zA-Z0-9_]+$"))
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
                    //Database Logic 
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

