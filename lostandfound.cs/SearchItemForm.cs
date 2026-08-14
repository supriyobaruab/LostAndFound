using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
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
                    "Bag",
                    "Phone",
                    "Wallet",
                    "Laptop"
                 });

            Find_Items.Rows.Add(
                null,
                "Black Bag",
                "14/08/2026",
                "AIUB Campus",
                "Found",
                "View"
);
        }

        



    }
    }

