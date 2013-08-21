namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            int iMin = int.MaxValue;
            for (int i = 0; i < collection.Count-1; i++)
            {
                iMin = i;
                for (int j = i+1; j < collection.Count; j++)
                {
                    if (collection[j].CompareTo(collection[iMin]) <0)
                    {
                        iMin = j;
                    }
                }

                if (iMin != i)
                {
                    var swapVar = collection[iMin];
                    collection[iMin] = collection[i];
                    collection[i] = swapVar;
                }
            }
        }
    }
}
