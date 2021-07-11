namespace Solaire
{
    partial class Solaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Solaire));
            this.lblSolVerText = new System.Windows.Forms.Label();
            this.lblSolVerValue = new System.Windows.Forms.Label();
            this.lblAddressTxt = new System.Windows.Forms.Label();
            this.lblAddressValue = new System.Windows.Forms.Label();
            this.lblBalanceValue = new System.Windows.Forms.Label();
            this.lblCurrentBalanceTxt = new System.Windows.Forms.Label();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAirdrop = new System.Windows.Forms.Button();
            this.lblClusterValue = new System.Windows.Forms.Label();
            this.lblClusterText = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCopyAddress = new System.Windows.Forms.Button();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSolVerText
            // 
            this.lblSolVerText.AutoSize = true;
            this.lblSolVerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSolVerText.Location = new System.Drawing.Point(12, 33);
            this.lblSolVerText.Name = "lblSolVerText";
            this.lblSolVerText.Size = new System.Drawing.Size(244, 37);
            this.lblSolVerText.TabIndex = 0;
            this.lblSolVerText.Text = "Solana Version:";
            // 
            // lblSolVerValue
            // 
            this.lblSolVerValue.AutoSize = true;
            this.lblSolVerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSolVerValue.Location = new System.Drawing.Point(249, 33);
            this.lblSolVerValue.Name = "lblSolVerValue";
            this.lblSolVerValue.Size = new System.Drawing.Size(0, 37);
            this.lblSolVerValue.TabIndex = 1;
            // 
            // lblAddressTxt
            // 
            this.lblAddressTxt.AutoSize = true;
            this.lblAddressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAddressTxt.Location = new System.Drawing.Point(12, 136);
            this.lblAddressTxt.Name = "lblAddressTxt";
            this.lblAddressTxt.Size = new System.Drawing.Size(144, 37);
            this.lblAddressTxt.TabIndex = 2;
            this.lblAddressTxt.Text = "Address:";
            // 
            // lblAddressValue
            // 
            this.lblAddressValue.AutoSize = true;
            this.lblAddressValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAddressValue.Location = new System.Drawing.Point(16, 173);
            this.lblAddressValue.Name = "lblAddressValue";
            this.lblAddressValue.Size = new System.Drawing.Size(0, 17);
            this.lblAddressValue.TabIndex = 3;
            // 
            // lblBalanceValue
            // 
            this.lblBalanceValue.AutoSize = true;
            this.lblBalanceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBalanceValue.Location = new System.Drawing.Point(152, 201);
            this.lblBalanceValue.Name = "lblBalanceValue";
            this.lblBalanceValue.Size = new System.Drawing.Size(184, 37);
            this.lblBalanceValue.TabIndex = 5;
            this.lblBalanceValue.Text = "Initializing...";
            // 
            // lblCurrentBalanceTxt
            // 
            this.lblCurrentBalanceTxt.AutoSize = true;
            this.lblCurrentBalanceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCurrentBalanceTxt.Location = new System.Drawing.Point(11, 201);
            this.lblCurrentBalanceTxt.Name = "lblCurrentBalanceTxt";
            this.lblCurrentBalanceTxt.Size = new System.Drawing.Size(141, 37);
            this.lblCurrentBalanceTxt.TabIndex = 4;
            this.lblCurrentBalanceTxt.Text = "Balance:";
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(433, 24);
            this.msMain.TabIndex = 7;
            this.msMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.newToolStripMenuItem.Text = "&New Keypair";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.openToolStripMenuItem.Text = "&Load Keypair";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(182, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(113, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnAirdrop
            // 
            this.btnAirdrop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAirdrop.FlatAppearance.BorderSize = 0;
            this.btnAirdrop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAirdrop.Location = new System.Drawing.Point(161, 143);
            this.btnAirdrop.Name = "btnAirdrop";
            this.btnAirdrop.Size = new System.Drawing.Size(102, 25);
            this.btnAirdrop.TabIndex = 8;
            this.btnAirdrop.Text = "Airdrop";
            this.btnAirdrop.UseVisualStyleBackColor = false;
            this.btnAirdrop.Click += new System.EventHandler(this.btnAirdrop_Click);
            // 
            // lblClusterValue
            // 
            this.lblClusterValue.AutoSize = true;
            this.lblClusterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblClusterValue.Location = new System.Drawing.Point(134, 82);
            this.lblClusterValue.Name = "lblClusterValue";
            this.lblClusterValue.Size = new System.Drawing.Size(0, 37);
            this.lblClusterValue.TabIndex = 10;
            // 
            // lblClusterText
            // 
            this.lblClusterText.AutoSize = true;
            this.lblClusterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblClusterText.Location = new System.Drawing.Point(11, 82);
            this.lblClusterText.Name = "lblClusterText";
            this.lblClusterText.Size = new System.Drawing.Size(127, 37);
            this.lblClusterText.TabIndex = 9;
            this.lblClusterText.Text = "Cluster:";
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTransfer.Location = new System.Drawing.Point(19, 254);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(102, 25);
            this.btnTransfer.TabIndex = 11;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRefresh.BackgroundImage = global::Solaire.Properties.Resources.refresh24;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Location = new System.Drawing.Point(393, 27);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(30, 30);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCopyAddress
            // 
            this.btnCopyAddress.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCopyAddress.BackgroundImage = global::Solaire.Properties.Resources.copy;
            this.btnCopyAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCopyAddress.FlatAppearance.BorderSize = 0;
            this.btnCopyAddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopyAddress.Location = new System.Drawing.Point(391, 166);
            this.btnCopyAddress.Name = "btnCopyAddress";
            this.btnCopyAddress.Size = new System.Drawing.Size(30, 30);
            this.btnCopyAddress.TabIndex = 13;
            this.btnCopyAddress.UseVisualStyleBackColor = false;
            this.btnCopyAddress.Click += new System.EventHandler(this.btnCopyAddress_Click);
            // 
            // Solaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(433, 622);
            this.Controls.Add(this.btnCopyAddress);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.lblClusterValue);
            this.Controls.Add(this.lblClusterText);
            this.Controls.Add(this.btnAirdrop);
            this.Controls.Add(this.lblBalanceValue);
            this.Controls.Add(this.lblCurrentBalanceTxt);
            this.Controls.Add(this.lblAddressValue);
            this.Controls.Add(this.lblAddressTxt);
            this.Controls.Add(this.lblSolVerValue);
            this.Controls.Add(this.lblSolVerText);
            this.Controls.Add(this.msMain);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.MaximizeBox = false;
            this.Name = "Solaire";
            this.Text = " Solaire";
            this.Load += new System.EventHandler(this.Solaire_Load);
            this.Shown += new System.EventHandler(this.Solaire_Shown);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSolVerText;
        private System.Windows.Forms.Label lblSolVerValue;
        private System.Windows.Forms.Label lblAddressTxt;
        private System.Windows.Forms.Label lblAddressValue;
        private System.Windows.Forms.Label lblBalanceValue;
        private System.Windows.Forms.Label lblCurrentBalanceTxt;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnAirdrop;
        private System.Windows.Forms.Label lblClusterValue;
        private System.Windows.Forms.Label lblClusterText;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCopyAddress;
    }
}

