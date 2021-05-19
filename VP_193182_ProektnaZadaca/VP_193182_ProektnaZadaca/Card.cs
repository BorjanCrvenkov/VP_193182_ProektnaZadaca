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
        public Image flippedImg { get; set; }

        public bool isAce { get; set; }

        public Card(SUIT suit, int value, Image image)
        {
            this.suit = suit;
            this.image = image;
            if(value == 11)
            {
                value = 11;
                isAce = true;
            }else if (value > 10)
            {
                this.value = 10;
                isAce = false;
            }
            else
            {
                this.value = value;
                isAce = false;
            }
        }
    }
}
