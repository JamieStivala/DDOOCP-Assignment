using System;
using System.Diagnostics;
using System.Windows.Forms;
using Booking_System.backend.model.hotel;
using Booking_System.backend.model.user;

namespace Booking_System.frontend.user.bookings.create
{
    public partial class CreateBookingPage2 : Form
    {
        private Hotel hotel;
        private Room room;
        private User user;
        public CreateBookingPage2(User user, Hotel hotel, Room room)
        {
            InitializeComponent();
            this.hotel = hotel;
            this.room = room;
            this.user = user;

            labelPricePerNightValue.Text = $"£{this.room.Price}";
        }

        private int CalculateAmountOfNights()
        {
            return (dateTimePickerCheckOutDay.Value.Date - dateTimePickerCheckInDay.Value.Date).Days;
        }

        private bool ValidateDates()
        {
            errorProvider.Clear();
            int daysFromTodayTillCheckIn = (dateTimePickerCheckInDay.Value.Date - DateTime.Today).Days;
            if (daysFromTodayTillCheckIn < 0)
            {
                errorProvider.SetError(dateTimePickerCheckInDay, "Check-In Date can't be before today.");
                return false;
            }
            else if (CalculateAmountOfNights() <= 0)
            {
                errorProvider.SetError(dateTimePickerCheckInDay, "Check-In Date can't be before Check-out Date.");
                return false;
            }

            return true;
        }

        private void UpdatePriceBreakdown()
        {
            
            if(!this.ValidateDates()) return;

            labelAmountOfNightsValue.Text = this.CalculateAmountOfNights() + "";
            labelTotalPriceValue.Text = $"£{this.CalculateAmountOfNights() * this.room.Price}";

        }
        private void dateTimePickerCheckInDate_ValueChanged(object sender, EventArgs e)
        {
            this.UpdatePriceBreakdown();
        }

        private void dateTimePickerCheckOutDay_ValueChanged(object sender, EventArgs e)
        {
            this.UpdatePriceBreakdown();
        }
    }
}
