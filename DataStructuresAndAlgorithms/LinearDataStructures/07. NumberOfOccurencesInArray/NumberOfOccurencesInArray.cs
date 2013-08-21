using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfOccurencesInArray
{
    class NumberOfOccurencesInArray
    {
        static void Main(string[] args)
        {
            int[] sequence1 = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            ListUtilities.PrintListElements(sequence1);
            ListUtilities.PrintListElements(ListUtilities.GroupByOccurence(sequence1));
        }
    }
}
