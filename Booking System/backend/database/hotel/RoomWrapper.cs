﻿using Booking_System.backend.model.hotel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Booking_System.backend.database.hotel
{
    public class RoomWrapper
    {
        private static readonly Dictionary<int, List<Room>> RoomCache = new Dictionary<int, List<Room>>();  //Hotel --> Room
        private static readonly List<Room> RoomList = new List<Room>();
        public static void CreateRoom(Room room)
        {
            string insertQuery = $"INSERT INTO tblRoom (HotelId, [Name], Description, Capacity, Price, AmountOfRooms) VALUES" +
                                 $"({room.HotelId}, '{room.Name}', '{room.Description}', {room.Capacity}, {room.Price}, {room.AmountOfRooms})";

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
            //Just in case the  object was copied, copy the current instance onto the new instance
            Room cachedRoom = RoomCache[room.HotelId]?.Find(searching => searching.Id == room.Id);
            if (cachedRoom == null) throw new Exception("The room you are trying to update cannot be found.");

            cachedRoom.HotelId = room.HotelId;
            cachedRoom.Name = room.Name;
            cachedRoom.Description = room.Description;
            cachedRoom.Capacity = room.Capacity;
            cachedRoom.Price = room.Price;
            cachedRoom.AmountOfRooms = room.AmountOfRooms;
            //Just in case the  object was copied, copy the current instance onto the new instance

            string updateQuery = $"UPDATE tblRoom SET " +
                                 $" HotelId={room.HotelId}, [Name]='{room.Name}', " +
                                 $" Description='{room.Description}', Capacity={room.Capacity}, " +
                                 $" Price={room.Price}, AmountOfRooms={room.AmountOfRooms} " +
                                 $"WHERE ID={room.Id}";

            DatabaseResult result = DatabaseWrapper.UpdateFromDatabase(updateQuery);

            //Switch the result based on the ENUM representing result
            switch (result)
            {
                case DatabaseResult.Ok:
                    return;
                case DatabaseResult.NotFound:
                    throw new Exception("The room you are trying to update cannot be found.");
                default:
                    throw new Exception("An unknown error has occurred.");
            }
        }

        public static Room[] GetHotelRooms(int hotelId)
        {
            //Check if the item is in the cache, if it is, return it
            if (RoomWrapper.RoomCache.ContainsKey(hotelId)) return RoomWrapper.RoomCache[hotelId].ToArray().OrderBy(value => value.Name).ToArray();

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
                            Price = double.Parse(dbRoom.Item2["Price"].ToString()), //For some reason normal typecasting wasn't working
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

        public static Room GetHotelRoom(int roomId)
        {
            Room cachedRoom = RoomWrapper.RoomList.Find(findingRoom => findingRoom.Id == roomId);
            if (cachedRoom != null) return cachedRoom;

            string query = $"SELECT * FROM tblRoom WHERE ID={roomId}";
            Tuple<DatabaseResult, Dictionary<string, object>> dbRoom = (DatabaseWrapper.GetFromDatabase(query)[0]);

            switch (dbRoom.Item1)
            {
                case DatabaseResult.Ok:
                    Room room = new Room((int)dbRoom.Item2["ID"])
                    {
                        HotelId = (int)dbRoom.Item2["HotelId"],
                        Name = dbRoom.Item2["Name"].ToString(),
                        Description = dbRoom.Item2["Description"].ToString(),
                        Capacity = (int)dbRoom.Item2["Capacity"],
                        Price = double.Parse(dbRoom.Item2["Price"].ToString()), //For some reason normal typecasting wasn't working
                        AmountOfRooms = (int)dbRoom.Item2["AmountOfRooms"],
                    };
                    RoomWrapper.AddToCache(room); //Add the room to the cache
                    return room;
                default:
                    throw new Exception("An unknown error has occurred.");
            }
        }

        public static void DeleteRoom(Room room)
        {
            string query = $"DELETE * FROM tblRoom WHERE ID={room.Id}";
            DatabaseResult result = DatabaseWrapper.DeleteFromDatabase(query);

            //Switch the result based on the ENUM representing result
            switch (result)
            {
                case DatabaseResult.Ok:
                    RoomWrapper.RoomCache[room.HotelId].Remove(room); //Remove the room from the cache
                    RoomWrapper.RoomList.Remove(room);
                    return;
                default:
                    throw new Exception("An unknown error has occurred.");
            }
        }


        /**
         * Ability to add one room to the cache, organized by hotel id
         */
        private static void AddToCache(Room room)
        {
            if (!RoomWrapper.RoomCache.ContainsKey(room.HotelId)) RoomWrapper.RoomCache.Add(room.HotelId, new List<Room>());

            if (RoomWrapper.RoomCache[room.HotelId].Find(findingRoom => room.Id == findingRoom.Id) == null) RoomWrapper.RoomCache[room.HotelId].Add(room);
            if (RoomWrapper.RoomList.Find(findingRoom => room.Id == findingRoom.Id) == null) RoomWrapper.RoomList.Add(room);
        }
    }
}
