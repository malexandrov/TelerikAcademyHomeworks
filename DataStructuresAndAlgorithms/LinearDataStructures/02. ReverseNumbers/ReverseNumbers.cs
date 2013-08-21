namespace _02.ReverseNumbers
{
    using System;
    using System.Collections.Generic;

    class ReverseNumbers
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int inputNum = int.Parse(Console.ReadLine());
                numbers.Push(inputNum);
            }

            Console.WriteLine("Numbers reversed:");
            int numbersCount = numbers.Count;

            for (int i = 0; i < numbersCount; i++)
            {
                Console.WriteLine(numbers.Pop());
            }

        }
    }
}
