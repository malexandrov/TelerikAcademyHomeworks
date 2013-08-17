using System;
using System.IO;
using System.Text;


class InsertLineNumbers
{
    static void Main()
    {
        int i = 1;
        using (StreamReader first = new StreamReader("../../first.txt"))
        using (StreamWriter output = new StreamWriter("../../output.txt"))

        for (string line; (line= first.ReadLine()) != null; i++)
        {
            output.WriteLine(i + ". "+ line);
        }
    }
}