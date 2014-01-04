using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace CardGame
{
    class Deck
    {
        Card[] cards;

        int nextCardToDealIndex;

        public Deck()
        {
            nextCardToDealIndex = 0;

            cards = new Card[52];
            for (int i = 0; i < 52; i++)
            {
                cards[i] = new Card( (CardValue)(i%13 + 2), (Suit)(i/13));
            }

            Shuffle();
        }

        public override String ToString()
        {
            String returner = "";
            for (int i = 0; i < 52; i++)
            {
                returner += cards[i];
                returner += "\n";
            }

            return returner;
        }

        void Shuffle()
        {
            Random random = new Random();
            
            for(int i=0;i<52;i++)
            {
                //get a random index
                int randomInt = random.Next(0, 52);

                //swap with the random int
                Card tempCard = cards[i];
                cards[i] = cards[randomInt];
                cards[randomInt] = tempCard;
            }
        }

        public Card nextCard()
        {
            
            Debug.Assert(this.nextCardToDealIndex < 52);

            return cards[this.nextCardToDealIndex];

            this.nextCardToDealIndex++;
        }
    }
}
