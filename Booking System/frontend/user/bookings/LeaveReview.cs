using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Booking_System.backend.database.hotel;
using Booking_System.backend.model.hotel;

namespace Booking_System.frontend.user.bookings
{
    public partial class LeaveReview : Form
    {
        private readonly Booking[] bookingsPendingReview;
        private Dictionary<int, Tuple<Booking, Room>> indexedRoomBookings;

        public LeaveReview(Booking[] bookingsPendingReview)
        {
            InitializeComponent();
            this.indexedRoomBookings = new Dictionary<int, Tuple<Booking, Room>>();
            this.bookingsPendingReview = bookingsPendingReview;

            this.FillBookingsMenu();
            comboBoxBookings.SelectedIndex = 0;
        }

        private void FillBookingsMenu()
        {
            try
            {
                for (int i = 0; i != bookingsPendingReview.Length; i++)
                {
                    Booking booking = bookingsPendingReview[i];
                    Room room = RoomWrapper.GetHotelRoom(booking.RoomId);
                    comboBoxBookings.Items.Add(
                        $"Room: {room.Name} - From {booking.CheckIn.ToShortDateString()} till {booking.CheckOut.ToShortDateString()} - Price:£{booking.Price}");
                    this.indexedRoomBookings.Add(i, new Tuple<Booking, Room>(booking, room));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsDataValid()
        {
            errorProvider.Clear();

            Control[] itemsToValidateEmpty = new Control[] { textBoxReviewTitle, richTextBoxReviewDescription};
            return !GeneralValidation.IsEmpty(itemsToValidateEmpty, errorProvider);
        }

        private void buttonSaveReview_Click(object sender, EventArgs e)
        {
            if(!this.IsDataValid()) return;

            try
            {
                Tuple<Booking, Room> currentItem = this.indexedRoomBookings[comboBoxBookings.SelectedIndex];

                Review review = new Review(currentItem.Item2.Id, currentItem.Item1.Id, textBoxReviewTitle.Text,
                    richTextBoxReviewDescription.Text.Replace("'", " ")); //Replace ' with spaces to prevent SQL Injection
                ReviewWrapper.CreateReview(review);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
