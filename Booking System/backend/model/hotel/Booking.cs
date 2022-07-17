using System;

namespace Booking_System.backend.model.hotel
{
    public class Booking
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public string UserId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public double Price { get; set; }
        public int NumberOfPeople { get; set; }
    }
}
