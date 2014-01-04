using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    enum HandType { Nothing, SinglePair, TwoPair, ThreeOfAKind, ThreeOfAKindAndPair, 
                    Straight, Flush, FullHouse, FourOfAKind, StraightFlush };
    class Hand
    {
        private ArrayList myCards;
        private HandType typeOfHand;

        Hand()
        {
            myCards = new ArrayList();
            typeOfHand = HandType.Nothing;
        }

        public void addCard(Card cardToAdd)
        {
            myCards.Add(cardToAdd);
            myCards.Sort();
            analizeHand();
        }

        private void analizeHand()
        {

        }
    }
}
