namespace PriorityQueue
{
    using System;
    using System.Collections.Generic;

    public class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> data;

        public PriorityQueue()
        {
            this.data = new List<T>();
        }

        public void Enqueue(T item)
        {
            this.data.Add(item);
            int childIndex = data.Count - 1;

            while (childIndex > 0)
            {
                int parentIndex = (childIndex - 1) / 2;

                if (data[childIndex].CompareTo(data[parentIndex]) >= 0)
                {
                    break;
                }

                T temp = data[childIndex];
                data[childIndex] = data[parentIndex];
                data[parentIndex] = temp;
                childIndex = parentIndex;
            }
        }

        public T Dequeue()
        {
            if (this.data.Count <= 0)
            {
                throw new ArgumentException("Cannot Dequeue from empty queue!");
            }

            int lastIndex = this.data.Count - 1;
            T frontItem = data[0];
            data[0] = data[lastIndex];
            data.RemoveAt(lastIndex);

            --lastIndex;
            int parentIndex = 0;

            while (true)
            {
                int childIndex = parentIndex * 2 + 1;
                if (childIndex > lastIndex)
                {
                    break;
                }

                int rightChild = childIndex + 1;
                if (rightChild <= lastIndex && data[rightChild].CompareTo(data[childIndex]) < 0)
                {
                    childIndex = rightChild;
                }
                if (data[parentIndex].CompareTo(data[childIndex]) <= 0)
                {
                    break;
                }
                T tmp = data[parentIndex];
                data[parentIndex] = data[childIndex];
                data[childIndex] = tmp;
                parentIndex = childIndex;
            }
            return frontItem;
        }

        public T Peek()
        {
            T frontItem = data[0];
            return frontItem;
        }

        public int Count()
        {
            return data.Count;
        }

        public bool IsConsistent()
        {
            // is the heap property true for all data?
            if (data.Count == 0) return true;

            int lastIndex = data.Count - 1; // last index
            for (int parentIndex = 0; parentIndex < data.Count; ++parentIndex) // each parent index
            {
                int leftChildIndex = 2 * parentIndex + 1; // left child index
                int rightChildIndex = 2 * parentIndex + 2; // right child index

                if (leftChildIndex <= lastIndex && data[parentIndex].CompareTo(data[leftChildIndex]) > 0) return false; // if lc exists and it's greater than parent then bad.
                if (rightChildIndex <= lastIndex && data[parentIndex].CompareTo(data[rightChildIndex]) > 0) return false; // check the right child too.
            }

            return true; // passed all checks
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < data.Count; ++i)
                s += data[i].ToString() + " ";
            s += "count = " + data.Count;
            return s;
        }
    }
}