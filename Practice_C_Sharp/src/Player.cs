using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Player
    {
        public ArrayList hand = new ArrayList();
        public int playerNumber;

        public void GiveCard(Card card)
        {
            hand.Add(card);
        }

        public ArrayList GetCards()
        {
            ArrayList cardsToGive = hand;
            hand = new ArrayList();
            return cardsToGive;
        }

        public void resetHand()
        {
            hand.Clear();
        }

        public void DisplayCards()
        {
            Console.WriteLine(getName() + "'s Cards:");
            Console.WriteLine();

            foreach(Card card in hand)
            {
                card.Print();
            }
            Console.WriteLine();
        }

        public String getName()
        {
            return "Player " + playerNumber;
        }
    }
}
