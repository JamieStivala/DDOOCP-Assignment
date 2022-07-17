using System;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Booking_System.frontend
{
    internal class GeneralValidation
    {
        #region Is Empty
        public static Boolean IsEmpty(string input)
        {
            return String.IsNullOrEmpty(input);
        }

        private static Boolean IsEmpty(Control item)
        {
            return IsEmpty(item.Text);
        }

        public static Boolean IsEmpty(Control[] item, ErrorProvider errorProvider)
        {
            bool passed = true;
            for (int i = 0; i != item.Length; i++)
            {
                if (IsEmpty(item[i]))
                {
                    passed = false;
                    errorProvider.SetError(item[i], "Field can't be empty");
                }
            }

            return !passed;
        }
        #endregion

        #region Is Valid Email
        /**
         * It's best to use the built-in email validation since it always follows ISO Standards (https://docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format?redirectedfrom=MSDN)
         */
        public static Boolean IsValidEmail(string inputtedEmail)
        {
            if(GeneralValidation.IsEmpty(inputtedEmail)) return false;
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

        public static Boolean IsValidEmail(Control inputtedEmail, ErrorProvider errorProvider)
        {
            if (!GeneralValidation.IsValidEmail(inputtedEmail.Text))
            {
                errorProvider.SetError(inputtedEmail, "Invalid email format provided");
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region Verify Password Strength
        /**
         * A standard Regex (https://stackoverflow.com/questions/23699919/regular-expression-for-password-complexity) that requires one digit, one lower case character, one uppercase character, a special symbol and a minimum length of 8 characters and a maximum length of 40 characters
         */
        public static Boolean VerifyPasswordStrength(string inputtedPassword)
        {
            if(IsEmpty(inputtedPassword)) return false;
            return Regex.IsMatch(inputtedPassword, @"((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%!]).{8,40})");
        }

        public static Boolean VerifyPasswordStrength(Control inputtedPassword, ErrorProvider errorProvider)
        {
            if (!GeneralValidation.VerifyPasswordStrength(inputtedPassword.Text))
            {
                errorProvider.SetError(inputtedPassword, "Password is not strong enough.  The password needs to have at least 1 digit, 1 lowercase and 1 uppercase charater and 1 special symbol.  The password can't be longer than 40 characters or shorter than 8 characters.");
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion
    }
}
