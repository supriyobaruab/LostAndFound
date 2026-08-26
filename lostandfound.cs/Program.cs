using System;
using System.Windows.Forms;

namespace lostandfound.cs
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            //Application.Run(new Dashboard("Supriyo","24-59312-3"));
            //Application.Run(new Register());
            // Application.Run(new LostItemForm());
            //Application.Run(new FoundItemForm());
             Application.Run(new StaffDashboard());
            //Application.Run(new SearchItemForm());
            //Application.Run(new ViewReports());
            //Application.Run(new AdminDashboard());

        }
    }
}
