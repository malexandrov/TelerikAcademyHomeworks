using System;

class GivenBitsExchange
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint bits_3_4_5, bits_24_25_26;
        uint firstBits, secondBits;
        uint mask = 7;
        int positionsToShift = 21;
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));   
        
        bits_3_4_5 = mask << 3;                                         // Put the masks in place
        bits_24_25_26 = mask << 24;

        firstBits = (n & bits_3_4_5) << positionsToShift;                // Get bits and shift places
        secondBits = (n & bits_24_25_26) >> positionsToShift;
        Console.WriteLine(Convert.ToString(firstBits, 2).PadLeft(32, '0'));  
        Console.WriteLine(Convert.ToString(secondBits, 2).PadLeft(32, '0'));  
        
        n = n & ~bits_3_4_5;                                            // Zero the bits positions
        n = n & ~bits_24_25_26;
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));    
        
        n = n | firstBits | secondBits;                                 // Put bits in their new places
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine(n);  
    }
}

