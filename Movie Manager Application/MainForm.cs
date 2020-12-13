using System;
using System.Windows.Forms;

namespace Movie_Manager_Application
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: connect to database, download list of movies, populate table with movie data
            string allMovieData = SqlHandler.queryAllMovieData();
            Console.WriteLine($"All movie data: {allMovieData}");
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // The file menu option has no required functionality
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new About();
            form.Show();
        }

        private void addMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AddMovie();
            form.Show();
        }

        private void deleteMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DeleteMovie();
            form.Show();
        }

        private void updateMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new UpdateMovie();
            form.Show();
        }
    }
}
