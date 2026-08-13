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

        private void btn_ReportLost_Click(object sender, EventArgs e)
        {
            LostItemForm lostItemForm = new LostItemForm();
            lostItemForm.Show();
        }

        private void Btn_ReportItem_Click(object sender, EventArgs e)
        {
           ViewReportsForm reportForm = new ViewReportsForm();
            reportForm.Show();
        }

        private void Btn_FindItems_Click(object sender, EventArgs e)
        {
            FoundItemForm foundItemForm = new FoundItemForm();
            foundItemForm.Show();
        }

        private void Btn_MyReports_Click(object sender, EventArgs e)
        {
            ViewReportsForm myReportsForm = new ViewReportsForm();
            myReportsForm.Show();
        }
    }
}

