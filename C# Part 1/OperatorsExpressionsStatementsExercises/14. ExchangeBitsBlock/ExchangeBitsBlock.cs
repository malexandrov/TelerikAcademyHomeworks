using System;

class ExchangeBitsBlock
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int positionsToShift = q-p;
        uint pBits = 0, qBits = 0;
        uint firstBits, secondBits;
        uint mask = 1;

        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

        for (int i = 0; i < k; i++)
        {
            pBits = pBits | (mask << p+i);                          // Put the masks in place
            qBits = qBits | (mask << q+i);
        }

        firstBits = (n & pBits) << positionsToShift;                // Get bits and shift places
        secondBits = (n & qBits) >> positionsToShift;
        Console.WriteLine(Convert.ToString(firstBits, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(secondBits, 2).PadLeft(32, '0'));

        n = n & ~pBits;                                            // Zero the bits positions
        n = n & ~qBits;
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

        n = n | firstBits | secondBits;                            // Put bits in their new places
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine(n);  
    }
}
