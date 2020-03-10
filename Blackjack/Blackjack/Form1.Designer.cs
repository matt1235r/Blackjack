namespace Blackjack
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dealerLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.playerLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.standButton = new System.Windows.Forms.Button();
            this.hitButton = new System.Windows.Forms.Button();
            this.dealButton = new System.Windows.Forms.Button();
            this.playerCountLabel = new System.Windows.Forms.Label();
            this.dealerCountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cardImageList = new System.Windows.Forms.ImageList(this.components);
            this.miscImageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // dealerLayoutPanel
            // 
            this.dealerLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dealerLayoutPanel.Location = new System.Drawing.Point(21, 54);
            this.dealerLayoutPanel.Name = "dealerLayoutPanel";
            this.dealerLayoutPanel.Size = new System.Drawing.Size(751, 143);
            this.dealerLayoutPanel.TabIndex = 0;
            // 
            // playerLayoutPanel
            // 
            this.playerLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerLayoutPanel.Location = new System.Drawing.Point(21, 242);
            this.playerLayoutPanel.Name = "playerLayoutPanel";
            this.playerLayoutPanel.Size = new System.Drawing.Size(751, 143);
            this.playerLayoutPanel.TabIndex = 1;
            // 
            // standButton
            // 
            this.standButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.standButton.BackColor = System.Drawing.Color.YellowGreen;
            this.standButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.standButton.Location = new System.Drawing.Point(404, 471);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(229, 36);
            this.standButton.TabIndex = 2;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = false;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // hitButton
            // 
            this.hitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.hitButton.BackColor = System.Drawing.Color.YellowGreen;
            this.hitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hitButton.Location = new System.Drawing.Point(189, 471);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(209, 36);
            this.hitButton.TabIndex = 3;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = false;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // dealButton
            // 
            this.dealButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dealButton.BackColor = System.Drawing.Color.YellowGreen;
            this.dealButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dealButton.Location = new System.Drawing.Point(8, 471);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(112, 36);
            this.dealButton.TabIndex = 4;
            this.dealButton.Text = "New Game";
            this.dealButton.UseVisualStyleBackColor = false;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // playerCountLabel
            // 
            this.playerCountLabel.AutoSize = true;
            this.playerCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerCountLabel.ForeColor = System.Drawing.Color.Yellow;
            this.playerCountLabel.Location = new System.Drawing.Point(110, 215);
            this.playerCountLabel.Name = "playerCountLabel";
            this.playerCountLabel.Size = new System.Drawing.Size(21, 24);
            this.playerCountLabel.TabIndex = 5;
            this.playerCountLabel.Text = "0";
            // 
            // dealerCountLabel
            // 
            this.dealerCountLabel.AutoSize = true;
            this.dealerCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerCountLabel.ForeColor = System.Drawing.Color.Yellow;
            this.dealerCountLabel.Location = new System.Drawing.Point(110, 27);
            this.dealerCountLabel.Name = "dealerCountLabel";
            this.dealerCountLabel.Size = new System.Drawing.Size(21, 24);
            this.dealerCountLabel.TabIndex = 6;
            this.dealerCountLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dealer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(18, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Player:";
            // 
            // cardImageList
            // 
            this.cardImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("cardImageList.ImageStream")));
            this.cardImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.cardImageList.Images.SetKeyName(0, "2C.png");
            this.cardImageList.Images.SetKeyName(1, "2D.png");
            this.cardImageList.Images.SetKeyName(2, "2H.png");
            this.cardImageList.Images.SetKeyName(3, "2S.png");
            this.cardImageList.Images.SetKeyName(4, "3C.png");
            this.cardImageList.Images.SetKeyName(5, "3D.png");
            this.cardImageList.Images.SetKeyName(6, "3H.png");
            this.cardImageList.Images.SetKeyName(7, "3S.png");
            this.cardImageList.Images.SetKeyName(8, "4C.png");
            this.cardImageList.Images.SetKeyName(9, "4D.png");
            this.cardImageList.Images.SetKeyName(10, "4H.png");
            this.cardImageList.Images.SetKeyName(11, "4S.png");
            this.cardImageList.Images.SetKeyName(12, "5C.png");
            this.cardImageList.Images.SetKeyName(13, "5D.png");
            this.cardImageList.Images.SetKeyName(14, "5H.png");
            this.cardImageList.Images.SetKeyName(15, "5S.png");
            this.cardImageList.Images.SetKeyName(16, "6C.png");
            this.cardImageList.Images.SetKeyName(17, "6D.png");
            this.cardImageList.Images.SetKeyName(18, "6H.png");
            this.cardImageList.Images.SetKeyName(19, "6S.png");
            this.cardImageList.Images.SetKeyName(20, "7C.png");
            this.cardImageList.Images.SetKeyName(21, "7D.png");
            this.cardImageList.Images.SetKeyName(22, "7H.png");
            this.cardImageList.Images.SetKeyName(23, "7S.png");
            this.cardImageList.Images.SetKeyName(24, "8C.png");
            this.cardImageList.Images.SetKeyName(25, "8D.png");
            this.cardImageList.Images.SetKeyName(26, "8H.png");
            this.cardImageList.Images.SetKeyName(27, "8S.png");
            this.cardImageList.Images.SetKeyName(28, "9C.png");
            this.cardImageList.Images.SetKeyName(29, "9D.png");
            this.cardImageList.Images.SetKeyName(30, "9H.png");
            this.cardImageList.Images.SetKeyName(31, "9S.png");
            this.cardImageList.Images.SetKeyName(32, "10C.png");
            this.cardImageList.Images.SetKeyName(33, "10D.png");
            this.cardImageList.Images.SetKeyName(34, "10H.png");
            this.cardImageList.Images.SetKeyName(35, "10S.png");
            this.cardImageList.Images.SetKeyName(36, "AC.png");
            this.cardImageList.Images.SetKeyName(37, "AD.png");
            this.cardImageList.Images.SetKeyName(38, "AH.png");
            this.cardImageList.Images.SetKeyName(39, "AS.png");
            this.cardImageList.Images.SetKeyName(40, "JC.png");
            this.cardImageList.Images.SetKeyName(41, "JD.png");
            this.cardImageList.Images.SetKeyName(42, "JH.png");
            this.cardImageList.Images.SetKeyName(43, "JS.png");
            this.cardImageList.Images.SetKeyName(44, "KC.png");
            this.cardImageList.Images.SetKeyName(45, "KD.png");
            this.cardImageList.Images.SetKeyName(46, "KH.png");
            this.cardImageList.Images.SetKeyName(47, "KS.png");
            this.cardImageList.Images.SetKeyName(48, "QC.png");
            this.cardImageList.Images.SetKeyName(49, "QD.png");
            this.cardImageList.Images.SetKeyName(50, "QH.png");
            this.cardImageList.Images.SetKeyName(51, "QS.png");
            // 
            // miscImageList
            // 
            this.miscImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("miscImageList.ImageStream")));
            this.miscImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.miscImageList.Images.SetKeyName(0, "blue_back.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(784, 519);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dealerCountLabel);
            this.Controls.Add(this.playerCountLabel);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.playerLayoutPanel);
            this.Controls.Add(this.dealerLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel dealerLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel playerLayoutPanel;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Label playerCountLabel;
        private System.Windows.Forms.Label dealerCountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList cardImageList;
        private System.Windows.Forms.ImageList miscImageList;
    }
}

