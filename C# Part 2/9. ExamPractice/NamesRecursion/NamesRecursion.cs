using System;

class Program
{
    static string[] names = { "Niki", "Viki", "Nora", "Lora", "Dora", "Pesho", "Misho", "Techo" };
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        CombinateNames(n -1, numbers, 0);
    }
    
    static void CombinateNames(int index, int[] numbers, int start)
    {
        if (index == -1)
        {
            PrintNames(numbers);
        }
        else
        {
            for (int i = start; i <= names.Length - 1; i++)
            {
                numbers[index] = i;
                CombinateNames(index - 1, numbers, i + 1);
            }
        }
    }

    private static void PrintNames(int[] numbers)
    {
        foreach (var num in numbers)
        {
            Console.Write("{0:10}",names[num],num);
        }
        Console.WriteLine();
    }
}