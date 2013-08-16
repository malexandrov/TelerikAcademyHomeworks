using System;

class PrintSequenceMembers
{
    static void Main()
    {
        for (byte i = 2; i < 12; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine(i);
            else
                Console.WriteLine("-" + i);
        }
    }
}

