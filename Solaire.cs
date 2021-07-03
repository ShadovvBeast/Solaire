using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Solaire1
{
    public partial class Solaire : Form
    {
        public Solaire()
        {
            InitializeComponent();
        }

        private void Solaire_Load(object sender, EventArgs e)
        {
            lblSolVerValue.Text = "Initializing...";
        }       

        private void Solaire_Shown(object sender, EventArgs e)
        {
            lblSolVerValue.Text = Utils.RunCommand("solana --version").Split(' ')[1];
            lblDefaultAddressValue.Text = Utils.RunCommand("solana address");
            lblBalanceValue.Text = Utils.RunCommand("solana balance");
        }

        private void btnLoadAddress_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Open the keypair file";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(fdlg.FileName);
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Options()).ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
