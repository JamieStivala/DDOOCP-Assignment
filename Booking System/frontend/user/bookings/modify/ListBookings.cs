using System;
using System.Diagnostics;
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

        private void buttonViewBooking_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteBooking_Click(object sender, EventArgs e)
        {

        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
