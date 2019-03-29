using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Card
    {
        public Suite suite;
        public int number;
        public String name;

        // comment

        public Card(Suite s, int n)
        {
            this.suite = s;
            this.number = n;
            this.name = NumberToName(n);
        }

        public String NumberToName(int number)
        {
            String name = "";

            switch (number)
            {
                case 1: name = "Ace"; break;
                case 11: name = "Jack"; break;
                case 12: name = "Queen"; break;
                case 13: name = "King"; break;
                default: name = number.ToString(); break;
            }

            return name;
        }

        override
        public String ToString()
        {
            String toString = name + " of " + this.suite.ToString();
            return toString;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
    

    enum Suite
    {
        Hearts,
        Diamonds,
        Spades, 
        Clubs
    }
}
