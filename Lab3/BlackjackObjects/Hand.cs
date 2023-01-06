using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackClassLibrary
{
    public class Hand
    {
        protected List<Card> _cards;

        // default constructor
        public Hand()
        {
            _cards = new List<Card>();
        }

        // adding card to the list
        public virtual void AddCard(Card card)
        {
            _cards.Add(card);
        }

        // clearing the card list
        public virtual void Clear()
        {
            _cards.Clear();
        }

        // print the cards
        public virtual void Print(int x, int y)
        {
            foreach (var card in _cards)
            {
                card.Print(x, y);
            }
        }





    }
}
