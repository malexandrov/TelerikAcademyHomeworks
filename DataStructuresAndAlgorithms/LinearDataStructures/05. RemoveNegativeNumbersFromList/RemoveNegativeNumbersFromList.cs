namespace RemoveNegativeNumbersFromList
{
    using System;
    using System.Collections.Generic;

    public class RemoveNegativeNumbersFromList
    {
        public static void Main(string[] args)
        {
            List<int> sequence1 = new List<int>() { -1, 1, 2, -2, 3, -3, 4, -4, 5, -5 };

            ListUtilities.PrintListElements(sequence1);
            ListUtilities.PrintListElements(ListUtilities.RemoveNegativeElements(sequence1));
        }
    }
}