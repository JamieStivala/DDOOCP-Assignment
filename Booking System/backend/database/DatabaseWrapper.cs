using System;
using System.Data.OleDb;
using System.Diagnostics;
using System.Configuration;
using System.Windows.Forms;

namespace Booking_System.backend.database
{
    internal class DatabaseWrapper
    {
        private static readonly string conString = ConfigurationManager.ConnectionStrings["Booking_System.Properties.Settings.dbConnectionString"].ConnectionString;//$"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\bookings.mdb";
        private static readonly OleDbConnection dbCon = new OleDbConnection(conString);

        private static OleDbConnection getConnection()
        {
            return dbCon;
        }

        private static void Open()
        {
            dbCon.Open();
        }

        private static void Close()
        {
            dbCon.Close();
        }

        /**
         * Returns 0 when the command runs successfully, otherwise returns the error HashCode when the result is 
         */
        public static DatabaseResult InsertIntoDatabase(string query)
        {
            DatabaseResult result;
            Debug.Write(DatabaseWrapper.conString);

            try
            {
                DatabaseWrapper.Open();
                OleDbCommand insertCommand = new OleDbCommand(query, DatabaseWrapper.getConnection());

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

        private static DatabaseResult ConvertResult(int error)
        {
            switch (error)
            {
                case 0:
                    return DatabaseResult.OK;
                case 958745:
                    return DatabaseResult.DUPLICATE;
                default:
                    return DatabaseResult.UNKNOWN;
            }
        }
    }

    internal enum DatabaseResult
    {
        OK = 200,
        DUPLICATE = 409,
        UNKNOWN = 400
    } 
}
