using System;

class IntegerBitCheck
{
    static void Main()
    {
        int a = 40;
        int mask = 1 << 3; //Or int mask = 8;
        int result = a & mask;
        //Console.WriteLine(Convert.ToString(a, 2).PadLeft(32, '0'));
        //Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));
        Console.WriteLine(result != 0 ? 1 : 0);
    }
}

