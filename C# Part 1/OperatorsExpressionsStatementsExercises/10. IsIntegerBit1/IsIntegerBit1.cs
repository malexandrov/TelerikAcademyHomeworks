using System;

class IsIntegerBit1
{
    static void Main()
    {
        int v = 5;
        int p = 1;
        int mask = 1 << p; 
        int result = v & mask;
        // Console.WriteLine(Convert.ToString(v, 2).PadLeft(32, '0'));
        // Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));
        Console.WriteLine(result != 0 ? true : false);
    }
}
