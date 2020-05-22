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
            this.removePlayer = new System.Windows.Forms.Button();
            this.newPlayer = new System.Windows.Forms.Button();
            this.miscImageList = new System.Windows.Forms.ImageList(this.components);
            this.dealerCountLabel = new System.Windows.Forms.Label();
            this.cardImageList = new System.Windows.Forms.ImageList(this.components);
            this.bannerTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.helpButton = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.PictureBox();
            this.muteButton = new System.Windows.Forms.PictureBox();
            this.deckSizeLabel = new System.Windows.Forms.Label();
            this.dealerLayoutPanel = new System.Windows.Forms.PictureBox();
            this.playerContainer = new System.Windows.Forms.Panel();
            this.toolTipHandler = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muteButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerLayoutPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // removePlayer
            // 
            this.removePlayer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.removePlayer.BackColor = System.Drawing.Color.IndianRed;
            this.removePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removePlayer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removePlayer.Location = new System.Drawing.Point(526, 532);
            this.removePlayer.Name = "removePlayer";
            this.removePlayer.Size = new System.Drawing.Size(244, 35);
            this.removePlayer.TabIndex = 2;
            this.removePlayer.Text = "Remove Player";
            this.toolTipHandler.SetToolTip(this.removePlayer, "Remove a player from the game. (Min 1)");
            this.removePlayer.UseVisualStyleBackColor = false;
            this.removePlayer.Click += new System.EventHandler(this.removePlayer_Click);
            // 
            // newPlayer
            // 
            this.newPlayer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.newPlayer.BackColor = System.Drawing.Color.YellowGreen;
            this.newPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newPlayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newPlayer.ImageList = this.miscImageList;
            this.newPlayer.Location = new System.Drawing.Point(295, 532);
            this.newPlayer.Name = "newPlayer";
            this.newPlayer.Size = new System.Drawing.Size(223, 35);
            this.newPlayer.TabIndex = 3;
            this.newPlayer.Text = "New Player";
            this.toolTipHandler.SetToolTip(this.newPlayer, "Add a new player to the game. (Max 4)");
            this.newPlayer.UseVisualStyleBackColor = false;
            this.newPlayer.Click += new System.EventHandler(this.newPlayer_Click);
            // 
            // miscImageList
            // 
            this.miscImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("miscImageList.ImageStream")));
            this.miscImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.miscImageList.Images.SetKeyName(0, "stand.PNG");
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
            // bannerTimer
            // 
            this.bannerTimer.Interval = 2000;
            this.bannerTimer.Tick += new System.EventHandler(this.bannerTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.helpButton);
            this.panel1.Controls.Add(this.settingsButton);
            this.panel1.Controls.Add(this.muteButton);
            this.panel1.Controls.Add(this.deckSizeLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 520);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 54);
            this.panel1.TabIndex = 15;
            // 
            // helpButton
            // 
            this.helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.helpButton.BackColor = System.Drawing.Color.Transparent;
            this.helpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpButton.BackgroundImage")));
            this.helpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpButton.Image = ((System.Drawing.Image)(resources.GetObject("helpButton.Image")));
            this.helpButton.Location = new System.Drawing.Point(864, 6);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(47, 42);
            this.helpButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helpButton.TabIndex = 16;
            this.helpButton.TabStop = false;
            this.helpButton.Tag = "0";
            this.toolTipHandler.SetToolTip(this.helpButton, "View Help Window");
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
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
            this.playerContainer.Location = new System.Drawing.Point(22, 176);
            this.playerContainer.Name = "playerContainer";
            this.playerContainer.Size = new System.Drawing.Size(949, 335);
            this.playerContainer.TabIndex = 25;
            this.playerContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.playerContainer_Paint);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 574);
            this.Controls.Add(this.dealerCountLabel);
            this.Controls.Add(this.dealerLayoutPanel);
            this.Controls.Add(this.newPlayer);
            this.Controls.Add(this.removePlayer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.playerContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "GameWindow";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muteButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerLayoutPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button removePlayer;
        private System.Windows.Forms.Button newPlayer;
        private System.Windows.Forms.Label dealerCountLabel;
        private System.Windows.Forms.ImageList cardImageList;
        private System.Windows.Forms.ImageList miscImageList;
        private System.Windows.Forms.Label deckSizeLabel;
        private System.Windows.Forms.Timer bannerTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox muteButton;
        private System.Windows.Forms.PictureBox settingsButton;
        private System.Windows.Forms.PictureBox dealerLayoutPanel;
        private System.Windows.Forms.Panel playerContainer;
        private System.Windows.Forms.PictureBox helpButton;
        private System.Windows.Forms.ToolTip toolTipHandler;
    }
}

