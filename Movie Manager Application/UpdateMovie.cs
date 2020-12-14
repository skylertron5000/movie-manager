using System;
using System.Windows.Forms;

namespace Movie_Manager_Application
{
    public partial class UpdateMovie : Form
    {
        private int foundId = -999; // Presumably no actual id will be -999

        public UpdateMovie()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox_movieTitle.Clear();
            textBox_year.Clear();
            textBox_director.Clear();
            comboBox_genre.ResetText();
            textBox_rtScore.Clear();
            textBox_boe.Clear();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            MovieData movieData = new MovieData(textBox_movieTitle.Text.Trim(),
                                                textBox_year.Text.Trim(),
                                                textBox_director.Text.Trim(),
                                                comboBox_genre.Text.Trim(),
                                                textBox_rtScore.Text.Trim(),
                                                textBox_boe.Text.Trim());

            string displayText =
                "* Find Button *\n\n" +
                $"Movie Title: {movieData.MovieTitle}\n";

            MessageBox.Show(displayText);

            // findRecord should return a single MovieData object and then populate the text fields with its data
            MovieData foundMovie = SqlHandler.findRecord(movieData);

            if (foundMovie is null)
            {
                MessageBox.Show($"No movie was found with title \"{movieData.MovieTitle}\"");
            }
            else
            {
                // Keep track of the found movie's id in case we want to update it
                foundId = foundMovie.Id;

                // Populate text fields
                textBox_movieTitle.Text = foundMovie.MovieTitle;
                textBox_year.Text = foundMovie.Year;
                textBox_director.Text = foundMovie.Director;
                comboBox_genre.Text = foundMovie.Genre;
                textBox_rtScore.Text = foundMovie.RTScore;
                textBox_boe.Text = foundMovie.BOE;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (foundId == -999)
            {
                MessageBox.Show("You have not located a movie to update.");
            }
            else
            {
                MovieData movieData = new MovieData(textBox_movieTitle.Text.Trim(),
                                                    textBox_year.Text.Trim(),
                                                    textBox_director.Text.Trim(),
                                                    comboBox_genre.Text.Trim(),
                                                    textBox_rtScore.Text.Trim(),
                                                    textBox_boe.Text.Trim());

                string displayText =
                    "* Update Button *\n\n" +
                    $"Movie Title: {movieData.MovieTitle}\n" +
                    $"Year: {movieData.Year}\n" +
                    $"Director: {movieData.Director}\n" +
                    $"Genre: {movieData.Genre}\n" +
                    $"RT Score: {movieData.RTScore}\n" +
                    $"BOE: {movieData.BOE}";

                MessageBox.Show(displayText);

                SqlHandler.updateRecord(foundId, movieData);
            }

        }
    }
}
