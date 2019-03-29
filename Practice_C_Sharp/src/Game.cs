using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Game
    {
        public ArrayList players = new ArrayList();
        public Deck deck = new Deck();
        public ArrayList visibleCards = new ArrayList();
        public ArrayList flop;
        public ArrayList river;
        public ArrayList turn;

        public Game() { }

        public Game(int numberOfPlayers)
        {
            for(int i=0; i<numberOfPlayers; i++)
            {
                Player p = new Player();
                p.playerNumber = i + 1;
                players.Add(p);
            }
        }

        public void StartGame()
        {
            // initial showing
            deck.resetDeck();
            GiveEachPlayerCards(2);
            ShowEachPlayersCards();

            // show 1st 3 cards
            Console.WriteLine("Next Round");
            Console.WriteLine();
            DrawFlop();
            DisplayVisibleCards();
            Console.ReadKey();
            Console.Clear();
            ShowEachPlayersCards();

            // show next card
            Console.WriteLine("Next Round");
            Console.WriteLine();
            DrawRiver();
            DisplayVisibleCards();
            Console.ReadKey();
            Console.Clear();
            ShowEachPlayersCards();

            // show final card
            Console.WriteLine("Next Round");
            Console.WriteLine();
            DrawTurn();
            DisplayVisibleCards();
            Console.ReadKey();
            Console.Clear();
            ShowEachPlayersCards();
        }

        public void GiveEachPlayerCards(int numberOfCards)
        {
            foreach(Player currentPlayer in players)
            {
                for (int i = 0; i < numberOfCards; i++)
                {
                    Card temp = deck.DrawCard();
                    currentPlayer.GiveCard(temp);
                }
            }
        }

        public void ShowEachPlayersCards()
        {
            foreach (Player p in players)
            {
                SwitchTurns(p);
                p.DisplayCards();
                DisplayVisibleCards();
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void SwitchTurns(Player currentPlayer)
        {
            // state who's turn it is
            Console.WriteLine("Player " + currentPlayer.playerNumber + "'s turn");
            // wait for input (so computer can be passed)
            Console.ReadKey();
            // empty the console
            Console.Clear();
        }

        private void DisplayVisibleCards()
        {
            if (visibleCards.Count > 0)
            {
                Console.WriteLine("Cards on the board:");
                Console.WriteLine();

                foreach (Card card in visibleCards)
                {
                    card.Print();
                }
            }
        }

        public void DrawFlop()
        {
            flop = new ArrayList();
            int flopCount = 3;
            for(int i=0; i<flopCount; i++)
            {
                Card newCard = deck.DrawCard();
                flop.Add(newCard);
            }
            visibleCards.AddRange(flop);
        }

        public void DrawRiver()
        {
            river = new ArrayList();
            Card newCard = deck.DrawCard();
            river.Add(newCard);

            visibleCards.AddRange(river);
        }

        public void DrawTurn()
        {
            turn = new ArrayList();
            Card newCard = deck.DrawCard();
            turn.Add(newCard);

            visibleCards.AddRange(turn);
        }

        public void AddPlayer(Player p)
        {
            players.Add(p);
        }

        public void RemovePlayer(Player p)
        {
            if (players.Contains(p))
            {
                players.Remove(p);
            }
        }
    }
}
