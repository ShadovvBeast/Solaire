using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Solaire
{
    class Utils
    {
        public static string ParseCmdResponse(string response, string command)
        {
            string dirName = Path.GetDirectoryName(Application.ExecutablePath);
            int startIndex = response.IndexOf(command) + command.Length + 2;
            int dirnameIndex = response.IndexOf(dirName, startIndex);
            if (dirnameIndex == -1)
                throw new Exception("Error parsing cmd response");
            return response.Substring(startIndex, dirnameIndex - (3 + startIndex));
        }

        public static string RunCommand(string command)
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
    }
}
