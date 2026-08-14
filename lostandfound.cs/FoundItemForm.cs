using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lostandfound.cs
{
    public partial class FoundItemForm : Form
    {
        public FoundItemForm()
        {
            InitializeComponent();

            CB_Category.Items.AddRange(new string[]
                {
                    "Bag",
                    "Electronics",
                    "Keys",
                    "ID card",
                    "Books",
                    "Wallet",
                    "Cloth",
                    "Other"
                 });
        }

        private void FoundItemForm_Load(object sender, EventArgs e)
        {

        }

        private void TB_FoundLoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void LB_FoundLocation_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LB_FoundDate_Click(object sender, EventArgs e)
        {

        }
    }
}
