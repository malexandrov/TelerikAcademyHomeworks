using System;
using System.Collections.Generic;

namespace _2.IEnumerableExtensions
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            IEnumerable<int> someElements = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9};

            Console.WriteLine(someElements.Sum<int>());
            Console.WriteLine(someElements.Product<int>());
            Console.WriteLine(someElements.Min<int>());
            Console.WriteLine(someElements.Max<int>());
            Console.WriteLine(someElements.Average<int>());
        }
    }
}
