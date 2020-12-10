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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            movieTitleTextBox.Clear();
            yearTextBox.Clear();
            directorTextBox.Clear();
            genreComboBox.ResetText();
            rottenTomatoScoreTextBox.Clear();
            boxOfficeEarningTextBox.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
