namespace Booking_System.backend.model.hotel
{
    public class Room
    {

        public Room(int id)
        {
            this.Id = id;
        }

        public Room(int hotelId, string name, string description, int capacity, double price, int amountOfRooms)
        {
            HotelId = hotelId;
            Name = name;
            Description = description;
            Capacity = capacity;
            Price = price;
            AmountOfRooms = amountOfRooms;
        }

        public int Id { get; set; }
        public int HotelId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public double Price { get; set; }
        public int AmountOfRooms { get; set; }
    }
}
