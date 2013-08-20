using System;

namespace Task3{

    class WalkInMatrica {

        static void ChangeDirection(ref int dx, ref int dy) 
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
        	int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int cd = 0;

            for(int i = 0; i < 8; i++)
            {
                if (dirX[i] == dx && dirY[i] == dy)
                {
                    cd = i; break;
                }
            }
            if(cd == 7) 
            { 
                dx = dirX[0]; 
                dy = dirY[0]; 
                return; 
            }

            dx = dirX[cd + 1];
            dy = dirY[cd + 1];
        }

        static bool CheckDirection(int[,] arr, int x, int y)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for(int i = 0; i < 8; i++)
            {
                if (x + dirX[i] >= arr.GetLength(0) || x + dirX[i] < 0)
                {
                    dirX[i] = 0;
                }
                if (y + dirY[i] >= arr.GetLength(0) || y + dirY[i] < 0)
                {
                    dirY[i] = 0;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                if (arr[x + dirX[i], y + dirY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        static void GetFirstEmptyCell(int[,] arr, out int x, out int y)
        {
            x = 0;
            y = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i, j] == 0) 
                    { 
                        x = i; 
                        y = j; 
                        return; 
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number ");
            int n;
            bool isInputParsed = int.TryParse(Console.ReadLine(), out n);
            while (!isInputParsed)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                isInputParsed = int.TryParse(Console.ReadLine(), out n);
            }

            GenerateWalkInMatrix(n);
        }

        private static void GenerateWalkInMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            int step = n;
            int stepNumber = 1;
            int col = 0;
            int row = 0;
            int dx = 1;
            int dy = 1;

            while (true)
            { //malko e kofti tova uslovie, no break-a raboti 100% : )
                matrix[col, row] = stepNumber;

                if (!CheckDirection(matrix, col, row))
                {
                    break;
                } // prekusvame ako sme se zadunili

                if (col + dx >= n || col + dx < 0 || row + dy >= n || row + dy < 0 || matrix[col + dx, row + dy] != 0)
                {
                    while ((col + dx >= n || col + dx < 0 || row + dy >= n || row + dy < 0 || matrix[col + dx, row + dy] != 0))
                    {
                        ChangeDirection(ref dx, ref dy);
                    }
                }
                col += dx;
                row += dy;
                stepNumber++;
            }

            GetFirstEmptyCell(matrix, out col, out row);
            stepNumber++;
            if (col != 0 && row != 0)
            { // taka go napravih, zashtoto funkciqta ne mi davashe da ne si definiram out parametrite
                dx = 1;
                dy = 1;
                while (true)
                { //malko e kofti tova uslovie, no break-a raboti 100% : )
                    matrix[col, row] = stepNumber;
                    if (!CheckDirection(matrix, col, row))
                    {
                        break;
                    }// prekusvame ako sme se zadunili
                    if (col + dx >= n || col + dx < 0 || row + dy >= n || row + dy < 0 || matrix[col + dx, row + dy] != 0)
                    {
                        while ((col + dx >= n || col + dx < 0 || row + dy >= n || row + dy < 0 || matrix[col + dx, row + dy] != 0))
                        {
                            ChangeDirection(ref dx, ref dy);
                        }
                    }
                    col += dx;
                    row += dy;
                    stepNumber++;
                }
            }
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
