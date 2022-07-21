using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Booking_System.backend.database.hotel;
using Booking_System.backend.model.hotel;
using Booking_System.backend.model.user;

namespace Booking_System.frontend.user.bookings.modify
{
    public partial class ListBookings : Form
    {
        private Booking[] bookings;
        private User user;

        public ListBookings(User user)
        {
            InitializeComponent();
            this.user = user;
            LoadBookingList();
        }

        private void LoadBookingList()
        {

            try
            {
                listViewBookings.Items.Clear();

                this.bookings = BookingWrapper.GetUserBookings(user.Uuid);

                for (int i = 0; i != bookings.Length; i++)
                {
                    Room room = RoomWrapper.GetHotelRoom(bookings[i].RoomId);
                    Hotel hotel = HotelWrapper.GetHotel(room.HotelId);
                    Debug.WriteLine(hotel.Name);

                    ListViewItem listViewItem = new ListViewItem(bookings[i].Id + "");
                    listViewItem.SubItems.Add(hotel.Name);
                    listViewItem.SubItems.Add(room.Name);
                    listViewItem.SubItems.Add(bookings[i].GetAmountOfNights() + "");
                    listViewItem.SubItems.Add($"£{bookings[i].Price}");
                    listViewBookings.Items.Add(listViewItem);
                }
            }
            catch (Exception ex)
            {
                this.ShowError("You have not yet made any bookings.  To be able to modify or delete a booking please first book a room.");
            }
        }

        private Booking GetSelectedBooking()
        {
            if (listViewBookings.SelectedItems.Count != 1)
            {
                this.ShowError("Please select a booking.");
                return null;
            }

            int bookingId = int.Parse(listViewBookings.SelectedItems[0].Text);
            return this.bookings.Single(value => value.Id == bookingId); //Get the booking
        }

        private void buttonViewBooking_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteBooking_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete this booking?",
                "Confirm booking delete", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return; //If no, stop action

            Booking booking = this.GetSelectedBooking();
            if (booking == null) return;

            BookingWrapper.DeleteBooking(booking);
            this.LoadBookingList();
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
