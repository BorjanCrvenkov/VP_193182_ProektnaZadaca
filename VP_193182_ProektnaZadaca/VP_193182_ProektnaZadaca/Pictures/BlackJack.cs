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

        int bet, balance;
        Deck deck;
        PlayerHand playerHand;
        DealerHand dealerHand;
        int dealerX, dealerY, playerX, playerY;

        public BlackJack()
        {
            InitializeComponent();
            dealer = true;
            this.BackgroundImage = Properties.Resources.BlackJack_Background;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            buttonControler();
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            btnDeal.Enabled = false;
            buttonControler();

            deck = new Deck();
            playerHand = new PlayerHand();
            dealerHand = new DealerHand(false);

            for (int i = 0; i < 2; i++)
            {
                playerHand.addCard(deck.generateCard());
                dealerHand.addCard(deck.generateCard());
            }

            Image flipped = Image.FromFile(@"Pictures\Cards\RedCardFlipped.png");

            playerX = 580;
            playerY = 370;

            g.DrawImage(playerHand.getCard(0).image, playerX, playerY,90,170);
            playerX += 95;
            g.DrawImage(playerHand.getCard(1).image, playerX , playerY,90,170);
            

            dealerX = 10;
            dealerY = 250;

            g.DrawImage(dealerHand.getCard(0).image, dealerX, dealerY,90,170);
            dealerX += 95;
            g.DrawImage(flipped, dealerX, dealerY, 90, 170);

            handValueUpdate(false);
            if (playerHand.getTotalValue() == 21)
            {
                MessageBox.Show("Blackjack! You win!");
                newDeal();
            }
            else if (dealerHand.Blackjack() && playerHand.getTotalValue() == 21)
            {
                MessageBox.Show("Blackjack! You win!");
                newDeal();
            }
            else if (dealerHand.Blackjack())
            {
                MessageBox.Show("Blackjack! The dealer wins!");
                newDeal();
            }
        }

        private void buttonControler()
        {
            if(btnDeal.Enabled == true)
            {
                btnHit.Enabled = false;
                btnStand.Enabled = false;
                btnDouble.Enabled = false;
            }
            else
            {
                btnHit.Enabled = true;
                btnStand.Enabled = true;
                btnDouble.Enabled = true;
            }
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            hit();
        }

        private void hit()
        {
            Graphics g = this.CreateGraphics();

            playerHand.addCard(deck.generateCard());
            playerX += 95;
            g.DrawImage(playerHand.getCard(playerHand.getCardCount() - 1).image, playerX, playerY, 90, 170);
            handValueUpdate(false);
            if (playerHand.getTotalValue() > 21)
            {
                MessageBox.Show("You bust, dealer wins!");
            }
            
            
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            stand();
        }

        private void handValueUpdate(bool newDeal)
        {
            if (newDeal)
            {
                lbDealerHand.Text = "Dealer's hand: 0";
                lbPlayerHand.Text = "Player's hand: 0";
            }
            else
            {
                lbDealerHand.Text = "Dealer's hand: " + dealerHand.getTotalValue();
                lbPlayerHand.Text = "Player's hand: " + playerHand.getTotalValue();
            }
        }

        private void stand()
        {
            Graphics g = this.CreateGraphics();
            dealerHand.stand = true;

            g.DrawImage(dealerHand.getCard(1).image, dealerX, dealerY, 90, 170);
            handValueUpdate(false);

            while (true)
            {
                if (dealerHand.getTotalValue() > 16)
                {
                    break;
                }
                dealerHand.addCard(deck.generateCard());
                dealerX += 95;
                g.DrawImage(dealerHand.getCard(dealerHand.getCardCount() - 1).image, dealerX, dealerY, 90, 170);
                handValueUpdate(false);
            }

            if (dealerHand.getTotalValue() > 21)
            {
                MessageBox.Show("The dealer busts, You win!");
                newDeal();
            }
            else if (dealerHand.getTotalValue() > playerHand.getTotalValue())
            {
                MessageBox.Show("The dealer has a higher score than you. The dealer wins!");
                newDeal();
            }
            else if (dealerHand.getTotalValue() < playerHand.getTotalValue())
            {
                MessageBox.Show("You have a higher score than the dealer. You win!");
                newDeal();
            }
            else
            {
                MessageBox.Show("It's a draw. Nobody wins!");
                newDeal();
            }

        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            DOUBLE();
        }

        private void DOUBLE()
        {

        }

        private void newDeal()
        {
            Graphics g = this.CreateGraphics();

            btnDeal.Enabled = true;
            buttonControler();

            g.Clear(Color.Crimson);
            this.BackgroundImage = Properties.Resources.BlackJack_Background;
            handValueUpdate(true);

        }

        private void pbDealer_Click(object sender, EventArgs e)
        {
            if (dealer)
            {
                pbDealer.Image = Properties.Resources.BlackJack_Dealer_Woman;
                dealer = false;
            }
            else
            {
                pbDealer.Image = Properties.Resources.BlackJack_Dealer_Man;
                dealer = true;
            }
        }
    }
}
