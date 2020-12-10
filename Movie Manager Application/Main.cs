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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        //onLoad connect to database and download list of movies
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("You clicked the about menu option!");
            var m = new About();
            m.Show();

        }

        private void addMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("You clicked the add movie menu option!");
            var am = new AddMovie();
            am.Show();
        }

        private void deleteMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("You clicked the delete movie menu option!");
            var um = new DeleteMovie();
            um.Show();
        }

        private void updateMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("You clicked the update movie menu option!");
            var dm = new UpdateMovie();
            dm.Show();
        }

       
    }

}
