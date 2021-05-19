using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_193182_ProektnaZadaca
{
    public class Deck
    {
        public Card[] deck { get; set; }
        Random random = new Random();

        public Deck()
        {
            deck = new Card[52];
            Image image;
            int count = 0;
            foreach (SUIT s in Enum.GetValues(typeof(SUIT)))
            {
                for (int value = 2; value < 15; value++)
                {
                    if(s == SUIT.CLUB)
                    {
                        image = Image.FromFile(@"Pictures\Cards\" + value + "C.png");
                    }
                    else if(s == SUIT.DIAMOND)
                    {
                        image = Image.FromFile(@"Pictures\Cards\" + value + "D.png");
                    }
                    else if(s == SUIT.HEART)
                    {
                        image = Image.FromFile(@"Pictures\Cards\" + value + "H.png");

                    }
                    else
                    {
                        image = Image.FromFile(@"Pictures\Cards\" + value + "S.png");
                    }
                    deck[count] = new Card(s, value, image);
                    count++;
                }
            }
                
        }

        public void shuffle()
        {
            Random rnd = new Random();
            for (int i = 51; i > 0; i--)
            {
                int random = rnd.Next(0, 52);
                Card tmp = deck[i];
                deck[i] = deck[random];
                deck[random] = tmp;
            }
        }
        public Card generateCard()
        {
            return deck[random.Next(0, 52)];
        }
    }
}
