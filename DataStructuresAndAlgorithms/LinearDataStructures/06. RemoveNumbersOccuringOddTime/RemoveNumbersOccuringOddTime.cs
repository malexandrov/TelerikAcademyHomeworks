namespace RemoveNumbersOccuringOddTime
{
    using System;
    using System.Collections.Generic;

    class RemoveNumbersOccuringOddTime
    {
        static void Main(string[] args)
        {
            List<int> sequence1 = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            ListUtilities.PrintListElements(sequence1);
            ListUtilities.PrintListElements(ListUtilities.RemoveOccuringOddTime(sequence1));
        }
    }
}
