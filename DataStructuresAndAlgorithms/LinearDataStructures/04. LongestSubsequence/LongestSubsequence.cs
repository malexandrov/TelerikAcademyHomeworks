namespace LongestSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestSubsequence
    {
        static void Main(string[] args)
        {
            List<int> sequence1 = new List<int>() { 1, 2, 2, 3, 3, 3, 4, 4, 5, 5, 5, 5, 5 };
            List<int> sequence2 = new List<int>() { 1, 1, 2, 2, 3, 3, 3, 4, 4, 5, 5};

            
            PrintListElements(sequence1);
            Console.WriteLine("The best same element subsequence is:");
            PrintListElements(MaxSequenceOfEquals(sequence1));
           
            Console.WriteLine();
            PrintListElements(sequence2);
            Console.WriteLine("The best same element subsequence is:");
            PrintListElements(MaxSequenceOfEquals(sequence2));
        }

        public static void PrintListElements(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static List<int> MaxSequenceOfEquals(List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                throw new ArgumentNullException("Sequence cannot be empty!");
            }

            if (list.Count == 1)
            {
                return list;
            }

            int maxLength = 0;
            int currLength = 1;
            int maxElemIndex = 0;
            int currentIndex = 0;
            int listLength = list.Count;

            for (int i = 0; i < listLength - 1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    currLength++;
                    if (currLength > maxLength)
                    {
                        maxLength = currLength;
                        maxElemIndex = currentIndex;
                    }
                }
                else
                {
                    currentIndex = i + 1;
                    currLength = 1;
                }
            }

            List<int> resultList = list.GetRange(maxElemIndex, maxLength);
            return resultList;
        }
    }
}
