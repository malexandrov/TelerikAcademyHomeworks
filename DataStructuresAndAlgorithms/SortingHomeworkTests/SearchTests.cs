﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingHomework;

namespace SortingHomeworkTests
{
    [TestClass]
    public class SearchTests
    {
        [TestMethod]
        public void LinearSearchNonExistingTest()
        {
            var collection = new SortableCollection<int>(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });

            bool result = collection.LinearSearch(11);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LinearSearchLastTest()
        {
            var collection = new SortableCollection<int>(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });

            bool result = collection.LinearSearch(0);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void BinarySearchLastTest()
        {
            var collection = new SortableCollection<int>(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });

            bool result = collection.BinarySearch(0);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void BinarySearchTest()
        {
            var collection = new SortableCollection<int>(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });

            bool result = collection.BinarySearch(8);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void BinarySearchNonExistingTest()
        {
            var collection = new SortableCollection<int>(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });

            bool result = collection.BinarySearch(10);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ShuffleTest()
        {
            var collection = new SortableCollection<int>(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            collection.Shuffle();
            bool shuffled = false;

            for (int i = 0; i < collection.Items.Count - 1; i++)
            {
                if (collection.Items[i] > collection.Items[i + 1])
                {
                    shuffled = true;
                    break;
                }
            }

            Assert.IsTrue(shuffled);
        }
    }
}
