using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ExtractTextFromXml
{
    class ExtractTextFromXml
    {
        static void Main(string[] args)
        {
            string fileName = "../../test.xml";

            List<string> extractedText = new List<string>();

            using (StreamReader file = new StreamReader(fileName))
            {
                string text = "";
                int length = 0;
                int start = 0;
                int end = 0;

                string lineText = file.ReadLine();
                while (lineText != null)
                {
                    start = lineText.IndexOf('>');
                    end = lineText.LastIndexOf('<');
                    if (start != 0 && end != 0)
                    {
                        if (start < end)
                        {
                            length = end - start;
                            text = lineText.Substring(start+1 , length-1);
                            extractedText.Add(text);
                        }
                    }
                    lineText = file.ReadLine();
                    start = 0;
                    end = 0;
                }
            }
            using (StreamWriter destinationFile = new StreamWriter("../../output.txt"))
            {
                for (int i = 0; i < extractedText.Count; i++)
                {
                    destinationFile.WriteLine(extractedText[i]);
                }
            }
        }
    }
}