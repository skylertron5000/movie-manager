using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Manager_Application
{
    public partial class DeleteMovie : Form
    {
        public DeleteMovie()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void closeDeleteMovie_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pushed the delete button");
        }

        private void clearDeleteMovieButton_Click(object sender, EventArgs e)
        {
            movieTitleTextBox2.Clear();
            yearTextBox2.Clear();
            directorTextBox2.Clear();
            genre.ResetText();
            rottenTomatoScoreTextBox2.Clear();
            boxOfficeEarningTextBox2.Clear();
        }
    }
}
