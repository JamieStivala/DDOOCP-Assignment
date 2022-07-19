using Booking_System.backend.database;
using Booking_System.backend.model.user;
using Booking_System.frontend.user;
using System;
using System.Windows.Forms;

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
            var user = UserWrapper.GetUser("jamiestivala@gmail.com", "Pukka1234!");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainUserWindow(user));
        }
    }
}
