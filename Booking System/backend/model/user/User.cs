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
        private string contactNumber;
        private DateTime dateOfBirth;
        private char gender;
        private string idCard;
        private string nationality;
        private string address;
        private UserType type;

        /**
         * Creates the instance needed for a User.  Boolean encrypted checks if the password is encrypted or not and during instance create, if the password is "raw" the password is encrypted.
         */
        public User(string name, string surname, string email, string password, Boolean encrypted, string contactNumber, DateTime dateOfBirth, char gender, string idCard, string nationality, string address, UserType type)
        {
            this.FirstName = name;
            this.LastName = surname;
            this.Email = email;
            if (encrypted) this.Password = password;
            else this.Password = User.EncryptPassword(password);
            this.Password = password;
            this.ContactNumber = contactNumber;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.IdCard = idCard;
            this.Nationality = nationality;
            this.Address = address;
            this.Type = type;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public char Gender { get => gender; set => gender = value; }
        public string IdCard { get => idCard; set => idCard = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public string Address { get => address; set => address = value; }
        public UserType Type { get => type; set => type = value; }



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

    public enum UserType
    {
        ADMIN = 0,
        CUSTOMER = 1,
    }
}
