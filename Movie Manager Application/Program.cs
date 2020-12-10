using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Manager_Application
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //      Application.EnableVisualStyles();
            //      Application.SetCompatibleTextRenderingDefault(false);
                  Application.Run(new Form1());

            try
            {
                using (SqlConnection connection = new SqlConnection(
                @"Data Source=coursemaster1.csbchotp6tva.us-east-2.rds.amazonaws.com,1433;Initial Catalog=CSCI1630;User ID=rw1630;Password=Project!;"))
                {
                    connection.Open();
                    // The database is closed upon Dispose() (or Close()).
                }
                Console.WriteLine("Successfully opened and closed the database.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong while opening a connection to the database: { ex.Message }");
            }
            //Console.WriteLine("Press any key to close.");
            //Console.ReadKey();
        }
    }
}
