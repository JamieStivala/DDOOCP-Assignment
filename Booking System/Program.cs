using Booking_System.backend.database;
using Booking_System.backend.model.user;
using Booking_System.frontend.user;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Booking_System.backend.database.hotel;
using Booking_System.backend.helpers;
using Booking_System.backend.model.hotel;
using Booking_System.frontend.admin;
using Booking_System.frontend.auth;
using Booking_System.frontend.user.bookings.create;
using Booking_System.frontend.user.bookings.modify;

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
            //Create a default admin user
            try
            {
                bool adminFound = UserWrapper.GetAllUsers().Any(user => user.Type == UserType.Admin); //Check if an admin is existing, if not, create the default admin.
                
                UserWrapper.CreateUser(new User("Jamie", "Stivala", "jamiestivala@gmail.com", "Pukka1234!", "77223883", new DateTime(2001, 09, 16, 1, 1, 1), 'M', "0368201L", "Malta", "48 Rhapsody", UserType.Customer));
                if (!adminFound) UserWrapper.CreateUser(new User("Admin", "Account", "admin@admin.com", "SecurePassword123!", "00000000", new DateTime(2001, 09, 16, 1, 1, 1), 'O', "000000A", "British", "London Bridge", UserType.Admin));
            }
            catch (Exception ex)
            {
                Debug.WriteLine("An admin user already exists.");
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Create a default admin user

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var userr = UserWrapper.GetUser("jamiestivala@gmail.com", "Pukka1234!");
            Application.Run(new ListBookings(userr));
        }
    }
}
