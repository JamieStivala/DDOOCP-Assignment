using Booking_System.backend.model.user;
using System;
using System.Collections.Generic;

namespace Booking_System.backend.database
{
    public class UserWrapper
    {
        public static void CreateUser(User user)
        {
            string insertQuery = $"INSERT INTO tblUser VALUES" +
                $"('{user.Uuid}', '{user.FirstName}', '{user.LastName}', '{user.Email}', '{user.Password}', '{user.ContactNumber}', '{user.DateOfBirth.ToShortDateString()}', '{user.Gender + ""}', '{user.IdCard}', '{user.Nationality}', '{user.Address}', '{(int)user.Type}')"; //Query to insert the information into the database


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

        public static void UpdateUser(User user)
        {
            string updateQuery = $"UPDATE tblUser SET" +
                                 $" FirstName='{user.FirstName}', LastName='{user.LastName}', " +
                                 $" Email='{user.Email}', [Password]='{user.Password}', " +
                                 $" DateOfBirth='{user.DateOfBirth.ToShortDateString()}', IDCardNumber='{user.IdCard}', " +
                                 $" ContactNumber='{user.ContactNumber}', Nationality='{user.Nationality}', " +
                                 $" Address='{user.Address}', Gender='{user.Gender + ""}', " +
                                 $" Type='{(int)user.Type}' " +
                                 $"WHERE uuid='{user.Uuid}'";

            DatabaseResult result = DatabaseWrapper.UpdateFromDatabase(updateQuery);

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
                        Uuid = currentRow["uuid"].ToString(),
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


                    if (!user.VerifyPassword(password)) throw new Exception("The password entered for this user is incorrect."); //Verify the password

                    return user;

                case DatabaseResult.NotFound:
                    throw new Exception("A user with that email address was not found.");
                default:
                    throw new Exception("An unknown error has occurred.");
            }
        }

        public static void DeleteUser(User user)
        {
            string query = $"DELETE * FROM tblUser WHERE uuid={user.Uuid}";
            DatabaseResult result = DatabaseWrapper.DeleteFromDatabase(query);

            //Switch the result based on the ENUM representing result
            switch (result)
            {
                case DatabaseResult.Ok:
                    return;
                default:
                    throw new Exception("An unknown error has occurred.");
            }
        }


        public static User[] GetAllUsers()
        {
            List<User> users = new List<User>();

            string getAllUsers = $"SELECT * FROM tblUser";
            var result = DatabaseWrapper.GetFromDatabase(getAllUsers);
            
            foreach (Tuple<DatabaseResult, Dictionary<string, object>> row in result)
            {
                switch (row.Item1)
                {
                    case DatabaseResult.Ok:

                        //Create the user
                        User user = new User(row.Item2["Email"].ToString(), row.Item2["Password"].ToString())
                        {
                            Uuid = row.Item2["uuid"].ToString(),
                            FirstName = row.Item2["FirstName"].ToString(),
                            LastName = row.Item2["LastName"].ToString(),
                            DateOfBirth = (DateTime)row.Item2["DateOfBirth"],
                            IdCard = row.Item2["IDCardNumber"].ToString(),
                            ContactNumber = row.Item2["ContactNumber"].ToString(),
                            Nationality = row.Item2["Nationality"].ToString(),
                            Address = row.Item2["Address"].ToString(),
                            Gender = row.Item2["Gender"].ToString()[0],
                            Type = (UserType)row.Item2["Type"]
                        };

                        users.Add(user);
                        break;
                    default:
                        throw new Exception("An unknown error has occurred.");
                }
            }

            return users.ToArray();
        }
    }
}
