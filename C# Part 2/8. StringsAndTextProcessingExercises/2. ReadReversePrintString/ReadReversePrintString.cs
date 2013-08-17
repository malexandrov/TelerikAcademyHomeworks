using System;

class ReadReversePrintString
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        for (int i = inputString.Length-1; i >= 0 ; i--)
        {
            Console.Write(inputString[i]);
        }
    }
}