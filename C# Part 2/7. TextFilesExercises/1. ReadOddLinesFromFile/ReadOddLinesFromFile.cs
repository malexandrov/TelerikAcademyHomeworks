using System;
using System.IO;


class ReadOddLinesFromFile
{
    static void Main()
    {
        int row = 1;
        StreamReader streamReader = new StreamReader("../../ReadOddLinesFromFile.cs");
        string oneLine = streamReader.ReadLine();

        while (oneLine != null)
        {
            if (row % 2 != 0)
            {

                Console.WriteLine(oneLine);
            }
            row++;
            oneLine = streamReader.ReadLine();
        }
 
    }
}