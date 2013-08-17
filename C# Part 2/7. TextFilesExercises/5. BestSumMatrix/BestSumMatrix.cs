using System;
using System.IO;
using System.Text;

class BestSumMatrix
{
    static void Main()
    {
        using (StreamReader input = new StreamReader("../../matrix.txt"))
        {
            int n = int.Parse(input.ReadLine());
            int[,] matrix = new int[n, n];
            int maxSum = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                string[] numbers = input.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matrix[i,j] = int.Parse(numbers[j]);
                }
            }

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if ((matrix[i, j] + matrix[i + 1, j]+ matrix[i, j + 1] + matrix[i + 1, j + 1]) > maxSum)
                    {
                        maxSum = (matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1]);
                    }
                }
            }
            using (StreamWriter output = new StreamWriter("../../output.txt"))
            {
                output.WriteLine(maxSum);
            }
        }

    }
}