
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
            this.label1 = new System.Windows.Forms.Label();
            this.movie = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.director = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.Label();
            this.movieTitleTextBox2 = new System.Windows.Forms.TextBox();
            this.yearTextBox2 = new System.Windows.Forms.TextBox();
            this.directorTextBox2 = new System.Windows.Forms.TextBox();
            this.rottenTomatoScoreTextBox2 = new System.Windows.Forms.TextBox();
            this.deleteButton2 = new System.Windows.Forms.Button();
            this.clearButton2 = new System.Windows.Forms.Button();
            this.closeButton2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boxOfficeEarningTextBox2 = new System.Windows.Forms.TextBox();
            this.genreComboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(72, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete Movie Screen";
            // 
            // movie
            // 
            this.movie.AutoSize = true;
            this.movie.Location = new System.Drawing.Point(75, 86);
            this.movie.Name = "movie";
            this.movie.Size = new System.Drawing.Size(87, 20);
            this.movie.TabIndex = 1;
            this.movie.Text = "Movie Title:";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(79, 144);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(47, 20);
            this.year.TabIndex = 2;
            this.year.Text = "Year:";
            // 
            // director
            // 
            this.director.AutoSize = true;
            this.director.Location = new System.Drawing.Point(79, 221);
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(69, 20);
            this.director.TabIndex = 3;
            this.director.Text = "Director:";
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Location = new System.Drawing.Point(79, 301);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(58, 20);
            this.genre.TabIndex = 4;
            this.genre.Text = "Genre:";
            // 
            // movieTitleTextBox2
            // 
            this.movieTitleTextBox2.Location = new System.Drawing.Point(219, 79);
            this.movieTitleTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.movieTitleTextBox2.Name = "movieTitleTextBox2";
            this.movieTitleTextBox2.Size = new System.Drawing.Size(112, 26);
            this.movieTitleTextBox2.TabIndex = 5;
            // 
            // yearTextBox2
            // 
            this.yearTextBox2.Location = new System.Drawing.Point(219, 136);
            this.yearTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yearTextBox2.Name = "yearTextBox2";
            this.yearTextBox2.Size = new System.Drawing.Size(112, 26);
            this.yearTextBox2.TabIndex = 6;
            // 
            // directorTextBox2
            // 
            this.directorTextBox2.Location = new System.Drawing.Point(219, 221);
            this.directorTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.directorTextBox2.Name = "directorTextBox2";
            this.directorTextBox2.Size = new System.Drawing.Size(112, 26);
            this.directorTextBox2.TabIndex = 7;
            // 
            // rottenTomatoScoreTextBox2
            // 
            this.rottenTomatoScoreTextBox2.Location = new System.Drawing.Point(284, 436);
            this.rottenTomatoScoreTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rottenTomatoScoreTextBox2.Name = "rottenTomatoScoreTextBox2";
            this.rottenTomatoScoreTextBox2.Size = new System.Drawing.Size(173, 26);
            this.rottenTomatoScoreTextBox2.TabIndex = 8;
            // 
            // deleteButton2
            // 
            this.deleteButton2.Location = new System.Drawing.Point(75, 500);
            this.deleteButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteButton2.Name = "deleteButton2";
            this.deleteButton2.Size = new System.Drawing.Size(84, 29);
            this.deleteButton2.TabIndex = 9;
            this.deleteButton2.Text = "Delete";
            this.deleteButton2.UseVisualStyleBackColor = true;
            this.deleteButton2.Click += new System.EventHandler(this.deleteDeleteMovieButton_Click);
            // 
            // clearButton2
            // 
            this.clearButton2.Location = new System.Drawing.Point(248, 500);
            this.clearButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearButton2.Name = "clearButton2";
            this.clearButton2.Size = new System.Drawing.Size(84, 29);
            this.clearButton2.TabIndex = 10;
            this.clearButton2.Text = "Clear";
            this.clearButton2.UseVisualStyleBackColor = true;
            this.clearButton2.Click += new System.EventHandler(this.clearDeleteMovieButton_Click);
            // 
            // closeButton2
            // 
            this.closeButton2.Location = new System.Drawing.Point(713, 500);
            this.closeButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closeButton2.Name = "closeButton2";
            this.closeButton2.Size = new System.Drawing.Size(84, 29);
            this.closeButton2.TabIndex = 11;
            this.closeButton2.Text = "Close";
            this.closeButton2.UseVisualStyleBackColor = true;
            this.closeButton2.Click += new System.EventHandler(this.closeDeleteMovie_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Rotten Tomato Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Box Office Earning:";
            // 
            // boxOfficeEarningTextBox2
            // 
            this.boxOfficeEarningTextBox2.Location = new System.Drawing.Point(692, 442);
            this.boxOfficeEarningTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxOfficeEarningTextBox2.Name = "boxOfficeEarningTextBox2";
            this.boxOfficeEarningTextBox2.Size = new System.Drawing.Size(160, 26);
            this.boxOfficeEarningTextBox2.TabIndex = 14;
            // 
            // genreComboBox2
            // 
            this.genreComboBox2.FormattingEnabled = true;
            this.genreComboBox2.Location = new System.Drawing.Point(219, 292);
            this.genreComboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genreComboBox2.Name = "genreComboBox2";
            this.genreComboBox2.Size = new System.Drawing.Size(130, 28);
            this.genreComboBox2.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(382, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 27);
            this.button2.TabIndex = 17;
            this.button2.Text = "Find";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.findDeleteMovieButton_Click);
            // 
            // DeleteMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.genreComboBox2);
            this.Controls.Add(this.boxOfficeEarningTextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.closeButton2);
            this.Controls.Add(this.clearButton2);
            this.Controls.Add(this.deleteButton2);
            this.Controls.Add(this.rottenTomatoScoreTextBox2);
            this.Controls.Add(this.directorTextBox2);
            this.Controls.Add(this.yearTextBox2);
            this.Controls.Add(this.movieTitleTextBox2);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.director);
            this.Controls.Add(this.year);
            this.Controls.Add(this.movie);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DeleteMovie";
            this.Text = "DeleteMovie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label movie;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label director;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.TextBox movieTitleTextBox2;
        private System.Windows.Forms.TextBox yearTextBox2;
        private System.Windows.Forms.TextBox directorTextBox2;
        private System.Windows.Forms.TextBox rottenTomatoScoreTextBox2;
        private System.Windows.Forms.Button deleteButton2;
        private System.Windows.Forms.Button clearButton2;
        private System.Windows.Forms.Button closeButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxOfficeEarningTextBox2;
        private System.Windows.Forms.ComboBox genreComboBox2;
        private System.Windows.Forms.Button button2;
    }
}