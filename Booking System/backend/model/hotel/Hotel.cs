using System;

namespace Booking_System.backend.model.hotel
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime DefaultCheckInTime { get; set; }
        public DateTime DefaultCheckOutTime { get; set; }
    }
}
