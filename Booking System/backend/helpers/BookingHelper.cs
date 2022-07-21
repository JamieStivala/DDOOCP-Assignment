using System;
using System.Linq;
using Booking_System.backend.database.hotel;
using Booking_System.backend.model.hotel;

namespace Booking_System.backend.helpers
{
    public class BookingHelper
    {

        /**
         * Checks if check-in and check-out fall between two existing dates
         */
        public static bool IsBetweenDates(DateTime existingCheckIn, DateTime existingCheckOut, DateTime newBookingCheckIn, DateTime newBookingCheckOut)
        {
            return (existingCheckIn <= newBookingCheckOut) && (existingCheckOut >= newBookingCheckIn);
        }

        /**
         * Checks if a room is available for a specified period
         *
         * excludeBookingId is used for when we are modifying a booking and want to exclude it from the check
         */
        public static bool IsRoomAvailable(Room room, DateTime newBookingCheckIn, DateTime newBookingCheckOut, int excludeBookingId=-1)
        {
            
            Booking[] currentBookings = BookingWrapper.GetRoomBookings(room.Id);
            if (currentBookings == null || currentBookings.Length == 0) //If the current bookings is null or there are no bookings 
            {
                return room.AmountOfRooms > 0; //return if there is at least on room available
            }

            int amountOfRoomsCurrentlyBooked = currentBookings.Count(existingBooking => existingBooking.Id != excludeBookingId && IsBetweenDates(existingBooking.CheckIn, existingBooking.CheckOut, newBookingCheckIn, newBookingCheckOut)); //Calculates how many rooms are booked in that timefrime
            return room.AmountOfRooms > amountOfRoomsCurrentlyBooked;
        }
    }
}
