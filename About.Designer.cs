
namespace Solaire
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.pbPraise = new System.Windows.Forms.PictureBox();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblBelow = new System.Windows.Forms.Label();
            this.lblGithub = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbPraise)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPraise
            // 
            this.pbPraise.Image = global::Solaire.Properties.Resources.praise_the_sun;
            this.pbPraise.Location = new System.Drawing.Point(95, 12);
            this.pbPraise.Name = "pbPraise";
            this.pbPraise.Size = new System.Drawing.Size(300, 400);
            this.pbPraise.TabIndex = 0;
            this.pbPraise.TabStop = false;
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMain.Location = new System.Drawing.Point(36, 415);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(426, 31);
            this.lblMain.TabIndex = 1;
            this.lblMain.Text = "Solaire - Solana Desktop Wallet";
            // 
            // lblBelow
            // 
            this.lblBelow.AutoSize = true;
            this.lblBelow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBelow.Location = new System.Drawing.Point(90, 446);
            this.lblBelow.Name = "lblBelow";
            this.lblBelow.Size = new System.Drawing.Size(323, 25);
            this.lblBelow.TabIndex = 2;
            this.lblBelow.Text = "Free and open source (MIT license)";
            // 
            // lblGithub
            // 
            this.lblGithub.AutoSize = true;
            this.lblGithub.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblGithub.Location = new System.Drawing.Point(209, 471);
            this.lblGithub.Name = "lblGithub";
            this.lblGithub.Size = new System.Drawing.Size(40, 13);
            this.lblGithub.TabIndex = 3;
            this.lblGithub.TabStop = true;
            this.lblGithub.Text = "GitHub";
            this.lblGithub.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lblGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGithub_LinkClicked);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(495, 490);
            this.Controls.Add(this.lblGithub);
            this.Controls.Add(this.lblBelow);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.pbPraise);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pbPraise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPraise;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblBelow;
        private System.Windows.Forms.LinkLabel lblGithub;
    }
}