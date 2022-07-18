using System;
using System.Collections.Generic;
using System.Diagnostics;
using Booking_System.backend.model.hotel;

namespace Booking_System.backend.database.hotel
{
    public class RoomWrapper
    {
        private static readonly Dictionary<int, List<Room>> RoomCache = new Dictionary<int, List<Room>>();  //Hotel --> Room
        public static void CreateRoom(Room room)
        {
            string insertQuery = $"INSERT INTO tblRoom (HotelId, [Name], Description, Capacity, Price, AmountOfRooms) VALUES" +
                                 $"('{room.HotelId}', '{room.Name}', '{room.Description}', {room.Capacity}, {room.Price}, {room.AmountOfRooms})";

            (DatabaseResult, int) result = DatabaseWrapper.InsertIntoDatabaseReturningId(insertQuery);

            switch (result.Item1)
            {
                case DatabaseResult.Ok:
                    room.Id = result.Item2;
                    RoomWrapper.AddToCache(room);
                    return;
                default:
                    throw new Exception("An unknown error has occurred.");
            }
        }

        public static void UpdateRoom(Room room)
        {
            
        }

        public static Room[] GetHotelRooms(int hotelId)
        {
            //Check if the item is in the cache, if it is, return it
            if(RoomWrapper.RoomCache.ContainsKey(hotelId)) return RoomWrapper.RoomCache[hotelId].ToArray();

            string query = $"SELECT * FROM tblRoom WHERE HotelId={hotelId}";
            Tuple<DatabaseResult, Dictionary<string, object>>[] result = DatabaseWrapper.GetFromDatabase(query);

            foreach (var dbRoom in result)
            {
                switch (dbRoom.Item1)
                {
                    case DatabaseResult.Ok:
                        Room room = new Room((int)dbRoom.Item2["ID"])
                        {
                            HotelId = (int)dbRoom.Item2["HotelId"],
                            Name = dbRoom.Item2["Name"].ToString(),
                            Description = dbRoom.Item2["Description"].ToString(),
                            Capacity = (int)dbRoom.Item2["Capacity"],
                            Price = (double)dbRoom.Item2["Price"],
                            AmountOfRooms = (int)dbRoom.Item2["AmountOfRooms"],
                        };
                        RoomWrapper.AddToCache(room); //Add the room to the cache
                        break;
                    case DatabaseResult.NotFound:
                        throw new Exception("The hotel does not have any rooms.  Please add rooms that are relevant to the hotel.");
                    default:
                        throw new Exception("An unknown error has occurred.");
                }
            }

            return GetHotelRooms(hotelId); //Since now all the rooms have been cached, recall method and return result from cache
        }

        /**
         * Ability to add one room to the cache, organized by hotel id
         */
        private static void AddToCache(Room room)
        {
            if(RoomWrapper.RoomCache[room.HotelId] == null) RoomWrapper.RoomCache.Add(room.HotelId, new List<Room>());
            RoomWrapper.RoomCache[room.HotelId].Add(room);
        }

        /**
         * Ability to add rooms to cache, by using AddToCache(Room room)
         */
        private static void AddToCache(IEnumerable<Room> rooms)
        {
            foreach (Room room in rooms)
            {
                RoomWrapper.AddToCache(room);
            }
        }

    }
}
