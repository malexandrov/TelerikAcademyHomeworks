using System;

class GenerateCombinations
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        int[] array = new int[K];

        Combinate(array, 0, 1, N);
    }

    static void Combinate(int[] array, int index, int currentNumber, int N)
    {
        if (index == array.Length)
        {
            Console.Write("{ ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.Write("}");
            Console.WriteLine();
        }

        else
        {
            for (int i = currentNumber; i <= N; i++)
            {
                array[index] = i;
                Combinate(array, index + 1, i + 1, N);
            }
        }
    }
}