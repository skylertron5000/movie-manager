
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(64, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete Movie Screen";
            // 
            // movie
            // 
            this.movie.AutoSize = true;
            this.movie.Location = new System.Drawing.Point(67, 69);
            this.movie.Name = "movie";
            this.movie.Size = new System.Drawing.Size(80, 17);
            this.movie.TabIndex = 1;
            this.movie.Text = "Movie Title:";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(70, 115);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(42, 17);
            this.year.TabIndex = 2;
            this.year.Text = "Year:";
            this.year.Click += new System.EventHandler(this.label3_Click);
            // 
            // director
            // 
            this.director.AutoSize = true;
            this.director.Location = new System.Drawing.Point(70, 177);
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(62, 17);
            this.director.TabIndex = 3;
            this.director.Text = "Director:";
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Location = new System.Drawing.Point(70, 241);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(52, 17);
            this.genre.TabIndex = 4;
            this.genre.Text = "Genre:";
            // 
            // movieTitleTextBox2
            // 
            this.movieTitleTextBox2.Location = new System.Drawing.Point(195, 63);
            this.movieTitleTextBox2.Name = "movieTitleTextBox2";
            this.movieTitleTextBox2.Size = new System.Drawing.Size(100, 22);
            this.movieTitleTextBox2.TabIndex = 5;
            // 
            // yearTextBox2
            // 
            this.yearTextBox2.Location = new System.Drawing.Point(195, 109);
            this.yearTextBox2.Name = "yearTextBox2";
            this.yearTextBox2.Size = new System.Drawing.Size(100, 22);
            this.yearTextBox2.TabIndex = 6;
            // 
            // directorTextBox2
            // 
            this.directorTextBox2.Location = new System.Drawing.Point(195, 177);
            this.directorTextBox2.Name = "directorTextBox2";
            this.directorTextBox2.Size = new System.Drawing.Size(100, 22);
            this.directorTextBox2.TabIndex = 7;
            // 
            // rottenTomatoScoreTextBox2
            // 
            this.rottenTomatoScoreTextBox2.Location = new System.Drawing.Point(252, 349);
            this.rottenTomatoScoreTextBox2.Name = "rottenTomatoScoreTextBox2";
            this.rottenTomatoScoreTextBox2.Size = new System.Drawing.Size(154, 22);
            this.rottenTomatoScoreTextBox2.TabIndex = 8;
            // 
            // deleteButton2
            // 
            this.deleteButton2.Location = new System.Drawing.Point(67, 400);
            this.deleteButton2.Name = "deleteButton2";
            this.deleteButton2.Size = new System.Drawing.Size(75, 23);
            this.deleteButton2.TabIndex = 9;
            this.deleteButton2.Text = "Delete";
            this.deleteButton2.UseVisualStyleBackColor = true;
            this.deleteButton2.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearButton2
            // 
            this.clearButton2.Location = new System.Drawing.Point(220, 400);
            this.clearButton2.Name = "clearButton2";
            this.clearButton2.Size = new System.Drawing.Size(75, 23);
            this.clearButton2.TabIndex = 10;
            this.clearButton2.Text = "Clear";
            this.clearButton2.UseVisualStyleBackColor = true;
            this.clearButton2.Click += new System.EventHandler(this.clearButton2_Click);
            // 
            // closeButton2
            // 
            this.closeButton2.Location = new System.Drawing.Point(634, 400);
            this.closeButton2.Name = "closeButton2";
            this.closeButton2.Size = new System.Drawing.Size(75, 23);
            this.closeButton2.TabIndex = 11;
            this.closeButton2.Text = "Close";
            this.closeButton2.UseVisualStyleBackColor = true;
            this.closeButton2.Click += new System.EventHandler(this.close2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Rotten Tomato Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Box Office Earning:";
            // 
            // boxOfficeEarningTextBox2
            // 
            this.boxOfficeEarningTextBox2.Location = new System.Drawing.Point(615, 354);
            this.boxOfficeEarningTextBox2.Name = "boxOfficeEarningTextBox2";
            this.boxOfficeEarningTextBox2.Size = new System.Drawing.Size(143, 22);
            this.boxOfficeEarningTextBox2.TabIndex = 14;
            // 
            // genreComboBox2
            // 
            this.genreComboBox2.FormattingEnabled = true;
            this.genreComboBox2.Location = new System.Drawing.Point(195, 234);
            this.genreComboBox2.Name = "genreComboBox2";
            this.genreComboBox2.Size = new System.Drawing.Size(116, 24);
            this.genreComboBox2.TabIndex = 15;
            // 
            // DeleteMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}