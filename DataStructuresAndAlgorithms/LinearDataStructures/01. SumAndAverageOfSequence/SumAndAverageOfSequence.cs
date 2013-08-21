namespace _01.SumAndAverageOfSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SumAndAverageOfSequence
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = new List<int>();
            FillNumbersList(inputNumbers);

            // We could also use the built-in List.Average and List.Sum methods
            long sumOfElements = MathUtilities.GetSum(inputNumbers);
            double averageOfElements = MathUtilities.GetAverage(inputNumbers);
            Console.WriteLine("The sum of the elements is: " + sumOfElements);
            Console.WriteLine("The average of the elements is: " + averageOfElements);
        }

        private static void FillNumbersList(List<int> inputNumbers)
        {
            bool isEnd = false;

            while (!isEnd)
            {
                string parsedLine = Console.ReadLine();

                if (string.IsNullOrEmpty(parsedLine))
                {
                    isEnd = true;
                }
                else
                {
                    int parsedNum = int.MinValue;

                    if (int.TryParse(parsedLine, out parsedNum))
                    {
                        inputNumbers.Add(parsedNum);
                    }
                    else
                    {
                        throw new FormatException("Input is not in the right format (positive integer number): " + parsedLine);
                    }
                }
            }
        }
    }
}
