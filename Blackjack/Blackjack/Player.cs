using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            DeckClass.currentDeck = DeckClass.allCards;
        }

        public void EndTurn()
        {
            hitButton.Hide();
            standButton.Hide();
            playerTurn = false;
            window.TurnCompleted(21);
        }

        public void StartTurn()
        {
            hitButton.Show();
            standButton.Show();
            playerTurn = true;

        }

        public bool IsTurn()
        {
            return playerTurn;
        }

        private void playerCountLabel_Click(object sender, EventArgs e)
        {
            DeckClass.getNewCard(playerLayoutPanel, false);
        }

        private int calcPlayerValue()
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
    }
}
