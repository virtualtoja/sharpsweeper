using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void gitLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenUrl("github.com/virtualtoja/sharpsweeper");
        }

        private void OpenUrl(string url)
        {
            Process.Start("cmd", $"/c explorer \"C:\\\"");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
