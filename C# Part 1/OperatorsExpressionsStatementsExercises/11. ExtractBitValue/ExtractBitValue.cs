using System;

class ExtractBitValue
{
    static void Main()
    {
        Console.Write("Enter number i: ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Enter position of the bit to be extracted: ");
        int b = int.Parse(Console.ReadLine());
        int mask = 1 << b;
        Console.WriteLine((i & mask) != 0 ? 1 : 0);
    }
}
