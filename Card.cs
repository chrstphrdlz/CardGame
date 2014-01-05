using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    enum CardValue
    {
        Nothing=0,Two,Three,Four,Five,Six,Seven,Eight,Nine,Ten,Jack,Queen,King,Ace
    }

    enum Suit
    {
        Diamond=0,Clubs,Hearts,Spades
    }

    class Card : IComparable 
    {
        public CardValue cardType { get; private set; }

        public Suit cardSuit { get; private set; }

        public Card(CardValue cardVal, Suit cardSuit)
        {
            this.cardSuit = cardSuit;
            this.cardType = cardVal;
        }

        public override String ToString()
        {
            String returner = "";

            switch (this.cardType)
            {
                case CardValue.Two:
                    returner += "Two ";
                    break;

                case CardValue.Three:
                    returner += "Three ";
                    break;

                case CardValue.Four:
                    returner += "Four ";
                    break;

                case CardValue.Five:
                    returner += "Five ";
                    break;

                case CardValue.Six:
                    returner += "Six ";
                    break;

                case CardValue.Seven:
                    returner += "Seven ";
                    break;

                case CardValue.Eight:
                    returner += "Eight ";
                    break;

                case CardValue.Nine:
                    returner += "Nine ";
                    break;

                case CardValue.Ten:
                    returner += "Ten ";
                    break;

                case CardValue.Jack:
                    returner += "Jack ";
                    break;

                case CardValue.Queen:
                    returner += "Queen ";
                    break;

                case CardValue.King:
                    returner += "King ";
                    break;
                
                case CardValue.Ace:
                    returner += "Ace ";
                    break;

                default:
                    returner += "Error";
                    break;
            }

            returner += " of ";

            switch (this.cardSuit)
            {
                case Suit.Clubs:
                    returner += "Clubs";
                    break;

                case Suit.Diamond:
                    returner += "Diamonds";
                    break;

                case Suit.Hearts:
                    returner += "Hearts";
                    break;

                case Suit.Spades:
                    returner += "Spades";
                    break;

                default:
                    returner += "error";
                    break;
            }

            return returner;
        }
        
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Card otherCard = obj as Card;
            if (otherCard != null)
                return this.cardType.CompareTo(otherCard.cardType);
            else
                throw new ArgumentException("Object is not a Temperature");
        }

        public static bool operator >(Card a, Card b)
        {
            return a.cardType > b.cardType;
        }

        public static bool operator <(Card a, Card b)
        {
            return a.cardType < b.cardType;
        }

    }

    
}
