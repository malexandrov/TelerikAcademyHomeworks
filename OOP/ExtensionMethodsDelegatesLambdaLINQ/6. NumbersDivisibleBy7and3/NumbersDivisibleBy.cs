using System;
using System.Collections.Generic;
using System.Linq;


namespace _6.NumbersDivisibleBy7and3
{
    class NumbersDivisibleBy
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[1000];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

            // Lambda expression
            var subset = numbers.Where(number => number % 21 == 0);

            foreach (var num in subset)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            // LINQ
            var numList =
                from number in numbers
                where number % 21 == 0
                select number;

            foreach (var num in numList)
            {
                Console.WriteLine(num);
            }
        }
    }
}
