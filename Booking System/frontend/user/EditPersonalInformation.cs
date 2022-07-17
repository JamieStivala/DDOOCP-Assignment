using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
