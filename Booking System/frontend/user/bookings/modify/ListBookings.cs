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
        private bool fromAdmin;

        public ListBookings(User user, bool fromAdmin=false)
        {
            InitializeComponent();
            this.user = user;
            this.fromAdmin = fromAdmin;
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

                    //Set the list of hotels
                    ListViewItem listViewItem = new ListViewItem(bookings[i].Id + "");
                    listViewItem.SubItems.Add(hotel.Name);
                    listViewItem.SubItems.Add(room.Name);
                    listViewItem.SubItems.Add(bookings[i].GetAmountOfNights() + "");
                    listViewItem.SubItems.Add($"£{bookings[i].Price}");

                    char editable = 'N';
                    if (bookings[i].IsBeforeCheckIn()) editable = 'Y';

                    listViewItem.SubItems.Add($"{editable}");
                    listViewBookings.Items.Add(listViewItem);
                    //Set the list of hotels
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
            Booking booking = this.GetSelectedBooking();
            if (booking == null) return;

            if (!booking.IsBeforeCheckIn() && !this.fromAdmin)
            {
                this.ShowError("Unable to delete a booking which is AFTER check-in date. Please contact an administrator.");
                return;
            }

            //Makes more sense like this since everything is in the cache already
            Room room = RoomWrapper.GetHotelRoom(booking.RoomId);
            Hotel hotel = HotelWrapper.GetHotel(room.HotelId);
            //Makes more sense like this since everything is in the cache already

            ModifyBooking viewBooking = new ModifyBooking(hotel, room, booking);
            viewBooking.Show();
            viewBooking.Closed += this.WindowBookingList_Close; //When the room is closed event is triggered, reload the booking list
        }


        private void buttonDeleteBooking_Click(object sender, EventArgs e)
        {
            Booking booking = this.GetSelectedBooking();
            if (booking == null) return;

            if (!booking.IsBeforeCheckIn() && !this.fromAdmin)
            {
                this.ShowError("Unable to delete a booking which is AFTER check-in date.  Please contact an administrator.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete this booking?",
                "Confirm booking delete", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return; //If no, stop action

            

            BookingWrapper.DeleteBooking(booking);
            this.LoadBookingList();
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void WindowBookingList_Close(object sender, EventArgs e)
        {
            this.LoadBookingList();
        }

    }
}
