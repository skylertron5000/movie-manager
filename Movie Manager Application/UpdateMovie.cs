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

        private void findUpdateMovieButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pushed the find update movie button");
        }

        private void closeUpdateMovieButton_Click(object sender, EventArgs e)
        {
            Close();
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

        private void updateUpdateMovieButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pushed the update button");
        }
    }
}
