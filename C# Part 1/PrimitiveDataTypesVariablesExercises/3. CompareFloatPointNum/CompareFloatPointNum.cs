using System;

class CompareFloatPointNum
{
    static void Main()
    {
        Console.WriteLine("Моля въведете стойност за първа променлива:");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Моля въведете стойност за втора променлива:");
        decimal b = decimal.Parse(Console.ReadLine());
        bool result = (a == b);
        Console.WriteLine("Има ли равенство: {0}", result);
    }
}

