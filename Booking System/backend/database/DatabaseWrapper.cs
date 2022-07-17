using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

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
         * Returns 0 when the command runs successfully, otherwise returns the error HashCode when the result is 
         */
        public static DatabaseResult InsertIntoDatabase(string query)
        {
            DatabaseResult result;

            try
            {
                DatabaseWrapper.Open();
                OleDbCommand insertCommand = new OleDbCommand(query, DatabaseWrapper.GetConnection());

                insertCommand.ExecuteNonQuery();
                insertCommand.Dispose();

                result = DatabaseWrapper.ConvertResult(0); //Null means command ok
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Message: {ex.Message}\nHash Code: {ex.GetHashCode()}");
                result = ConvertResult (ex.GetHashCode());
            }
            finally
            {
                DatabaseWrapper.Close();
            }

            return result;
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
                    if (!reader.HasRows) result.Add(new Tuple<DatabaseResult, Dictionary<string, object>>(DatabaseResult.NotFound, null));
                    else
                    {
                        while (reader.Read())
                        {
                            //The result is converted into a dictionary so it is independent of the OleDbReader.  This frees up memory and gives us the ability to close the connection and the reader before the data is manupulated
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

        private static DatabaseResult ConvertResult(int error)
        {
            switch (error)
            {
                case 0:
                    return DatabaseResult.Ok;
                case 958745:
                case 49205706:
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
        NotFound=404,
        Unknown = 400
    } 
}
