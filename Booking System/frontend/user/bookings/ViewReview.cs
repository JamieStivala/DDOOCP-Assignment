using Booking_System.backend.model.hotel;
using System;
using System.Windows.Forms;

namespace Booking_System.frontend.user.bookings
{
    public partial class ViewReview : Form
    {
        private Review[] reviews;
        public ViewReview(Review[] reviews, int startingIndex)
        {
            InitializeComponent();
            this.reviews = reviews;
            this.UpdateReviewText(startingIndex);
        }

        private void UpdateReviewText(int index)
        {
            if (this.reviews == null || this.reviews.Length == 0)
            {
                this.labelTitleValue.Text = "No reviews yet.";
                this.richTextBoxDescription.Text = "No reviews yet";
            }
            else
            {
                this.labelTitleValue.Text = reviews[index].Title;
                this.richTextBoxDescription.Text = reviews[index].Description;
            }

        }

        private void buttonNextReview_Click(object sender, EventArgs e)
        {
            if (this.reviews == null || this.reviews.Length == 0) return;
            this.UpdateReviewText(new Random().Next(0, this.reviews.Length));
        }
    }
}
