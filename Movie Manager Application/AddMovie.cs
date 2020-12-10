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
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            movieTitleTextBox.Clear();
            yearTextBox.Clear();
            directorTextBox.Clear();
            genreComboBox.ResetText();
            rottenTomatoScoreTextBox.Clear();
            boxOfficeEarningTextBox.Clear();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
      MessageBox.Show("Hello, World!\n Second line.");
    }
    }
}
