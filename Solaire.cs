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
        string path;
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
            var configArr = Utils.RunCommand("solana config get").Split('\n');
            if (path == null)
                path = Utils.getConfigItemValue(configArr[3]);
            address = lblAddressValue.Text = Utils.RunCommand("solana address --keypair " + path);
            lblBalanceValue.Text = Utils.RunCommand("solana balance " + path);
            
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
                string error;
                Utils.RunCommand("solana airdrop " + ((NumericUpDown)dlgAirDrop.Controls.Find("nudAmount", true)[0]).Value + " " + address, out error).Split('\n');
                if (error.Length > 0)
                    MessageBox.Show(error, "An error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblBalanceValue.Text = Utils.RunCommand("solana balance");
                Cursor.Current = Cursors.Default;
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new About()).ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Open the keypair file";
            //fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                path = fdlg.FileName;
                Init();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdlg = new SaveFileDialog();
            sfdlg.Title = "Save keypair file";
            sfdlg.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            sfdlg.FilterIndex = 1;
            sfdlg.RestoreDirectory = true;
            if (sfdlg.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                var newArr = Utils.RunCommand("solana-keygen new --no-passphrase -o " + sfdlg.FileName).Split('\n');
                address = Utils.getConfigItemValue(newArr[3]);
                path = sfdlg.FileName;
                MessageBox.Show("Please save this seed phrase:" + Environment.NewLine + newArr[6], "Seed phrase", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Init();
            }

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            var dlgTransfer = new Transfer(decimal.Parse(lblBalanceValue.Text.Split(' ')[0]));
            var dlgrTransfer = dlgTransfer.ShowDialog();
            if (dlgrTransfer == DialogResult.OK)
            {
                var to_address = ((TextBox)dlgTransfer.Controls.Find("txtAddress", true)[0]).Text;
                var amount = ((NumericUpDown)dlgTransfer.Controls.Find("nudAmount", true)[0]).Value;
                var response = Utils.RunCommand("solana transfer --from " + path + " " + to_address + " " + amount + " --allow-unfunded-recipient --fee-payer " + path);
                MessageBox.Show(response, "Signature", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Init();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void btnCopyAddress_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(address);
        }
    }
}
