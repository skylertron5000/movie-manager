using System;
using System.Data.SqlClient;

namespace Movie_Manager_Application
{
    class SqlHandler
    {
        private const string ConnectionString = @"Data Source=coursemaster1.csbchotp6tva.us-east-2.rds.amazonaws.com,1433;Initial Catalog=CSCI1630;User ID=rw1630;Password=Project!;";

        public static void findMovie(MovieData movieData)
        {
            string queryType = "Find Movie";

            queryDB(queryType, movieData);
        }

        public static void addMovie(MovieData movieData)
        {
            string queryType = "Add Movie";

            queryDB(queryType, movieData);
        }

        public static void updateMovie(MovieData movieData)
        {
            string queryType = "Update Movie";

            queryDB(queryType, movieData);
        }

        public static void deleteMovie(MovieData movieData)
        {
            string queryType = "Delete Movie";

            queryDB(queryType, movieData);
        }

        public static string queryAllMovieData()
        {
            Console.WriteLine($"Attempting to load all movie data...");

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand("SELECT Id, FirstName, LastName, DateOfBirth, GenderId FROM dbo.Person", connection))
                {
                    connection.Open(); // The database is closed upon Dispose() (or Close()).
                }
                
                Console.WriteLine($"Query all movie data - Successfully opened and closed the database.");
                return "((ALL OF THE MOVIE DATA))";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Query all movie data - Something went wrong while opening a connection to the database: { ex.Message }");
                return null;
            }
        }

        private static void queryDB(string queryType, MovieData movieData)
        {
            consoleWriteQueryInfo(movieData, queryType);

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

        private static void consoleWriteQueryInfo(MovieData movieData, string queryType)
        {
            Console.WriteLine($"Attempting to {queryType} for the following data:");
            Console.WriteLine(movieData.getAllProperties());
        }
    }
}
