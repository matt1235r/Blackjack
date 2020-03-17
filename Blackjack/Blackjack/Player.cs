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

        public Player(GameWindow parent)
        {
            InitializeComponent();
            window = parent;
        }

        public Player()
        {
            InitializeComponent();
        }

        bool playerTurn;

        private void Player_Load(object sender, EventArgs e)
        {
            scoreBanner.Hide();
        }

        public void EndTurn()
        {
            hitButton.Hide();
            standButton.Hide();
            playerTurn = false;
            window.TurnCompleted();
        }

        public void StartTurn()
        {
            scoreBanner.Hide();
            playerLayoutPanel.Controls.Clear();
            hitButton.Show();
            standButton.Show();
            playerTurn = true;

            hitButton.PerformClick();
            hitButton.PerformClick();

            while (Convert.ToInt32(playerCountLabel.Text) >= 17)
            {

                hitButton.PerformClick();
            }
            EndTurn();

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
                resultLabel.Text = "Player Lost";

            }
            else if (result == 0)
            {
                scoreBanner.BackColor = Color.MediumPurple;
                resultLabel.Text = "Player Tied";
            }
            else if (result == 1)
            {
                scoreBanner.BackColor = Color.Green;
                resultLabel.Text = "Player Won";
            }
            scoreBanner.Show();
        }
    }
}
