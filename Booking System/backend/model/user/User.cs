using System;
using System.Collections.Generic;
using System.Text;

namespace Booking_System.backend.model.user
{
    public class User
    {
        private string firstName;
        private string lastName;
        private string email;
        private string password; //This is always the encrypted password
        private DateTime dateOfBirth;
        private string phoneNumber;
        private string idCard;

        /**
         * Creates the instance needed for a User.  Boolean encrypted checks if the password is encrypted or not and during instance create, if the password is "raw" the password is encrypted.
         */
        public User(string name, string surname, string email, string password, Boolean encrypted, DateTime dateOfBirth, string phoneNumber, string idCard)
        {
            this.FirstName = name;
            this.LastName = surname;
            this.Email = email;
            if (encrypted) this.Password = password;
            else this.Password = User.EncryptPassword(password);
            this.Password = password;
            this.DateOfBirth = dateOfBirth;
            this.PhoneNumber = phoneNumber;
            this.IdCard = idCard;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string IdCard { get => idCard; set => idCard = value; }

        /**
        * A simple algorithim to encrypt a user inputted password.  
        */
        public static string EncryptPassword(string inputtedPassword)
        {
            byte[] data = System.Text.Encoding.UTF8.GetBytes(inputtedPassword);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            return System.Text.Encoding.UTF8.GetString(data);
        }

        /**
         * Works by encrypting the user input and checking that encryptedInputtedPassword is equal to this.password
         */
        public Boolean ConfirmPassword(string inputtedPassword)
        {
            byte[] data = System.Text.Encoding.UTF8.GetBytes(inputtedPassword); //Convert user input to UTF8
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            string encryptedInputtedPassword = System.Text.Encoding.UTF8.GetString(data);

            return encryptedInputtedPassword == this.Password;
        }


    }
}
