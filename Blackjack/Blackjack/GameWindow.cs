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

        private void LoadSettings()
        {
            dealerCountLabel.Visible = Properties.Settings.Default.showScore;
 
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

            //ace logic
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
            dealerCountLabel.Visible = Properties.Settings.Default.showScore;

            DeckClass.playSound(Properties.Resources.shuffling_cards_1);

            DeckClass.currentDeck = new List<Card>(DeckClass.allCards);
            deckSizeLabel.Text = DeckClass.currentDeck.Count.ToString();
            
            dealerLayoutPanel.Controls.Clear();

            dealerCountLabel.Text = "0";


            DeckClass.getNewCard(dealerLayoutPanel, true);
            DeckClass.getNewCard(dealerLayoutPanel);


            foreach (Control c in playerContainer.Controls)
            {
                if (c.GetType() == typeof(Player))
                {
                    ((Player)c).StartTurn();
                }
            }

            calcDealerValue();
           
        }

   
        private void dealerTurn()
        {
            ((PictureBox)dealerLayoutPanel.Controls[1]).Image = null;
            while (calcDealerValue() <= 16)
            {
                DeckClass.getNewCard(dealerLayoutPanel);
                
            }

            checkWhoWon();
        }
        

        //will iterate through all player instances to calculate results.
        private void checkWhoWon()
        {
            for(int i = playerContainer.Controls.Count; i --> 0;)
            {
                Player currentplayer = (Player)playerContainer.Controls[i];
                
                //int playerhand = calcPlayerValue();
                int dealerhand = calcDealerValue();
                int playerhand = currentplayer.calcPlayerValue();
                
                //first see if player is bust

                if (playerhand <= 21 && playerhand == dealerhand)
                {
                    DeckClass.playSound(Properties.Resources.Short_Dial_Tone_SoundBible_com_1911037576);
                    currentplayer.roundEnd(0);
                }
                else if (playerhand <= 21 && (dealerhand > 21 || playerhand > dealerhand))
                {
                    DeckClass.playSound(Properties.Resources.Ta_Da_SoundBible_com_1884170640);
                    currentplayer.roundEnd(1);
                }
                else
                {
                    DeckClass.playSound(Properties.Resources.CD_Skipping_SoundBible_com_816257683);
                    currentplayer.roundEnd(-1);
                }
            }

            DeckClass.wait(3000);
            ResetGame();
        }

        private void dealButton_Click(object sender, EventArgs e)
        {           
            ResetGame();
            
        }     

        private void bannerTimer_Tick(object sender, EventArgs e)
        {
            ResetGame();
            bannerTimer.Stop();
        }

        private void muteButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (muteButton.Tag.ToString() == "0")
            {
                muteButton.BackgroundImage = Properties.Resources.unmute;
                Properties.Settings.Default.gameMuted = true;
                muteButton.Tag = 1;
            }
            else
            {
                muteButton.BackgroundImage = Properties.Resources.mute;
                Properties.Settings.Default.gameMuted = false;
                muteButton.Tag = 0;
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            new SettingsWindow().ShowDialog();
            LoadSettings();
        }

        public void TurnCompleted()
        {
            DeckClass.playSound(Properties.Resources.Lightsaber_Turn_Off_SoundBible_com_726724693);
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

        //adds a new player to the game
        private void newPlayer_Click(object sender, EventArgs e)
        {

            Player player = new Player(this);
            player.Location = DeckClass.playercords[playerContainer.Controls.Count];

            playerContainer.Controls.Add(player);


            ResetGame();
        }

        //removes the player from the game, but doesnt allow you to delete them all.
        private void removePlayer_Click(object sender, EventArgs e)
        {
            if (playerContainer.Controls.Count != 1)
            {
                playerContainer.Controls[playerContainer.Controls.Count - 1].Dispose();
                ResetGame();
            }
       
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            Player player = new Player(this, false);
            player.Location = DeckClass.playercords[playerContainer.Controls.Count];

            playerContainer.Controls.Add(player);


            ResetGame();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            new Help().ShowDialog();
        }

        private void playerContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void muteButton_Click(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            //form1.ShowDialog();
        }
    }
}
