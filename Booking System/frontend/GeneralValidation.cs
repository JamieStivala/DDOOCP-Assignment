using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Booking_System.frontend
{
    internal class GeneralValidation
    {
        /**
         * It's best to use the built-in email validation since it always follows ISO Standards (https://docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format?redirectedfrom=MSDN)
         */
        public static Boolean VerifyEmail(string inputtedEmail)
        {

            try
            {
                MailAddress m = new MailAddress(inputtedEmail);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        /**
         * A standard Regex (https://stackoverflow.com/questions/23699919/regular-expression-for-password-complexity) that requires one digit, one lower case character, one uppercase character, a special symbol and a minimum length of 8 characters and a maximum length of 40 characters
         */
        public static Boolean VerifyPasswordStrength(string inputtedPassword)
        {
            return Regex.IsMatch(inputtedPassword, @"((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{8,40})");
        }
    }
}
