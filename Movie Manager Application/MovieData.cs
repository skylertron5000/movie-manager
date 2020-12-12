
namespace Movie_Manager_Application
{
    class MovieData
    {
        public MovieData(string movieTitle, string year, string director, string genre, string rtScore, string boe)
        {
            MovieTitle = movieTitle;
            Year = year;
            Director = director;
            Genre = genre;
            RTScore = rtScore;
            BOE = boe;
        }

        public string MovieTitle { get; set; }
        public string Year { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public string RTScore { get; set; }
        public string BOE { get; set; }
    }
}
