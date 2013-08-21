namespace FindShortestSequenceOfOpperations
{
    using System;
    using System.Collections.Generic;
    
    class FindShortestSequenceOfOpperations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number N: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number M: ");
            int M = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();
            list.Add(M);

            while (M / 2 >= N)
            {
                M = M / 2;
                list.Add(M);
            }

            while (M - 2 >= N)
            {
                M = M - 2;
                list.Add(M);
            }

            while (M - 1 >= N)
            {
                M = M - 1;
                list.Add(M);
            }

            list.Reverse();
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
