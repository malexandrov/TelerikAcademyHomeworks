using System;


class NestedLoops
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[] vector = new char[n];
        Recursion(n - 1, vector, '1');
    }

    static void Recursion(int n, char[] vector, char start)
    {
        if (n == -1)
        {
            Print(vector);
        }
        else
        {
            for (char i = start; i <= '5'; i++)
            {
                vector[n] = i;
                Recursion(n - 1, vector, (char)(i+1));
            }
        }
    }

    private static void Print(char[] vector)
    {
        foreach (var i in vector)
        {
            Console.Write("{0}",i);
        }
        Console.WriteLine();
    }
}