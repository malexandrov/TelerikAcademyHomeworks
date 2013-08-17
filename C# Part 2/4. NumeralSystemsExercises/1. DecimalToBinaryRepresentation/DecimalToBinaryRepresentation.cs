using System;
using System.Collections.Generic;

class DecimalToBinaryRepresentation
{
    static void Main()
    {
        int number = 500;
        Console.WriteLine(number);

        DecToBinConvert(number);
    }

    static void DecToBinConvert(int number)
    {
        List<int> binNumber = new List<int>(16);
        do
        {
            binNumber.Add(number % 2);
            number = number / 2;
        }
        while (number > 0);
        binNumber.Reverse();


        for (int i = 0; i < binNumber.Count; i++)
        {
            Console.Write(binNumber[i]);
        }
        Console.WriteLine();
    }
}
