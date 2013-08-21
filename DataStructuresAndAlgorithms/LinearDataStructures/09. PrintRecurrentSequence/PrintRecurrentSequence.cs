namespace PrintRecurrentSequence
{
    using System;
    using System.Collections.Generic;

    class PrintRecurrentSequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number N: ");

            int N = int.Parse(Console.ReadLine());  
            int count = 50;

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(N);

            for (int i = 0; i < count; i++)
            {
                int current = queue.Dequeue();
                Console.Write(current + " ");

                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current + 1);
                queue.Enqueue(current + 2);
            }
        }
    }
}
