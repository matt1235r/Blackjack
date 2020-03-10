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
    public partial class Card : UserControl
    {
        //Internal Variables

        private int number;
        private string image;
        private string name;
        private string suit;

        public Card(string argSuit, int argNumber)
        {
            InitializeComponent();
            suit = argSuit;
            number = argNumber;
        }

        private void Card_Load(object sender, EventArgs e)
        {
            label1.Text = number.ToString();
            label2.Text = suit;
        }


        //Public Functions

        public string getSuit()
        {
            return suit;
        }

        public int getValue()
        {
            return number;    
        }
    }
}
