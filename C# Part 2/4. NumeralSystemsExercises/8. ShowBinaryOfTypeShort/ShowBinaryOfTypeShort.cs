using System;
using System.Collections.Generic;


class ShowBinaryOfTypeShort
{
    static void Main()
    {
        ShowBinary(123);
    }
    static void ShowBinary(short number)
    {
        byte mask = 1;
        int sign = 0;
        string binNum = "";

        sign = ((number >> 15) & mask);
        number = (short)(number & (~(mask << 15)));

        while (number != 0)
        {
            binNum = (number % 2) + binNum;
            number /= 2;
        }
        while (binNum.Length < 15)
        {
            binNum = "0" + binNum;
        }

        binNum = sign + binNum;
        Console.WriteLine(binNum);
    }
}