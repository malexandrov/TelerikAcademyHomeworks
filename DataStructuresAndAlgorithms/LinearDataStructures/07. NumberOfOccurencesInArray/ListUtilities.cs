namespace NumberOfOccurencesInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ListUtilities
    {
        public static void PrintListElements<T>(IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static Dictionary<int, int> GroupByOccurence(int[] list)
        {
            if (list == null)
            {
                throw new ArgumentNullException("Sequence cannot be empty!");
            }

            Dictionary<int, int> occurences = new Dictionary<int, int>();
            
            for (int i = 0; i < list.Count(); i++)
            {
                int element = list[i];

                if (occurences.ContainsKey(element))
                {
                    occurences[element]++;
                }
                else
                {
                    occurences.Add(element, 1);
                }
            }

            return occurences;
        }
    }
}