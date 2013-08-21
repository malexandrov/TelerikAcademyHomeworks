namespace PriorityQueue
{
    using System;
    using System.Collections.Generic;

    class PriorityQueueTest
    {
        static void Main()
        {
            PriorityQueue<Student> pq = new PriorityQueue<Student>();

            Student s1 = new Student("Pesho", 10658);
            Student s2 = new Student("Gosho", 11111);
            Student s3 = new Student("Joro", 33333);
            Student s4 = new Student("Jazz", 44444);
            Student s5 = new Student("Mincho", 55555);

            Console.WriteLine("Adding " + s5.ToString() + " to priority queue");
            pq.Enqueue(s5);
            Console.WriteLine("Adding " + s3.ToString() + " to priority queue");
            pq.Enqueue(s3);
            Console.WriteLine("Adding " + s4.ToString() + " to priority queue");
            pq.Enqueue(s4);
            Console.WriteLine("Adding " + s1.ToString() + " to priority queue");
            pq.Enqueue(s1);
            Console.WriteLine("Adding " + s2.ToString() + " to priority queue");
            pq.Enqueue(s2);

            Console.WriteLine("\nPriory queue is: ");
            Console.WriteLine(pq.ToString());
            Console.WriteLine("\n");

            Student removed = pq.Dequeue();
            Console.WriteLine("Removed:" + removed.ToString());
            Console.WriteLine("\nPriory queue is now: ");
            Console.WriteLine(pq.ToString());
            Console.WriteLine("\n");

            removed = pq.Dequeue();
            Console.WriteLine("Removed:" + removed.ToString());
            Console.WriteLine("\nPriory queue is now: ");
            Console.WriteLine(pq.ToString());
            Console.WriteLine("\n");

            removed = pq.Dequeue();
            Console.WriteLine("Removed:" + removed.ToString());
            Console.WriteLine("\nPriory queue is now: ");
            Console.WriteLine(pq.ToString());
            Console.WriteLine("\n");
        }
    }
}
