using System;
using System.Collections.Generic;

class ConvertFromToAnyNumeralSystem
{
    static void Main()
    {
        Console.Write("Number n: ");
        string number = (Console.ReadLine()).ToUpper();
        Console.Write("Base s from: ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Base d to: ");
        int d = int.Parse(Console.ReadLine());

        if (s < 2 || d < 2 || s > 16 || d > 16)
        {
            Console.WriteLine("s and d must be (2<=s, d<=16)");
        }
        else
        {
            FromDec(ToDec(number, s), d);
        }
    }

    static int ToDec(string number, int s)
    {
        int decNumber = 0;
        for (int i = number.Length - 1, pow = 0; i >= 0; i--, pow++)
        {
            if (number[i] > 57)                     // Use ASCII table char codes 
            {
                switch (number[i])
                {
                    case 'A': decNumber += 10 * (int)Math.Pow(s, pow); break;
                    case 'B': decNumber += 11 * (int)Math.Pow(s, pow); break;
                    case 'C': decNumber += 12 * (int)Math.Pow(s, pow); break;
                    case 'D': decNumber += 13 * (int)Math.Pow(s, pow); break;
                    case 'E': decNumber += 14 * (int)Math.Pow(s, pow); break;
                    case 'F': decNumber += 15 * (int)Math.Pow(s, pow); break;
                }
            }
            else
            {
                decNumber += (number[i] - 48) * (int)Math.Pow(s, pow);
            }
        }
        return decNumber;
    }

    static void FromDec(int number, int d)
    {
        List<string> binNumber = new List<string>();
        do
        {
            if (number % d > 9)
            {
                switch (number % d)
                {
                    case 10: binNumber.Add("A"); break;
                    case 11: binNumber.Add("B"); break;
                    case 12: binNumber.Add("C"); break;
                    case 13: binNumber.Add("D"); break;
                    case 14: binNumber.Add("E"); break;
                    case 15: binNumber.Add("F"); break;
                }
            }
            else
            {
                int hexNum = number % d;
                binNumber.Add(hexNum.ToString());
            }
            number = number / d;
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