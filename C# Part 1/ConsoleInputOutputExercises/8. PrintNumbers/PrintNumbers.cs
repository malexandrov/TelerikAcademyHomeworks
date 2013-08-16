using System;

class PrintNumbers
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

