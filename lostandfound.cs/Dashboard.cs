using System;
using System.Windows.Forms;
// im supposed to work in this segment
namespace lostandfound.cs
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
          
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            label1.Text = "Lost And Found Management";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LostItemForm lost = new LostItemForm();
            lost.Show();
            this.Hide();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            FoundItemForm found = new FoundItemForm();
            found.Show();
            this.Hide();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            SearchItemForm search = new SearchItemForm();
            search.Show();
            this.Hide();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            ViewReportsForm reports = new ViewReportsForm();
            reports.Show();
            this.Hide();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

