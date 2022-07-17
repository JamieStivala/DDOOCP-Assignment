namespace Booking_System.backend.model.hotel
{
    public class Room
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public double Price { get; set; }
        public int AmountOfRooms { get; set; }
    }
}
