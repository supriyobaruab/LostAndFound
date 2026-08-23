using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lostandfound.cs
{
    public partial class StaffDashboard : Form
    {
        string connectionString =
        "Server=localhost;Database=LostAndFound;Trusted_Connection=True;TrustServerCertificate=True;";
        public StaffDashboard()
        {
            InitializeComponent();
            //clicking cell items colour change problem solve
            Grd_ReviewTable.DefaultCellStyle.SelectionBackColor =
            Grd_ReviewTable.DefaultCellStyle.BackColor;

            Grd_ReviewTable.DefaultCellStyle.SelectionForeColor =
            Grd_ReviewTable.DefaultCellStyle.ForeColor;
            //keep columns readonly
            Grd_ReviewTable.Columns["colItem"].ReadOnly = true;
            Grd_ReviewTable.Columns["colReporter"].ReadOnly = true;
            Grd_ReviewTable.Columns["colStatus"].ReadOnly = true;
            LoadReports();
        }
        private void LoadReports()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    string query = @"
        SELECT
            L.Item_Name AS Item,
            U.Name AS Reporter,
            'Lost' AS Status
        FROM LostItems L
        INNER JOIN [User] U ON L.User_ID = U.User_ID

        UNION ALL

        SELECT
            F.Item_Name AS Item,
            U.Name AS Reporter,
            'Found' AS Status
        FROM FoundItems F
        INNER JOIN [User] U ON F.User_ID = U.User_ID;
    ";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        Grd_ReviewTable.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reports: " + ex.Message);
            }
        }


        //======================================================================================================================================================================
        //LOGOUT
        //======================================================================================================================================================================



        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
       "Are you sure you want to logout?",
       "Confirm Logout",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();

                this.Close();
            }
        }
    }
}
