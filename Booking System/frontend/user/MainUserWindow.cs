using Booking_System.backend.model.user;
using Booking_System.frontend.auth;
using System;
using System.Windows.Forms;
using Booking_System.frontend.user.bookings.create;
using Booking_System.frontend.user.bookings.modify;

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

        private void createBookingButton_Click(object sender, EventArgs e)
        {
            CreateBookingPage1 createBooking = new CreateBookingPage1(this.user);
            createBooking.Show();
        }

        private void viewBookingButton_Click(object sender, EventArgs e)
        {
            new ListBookings(this.user).Show();
        }
    }
}
