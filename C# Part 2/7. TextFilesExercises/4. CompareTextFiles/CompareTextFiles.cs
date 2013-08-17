using System;
using System.IO;
using System.Text;

class CompareTextFiles
{
    static void Main()
    {
        int sameLines = 0;
        int diffLines = 0;

         using (StreamReader first = new StreamReader("../../first.txt"))
         {
             using (StreamReader second = new StreamReader("../../second.txt"))
             {
                 string lineFirst = first.ReadLine();
                 string lineSecond = second.ReadLine();
                 
                while (lineFirst != null || lineSecond != null)
                 {
                     lineFirst = first.ReadLine();
                     lineSecond = second.ReadLine();

                     if (lineFirst == lineSecond)
                     {
                         sameLines++;
                     }
                     if (lineFirst != lineSecond)
                     {
                         diffLines++;
                     }
                 }
             }
         }
         Console.WriteLine("Same lines: " + sameLines);
         Console.WriteLine("Different lines: " + diffLines);
    }
}
