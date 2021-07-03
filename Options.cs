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
        }

        private string getConfigItemValue(string item)
        {
            return item.Split(new[] { ": " }, StringSplitOptions.RemoveEmptyEntries)[1].Trim();
        }
    }
}
