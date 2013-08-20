using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Tests
{
    [TestClass]
    public class CardToStringTests
    {
        [TestMethod]
        public void CardToStringTwoDiamonds()
        {
            Card card = new Card(CardFace.Two, CardSuit.Diamonds);
            string actual = card.ToString();
            string expected = "2♦";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CardToStringAceSpades()
        {
            Card card = new Card(CardFace.Ace, CardSuit.Spades);
            string actual = card.ToString();
            string expected = "A♠";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CardToStringTenClubs()
        {
            Card card = new Card(CardFace.Ten, CardSuit.Clubs);
            string actual = card.ToString();
            string expected = "10♣";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CardToStringJackHearts()
        {
            Card card = new Card(CardFace.Jack, CardSuit.Hearts);
            string actual = card.ToString();
            string expected = "J♥";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CardToStringSevenSpades()
        {
            Card card = new Card(CardFace.Seven, CardSuit.Spades);
            string actual = card.ToString();
            string expected = "7♠";
            Assert.AreEqual(expected, actual);
        }
    }
}
