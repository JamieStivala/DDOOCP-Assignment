using Booking_System.backend.database;
using Booking_System.backend.model.user;
using Booking_System.frontend.user;
using System;
using System.Windows.Forms;

namespace Booking_System.frontend.auth
{
    public partial class FormSignin : Form
    {
        public FormSignin()
        {
            InitializeComponent();
        }

        private bool IsDataValid()
        {
            errorProvider.Clear();
            bool passed = true;

            Control[] itemsToValidateEmpty = new Control[] { emailTextBox, passwordTextBox };
            if (GeneralValidation.IsEmpty(itemsToValidateEmpty, errorProvider)) passed = false;

            return passed;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!IsDataValid()) return;

            try
            {
                User user = UserWrapper.GetUser(emailTextBox.Text.Trim(), passwordTextBox.Text.Trim());
                MainUserWindow mainUserWindow = new MainUserWindow(user);
                mainUserWindow.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Show login error
            }
        }

        private void ButtonSignup_Click(object sender, EventArgs e)
        {
            FormSignup formSignup = new FormSignup();
            formSignup.Show();
            this.Hide();
        }
    }
}
