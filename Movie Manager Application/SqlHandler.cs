using System;
using System.Data.SqlClient;

namespace Movie_Manager_Application
{
    class SqlHandler
    {
        private const string ConnectionString = @"Data Source=coursemaster1.csbchotp6tva.us-east-2.rds.amazonaws.com,1433;Initial Catalog=CSCI1630;User ID=rw1630;Password=Project!;";

        public static void findMovie()
        {
            string queryType = "Find Movie";

            queryDB(queryType);
        }

        public static void addMovie()
        {
            string queryType = "Add Movie";

            queryDB(queryType);
        }

        public static void updateMovie()
        {
            string queryType = "Update Movie";

            queryDB(queryType);
        }

        public static void deleteMovie()
        {
            string queryType = "Delete Movie";

            queryDB(queryType);
        }

        private static void queryDB(string queryType)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open(); // The database is closed upon Dispose() (or Close()).
                }
                Console.WriteLine($"{queryType} - Successfully opened and closed the database.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{queryType} - Something went wrong while opening a connection to the database: { ex.Message }");
            }
        }
    }
}
