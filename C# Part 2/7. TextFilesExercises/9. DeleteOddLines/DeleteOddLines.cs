using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DeleteOddLines
{
    static void Main()
    {
        string firstFileName = "../../test.txt";

        List<string> oddLines = new List<string>();

        using (StreamReader file = new StreamReader(firstFileName))
        {
            string lineText = file.ReadLine();
            int lineNumber = 1;
            while (lineText != null)
            {
                if (lineNumber % 2 != 0)
                {
                    oddLines.Add(lineText);
                }
                lineText = file.ReadLine();
                lineNumber++;
            }
        }

        using (StreamWriter destinationFile = new StreamWriter(firstFileName))
        {
            for (int i = 0; i < oddLines.Count; i++)
            {
                destinationFile.WriteLine(oddLines[i]);
            }
        }
    }
}