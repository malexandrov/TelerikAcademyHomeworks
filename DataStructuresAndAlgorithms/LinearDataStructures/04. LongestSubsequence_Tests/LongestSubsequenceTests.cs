using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LongestSubsequence.Tests
{
    [TestClass]
    public class LongestSubsequenceTests
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MaxSequenceOfEquals_NullTest()
        {
            List<int> actual = LongestSubsequence.MaxSequenceOfEquals(new List<int>());
        }

        [TestMethod]
        public void MaxSequenceOfEquals_OneElementTest()
        {
            List<int> actual = LongestSubsequence.MaxSequenceOfEquals(new List<int>() { 1 });
            List<int> expected = new List<int>() { 1 };

            CollectionAssert.AreEqual(expected, actual);
        }
             
        [TestMethod]
        public void MaxSequenceOfEquals_BeginningTest()
        {
            List<int> actual = LongestSubsequence.MaxSequenceOfEquals(new List<int>() { 1, 1, 1, 3, 4, 2, 2, 42, 2, 2, 33, 1, 1 });
            List<int> expected = new List<int>() { 1, 1, 1 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MaxSequenceOfEquals_EndSequenceTest()
        {
            List<int> actual = LongestSubsequence.MaxSequenceOfEquals(new List<int>() { 1, 1, 1, 3, 4, 2, 2, 42, 1, 1, 1, 1, 1 });
            List<int> expected = new List<int>() { 1, 1, 1, 1, 1 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MaxSequenceOfEquals_GenericTest()
        {
            List<int> actual = LongestSubsequence.MaxSequenceOfEquals(new List<int>() { 1, 12, 1, 3, 4, 2, 2, 2, 1, 2, 1, 2, 1 });
            List<int> expected = new List<int>() { 2, 2, 2 };

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
