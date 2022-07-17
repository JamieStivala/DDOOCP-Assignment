using Booking_System.backend.database;
using Booking_System.backend.model.user;
using Booking_System.frontend.user;
using System;
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

            if (age < 18)
            {
                errorProvider.SetError(dateTimePickerDOB, "Minimum age is 18.");
                passed = false;
            }
            //Validate the age >18

            return passed;
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            if (!IsDataValid()) return; //Validate the data

            User user = new User(textBoxName.Text.Trim(), textBoxSurname.Text.Trim(), textBoxEmail.Text.Trim(), textBoxPassword.Text.Trim(), textBoxContactNumber.Text.Trim(), dateTimePickerDOB.Value, comboBoxGender.Text[0], textBoxIdCard.Text.Trim(), textBoxNation.Text.Trim(), textBoxAddress.Text.Trim(), UserType.Customer); //Create the user instance
            try
            {
                UserWrapper.CreateUser(user);
                MainUserWindow mainUserWindow = new MainUserWindow(user);
                mainUserWindow.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSignin_Click(object sender, EventArgs e)
        {
            FormSignin formSignin = new FormSignin();
            formSignin.Show();
            this.Hide();
        }
    }
}
