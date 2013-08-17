using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class SortTextFileOfStrings
{
    static void Main()
    {
        List<string> names = new List<string>();
        
        using (StreamReader input = new StreamReader("../../input.txt"))
        {
            string oneLine = input.ReadLine();
            while (oneLine != null)
            {
                names.Add(oneLine);
                oneLine = input.ReadLine();
            }
        }

        names.Sort();

        using (StreamWriter output = new StreamWriter("../../output.txt"))
        {
            for (int i = 0; i < names.Count; i++)
            {
                output.WriteLine(names[i]);
            }
        }
    }
}