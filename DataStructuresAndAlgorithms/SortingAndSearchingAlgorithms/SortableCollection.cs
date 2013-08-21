namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            foreach (var entry in this.items)
            {
                if (entry.CompareTo(item) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool BinarySearch(T item)
        {
            this.Sort(new Quicksorter<T>());

            int startIndex = 0;
            int endIndex = this.items.Count ;
            bool itemExists = false;
            while (startIndex < endIndex)
            {
                int mid = (startIndex + endIndex) / 2;
                if (this.items[mid].CompareTo(item) < 0)
                {
                    startIndex = mid + 1;
                }
                else if (this.items[mid].CompareTo(item) > 0)
                {
                    endIndex = mid - 1;
                }
                else
                {
                    itemExists = true;
                    break;
                }
            }

            return itemExists;
        }

        public void Shuffle()
        {
            Random randomGenerator = new Random();

            for (int i = this.items.Count - 1; i > 0; i--)
            {
                int randomIndex = randomGenerator.Next(0, i);

                T swapValue = this.items[i];
                this.items[i] = this.items[randomIndex];
                this.items[randomIndex] = swapValue;
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
