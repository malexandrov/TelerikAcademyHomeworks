using System;

class PrintCopyrightTriangle
{
    static void Main()
    {
        char a = '\u00A9';
        Console.WriteLine("   {0}   ",a);
        Console.WriteLine("  {0} {0}  ", a);
        Console.WriteLine(" {0}   {0} ", a);
        Console.WriteLine("{0} {0} {0} {0}", a);
    }
}

