namespace ExtractElementsOccuringOddTimes
{
    using System;
    using System.Collections.Generic;
    class ExtractElementsOccuringOddTimes
    {
        static void Main(string[] args)
        {
            string[] strings = {"С#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            Console.WriteLine(String.Join(", ", strings));

            Dictionary<string, int> occurences = new Dictionary<string, int>();
            for (int i = 0; i < strings.Length; i++)
            {
                if (occurences.ContainsKey(strings[i]))
                {
                    occurences[strings[i]]++;
                }
                else
                {
                    occurences[strings[i]] = 1;
                }
            }

            foreach (var pair in occurences)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.Write(pair.Key + " ");
                }
            }
        }
    }
}
