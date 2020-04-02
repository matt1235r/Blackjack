namespace Blackjack
{
    partial class Player
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playerCountLabel = new System.Windows.Forms.Label();
            this.playerLayoutPanel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerLayoutPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // playerCountLabel
            // 
            this.playerCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.playerCountLabel.AutoSize = true;
            this.playerCountLabel.BackColor = System.Drawing.Color.Gray;
            this.playerCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.playerCountLabel.Location = new System.Drawing.Point(50, 235);
            this.playerCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerCountLabel.Name = "playerCountLabel";
            this.playerCountLabel.Size = new System.Drawing.Size(41, 29);
            this.playerCountLabel.TabIndex = 17;
            this.playerCountLabel.Text = "04";
            // 
            // playerLayoutPanel
            // 
            this.playerLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.playerLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.playerLayoutPanel.Location = new System.Drawing.Point(4, 3);
            this.playerLayoutPanel.Name = "playerLayoutPanel";
            this.playerLayoutPanel.Size = new System.Drawing.Size(139, 147);
            this.playerLayoutPanel.TabIndex = 18;
            this.playerLayoutPanel.TabStop = false;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.playerLayoutPanel);
            this.Controls.Add(this.playerCountLabel);
            this.Name = "Player";
            this.Size = new System.Drawing.Size(146, 264);
            ((System.ComponentModel.ISupportInitialize)(this.playerLayoutPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playerLayoutPanel;
        private System.Windows.Forms.Label playerCountLabel;
    }
}
