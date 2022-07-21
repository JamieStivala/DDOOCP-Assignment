using System;
using System.Collections.Generic;
using System.Linq;
using Booking_System.backend.model.hotel;

namespace Booking_System.backend.database.hotel
{
    public class ReviewWrapper
    {
        private static readonly List<Review> ReviewList = new List<Review>();

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

        private static void UpdateCacheFromQuery(Tuple<DatabaseResult, Dictionary<string, object>>[] databaseResult)
        {
            foreach (Tuple<DatabaseResult, Dictionary<string, object>> row in databaseResult)
            {
                switch (row.Item1)
                {
                    case DatabaseResult.Ok:
                        int currentId = (int)row.Item2["ID"];

                        Review review = GetFromCache(currentId);
                        if (review == null) //If booking is not found, create the booking instance and add the booking to the wrapper
                        {
                            review = new Review(currentId);
                            ReviewWrapper.AddToCache(review);
                        }

                        //Copy everything from the database to the new/found booking object (basically updating the cache since the query was done anyways)
                        review.RoomId = (int)row.Item2["RoomId"];
                        review.BookingId = (int)row.Item2["BookingId"];
                        review.Title = row.Item2["Title"].ToString();
                        review.Description = row.Item2["Description"].ToString();
                        break;
                    case DatabaseResult.NotFound:
                        return; //This is not an error, it just means that the user does not have any bookings to review/there are no bookings
                    default:
                        throw new Exception("An unknown error has occurred.");
                }
            }
        }

        public static Review[] GetBookingReviews(int[] bookingIds)
        {
            //Build a string which is able to get multiple reviews based on multiple BookingIds using WHERE (BookingId=something OR ...)
            string builtQuery = bookingIds.Aggregate("", (current, bookingId) => current + $"BookingId={bookingId} OR");
            builtQuery = builtQuery.Substring(builtQuery.Length - 3); //Remove the last OR 


            string query = $"SELECT * FROM tblReview WHERE ({builtQuery})";
            Tuple<DatabaseResult, Dictionary<string, object>>[] result = DatabaseWrapper.GetFromDatabase(query);
            ReviewWrapper.UpdateCacheFromQuery(result);

            //Get a unique list of reviews 
            HashSet<Review> foundReviews = new HashSet<Review>();
            foreach (int bookingId in bookingIds)
            {
                foreach (Review review in ReviewList.FindAll(item => item.BookingId == bookingId).ToArray())
                {
                    foundReviews.Add(review);
                }
            }
            //Get a unique list of reviews

            return foundReviews.ToArray();
        }

        public static Review[] GetRoomReviews(int roomId)
        {
            string query = $"SELECT * FROM tblReview WHERE (RoomId={roomId})";
            Tuple<DatabaseResult, Dictionary<string, object>>[] result = DatabaseWrapper.GetFromDatabase(query);
            ReviewWrapper.UpdateCacheFromQuery(result);

            return ReviewList.FindAll(item => item.RoomId == roomId).ToArray();
        }

        private static Review GetFromCache(int reviewId)
        {
            return ReviewWrapper.ReviewList.Find(currentItem => currentItem.Id == reviewId);
        }

        private static void AddToCache(Review review)
        {
            if(GetFromCache(review.Id) == null) ReviewList.Add(review);
        }
    }
}
