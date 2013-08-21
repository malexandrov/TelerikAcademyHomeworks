namespace Crossword
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class CrosswordSolver
    {
        static HashSet<string> allWords = new HashSet<string>();
        static string[] words;
        static string[] crossword;

        static void SolveCrosswords(int indexLine)
        {
            if (indexLine >= crossword.Length)
            {
                if (CheckVerticalWord())
                {
                    PrintCrossword();
                    Environment.Exit(0);
                }
                return;
            }

            for (int i = 0; i < words.Length; i++)
            {
                crossword[indexLine] = words[i];
                SolveCrosswords(indexLine + 1);
                crossword[indexLine] = null;
            }
        }

        static void PrintCrossword()
        {
            for (int i = 0; i < crossword.Length; i++)
            {
                Console.WriteLine(crossword[i]);
            }
        }

        static bool CheckVerticalWord()
        {
            StringBuilder currentWord = new StringBuilder();
            for (int i = 0; i < crossword.Length; i++)
            {
                currentWord.Clear();

                for (int j = 0; j < crossword.Length; j++)
                {
                    currentWord.Append(crossword[j][i]);
                }

                if (!allWords.Contains(currentWord.ToString()))
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            words = new string[2 * N];
            crossword = new string[N];

            for (int i = 0; i < 2 * N; i++)
            {
                words[i] = Console.ReadLine();
                allWords.Add(words[i]);
            }

            Array.Sort(words);
            SolveCrosswords(0);

            Console.WriteLine("NO SOLUTION!");
        }
    }
}
//4
//FIRE
//ACID
//CENG
//EDGE
//FACE
//ICED
//RING
//CERN