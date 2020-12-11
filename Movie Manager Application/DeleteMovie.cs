using System;
using System.Windows.Forms;

namespace Movie_Manager_Application
{
    public partial class DeleteMovie : Form
    {
        public DeleteMovie()
        {
            InitializeComponent();
        }

        private void closeDeleteMovie_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteDeleteMovieButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pushed the delete button");
        }

        private void clearDeleteMovieButton_Click(object sender, EventArgs e)
        {
            textBox_movieTitle.Clear();
            textBox_year.Clear();
            textBox_director.Clear();
            comboBox_genre.ResetText();
            textBox_rtScore.Clear();
            textBox_boe.Clear();
        }

        private void findDeleteMovieButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pushed the find delete movie button");
        }
    }
}
