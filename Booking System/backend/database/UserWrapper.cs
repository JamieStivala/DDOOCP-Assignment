using Booking_System.backend.model.user;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_System.backend.database
{
    public class UserWrapper
    {
        public static User GetUser(string email, string password)
        {
            User user = new User("Jamie", "Stivala", email, password, false, new DateTime(), "77223883", "0368201L");

            if (user.ConfirmPassword(password)) return user;
            else throw new Exception("Invalid password provided for user with this email address.");
        }
    }
}
