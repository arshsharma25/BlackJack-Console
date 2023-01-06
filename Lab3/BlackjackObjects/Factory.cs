using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackClassLibrary
{
    internal static class Factory
    {
        public static Card CreateCard(Card.CardFace face, Card.CardSuit suit)
        {
            Card card = new(face, suit);
            return card;
        }

        public static Card CreateBlackjackCard(Card.CardFace face, Card.CardSuit suit)
        {
            var blackJackCard = new BlackjackCard(face, suit);
           // Console.WriteLine($"Factory - {face} {suit}");
          //  Console.WriteLine($"Inside Factory Black Jack {blackJackCard.Face.ToString()} {blackJackCard.Value} {blackJackCard.Suit.ToString()}");
            return blackJackCard;
        }
    }
}
