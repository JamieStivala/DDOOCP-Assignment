using Booking_System.backend.model.user;
using Booking_System.frontend.auth;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Booking_System.backend.database.hotel;
using Booking_System.backend.model.hotel;
using Booking_System.frontend.user.bookings;
using Booking_System.frontend.user.bookings.create;
using Booking_System.frontend.user.bookings.modify;

namespace Booking_System.frontend.user
{
    public partial class MainUserWindow : Form
    {
        private readonly User user;
        private readonly List<Booking> bookingsRequiringReview = new List<Booking>();
        public MainUserWindow(User user)
        {
            InitializeComponent();
            this.user = user;
            this.FindBookingsRequiringReviews();
            
        }

        private void FindBookingsRequiringReviews()
        {
            try
            {
                this.bookingsRequiringReview.Clear();
                buttonLeaveReview.Visible = false;

                //Get all the bookings
                Booking[] bookings = BookingWrapper.GetUserBookings(this.user.Uuid);
                if (bookings == null || bookings.Length == 0) return;

                //Filter out all the bookings that are past their checkout
                bookings = Array.FindAll(bookings, booking => !booking.IsBeforeCheckIn());
                if (bookings.Length <= 0) return;

                //Extract all the booking ID's and get their review
                int[] bookingIds = new int[bookings.Length];
                for (int i = 0; i != bookings.Length; i++) bookingIds[i] = bookings[i].Id;
                Review[] reviews = ReviewWrapper.GetBookingReviews(bookingIds);

                if (reviews == null) //If there are no reviews, add all the remaining bookings to the List of items requiring review
                {
                    this.bookingsRequiringReview.AddRange(bookings);
                    buttonLeaveReview.Visible = true; //Make the review button visible
                    return;
                }
                else if (reviews.Length == bookingIds.Length) //If there are reviews as much as there are bookings, it means all the reviews are there
                {
                    return;
                }
                else
                {
                    this.bookingsRequiringReview.AddRange(bookings); //Add all the bookings to be reviewed
                    foreach (Review review in reviews)
                    {
                        Booking bookingWithReview = Array.Find(bookings, booking => booking.Id == review.BookingId); //Search for the booking the review is related to
                        if (bookingWithReview != null) this.bookingsRequiringReview.Remove(bookingWithReview); //Remove that booking from the to be reviewed pool
                    }

                    if(this.bookingsRequiringReview.Count > 0) buttonLeaveReview.Visible = true; //Make the review button visible
                }
            }
            catch (Exception ex)
            {
                //Nothing to do here, just means no bookings/reviews were found.
            }
        }

        private void formLeaveReview_Closed(object sender, EventArgs e)
        {
            FindBookingsRequiringReviews();
        }

        private void SignoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainUserWindow_Load(object sender, EventArgs e)
        {

        }

        private void EditPersonalInformationButton_Click(object sender, EventArgs e)
        {
            EditPersonalInformation editPersonalInformation = new EditPersonalInformation(this.user);
            editPersonalInformation.Show();
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

        private void buttonLeaveReview_Click(object sender, EventArgs e)
        {
            LeaveReview leaveReview = new LeaveReview(this.bookingsRequiringReview.ToArray());
            leaveReview.Closed += formLeaveReview_Closed;
            leaveReview.Show();
        }
    }
}
