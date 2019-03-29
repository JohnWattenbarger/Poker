using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Deck
    {
        public ArrayList CardsInDeck = new ArrayList();
        public ArrayList CardsDealt = new ArrayList();
        Random randomNumberGenerator = new Random();

        public Deck()
        {
            CreateDefaultDeck();
        }
        
        public void CreateDefaultDeck()
        {
            var values = Enum.GetValues(typeof(Suite));

            foreach(Suite currentSuite in values)
            {
                for(int i=1; i<=13; i++)
                {
                    Card cardToAdd = new Card(currentSuite, i);
                    CardsInDeck.Add(cardToAdd);
                }
            }
        }

        public Card DrawCard()
        {
            // choose a random card
            int randomCardLocation = randomNumberGenerator.Next(CardsInDeck.Count);
            Card drawnCard = (Card)CardsInDeck[randomCardLocation];

            // remove from cards in deck and add to cards dealt
            CardsInDeck.RemoveAt(randomCardLocation);
            CardsDealt.Add(drawnCard);

            return drawnCard;
        }

        public void resetDeck()
        {
            CardsInDeck.AddRange(CardsDealt);
            CardsDealt.Clear();
        }
    }
}
