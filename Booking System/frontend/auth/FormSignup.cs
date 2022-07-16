using Booking_System.backend.database;
using Booking_System.backend.model.user;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Booking_System.frontend.auth
{
    public partial class FormSignup : Form
    {
        public FormSignup()
        {
            InitializeComponent();
        }

        private void FormSignup_Load(object sender, EventArgs e)
        {

        }


        private bool IsDataValid()
        {
            errorProvider.Clear();
            bool passed = true;

            Control[] itemsToValidateEmpty = new Control[] { textBoxName, textBoxSurname, textBoxPassword, textBoxContactNumber, textBoxIdCard, comboBoxGender, textBoxNation, textBoxAddress };
            if (GeneralValidation.IsEmpty(itemsToValidateEmpty, errorProvider)) passed = false;

            if (!GeneralValidation.IsValidEmail(textBoxEmail, errorProvider)) passed = false;
            if (!GeneralValidation.VerifyPasswordStrength(textBoxPassword, errorProvider)) passed = false;

            //Validate the age >18
            DateTime today = DateTime.Today;
            int age = today.Year - dateTimePickerDOB.Value.Year;
            if (dateTimePickerDOB.Value.Date > today.AddYears(-age)) age--;

            if(age < 18)
            {
                errorProvider.SetError(dateTimePickerDOB, "Minimum age is 18.");
                passed = false;
            }
            //Validate the age >18

            return passed;
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            if (!IsDataValid()) return; //Validate the data

            User user = new User(textBoxName.Text, textBoxSurname.Text, textBoxEmail.Text, textBoxPassword.Text, false, textBoxContactNumber.Text, dateTimePickerDOB.Value, comboBoxGender.Text[0], textBoxIdCard.Text, textBoxNation.Text, textBoxAddress.Text, UserType.CUSTOMER); //Create the user instance
            string result = UserWrapper.CreateUser(user);
            if (result != null) MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //If the result is null -> no error
        }

        private void buttonSignin_Click(object sender, EventArgs e)
        {
            FormSignin formSignin = new FormSignin();
            formSignin.Show();
            this.Hide();
        }
    }
}
