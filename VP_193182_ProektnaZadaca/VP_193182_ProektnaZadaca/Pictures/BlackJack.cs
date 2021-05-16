using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_193182_ProektnaZadaca.Pictures
{
    public partial class BlackJack : Form
    {
        public bool dealer { get; set; }
        public BlackJack()
        {
            InitializeComponent();
            dealer = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (dealer)
            {
                pictureBox1.Image = Properties.Resources.BlackJack_Dealer_Woman;
                dealer = false;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.BlackJack_Dealer_Man;
                dealer = false;
            }
        }

        
    }
}
