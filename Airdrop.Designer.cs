
namespace Solaire
{
    partial class Airdrop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Airdrop));
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.btnAirdrop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(12, 12);
            this.nudAmount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(49, 20);
            this.nudAmount.TabIndex = 0;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAirdrop
            // 
            this.btnAirdrop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAirdrop.FlatAppearance.BorderSize = 0;
            this.btnAirdrop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAirdrop.Location = new System.Drawing.Point(92, 12);
            this.btnAirdrop.Name = "btnAirdrop";
            this.btnAirdrop.Size = new System.Drawing.Size(102, 25);
            this.btnAirdrop.TabIndex = 9;
            this.btnAirdrop.Text = "Airdrop";
            this.btnAirdrop.UseVisualStyleBackColor = false;
            this.btnAirdrop.Click += new System.EventHandler(this.btnAirdrop_Click);
            // 
            // Airdrop
            // 
            this.AcceptButton = this.btnAirdrop;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(210, 57);
            this.Controls.Add(this.btnAirdrop);
            this.Controls.Add(this.nudAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Airdrop";
            this.Text = "Airdrop";
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Button btnAirdrop;
    }
}