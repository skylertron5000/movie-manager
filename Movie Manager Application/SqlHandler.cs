using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace Movie_Manager_Application
{
    class SqlHandler
    {
        private const string ConnectionString = @"Data Source=coursemaster1.csbchotp6tva.us-east-2.rds.amazonaws.com,1433;Initial Catalog=CSCI1630;User ID=rw1630;Password=Project!;";

        public static ArrayList queryAllMovieData()
        {
            Console.WriteLine($"Attempting to load all movie data...");

            ArrayList allMovies = new ArrayList();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand("SELECT id, title, year, director, genre FROM MOVIES", connection))
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

        public static int insertRecord(MovieData movieData)
        {
            string queryType = "Add Movie";
            consoleWriteQueryInfo(movieData, queryType);

            string sqlCommandString =
                "INSERT INTO MOVIES (title, year, director, genre) " + 
                $"VALUES (@title, @year, @director, @genre);";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand(sqlCommandString, connection))
                {
                    connection.Open(); // The database is closed upon Dispose() (or Close()).

                    command.Parameters.Add("title", SqlDbType.VarChar).Value = movieData.MovieTitle;
                    command.Parameters.Add("year", SqlDbType.Int).Value = movieData.Year;
                    command.Parameters.Add("director", SqlDbType.VarChar).Value = movieData.Director;
                    command.Parameters.Add("genre", SqlDbType.Int).Value = movieData.Genre;

                    Console.WriteLine($"{queryType} - Successfully opened and closed the database.");

                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{queryType} - Something went wrong while opening a connection to the database: { ex.Message }");
            }

            return 0;
        }

        public static void updateRecord(MovieData movieData)
        {
            string queryType = "Update Movie";
            consoleWriteQueryInfo(movieData, queryType);
        }

        public static void deleteRecord(MovieData movieData)
        {
            string queryType = "Delete Movie";
            consoleWriteQueryInfo(movieData, queryType);
        }

        public static MovieData findRecord(MovieData movieData)
        {
            string queryType = "Find Movie";
            consoleWriteQueryInfo(movieData, queryType);

            string sqlCommandString = "SELECT id, title, year, director, genre, RottenTomatoesScore, TotalEarned FROM MOVIES " +
                                      $"WHERE title = @title";

            // try/catch block to find the movie
            // if no movie is found, return null
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand(sqlCommandString, connection))
                {
                    connection.Open(); // The database is closed upon Dispose() (or Close()).

                    command.Parameters.Add("title", SqlDbType.VarChar).Value = movieData.MovieTitle;

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

                            object rtScore = reader[5];
                            string rtScoreAsInt = rtScore.ToString();

                            object boe = reader[6];
                            string boeAsDecimal = boe.ToString();

                            var m = new MovieData(idAsInt,
                                titleAsString,
                                yearAsString,
                                directorAsString,
                                genreAsString,
                                rtScoreAsInt,
                                boeAsDecimal);

                            return m;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Query all movie data - Something went wrong while opening a connection to the database: { ex.Message }");
            }

            return null;
        }

        private static void consoleWriteQueryInfo(MovieData movieData, string queryType)
        {
            Console.WriteLine($"Attempting to {queryType} for the following data:");
            Console.WriteLine(movieData.getAllProperties());
        }
    }
}
