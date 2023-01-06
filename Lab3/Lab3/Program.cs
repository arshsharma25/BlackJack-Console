using System;
using LectureCode;
using PG2Input;
using BlackjackClassLibrary;
using FullSailCasino;
    
namespace Lab3
{
    class Program
    {
        public static void Main(string[] args)
        {
#if DEBUG
            Lectures.Run();
#endif
            var blackDeckObject = new BlackjackDeck();
            
            
            while (true)
            {
                Input.ReadChoice("Choice?", new[] {"1. Play Blackjack", "2. Shuffle and Show Deck", "3. Sample Hands", "4. Exit"}, 
                    out var choice);
                switch (choice)
                {
                    case 1:
                        var blackjackGame = new BlackjackGame();
                        while (true)
                        {
                            blackjackGame.PlayRound();
                            Input.ReadChoice("Do you want to continue", new[] {"1. Yes", "2. No"}, out var userChoice);
                            if (userChoice != 1)
                            {
                                break;
                            }
                        }
                        break;
                    case 2:
                        Console.Clear();
                        blackDeckObject.Shuffle();
                        blackDeckObject.Print();
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        Console.Clear();
                        var userHand = new BlackjackHand();
                        var dealerHand = new BlackjackHand(true);
            
                        userHand.AddCard(blackDeckObject.Deal());
                        userHand.AddCard(blackDeckObject.Deal());
                        dealerHand.AddCard(blackDeckObject.Deal());
                        dealerHand.AddCard(blackDeckObject.Deal());
            
                        userHand.Print(2, 2);
                        dealerHand.Print(2, 4);
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }



        }
    }
}
