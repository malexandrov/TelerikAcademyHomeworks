using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class DeleteWordWithPrefix
{
    static void Main()
    {
          using (StreamReader input = new StreamReader("../../in.txt"))
          using (StreamWriter output = new StreamWriter("../../out.txt"))
          {
               string lineText = input.ReadLine();
               while (lineText != null)
               {
                   output.WriteLine(Regex.Replace(lineText, "\\btest[A-Za-z0-9_]*\\b", ""));
                   lineText = input.ReadLine();
               }
          }
    }
}
