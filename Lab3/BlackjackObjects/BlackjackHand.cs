using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackClassLibrary
{
    public class BlackjackHand : Hand
    {
        public bool isDealer { get; set; }
        public int Score { get; private set; }


        public BlackjackHand(bool isDealer = false)
        {
            this.isDealer = isDealer;
        }

        public override void AddCard(Card card)
        {
            base.AddCard(card);
            var sum = 0;
            var aceOccurence = 0;
            //this.Score = ((BlackjackCard)card).Value;
            foreach (var cardVar in _cards)
            {
                if (cardVar.Face.ToString() != "A")
                {
                    sum += ((BlackjackCard)cardVar).Value;
                }
                else
                {
                    // checking the number of times ace is in the hand
                    aceOccurence++;
                }
            }

            // trying to make the best score possible of 21
            if (21 - sum < 10)
            {
                sum += aceOccurence;
            }
            else
            {
                sum += aceOccurence * 11;
            }

            Score = sum;
        }

        public override void Print(int x, int y)
        {
            base.Print(x, y);
            if (isDealer)
            {
                var i = 0;
                foreach (var card in _cards)
                {
                    // skips the first card
                    if (i >= 1)
                    {
                        card.Print(x, y);
                        x += 5;
                    }
                    else
                    {
                        Console.SetCursorPosition(x,y);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("    ");
                        Console.ResetColor();
                        x += 5;
                    }

                    i++;
                }

                Console.WriteLine(" ??");
            }
            else
            {
                foreach (var card in _cards)
                {
                    //  Console.WriteLine(card.Face.ToString());
                    card.Print(x, y);
                    x += 7;
                }

                Console.WriteLine($" {Score}");
            }
        }

        public override void Clear()
        {
            base.Clear();
            Score = 0;
        }

        public void Reveal(int x, int y)
        {
            if (isDealer)
            {
                isDealer = false;
                Print(x, y);
            }
            else
            {
                Print(x, y);
            }
        }
    }
}