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
    public partial class UpdateMovie : Form
    {
        public UpdateMovie()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closeButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearButton3_Click(object sender, EventArgs e)
        {
            movieTitleTextBox3.Clear();
            yearTextBox3.Clear();
            directorTextBox3.Clear();
            genreComboBox3.ResetText();
            rottenTomatoScoreTextBox3.Clear();
            boxOfficeEarningTextBox3.Clear();
        }
    }
}
