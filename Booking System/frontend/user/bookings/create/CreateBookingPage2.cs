using Booking_System.backend.database.hotel;
using Booking_System.backend.helpers;
using Booking_System.backend.model.hotel;
using Booking_System.backend.model.user;
using System;
using System.Windows.Forms;

namespace Booking_System.frontend.user.bookings.create
{
    public partial class CreateBookingPage2 : Form
    {
        private readonly Hotel hotel;
        private readonly Room room;
        private readonly User user;
        public CreateBookingPage2(User user, Hotel hotel, Room room)
        {
            InitializeComponent();
            this.hotel = hotel;
            this.room = room;
            this.user = user;

            labelPricePerNightValue.Text = $"£{this.room.Price}";
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
            else if (Booking.CalculateAmountOfNights(dateTimePickerCheckInDay.Value, dateTimePickerCheckOutDay.Value) <= 0)
            {
                errorProvider.SetError(dateTimePickerCheckInDay, "Check-In Date can't be before Check-out Date.");
                return false;
            }

            return true;
        }

        private void UpdatePriceBreakdown()
        {

            if (!this.ValidateDates()) return;
            int amountOfNights = Booking.CalculateAmountOfNights(dateTimePickerCheckInDay.Value, dateTimePickerCheckOutDay.Value);
            labelAmountOfNightsValue.Text = amountOfNights + "";
            labelTotalPriceValue.Text = $"£{amountOfNights * this.room.Price}";

        }
        private void dateTimePickerCheckInDate_ValueChanged(object sender, EventArgs e)
        {
            this.UpdatePriceBreakdown();
        }

        private void dateTimePickerCheckOutDay_ValueChanged(object sender, EventArgs e)
        {
            this.UpdatePriceBreakdown();
        }

        private void buttonBookNow_Click(object sender, EventArgs e)
        {
            if (!this.ValidateDates()) return;

            //Set the time of the check-in and check-out days
            DateTime checkInDate = dateTimePickerCheckInDay.Value;
            TimeSpan checkInTimeSpan = new TimeSpan(this.hotel.DefaultCheckInTime.Hour,
                this.hotel.DefaultCheckInTime.Minute, this.hotel.DefaultCheckInTime.Second);
            checkInDate += checkInTimeSpan;

            DateTime checkOutDate = dateTimePickerCheckOutDay.Value;
            TimeSpan checkOutTimeSpan = new TimeSpan(this.hotel.DefaultCheckOutTime.Hour,
                this.hotel.DefaultCheckOutTime.Minute, this.hotel.DefaultCheckOutTime.Second);
            checkOutDate += checkOutTimeSpan;
            //Set the time of the check-in and check-out days

            if (!BookingHelper.IsRoomAvailable(this.room, checkInDate, checkOutDate))
            {
                MessageBox.Show("Unfortunately the room is not available on the dates you picked.  Please pick another date or contact an administrator to help you.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Booking booking = new Booking(this.room.Id, this.user.Uuid, checkInDate, checkOutDate,
                    (Booking.CalculateAmountOfNights(dateTimePickerCheckInDay.Value, dateTimePickerCheckOutDay.Value) * this.room.Price), this.room.Capacity);

                try
                {
                    BookingWrapper.CreateBooking(booking);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
    }
}
