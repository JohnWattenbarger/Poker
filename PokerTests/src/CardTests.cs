using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Tests
{
    [TestClass()]
    public class CardTests
    {
        [TestMethod()]
        public void CardTest()
        {
            Card card = new Card(Suite.Spades, 1);
            Assert.IsNotNull(card);
        }

        [TestMethod()]
        public void NumberToNameTestSimple()
        {
            Card card = new Card(Suite.Diamonds, 3);
            
            String expected = "4";
            String actual = card.NumberToName(4);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NumberToNameTestAce()
        {
            Card card = new Card(Suite.Diamonds, 3);

            String expected = "Ace";
            String actual = card.NumberToName(1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NumberToNameTestRoyal()
        {
            Card card = new Card(Suite.Diamonds, 3);

            String expected = "Queen";
            String actual = card.NumberToName(12);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void ToStringTest()
        {
            Card card = new Card(Suite.Clubs, 13);

            String expected = "King of Clubs";
            String actual = card.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PrintTest()
        {
            Card card = new Card(Suite.Hearts, 5);

            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);
                
                card.Print();

                string expected = "5 of Hearts\r\n";
                string actual = stringWriter.ToString();
                
                Assert.AreEqual<string>(expected, actual);
            }
        }
    }
}