using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingHomework;

namespace SortingAndSearchingTests
{
    [TestClass]
    public class SortingTests
    {
        [TestMethod]
        public void SelectionSortTest()
        {
            var collection = new SortableCollection<int>(new[] { 5, 1, 2, 4, 0, 6, 9, 8, 7 });

            collection.Sort(new SelectionSorter<int>());

            for (int i = 0; i < collection.Items.Count - 1; i++)
            {
                Assert.IsTrue(collection.Items[i] < collection.Items[i + 1]);
            }
        }

        [TestMethod]
        public void SelectionSortReverseSortedTest()
        {
            var collection = new SortableCollection<int>(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });

            collection.Sort(new SelectionSorter<int>());

            for (int i = 0; i < collection.Items.Count - 1; i++)
            {
                Assert.IsTrue(collection.Items[i] < collection.Items[i + 1]);
            }
        }


        [TestMethod]
        public void QuickSortTest()
        {
            var collection = new SortableCollection<int>(new[] { 5, 1, 2, 4, 0, 6, 9, 8, 7 });

            collection.Sort(new Quicksorter<int>());

            for (int i = 0; i < collection.Items.Count - 1; i++)
            {
                Assert.IsTrue(collection.Items[i] < collection.Items[i + 1]);
            }
        }

        [TestMethod]
        public void QuickSortReverseSortedTest()
        {
            var collection = new SortableCollection<int>(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });

            collection.Sort(new Quicksorter<int>());

            for (int i = 0; i < collection.Items.Count - 1; i++)
            {
                Assert.IsTrue(collection.Items[i] < collection.Items[i + 1]);
            }
        }

        [TestMethod]
        public void MergeSortTest()
        {
            var collection = new SortableCollection<int>(new[] { 5, 1, 2, 4, 0, 6, 9, 8, 7 });

            collection.Sort(new MergeSorter<int>());

            for (int i = 0; i < collection.Items.Count - 1; i++)
            {
                Assert.IsTrue(collection.Items[i] < collection.Items[i + 1]);
            }
        }

        [TestMethod]
        public void MergeSortReverseSortedTest()
        {
            var collection = new SortableCollection<int>(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });

            collection.Sort(new MergeSorter<int>());

            for (int i = 0; i < collection.Items.Count - 1; i++)
            {
                Assert.IsTrue(collection.Items[i] < collection.Items[i + 1]);
            }
        }

    }
}