using System;
using System.Collections;
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

        public static ArrayList queryAllMovieData()
        {
            Console.WriteLine($"Attempting to load all movie data...");

            ArrayList allMovies = new ArrayList();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand("SELECT id, title, year, director, genre FROM MOVIES", connection))
                //using (SqlCommand command = new SqlCommand("select * from information_schema.columns where table_name = 'MOVIES'", connection))
                {
                    connection.Open(); // The database is closed upon Dispose() (or Close()).

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            object id = reader[0];
                            int idAsInt = Convert.ToInt32(id);

                            object title = reader[1];
                            string titleAsString = title.ToString();

                            object year = reader[2];
                            string yearAsString = year.ToString();

                            object director = reader[3];
                            string directorAsString = director.ToString();

                            object genre = reader[4];
                            string genreAsString = genre.ToString();

                            var m = new MovieData(idAsInt, titleAsString, yearAsString, directorAsString, genreAsString, "", "");

                            allMovies.Add(m);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Query all movie data - Something went wrong while opening a connection to the database: { ex.Message }");
            }

            Console.WriteLine($"Query all movie data - Successfully opened and closed the database.");

            return allMovies;
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
