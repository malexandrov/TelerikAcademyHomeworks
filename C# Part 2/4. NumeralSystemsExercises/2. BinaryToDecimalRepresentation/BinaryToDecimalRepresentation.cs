using System;
using System.Collections.Generic;


class BinaryToDecimalRepresentation
{
    static void Main()
    {
        string number = "111110100";
        Console.WriteLine(number);

        BinToDecConvert(number);
    }

    static void BinToDecConvert(string number)
    {
        int decNumber = 0;
        for (int i = 0; i < number.Length; i++)
        {
            if (number[number.Length - i - 1] == '0')
            {
                continue;
            }
            else decNumber += (int)Math.Pow(2, i);
        }
        Console.WriteLine(decNumber);
    }
}