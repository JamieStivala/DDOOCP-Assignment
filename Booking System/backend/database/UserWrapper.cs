using Booking_System.backend.model.user;
using System;
using System.Diagnostics;
using System.Text;

namespace Booking_System.backend.database
{
    public class UserWrapper
    {

        public static string CreateUser(User user)
        {
            Debug.WriteLine((int)user.Type);
            string insertQuery = $"INSERT INTO tblUser VALUES" +
                $"('{user.FirstName}', '{user.LastName}', '{user.Email}', '{user.Password}', '{user.ContactNumber}', '{user.DateOfBirth.ToShortDateString()}', '{user.Gender + ""}', '{user.IdCard}', '{user.Nationality}', '{user.Address}', '{(int)user.Type}')"; //Query to insert the information into the database


            DatabaseResult result = DatabaseWrapper.InsertIntoDatabase(insertQuery); //Run the query and get the result

            //Switch the result based on the ENUM representing result
            switch (result)
            {
                case DatabaseResult.OK:
                    return null;
                case DatabaseResult.DUPLICATE:
                    return "A user with that email already exists.  Please use another email or contact one of the admins to update your password.";
                default:
                    return "An unknown error has occurred.";
            }
        }

        public static User GetUser(string email, string password)
        {
            /*
            User user = new User("Jamie", "Stivala", email, password, false, new DateTime(), "77223883", "0368201L");

            if (user.ConfirmPassword(password)) return user;
            else throw new Exception("Invalid password provided for user with this email address.");
            */
            return null;
        }
    }
}
