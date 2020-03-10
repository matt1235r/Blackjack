using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            playerLayoutPanel.Controls.Add(new Card("Spade", 8));
            CountPlayerHand();
        }

        private void CountPlayerHand()
        {
            int count = 0;
            foreach (Control c in playerLayoutPanel.Controls)
            {
                count = count + ((Card)c).getValue();
            }
            playerCountLabel.Text = count.ToString();
        }

        private void CountDealerHand()
        {
            int count = 0;
            foreach (Control c in dealerLayoutPanel.Controls)
            {
                count = count + ((Card)c).getValue();
            }
            dealerCountLabel.Text = count.ToString();
        }
    }
}
