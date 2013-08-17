using System;
using System.Collections.Generic;

class DecimalToHexadecimalRepresentation
{
    static void Main()
    {
        int number = 500;
        Console.WriteLine(number);

        DecToHexConvert(number);
    }

    static void DecToHexConvert(int number)
    {
        List<string> hexNumber = new List<string>();
        do
        {
            if (number % 16 > 9)
            {
                switch (number % 16)
                {
                    case 10: hexNumber.Add("A"); break;
                    case 11: hexNumber.Add("B"); break;
                    case 12: hexNumber.Add("C"); break;
                    case 13: hexNumber.Add("D"); break;
                    case 14: hexNumber.Add("E"); break;
                    case 15: hexNumber.Add("F"); break;
                }
            }
            else
            {
                int hexNum = number % 16;
                hexNumber.Add(hexNum.ToString());
            }
            number = number / 16;
        }
        while (number > 0);
        hexNumber.Reverse();

        for (int i = 0; i < hexNumber.Count; i++)
        {
            Console.Write(hexNumber[i]);
        }
        Console.WriteLine();
    }
}