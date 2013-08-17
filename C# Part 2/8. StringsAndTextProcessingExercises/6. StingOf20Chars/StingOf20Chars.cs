using System;

class StingOf20Chars
{
    static void Main()
    {
        string readString = Console.ReadLine();

        if (readString.Length > 20)
        {
            Console.WriteLine(readString.Substring(0, 20));
        }
        else
        {
            Console.WriteLine(readString.PadRight(20, '*'));
        }
    }
}