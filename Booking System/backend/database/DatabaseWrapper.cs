﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;

namespace Booking_System.backend.database
{
    internal class DatabaseWrapper
    {
        private static readonly string ConString = ConfigurationManager.ConnectionStrings["Booking_System.Properties.Settings.dbConnectionString"].ConnectionString;//$"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\bookings.mdb";
        private static readonly OleDbConnection DbCon = new OleDbConnection(ConString);

        private static OleDbConnection GetConnection()
        {
            return DbCon;
        }

        private static void Open()
        {
            DbCon.Open();
        }

        private static void Close()
        {
            DbCon.Close();
        }

        /**
         * Run a query which does not return an "item" from the database, but simply returns a status of command.
         */
        private static DatabaseResult RunSingleNonReturningQuery(string query)
        {
            DatabaseResult result;

            try
            {
                DatabaseWrapper.Open();
                OleDbCommand command = new OleDbCommand(query, DatabaseWrapper.GetConnection());

                command.ExecuteNonQuery();
                command.Dispose();

                result = DatabaseWrapper.ConvertResult(0); //Null means command ok
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Message: {ex.Message}\nHash Code: {ex.GetHashCode()}");
                result = ConvertResult(ex.GetHashCode());
            }
            finally
            {
                DatabaseWrapper.Close();
            }

            return result;
        }

        /**
         * Run a query (usually insertion) which returns the "identity" of the object (a.k.a auto generated ID)
         */
        private static (DatabaseResult, int) RunSingleReturningIdQuery(string query)
        {
            DatabaseResult result;
            int id = -1;

            try
            {

                DatabaseWrapper.Open();
                OleDbCommand command = new OleDbCommand(query, DatabaseWrapper.GetConnection());
                command.ExecuteNonQuery();

                //Get the command scalar (https://stackoverflow.com/questions/7230200/how-to-get-the-last-record-number-after-inserting-record-to-database-in-access)
                command.CommandText = "Select @@Identity";
                id = (int)command.ExecuteScalar();

                command.Dispose();

                result = DatabaseWrapper.ConvertResult(0); //Null means command ok
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Message: {ex.Message}\nHash Code: {ex.GetHashCode()}");
                result = ConvertResult(ex.GetHashCode());
            }
            finally
            {
                DatabaseWrapper.Close();
            }

            return (result, id);
        }

        /**
         * Update from database.  This is mostly used for code readability as it is the same as InsertIntoDatabase
         */
        public static DatabaseResult UpdateFromDatabase(string query)
        {
            return DatabaseWrapper.RunSingleNonReturningQuery(query);
        }

        /**
         * Insert into database.  This is mostly used for code readability as it is the same as UpdateFromDatabase
         */
        public static DatabaseResult InsertIntoDatabase(string query)
        {
            return DatabaseWrapper.RunSingleNonReturningQuery(query);
        }

        /**
         * Insert into database whilst getting the ID of the insertion.
         */
        public static (DatabaseResult, int) InsertIntoDatabaseReturningId(string query)
        {
            return DatabaseWrapper.RunSingleReturningIdQuery(query);
        }

        /**
         * Delete from database.  This is mostly used for code readability as it is the same as UpdateFromDatabase
         */
        public static DatabaseResult DeleteFromDatabase(string query)
        {
            return DatabaseWrapper.RunSingleNonReturningQuery(query);
        }

        public static Tuple<DatabaseResult, Dictionary<string, object>>[] GetFromDatabase(string query)
        {
            List<Tuple<DatabaseResult, Dictionary<string, object>>> result = new List<Tuple<DatabaseResult, Dictionary<string, object>>>();

            try
            {
                DatabaseWrapper.Open();
                OleDbCommand selectCommand = new OleDbCommand(query, DatabaseWrapper.GetConnection());

                using (OleDbDataReader reader = selectCommand.ExecuteReader())
                {
                    if (!reader.HasRows) result.Add(new Tuple<DatabaseResult, Dictionary<string, object>>(DatabaseResult.NotFound, null)); //If the result has no rows, return not found
                    else
                    {
                        while (reader.Read())
                        {
                            //The result is converted into a dictionary so it is independent of the OleDbReader.  This frees up memory and gives us the ability to close the connection and the reader before the data is manipulated
                            Dictionary<string, object> currentRow = Enumerable.Range(0, reader.FieldCount).ToDictionary(reader.GetName, reader.GetValue); //Convert the current row into a dictionary (rowName -> rowResult)
                            result.Add(new Tuple<DatabaseResult, Dictionary<string, object>>(DatabaseResult.Ok, currentRow)); //Store the current row as dbResult -> dictionary
                        }

                    }
                }

                selectCommand.Dispose();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Message: {ex.Message}\nHash Code: {ex.GetHashCode()}");
                result.Add(new Tuple<DatabaseResult, Dictionary<string, object>>(ConvertResult(ex.GetHashCode()), null));
            }
            finally
            {
                DatabaseWrapper.Close();
            }


            return result.ToArray();
        }

        /**
         * Converts Error HashCodes into readable and manipulatable results
         */
        private static DatabaseResult ConvertResult(int error)
        {
            switch (error)
            {
                case 0:
                    return DatabaseResult.Ok;
                case 958745:
                case 49205706:
                case 53036123:
                    return DatabaseResult.Duplicate;
                default:
                    return DatabaseResult.Unknown;
            }
        }
    }

    internal enum DatabaseResult
    {
        Ok = 200,
        Duplicate = 409,
        NotFound = 404,
        Unknown = 400
    }
}
