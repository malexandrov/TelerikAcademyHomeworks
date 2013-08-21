namespace GeneratingOrderedSubsets
{
    using System;

    class GeneratingOrderedSubsets
    {
        private static string[] wordsArray = new string[] { "hi", "a", "b" }; 

        static void Main()
        {
            int n = 3;
            int k = 2;
            int[] indices = new int[k];

            GenerateCombinations(indices, 0, k, n);
        }

        private static void GenerateCombinations(int[] indicesArray, int index, int k, int n)
        {
            if (index >= k)
            {
                PrintSubsets(indicesArray, wordsArray);
                return;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    indicesArray[index] = i;
                    GenerateCombinations(indicesArray, index + 1, k, n);
                }
            }
        }

        private static void PrintSubsets(int[] array, string[] wordsArray)
        {
            Console.Write("( ");
            for (int i = 0; i < array.Length; i++)
            {
                int arrayIndex = array[i];
                Console.Write(wordsArray[arrayIndex] + " ");
            }
            Console.WriteLine(")");
        }
    }
}
