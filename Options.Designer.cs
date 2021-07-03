
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
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(690, 416);
            this.Controls.Add(this.lblConfigFileValue);
            this.Controls.Add(this.lblConfigFileText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.Shown += new System.EventHandler(this.Options_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfigFileText;
        private System.Windows.Forms.Label lblConfigFileValue;
    }
}