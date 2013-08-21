namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            if (collection.Count <=1)
            {
                return;
            }

            int leftIndex = 0;
            int rigthIndex = collection.Count - 1;
            QuickSort(collection, leftIndex, rigthIndex);
        }

        private void QuickSort(IList<T> collection, int leftIndex, int rigthIndex)
        {
            if (leftIndex < rigthIndex)
            {
                int pivotIndex = leftIndex + (rigthIndex - leftIndex) / 2;
                int pivotNewIndex = Partition(collection, leftIndex, rigthIndex, pivotIndex);

                QuickSort(collection, leftIndex, pivotNewIndex - 1);
                QuickSort(collection, pivotNewIndex + 1, rigthIndex);
            }
        }

        private int Partition(IList<T> collection, int leftIndex, int rightIndex, int pivotIndex)
        {
            var pivotValue = collection[pivotIndex];
            Swap(collection, pivotIndex, rightIndex);
            int storeIndex = leftIndex;

            for (int i = leftIndex; i < rightIndex; i++)
            {
                if (collection[i].CompareTo(pivotValue) <= 0)
                {
                    Swap(collection, i, storeIndex);
                    storeIndex += 1; 
                }
            }
            Swap(collection, storeIndex, rightIndex);

            return storeIndex;
        }

        private static void Swap(IList<T> collection, int indexA, int indexB)
        {
            var tmp = collection[indexA];
            collection[indexA] = collection[indexB];
            collection[indexB] = tmp;
        }
    }
}
