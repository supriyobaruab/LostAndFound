using System;
using System.Windows.Forms;

namespace lostandfound.cs
{
    public partial class Login : Form
    {
        public bool UseSystemPassword { get; private set; }

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            UseSystemPassword = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
   
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "24-59307-3" && textBox2.Text=="1234")
            {
                MessageBox.Show("Login Successful!");
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }
    }
    }


