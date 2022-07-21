using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking_System.backend.model.hotel;
using Booking_System.backend.model.user;

namespace Booking_System.backend.database.hotel
{
    public class HotelWrapper
    {
        private static readonly List<Hotel> HotelCache = new List<Hotel>();
        private static bool _gottenAll = false;

        public static void CreateHotel(Hotel hotel)
        {
            string insertQuery = $"INSERT INTO tblHotel ([Name], Location, DefaultCheckInTime, DefaultCheckOutTime) VALUES" +
                                 $"('{hotel.Name}', '{hotel.Location}', {hotel.DefaultCheckInTime.ToOADate()}, {hotel.DefaultCheckOutTime.ToOADate()})";

            (DatabaseResult, int) result = DatabaseWrapper.InsertIntoDatabaseReturningId(insertQuery);

            switch (result.Item1)
            {
                case DatabaseResult.Ok:
                    hotel.Id = result.Item2;
                    HotelWrapper.AddToCache(hotel);
                    return;
                default:
                    throw new Exception("An unknown error has occurred.");
            }

        }

        public static Hotel[] GetAllHotels()
        {
            if (HotelWrapper._gottenAll) return HotelWrapper.HotelCache.ToArray(); //If already gotten all the database items, return all

            HotelWrapper.HotelCache.Clear(); //Since we are re-getting everything from the database, remove any hotels in cache that were created

            string query = $"SELECT * FROM tblHotel";
            Tuple<DatabaseResult, Dictionary<string, object>>[] result = DatabaseWrapper.GetFromDatabase(query);

            for (int i = 0; i != result.Length; i++)
            {
                var currentRow = result[i];

                switch (currentRow.Item1)
                {
                    case DatabaseResult.Ok:
                        Hotel hotel = new Hotel((int)currentRow.Item2["ID"])
                        {
                            Name = currentRow.Item2["Name"].ToString(),
                            Location = currentRow.Item2["Location"].ToString(), 
                            DefaultCheckInTime = (DateTime)currentRow.Item2["DefaultCheckInTime"],
                            DefaultCheckOutTime = (DateTime)currentRow.Item2["DefaultCheckOutTime"]
                        }; //Create the hotel instance
                        HotelWrapper.HotelCache.Add(hotel); //Add the hotel to cache
                        break;
                    default:
                        throw new Exception("No hotels have been found.  Please tell the Admin to configure the system.");

                }
            }

            HotelWrapper._gottenAll = true;

            return HotelWrapper.GetAllHotels(); //Since now _gottenAll is true, return method (which simply returns the cache)
        }

        /**
         * Get hotel by ID
         */
        public static Hotel GetHotel(int id) => HotelWrapper.GetAllHotels().First(h => h.Id == id);

        public static void UpdateHotel(Hotel hotel)
        {
            //Just in case the object was copied and not referenced, copy the current instance onto the new instance
            Hotel cachedHotel = HotelWrapper.HotelCache.Find(val => val.Id == hotel.Id);
            if (cachedHotel == null) throw new Exception("A hotel with that internal ID can't be found.");

            cachedHotel.Name = hotel.Name;
            cachedHotel.Location = hotel.Location;
            cachedHotel.DefaultCheckInTime = hotel.DefaultCheckInTime;
            cachedHotel.DefaultCheckOutTime = hotel.DefaultCheckOutTime;
            //Just in case the object was copied and not referenced, copy the current instance onto the new instance
            
            string updateQuery = $"UPDATE tblHotel SET" +
                                 $" [Name]='{hotel.Name}', Location='{hotel.Location}', " +
                                 $" DefaultCheckInTime='{hotel.DefaultCheckInTime.ToShortTimeString()}', DefaultCheckOutTime='{hotel.DefaultCheckOutTime.ToShortTimeString()}'" +
                                 $"WHERE ID={hotel.Id}";

            DatabaseResult result = DatabaseWrapper.UpdateFromDatabase(updateQuery);

            //Switch the result based on the ENUM representing result
            switch (result)
            {
                case DatabaseResult.Ok:
                    return;
                case DatabaseResult.NotFound:
                    throw new Exception("A hotel with that internal ID can't be found.");
                default:
                    throw new Exception("An unknown error has occurred.");
            }
        }

        public static void DeleteHotel(Hotel hotel)
        {
            string query = $"DELETE * FROM tblHotel WHERE ID={hotel.Id}";
            DatabaseResult result = DatabaseWrapper.DeleteFromDatabase(query);

            //Switch the result based on the ENUM representing result
            switch (result)
            {
                case DatabaseResult.Ok:
                    HotelWrapper.HotelCache.Remove(hotel); //Remove the hotel from the cache
                    return;
                default:
                    throw new Exception("An unknown error has occurred.");
            }
        }


        private static void AddToCache(Hotel hotel)
        {
            HotelWrapper.HotelCache.Add(hotel);
        }


    }
}
