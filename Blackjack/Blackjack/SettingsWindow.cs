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
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void LoadSettings()
        {
            showLabelsBox.Checked = Properties.Settings.Default.showScore;
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.showScore = showLabelsBox.Checked;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
            this.Close();
        }
    }
}
