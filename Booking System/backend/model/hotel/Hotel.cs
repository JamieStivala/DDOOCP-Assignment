using System;

namespace Booking_System.backend.model.hotel
{
    public class Hotel
    {
        public Hotel(int id)
        {
            Id = id;
        }

        public Hotel(string name, string location, DateTime defaultCheckInTime, DateTime defaultCheckOutTime)
        {
            Name = name;
            Location = location;
            DefaultCheckInTime = defaultCheckInTime;
            DefaultCheckOutTime = defaultCheckOutTime;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime DefaultCheckInTime { get; set; }
        public DateTime DefaultCheckOutTime { get; set; }
    }
}
