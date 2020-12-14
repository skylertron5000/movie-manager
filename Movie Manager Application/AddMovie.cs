using System;
using System.Windows.Forms;

namespace Movie_Manager_Application
{
    public partial class AddMovie : Form
    {
        public AddMovie()
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

        private void addButton_Click(object sender, EventArgs e)
        {
            // If title, year, director, or genre are empty then warn the user and do not make a DB call
            if (String.IsNullOrEmpty(textBox_movieTitle.Text.Trim()) ||
                String.IsNullOrEmpty(textBox_year.Text.Trim()) ||
                String.IsNullOrEmpty(textBox_director.Text.Trim()) ||
                String.IsNullOrEmpty(comboBox_genre.Text.Trim()))
            {
                MessageBox.Show("You are missing one or more of the following required values:\n" +
                                "Title, Year, Director, Genre.");
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
                    "* Add Button *\n\n" +
                    $"Movie Title: {movieData.MovieTitle}\n" +
                    $"Year: {movieData.Year}\n" +
                    $"Director: {movieData.Director}\n" +
                    $"Genre: {movieData.Genre}\n" +
                    $"RT Score: {movieData.RTScore}\n" +
                    $"BOE: {movieData.BOE}";

                MessageBox.Show(displayText);

                SqlHandler.insertRecord(movieData);
            }
        }
    }
}
