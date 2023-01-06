using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace BlackjackClassLibrary
{
    public class Card
    {
        public CardFace Face { get; set; }
        public CardSuit Suit { get; set; }
        
        public enum CardSuit
        {
            Spades,
            Hearts,
            Clubs,
            Diamonds
        }

        public enum CardFace
        {
            A,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            J,
            Q,
            K
        }

        // default constructor
        protected Card()
        {

        }

        // parameterized constructor
        public Card(CardFace face, CardSuit suit)
        {
            Face = face;
            Suit = suit;
        }   


        // displaying card at a specific location
        public void Print(int x, int y)
        {
            const string heart = "♥";
            const string spade = "♠";
            const string club = "♣";
            const string diamond = "♦";
            var faceString = "";
            var suitString = "";
            var colorChoice = "";

            switch (Face.ToString())
            {
                case "A":
                case "K":
                case "Q":
                case "J":
                    faceString = Face.ToString();
                    break;
                case "Two":
                    faceString = "2";
                    break;
                case "Three":
                    faceString = "3";
                    break;
                case "Four":
                    faceString = "4";
                    break;
                case "Five":
                    faceString = "5";
                    break;
                case "Six":
                    faceString = "6";
                    break;
                case "Seven":
                    faceString = "7";
                    break;
                case "Eight":
                    faceString = "8";
                    break;
                case "Nine":
                    faceString = "9";
                    break;
                case "Ten":
                    faceString = "10";
                    break;
            }

            switch (Suit.ToString())
            {
                case "Hearts":
                    colorChoice = "Red";
                    suitString = heart;
                    break;
                case "Diamonds":
                    colorChoice = "Red";
                    suitString = diamond;
                    break;
                case "Spades":
                    colorChoice = "Black";
                    suitString = spade;
                    break;
                case "Clubs":
                    colorChoice = "Black";
                    suitString = club;
                    break;
            }
            
            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = ConsoleColor.White;
            if (colorChoice.Equals("Red"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
            }
            Console.Write($"{faceString} {suitString}");
            Console.ResetColor();
        }


    }
}
