using System;

class Program
{

    static void Main()
    {
        Console.WriteLine("1.Reverse digits of number  2.Calculate average   3.Solve equation a*x+b");

        int menuItem = int.Parse(Console.ReadLine());

        if (menuItem == 1) ReverseDigits();
        else if (menuItem == 2) CalculateAverage();
        else if (menuItem == 3) SolveLinearEquation();
    }

    static void ReverseDigits()
    {
        Console.WriteLine("Enter number to reverse: ");
        int numberToReverse = int.Parse(Console.ReadLine());

        if (numberToReverse >= 0)
        {
            do
            {
                Console.Write(numberToReverse % 10);
                numberToReverse = numberToReverse / 10;
            }
            while (numberToReverse != 0);
            Console.WriteLine();
        }
        else Console.WriteLine("Number can't be negative.");
    }

    static void CalculateAverage()
    {
        Console.WriteLine("Enter array size:");
        int[] array = new int[int.Parse(Console.ReadLine())];

        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        if (array.Length > 0)
        {
            int sum = 0;
            Console.WriteLine("Average: ");
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum / array.Length);
        }
        else Console.WriteLine("Sequence should not be empty!!");
    }

    static void SolveLinearEquation()
    {
        Console.WriteLine("Enter a and b:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if (a != 0)
        {
            Console.WriteLine("Result: " + (double)-b / a);
        }
        else Console.WriteLine("a should not be equal to 0.");
    }
}