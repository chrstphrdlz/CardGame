using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    enum HandType { Nothing, SinglePair, TwoPair, ThreeOfAKind, 
                    Straight, Flush, FullHouse, FourOfAKind, StraightFlush };

    //all that is necessairy to compare two hands (unless it is Nothing or a Flush)
    struct PokerHand
    {
        public HandType handType;
        public Card primaryCard;
        public Card secodaryCard;
    }

    class Hand
    {
        private ArrayList myCards;
        private PokerHand typeOfHand;

        Hand()
        {
            myCards = new ArrayList();
            typeOfHand.handType = HandType.Nothing;
        }

        public void addCard(Card cardToAdd)
        {
            myCards.Add(cardToAdd);

            if (myCards.Count == 5)
            {
                myCards.Sort();
                analizeHand();
            }
        }

        private bool isStraight()
        {
            for (int i = 0; i < 4; i++)
                if ((int)(myCards[i] as Card).cardType + 1 != (int)(myCards[i + 1] as Card).cardType)
                    return false;

            return true;
        }

        private bool isFlush()
        {
            Suit suitToFind = (myCards[0] as Card).cardSuit;

            foreach(Card card in myCards)
                if(card.cardSuit != suitToFind)
                    return false;

            return true;
        }

        private bool isFourOfAKind()
        {
            CardValue firstCardType = (myCards[0] as Card).cardType;
            CardValue secondCardType = (myCards[1] as Card).cardType;
            CardValue cardToMatch;
            int matchedCards = 0;

            //if the first two match, we are looking for the first to match (or not 4 of a kind)
            if (firstCardType == secondCardType)
                cardToMatch = firstCardType;
            //if not, the second card type must be the one we are looking to match (or not 4 of a kind)
            else
                cardToMatch = secondCardType;

            foreach(Card i in myCards)
                if(cardToMatch == i.cardType)
                    matchedCards++;

            if(matchedCards == 3)
                return true;
            else
                return false;
        }

        private bool hasPair()
        {
            int count = 0;
            
            for (int i = 0; i < 4; i++)
            {
                bool matches =  (int)(myCards[i] as Card).cardType + 1 != (int)(myCards[i + 1] as Card).cardType;
                //found three of a kind
                if(matches)
                {                    
                    count++;
                }
                if(!matches || i == 3)
                {
                    if(count == 1)
                        return true;
                }
            }

            return false;
            
        }

        private bool hasThreeOfAKind()
        {            
            int count = 0;
            
            for (int i = 0; i < 4; i++)
            {
                bool matches =  (int)(myCards[i] as Card).cardType + 1 == (int)(myCards[i + 1] as Card).cardType;
                //found three of a kind
                if(matches)
                {
                    count++;

                    if(i==3)
                        return true;
                }
                else
                {
                    if(count == 2)
                        return true;
                }
            }

            return false;
        }

        private bool hasTwoPair()
        {
            bool foundFirstPair = false;
            int count = 0;

            for (int i = 0; i < 4; i++)
            {
                bool matches = (int)(myCards[i] as Card).cardType + 1 == (int)(myCards[i + 1] as Card).cardType;
                //found three of a kind
                if (matches)
                {
                    count++;
                }
                if (!matches || i == 3)
                {
                    if (!matches)
                        count = 0;

                    if (count == 1)
                        if (!foundFirstPair)
                            foundFirstPair = true;
                        else
                            return true;
                }
            }
            
            return false;
        }


        private void analizeHand()
        {
            bool isStraight = this.isStraight();
            bool isFlush = this.isFlush();

            if (isStraight && isFlush)
            {

            }
            else if (!isStraight && isFlush)
            {

            }
            else if (isStraight && !isFlush)
            {

            }
            else
            {
                if (hasPair())
                {
                    if (hasTwoPair())
                    {

                    }
                    else if (hasThreeOfAKind())
                    {

                    }
                    else
                    {

                    }
                }
                else if (hasThreeOfAKind())
                {

                }
                else if(true)
                {

                }





            }

        }
    }
}
