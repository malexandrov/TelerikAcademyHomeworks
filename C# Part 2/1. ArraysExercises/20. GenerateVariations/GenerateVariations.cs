using System;

class GenerateVariations
{

    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        int[] varArray = new int[K];
        Variations(varArray, 0, N);
    }

    static void Variations(int[] array, int index, int N)
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
            for (int i = 1; i <= N; i++)
            {
                array[index] = i;
                Variations(array, index + 1, N);
            }
        }
    }
}