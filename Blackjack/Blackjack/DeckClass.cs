using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    static class DeckClass
    {
        public static List<Card> allCards = new List<Card>()
            {
                #region spades

                new Card() { Value  = 2, LongName = "Two Spades", ImageName = "_2S" },
                new Card() { Value = 3, LongName = "Three Spades", ImageName = "_3S" },
                new Card() { Value = 4, LongName =  "Four Spades", ImageName = "_4S" },
                new Card() { Value = 5, LongName = "Five Spades", ImageName = "_5S" },
                new Card() { Value = 6, LongName = "Six Spades", ImageName = "_6S" },
                new Card() { Value = 7, LongName = "Seven Spades", ImageName = "_7S" },
                new Card() { Value = 8, LongName = "Eight Spades", ImageName = "_8S" },
                new Card() { Value = 9, LongName = "Nine Spades", ImageName = "_9S" },
                new Card() { Value = 10, LongName = "Ten Spades", ImageName = "_10S" },
                new Card() { Value = 10, LongName = "Jack Spades", ImageName = "JS" },
                new Card() { Value = 10, LongName = "Queen Spades", ImageName = "QS" },
                new Card(){ Value = 10, LongName = "King Spades", ImageName = "KS" },
                new Card(){ Value = 11, LongName = "Ace Spades", ImageName = "AS" },

                #endregion

                #region diamonds

                new Card() { Value  = 2, LongName = "Two Diamonds", ImageName = "_2D" },
                new Card() { Value = 3, LongName = "Three Diamonds", ImageName = "_3D" },
                new Card() { Value = 4, LongName =  "Four Diamonds", ImageName = "_4D" },
                new Card() { Value = 5, LongName = "Five Diamonds", ImageName = "_5D" },
                new Card() { Value = 6, LongName = "Six Diamonds", ImageName = "_6D" },
                new Card(){ Value = 7, LongName = "Seven Diamonds", ImageName = "_7D" },
                new Card() { Value = 8, LongName = "Eight Diamonds", ImageName = "_8D" },
                new Card() { Value = 9, LongName = "Nine Diamonds", ImageName = "_9D" },
                new Card() { Value = 10, LongName = "Ten Diamonds", ImageName = "_10D" },
                new Card() { Value = 10, LongName = "Jack Diamonds", ImageName = "JD" },
                new Card() { Value = 10, LongName = "Queen Diamonds", ImageName = "QD" },
                new Card(){ Value = 10, LongName = "King Diamonds", ImageName = "KD" },
                new Card(){ Value = 11, LongName = "Ace Diamonds", ImageName = "AD" },

                #endregion

                #region clubs

                new Card() { Value  = 2, LongName = "Two Clubs", ImageName = "_2C" },
                new Card() { Value = 3, LongName = "Three Clubs", ImageName = "_3C" },
                new Card() { Value = 4, LongName =  "Four Clubs", ImageName = "_4C" },
                new Card() { Value = 5, LongName = "Five Clubs", ImageName = "_5C" },
                new Card() { Value = 6, LongName = "Six Clubs", ImageName = "_6C" },
                new Card(){ Value = 7, LongName = "Seven Clubs", ImageName = "_7C" },
                new Card() { Value = 8, LongName = "Eight Clubs", ImageName = "_8C" },
                new Card() { Value = 9, LongName = "Nine Clubs", ImageName= "_9C" },
                new Card() { Value = 10, LongName = "Ten Clubs", ImageName = "_10C" },
                new Card() { Value = 10, LongName = "Jack Clubs", ImageName = "JC" },
                new Card() { Value = 10, LongName = "Queen Clubs", ImageName = "QC" },
                new Card(){ Value = 10, LongName = "King Clubs", ImageName = "KC" },
                new Card(){ Value = 11, LongName = "Ace Clubs", ImageName = "AC" },

                #endregion

                #region hearts

                new Card() { Value  = 2, LongName = "Two Hearts", ImageName = "_2H" },
                new Card() { Value = 3, LongName = "Three Hearts", ImageName = "_3H" },
                new Card() { Value = 4, LongName =  "Four Hearts", ImageName = "_4H" },
                new Card() { Value = 5, LongName = "Five Hearts", ImageName = "_5H" },
                new Card() { Value = 6, LongName = "Six Hearts", ImageName = "_6H" },
                new Card(){ Value = 7, LongName = "Seven Hearts", ImageName = "_7H" },
                new Card() { Value = 8, LongName = "Eight Hearts", ImageName = "_8H" },
                new Card() { Value = 9, LongName = "Nine Hearts", ImageName = "_9H" },
                new Card() { Value = 10, LongName = "Ten Hearts", ImageName = "_10H" },
                new Card() { Value = 10, LongName = "Jack Hearts", ImageName = "JH" },
                new Card() { Value = 10, LongName = "Queen Hearts", ImageName = "QH" },
                new Card(){ Value = 10, LongName = "King Hearts", ImageName = "KH" },
                new Card(){ Value = 11, LongName = "Ace Hearts", ImageName = "AH" }

                #endregion
            };

        public static List<Card> currentDeck = new List<Card>();

        public static Random random = new Random();

        public static ImageList cardImageList = new ImageList();

        public static Point[] playercords = new Point[] { new Point { X = 410, Y = 81 }, new Point { X = 771, Y = 24 }, new Point { X = 46, Y = 21 }, new Point { X = 221, Y = 67 }, new Point { X = 594, Y = 67 }};


        public static void playSound(System.IO.UnmanagedMemoryStream path)
        {
            System.IO.Stream str = path;
            SoundPlayer snd = new SoundPlayer(str);

            if (!Properties.Settings.Default.gameMuted) { snd.Play(); }

        }

        public static void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            //Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                //Console.WriteLine("stop wait timer");
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        public static void getNewCard(PictureBox parentControl, bool hidden = false)
        {
            //plays card flipping sound
            playSound(Properties.Resources.cardSlide6);

            //chooses a random card index from the collection of cards.
            int randomIndex = random.Next(0, currentDeck.Count -1);

            //the chosen card is removed from the current deck, so it isnt chosen twice.
            currentDeck.RemoveAt(randomIndex);

            //uses the random index to initiate a new Card instance.
            Card card = currentDeck[randomIndex];

            //creates the container to hold the cardimage.
            PictureBox cardHolder = new PictureBox();
            cardHolder.Size = new Size(80, 120);

            //if card needs to be hidden then the image of the back of the card is displayed on top of the cards image.
            if (hidden) { cardHolder.Image = (Image) Properties.Resources.ResourceManager.GetObject("blue_back"); }

            //the card holder control is given the appropriate values and the layout is setup so the cards overlap 
            //like a normal deck of cards.
            cardHolder.Tag = card.Value;
            
            cardHolder.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(card.ImageName);
            try
            {
                cardHolder.BackgroundImage.Tag = card.ImageName;
            }
            catch (Exception)
            {

                
            }
            
            cardHolder.Anchor = (AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
            cardHolder.BackgroundImageLayout = ImageLayout.Stretch;
            cardHolder.SizeMode = PictureBoxSizeMode.StretchImage;

            int cord = parentControl.Controls.Count * 20;
            if (parentControl.Controls.Count > 0)
            {
                cardHolder.Location = new Point((parentControl.Controls[parentControl.Controls.Count - 1].Location.X) + cord, cardHolder.Location.Y);

            }

            parentControl.Controls.Add(cardHolder);
            cardHolder.BringToFront();
        }
    }

}
