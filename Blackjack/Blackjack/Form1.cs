using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {

        List<Card> deck = new List<Card>()
            {
                #region spades

                new Card() { Value  = 2, LongName = "Two Spades", ImageName = "2S.PNG" },
                new Card() { Value = 3, LongName = "Three Spades", ImageName = "3S.PNG" },
                new Card() { Value = 4, LongName =  "Four Spades", ImageName = "4S.PNG" },
                new Card() { Value = 5, LongName = "Five Spades", ImageName = "5S.PNG" },
                new Card() { Value = 6, LongName = "Six Spades", ImageName = "6S.PNG" },
                new Card() { Value = 7, LongName = "Seven Spades", ImageName = "7S.PNG" },
                new Card() { Value = 8, LongName = "Eight Spades", ImageName = "8S.PNG" },
                new Card() { Value = 9, LongName = "Nine Spades", ImageName = "9S.PNG" },
                new Card() { Value = 10, LongName = "Ten Spades", ImageName = "10S.PNG" },
                new Card() { Value = 10, LongName = "Jack Spades", ImageName = "JS.PNG" },
                new Card() { Value = 10, LongName = "Queen Spades", ImageName = "QS.PNG" },
                new Card(){ Value = 10, LongName = "King Spades", ImageName = "KS.PNG" },
                new Card(){ Value = 11, LongName = "Ace Spades", ImageName = "AS.PNG" },

                #endregion

                #region diamonds

                new Card() { Value  = 2, LongName = "Two Diamonds", ImageName = "2D.PNG" },
                new Card() { Value = 3, LongName = "Three Diamonds", ImageName = "3D.PNG" },
                new Card() { Value = 4, LongName =  "Four Diamonds", ImageName = "4D.PNG" },
                new Card() { Value = 5, LongName = "Five Diamonds", ImageName = "5D.PNG" },
                new Card() { Value = 6, LongName = "Six Diamonds", ImageName = "6D.PNG" },
                new Card(){ Value = 7, LongName = "Seven Diamonds", ImageName = "7D.PNG" },
                new Card() { Value = 8, LongName = "Eight Diamonds", ImageName = "8D.PNG" },
                new Card() { Value = 9, LongName = "Nine Diamonds", ImageName = "9D.PNG" },
                new Card() { Value = 10, LongName = "Ten Diamonds", ImageName = "10D.PNG" },
                new Card() { Value = 10, LongName = "Jack Diamonds", ImageName = "JD.PNG" },
                new Card() { Value = 10, LongName = "Queen Diamonds", ImageName = "QD.PNG" },
                new Card(){ Value = 10, LongName = "King Diamonds", ImageName = "KD.PNG" },
                new Card(){ Value = 11, LongName = "Ace Diamonds", ImageName = "AD.PNG" },

                #endregion

                #region clubs

                new Card() { Value  = 2, LongName = "Two Clubs", ImageName = "2C.PNG" },
                new Card() { Value = 3, LongName = "Three Clubs", ImageName = "3C.PNG" },
                new Card() { Value = 4, LongName =  "Four Clubs", ImageName = "4C.PNG" },
                new Card() { Value = 5, LongName = "Five Clubs", ImageName = "5C.PNG" },
                new Card() { Value = 6, LongName = "Six Clubs", ImageName = "6C.PNG" },
                new Card(){ Value = 7, LongName = "Seven Clubs", ImageName = "7C.PNG" },
                new Card() { Value = 8, LongName = "Eight Clubs", ImageName = "8C.PNG" },
                new Card() { Value = 9, LongName = "Nine Clubs", ImageName= "9C.PNG" },
                new Card() { Value = 10, LongName = "Ten Clubs", ImageName = "10C.PNG" },
                new Card() { Value = 10, LongName = "Jack Clubs", ImageName = "JC.PNG" },
                new Card() { Value = 10, LongName = "Queen Clubs", ImageName = "QC.PNG" },
                new Card(){ Value = 10, LongName = "King Clubs", ImageName = "KC.PNG" },
                new Card(){ Value = 11, LongName = "Ace Clubs", ImageName = "AC.PNG" },

                #endregion

                #region hearts

                new Card() { Value  = 2, LongName = "Two Hearts", ImageName = "2H.PNG" },
                new Card() { Value = 3, LongName = "Three Hearts", ImageName = "3H.PNG" },
                new Card() { Value = 4, LongName =  "Four Hearts", ImageName = "4H.PNG" },
                new Card() { Value = 5, LongName = "Five Hearts", ImageName = "5H.PNG" },
                new Card() { Value = 6, LongName = "Six Hearts", ImageName = "6H.PNG" },
                new Card(){ Value = 7, LongName = "Seven Hearts", ImageName = "7H.PNG" },
                new Card() { Value = 8, LongName = "Eight Hearts", ImageName = "8H.PNG" },
                new Card() { Value = 9, LongName = "Nine Hearts", ImageName = "9H.PNG" },
                new Card() { Value = 10, LongName = "Ten Hearts", ImageName = "10H.PNG" },
                new Card() { Value = 10, LongName = "Jack Hearts", ImageName = "JH.PNG" },
                new Card() { Value = 10, LongName = "Queen Hearts", ImageName = "QH.PNG" },
                new Card(){ Value = 10, LongName = "King Hearts", ImageName = "KH.PNG" },
                new Card(){ Value = 11, LongName = "Ace Hearts", ImageName = "AH.PNG" }

                #endregion
            };

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            playerHit();
            calcPlayerValue();

        }

        private void calcPlayerValue()
        {
            int count = 0;
            foreach (Control c in playerLayoutPanel.Controls)
            {
                count = count + deck[Convert.ToInt16(c.Tag)].Value;
            }

            playerCountLabel.Text = count.ToString();
        }

        private int calcDealerValue()
        {
            int count = 0;
            foreach (Control c in dealerLayoutPanel.Controls)
            {
                if (((PictureBox)c).Image == null)
                {
                    count = count + deck[Convert.ToInt16(c.Tag)].Value;
                }

            }

            dealerCountLabel.Text = count.ToString();
            return count;
        }

        private void ResetGame()
        {
            playerLayoutPanel.Controls.Clear();
            dealerLayoutPanel.Controls.Clear();

            playerCountLabel.Text = "0";
            dealerCountLabel.Text = "0";


            dealerLayoutPanel.Controls.Add(getNewCard(true));
            dealerLayoutPanel.Controls.Add(getNewCard());

            playerHit();
            playerHit();

            calcDealerValue();
            calcPlayerValue();
        }


        private void playerHit()
        {
            playerLayoutPanel.Controls.Add(getNewCard());
        }

        private void dealerTurn()
        {
            ((PictureBox)dealerLayoutPanel.Controls[0]).Image = null;
            while (calcDealerValue() <= 17)
            {
                dealerLayoutPanel.Controls.Add(getNewCard());
                Thread.Sleep(250);
            }
        }
        private PictureBox getNewCard(bool hidden = false)
        {

            int randomIndex = random.Next(0, deck.Count - 1);

            Card card = deck[randomIndex];

            PictureBox cardHolder = new PictureBox();
            cardHolder.Size = new Size(100, 140);

            if (hidden) { cardHolder.Image = miscImageList.Images[0]; }

            cardHolder.Tag = randomIndex;
            cardHolder.BackgroundImage = cardImageList.Images[cardImageList.Images.IndexOfKey(card.ImageName)];

            return cardHolder;
        }

        private void checkIfWon()
        {
            if(playerCountLabel.Text == "21")
            {

            }
        }

        private void dealButton_Click(object sender, EventArgs e)
        {
            ResetGame();

        }

        private void standButton_Click(object sender, EventArgs e)
        {
            dealerTurn();
        }
    }
}
