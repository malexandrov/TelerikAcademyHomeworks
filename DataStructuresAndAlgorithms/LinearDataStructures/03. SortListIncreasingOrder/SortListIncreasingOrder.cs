namespace _03.SortListIncreasingOrder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SortListIncreasingOrder
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = new List<int>();
            FillNumbersList(inputNumbers);

            inputNumbers.Sort();
            Console.WriteLine("Sorted:");
            for (int i = 0; i < inputNumbers.Count; i++)
            {
                Console.Write("{0} ", inputNumbers[i]);
            }
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
