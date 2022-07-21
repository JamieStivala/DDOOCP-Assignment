using System;
using System.Windows.Forms;
using Booking_System.backend.database.hotel;
using Booking_System.backend.helpers;
using Booking_System.backend.model.hotel;

namespace Booking_System.frontend.user.bookings
{
    public partial class ModifyBooking : Form
    {
        private readonly Hotel hotel;
        private readonly Room room;
        private readonly Booking booking;
        public ModifyBooking(Hotel hotel, Room room, Booking booking)
        {
            InitializeComponent();
            this.booking = booking;
            this.room = room;
            this.hotel = hotel;

            labelMaxAmountOfPeopleValue.Text = room.Capacity + "";
            labelCheckInTimeValue.Text = hotel.DefaultCheckInTime.ToShortTimeString();
            labelCheckOutTimeValue.Text = hotel.DefaultCheckOutTime.ToShortTimeString();
            richTextBoxRoomDescription.Text = room.Description;
            labelPricePerNightValue.Text = $"£{room.Price}";

            dateTimePickerCheckInDay.Value = this.booking.CheckIn;
            dateTimePickerCheckOutDay.Value = this.booking.CheckOut;

            
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
            var amountOfNights =
                Booking.CalculateAmountOfNights(dateTimePickerCheckInDay.Value, dateTimePickerCheckOutDay.Value);
            labelAmountOfNightsValue.Text = amountOfNights + "";
            labelTotalPriceValue.Text = $"£{amountOfNights * this.room.Price}";
        }


        private void dateTimePickerCheckInDay_ValueChanged(object sender, EventArgs e)
        {
            this.UpdatePriceBreakdown();
        }

        private void dateTimePickerCheckOutDay_ValueChanged(object sender, EventArgs e)
        {
            this.UpdatePriceBreakdown();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonSaveModifiedBooking_Click(object sender, EventArgs e)
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

            if (!BookingHelper.IsRoomAvailable(this.room, checkInDate, checkOutDate, this.booking.Id))
            {
                MessageBox.Show("Unfortunately the room is not available on the dates you picked.  Please pick another date or contact an administrator to help you.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.booking.CheckIn = checkInDate;
                this.booking.CheckOut = checkOutDate;

                try
                {
                    BookingWrapper.UpdateBooking(booking);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.Hide();
                }

            }
        }
    }
}
