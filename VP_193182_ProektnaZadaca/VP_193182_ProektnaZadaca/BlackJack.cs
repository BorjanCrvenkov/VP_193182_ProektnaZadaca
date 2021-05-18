using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_193182_ProektnaZadaca.Pictures
{
    public partial class BlackJack : Form
    {
        public bool dealer { get; set; }

        double bet, balance;
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
            bet = 0;
            balance = 1000;
            DoubleBuffered = true;
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

            playerX = 460;
            playerY = 370;

            g.DrawImage(playerHand.getCard(0).image, playerX, playerY,90,170);
            handValueUpdate(false);
            Thread.Sleep(100);
            playerX += 95;
            g.DrawImage(playerHand.getCard(1).image, playerX , playerY,90,170);
            handValueUpdate(false);
            Thread.Sleep(100);

            dealerX = 10;
            dealerY = 250;

            g.DrawImage(dealerHand.getCard(0).image, dealerX, dealerY,90,170);
            handValueUpdate(false);
            Thread.Sleep(100);
            dealerX += 95;
            g.DrawImage(flipped, dealerX, dealerY, 90, 170);
            handValueUpdate(false);
            Thread.Sleep(100);

            handValueUpdate(false);
            if (playerHand.getTotalValue() == 21)
            {
                MessageBox.Show("Blackjack! You win!");
                balance += bet + (bet * 0.5);
                newDeal();
            }
            else if (dealerHand.Blackjack() && playerHand.getTotalValue() == 21)
            {
                MessageBox.Show("Blackjack! You win!");
                balance += bet + (bet * 0.5);
                newDeal();
            }
            else if (dealerHand.Blackjack())
            {
                MessageBox.Show("Blackjack! The dealer wins!");
                g.DrawImage(dealerHand.getCard(1).image, dealerX, dealerY, 90, 170);
                handValueUpdate(false);
                Thread.Sleep(200);
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
            Thread.Sleep(100);
            if (playerHand.getTotalValue() > 21)
            {
                MessageBox.Show("You bust, dealer wins!");
                newDeal();
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
                tbBet.Text = "Your bet: 0";
                bet = 0;
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
            Thread.Sleep(200);
            handValueUpdate(false);

            while (true)
            {
                if (dealerHand.getTotalValue() > 16)
                {
                    break;
                }
                dealerHand.addCard(deck.generateCard());
                handValueUpdate(false);
                dealerX += 95;
                g.DrawImage(dealerHand.getCard(dealerHand.getCardCount() - 1).image, dealerX, dealerY, 90, 170);
                Thread.Sleep(100);
            }

            if (playerHand.getTotalValue() == dealerHand.getTotalValue())
            {
                MessageBox.Show("It's a draw. Nobody wins!");
                balance += bet;
                newDeal();
            }else if (dealerHand.getTotalValue() > 21){
                MessageBox.Show("The dealer busts, You win!");
                balance += bet * 2;
                newDeal();
            }else if (dealerHand.getTotalValue() > playerHand.getTotalValue())
            {
                MessageBox.Show("The dealer has a higher score than you. The dealer wins!");
                newDeal();
            }else if (dealerHand.getTotalValue() < playerHand.getTotalValue())
            {
                MessageBox.Show("You have a higher score than the dealer. You win!");
                balance += bet * 2;
                newDeal();
            }
            

        }

        private void moneyStatus()
        {
            lbBalance.Text = "BALANCE: " + balance.ToString();
            tbBet.Text = "Your bet: " + bet.ToString();
        }

        private void pbChip5_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouse = (MouseEventArgs)e;
            if (mouse.Button == MouseButtons.Left)
            {
                if (balance >= 5)
                {
                    bet += 5;
                    balance -= 5;
                }

            }
            else
            {
                if (bet >= 5)
                {
                    bet -= 5;
                    balance += 5;
                }
            }
            moneyStatus();

        }

        private void pbChip10_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouse = (MouseEventArgs)e;
            if (mouse.Button == MouseButtons.Left)
            {
                if (balance >= 10)
                {
                    bet += 10;
                    balance -= 10;
                }

            }
            else
            {
                if (bet >= 10)
                {
                    bet -= 10;
                    balance += 5;
                }
            }
            moneyStatus();
        }

        private void pbChip25_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouse = (MouseEventArgs)e;
            if (mouse.Button == MouseButtons.Left)
            {
                if (balance >= 25)
                {
                    bet += 25;
                    balance -= 25;
                }

            }
            else
            {
                if (bet >= 25)
                {
                    bet -= 25;
                    balance += 25;
                }
            }
            moneyStatus();
        }

        private void pbChip50_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouse = (MouseEventArgs)e;
            if (mouse.Button == MouseButtons.Left)
            {
                if (balance >= 50)
                {
                    bet += 50;
                    balance -= 50;
                }

            }
            else
            {
                if (bet >= 50)
                {
                    bet -= 50;
                    balance += 50;
                }
            }
            moneyStatus();
        }

        private void pbChip100_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouse = (MouseEventArgs)e;
            if (mouse.Button == MouseButtons.Left)
            {
                if (balance >= 100)
                {
                    bet += 100;
                    balance -= 100;
                }

            }
            else
            {
                if (bet >= 100)
                {
                    bet -= 100;
                    balance += 100;
                }
            }
            moneyStatus();
        }

        private void pbChip500_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouse = (MouseEventArgs)e;
            if (mouse.Button == MouseButtons.Left)
            {
                if (balance >= 500)
                {
                    bet += 500;
                    balance -= 500;
                }

            }
            else
            {
                if (bet >= 500)
                {
                    bet -= 500;
                    balance += 500;
                }
            }
            moneyStatus();
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            if (balance >= bet)
            {
                balance -= bet;
                bet *= 2;
                moneyStatus();
                DOUBLE();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbChip1000_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouse = (MouseEventArgs)e;
            if (mouse.Button == MouseButtons.Left)
            {
                if (balance >= 1000)
                {
                    bet += 1000;
                    balance -= 1000;
                }

            }
            else
            {
                if (bet >= 1000)
                {
                    bet -= 1000;
                    balance += 1000;
                }
            }
            moneyStatus();
        }

        

        

        private void DOUBLE()
        {
            Graphics g = this.CreateGraphics();

            btnDouble.Enabled = false;
            playerHand.addCard(deck.generateCard());
            playerX += 95;
            g.DrawImage(playerHand.getCard(playerHand.getCardCount() - 1).image, playerX, playerY, 90, 170);
            handValueUpdate(false);
            Thread.Sleep(100);
            handValueUpdate(false);

            if (playerHand.getTotalValue() > 21)
            {
                MessageBox.Show("You bust, dealer wins!");
                newDeal();
            }
            else
            {
                stand();
            }



        }

        private void newDeal()
        {
            moneyStatus();
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
