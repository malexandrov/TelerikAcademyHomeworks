using System;
using System.Collections.Generic;

class BinaryToHexadecimalDirectly
{
    static void Main()
    {
        string number = "000111110100";
        Console.WriteLine(number);
        BinToHexConvert(number);
    }

    static void BinToHexConvert(string number)
    {
        string hexNum = "";
        string subNumber = "";

        for (int i = 0; i < number.Length; i+=4)
        {
            subNumber = number.Substring(i, 4);
            switch (subNumber)
            {
                case "0000": hexNum += "0"; break;
                case "0001": hexNum += "1"; break;
                case "0010": hexNum += "2"; break;
                case "0011": hexNum += "3"; break;
                case "0100": hexNum += "4"; break;
                case "0101": hexNum += "5"; break;
                case "0110": hexNum += "6"; break;
                case "0111": hexNum += "7"; break;
                case "1000": hexNum += "8"; break;
                case "1001": hexNum += '9'; break;
                case "1010": hexNum += 'A'; break;
                case "1011": hexNum += 'B'; break;
                case "1100": hexNum += 'C'; break;
                case "1101": hexNum += 'D'; break;
                case "1110": hexNum += 'E'; break;
                case "1111": hexNum += 'F'; break;
            }
        }
        Console.WriteLine(hexNum);
    }
}
