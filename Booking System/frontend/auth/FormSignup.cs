using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            TextBox[] itemsToValidateEmpty = new TextBox[] { textBoxName, textBoxSurname, textBoxPassword, textBoxContactNumber, textBoxIdCard, textBoxGender, textBoxNation, textBoxAddress };
            if (GeneralValidation.IsEmpty(itemsToValidateEmpty, errorProvider)) passed = false;

            if (!GeneralValidation.IsValidEmail(textBoxEmail, errorProvider)) passed = false;
            if (!GeneralValidation.VerifyPasswordStrength(textBoxPassword, errorProvider)) passed = false;

            return passed;
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            //Validate the data
            if (!IsDataValid()) return;

            //Validate the data

        }
    }
}
