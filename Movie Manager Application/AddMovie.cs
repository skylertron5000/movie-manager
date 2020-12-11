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

        private void closeAddMovieButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearAddMovieButton_Click(object sender, EventArgs e)
        {
            textBox_movieTitle.Clear();
            textBox_year.Clear();
            textBox_director.Clear();
            comboBox_genre.ResetText();
            textBox_rtScore.Clear();
            textBox_boe.Clear();
        }

        private void addAddMovieButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pushed the add button");
        }
    }
}
