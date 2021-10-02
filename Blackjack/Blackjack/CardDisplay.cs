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
            foreach (Image s in cardImageList.Images)
            {
                Panel card = new Panel();
                card.BackgroundImage = s;
                card.Size = new Size(100, 140);
                flowLayoutPanel1.Controls.Add(card);
            }
        }
    }
}
