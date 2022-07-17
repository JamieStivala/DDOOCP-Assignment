using Booking_System.frontend.auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Booking_System.backend.database;
using Booking_System.backend.model.user;
using Booking_System.frontend;
using Booking_System.frontend.user;

namespace Booking_System
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

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(!IsDataValid()) return;

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

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            FormSignup formSignup = new FormSignup();
            formSignup.Show();
            this.Hide();
        }
    }
}
