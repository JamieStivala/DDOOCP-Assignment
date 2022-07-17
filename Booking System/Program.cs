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
            var user = new User("Jamie", "Stivala", "jamiestivala@gmail.com", "Pukka1234!", "77223883", DateTime.Today, 'M', "368201L", "Maltese", "48 Rhapsody, Donato Del Piano Street Zurrieq", UserType.Customer);
            UserWrapper.CreateUser(user);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainUserWindow(user));
        }
    }
}
