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
            //UserWrapper.CreateUser(new User("Jamie", "Stivala", "jamiestivala@gmail.com", "Pukka1234!", "77223883", new DateTime(2001,09,16, 1,1,1), 'M', "0368201L", "Malta", "48 Rhapsody", UserType.Customer));
            //UserWrapper.CreateUser(new User("Jamie", "Stivala", "jamie.stivala@gmail.com", "Pukka1234!", "77223883", new DateTime(2001,09,16, 1,1,1), 'M', "0368201L", "Malta", "48 Rhapsody", UserType.Customer));
            //UserWrapper.CreateUser(new User("Jamie", "Stivalaoa", "jam.stivala@gmail.com", "Pukka1234!", "77223883", new DateTime(2001,09,16, 1,1,1), 'M', "0368201L", "Malta", "48 Rhapsody", UserType.Admin));
            var user = UserWrapper.GetUser("jamie.stivala@gmail.com", "Pukka1234!");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainUserWindow(user));
            //Application.Run(new AdminUserWindow());
            
        }
    }
}
