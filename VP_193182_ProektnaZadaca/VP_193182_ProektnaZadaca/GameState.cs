using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_193182_ProektnaZadaca
{
    public partial class GameState : Form
    {
        private bool blackjackDisplay = true;
        private String state{ get; set; }
        public GameState(String state)
        {
            InitializeComponent();
            this.state = state;
            this.StartPosition = FormStartPosition.CenterScreen;
            if (state.Equals("Blackjack lose"))
            {
                this.BackgroundImage = Properties.Resources.Blackjack;
                timer1.Start();
            }
            else if (state.Equals("Blackjack win"))
            {
                this.BackgroundImage = Properties.Resources.Blackjack;
                timer1.Start();
            }
            else if (state.Equals("Win"))
            {
                this.BackgroundImage = Properties.Resources.You_win;
            }else if (state.Equals("Lose"))
            {
                this.BackgroundImage = Properties.Resources.You_lose;
            }else if (state.Equals("Push")){
                this.BackgroundImage = Properties.Resources.Push;
            }
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BackgroundImage = base.BackgroundImage;
            if (state.Equals("Blackjack win"))
            {
                if (blackjackDisplay)
                {
                    this.BackgroundImage = Properties.Resources.You_win;
                    blackjackDisplay = false;
                }
                else
                {
                    this.BackgroundImage = Properties.Resources.Blackjack;
                    blackjackDisplay = true;
                }
            }
            else if((state.Equals("Blackjack lose")))
            {
                if (blackjackDisplay)
                {
                    this.BackgroundImage = Properties.Resources.You_lose;
                    blackjackDisplay = false;
                }
                else
                {
                    this.BackgroundImage = Properties.Resources.Blackjack;
                    blackjackDisplay = true;
                }
            }
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }
    }
}
