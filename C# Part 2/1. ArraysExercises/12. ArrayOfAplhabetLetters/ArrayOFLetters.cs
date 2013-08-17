using System;

class Program
{
    static void Main()
    {
        int[] arrayOfLetters = new int[52];
        string word = Console.ReadLine();
        
        for (int i = 0; i < arrayOfLetters.Length / 2; i++)
        {
            arrayOfLetters[i] = ('A' + i);
        }

        for (int j = 26; j < arrayOfLetters.Length; j++)
        {
            arrayOfLetters[j] = ('A' + j) + 6;
        }

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < arrayOfLetters.Length; j++)
            {
                if (word[i] == arrayOfLetters[j])
                {
                    Console.WriteLine("Letter {0} Index {1}", word[i], j);
                }
            }
        }
    }
}