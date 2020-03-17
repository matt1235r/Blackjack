using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class GameWindow : Form
    {


        public GameWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            winnerBanner.Hide();
            drawPanel.Hide();
            looseBanner.Hide();
            LoadSettings();

            
        }

        private void LoadSettings()
        {
            dealerCountLabel.Visible = Properties.Settings.Default.showScore;
            //playerCountLabel.Visible = Properties.Settings.Default.showScore;
        }
        

        private int calcDealerValue()
        {
            int count = 0;
            foreach (Control c in dealerLayoutPanel.Controls)
            {
                if (((PictureBox)c).Image == null)
                {
                    count = count + Convert.ToInt16(c.Tag);
                }

            }

            //some simple ace logic
            if (count > 21)
            {
                foreach (Control c in dealerLayoutPanel.Controls)
                {
                    if (Convert.ToInt16(c.Tag) == 11)
                    {
                        count -= 10;
                        if (count <= 21)
                        {
                            break;
                        }
                    }

                }
            }

            dealerCountLabel.Text = count.ToString();
            return count;
        }


        private void ResetGame()
        {
            //DeckClass.currentDeck.Clear();

            DeckClass.currentDeck = new List<Card>(DeckClass.allCards);
            deckSizeLabel.Text = DeckClass.currentDeck.Count.ToString();
            
            dealerLayoutPanel.Controls.Clear();

            dealerCountLabel.Text = "0";


            DeckClass.getNewCard(dealerLayoutPanel, true);
            DeckClass.getNewCard(dealerLayoutPanel);


            playerHit();
            calcDealerValue();

            hitButton.Enabled = true;
            standButton.Enabled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// 

        private void playerHit()
        {
            foreach(Control c in playerContainer.Controls)
            {
                if(c.GetType() == typeof(Player))
                {
                    ((Player)c).StartTurn();
                }
            }
        }

   
        private void dealerTurn()
        {
            ((PictureBox)dealerLayoutPanel.Controls[1]).Image = null;
            while (calcDealerValue() <= 17)
            {
                DeckClass.getNewCard(dealerLayoutPanel);
                
            }

            checkWhoWon();
        }
        

        private void playSound(System.IO.UnmanagedMemoryStream path)
        {
            System.IO.Stream str = path;
            SoundPlayer snd = new SoundPlayer(str);

            if (muteButton.Tag.ToString() == "0") { snd.Play(); }
            
        }

        private void checkWhoWon()
        {
            foreach(Control c in playerContainer.Controls)
            {
                Player currentplayer = ((Player)c);
                //int playerhand = calcPlayerValue();
                int dealerhand = calcDealerValue();
                int playerhand = currentplayer.calcPlayerValue();
                //first see if player is bust
                hitButton.Enabled = false;
                standButton.Enabled = false;
                if (playerhand <= 21 && playerhand == dealerhand)
                {
                    playSound(Properties.Resources.Short_Dial_Tone_SoundBible_com_1911037576);
                    currentplayer.roundEnd(0);
                }
                else if (playerhand <= 21 && (dealerhand > 21 || playerhand > dealerhand))
                {
                    playSound(Properties.Resources.Ta_Da_SoundBible_com_1884170640);
                    currentplayer.roundEnd(1);
                }
                else
                {
                    playSound(Properties.Resources.CD_Skipping_SoundBible_com_816257683);
                    currentplayer.roundEnd(-1);
                }
            }
            bannerTimer.Start();
            
        }

        private void dealButton_Click(object sender, EventArgs e)
        {           
            ResetGame();

        }

        private void standButton_Click(object sender, EventArgs e)
        {
            Player player = new Player(this);
            player.Location = new Point(52, 18);

            playerContainer.Controls.Add(player);

            ResetGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void deckSizeLabel_Click(object sender, EventArgs e)
        {

        }

        private void bannerTimer_Tick(object sender, EventArgs e)
        {
            ResetGame();
            MessageBox.Show("Test");
            bannerTimer.Stop();
        }

        private void muteButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (muteButton.Tag.ToString() == "0")
            {
                muteButton.BackgroundImage = Properties.Resources.unmute;
                muteButton.Tag = 1;
            }
            else
            {
                muteButton.BackgroundImage = Properties.Resources.mute;
                muteButton.Tag = 0;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.H)
            {
                hitButton.PerformClick();
            }
            else if (e.KeyCode == Keys.S)
            {
                standButton.PerformClick();
            }
            else if (e.KeyCode == Keys.N)
            {
                dealButton.PerformClick();
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            new SettingsWindow().ShowDialog();
            LoadSettings();
        }

        public void TurnCompleted()
        {
            int playersleft = playerContainer.Controls.Count;
            foreach(Control c in playerContainer.Controls)
            {
                if (((Player)c).IsTurn() == false) { playersleft--; }
            }

            if(playersleft == 0)
            {
                dealerTurn();
            }
            
        }
        private void GameWindow_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            Player player = new Player(this);
            player.Location = DeckClass.playercords[playerContainer.Controls.Count];

            playerContainer.Controls.Add(player);
            

            ResetGame();

        }
    }
}
