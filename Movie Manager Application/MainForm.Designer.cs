
namespace Movie_Manager_Application
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_moviesMasterList = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.maintanceToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1015, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.fileToolStripMenuItem.Text = "File ";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // maintanceToolStripMenuItem
            // 
            this.maintanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMovieToolStripMenuItem,
            this.updateMovieToolStripMenuItem,
            this.deleteMovieToolStripMenuItem});
            this.maintanceToolStripMenuItem.Name = "maintanceToolStripMenuItem";
            this.maintanceToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.maintanceToolStripMenuItem.Text = "Maintenance";
            // 
            // addMovieToolStripMenuItem
            // 
            this.addMovieToolStripMenuItem.Name = "addMovieToolStripMenuItem";
            this.addMovieToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addMovieToolStripMenuItem.Text = "Add Movie";
            this.addMovieToolStripMenuItem.Click += new System.EventHandler(this.addMovieToolStripMenuItem_Click);
            // 
            // updateMovieToolStripMenuItem
            // 
            this.updateMovieToolStripMenuItem.Name = "updateMovieToolStripMenuItem";
            this.updateMovieToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.updateMovieToolStripMenuItem.Text = "Update Movie";
            this.updateMovieToolStripMenuItem.Click += new System.EventHandler(this.updateMovieToolStripMenuItem_Click);
            // 
            // deleteMovieToolStripMenuItem
            // 
            this.deleteMovieToolStripMenuItem.Name = "deleteMovieToolStripMenuItem";
            this.deleteMovieToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deleteMovieToolStripMenuItem.Text = "Delete Movie";
            this.deleteMovieToolStripMenuItem.Click += new System.EventHandler(this.deleteMovieToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label_moviesMasterList
            // 
            this.label_moviesMasterList.AutoSize = true;
            this.label_moviesMasterList.Location = new System.Drawing.Point(12, 41);
            this.label_moviesMasterList.Name = "label_moviesMasterList";
            this.label_moviesMasterList.Size = new System.Drawing.Size(125, 17);
            this.label_moviesMasterList.TabIndex = 1;
            this.label_moviesMasterList.Text = "Movies Master List";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 450);
            this.Controls.Add(this.label_moviesMasterList);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Movie Manager Application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label_moviesMasterList;
        private System.Windows.Forms.ToolStripMenuItem addMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMovieToolStripMenuItem;
    }
}
