using System;
using System.Data.SqlClient;

namespace Movie_Manager_Application
{
    class SqlHandler
    {
        private const string ConnectionString = @"Data Source=coursemaster1.csbchotp6tva.us-east-2.rds.amazonaws.com,1433;Initial Catalog=CSCI1630;User ID=rw1630;Password=Project!;";

        public static void findMovie()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open(); // The database is closed upon Dispose() (or Close()).
                }
                Console.WriteLine("Find Movie - Successfully opened and closed the database.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Find Movie - Something went wrong while opening a connection to the database: { ex.Message }");
            }
        }

        public static void addMovie()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open(); // The database is closed upon Dispose() (or Close()).
                }
                Console.WriteLine("Add Movie - Successfully opened and closed the database.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Add Movie - Something went wrong while opening a connection to the database: { ex.Message }");
            }
        }

        public static void updateMovie()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open(); // The database is closed upon Dispose() (or Close()).
                }
                Console.WriteLine("Update Movie - Successfully opened and closed the database.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Update Movie - Something went wrong while opening a connection to the database: { ex.Message }");
            }
        }

        public static void deleteMovie()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open(); // The database is closed upon Dispose() (or Close()).
                }
                Console.WriteLine("Delete Movie - Successfully opened and closed the database.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Delete Movie - Something went wrong while opening a connection to the database: { ex.Message }");
            }
        }
    }
}
