using System;
using Booking_System.backend.model.hotel;

namespace Booking_System.backend.database.hotel
{
    public class ReviewWrapper
    {

        public static void CreateReview(Review review)
        {
            string query = "INSERT INTO tblReview (BookingId, RoomId, Title, [Description]) VALUES" +
                           $"({review.BookingId}, {review.RoomId}, {review.Title}, {review.Description})";

            (DatabaseResult, int) result = DatabaseWrapper.InsertIntoDatabaseReturningId(query);

            switch (result.Item1)
            {
                case DatabaseResult.Ok:
                    review.Id = result.Item2;
                    ReviewWrapper.AddToCache(review);
                    return;
                default:
                    throw new Exception("An unknown error has occurred.");
            }
        }

        public static Review[] GetBookingReviews(int[] bookingId)
        {
            return null;
        }

        public static Review[] GetRoomReviews(int roomId)
        {
            return null;
        }

        private static void AddToCache(Review review)
        {

        }
    }
}
