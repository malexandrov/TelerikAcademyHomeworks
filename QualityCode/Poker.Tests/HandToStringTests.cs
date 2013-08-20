using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Poker.Tests
{
    [TestClass]
    public class HandToStringTests
    {
        [TestMethod]
        public void HandToStringWithOneCard()
        {
            Hand hand = new Hand(new List<ICard>() { new Card(CardFace.Two, CardSuit.Diamonds) });
            string actual = hand.ToString();
            string expected = "2♦";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HandToStringWith5Cards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Spades)
             });
            string actual = hand.ToString();
            string expected = "2♦ A♠ 10♣ J♥ 7♠";

            Assert.AreEqual(expected, actual);
        }
    }
}
