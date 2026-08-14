using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lostandfound.cs
{
    public partial class SearchItemForm : Form
    {
        public SearchItemForm()
        {
            InitializeComponent();

            SelectItem.Items.AddRange(new string[]
                {
                    "Choose an item",
                    "Bag",
                    "Phone",
                    "Wallet",
                    "Laptop"
                 });

            SelectItem.SelectedIndex = 0;
        }



    }
    }

