using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Booking_System.backend.database;
using Booking_System.backend.model.user;

namespace Booking_System.frontend.user
{
    public partial class EditPersonalInformation : Form
    {
        private readonly User user;
        public EditPersonalInformation(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void EditPersonalInformation_Load(object sender, EventArgs e)
        {
            textBoxName.Text = user.FirstName;
            textBoxSurname.Text = user.LastName;
            textBoxEmail.Text = user.Email;
            textBoxContactNumber.Text = user.ContactNumber;
            dateTimePickerDOB.Value = user.DateOfBirth;
            textBoxIdCard.Text = user.IdCard;

            string gender = "";
            switch (user.Gender)
            {   
                case 'M':
                    gender = "Male";
                    break;
                case 'F':
                    gender = "Female";
                    break;
                case 'O':
                    gender = "Other";
                    break;
            }

            comboBoxGender.Text = gender;
            textBoxNation.Text = user.Nationality;
            textBoxAddress.Text = user.Address;
        }

        private bool IsDataValid()
        {
            errorProvider.Clear();
            bool passed = true;

            //If the password is left empty, that means that no updating to the password is needed.
            Control[] itemsToValidateEmpty = GeneralValidation.IsEmpty(textBoxPassword.Text) ? 
                new Control[] { textBoxName, textBoxSurname, textBoxContactNumber, textBoxIdCard, comboBoxGender, textBoxNation, textBoxAddress } : 
                new Control[] { textBoxName, textBoxSurname, textBoxPassword, textBoxContactNumber, textBoxIdCard, comboBoxGender, textBoxNation, textBoxAddress };


            if (GeneralValidation.IsEmpty(itemsToValidateEmpty, errorProvider)) passed = false;

            if (!GeneralValidation.IsValidEmail(textBoxEmail, errorProvider)) passed = false; //Validate email
            if (!GeneralValidation.IsEmpty(textBoxPassword.Text) && !GeneralValidation.VerifyPasswordStrength(textBoxPassword, errorProvider)) passed = false; //If there is a password, validate new password strength

            //Validate the age >18
            DateTime today = DateTime.Today;
            int age = today.Year - dateTimePickerDOB.Value.Year;
            if (dateTimePickerDOB.Value.Date > today.AddYears(-age)) age--;

            if (age < 18)
            {
                errorProvider.SetError(dateTimePickerDOB, "Minimum age is 18.");
                passed = false;
            }
            //Validate the age >18

            return passed;
        }



        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!IsDataValid()) return; //Validate the data

            //Set the new user information
            this.user.FirstName = textBoxName.Text.Trim();
            this.user.LastName = textBoxSurname.Text.Trim();
            this.user.Email = textBoxEmail.Text.Trim();
            if(!GeneralValidation.IsEmpty(textBoxPassword.Text)) this.user.Password = textBoxPassword.Text.Trim();
            this.user.ContactNumber = textBoxContactNumber.Text.Trim();
            this.user.DateOfBirth = dateTimePickerDOB.Value;
            this.user.IdCard = textBoxIdCard.Text.Trim();
            this.user.Gender = comboBoxGender.Text[0];
            this.user.Nationality = textBoxNation.Text.Trim();
            this.user.Address = textBoxAddress.Text.Trim();
            //Set the new user information

            try
            {
                UserWrapper.UpdateUser(this.user);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
