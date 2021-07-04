using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solaire1
{
    public partial class Options : Form
    {
        bool initialized = false;
        int prevSelectedIndex;
        Dictionary<string, string> dClusterUrlToName = new Dictionary<string, string>()
        {
            {"https://api.devnet.solana.com", "Devnet" },
            {"https://api.testnet.solana.com", "Testnet" },
            {"https://api.mainnet-beta.solana.com", "Mainnet Beta" }
        };
        
        Dictionary<string, string> dClusteNameToUrl = new Dictionary<string, string>()
        {
            {"Devnet", "https://api.devnet.solana.com" },
            {"Testnet", "https://api.testnet.solana.com" },
            {"Mainnet Beta", "https://api.mainnet-beta.solana.com" }
        };

        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {

        }

        private void Options_Shown(object sender, EventArgs e)
        {
            var configStr = Utils.RunCommand("solana config get");
            var configArr = configStr.Split('\n');

            lblConfigFileValue.Text = getConfigItemValue(configArr[0]);
            cbCluster.SelectedItem = dClusterUrlToName[getConfigItemValue(configArr[1])];
            prevSelectedIndex = cbCluster.SelectedIndex;
            lblCommitmentValue.Text = getConfigItemValue(configArr[4]);
            initialized = true;
        }

        private string getConfigItemValue(string item)
        {
            return item.Split(new[] { ": " }, StringSplitOptions.RemoveEmptyEntries)[1].Trim();
        }

        private void cbCluster_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (initialized && cbCluster.SelectedIndex != prevSelectedIndex)
            {
                var dlgResult = MessageBox.Show("Are you sure you want to change the cluster?", "Changing cluster", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgResult == DialogResult.Yes)
                {
                    Utils.RunCommand("solana config set --url " + dClusteNameToUrl[cbCluster.SelectedItem.ToString()]);
                    prevSelectedIndex = cbCluster.SelectedIndex;
                }
                else
                    cbCluster.SelectedIndex = prevSelectedIndex;
            }
        }
    }
}
