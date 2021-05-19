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
        public bool dealer = true;

        double bet, balance;

        Deck deck;
        PlayerHand playerHand;
        DealerHand dealerHand;

        int dealerX, dealerY, playerX, playerY;
        int cardHeight = 170;
        int cardWidth = 90;

        Image flipped = Image.FromFile(@"Pictures\Cards\RedCardFlipped.png");
        

        //MAIN FUNCTIONS
        public BlackJack()
        {
            InitializeComponent();

            this.BackgroundImage = Properties.Resources.BlackJack_Background;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            buttonControler();

            bet = 0;
            balance = 1000;

            DoubleBuffered = true;
            cardPositionReset();
        }

        //BUTTON DEAL
        private void btnDeal_Click(object sender, EventArgs e)
        {
            btnDeal.Enabled = false;
            buttonControler();

            deck = new Deck();
            deck.shuffle();

            playerHand = new PlayerHand();
            dealerHand = new DealerHand(false);

            addAndDrawCard("player", false);
            Thread.Sleep(300);

            addAndDrawCard("dealer", false);

            addAndDrawCard("player", false);
            Thread.Sleep(300);

            addAndDrawCard("dealer", true);

            dealState();
        }

        //NEW DEAL
        private void newDeal()
        {
            lbDealerHand.Text = "Dealer's hand: 0";
            lbPlayerHand.Text = "Player's hand: 0";
            tbBet.Text = "Your bet: $0";

            bet = 0;
            moneyStatus();

            Graphics g = this.CreateGraphics();

            btnDeal.Enabled = true;
            buttonControler();

            g.Clear(Color.Crimson);
            this.BackgroundImage = Properties.Resources.BlackJack_Background;

            cardPositionReset();
        }

        //BUTTON HIT
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
            handValueUpdate("player");
            if (playerHand.getTotalValue() > 21)
            {
                MessageBox.Show("You bust, dealer wins!");
                newDeal();
            }
        }

        //BUTTON STAND
        private void btnStand_Click(object sender, EventArgs e)
        {
            stand();
        }

        private void stand()
        {
            Graphics g = this.CreateGraphics();
            dealerHand.stand = true;

            g.DrawImage(dealerHand.getCard(1).image, dealerX, dealerY, 90, 170);
            handValueUpdate("dealer");

            while (true)
            {
                if (dealerHand.getTotalValue() > 16)
                {
                    break;
                }
                dealerHand.addCard(deck.generateCard());
                handValueUpdate("dealer");
                dealerX += 95;
                Thread.Sleep(300);
                g.DrawImage(dealerHand.getCard(dealerHand.getCardCount() - 1).image, dealerX, dealerY, 90, 170);;
            }
            standState();
        }

        //STAND STATE
        private void standState()
        {
            if (playerHand.getTotalValue() == dealerHand.getTotalValue())
            {
                MessageBox.Show("It's a draw. Nobody wins!");
                balance += bet;
                newDeal();
            }
            else if (dealerHand.getTotalValue() > 21)
            {
                MessageBox.Show("The dealer busts, You win!");
                balance += bet * 2;
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
                balance += bet * 2;
                newDeal();
            }
        }

        //BUTTON DOUBLE       
        private void btnDouble_Click(object sender, EventArgs e)
        {
            if (balance >= bet)
            {
                balance -= bet;
                bet *= 2;
                moneyStatus();
                DOUBLE();
                handValueUpdate("player");
            }
        }

        private void DOUBLE()
        {
            Graphics g = this.CreateGraphics();

            btnDouble.Enabled = false;

            addAndDrawCard("player", false);
            Thread.Sleep(300);
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

        //SUPPORTING FUNCTIONS
        //ADD AND DRAW CARD
        private void addAndDrawCard(String playerOrDealer, bool flipped)
        {
            Graphics g = this.CreateGraphics();
            Card card = deck.generateCard();

            if (playerOrDealer.Equals("player"))
            {
                playerHand.addCard(card);
                handValueUpdate("player");
                playerX += 95;
                g.DrawImage(card.image, playerX, playerY, cardWidth, cardHeight);
            }
            else
            {
                dealerHand.addCard(card);
                handValueUpdate("dealer");
                dealerX += 95;
                if (flipped)
                {
                    g.DrawImage(this.flipped, dealerX, dealerY, cardWidth, cardHeight);
                }
                else
                {
                    g.DrawImage(card.image, dealerX, dealerY, cardWidth, cardHeight);
                }
                Thread.Sleep(300);
            }
        }

        //STATE AFTER THE DEAL DOES ANYONE HAVE BLACKJACK?
        private void dealState()
        {
            Graphics g = this.CreateGraphics();

            if (playerHand.getTotalValue() == 21)
            {
                MessageBox.Show("Blackjack! You win!");
                g.DrawImage(dealerHand.getCard(1).image, dealerX, dealerY, cardWidth, cardHeight);
                balance += bet + (bet * 0.5);
                newDeal();
            }
            else if (dealerHand.Blackjack() && playerHand.getTotalValue() == 21)
            {
                MessageBox.Show("Blackjack! You win!");
                g.DrawImage(dealerHand.getCard(1).image, dealerX, dealerY, cardWidth, cardHeight);
                balance += bet + (bet * 0.5);
                newDeal();
            }
            else if (dealerHand.Blackjack())
            {
                MessageBox.Show("Blackjack! The dealer wins!");
                g.DrawImage(dealerHand.getCard(1).image, dealerX, dealerY, cardWidth, cardHeight);
                newDeal();
            }
        }

        //HAND VALUE UPDATE 
        private void handValueUpdate(string playerOrDealer)
        {
            if (playerOrDealer.Equals("player"))
            {
                lbPlayerHand.Text = "Player's hand: " + playerHand.getTotalValue();
            }
            else
            {
                if(dealerHand.getCard(0)!= null)
                {
                    lbDealerHand.Text = "Dealer's hand: " + dealerHand.getTotalValue();  
                }
            }

        }


        //BUTTON CONTROLER IF A DEAL IS ACTIVE YOU CAN PLAY HIT,STAND OR DOUBLE IF NOT YOU CAN ONLY USE NEW DEAL
        private void buttonControler()
        {
            if (btnDeal.Enabled == true)
            {
                btnHit.Enabled = false;
                btnStand.Enabled = false;
                btnDouble.Enabled = false;

                btnAllIn.Enabled = true;
                pbChip5.Enabled = true;
                pbChip10.Enabled = true;
                pbChip25.Enabled = true;
                pbChip50.Enabled = true;
                pbChip100.Enabled = true;
                pbChip500.Enabled = true;
                pbChip1000.Enabled = true;
            }
            else
            {
                btnHit.Enabled = true;
                btnStand.Enabled = true;
                btnDouble.Enabled = true;

                btnAllIn.Enabled = false;
                pbChip5.Enabled = false;
                pbChip10.Enabled = false;
                pbChip25.Enabled = false;
                pbChip50.Enabled = false;
                pbChip100.Enabled = false;
                pbChip500.Enabled = false;
                pbChip1000.Enabled = false;
            }
        }

        // CHIPS AND MONEY STATUS

        private void raiseBet(int value)
        {
            if (balance >= value)
            {
                bet += value;
                balance -= value;
            }
            moneyStatus();
        }

        private void lowerBet(int value)
        {

            if (bet >= value)
            {
                bet -= value;
                balance += value;
            }
            moneyStatus();
        }

        private void moneyStatus()
        {
            lbBalance.Text = "BALANCE: $" + balance.ToString();
            tbBet.Text = "Your bet: $" + bet.ToString();
        }

        private void pbChip5_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouse = (MouseEventArgs)e;
            if (mouse.Button == MouseButtons.Left)
            {
                raiseBet(5);

            }
            else
            {
                lowerBet(5);
            }


        }

        private void pbChip10_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouse = (MouseEventArgs)e;
            if (mouse.Button == MouseButtons.Left)
            {
                raiseBet(10);

            }
            else
            {
                lowerBet(10);
            }
        }

        private void pbChip25_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouse = (MouseEventArgs)e;
            if (mouse.Button == MouseButtons.Left)
            {
                raiseBet(25);

            }
            else
            {
                lowerBet(25);
            }
        }

        private void pbChip50_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouse = (MouseEventArgs)e;
            if (mouse.Button == MouseButtons.Left)
            {
                raiseBet(50);

            }
            else
            {
                lowerBet(50);
            }
        }

        private void pbChip100_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouse = (MouseEventArgs)e;
            if (mouse.Button == MouseButtons.Left)
            {
                raiseBet(100);

            }
            else
            {
                lowerBet(100);
            }
        }

        private void pbChip500_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouse = (MouseEventArgs)e;
            if (mouse.Button == MouseButtons.Left)
            {
                raiseBet(500);

            }
            else
            {
                lowerBet(500);
            }
        }

        private void btnAllIn_Click(object sender, EventArgs e)
        {
            bet += balance;
            balance = 0;
            moneyStatus();
        }

        private void pbChip1000_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouse = (MouseEventArgs)e;
            if (mouse.Button == MouseButtons.Left)
            {
                raiseBet(1000);

            }
            else
            {
                lowerBet(1000);
            }
        }

        //CARD POSITION RESET
        private void cardPositionReset()
        {
            playerX = 485;
            playerY = 400;

            dealerX = -85;
            dealerY = 250;
        }

        //CLOSE GAME
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //DEALER IMAGE CHANGE
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