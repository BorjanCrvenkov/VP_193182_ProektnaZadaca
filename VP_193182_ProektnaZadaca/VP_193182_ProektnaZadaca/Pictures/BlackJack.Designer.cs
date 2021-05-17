
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.lbBalance = new System.Windows.Forms.Label();
            this.lbPlayerHand = new System.Windows.Forms.Label();
            this.btnDeal = new System.Windows.Forms.Button();
            this.lbDealerHand = new System.Windows.Forms.Label();
            this.pbDealer = new System.Windows.Forms.PictureBox();
            this.pbChip500 = new System.Windows.Forms.PictureBox();
            this.pbChip100 = new System.Windows.Forms.PictureBox();
            this.pbChip10 = new System.Windows.Forms.PictureBox();
            this.pbChip50 = new System.Windows.Forms.PictureBox();
            this.pbChip5 = new System.Windows.Forms.PictureBox();
            this.pbChip25 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChip500)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChip100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChip10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChip50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChip5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChip25)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 641);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Left click on the chips increases your bet, right click decreases your bet";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(647, 641);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(113, 23);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "0";
            // 
            // btnHit
            // 
            this.btnHit.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(647, 683);
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
            this.btnStand.Location = new System.Drawing.Point(864, 683);
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
            this.lbPlayerHand.Location = new System.Drawing.Point(838, 378);
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
            this.pbChip500.Location = new System.Drawing.Point(495, 683);
            this.pbChip500.Name = "pbChip500";
            this.pbChip500.Size = new System.Drawing.Size(74, 69);
            this.pbChip500.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChip500.TabIndex = 8;
            this.pbChip500.TabStop = false;
            // 
            // pbChip100
            // 
            this.pbChip100.Image = global::VP_193182_ProektnaZadaca.Properties.Resources.Chip100;
            this.pbChip100.Location = new System.Drawing.Point(398, 683);
            this.pbChip100.Name = "pbChip100";
            this.pbChip100.Size = new System.Drawing.Size(74, 69);
            this.pbChip100.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChip100.TabIndex = 6;
            this.pbChip100.TabStop = false;
            // 
            // pbChip10
            // 
            this.pbChip10.Image = global::VP_193182_ProektnaZadaca.Properties.Resources.Chip10;
            this.pbChip10.Location = new System.Drawing.Point(111, 683);
            this.pbChip10.Name = "pbChip10";
            this.pbChip10.Size = new System.Drawing.Size(74, 69);
            this.pbChip10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChip10.TabIndex = 5;
            this.pbChip10.TabStop = false;
            // 
            // pbChip50
            // 
            this.pbChip50.Image = global::VP_193182_ProektnaZadaca.Properties.Resources.Chip50;
            this.pbChip50.Location = new System.Drawing.Point(299, 683);
            this.pbChip50.Name = "pbChip50";
            this.pbChip50.Size = new System.Drawing.Size(74, 69);
            this.pbChip50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChip50.TabIndex = 4;
            this.pbChip50.TabStop = false;
            // 
            // pbChip5
            // 
            this.pbChip5.Image = global::VP_193182_ProektnaZadaca.Properties.Resources.Chip5;
            this.pbChip5.Location = new System.Drawing.Point(16, 683);
            this.pbChip5.Name = "pbChip5";
            this.pbChip5.Size = new System.Drawing.Size(74, 69);
            this.pbChip5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChip5.TabIndex = 3;
            this.pbChip5.TabStop = false;
            // 
            // pbChip25
            // 
            this.pbChip25.Image = global::VP_193182_ProektnaZadaca.Properties.Resources.Chip25;
            this.pbChip25.Location = new System.Drawing.Point(206, 683);
            this.pbChip25.Name = "pbChip25";
            this.pbChip25.Size = new System.Drawing.Size(74, 69);
            this.pbChip25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChip25.TabIndex = 2;
            this.pbChip25.TabStop = false;
            // 
            // BlackJack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 773);
            this.Controls.Add(this.lbDealerHand);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.lbPlayerHand);
            this.Controls.Add(this.lbBalance);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbDealer);
            this.Controls.Add(this.pbChip500);
            this.Controls.Add(this.pbChip100);
            this.Controls.Add(this.pbChip10);
            this.Controls.Add(this.pbChip50);
            this.Controls.Add(this.pbChip5);
            this.Controls.Add(this.pbChip25);
            this.Name = "BlackJack";
            this.Text = "BlackJack";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label lbPlayerHand;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Label lbDealerHand;
    }
}