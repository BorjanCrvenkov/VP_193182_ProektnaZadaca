using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_193182_ProektnaZadaca
{
    public abstract class Hand
    {
        public List<Card> hand { get; set; }

        public Hand()
        {
            hand = new List<Card>();
        }

        public Card getCard(int cardPos)
        {
            if (cardPos >= 0 && cardPos < hand.Count)
            {
                return (Card)hand.ElementAt(cardPos);
            }
            else
            {
                return null;
            }
            
        }

        public void addCard(Card card)
        {
            if (card != null)
            {
                hand.Add(card);
            }
        }

        public int getCardCount()
        {
            return hand.Count;
        }

        public abstract int getTotalValue();
    }

    public class PlayerHand : Hand
    {
        public override int getTotalValue()
        {
            int total = 0, count = 0;
            Card []aces = new Card[5];
            for(int i = 0; i < hand.Count; i++)
            {
                if (hand[i].isAce)
                {
                    aces[count] = hand[i];
                    count++;
                }
                else
                {
                    total += hand[i].value;
                }
            }

            for(int i=0; i < count; i++)
            {
                if (total > 11)
                {
                    total += 1;
                }
                else if (total < 11)
                {
                    total += 11;
                }
            }

            return total;

        }
    }

    public class DealerHand : Hand
    {
        public bool stand { get; set; }

        public DealerHand(bool stand)
        {
            this.stand = stand;
        }

        public bool Blackjack()
        {
            if(hand[0].isAce && hand[1].value == 10)
            {
                return true;
            }else if (hand[0].value == 10 && hand[1].isAce)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public override int getTotalValue()
        {
            int total = 0,count = 0;
            if (stand)
            {
                Card[] aces = new Card[5];
                for (int i = 0; i < hand.Count; i++)
                {
                    if (hand[i].isAce)
                    {
                        aces[count] = hand[i];
                        count++;
                    }
                    else
                    {
                        total += hand[i].value;
                    }
                }

                for (int i = 0; i < count; i++)
                {
                    if (total > 11)
                    {
                        total += 1;
                    }
                    else if (total < 11)
                    {
                        total += 11;
                    }
                }

            }
            else
            {
                total = hand[0].value;
            }
            return total;
        }
    }

}
