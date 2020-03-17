namespace Blackjack
{
    partial class GameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.standButton = new System.Windows.Forms.Button();
            this.hitButton = new System.Windows.Forms.Button();
            this.miscImageList = new System.Windows.Forms.ImageList(this.components);
            this.dealButton = new System.Windows.Forms.Button();
            this.dealerCountLabel = new System.Windows.Forms.Label();
            this.cardImageList = new System.Windows.Forms.ImageList(this.components);
            this.winnerBanner = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bannerTimer = new System.Windows.Forms.Timer(this.components);
            this.looseBanner = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.PictureBox();
            this.muteButton = new System.Windows.Forms.PictureBox();
            this.deckSizeLabel = new System.Windows.Forms.Label();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dealerLayoutPanel = new System.Windows.Forms.PictureBox();
            this.playerContainer = new System.Windows.Forms.Panel();
            this.winnerBanner.SuspendLayout();
            this.looseBanner.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muteButton)).BeginInit();
            this.drawPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealerLayoutPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // standButton
            // 
            this.standButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.standButton.BackColor = System.Drawing.Color.YellowGreen;
            this.standButton.Enabled = false;
            this.standButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.standButton.Location = new System.Drawing.Point(526, 532);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(244, 35);
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
            this.hitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hitButton.ImageList = this.miscImageList;
            this.hitButton.Location = new System.Drawing.Point(295, 532);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(223, 35);
            this.hitButton.TabIndex = 3;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = false;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // miscImageList
            // 
            this.miscImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("miscImageList.ImageStream")));
            this.miscImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.miscImageList.Images.SetKeyName(0, "stand.PNG");
            // 
            // dealButton
            // 
            this.dealButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dealButton.BackColor = System.Drawing.Color.YellowGreen;
            this.dealButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dealButton.Location = new System.Drawing.Point(9, 532);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(119, 35);
            this.dealButton.TabIndex = 4;
            this.dealButton.Text = "New Game";
            this.dealButton.UseVisualStyleBackColor = false;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // dealerCountLabel
            // 
            this.dealerCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dealerCountLabel.AutoSize = true;
            this.dealerCountLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dealerCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerCountLabel.ForeColor = System.Drawing.Color.Yellow;
            this.dealerCountLabel.Location = new System.Drawing.Point(412, 116);
            this.dealerCountLabel.Name = "dealerCountLabel";
            this.dealerCountLabel.Size = new System.Drawing.Size(32, 24);
            this.dealerCountLabel.TabIndex = 6;
            this.dealerCountLabel.Text = "04";
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
            this.cardImageList.Images.SetKeyName(52, "blue_back.png");
            // 
            // winnerBanner
            // 
            this.winnerBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.winnerBanner.BackColor = System.Drawing.Color.LimeGreen;
            this.winnerBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.winnerBanner.Controls.Add(this.label2);
            this.winnerBanner.Location = new System.Drawing.Point(198, 472);
            this.winnerBanner.Name = "winnerBanner";
            this.winnerBanner.Size = new System.Drawing.Size(660, 44);
            this.winnerBanner.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(202, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Player Wins";
            // 
            // bannerTimer
            // 
            this.bannerTimer.Interval = 2000;
            this.bannerTimer.Tick += new System.EventHandler(this.bannerTimer_Tick);
            // 
            // looseBanner
            // 
            this.looseBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.looseBanner.BackColor = System.Drawing.Color.Brown;
            this.looseBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.looseBanner.Controls.Add(this.label4);
            this.looseBanner.Location = new System.Drawing.Point(198, 472);
            this.looseBanner.Name = "looseBanner";
            this.looseBanner.Size = new System.Drawing.Size(660, 44);
            this.looseBanner.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(216, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dealer Wins";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.settingsButton);
            this.panel1.Controls.Add(this.muteButton);
            this.panel1.Controls.Add(this.deckSizeLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 520);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 54);
            this.panel1.TabIndex = 15;
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsButton.BackgroundImage")));
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsButton.Location = new System.Drawing.Point(917, 6);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(47, 42);
            this.settingsButton.TabIndex = 15;
            this.settingsButton.TabStop = false;
            this.settingsButton.Tag = "0";
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // muteButton
            // 
            this.muteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.muteButton.BackColor = System.Drawing.Color.Transparent;
            this.muteButton.BackgroundImage = global::Blackjack.Properties.Resources.mute;
            this.muteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.muteButton.Location = new System.Drawing.Point(970, 6);
            this.muteButton.Name = "muteButton";
            this.muteButton.Size = new System.Drawing.Size(47, 42);
            this.muteButton.TabIndex = 14;
            this.muteButton.TabStop = false;
            this.muteButton.Tag = "0";
            this.muteButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.muteButton_MouseDown);
            // 
            // deckSizeLabel
            // 
            this.deckSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deckSizeLabel.AutoSize = true;
            this.deckSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.deckSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deckSizeLabel.ForeColor = System.Drawing.Color.White;
            this.deckSizeLabel.Location = new System.Drawing.Point(49, -21);
            this.deckSizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deckSizeLabel.Name = "deckSizeLabel";
            this.deckSizeLabel.Size = new System.Drawing.Size(32, 24);
            this.deckSizeLabel.TabIndex = 11;
            this.deckSizeLabel.Text = "52";
            this.deckSizeLabel.Click += new System.EventHandler(this.deckSizeLabel_Click);
            // 
            // drawPanel
            // 
            this.drawPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawPanel.BackColor = System.Drawing.Color.MediumPurple;
            this.drawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawPanel.Controls.Add(this.label5);
            this.drawPanel.Location = new System.Drawing.Point(197, 471);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(660, 44);
            this.drawPanel.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(278, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "Push";
            // 
            // dealerLayoutPanel
            // 
            this.dealerLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dealerLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.dealerLayoutPanel.Location = new System.Drawing.Point(450, 74);
            this.dealerLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.dealerLayoutPanel.Name = "dealerLayoutPanel";
            this.dealerLayoutPanel.Size = new System.Drawing.Size(273, 123);
            this.dealerLayoutPanel.TabIndex = 0;
            this.dealerLayoutPanel.TabStop = false;
            // 
            // playerContainer
            // 
            this.playerContainer.BackColor = System.Drawing.Color.Transparent;
            this.playerContainer.Location = new System.Drawing.Point(22, 202);
            this.playerContainer.Name = "playerContainer";
            this.playerContainer.Size = new System.Drawing.Size(949, 309);
            this.playerContainer.TabIndex = 25;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 574);
            this.Controls.Add(this.playerContainer);
            this.Controls.Add(this.dealerCountLabel);
            this.Controls.Add(this.drawPanel);
            this.Controls.Add(this.dealerLayoutPanel);
            this.Controls.Add(this.winnerBanner);
            this.Controls.Add(this.looseBanner);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "GameWindow";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameWindow_MouseMove);
            this.winnerBanner.ResumeLayout(false);
            this.winnerBanner.PerformLayout();
            this.looseBanner.ResumeLayout(false);
            this.looseBanner.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muteButton)).EndInit();
            this.drawPanel.ResumeLayout(false);
            this.drawPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealerLayoutPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Label dealerCountLabel;
        private System.Windows.Forms.ImageList cardImageList;
        private System.Windows.Forms.ImageList miscImageList;
        private System.Windows.Forms.Label deckSizeLabel;
        private System.Windows.Forms.Panel winnerBanner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer bannerTimer;
        private System.Windows.Forms.Panel looseBanner;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox muteButton;
        private System.Windows.Forms.PictureBox settingsButton;
        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox dealerLayoutPanel;
        private System.Windows.Forms.Panel playerContainer;
    }
}

