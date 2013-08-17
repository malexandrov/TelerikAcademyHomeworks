using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;


class ReplaceWordOccurence
{
    static void Main()
    {
        using (StreamReader input = new StreamReader("../../input.txt"))
        {
            using (StreamWriter output = new StreamWriter("../../output.txt"))
            {
                string oneLine = input.ReadLine();
                string strToReplace = "start";
                string strToPlace = "finish";

                while (oneLine != null)
                {
                    output.WriteLine(oneLine.Replace(strToReplace, strToPlace));
                    oneLine = input.ReadLine();
                }
            }
        }
    }
}