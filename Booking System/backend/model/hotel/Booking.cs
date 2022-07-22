using System;

namespace Booking_System.backend.model.hotel
{
    public class Booking
    {
        public Booking(int id)
        {
            Id = id;
        }

        public Booking(int roomId, string userId, DateTime checkIn, DateTime checkOut, double price, int numberOfPeople)
        {
            RoomId = roomId;
            UserId = userId;
            CheckIn = checkIn;
            CheckOut = checkOut;
            Price = price;
            NumberOfPeople = numberOfPeople;
        }

        public int Id { get; set; }
        public int RoomId { get; set; }
        public string UserId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public double Price { get; set; }
        public int NumberOfPeople { get; set; }

        public int GetAmountOfNights()
        {
            return (this.CheckOut.Date - this.CheckIn.Date).Days;
        }

        public bool IsBeforeCheckIn()
        {
            return DateTime.Today < this.CheckIn;
        }

        public static int CalculateAmountOfNights(DateTime checkIn, DateTime checkOut)
        {
            return (checkOut.Date - checkIn.Date).Days;
        }

    }
}
