namespace GenericLinkedList
{
    using System;

    public class LinkedList<T>
    {
        public ListItem<T> FirstElement;

        public LinkedList()
        {
            this.FirstElement = new ListItem<T>();
        }

        public LinkedList(ListItem<T> firstItem)
        {
            this.FirstElement = firstItem;
        }

        public void AddFront(T value)
        {
            ListItem<T> newItem = new ListItem<T>(value, FirstElement.NextItem);
            newItem.NextItem = this.FirstElement;
            this.FirstElement = newItem;

        }
    }
}
