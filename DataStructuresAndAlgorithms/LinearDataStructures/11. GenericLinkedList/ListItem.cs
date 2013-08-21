namespace GenericLinkedList
{
    using System;

    public class ListItem<T>
    {
        public T Value;
        public ListItem<T> NextItem;

        public ListItem()
        {
            Value = default(T);
            NextItem = null;
        }

        public ListItem(T value, ListItem<T> nextItem)
        {
            this.Value = value;
            this.NextItem = nextItem;
        }

    }
}
