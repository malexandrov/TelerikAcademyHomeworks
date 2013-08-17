using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class ReplaceWholeWordOccurence
{
    static void Main()
    {
        using (StreamReader input = new StreamReader("../../input.txt"))
        {
            using (StreamWriter output = new StreamWriter("../../output.txt"))
            {
                string oneLine = input.ReadLine();
                while (oneLine != null)
                {
                    output.WriteLine(Regex.Replace(oneLine, @"\bstart\b", "finish"));
                    oneLine = input.ReadLine();
                }
            }
        }
    }
}