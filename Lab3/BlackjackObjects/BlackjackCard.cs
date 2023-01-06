using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackClassLibrary
{
    public class BlackjackCard: Card
    {
        public int Value { get; }


        public BlackjackCard(CardFace face, CardSuit suit)
        {
            //Console.WriteLine($"Inside BlackjackCard is {face} {suit}");
            switch (face.ToString())
            {
                case "K":
                case "Q":
                case "J":
                case "Ten":
                    Value = 10;
                    break;
                case "Nine":
                    Value = 9;
                    break;
                case "Eight":
                    Value = 8;
                    break;
                case "Seven":
                    Value = 7;
                    break;
                case "Six":
                    Value = 6;
                    break;
                case "Five":
                    Value = 5;
                    break;
                case "Four":
                    Value = 4;
                    break;
                case "Three":
                    Value = 3;
                    break;
                case "Two":
                    Value = 2;
                    break;
                case "A":
                    Value = 1;
                    break;
            }

            Face = face;
            Suit = suit;
        }
    }
}
