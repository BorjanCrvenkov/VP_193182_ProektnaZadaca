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
            this.StartPosition = FormStartPosition.CenterScreen;

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

            addAndDrawCard("player");
            Thread.Sleep(300);

            addAndDrawCard("dealer");

            addAndDrawCard("player");
            Thread.Sleep(300);

            addAndDrawCard("dealer");

            dealState();
        }

        //NEW DEAL
        private void newDeal()
        {
            lbDealerHand.Visible = false;
            lbPlayerHand.Visible = false;
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
                GameState gameState = new GameState("Lose");
                gameState.ShowDialog();
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
                GameState gameState = new GameState("Push");
                gameState.ShowDialog();
                balance += bet;
                newDeal();
            }
            else if (dealerHand.getTotalValue() > 21)
            {
                GameState gameState = new GameState("Win");
                gameState.ShowDialog();
                balance += bet * 2;
                newDeal();
            }
            else if (dealerHand.getTotalValue() > playerHand.getTotalValue())
            {
                GameState gameState = new GameState("Lose");
                gameState.ShowDialog();
                newDeal();
            }
            else if (dealerHand.getTotalValue() < playerHand.getTotalValue())
            {
                GameState gameState = new GameState("Win");
                gameState.ShowDialog();
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

            addAndDrawCard("player");
            Thread.Sleep(300);
            if (playerHand.getTotalValue() > 21)
            {
                GameState gameState = new GameState("Lose");
                gameState.ShowDialog();
                newDeal();
            }
            else
            {
                stand();
            }
        }

        //SUPPORTING FUNCTIONS
        //ADD AND DRAW CARD
        private void addAndDrawCard(String playerOrDealer)
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
                if (dealerHand.hand.Count == 2)
                {
                    g.DrawImage(this.flipped, dealerX, dealerY, cardWidth, cardHeight);
                }
                else
                {
                    g.DrawImage(card.image, dealerX, dealerY, cardWidth, cardHeight);
                }
                showCardValues();
                Thread.Sleep(300);
            }
        }

        //STATE AFTER THE DEAL DOES ANYONE HAVE BLACKJACK?
        private void dealState()
        {
            Graphics g = this.CreateGraphics();

            if (playerHand.getTotalValue() == 21)
            {
                GameState gameState = new GameState("Blackjack win");
                gameState.ShowDialog();
                g.DrawImage(dealerHand.getCard(1).image, dealerX, dealerY, cardWidth, cardHeight);
                Thread.Sleep(1000);
                balance += bet + (bet * 0.5);
                newDeal();
            }
            else if (dealerHand.Blackjack() && playerHand.getTotalValue() == 21)
            {
                GameState gameState = new GameState("Blackjack win");
                gameState.ShowDialog();
                g.DrawImage(dealerHand.getCard(1).image, dealerX, dealerY, cardWidth, cardHeight);
                Thread.Sleep(1000);
                balance += bet + (bet * 0.5);
                newDeal();
            }
            else if (dealerHand.Blackjack())
            {
                GameState gameState = new GameState("Blackjack lose");
                gameState.ShowDialog();
                g.DrawImage(dealerHand.getCard(1).image, dealerX, dealerY, cardWidth, cardHeight);
                Thread.Sleep(1000);
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
                opbChip5.Enabled = true;
                opbChip10.Enabled = true;
                opbChip25.Enabled = true;
                opbChip50.Enabled = true;
                opbChip100.Enabled = true;
                opbChip500.Enabled = true;
                opbChip1000.Enabled = true;
                opbChip2000.Enabled = true;
            }
            else
            {
                btnHit.Enabled = true;
                btnStand.Enabled = true;
                btnDouble.Enabled = true;

                btnAllIn.Enabled = false;
                opbChip5.Enabled = false;
                opbChip10.Enabled = false;
                opbChip25.Enabled = false;
                opbChip50.Enabled = false;
                opbChip100.Enabled = false;
                opbChip500.Enabled = false;
                opbChip1000.Enabled = false;
                opbChip2000.Enabled = false;
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

        private void opbChip5_Click(object sender, EventArgs e)
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

        private void opbChip10_Click(object sender, EventArgs e)
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

        private void opbChip25_Click(object sender, EventArgs e)
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

        private void opbChip50_Click(object sender, EventArgs e)
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

        private void opbChip100_Click(object sender, EventArgs e)
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

        private void opbChip500_Click(object sender, EventArgs e)
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
        private void opbChip1000_Click(object sender, EventArgs e)
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

        private void opbChip2000_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouse = (MouseEventArgs)e;
            if (mouse.Button == MouseButtons.Left)
            {
                raiseBet(2000);

            }
            else
            {
                lowerBet(2000);
            }
        }

        private void ovalPictureBox1_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }

        private void btnAllIn_Click(object sender, EventArgs e)
        {
            bet += balance;
            balance = 0;
            moneyStatus();
        }

        //CARD POSITION RESET
        private void cardPositionReset()
        {
            playerX = 430;
            playerY = 360;

            dealerX = -85;
            dealerY = 190;
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

        //SHOWS LABEL WITH SCORE
        private void showCardValues()
        {
            if (playerHand.hand.Count >= 2 && dealerHand.hand.Count >= 2)
            {
                lbPlayerHand.Visible = true;
                lbDealerHand.Visible = true;
            }
        }
    }
}