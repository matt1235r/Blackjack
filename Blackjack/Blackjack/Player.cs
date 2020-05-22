using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Blackjack
{
    public partial class Player : UserControl
    {
        GameWindow window;

        bool autoplay;

        bool isPlayer1 = false;

        public Player(GameWindow parent, bool playerCanBeBot = true)
        {
            InitializeComponent();
            window = parent;
            
            //game needs to know about player 1 to stop you changing it to a bot.
            isPlayer1 = !playerCanBeBot;

            //if not player 1 then game defaults to bot mode.
            if (playerCanBeBot)
            {
                autoplay = true;
            }
        }

        public Player()
        {
            InitializeComponent();
        }

        bool playerTurn;

        private void Player_Load(object sender, EventArgs e)
        {
            scoreBanner.Hide();
            AutoPlayCheck();
        }

        private void AutoPlayCheck()
        {
            if (autoplay)
            {
                playerLabel.Text = "CPU Player";
                profileImage.Image = Properties.Resources.cpu_icon_symbol_sign_vector;
            }
            else
            {
                playerLabel.Text = "Player";
                profileImage.Image = Properties.Resources.person_icon;
            }
        }

        public void EndTurn()
        {
            hitButton.Hide();
            standButton.Hide();
            playerCountLabel.ForeColor = Color.Black;
            playerCountLabel.BackColor = Color.Gray;
            playerTurn = false;
            window.TurnCompleted();
        }

        public void StartTurn()
        {
            AutoPlayCheck();
            playerCountLabel.Visible = Properties.Settings.Default.showScore;
            scoreBanner.Hide();
            playerLayoutPanel.Controls.Clear();
            hitButton.Show();
            standButton.Show();
            playerCountLabel.ForeColor = Color.White;
            playerCountLabel.BackColor = Color.LightSeaGreen;
            playerTurn = true;

            hitButton.PerformClick();
            hitButton.PerformClick();


            if (autoplay)
            {
                while (IsTurn())
                {
                    if(calcPlayerValue() < 17)
                    {
                        hitButton.PerformClick();
                    }
                    else
                    {
                        standButton.PerformClick();
                    }
                }
            }
        }


        public bool IsTurn()
        {
            return playerTurn;
        }

        private void playerCountLabel_Click(object sender, EventArgs e)
        {
            DeckClass.getNewCard(playerLayoutPanel, false);
        }

        public int calcPlayerValue()
        {
            int count = 0;
            foreach (Control c in playerLayoutPanel.Controls)
            {
                count = count + Convert.ToInt16(c.Tag);

            }
            
            //some simple ace logic
            if (count > 21)
            {
                foreach (Control c in playerLayoutPanel.Controls)
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
            playerCountLabel.Text = count.ToString();


            //checks if the game should end the turn for the player. eg: if they have 21 or are bust.
            if (count > 20)
            {

                standButton.Invoke(new MethodInvoker(delegate
                {
                    standButton.PerformClick();
                }));

            }


            return count;
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            DeckClass.getNewCard(playerLayoutPanel);
            calcPlayerValue();
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            EndTurn();
        }

        public void roundEnd(int result)
        {
            if(result == -1)
            {
                scoreBanner.BackColor = Color.IndianRed;
                resultLabel.Text = playerLabel.Text + " Lost";

            }
            else if (result == 0)
            {
                scoreBanner.BackColor = Color.MediumPurple;
                resultLabel.Text = playerLabel.Text + " Tied";
            }
            else if (result == 1)
            {
                scoreBanner.BackColor = Color.Green;
                resultLabel.Text = playerLabel.Text + " Won";
            }
            scoreBanner.Show();
        }

        private void profileImage_Click(object sender, EventArgs e)
        {
            //will not let you change to CPU bot if player 1 because it breaks things.
            if (!isPlayer1)
            {
                if (autoplay) { autoplay = false; } else { autoplay = true; }
                AutoPlayCheck();
            }
            
        }
    }
    }

