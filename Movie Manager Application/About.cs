using System;
using System.Windows.Forms;

namespace Movie_Manager_Application
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
