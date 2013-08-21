using System;
using System.Collections.Generic;

namespace LinkedQueue
{
    class LinkedQueue
    {
        static void Main(string[] args)
        {
            var myQueue = new Queue<int>();

            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            Console.WriteLine(myQueue);

            Console.WriteLine();
            myQueue.Dequeue();
            Console.WriteLine(myQueue);
            myQueue.Dequeue();
            Console.WriteLine(myQueue);
            myQueue.Dequeue();
            Console.WriteLine(myQueue);
        }
    }
}
