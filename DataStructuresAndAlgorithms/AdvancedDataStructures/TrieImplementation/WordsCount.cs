namespace WordsCount
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;

    public class WordsCount
    {
        const string FileToSearch = "..\\..\\Text.txt";
        const string WordsToSearch = "..\\..\\Words.txt";

        static void Main()
        {
            GenerateRandomText(FileToSearch, 100000); 
            GenerateRandomText(WordsToSearch, 1000);

            var trie = BuildTrie();           
            var words = GetWords();

            SortedDictionary<string, int> wordsAndOccurances = new SortedDictionary<string, int>();
            foreach (var word in words)
            {
                int occurances = 0;
                trie.ContainsWord(word, out occurances);
                if (!wordsAndOccurances.ContainsKey(word))
                {
                    wordsAndOccurances.Add(word, occurances);
                }                
            }

            Console.WriteLine(wordsAndOccurances.Count);

            PrintWordOccurences(wordsAndOccurances);
        }

        private static void PrintWordOccurences(SortedDictionary<string, int> wordsAndOccurences)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in wordsAndOccurences.OrderBy(x => x.Value))
            {
                sb.AppendFormat("{0} -> {1}\n", item.Key, item.Value);
            }

            Console.WriteLine(sb.ToString());
        }
  
        private static string[] GetWords()
        {
            var wordsText = ReadFile(WordsToSearch);
            var words = wordsText.Split(TrieNode.Separators, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }
  
        private static Trie BuildTrie()
        {
            var trie = new Trie();
            var text = ReadFile(FileToSearch);
            trie.BuildTrie(text);

            return trie;
        }

        private static string ReadFile(string fileLocation)
        {
            var reader = new StreamReader(fileLocation);
            string content;
            using (reader)
            {
                content = reader.ReadToEnd();
            }

            return content;
        }

        private static void GenerateRandomText(string fileLocation, int wordsNumber)
        {
            var writer = new StreamWriter(fileLocation);
            using (writer)
            {
                for (int i = 0; i < wordsNumber; i++)
                {
                    writer.Write(RandomStr());
                }

            }
        }

        public static string RandomStr()
        {
            string[] array = new string[46]
	        {
		        "a","b","c","d","e","f","g","h","j","k","m","n","p","q","r","s","t","u","v","w","x","y","z",
		        "A","B","C","D","E","F","G","H","J","K","L","M","N","P","R","S","T","U","V","W","X","Y","Z"
	        };
            Random num = new Random();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < GetRandomNumber(8); i++) sb.Append(array[GetRandomNumber(45)]);
            sb.Append(" ");
            return sb.ToString();
        }

        public static int GetRandomNumber(int maxNumber)
        {
            byte[] b = new byte[4];
            new System.Security.Cryptography.RNGCryptoServiceProvider().GetBytes(b);
            int seed = (b[0] & 0x7f) << 24 | b[1] << 16 | b[2] << 8 | b[3];
            System.Random r = new System.Random(seed);
            return r.Next(2, maxNumber);
        }
    }
}
