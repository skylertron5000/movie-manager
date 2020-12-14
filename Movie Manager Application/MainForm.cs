using System;
using System.Collections;
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
            RefreshMovieData();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshMovieData();
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

        private void RefreshMovieData()
        {
            ArrayList allMovieData = SqlHandler.queryAllMovieData();
            dataGridView.DataSource = allMovieData;
        }
    }
}
