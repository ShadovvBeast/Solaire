using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solaire
{
    public partial class Options : Form
    {
        bool initialized = false;
        int prevSelectedIndex;

        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {

        }

        private void Options_Shown(object sender, EventArgs e)
        {
            var configArr = Utils.RunCommand("solana config get").Split('\n');

            lblConfigFileValue.Text = Utils.getConfigItemValue(configArr[0]);
            cbCluster.SelectedItem = Utils.dClusterUrlToName[Utils.getConfigItemValue(configArr[1])];
            prevSelectedIndex = cbCluster.SelectedIndex;
            lblCommitmentValue.Text = Utils.getConfigItemValue(configArr[4]);
            initialized = true;
        }

        private void cbCluster_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (initialized && cbCluster.SelectedIndex != prevSelectedIndex)
            {
                var dlgResult = MessageBox.Show("Are you sure you want to change the cluster?", "Changing cluster", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgResult == DialogResult.Yes)
                {
                    Utils.RunCommand("solana config set --url " + Utils.dClusteNameToUrl[cbCluster.SelectedItem.ToString()]);
                    prevSelectedIndex = cbCluster.SelectedIndex;
                }
                else
                    cbCluster.SelectedIndex = prevSelectedIndex;
            }
        }
    }
}
