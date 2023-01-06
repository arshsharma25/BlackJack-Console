using System;
using BlackjackClassLibrary;
using PG2Input;

namespace FullSailCasino
{
    public class BlackjackGame
    {
        private BlackjackHand _dealer;
        private BlackjackHand _player;
        private BlackjackDeck _deck;
        private bool _isDealerActive;
        private bool _winner;
        private int _playerWins;
        private int _dealerWins;

        public BlackjackGame()
        {
            _playerWins = 0;
            _dealerWins = 0;
            _isDealerActive = false;
            _winner = false;
        }

        public void PlayRound()
        {
            _dealer = new BlackjackHand(true);
            _player = new BlackjackHand();
            _deck = new BlackjackDeck();
            _deck.Shuffle();

            DealInitialCards();

            if (_player.Score != 21 || _dealer.Score != 21)
            {
                PlayersTurn();
                DealersTurn();
            }

            DeclareWinner();
        }

        private void DrawTable()
        {
            var x = 0;
            var y = 1;
            
            Console.Clear();
            Console.SetCursorPosition(0,0);
            Console.WriteLine("Player Cards");
            _player.Reveal(x,y);

            
            if (_isDealerActive)
            {
                x = 0;
                y = 3;
            
                Console.SetCursorPosition(0,2);
                Console.WriteLine("Dealer Cards");
                _dealer.Print(x,y);
            }

            if (!_winner) return;
            Console.SetCursorPosition(0, 4);
            DrawWins();


        }

        private void DealInitialCards()
        {
            _isDealerActive = false;
            _winner = false;
            for (var i = 0; i < 2; i++)
            {
                _player.AddCard(_deck.Deal());
                DrawTable();
                _dealer.AddCard(_deck.Deal());
                DrawTable();
            }
            DrawTable();
        }

        private void PlayersTurn()
        {
            while (_player.Score < 21)
            {
                Input.ReadChoice("Hit or Stand?", new[] { "1. Hit", "2. Stand" }, out var selection);
                if (selection == 1)
                {
                    _player.AddCard(_deck.Deal());
                    DrawTable();
                }
                else
                {
                    break;
                }
            }
        }

        private void DealersTurn()
        {
            //TODO show dealers card
            _dealer.Reveal(0,3);
            _isDealerActive = true;
            while (_dealer.Score < 17)
            {
                _dealer.AddCard(_deck.Deal());
                DrawTable();
            }

            _winner = true;
            DrawTable();

        }

        private void DeclareWinner()
        {
            if (_player.Score > 21)
            {
                Console.WriteLine("Dealer Wins");
                _dealerWins++;
            }else if (_dealer.Score > 21)
            {
                Console.WriteLine("Player wins");
                _playerWins++;
            }else if (_player.Score > _dealer.Score)
            {
                Console.WriteLine("Player wins");
                _playerWins++;
            }else if (_player.Score < _dealer.Score)
            {
                Console.WriteLine("Dealer Wins");
                _dealerWins++;
            }
            else
            {
                Console.WriteLine("It is a tie");
            }
        }

        private void DrawWins()
        {
            Console.WriteLine($"The number of times Player Won are {_playerWins} and for the dealer it is {_dealerWins}");
        }
    }
}