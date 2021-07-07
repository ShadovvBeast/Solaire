using System.Windows.Forms;

namespace Solaire
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void lblGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ShadovvBeast/Solaire");
        }
    }
}
