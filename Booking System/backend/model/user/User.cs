using System;

namespace Booking_System.backend.model.user
{
    public class User
    {
        private string password;

        /**
         * Assumes encrypted password
         */
        public User(string email, string password)
        {
            this.Email = email;
            this.password = password; //sets the password pre-encrypted
        }

        /**
         * Creates the instance needed for a User.  Assumes unencrypted password
         */
        public User(string name, string surname, string email, string password, string contactNumber, DateTime dateOfBirth, char gender, string idCard, string nationality, string address, UserType type)
        {
            this.FirstName = name;
            this.LastName = surname;
            this.Email = email;
            this.Password = password; //Encrypts the password
            this.ContactNumber = contactNumber;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.IdCard = idCard;
            this.Nationality = nationality;
            this.Address = address;
            this.Type = type;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        /**
         * Setter will instantly encrypt password
         */
        public string Password { get => password; set => password = EncryptPassword(value); }

        public string ContactNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        public char Gender { get; set; }

        public string IdCard { get; set; }

        public string Nationality { get; set; }

        public string Address { get; set; }

        public UserType Type { get; set; }


        /**
        * A simple algorithm to encrypt a user inputted password.  
        */
        public static string EncryptPassword(string inputtedPassword)
        {
            byte[] data = System.Text.Encoding.UTF8.GetBytes(inputtedPassword);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            return System.Convert.ToBase64String(data);
        }

        /**
         * Works by encrypting the user input and checking that encryptedInputtedPassword is equal to this.password
         */
        public Boolean VerifyPassword(string inputtedPassword)
        {
            byte[] data = System.Text.Encoding.UTF8.GetBytes(inputtedPassword); //Convert user input to Base64String
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            string encryptedInputtedPassword = System.Convert.ToBase64String(data);

            return encryptedInputtedPassword == this.Password;
        }
    }

    public enum UserType
    {
        Admin = 0,
        Customer = 1,
    }
}
