
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
            this.label_movieTitle = new System.Windows.Forms.Label();
            this.label_year = new System.Windows.Forms.Label();
            this.label_director = new System.Windows.Forms.Label();
            this.label_genre = new System.Windows.Forms.Label();
            this.label_rtScore = new System.Windows.Forms.Label();
            this.label_boe = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_find = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_updateMovieScreen
            // 
            this.label_updateMovieScreen.AutoSize = true;
            this.label_updateMovieScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_updateMovieScreen.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_updateMovieScreen.Location = new System.Drawing.Point(45, 13);
            this.label_updateMovieScreen.Name = "label_updateMovieScreen";
            this.label_updateMovieScreen.Size = new System.Drawing.Size(190, 25);
            this.label_updateMovieScreen.TabIndex = 10;
            this.label_updateMovieScreen.Text = "Update Movie Screen";
            // 
            // label_movieTitle
            // 
            this.label_movieTitle.AutoSize = true;
            this.label_movieTitle.Location = new System.Drawing.Point(45, 60);
            this.label_movieTitle.Name = "label_movieTitle";
            this.label_movieTitle.Size = new System.Drawing.Size(80, 17);
            this.label_movieTitle.TabIndex = 11;
            this.label_movieTitle.Text = "Movie Title:";
            // 
            // label_year
            // 
            this.label_year.AutoSize = true;
            this.label_year.Location = new System.Drawing.Point(45, 100);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(38, 17);
            this.label_year.TabIndex = 12;
            this.label_year.Text = "Year:";
            // 
            // label_director
            // 
            this.label_director.AutoSize = true;
            this.label_director.Location = new System.Drawing.Point(45, 140);
            this.label_director.Name = "label_director";
            this.label_director.Size = new System.Drawing.Size(62, 17);
            this.label_director.TabIndex = 13;
            this.label_director.Text = "Director:";
            // 
            // label_genre
            // 
            this.label_genre.AutoSize = true;
            this.label_genre.Location = new System.Drawing.Point(45, 180);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(52, 17);
            this.label_genre.TabIndex = 14;
            this.label_genre.Text = "Genre:";
            // 
            // label_rtScore
            // 
            this.label_rtScore.AutoSize = true;
            this.label_rtScore.Location = new System.Drawing.Point(45, 330);
            this.label_rtScore.Name = "label_rtScore";
            this.label_rtScore.Size = new System.Drawing.Size(147, 17);
            this.label_rtScore.TabIndex = 15;
            this.label_rtScore.Text = "Rotten Tomato Score:";
            // 
            // label_boe
            // 
            this.label_boe.AutoSize = true;
            this.label_boe.Location = new System.Drawing.Point(420, 330);
            this.label_boe.Name = "label_boe";
            this.label_boe.Size = new System.Drawing.Size(129, 17);
            this.label_boe.TabIndex = 16;
            this.label_boe.Text = "Box Office Earning:";
            // 
            // textBox_movieTitle
            // 
            this.textBox_movieTitle.Location = new System.Drawing.Point(130, 60);
            this.textBox_movieTitle.Name = "textBox_movieTitle";
            this.textBox_movieTitle.Size = new System.Drawing.Size(200, 22);
            this.textBox_movieTitle.TabIndex = 0;
            // 
            // textBox_year
            // 
            this.textBox_year.Location = new System.Drawing.Point(130, 100);
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(200, 22);
            this.textBox_year.TabIndex = 1;
            // 
            // textBox_director
            // 
            this.textBox_director.Location = new System.Drawing.Point(130, 140);
            this.textBox_director.Name = "textBox_director";
            this.textBox_director.Size = new System.Drawing.Size(200, 22);
            this.textBox_director.TabIndex = 2;
            // 
            // comboBox_genre
            // 
            this.comboBox_genre.FormattingEnabled = true;
            this.comboBox_genre.Location = new System.Drawing.Point(130, 180);
            this.comboBox_genre.Name = "comboBox_genre";
            this.comboBox_genre.Size = new System.Drawing.Size(200, 22);
            this.comboBox_genre.TabIndex = 3;
            // 
            // textBox_rtScore
            // 
            this.textBox_rtScore.Location = new System.Drawing.Point(200, 330);
            this.textBox_rtScore.Name = "textBox_rtScore";
            this.textBox_rtScore.Size = new System.Drawing.Size(150, 22);
            this.textBox_rtScore.TabIndex = 4;
            // 
            // textBox_boe
            // 
            this.textBox_boe.Location = new System.Drawing.Point(560, 330);
            this.textBox_boe.Name = "textBox_boe";
            this.textBox_boe.Size = new System.Drawing.Size(200, 22);
            this.textBox_boe.TabIndex = 5;
            // 
            // button_find
            // 
            this.button_find.Location = new System.Drawing.Point(360, 60);
            this.button_find.Name = "button_find";
            this.button_find.Size = new System.Drawing.Size(75, 23);
            this.button_find.TabIndex = 9;
            this.button_find.Text = "Find";
            this.button_find.UseVisualStyleBackColor = true;
            this.button_find.Click += new System.EventHandler(this.findUpdateMovieButton_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(130, 394);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 6;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.updateUpdateMovieButton_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(243, 394);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 7;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.clearUpdateMovieButton_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(622, 394);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 8;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.closeUpdateMovieButton_Click);
            // 
            // UpdateMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_find);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.label_boe);
            this.Controls.Add(this.label_rtScore);
            this.Controls.Add(this.label_genre);
            this.Controls.Add(this.label_director);
            this.Controls.Add(this.label_year);
            this.Controls.Add(this.label_movieTitle);
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
        private System.Windows.Forms.Label label_movieTitle;
        private System.Windows.Forms.Label label_year;
        private System.Windows.Forms.Label label_director;
        private System.Windows.Forms.Label label_genre;
        private System.Windows.Forms.Label label_rtScore;
        private System.Windows.Forms.Label label_boe;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_find;
    }
}
