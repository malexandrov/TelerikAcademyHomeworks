using System;

class AssignNullValues
{
    static void Main()
    {
        int? nullInt = null;
        double? nullDouble = null;
        Console.WriteLine(nullInt.GetValueOrDefault());
        Console.WriteLine(nullDouble.GetValueOrDefault());

        nullInt = 123;
        nullDouble = 12;
        Console.WriteLine(nullInt.GetValueOrDefault());
        Console.WriteLine(nullDouble.GetValueOrDefault());

        nullInt = null + 123;
        nullDouble = null - 12;
        Console.WriteLine(nullInt.GetValueOrDefault());
        Console.WriteLine(nullDouble.GetValueOrDefault());
    }
}

