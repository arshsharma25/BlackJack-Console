using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackClassLibrary
{
    public class BlackjackDeck: Deck
    {
        public override void CreateAllCards()
        {
            foreach (Card.CardSuit Suit in Enum.GetValues(typeof(Card.CardSuit)))
            {
                foreach (Card.CardFace Face in Enum.GetValues(typeof(Card.CardFace)))
                {
                 //   Console.WriteLine($"CreateAllCards in Black Jack Deck Before - {Face} {Suit}");
                    Card card = (BlackjackCard)Factory.CreateBlackjackCard(Face, Suit);
                  //  Console.WriteLine($"CreateAllCards in Black Jack Deck - {card.Face} {card.Suit}");
                    _cards.Add(card);
                }
            }
        }
    }
}
