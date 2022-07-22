namespace Booking_System.backend.model.hotel
{
    public class Review
    {
        public Review(int id)
        {
            Id = id;
        }

        public Review(int roomId, int bookingId, string title, string description)
        {
            RoomId = roomId;
            BookingId = bookingId;
            Title = title;
            Description = description;
        }

        public int Id { get; set; }
        public int BookingId { get; set; }
        public int RoomId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
