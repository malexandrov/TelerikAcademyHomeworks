using System;

class PrintNumberMatrix
{
    static void Main()
    {
        int n;
        string consoleInput;
      
        do
        {
            Console.Write("Please enter N < 20: ");
        }
        while (!int.TryParse(consoleInput = Console.ReadLine(), out n) || n < 0 || n > 20);

        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write(i+j + " ");
            }
            Console.WriteLine();
        }
    }
}
