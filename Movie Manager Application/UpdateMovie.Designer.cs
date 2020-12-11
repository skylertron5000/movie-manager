
namespace Movie_Manager_Application
{
    partial class UpdateMovie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_movieTitle = new System.Windows.Forms.TextBox();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.textBox_director = new System.Windows.Forms.TextBox();
            this.textBox_rtScore = new System.Windows.Forms.TextBox();
            this.textBox_boe = new System.Windows.Forms.TextBox();
            this.comboBox_genre = new System.Windows.Forms.ComboBox();
            this.label_updateMovieScreen = new System.Windows.Forms.Label();
            this.label_movie = new System.Windows.Forms.Label();
            this.label_year = new System.Windows.Forms.Label();
            this.label_director = new System.Windows.Forms.Label();
            this.label_genre = new System.Windows.Forms.Label();
            this.label_rtScore = new System.Windows.Forms.Label();
            this.label_boe = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_find = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_movieTitle
            // 
            this.textBox_movieTitle.Location = new System.Drawing.Point(115, 75);
            this.textBox_movieTitle.Name = "textBox_movieTitle";
            this.textBox_movieTitle.Size = new System.Drawing.Size(100, 22);
            this.textBox_movieTitle.TabIndex = 0;
            // 
            // textBox_year
            // 
            this.textBox_year.Location = new System.Drawing.Point(115, 123);
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(100, 22);
            this.textBox_year.TabIndex = 1;
            // 
            // textBox_director
            // 
            this.textBox_director.Location = new System.Drawing.Point(115, 170);
            this.textBox_director.Name = "textBox_director";
            this.textBox_director.Size = new System.Drawing.Size(100, 22);
            this.textBox_director.TabIndex = 2;
            // 
            // textBox_rtScore
            // 
            this.textBox_rtScore.Location = new System.Drawing.Point(211, 324);
            this.textBox_rtScore.Name = "textBox_rtScore";
            this.textBox_rtScore.Size = new System.Drawing.Size(143, 22);
            this.textBox_rtScore.TabIndex = 3;
            // 
            // textBox_boe
            // 
            this.textBox_boe.Location = new System.Drawing.Point(590, 329);
            this.textBox_boe.Name = "textBox_boe";
            this.textBox_boe.Size = new System.Drawing.Size(164, 22);
            this.textBox_boe.TabIndex = 4;
            // 
            // comboBox_genre
            // 
            this.comboBox_genre.FormattingEnabled = true;
            this.comboBox_genre.Location = new System.Drawing.Point(115, 227);
            this.comboBox_genre.Name = "comboBox_genre";
            this.comboBox_genre.Size = new System.Drawing.Size(121, 24);
            this.comboBox_genre.TabIndex = 5;
            // 
            // label_updateMovieScreen
            // 
            this.label_updateMovieScreen.AutoSize = true;
            this.label_updateMovieScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_updateMovieScreen.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_updateMovieScreen.Location = new System.Drawing.Point(76, 13);
            this.label_updateMovieScreen.Name = "label_updateMovieScreen";
            this.label_updateMovieScreen.Size = new System.Drawing.Size(220, 25);
            this.label_updateMovieScreen.TabIndex = 6;
            this.label_updateMovieScreen.Text = "Update Movie Screen";
            // 
            // label_movie
            // 
            this.label_movie.AutoSize = true;
            this.label_movie.Location = new System.Drawing.Point(44, 75);
            this.label_movie.Name = "label_movie";
            this.label_movie.Size = new System.Drawing.Size(49, 17);
            this.label_movie.TabIndex = 7;
            this.label_movie.Text = "Movie:";
            // 
            // label_year
            // 
            this.label_year.AutoSize = true;
            this.label_year.Location = new System.Drawing.Point(44, 128);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(42, 17);
            this.label_year.TabIndex = 8;
            this.label_year.Text = "Year:";
            // 
            // label_director
            // 
            this.label_director.AutoSize = true;
            this.label_director.Location = new System.Drawing.Point(44, 175);
            this.label_director.Name = "label_director";
            this.label_director.Size = new System.Drawing.Size(62, 17);
            this.label_director.TabIndex = 9;
            this.label_director.Text = "Director:";
            // 
            // label_genre
            // 
            this.label_genre.AutoSize = true;
            this.label_genre.Location = new System.Drawing.Point(44, 234);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(52, 17);
            this.label_genre.TabIndex = 10;
            this.label_genre.Text = "Genre:";
            // 
            // label_rtScore
            // 
            this.label_rtScore.AutoSize = true;
            this.label_rtScore.Location = new System.Drawing.Point(44, 329);
            this.label_rtScore.Name = "label_rtScore";
            this.label_rtScore.Size = new System.Drawing.Size(147, 17);
            this.label_rtScore.TabIndex = 11;
            this.label_rtScore.Text = "Rotten Tomato Score:";
            // 
            // label_boe
            // 
            this.label_boe.AutoSize = true;
            this.label_boe.Location = new System.Drawing.Point(421, 332);
            this.label_boe.Name = "label_boe";
            this.label_boe.Size = new System.Drawing.Size(129, 17);
            this.label_boe.TabIndex = 12;
            this.label_boe.Text = "Box Office Earning:";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(81, 399);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 13;
            this.button_delete.Text = "Update";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.updateUpdateMovieButton_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(247, 399);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 14;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.clearUpdateMovieButton_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(603, 399);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 15;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.closeUpdateMovieButton_Click);
            // 
            // button_find
            // 
            this.button_find.Location = new System.Drawing.Point(303, 75);
            this.button_find.Name = "button_find";
            this.button_find.Size = new System.Drawing.Size(75, 23);
            this.button_find.TabIndex = 16;
            this.button_find.Text = "Find";
            this.button_find.UseVisualStyleBackColor = true;
            this.button_find.Click += new System.EventHandler(this.findUpdateMovieButton_Click);
            // 
            // UpdateMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_find);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.label_boe);
            this.Controls.Add(this.label_rtScore);
            this.Controls.Add(this.label_genre);
            this.Controls.Add(this.label_director);
            this.Controls.Add(this.label_year);
            this.Controls.Add(this.label_movie);
            this.Controls.Add(this.label_updateMovieScreen);
            this.Controls.Add(this.comboBox_genre);
            this.Controls.Add(this.textBox_boe);
            this.Controls.Add(this.textBox_rtScore);
            this.Controls.Add(this.textBox_director);
            this.Controls.Add(this.textBox_year);
            this.Controls.Add(this.textBox_movieTitle);
            this.Name = "UpdateMovie";
            this.Text = "UpdateMovie";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox_movieTitle;
        private System.Windows.Forms.TextBox textBox_year;
        private System.Windows.Forms.TextBox textBox_director;
        private System.Windows.Forms.TextBox textBox_rtScore;
        private System.Windows.Forms.TextBox textBox_boe;
        private System.Windows.Forms.ComboBox comboBox_genre;
        private System.Windows.Forms.Label label_updateMovieScreen;
        private System.Windows.Forms.Label label_movie;
        private System.Windows.Forms.Label label_year;
        private System.Windows.Forms.Label label_director;
        private System.Windows.Forms.Label label_genre;
        private System.Windows.Forms.Label label_rtScore;
        private System.Windows.Forms.Label label_boe;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_find;
    }
}