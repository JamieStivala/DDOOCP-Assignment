using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Booking_System.backend.model.user;
using Booking_System.frontend.auth;

namespace Booking_System.frontend.user
{
    public partial class MainUserWindow : Form
    {
        private readonly User user;
        public MainUserWindow(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void SignoutButton_Click(object sender, EventArgs e)
        {
            new FormSignin().Show();
            this.Hide();
        }

        private void MainUserWindow_Load(object sender, EventArgs e)
        {

        }

        private void EditPersonalInformationButton_Click(object sender, EventArgs e)
        {
            EditPersonalInformation editPersonalInformation = new EditPersonalInformation(this.user);
            editPersonalInformation.ShowDialog();
        }
    }
}
