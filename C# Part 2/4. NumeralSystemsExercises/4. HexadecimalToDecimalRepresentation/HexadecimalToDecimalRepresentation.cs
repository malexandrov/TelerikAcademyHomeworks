using System;
using System.Collections.Generic;

class HexadecimalToDecimalRepresentation
{
    static void Main()
    {
        string number = "1F4";
        Console.WriteLine(number);

        HexToDecConvert(number);
    }

    static void HexToDecConvert(string number)
    {
        int decNumber = 0;
        for (int i = number.Length-1, pow=0; i >= 0 ; i--, pow++)
        {
            if (number[i] > 57)                     // Use ASCII table char codes 
            {
                switch (number[i])
                {
                    case 'A': decNumber += 10 * (int)Math.Pow(16, pow); break;
                    case 'B': decNumber += 11 * (int)Math.Pow(16, pow); break;
                    case 'C': decNumber += 12 * (int)Math.Pow(16, pow); break;
                    case 'D': decNumber += 13 * (int)Math.Pow(16, pow); break;
                    case 'E': decNumber += 14 * (int)Math.Pow(16, pow); break;
                    case 'F': decNumber += 15 * (int)Math.Pow(16, pow); break;
                }
            }
            else
            {
                decNumber += (number[i]-48) * (int)Math.Pow(16, pow);
            }
        }
        Console.WriteLine(decNumber);
    }
}
