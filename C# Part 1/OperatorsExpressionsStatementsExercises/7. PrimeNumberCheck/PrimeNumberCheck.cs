using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter number to be checked: ");
        int number = Convert.ToInt32(Console.ReadLine());
        bool result = true;
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                result = false;
            }
        }
        Console.WriteLine(result);
    }
}
