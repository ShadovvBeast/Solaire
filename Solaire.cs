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

        private string RunCommand(string command)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine(command);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            return ParseCmdResponse(cmd.StandardOutput.ReadToEnd(), command);
        }

        private string ParseCmdResponse(string response, string command)
        {
            string dirName = Path.GetDirectoryName(Application.ExecutablePath);
            int startIndex = response.IndexOf(command) + command.Length + 2;
            return response.Substring(startIndex, response.IndexOf(dirName, startIndex) - (3 + startIndex));
        }

        private void Solaire_Shown(object sender, EventArgs e)
        {
            lblSolVerValue.Text = RunCommand("solana --version").Split(' ')[1];
            lblDefaultAddressValue.Text = RunCommand("solana address");
            lblBalanceValue.Text = RunCommand("solana balance");
        }
    }
}
