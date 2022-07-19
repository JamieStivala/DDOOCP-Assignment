using Booking_System.backend.database;
using Booking_System.backend.model.user;
using Booking_System.frontend.user;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using Booking_System.backend.database.hotel;
using Booking_System.backend.model.hotel;
using Booking_System.frontend.admin;

namespace Booking_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var user = UserWrapper.GetUser("admin@gmail.com", "admin");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AdminUserWindow());
            
        }
    }
}
