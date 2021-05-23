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
    public partial class Info : Form
    {
        int count;
        public Info()
        {
            InitializeComponent();
            lbText.Text = "Select information using the drop box";
            count = 0;
            lbText.Text = "Blackjack is a truly iconic game, the ultimate casino challenge.\n The goal is to win as much money from the house (represented by a dealer).\nThe dealer, unlike you , does not make his own decisions, so it’s all about your patience and luck.\nEnjoy your game.";
            lbInfo.Text = "Blackjack";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelUpdate()
        {
            if (count == 0)
            {
                lbText.Text = "Blackjack is a truly iconic game, the ultimate casino challenge.\nThe goal is to win as much money from the house (represented by a dealer).\nThe dealer, unlike you , does not make his own decisions, so it’s all about your patience and luck.\nEnjoy your game.";
                lbInfo.Text = "Blackjack";
            }
            else if (count == 1)
            {
                lbText.Text = "At the start of each round, you will need to make a BET, it can be anywhere from $1 to All In.\nBy left clicking your chips you place a bet on the table, and by right clicking them you take the chips back.\nOnce cards are dealt, bets cannot be changed until next round.\nAn All-In button will bet all your money at once!";
                lbInfo.Text = "Bets and Chips";
            }
            else if (count == 2)
            {
                lbText.Text = "Once a bet is made, click DEAL.\nThe dealer will give you two cards which form your HAND, and two cards to themselves which forms the dealer’s hand.\nOne of the dealer’s cards will be hidden at first.\nTo win you need to ensure the combined value of your cards is greater than that of the dealer.";
                lbInfo.Text = "Deal";
            }
            else if (count == 3)
            {
                lbText.Text = "You can add more cards, one by one, by choosing to HIT, your goal is to get as close as you can to 21 without exceeding 21.\nWhoever gets more than 21 loses automatically.\nIn case you are ready to play the hand, click STAND.\nDealer will then reveal their hidden card, and must always HIT if they have 16 or lower.\nWhen they have 17 or more, they will stop hitting.";
                lbInfo.Text = "Hit and Stand";
            }
            else if (count == 4)
            {
                lbText.Text = "A->11 if the other cards combined are less than 10\nJ-> 10\nQ-> 10\nK-> 10\nAny other card is worth it’s normal value";
                lbInfo.Text = "Card value";
            }
            else if (count == 5)
            {
                lbText.Text = "Queen + 10  -> 20\nKing + Jack->  20\nKing + Ace-> 21\nAce + 9-> 20 but if 7 is added it becomes 17. 1 + 9 + 7 = 17";
                lbInfo.Text = "Card examples";
            }
            else if (count == 6)
            {
                lbText.Text = "Whoever gets exactly 21, in most cases wins.\nA tie (PUSH) will simply refund the bet to the player.\nGoing over 21 (busting) is an instant loss.\nYou win by making the dealer go over 21 or by having a hire value against him, such as 20 against 19.\nBlackjack, a natural 21 (with the two initial cards) beats any combination even if the dealer has Blackjack as well.\nWinning will reward you with double your bet.\nIf your bet is $1000 and you win you will get +$2000.\nA blackjack has a slightly higher payoff of 3 to 2, such as $2500 for a bet of $1000, or $1500 benefit.";
                lbInfo.Text = "Winning";
            }
            else if (count == 7)
            {
                lbText.Text = "Unlike the dealer, you can DOUBLE your bet once cards are dealt (before you HIT or STAND).\nYou will have to take exactly one more card, and then immediately STAND.";
                lbInfo.Text = "Double";

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            count++;
            if (count == 8)
            {
                count = 0;
            }
            labelUpdate();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            count--;
            if (count == -1)
            {
                count = 7;
            }
            labelUpdate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
