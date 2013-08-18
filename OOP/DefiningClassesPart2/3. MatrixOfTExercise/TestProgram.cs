using System;

namespace _3.MatrixOfTExercise
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            int[,] testMatrix1 = new int[2, 3] {{1,2,3},
                                                {4,5,6}};

            int[,] testMatrix2 = new int[3, 2] {{7 , 8},
                                                {9, 10}, 
                                                {11,12} };

            Matrix<int> genericM1 = new Matrix<int>(2, 3, testMatrix1);
            Matrix<int> genericM2 = new Matrix<int>(3, 2, testMatrix2);

            Console.WriteLine(genericM1 * genericM2);
        }
    }
}
