using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_193182_ProektnaZadaca
{

    public enum SUIT
    {
        SPADE,
        HEART,
        CLUB,
        DIAMOND
    }
    public class Card
    {
        public SUIT suit{ get; set; }
        public int value { get; set; }
        public Image image { get; set; }
        public Image flippedImage { get; set; }

        public Card(SUIT suit, int value, Image image)
        {
            this.suit = suit;
            this.image = image;
            if (value > 10)
            {
                this.value = 10;
            }
            else
            {
                this.value = value;
            }
        }
    }
}
