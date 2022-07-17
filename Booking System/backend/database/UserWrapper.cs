using Booking_System.backend.model.user;
using System;
using System.Diagnostics;
using System.Text;

namespace Booking_System.backend.database
{
    public class UserWrapper
    {
        public static void CreateUser(User user)
        {
            string insertQuery = $"INSERT INTO tblUser VALUES" +
                $"('{user.FirstName}', '{user.LastName}', '{user.Email}', '{user.Password}', '{user.ContactNumber}', '{user.DateOfBirth.ToShortDateString()}', '{user.Gender + ""}', '{user.IdCard}', '{user.Nationality}', '{user.Address}', '{(int)user.Type}')"; //Query to insert the information into the database


            DatabaseResult result = DatabaseWrapper.InsertIntoDatabase(insertQuery); //Run the query and get the result

            //Switch the result based on the ENUM representing result
            switch (result)
            {
                case DatabaseResult.Ok:
                    return;
                case DatabaseResult.Duplicate:
                    throw new Exception("A user with that email already exists.  Please use another email or contact one of the admins to update your password.");
                default:
                    throw new Exception("An unknown error has occurred.");
            }
        }

        public static User GetUser(string email, string password) 
        {
            string findUserCommand = $"SELECT * FROM tblUser WHERE Email='{email}'";
            (DatabaseResult databaseResult, var currentRow) = (DatabaseWrapper.GetFromDatabase(findUserCommand))[0];

            switch (databaseResult)
            {
                case DatabaseResult.Ok:

                    //Create the user
                    User user = new User(currentRow["Email"].ToString(), currentRow["Password"].ToString())
                    {
                        FirstName = currentRow["FirstName"].ToString(),
                        LastName = currentRow["LastName"].ToString(),
                        DateOfBirth = (DateTime)currentRow["DateOfBirth"],
                        IdCard = currentRow["IDCardNumber"].ToString(),
                        ContactNumber = currentRow["ContactNumber"].ToString(),
                        Nationality = currentRow["Nationality"].ToString(),
                        Address = currentRow["Address"].ToString(),
                        Gender = currentRow["Gender"].ToString()[0],
                        Type = (UserType)currentRow["Type"]
                    };

                    
                    if(!user.VerifyPassword(password)) throw new Exception("The password entered for this user is incorrect."); //Verify the password

                    return user;

                case DatabaseResult.NotFound:
                    throw new Exception("A user with that email address was not found.");
                default:
                    throw new Exception("An unknown error has occurred.");
            }
        }
    }
}
