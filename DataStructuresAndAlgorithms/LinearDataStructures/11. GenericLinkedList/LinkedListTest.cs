using System;
using GenericLinkedList;

class LinkedListTest
{
    static void Main(string[] args)
    {
        ListItem<int> firstItem = new ListItem<int>();
        firstItem.Value = 4;
        LinkedList<int> list = new LinkedList<int>(firstItem);

        list.AddFront(3);
        list.AddFront(2);
        list.AddFront(1);

        Console.WriteLine(list.FirstElement.Value);
        Console.WriteLine(list.FirstElement.NextItem.Value);
        Console.WriteLine(list.FirstElement.NextItem.NextItem.Value);
        Console.WriteLine(list.FirstElement.NextItem.NextItem.NextItem.Value);
    }
}