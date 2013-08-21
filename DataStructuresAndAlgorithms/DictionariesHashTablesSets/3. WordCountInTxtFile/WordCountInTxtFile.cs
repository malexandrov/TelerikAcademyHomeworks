namespace WordCountInTxtFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class WordCountInTxtFile
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"../../Words.txt");
            StringComparer comparer = StringComparer.InvariantCultureIgnoreCase;
            IDictionary<string, int> occurences = new Dictionary<string, int>(comparer);

            using (reader)
            {
                string text = reader.ReadToEnd();
                char[] separators = {'?','!','.',',','-','-','–',';',' '};
                string[] tokens = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < tokens.Length; i++)
                {
                    // The ToLower is not needed because of the comparer in the dictionary. Its there so the output is prettier :)
                    string currentWord = tokens[i].ToLower(); 

                    if (occurences.ContainsKey(currentWord))
                    {
                        occurences[currentWord]++;
                    }
                    else occurences[currentWord] = 1;
                }
            }

            occurences = occurences.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (var pair in occurences)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}
