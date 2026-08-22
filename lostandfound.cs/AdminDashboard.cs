using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace lostandfound.cs
{
    public partial class AdminDashboard : Form
    {
        string connectionString =
        "Server=localhost;Database=LostAndFound;Trusted_Connection=True;TrustServerCertificate=True;";

        public AdminDashboard()
        {
            InitializeComponent();
            Grd_User.AutoGenerateColumns = false;
            //clicking cell items colour change problem solve
            Grd_User.DefaultCellStyle.SelectionBackColor =
            Grd_User.DefaultCellStyle.BackColor;

            Grd_User.DefaultCellStyle.SelectionForeColor =
            Grd_User.DefaultCellStyle.ForeColor;
            //method call
            LoadUsers();
            SetMemberPanelReadOnly(true);
        }
        private void LoadUsers()
        {
            string query = "SELECT User_ID, Name, Email, Role FROM [User]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        Grd_User.DataSource = table;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error loading users: " + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }
        private void SetMemberPanelReadOnly(bool readOnly)
        {
            TB_Name.ReadOnly = readOnly;
            TB_Email.ReadOnly = readOnly;
            TB_UID.ReadOnly = readOnly;
            TB_Password.ReadOnly = readOnly;
            //combobox
            CB_Role.Enabled = !readOnly;
            //button
            btn_Save.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Clear.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {

        }

        private void LB_AllLFReport_Click(object sender, EventArgs e)
        {

        }

        private void Grd_User_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (Grd_User.Columns[e.ColumnIndex].Name == "Update")
            {
                // Get selected user's information
                TB_Name.Text = Grd_User.Rows[e.RowIndex].Cells["colName"].Value?.ToString();
                TB_Email.Text = Grd_User.Rows[e.RowIndex].Cells["colEmail"].Value?.ToString();
                TB_UID.Text = Grd_User.Rows[e.RowIndex].Cells["UID"].Value?.ToString();
                CB_Role.Text = Grd_User.Rows[e.RowIndex].Cells["colRole"].Value?.ToString();

                // Enable editing
                SetMemberPanelReadOnly(false);
                btn_Save.Enabled = true;
                btn_Delete.Enabled = true;
                btn_Clear.Enabled = true;
            }
            }
    }
}
