using System;

class PrintGreaterNumber
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int result = Math.Max(a, b);
        Console.WriteLine("The greater number is: " + result);
        //  Console.WriteLine(result = a > b ? a : b);
    }
}
