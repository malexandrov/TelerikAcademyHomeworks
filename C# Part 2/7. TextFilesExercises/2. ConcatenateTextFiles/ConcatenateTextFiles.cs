using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class ConcatenateTextFiles
{
    static void Main()
    {
        StreamReader first = new StreamReader("../../first.txt", Encoding.GetEncoding("windows-1251"));
        StreamReader second = new StreamReader("../../second.txt", Encoding.GetEncoding("windows-1251"));
        StreamWriter outputFile = new StreamWriter("../../output.txt");
        
        using (first)
        {
            using (second)
            {
                using (outputFile)
                {
                    string file1 = first.ReadToEnd();
                    string file2 = second.ReadToEnd();
                    string concat = file1 + file2;
                    outputFile.WriteLine(concat);
                }
            }
        }
    }
}
