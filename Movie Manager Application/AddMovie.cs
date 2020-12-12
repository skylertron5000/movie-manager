﻿using System;
using System.Windows.Forms;

namespace Movie_Manager_Application
{
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
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

        private void closeAddMovieButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addAddMovieButton_Click(object sender, EventArgs e)
        {
            string displayText =
                "* Add Button *\n\n" +
                $"Movie Title: {textBox_movieTitle.Text}\n" +
                $"Year: {textBox_year.Text}\n" +
                $"Director: {textBox_director.Text}\n" +
                $"Genre: {comboBox_genre.Text}\n" +
                $"RT Score: {textBox_rtScore.Text}\n" +
                $"BOE: {textBox_boe.Text}";

            MessageBox.Show(displayText);

            // Make AddMovie call to DB
            SqlHandler.addMovie();
        }
    }
}
