using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Poker.Tests
{
    [TestClass]
    public class IsValidHandTests
    {
        [TestMethod]
        public void IsValidHand_ValidHandTest()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Spades)
             });
            PokerHandsChecker checker = new PokerHandsChecker();
            bool isValid = checker.IsValidHand(hand);

            Assert.AreEqual(true, isValid);
        }

        [TestMethod]
        public void IsValidHand_FirstAndLastSameCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Diamonds)
             });
            PokerHandsChecker checker = new PokerHandsChecker();
            bool isValid = checker.IsValidHand(hand);

            Assert.AreEqual(false, isValid);
        }

        [TestMethod]
        public void IsValidHand_FirstTwoSameCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Hearts)

             });
            PokerHandsChecker checker = new PokerHandsChecker();
            bool isValid = checker.IsValidHand(hand);

            Assert.AreEqual(false, isValid);
        }

        [TestMethod]
        public void IsValidHand_LastTwoSameCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Hearts)

             });
            PokerHandsChecker checker = new PokerHandsChecker();
            bool isValid = checker.IsValidHand(hand);

            Assert.AreEqual(false, isValid);
        }

        [TestMethod]
        public void IsValidHand_ThreeCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Clubs)
             });
            PokerHandsChecker checker = new PokerHandsChecker();
            bool isValid = checker.IsValidHand(hand);

            Assert.AreEqual(false, isValid);
        }
    }

    [TestClass]
    public class FlushHandTests
    {
        [TestMethod]
        public void IsFlushHandDiamondsTest()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Diamonds)
             });
            PokerHandsChecker checker = new PokerHandsChecker();
            bool isFlush = checker.IsFlush(hand);
            Assert.AreEqual(true, isFlush);
        }

        [TestMethod]
        public void IsFlushHandSpadesTest()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Spades)
             });
            PokerHandsChecker checker = new PokerHandsChecker();
            bool isFlush = checker.IsFlush(hand);
            Assert.AreEqual(true, isFlush);
        }
    }

    [TestClass]
    public class IsFourOfAKindHandTests
    {
        [TestMethod]
        public void IsFourOfAKindAcesTest()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Diamonds)
             });
            PokerHandsChecker checker = new PokerHandsChecker();
            bool isFourOfAKind = checker.IsFourOfAKind(hand);

            Assert.AreEqual(true, isFourOfAKind);
        }

        [TestMethod]
        public void IsFourOfAKindSevensTest()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Diamonds)
             });
            PokerHandsChecker checker = new PokerHandsChecker();
            bool isFourOfAKind = checker.IsFourOfAKind(hand);

            Assert.AreEqual(true, isFourOfAKind);
        }
    }
}
