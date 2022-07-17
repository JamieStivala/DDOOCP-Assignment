using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Booking_System.backend.model.user;

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

        private void signoutButton_Click(object sender, EventArgs e)
        {
            new FormSignin().Show();
            this.Hide();
        }

        private void MainUserWindow_Load(object sender, EventArgs e)
        {

        }

        private void editPersonalInformationButton_Click(object sender, EventArgs e)
        {
            EditPersonalInformation editPersonalInformation = new EditPersonalInformation(this.user);
            editPersonalInformation.ShowDialog();
        }
    }
}
