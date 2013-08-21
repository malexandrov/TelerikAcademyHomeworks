namespace _01.SumAndAverageOfSequence
{
    using System;
    using System.Collections.Generic;

    public class MathUtilities
    {
        public static long GetSum(List<int> input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("List cannot be empty or null");
            }

            long sum = 0;
            foreach (var listItem in input)
            {
                sum += listItem;
            }

            return sum;
        }

        public static double GetAverage(List<int> input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("List cannot be empty or null");
            }

            long sum = GetSum(input);
            double average = (double)sum / input.Count;

            return average;
        }
    }
}
