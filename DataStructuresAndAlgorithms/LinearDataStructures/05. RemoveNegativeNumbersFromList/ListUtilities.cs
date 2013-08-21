namespace RemoveNegativeNumbersFromList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ListUtilities
    {
        public static void PrintListElements(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static List<int> RemoveNegativeElements(List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                throw new ArgumentNullException("Sequence cannot be empty!");
            }

            List<int> resultList = new List<int>();
            int listLength = list.Count;

            for (int i = 0; i < listLength; i++)
            {
                if (list[i] > 0)
                {
                    resultList.Add(list[i]);
                }
            }

            return resultList;
        }
    }
}