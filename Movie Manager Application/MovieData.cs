using System.ComponentModel;

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

        public string MovieTitle { get; }
        public string Year { get; }
        public string Director { get; }
        public string Genre { get; }
        public string RTScore { get; }
        public string BOE { get; }

        public string getAllProperties()
        {
            string allProperties = "";

            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(this))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(this);
                allProperties += $"<{name}={value}>";
            }

            return allProperties;
        }
    }
}
