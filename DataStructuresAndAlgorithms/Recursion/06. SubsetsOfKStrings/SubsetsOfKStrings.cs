namespace SubsetsOfKStrings
{
    using System;

    class SubsetsOfKStrings
    {
        private static string[] wordsArray = new string[] {"paper", "scissors", "rock", "lizard", "Spok" };

        static void Main()
        {
            int k = 3;
            int[] indices = new int[k];
            int n = wordsArray.Length;
   
            GenerateSubsets(indices, 0, 0, n);
        }

        private static void GenerateSubsets(int[] indicesArray, int index, int startNum, int n)
        {
            if (index >= indicesArray.Length)
            {
                PrintSubsets(indicesArray, wordsArray);
                return;
            }
            else
            {
                for (int i = startNum; i <= n-1; i++)
                {
                    indicesArray[index] = i;
                    GenerateSubsets(indicesArray, index + 1, i + 1, n);
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
