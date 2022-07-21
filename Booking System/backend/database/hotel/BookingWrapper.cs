using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Booking_System.backend.model.hotel;

namespace Booking_System.backend.database.hotel
{
    public class BookingWrapper
    {
        private static readonly List<Booking> Bookings = new List<Booking>();

        public static void CreateBooking(Booking booking)
        {
            string insertQuery = $"INSERT INTO tblBooking (RoomId, UserId, CheckIn, CheckOut, Price, NumberOfPeopleInRoom) VALUES" +
                                 $"({booking.RoomId}, '{booking.UserId}', {booking.CheckIn.ToOADate()}, {booking.CheckOut.ToOADate()}, {booking.Price}, {booking.NumberOfPeople})";

            (DatabaseResult, int) result = DatabaseWrapper.InsertIntoDatabaseReturningId(insertQuery);

            switch (result.Item1)
            {
                case DatabaseResult.Ok:
                    booking.Id = result.Item2;
                    BookingWrapper.AddToCache(booking);
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

                        Booking booking = BookingWrapper.Bookings.Find(currentItem => currentItem.Id == currentId);
                        if (booking == null) //If booking is not found, create the booking instance and add the booking to the wrapper
                        {
                            booking = new Booking(currentId);
                            BookingWrapper.Bookings.Add(booking);
                        }

                        //Copy everything from the database to the new/found booking object (basically updating the cache since the query was done anyways)
                        booking.RoomId = (int)row.Item2["RoomId"];
                        booking.UserId = row.Item2["UserId"].ToString();
                        booking.CheckIn = (DateTime)row.Item2["CheckIn"];
                        booking.CheckOut = (DateTime)row.Item2["CheckOut"];
                        booking.Price = (int)row.Item2["Price"];
                        booking.NumberOfPeople = (int)row.Item2["NumberOfPeopleInRoom"];
                        break;
                    case DatabaseResult.NotFound:
                        return; //This is not an error, it just means that the user does not have any bookings
                    default:
                        throw new Exception("An unknown error has occurred.");
                }
            }
        }

        public static Booking[] GetUserBookings(string userId)
        {
            string query = $"SELECT * FROM tblBooking WHERE UserId='{userId}'";
            Tuple<DatabaseResult, Dictionary<string, object>>[] result = DatabaseWrapper.GetFromDatabase(query);
            BookingWrapper.UpdateCacheFromQuery(result);
            return BookingWrapper.Bookings.FindAll(item => item.UserId == userId).ToArray();
        }


        public static Booking[] GetRoomBookings(int roomId)
        {
            string query = $"SELECT * FROM tblBooking WHERE RoomId={roomId}";
            Tuple<DatabaseResult, Dictionary<string, object>>[] result = DatabaseWrapper.GetFromDatabase(query);
            BookingWrapper.UpdateCacheFromQuery(result);
            return BookingWrapper.Bookings.FindAll(item => item.RoomId == roomId).ToArray();
        }

        public static void UpdateBooking(Booking booking)
        {
            //Just in case the object was copied and not referenced, copy the current instance onto the new instance
            Booking cachedBooking = BookingWrapper.Bookings.Find(val => val.Id == booking.Id);
            if (cachedBooking == null) throw new Exception("A booking with that internal ID can't be found");

            cachedBooking.UserId = booking.UserId;
            cachedBooking.RoomId = booking.RoomId;
            cachedBooking.CheckIn = booking.CheckIn;
            cachedBooking.CheckOut = booking.CheckOut;
            cachedBooking.Price = booking.Price;
            cachedBooking.NumberOfPeople = booking.NumberOfPeople;
            //Just in case the object was copied and not referenced, copy the current instance onto the new instance

            string updateQuery = $"UPDATE tblBooking SET " +
                                 $" RoomId={booking.RoomId}, UserId='{booking.UserId}'," +
                                 $" CheckIn={booking.CheckIn.ToOADate()}, CheckOut={booking.CheckOut.ToOADate()}, " +
                                 $" Price={booking.Price}, NumberOfPeople={booking.NumberOfPeople}" +
                                 $"WHERE ID={booking.Id}";

            DatabaseResult result = DatabaseWrapper.UpdateFromDatabase(updateQuery);

            //Switch the result based on the ENUM representing result
            switch (result)
            {
                case DatabaseResult.Ok:
                    return;
                case DatabaseResult.NotFound:
                    throw new Exception("A booking with that internal ID can't be found.");
                default:
                    throw new Exception("An unknown error has occurred.");
            }
             
        }

        public static void DeleteBooking(Booking booking)
        {
            string query = $"DELETE * FROM tblBooking WHERE ID={booking.Id}";
            DatabaseResult result = DatabaseWrapper.DeleteFromDatabase(query);

            //Switch the result based on the ENUM representing result
            switch (result)
            {
                case DatabaseResult.Ok:
                    BookingWrapper.Bookings.Remove(booking); //Remove the booking from the cache
                    return;
                default:
                    throw new Exception("An unknown error has occurred.");
            }
        }

        private static void AddToCache(Booking booking)
        {
            BookingWrapper.Bookings.Add(booking);
        }
    }
}
