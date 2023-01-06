using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlackjackClassLibrary
{
    public class Deck
    {
        // class variable declaration
        protected List<Card> _cards;

        // default constructor
        public Deck()
        {
            _cards = new List<Card>();
            CreateAllCards();
        }

        // creating 52 card objects and pushing onto the list
        public virtual void CreateAllCards()
        {
            foreach(Card.CardSuit suit in Enum.GetValues(typeof(Card.CardSuit)))
            {
                foreach(Card.CardFace face in Enum.GetValues(typeof(Card.CardFace)))
                {
                    var card = Factory.CreateCard(face, suit);
                  //  Console.WriteLine($"CreateAllCards in Deck - {card.Face}");
                    _cards.Add(card);

                }
            }
        }

        // returning card from a list of cards
        public Card Deal()
        {
           // Shuffle();
            if (_cards.Count == 0)
            {
                CreateAllCards(); // recreates the deck if it is empty
                Shuffle();
            }
            
            var card = _cards[0]; // getting the top card
            _cards.RemoveAt(0); // removing card from the list
            //Console.WriteLine("Deal in Deck - " + card.Face);
          //  Console.WriteLine($"Card on top - {_cards[0].Face}");
            
            return card; // returning card
        }

        // shuffles the cards in the deck
        public void Shuffle()
        {
            // generating random values
            var random = new Random();


            for(var i = 0; i < _cards.Count; i++)
            {
                // getting two random positions
                var randomPosition1 = random.Next(0, _cards.Count);
                var randomPosition2 = random.Next(0, _cards.Count);

                // swapping the cards
                (_cards[randomPosition1], _cards[randomPosition2]) = (_cards[randomPosition2], _cards[randomPosition1]);
            }
        }
        
        // prints the card
        public void Print()
        {
            var x = 0;
            var y = 0;
            foreach(var card in _cards)
            {
                if (x == 65)
                {
                    x = 0;
                    y += 2;
                }
                card.Print(x, y);
                x += 5;
            }
        }


    }
}
