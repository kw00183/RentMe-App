using RentMe_App.View;
using System;
using System.Windows.Forms;

namespace RentMe_App
{
    /// <summary>
    /// Main method class
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
