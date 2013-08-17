using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class DeleteWordsFromList
{
    static void Main()
    {
        List<string> wordsList = new List<string>();
        using (StreamReader words = new StreamReader("../../words.txt"))
        {
            
            string lineText = words.ReadLine();

            while (lineText != null)
            {
                wordsList.Add(lineText);
                lineText = words.ReadLine();
            }
        }

        try
        {
            using (StreamReader text = new StreamReader("../../text.txt"))
            using (StreamWriter output = new StreamWriter("../../output.txt"))
            {
                string lineText = text.ReadLine();
                while (lineText != null)
                {
                    for (int i = 0; i < wordsList.Count; i++)
                    {
                        string word = wordsList[i];
                        lineText = lineText.Replace(word, "");
                    }
                    output.WriteLine(lineText);
                    lineText = text.ReadLine();
                }
            }
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
        }
    }
}