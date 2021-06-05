namespace Solaire1
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
            this.lblDefaultAddressTxt = new System.Windows.Forms.Label();
            this.lblDefaultAddressValue = new System.Windows.Forms.Label();
            this.lblBalanceValue = new System.Windows.Forms.Label();
            this.lblCurrentBalanceTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSolVerText
            // 
            this.lblSolVerText.AutoSize = true;
            this.lblSolVerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSolVerText.Location = new System.Drawing.Point(12, 9);
            this.lblSolVerText.Name = "lblSolVerText";
            this.lblSolVerText.Size = new System.Drawing.Size(244, 37);
            this.lblSolVerText.TabIndex = 0;
            this.lblSolVerText.Text = "Solana Version:";
            // 
            // lblSolVerValue
            // 
            this.lblSolVerValue.AutoSize = true;
            this.lblSolVerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSolVerValue.Location = new System.Drawing.Point(262, 9);
            this.lblSolVerValue.Name = "lblSolVerValue";
            this.lblSolVerValue.Size = new System.Drawing.Size(0, 37);
            this.lblSolVerValue.TabIndex = 1;
            // 
            // lblDefaultAddressTxt
            // 
            this.lblDefaultAddressTxt.AutoSize = true;
            this.lblDefaultAddressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDefaultAddressTxt.Location = new System.Drawing.Point(12, 76);
            this.lblDefaultAddressTxt.Name = "lblDefaultAddressTxt";
            this.lblDefaultAddressTxt.Size = new System.Drawing.Size(254, 37);
            this.lblDefaultAddressTxt.TabIndex = 2;
            this.lblDefaultAddressTxt.Text = "Default Address:";
            // 
            // lblDefaultAddressValue
            // 
            this.lblDefaultAddressValue.AutoSize = true;
            this.lblDefaultAddressValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDefaultAddressValue.Location = new System.Drawing.Point(16, 113);
            this.lblDefaultAddressValue.Name = "lblDefaultAddressValue";
            this.lblDefaultAddressValue.Size = new System.Drawing.Size(0, 17);
            this.lblDefaultAddressValue.TabIndex = 3;
            // 
            // lblBalanceValue
            // 
            this.lblBalanceValue.AutoSize = true;
            this.lblBalanceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBalanceValue.Location = new System.Drawing.Point(153, 159);
            this.lblBalanceValue.Name = "lblBalanceValue";
            this.lblBalanceValue.Size = new System.Drawing.Size(184, 37);
            this.lblBalanceValue.TabIndex = 5;
            this.lblBalanceValue.Text = "Initializing...";
            // 
            // lblCurrentBalanceTxt
            // 
            this.lblCurrentBalanceTxt.AutoSize = true;
            this.lblCurrentBalanceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCurrentBalanceTxt.Location = new System.Drawing.Point(12, 159);
            this.lblCurrentBalanceTxt.Name = "lblCurrentBalanceTxt";
            this.lblCurrentBalanceTxt.Size = new System.Drawing.Size(141, 37);
            this.lblCurrentBalanceTxt.TabIndex = 4;
            this.lblCurrentBalanceTxt.Text = "Balance:";
            // 
            // Solaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(400, 622);
            this.Controls.Add(this.lblBalanceValue);
            this.Controls.Add(this.lblCurrentBalanceTxt);
            this.Controls.Add(this.lblDefaultAddressValue);
            this.Controls.Add(this.lblDefaultAddressTxt);
            this.Controls.Add(this.lblSolVerValue);
            this.Controls.Add(this.lblSolVerText);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Solaire";
            this.Text = "Solaire";
            this.Load += new System.EventHandler(this.Solaire_Load);
            this.Shown += new System.EventHandler(this.Solaire_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSolVerText;
        private System.Windows.Forms.Label lblSolVerValue;
        private System.Windows.Forms.Label lblDefaultAddressTxt;
        private System.Windows.Forms.Label lblDefaultAddressValue;
        private System.Windows.Forms.Label lblBalanceValue;
        private System.Windows.Forms.Label lblCurrentBalanceTxt;
    }
}

