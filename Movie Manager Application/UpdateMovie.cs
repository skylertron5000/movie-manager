using System;
using System.Windows.Forms;

namespace Movie_Manager_Application
{
    public partial class UpdateMovie : Form
    {
        public UpdateMovie()
        {
            InitializeComponent();
        }

        private void clearUpdateMovieButton_Click(object sender, EventArgs e)
        {
            textBox_movieTitle.Clear();
            textBox_year.Clear();
            textBox_director.Clear();
            comboBox_genre.ResetText();
            textBox_rtScore.Clear();
            textBox_boe.Clear();
        }

        private void closeUpdateMovieButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void findUpdateMovieButton_Click(object sender, EventArgs e)
        {
            MovieData movieData = new MovieData(textBox_movieTitle.Text,
                                                textBox_year.Text,
                                                textBox_director.Text,
                                                comboBox_genre.Text,
                                                textBox_rtScore.Text,
                                                textBox_boe.Text);

            string displayText =
                "* Find Button *\n\n" +
                $"Movie Title: {movieData.MovieTitle}\n";

            MessageBox.Show(displayText);

            SqlHandler.findMovie(movieData);
        }

        private void updateUpdateMovieButton_Click(object sender, EventArgs e)
        {
            MovieData movieData = new MovieData(textBox_movieTitle.Text,
                                                textBox_year.Text,
                                                textBox_director.Text,
                                                comboBox_genre.Text,
                                                textBox_rtScore.Text,
                                                textBox_boe.Text);

            string displayText =
                "* Update Button *\n\n" +
                $"Movie Title: {movieData.MovieTitle}\n" +
                $"Year: {movieData.Year}\n" +
                $"Director: {movieData.Director}\n" +
                $"Genre: {movieData.Genre}\n" +
                $"RT Score: {movieData.RTScore}\n" +
                $"BOE: {movieData.BOE}";

            MessageBox.Show(displayText);

            SqlHandler.updateMovie(movieData);
        }
    }
}
