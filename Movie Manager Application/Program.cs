using System;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            //SchemaFinder.showSchema();
            //TableCatalog TABLE_SCHEMA   TABLE_NAME COLUMN_NAME    DATA_TYPE
            //CSCI1630       dbo Movies         Id             int
            //CSCI1630       dbo Movies         Title varchar
            //CSCI1630 dbo            Movies Year           int
            //CSCI1630       dbo Movies         Director varchar
            //CSCI1630 dbo            Movies Genre          int
            //CSCI1630       dbo Movies         RottenTomatoesScoreint
            //CSCI1630       dbo Movies         TotalEarned    decimal
        }
    }
}
