
namespace Solaire1
{
    partial class Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.lblConfigFileText = new System.Windows.Forms.Label();
            this.lblConfigFileValue = new System.Windows.Forms.Label();
            this.lblClusterText = new System.Windows.Forms.Label();
            this.lblCommitmentValue = new System.Windows.Forms.Label();
            this.lblCommitmentText = new System.Windows.Forms.Label();
            this.cbCluster = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblConfigFileText
            // 
            this.lblConfigFileText.AutoSize = true;
            this.lblConfigFileText.Location = new System.Drawing.Point(12, 19);
            this.lblConfigFileText.Name = "lblConfigFileText";
            this.lblConfigFileText.Size = new System.Drawing.Size(59, 13);
            this.lblConfigFileText.TabIndex = 0;
            this.lblConfigFileText.Text = "Config File:";
            // 
            // lblConfigFileValue
            // 
            this.lblConfigFileValue.AutoSize = true;
            this.lblConfigFileValue.Location = new System.Drawing.Point(77, 19);
            this.lblConfigFileValue.Name = "lblConfigFileValue";
            this.lblConfigFileValue.Size = new System.Drawing.Size(61, 13);
            this.lblConfigFileValue.TabIndex = 1;
            this.lblConfigFileValue.Text = "Initializing...";
            // 
            // lblClusterText
            // 
            this.lblClusterText.AutoSize = true;
            this.lblClusterText.Location = new System.Drawing.Point(12, 41);
            this.lblClusterText.Name = "lblClusterText";
            this.lblClusterText.Size = new System.Drawing.Size(42, 13);
            this.lblClusterText.TabIndex = 2;
            this.lblClusterText.Text = "Cluster:";
            // 
            // lblCommitmentValue
            // 
            this.lblCommitmentValue.AutoSize = true;
            this.lblCommitmentValue.Location = new System.Drawing.Point(77, 66);
            this.lblCommitmentValue.Name = "lblCommitmentValue";
            this.lblCommitmentValue.Size = new System.Drawing.Size(61, 13);
            this.lblCommitmentValue.TabIndex = 5;
            this.lblCommitmentValue.Text = "Initializing...";
            // 
            // lblCommitmentText
            // 
            this.lblCommitmentText.AutoSize = true;
            this.lblCommitmentText.Location = new System.Drawing.Point(12, 66);
            this.lblCommitmentText.Name = "lblCommitmentText";
            this.lblCommitmentText.Size = new System.Drawing.Size(67, 13);
            this.lblCommitmentText.TabIndex = 4;
            this.lblCommitmentText.Text = "Commitment:";
            // 
            // cbCluster
            // 
            this.cbCluster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCluster.FormattingEnabled = true;
            this.cbCluster.Items.AddRange(new object[] {
            "Devnet",
            "Testnet",
            "Mainnet Beta"});
            this.cbCluster.Location = new System.Drawing.Point(70, 38);
            this.cbCluster.Name = "cbCluster";
            this.cbCluster.Size = new System.Drawing.Size(121, 21);
            this.cbCluster.TabIndex = 6;
            this.cbCluster.SelectedIndexChanged += new System.EventHandler(this.cbCluster_SelectedIndexChanged);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(690, 119);
            this.Controls.Add(this.cbCluster);
            this.Controls.Add(this.lblCommitmentValue);
            this.Controls.Add(this.lblCommitmentText);
            this.Controls.Add(this.lblClusterText);
            this.Controls.Add(this.lblConfigFileValue);
            this.Controls.Add(this.lblConfigFileText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.Shown += new System.EventHandler(this.Options_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfigFileText;
        private System.Windows.Forms.Label lblConfigFileValue;
        private System.Windows.Forms.Label lblClusterText;
        private System.Windows.Forms.Label lblCommitmentValue;
        private System.Windows.Forms.Label lblCommitmentText;
        private System.Windows.Forms.ComboBox cbCluster;
    }
}