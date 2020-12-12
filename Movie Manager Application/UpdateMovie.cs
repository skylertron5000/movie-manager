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
            string displayText =
                "* Find Button *\n\n" +
                $"Title: {textBox_movieTitle.Text}\n";

            MessageBox.Show(displayText);

            // Make FindMovie call to DB
            SqlHandler.foo();
        }

        private void updateUpdateMovieButton_Click(object sender, EventArgs e)
        {
            string displayText =
                "* Update Button *\n\n" +
                $"Title: {textBox_movieTitle.Text}\n" +
                $"Year: {textBox_year.Text}\n" +
                $"Director: {textBox_director.Text}\n" +
                $"Genre: {comboBox_genre.Text}\n" +
                $"RT Score: {textBox_rtScore.Text}\n" +
                $"BOE: {textBox_boe.Text}";

            MessageBox.Show(displayText);

            // Make UpdateMovie call to DB
            SqlHandler.foo();
        }
    }
}
