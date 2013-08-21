namespace RemoveNumbersOccuringOddTime
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

        public static List<int> RemoveOccuringOddTime(List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                throw new ArgumentNullException("Sequence cannot be empty!");
            }

            List<int> resultList = new List<int>();
            int listLength = list.Count;

            for (int i = 0; i < listLength; i++)
            {
                int currElement = list[i];
                int occurences = list.FindAll(x => x == currElement).Count;

                if (occurences % 2 == 0)
                {
                    resultList.Add(currElement);
                }
            }

            return resultList;
        }
    }
}