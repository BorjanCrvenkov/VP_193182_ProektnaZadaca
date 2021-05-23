
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
            this.btnAllIn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbDealer = new System.Windows.Forms.PictureBox();
            this.ovalPictureBox1 = new VP_193182_ProektnaZadaca.OvalPictureBox();
            this.opbChip2000 = new VP_193182_ProektnaZadaca.OvalPictureBox();
            this.opbChip1000 = new VP_193182_ProektnaZadaca.OvalPictureBox();
            this.opbChip500 = new VP_193182_ProektnaZadaca.OvalPictureBox();
            this.opbChip100 = new VP_193182_ProektnaZadaca.OvalPictureBox();
            this.opbChip50 = new VP_193182_ProektnaZadaca.OvalPictureBox();
            this.opbChip25 = new VP_193182_ProektnaZadaca.OvalPictureBox();
            this.opbChip10 = new VP_193182_ProektnaZadaca.OvalPictureBox();
            this.opbChip5 = new VP_193182_ProektnaZadaca.OvalPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbChip2000)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbChip1000)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbChip500)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbChip100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbChip50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbChip25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbChip10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbChip5)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBet
            // 
            this.tbBet.Enabled = false;
            this.tbBet.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBet.Location = new System.Drawing.Point(893, 657);
            this.tbBet.Multiline = true;
            this.tbBet.Name = "tbBet";
            this.tbBet.ReadOnly = true;
            this.tbBet.Size = new System.Drawing.Size(217, 40);
            this.tbBet.TabIndex = 13;
            this.tbBet.Text = "Your bet: $0";
            // 
            // btnHit
            // 
            this.btnHit.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(893, 736);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(158, 64);
            this.btnHit.TabIndex = 14;
            this.btnHit.Text = "HIT";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStand.Location = new System.Drawing.Point(1057, 736);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(158, 64);
            this.btnStand.TabIndex = 15;
            this.btnStand.Text = "STAND";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDouble.Location = new System.Drawing.Point(1224, 736);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(158, 64);
            this.btnDouble.TabIndex = 16;
            this.btnDouble.Text = "DOUBLE";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Font = new System.Drawing.Font("Arial Unicode MS", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalance.Location = new System.Drawing.Point(632, 23);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(296, 44);
            this.lbBalance.TabIndex = 17;
            this.lbBalance.Text = "BALANCE: $1000";
            // 
            // lbPlayerHand
            // 
            this.lbPlayerHand.AutoSize = true;
            this.lbPlayerHand.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerHand.Location = new System.Drawing.Point(699, 397);
            this.lbPlayerHand.Name = "lbPlayerHand";
            this.lbPlayerHand.Size = new System.Drawing.Size(117, 23);
            this.lbPlayerHand.TabIndex = 18;
            this.lbPlayerHand.Text = "Your hand: 0";
            this.lbPlayerHand.Visible = false;
            // 
            // btnDeal
            // 
            this.btnDeal.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeal.Location = new System.Drawing.Point(1144, 657);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(238, 40);
            this.btnDeal.TabIndex = 19;
            this.btnDeal.Text = "DEAL";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // lbDealerHand
            // 
            this.lbDealerHand.AutoSize = true;
            this.lbDealerHand.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDealerHand.Location = new System.Drawing.Point(240, 209);
            this.lbDealerHand.Name = "lbDealerHand";
            this.lbDealerHand.Size = new System.Drawing.Size(146, 23);
            this.lbDealerHand.TabIndex = 20;
            this.lbDealerHand.Text = "Dealer\'s hand: 0";
            this.lbDealerHand.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 669);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(550, 28);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "Left click increases your bet, right click decreases your bet";
            // 
            // btnAllIn
            // 
            this.btnAllIn.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllIn.Location = new System.Drawing.Point(690, 657);
            this.btnAllIn.Name = "btnAllIn";
            this.btnAllIn.Size = new System.Drawing.Size(184, 39);
            this.btnAllIn.TabIndex = 24;
            this.btnAllIn.Text = "All-In";
            this.btnAllIn.UseVisualStyleBackColor = true;
            this.btnAllIn.Click += new System.EventHandler(this.btnAllIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VP_193182_ProektnaZadaca.Properties.Resources.Blackjack_EndGame;
            this.pictureBox1.Location = new System.Drawing.Point(1095, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbDealer
            // 
            this.pbDealer.Image = global::VP_193182_ProektnaZadaca.Properties.Resources.BlackJack_Dealer_Man;
            this.pbDealer.Location = new System.Drawing.Point(12, 12);
            this.pbDealer.Name = "pbDealer";
            this.pbDealer.Size = new System.Drawing.Size(601, 220);
            this.pbDealer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDealer.TabIndex = 11;
            this.pbDealer.TabStop = false;
            this.pbDealer.Click += new System.EventHandler(this.pbDealer_Click);
            // 
            // ovalPictureBox1
            // 
            this.ovalPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.ovalPictureBox1.Image = global::VP_193182_ProektnaZadaca.Properties.Resources.Info_icon;
            this.ovalPictureBox1.Location = new System.Drawing.Point(970, 13);
            this.ovalPictureBox1.Name = "ovalPictureBox1";
            this.ovalPictureBox1.Size = new System.Drawing.Size(119, 74);
            this.ovalPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ovalPictureBox1.TabIndex = 33;
            this.ovalPictureBox1.TabStop = false;
            this.ovalPictureBox1.Click += new System.EventHandler(this.ovalPictureBox1_Click);
            // 
            // opbChip2000
            // 
            this.opbChip2000.BackColor = System.Drawing.Color.DarkGray;
            this.opbChip2000.Image = global::VP_193182_ProektnaZadaca.Properties.Resources.Chip2000;
            this.opbChip2000.Location = new System.Drawing.Point(779, 703);
            this.opbChip2000.Name = "opbChip2000";
            this.opbChip2000.Size = new System.Drawing.Size(95, 97);
            this.opbChip2000.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opbChip2000.TabIndex = 32;
            this.opbChip2000.TabStop = false;
            this.opbChip2000.Click += new System.EventHandler(this.opbChip2000_Click);
            // 
            // opbChip1000
            // 
            this.opbChip1000.BackColor = System.Drawing.Color.DarkGray;
            this.opbChip1000.Image = global::VP_193182_ProektnaZadaca.Properties.Resources.Chip1000;
            this.opbChip1000.Location = new System.Drawing.Point(670, 703);
            this.opbChip1000.Name = "opbChip1000";
            this.opbChip1000.Size = new System.Drawing.Size(95, 97);
            this.opbChip1000.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opbChip1000.TabIndex = 31;
            this.opbChip1000.TabStop = false;
            this.opbChip1000.Click += new System.EventHandler(this.opbChip1000_Click);
            // 
            // opbChip500
            // 
            this.opbChip500.BackColor = System.Drawing.Color.DarkGray;
            this.opbChip500.Image = global::VP_193182_ProektnaZadaca.Properties.Resources.Chip500;
            this.opbChip500.Location = new System.Drawing.Point(561, 703);
            this.opbChip500.Name = "opbChip500";
            this.opbChip500.Size = new System.Drawing.Size(95, 97);
            this.opbChip500.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opbChip500.TabIndex = 30;
            this.opbChip500.TabStop = false;
            this.opbChip500.Click += new System.EventHandler(this.opbChip500_Click);
            // 
            // opbChip100
            // 
            this.opbChip100.BackColor = System.Drawing.Color.DarkGray;
            this.opbChip100.Image = global::VP_193182_ProektnaZadaca.Properties.Resources.Chip100;
            this.opbChip100.Location = new System.Drawing.Point(452, 703);
            this.opbChip100.Name = "opbChip100";
            this.opbChip100.Size = new System.Drawing.Size(95, 97);
            this.opbChip100.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opbChip100.TabIndex = 29;
            this.opbChip100.TabStop = false;
            this.opbChip100.Click += new System.EventHandler(this.opbChip100_Click);
            // 
            // opbChip50
            // 
            this.opbChip50.BackColor = System.Drawing.Color.DarkGray;
            this.opbChip50.Image = global::VP_193182_ProektnaZadaca.Properties.Resources.Chip50;
            this.opbChip50.Location = new System.Drawing.Point(343, 703);
            this.opbChip50.Name = "opbChip50";
            this.opbChip50.Size = new System.Drawing.Size(95, 97);
            this.opbChip50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opbChip50.TabIndex = 28;
            this.opbChip50.TabStop = false;
            this.opbChip50.Click += new System.EventHandler(this.opbChip50_Click);
            // 
            // opbChip25
            // 
            this.opbChip25.BackColor = System.Drawing.Color.DarkGray;
            this.opbChip25.Image = global::VP_193182_ProektnaZadaca.Properties.Resources.Chip25;
            this.opbChip25.Location = new System.Drawing.Point(234, 703);
            this.opbChip25.Name = "opbChip25";
            this.opbChip25.Size = new System.Drawing.Size(95, 97);
            this.opbChip25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opbChip25.TabIndex = 27;
            this.opbChip25.TabStop = false;
            this.opbChip25.Click += new System.EventHandler(this.opbChip25_Click);
            // 
            // opbChip10
            // 
            this.opbChip10.BackColor = System.Drawing.Color.DarkGray;
            this.opbChip10.Image = global::VP_193182_ProektnaZadaca.Properties.Resources.Chip10;
            this.opbChip10.Location = new System.Drawing.Point(125, 703);
            this.opbChip10.Name = "opbChip10";
            this.opbChip10.Size = new System.Drawing.Size(95, 97);
            this.opbChip10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opbChip10.TabIndex = 26;
            this.opbChip10.TabStop = false;
            this.opbChip10.Click += new System.EventHandler(this.opbChip10_Click);
            // 
            // opbChip5
            // 
            this.opbChip5.BackColor = System.Drawing.Color.DarkGray;
            this.opbChip5.Image = global::VP_193182_ProektnaZadaca.Properties.Resources.Chip5;
            this.opbChip5.Location = new System.Drawing.Point(16, 703);
            this.opbChip5.Name = "opbChip5";
            this.opbChip5.Size = new System.Drawing.Size(95, 97);
            this.opbChip5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opbChip5.TabIndex = 25;
            this.opbChip5.TabStop = false;
            this.opbChip5.Click += new System.EventHandler(this.opbChip5_Click);
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 813);
            this.Controls.Add(this.ovalPictureBox1);
            this.Controls.Add(this.opbChip2000);
            this.Controls.Add(this.opbChip1000);
            this.Controls.Add(this.opbChip500);
            this.Controls.Add(this.opbChip100);
            this.Controls.Add(this.opbChip50);
            this.Controls.Add(this.opbChip25);
            this.Controls.Add(this.opbChip10);
            this.Controls.Add(this.opbChip5);
            this.Controls.Add(this.btnAllIn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbDealerHand);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.lbPlayerHand);
            this.Controls.Add(this.lbBalance);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.tbBet);
            this.Controls.Add(this.pbDealer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BlackJack";
            this.Text = "BlackJack";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbChip2000)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbChip1000)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbChip500)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbChip100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbChip50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbChip25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbChip10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opbChip5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbDealer;
        private System.Windows.Forms.TextBox tbBet;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label lbPlayerHand;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Label lbDealerHand;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAllIn;
        private OvalPictureBox opbChip5;
        private OvalPictureBox opbChip10;
        private OvalPictureBox opbChip25;
        private OvalPictureBox opbChip50;
        private OvalPictureBox opbChip100;
        private OvalPictureBox opbChip500;
        private OvalPictureBox opbChip1000;
        private OvalPictureBox opbChip2000;
        private OvalPictureBox ovalPictureBox1;
    }
}