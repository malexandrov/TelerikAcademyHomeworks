﻿using System;

public class TextUtils
{
    public static string ConvertDigitToWord(int number)
    {
        switch (number)
        {
            case 0: return "zero";
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            case 9: return "nine";
            default: throw new ArgumentOutOfRangeException("value out of range [0...9].");
        }
    }

    public static void PrintAsNumber(object number, string format)
    {
        if (format == "f")
        {
            Console.WriteLine("{0:f2}", number);
        }
        if (format == "%")
        {
            Console.WriteLine("{0:p0}", number);
        }
        if (format == "r")
        {
            Console.WriteLine("{0,8}", number);
        }
    }
}
