using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VP_193182_ProektnaZadaca.Pictures;

namespace VP_193182_ProektnaZadaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuitGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit game?", "Quit Game", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Info forma = new Info();

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            BlackJack blackjack = new BlackJack();
        }
    }
}
