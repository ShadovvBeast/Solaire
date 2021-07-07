using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Solaire
{
    public partial class Solaire : Form
    {
        string address;
        char cluster;
        public Solaire()
        {
            InitializeComponent();
        }

        private void Solaire_Load(object sender, EventArgs e)
        {
            lblSolVerValue.Text = "Initializing...";
        }       
        private void Init()
        {
            Cursor.Current = Cursors.WaitCursor;
            lblSolVerValue.Text = Utils.RunCommand("solana --version").Split(' ')[1];
            address = lblDefaultAddressValue.Text = Utils.RunCommand("solana address");
            lblBalanceValue.Text = Utils.RunCommand("solana balance");
            var configArr = Utils.RunCommand("solana config get").Split('\n');
            var clusterName = lblClusterValue.Text = Utils.dClusterUrlToName[Utils.getConfigItemValue(configArr[1])];
            cluster = clusterName.ToLower()[0];
            if (cluster == 'm')
                btnAirdrop.Enabled = false;
            else
                btnAirdrop.Enabled = true;
            Cursor.Current = Cursors.Default;
        }
        private void Solaire_Shown(object sender, EventArgs e)
        {
            Init();
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
            var dlgrOptions = (new Options()).ShowDialog();
            if (dlgrOptions == DialogResult.Cancel)
            {
                Init();
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAirdrop_Click(object sender, EventArgs e)
        {
            var dlgAirDrop = new Airdrop(cluster);
            var dlgrAirdrop = dlgAirDrop.ShowDialog();
            if (dlgrAirdrop == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                Utils.RunCommand("solana airdrop " + ((NumericUpDown)dlgAirDrop.Controls.Find("nudAmount", true)[0]).Value + " " + address);
                lblBalanceValue.Text = Utils.RunCommand("solana balance");
                Cursor.Current = Cursors.Default;
            }

        }
    }
}
