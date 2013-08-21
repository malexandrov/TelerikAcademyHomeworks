namespace PermutationsWithRepetition
{
    using System;

    class PermutationsWithRepetition
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 5, 5 };
            //static int[] numbers = { 1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };

            Array.Sort(numbers);
            Permute(numbers, 0, numbers.Length);
        }

        static void Permute(int[] array, int start, int end)
        {
            PrintNumbers(array);

            if (start < end)
            {
                for (int i = end - 2; i >= start; i--)
                {
                    for (int j = i + 1; j < end; j++)
                    {
                        if (array[i] != array[j])
                        {
                            Swap(array, i, j);
                            Permute(array, i + 1, end);
                        }
                    }

                    // Reverse modifications done with recursive calls
                    int swapValue = array[i];
                    for (int k = i; k < end - 1; k++)
                    {
                        Swap(array, k, k + 1);
                    }
                    array[end - 1] = swapValue;
                }
            }
        }

        private static void Swap(int[] array, int k, int i)
        {
            int temp = array[i];
            array[i] = array[k];
            array[k] = temp;
        }

        private static void PrintNumbers(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
    }
}