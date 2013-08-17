using System;

class BiggerOfTwoMethod
{
    static void Main()
    {
        int intA, intB, intC, result;
        Console.WriteLine("Enter 3 integers:");
        intA = int.Parse(Console.ReadLine());
        intB = int.Parse(Console.ReadLine());
        intC = int.Parse(Console.ReadLine());

        result = GetMax(intA, intB);
        result = GetMax(result, intC);

        Console.WriteLine(result);
    }

    static int GetMax(int a, int b)
    {
        int biggerInt = a;
        if (a < b)
        {
            biggerInt = b; 
        }
        return biggerInt;
    }
}