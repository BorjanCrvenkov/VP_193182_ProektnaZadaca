
namespace VP_193182_ProektnaZadaca.Pictures
{
    partial class BlackJack
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbBet = new System.Windows.Forms.TextBox();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.lbBalance = new System.Windows.Forms.Label();
            this.lbPlayerHand = new System.Windows.Forms.Label();
            this.btnDeal = new System.Windows.Forms.Button();
            this.lbDealerHand = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbChip1000 = new System.Windows.Forms.PictureBox();
            this.pbDealer = new System.Windows.Forms.PictureBox();
            this.pbChip500 = new System.Windows.Forms.PictureBox();
            this.pbChip100 = new System.Windows.Forms.PictureBox();
            this.pbChip10 = new System.Windows.Forms.PictureBox();
            this.pbChip50 = new System.Windows.Forms.PictureBox();
            this.pbChip5 = new System.Windows.Forms.PictureBox();
            this.pbChip25 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChip1000)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChip500)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChip100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChip10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChip50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChip5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChip25)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBet
            // 
            this.tbBet.Enabled = false;
            this.tbBet.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBet.Location = new System.Drawing.Point(332, 250);
            this.tbBet.Multiline = true;
            this.tbBet.Name = "tbBet";
            this.tbBet.ReadOnly = true;
            this.tbBet.Size = new System.Drawing.Size(234, 28);
            this.tbBet.TabIndex = 13;
            this.tbBet.Text = "Your bet: 0";
            // 
            // btnHit
            // 
            this.btnHit.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(611, 683);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(149, 69);
            this.btnHit.TabIndex = 14;
            this.btnHit.Text = "HIT";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStand.Location = new System.Drawing.Point(842, 683);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(149, 69);
            this.btnStand.TabIndex = 15;
            this.btnStand.Text = "STAND";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDouble.Location = new System.Drawing.Point(1061, 683);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(149, 69);
            this.btnDouble.TabIndex = 16;
            this.btnDouble.Text = "DOUBLE";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalance.Location = new System.Drawing.Point(12, 26);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(146, 23);
            this.lbBalance.TabIndex = 17;
            this.lbBalance.Text = "BALANCE: 1000";
            // 
            // lbPlayerHand
            // 
            this.lbPlayerHand.AutoSize = true;
            this.lbPlayerHand.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerHand.Location = new System.Drawing.Point(607, 399);
            this.lbPlayerHand.Name = "lbPlayerHand";
            this.lbPlayerHand.Size = new System.Drawing.Size(117, 23);
            this.lbPlayerHand.TabIndex = 18;
            this.lbPlayerHand.Text = "Your hand: 0";
            // 
            // btnDeal
            // 
            this.btnDeal.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeal.Location = new System.Drawing.Point(588, 248);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(258, 30);
            this.btnDeal.TabIndex = 19;
            this.btnDeal.Text = "DEAL";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // lbDealerHand
            // 
            this.lbDealerHand.AutoSize = true;
            this.lbDealerHand.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDealerHand.Location = new System.Drawing.Point(12, 270);
            this.lbDealerHand.Name = "lbDealerHand";
            this.lbDealerHand.Size = new System.Drawing.Size(146, 23);
            this.lbDealerHand.TabIndex = 20;
            this.lbDealerHand.Text = "Dealer\'s hand: 0";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 636);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(550, 28);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "Left click increases your bet, right click decreases your bet";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VP_193182_ProektnaZadaca.Properties.Resources.Blackjack_EndGame;
            this.pictureBox1.Location = new System.Drawing.Point(866, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbChip1000
            // 
            this.pbChip1000.Image = global::VP_193182_ProektnaZadaca.Properties.Resources.Chip1000;
            this.pbChip1000.Location = new System.Drawing.Point(492, 683);
            this.pbChip1000.Name = "pbChip1000";
            this.pbChip1000.Size = new System.Drawing.Size(74, 69);
            this.pbChip1000.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChip1000.TabIndex = 21;
            this.pbChip1000.TabStop = false;
            this.pbChip1000.Click += new System.EventHandler(this.pbChip1000_Click);
            // 
            // pbDealer
            // 
            this.pbDealer.Image = global::VP_193182_ProektnaZadaca.Properties.Resources.BlackJack_Dealer_Man;
            this.pbDealer.Location = new System.Drawing.Point(323, 12);
            this.pbDealer.Name = "pbDealer";
            this.pbDealer.Size = new System.Drawing.Size(523, 233);
            this.pbDealer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDealer.TabIndex = 11;
            this.pbDealer.TabStop = false;
            this.pbDealer.Click += new System.EventHandler(this.pbDealer_Click);
            // 
            // pbChip500
            // 
            this.pbChip500.Image = global::VP_193182_ProektnaZadaca.Properties.Resources.Chip500;
            this.pbChip500.Location = new System.Drawing.Point(412, 683);
            this.pbChip500.Name = "pbChip500";
            this.pbChip500.Size = new System.Drawing.Size(74, 69);
            this.pbChip500.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChip500.TabIndex = 8;
            this.pbChip500.TabStop = false;
            this.pbChip500.Click += new System.EventHandler(this.pbChip500_Click);
            // 
            // pbChip100
            // 
            this.pbChip100.Image = global::VP_193182_ProektnaZadaca.Properties.Resources.Chip100;
            this.pbChip100.Location = new System.Drawing.Point(332, 683);
            this.pbChip100.Name = "pbChip100";
            this.pbChip100.Size = new System.Drawing.Size(74, 69);
            this.pbChip100.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChip100.TabIndex = 6;
            this.pbChip100.TabStop = false;
            this.pbChip100.Click += new System.EventHandler(this.pbChip100_Click);
            // 
            // pbChip10
            // 
            this.pbChip10.Image = global::VP_193182_ProektnaZadaca.Properties.Resources.Chip10;
            this.pbChip10.Location = new System.Drawing.Point(92, 683);
            this.pbChip10.Name = "pbChip10";
            this.pbChip10.Size = new System.Drawing.Size(74, 69);
            this.pbChip10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChip10.TabIndex = 5;
            this.pbChip10.TabStop = false;
            this.pbChip10.Click += new System.EventHandler(this.pbChip10_Click);
            // 
            // pbChip50
            // 
            this.pbChip50.Image = global::VP_193182_ProektnaZadaca.Properties.Resources.Chip50;
            this.pbChip50.Location = new System.Drawing.Point(252, 683);
            this.pbChip50.Name = "pbChip50";
            this.pbChip50.Size = new System.Drawing.Size(74, 69);
            this.pbChip50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChip50.TabIndex = 4;
            this.pbChip50.TabStop = false;
            this.pbChip50.Click += new System.EventHandler(this.pbChip50_Click);
            // 
            // pbChip5
            // 
            this.pbChip5.Image = global::VP_193182_ProektnaZadaca.Properties.Resources.Chip5;
            this.pbChip5.Location = new System.Drawing.Point(12, 683);
            this.pbChip5.Name = "pbChip5";
            this.pbChip5.Size = new System.Drawing.Size(74, 69);
            this.pbChip5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChip5.TabIndex = 3;
            this.pbChip5.TabStop = false;
            this.pbChip5.Click += new System.EventHandler(this.pbChip5_Click);
            // 
            // pbChip25
            // 
            this.pbChip25.Image = global::VP_193182_ProektnaZadaca.Properties.Resources.Chip25;
            this.pbChip25.Location = new System.Drawing.Point(172, 683);
            this.pbChip25.Name = "pbChip25";
            this.pbChip25.Size = new System.Drawing.Size(74, 69);
            this.pbChip25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChip25.TabIndex = 2;
            this.pbChip25.TabStop = false;
            this.pbChip25.Click += new System.EventHandler(this.pbChip25_Click);
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 773);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pbChip1000);
            this.Controls.Add(this.lbDealerHand);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.lbPlayerHand);
            this.Controls.Add(this.lbBalance);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.tbBet);
            this.Controls.Add(this.pbDealer);
            this.Controls.Add(this.pbChip500);
            this.Controls.Add(this.pbChip100);
            this.Controls.Add(this.pbChip10);
            this.Controls.Add(this.pbChip50);
            this.Controls.Add(this.pbChip5);
            this.Controls.Add(this.pbChip25);
            this.Name = "BlackJack";
            this.Text = "BlackJack";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChip1000)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChip500)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChip100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChip10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChip50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChip5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChip25)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbChip25;
        private System.Windows.Forms.PictureBox pbChip5;
        private System.Windows.Forms.PictureBox pbChip50;
        private System.Windows.Forms.PictureBox pbChip10;
        private System.Windows.Forms.PictureBox pbChip100;
        private System.Windows.Forms.PictureBox pbChip500;
        private System.Windows.Forms.PictureBox pbDealer;
        private System.Windows.Forms.TextBox tbBet;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label lbPlayerHand;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Label lbDealerHand;
        private System.Windows.Forms.PictureBox pbChip1000;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}