using System;

class MinMaxIntNumbers
{
    static void Main()
    {
        Console.Write("Please enter number N:");
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());    // Capture first number
        int max = min;

        for (int i = 1; i < n; i++)
        {
            int temp = int.Parse(Console.ReadLine());

            if (temp > max)
            {
                max = temp;
            }
            if (temp < min)
            {
                min = temp;
            }
        }
        Console.WriteLine("max {0}, min {1}", max, min);
    }
}