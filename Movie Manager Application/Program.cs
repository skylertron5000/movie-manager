using System;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Movie_Manager_Application
{
    static class Program
    {

        private const string ConnectionString = @"Data Source=coursemaster1.csbchotp6tva.us-east-2.rds.amazonaws.com,1433;Initial Catalog=CSCI1630;User ID=rw1630;Password=Project!;";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());

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

                    foreach (MovieData m in allMovies)
                    {
                        Console.WriteLine(m.getAllProperties());
                    }

                    Console.WriteLine($"Query all movie data - Successfully opened and closed the database.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Query all movie data - Something went wrong while opening a connection to the database: { ex.Message }");
            }
        }
    }
}
