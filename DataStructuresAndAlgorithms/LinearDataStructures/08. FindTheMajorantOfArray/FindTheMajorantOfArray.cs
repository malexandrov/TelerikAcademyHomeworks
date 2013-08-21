namespace FindTheMajorantOfArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FindTheMajorantOfArray
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

            int majorityCandidate = 0;
            int count = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (count == 0)
                {
                    majorityCandidate = numbers[i];
                    count = 1;
                }

                if (majorityCandidate == numbers[i+1])
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            int votes = numbers.Count(num => num == majorityCandidate);
            if (votes > numbers.Length / 2)
            {
                Console.WriteLine("Majorant of the array is: " + majorityCandidate);
            }
            else
            {
                Console.WriteLine("No majorant in array.");
            }
        }
    }
}
