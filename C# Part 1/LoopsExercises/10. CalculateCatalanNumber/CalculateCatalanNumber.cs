using System;

class CalculateCatalanNumber
{
    static void Main()
    {
        int n;
        string consoleInput;
        double nFact = 1;
        double nFactPlus = 1;
        double nFactDouble = 1;

        do
        {
            Console.Write("Please enter N >= 0: ");
        }
        while (!int.TryParse(consoleInput = Console.ReadLine(), out n) || n < 0);
        
        double n1 = n + 1;
        double n2 = n * 2;

        for (int i = 1; i <= n; i++)
        {
            nFact *= i;
        }
        for (int i = 1; i <= n1; i++)
        {
            nFactPlus *= i;
        }
        for (int i = 1; i <= n2; i++)
        {
            nFactDouble *= i;
        }
        
        double sum = nFactDouble / (nFactPlus*nFact);
        Console.WriteLine(sum);
    }
}
