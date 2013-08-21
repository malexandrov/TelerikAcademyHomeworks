namespace NumberOfValueOccurences
{
    using System;
    using System.Collections.Generic;

    class NumberOfValueOccurences
    {
        static void Main()
        {
            double[] givenArray = { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            Console.WriteLine(String.Join(", ", givenArray));

            Dictionary<double, int> occurences = new Dictionary<double, int>();
            for (int i = 0; i < givenArray.Length; i++)
            {
                if (occurences.ContainsKey(givenArray[i]))
                {
                    occurences[givenArray[i]]++;
                }
                else
                {
                    occurences[givenArray[i]] = 1;
                }
            }

            foreach (var pair in occurences)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}
