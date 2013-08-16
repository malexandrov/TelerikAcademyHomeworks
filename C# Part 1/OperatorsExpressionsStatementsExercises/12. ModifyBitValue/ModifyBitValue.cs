using System;

class ModifyBitValue
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("v = ");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        int result = v == 0 ? (n = n & (~(1 << p))) : (n = n | (1 << p));
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}
