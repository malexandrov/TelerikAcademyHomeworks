using System;

namespace GenericStack
{
    public class Stack<T>
    {
        private int Size;
        private int StackPointer = 0;
        private T[] Items;

        public Stack()
            : this(100)
        { }

        public Stack(int size)
        {
            this.Size = size;
            this.Items = new T[Size];
        }

        public void Push(T item)
        {
            if (StackPointer >= Size)
            {
                Size *= 2; 
                T[] resizedItems = new T[Size];
                Array.Resize(ref Items, Size);
            }

            Items[StackPointer] = item;
            StackPointer++;
        }

        public T Pop()
        {
            StackPointer--;
            if (StackPointer >= 0)
            {
                return Items[StackPointer];
            }
            else
            {
                StackPointer = 0;
                throw new InvalidOperationException("Cannot pop an empty stack");
            }
        }

        public override string ToString()
        {
            return string.Join(" ", this.Items);
        }
    }
}
