using System;
using System.Collections.Generic;
using System.Linq;

namespace LinkedQueue
{
    class Queue<T> 
    {
        private LinkedList<T> Items = new LinkedList<T>();

        public int Count
        {
            get { return this.Items.Count; }
        }

        public void Enqueue(T value)
        {
            this.Items.AddLast(value);
        }

        public T Dequeue()
        {
            if (this.Count == 0)
                throw new InvalidOperationException("Queue is empty.");

            T value = this.Items.First.Value;

            this.Items.RemoveFirst();

            return value;
        }

        public void Clear()
        {
            this.Items.Clear();
        }

        public override string ToString()
        {
            return string.Join(", ", this.Items);
        }
    }
}
