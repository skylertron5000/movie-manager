
namespace Movie_Manager_Application
{
    partial class DeleteMovie
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
            this.label_deleteMovieScreen = new System.Windows.Forms.Label();
            this.label_movie = new System.Windows.Forms.Label();
            this.label_year = new System.Windows.Forms.Label();
            this.label_director = new System.Windows.Forms.Label();
            this.label_genre = new System.Windows.Forms.Label();
            this.textBox_movieTitle = new System.Windows.Forms.TextBox();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.textBox_director = new System.Windows.Forms.TextBox();
            this.textBox_rtScore = new System.Windows.Forms.TextBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.label_rtScore = new System.Windows.Forms.Label();
            this.label_boe = new System.Windows.Forms.Label();
            this.textBox_boe = new System.Windows.Forms.TextBox();
            this.comboBox_genre = new System.Windows.Forms.ComboBox();
            this.button_find = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_deleteMovieScreen
            // 
            this.label_deleteMovieScreen.AutoSize = true;
            this.label_deleteMovieScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_deleteMovieScreen.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_deleteMovieScreen.Location = new System.Drawing.Point(72, 16);
            this.label_deleteMovieScreen.Name = "label1";
            this.label_deleteMovieScreen.Size = new System.Drawing.Size(175, 20);
            this.label_deleteMovieScreen.TabIndex = 0;
            this.label_deleteMovieScreen.Text = "Delete Movie Screen";
            // 
            // label_movie
            // 
            this.label_movie.AutoSize = true;
            this.label_movie.Location = new System.Drawing.Point(75, 86);
            this.label_movie.Name = "label_movie";
            this.label_movie.Size = new System.Drawing.Size(87, 20);
            this.label_movie.TabIndex = 1;
            this.label_movie.Text = "Movie Title:";
            // 
            // label_year
            // 
            this.label_year.AutoSize = true;
            this.label_year.Location = new System.Drawing.Point(79, 144);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(47, 20);
            this.label_year.TabIndex = 2;
            this.label_year.Text = "Year:";
            // 
            // label_director
            // 
            this.label_director.AutoSize = true;
            this.label_director.Location = new System.Drawing.Point(79, 221);
            this.label_director.Name = "label_director";
            this.label_director.Size = new System.Drawing.Size(69, 20);
            this.label_director.TabIndex = 3;
            this.label_director.Text = "Director:";
            // 
            // label_genre
            // 
            this.label_genre.AutoSize = true;
            this.label_genre.Location = new System.Drawing.Point(79, 301);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(58, 20);
            this.label_genre.TabIndex = 4;
            this.label_genre.Text = "Genre:";
            // 
            // textBox_movieTitle
            // 
            this.textBox_movieTitle.Location = new System.Drawing.Point(219, 79);
            this.textBox_movieTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_movieTitle.Name = "textBox_movieTitle";
            this.textBox_movieTitle.Size = new System.Drawing.Size(112, 26);
            this.textBox_movieTitle.TabIndex = 5;
            // 
            // yearTextBox2
            // 
            this.textBox_year.Location = new System.Drawing.Point(219, 136);
            this.textBox_year.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_year.Name = "yearTextBox2";
            this.textBox_year.Size = new System.Drawing.Size(112, 26);
            this.textBox_year.TabIndex = 6;
            // 
            // textBox_director
            // 
            this.textBox_director.Location = new System.Drawing.Point(219, 221);
            this.textBox_director.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_director.Name = "textBox_director";
            this.textBox_director.Size = new System.Drawing.Size(112, 26);
            this.textBox_director.TabIndex = 7;
            // 
            // textBox_rtScore
            // 
            this.textBox_rtScore.Location = new System.Drawing.Point(284, 436);
            this.textBox_rtScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_rtScore.Name = "textBox_rtScore";
            this.textBox_rtScore.Size = new System.Drawing.Size(173, 26);
            this.textBox_rtScore.TabIndex = 8;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(75, 500);
            this.button_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(84, 29);
            this.button_delete.TabIndex = 9;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.deleteDeleteMovieButton_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(248, 500);
            this.button_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(84, 29);
            this.button_clear.TabIndex = 10;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.clearDeleteMovieButton_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(713, 500);
            this.button_close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(84, 29);
            this.button_close.TabIndex = 11;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.closeDeleteMovie_Click);
            // 
            // label_rtScore
            // 
            this.label_rtScore.AutoSize = true;
            this.label_rtScore.Location = new System.Drawing.Point(72, 436);
            this.label_rtScore.Name = "label_rtScore";
            this.label_rtScore.Size = new System.Drawing.Size(166, 20);
            this.label_rtScore.TabIndex = 12;
            this.label_rtScore.Text = "Rotten Tomato Score:";
            // 
            // label_boe
            // 
            this.label_boe.AutoSize = true;
            this.label_boe.Location = new System.Drawing.Point(540, 442);
            this.label_boe.Name = "label_boe";
            this.label_boe.Size = new System.Drawing.Size(145, 20);
            this.label_boe.TabIndex = 13;
            this.label_boe.Text = "Box Office Earning:";
            // 
            // textBox_boe
            // 
            this.textBox_boe.Location = new System.Drawing.Point(692, 442);
            this.textBox_boe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_boe.Name = "textBox_boe";
            this.textBox_boe.Size = new System.Drawing.Size(160, 26);
            this.textBox_boe.TabIndex = 14;
            // 
            // comboBox_genre
            // 
            this.comboBox_genre.FormattingEnabled = true;
            this.comboBox_genre.Location = new System.Drawing.Point(219, 292);
            this.comboBox_genre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_genre.Name = "comboBox_genre";
            this.comboBox_genre.Size = new System.Drawing.Size(130, 28);
            this.comboBox_genre.TabIndex = 15;
            // 
            // button_find
            // 
            this.button_find.Location = new System.Drawing.Point(382, 79);
            this.button_find.Name = "button_find";
            this.button_find.Size = new System.Drawing.Size(92, 27);
            this.button_find.TabIndex = 17;
            this.button_find.Text = "Find";
            this.button_find.UseVisualStyleBackColor = true;
            this.button_find.Click += new System.EventHandler(this.findDeleteMovieButton_Click);
            // 
            // DeleteMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.button_find);
            this.Controls.Add(this.comboBox_genre);
            this.Controls.Add(this.textBox_boe);
            this.Controls.Add(this.label_boe);
            this.Controls.Add(this.label_rtScore);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.textBox_rtScore);
            this.Controls.Add(this.textBox_director);
            this.Controls.Add(this.textBox_year);
            this.Controls.Add(this.textBox_movieTitle);
            this.Controls.Add(this.label_genre);
            this.Controls.Add(this.label_director);
            this.Controls.Add(this.label_year);
            this.Controls.Add(this.label_movie);
            this.Controls.Add(this.label_deleteMovieScreen);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DeleteMovie";
            this.Text = "DeleteMovie";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label_deleteMovieScreen;
        private System.Windows.Forms.Label label_movie;
        private System.Windows.Forms.Label label_year;
        private System.Windows.Forms.Label label_director;
        private System.Windows.Forms.Label label_genre;
        private System.Windows.Forms.TextBox textBox_movieTitle;
        private System.Windows.Forms.TextBox textBox_year;
        private System.Windows.Forms.TextBox textBox_director;
        private System.Windows.Forms.TextBox textBox_rtScore;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_rtScore;
        private System.Windows.Forms.Label label_boe;
        private System.Windows.Forms.TextBox textBox_boe;
        private System.Windows.Forms.ComboBox comboBox_genre;
        private System.Windows.Forms.Button button_find;
    }
}