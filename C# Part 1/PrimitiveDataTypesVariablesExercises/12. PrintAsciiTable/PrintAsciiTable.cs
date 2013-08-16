using System;

class PrintAsciiTable
{
    static void Main()
    {
        byte counter;
        for ( counter = 0; counter < 128; counter++)
        {
            Console.WriteLine((char)counter);
        }
    }
}

