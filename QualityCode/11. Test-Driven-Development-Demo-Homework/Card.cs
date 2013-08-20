using System;
using System.Text;

namespace Poker
{
    public class Card : ICard
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        private string GetCardFace()
        {
            string cardFace;
            switch (this.Face)
            {
                case CardFace.Two: 
                    cardFace = "2";                
                    break;
                case CardFace.Three: 
                    cardFace = "3";                 
                    break;
                case CardFace.Four: 
                    cardFace = "4";
                    break;
                case CardFace.Five: 
                    cardFace = "5";
                    break;
                case CardFace.Six: 
                    cardFace = "6";
                    break;
                case CardFace.Seven: 
                    cardFace = "7";
                    break;
                case CardFace.Eight: 
                    cardFace = "8";
                    break;
                case CardFace.Nine: 
                    cardFace = "9";
                    break;
                case CardFace.Ten: 
                    cardFace = "10";
                    break;
                case CardFace.Jack: 
                    cardFace = "J";
                    break;
                case CardFace.Queen: 
                    cardFace = "Q";
                    break;
                case CardFace.King: 
                    cardFace = "K";
                    break;
                case CardFace.Ace: 
                    cardFace = "A";
                    break;
                default:
                    cardFace = "";
                    break;
            }

            return cardFace;
        }

        private char GetCardSuit()
        {
            char cardSuit = '0';
            switch (this.Suit)
            {
                case CardSuit.Clubs:
                    cardSuit = '♣';
                    break;
                case CardSuit.Diamonds:
                    cardSuit = '♦';
                    break;
                case CardSuit.Hearts:
                    cardSuit = '♥';
                    break;
                case CardSuit.Spades:
                    cardSuit = '♠';
                    break;
                default:
                    break;
            }
            return cardSuit;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(GetCardFace());
            sb.Append(GetCardSuit());

            return sb.ToString();
            
        }
    }
}
