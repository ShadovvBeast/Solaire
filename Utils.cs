using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Solaire
{
    class Utils
    {
        public static Dictionary<string, string> dClusterUrlToName = new Dictionary<string, string>()
        {
            {"https://api.devnet.solana.com", "Devnet" },
            {"https://api.testnet.solana.com", "Testnet" },
            {"https://api.mainnet-beta.solana.com", "Mainnet Beta" }
        };

        public static Dictionary<string, string> dClusteNameToUrl = new Dictionary<string, string>()
        {
            {"Devnet", "https://api.devnet.solana.com" },
            {"Testnet", "https://api.testnet.solana.com" },
            {"Mainnet Beta", "https://api.mainnet-beta.solana.com" }
        };

        public static string ParseCmdResponse(string response, string command)
        {
            string dirName = Path.GetDirectoryName(Application.ExecutablePath);
            int startIndex = response.IndexOf(command) + command.Length + 2;
            int dirnameIndex = response.IndexOf(dirName, startIndex);
            return response.Substring(startIndex, dirnameIndex - (2 + startIndex)).Trim();
        }

        public static void ExecuteAsAdmin(string fileName, string arguments)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = fileName;
            proc.StartInfo.Arguments = arguments;
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Verb = "runas";
            proc.Start();
            proc.WaitForExit();
        }

        public static string RunCommand(string command)
        {
            string dummy;
            return RunCommand(command, out dummy);
        }

        public static string RunCommand(string command, out string error)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.RedirectStandardError = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine(command);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            var output = cmd.StandardOutput.ReadToEnd();
            error = cmd.StandardError.ReadToEnd();
            cmd.WaitForExit();
            return ParseCmdResponse(output, command);
        }

        public static string getConfigItemValue(string item)
        {
            return item.Split(new[] { ": " }, StringSplitOptions.RemoveEmptyEntries)[1].Trim();
        }
    }
}
