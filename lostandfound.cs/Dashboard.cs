using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
// im supposed to work in this segment
namespace lostandfound.cs
{
    public partial class Dashboard : Form
    {
        public Dashboard(string name)
        {
            InitializeComponent();
            
            Txt_Welcome.Text = "Welcome Back, " + name.Split(' ')[0] + " !";
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

