using System;


class Slices
{
    static void Main()
    {
        string sizeStr = Console.ReadLine();
        string[] sizeArray = sizeStr.Split(' ');
        int width = int.Parse(sizeArray[0]);
        int height = int.Parse(sizeArray[1]);
        int depth = int.Parse(sizeArray[2]);

        int[, ,] cube = new int[width, height, depth];
        for (int h = 0; h < height; h++)
        {
            string oneLine = Console.ReadLine();
            string[] seq = oneLine.Split('|');
            for (int d = 0; d < depth; d++)
            {
                string[] num = seq[d].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int w = 0; w < width; w++)
                {
                    int value = int.Parse(num[w]);
                    cube[w, h, d] = value;
                }
            }
        }

        long cubeSum = 0;
        long currentSum = 0;
        for (int w = 0; w < width; w++)
        {
            for (int h = 0; h < height; h++)
            {
                for (int d = 0; d < depth; d++)
                {
                    cubeSum += cube[w, h, d];
                }
            }
        }

        int counter = 0;
        for (int w = 0; w < width-1; w++)
        {
            for (int h = 0; h < height; h++)
            {
                for (int d = 0; d < depth; d++)
                {
                    currentSum += cube[w, h, d];
                }
            }
            if (currentSum == cubeSum/2)
            {
                counter++;
            }
        }

        currentSum = 0;
        for (int h = 0; h < height-1; h++) 
        {
            for (int w = 0; w < width; w++)
            {
                for (int d = 0; d < depth; d++)
                {
                    currentSum += cube[w, h, d];
                }
            }
            if (currentSum == cubeSum / 2)
            {
                counter++;
            }
        }

        currentSum = 0;
        for (int d = 0; d < depth-1; d++) 
        {
            for (int h = 0; h < height; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    currentSum += cube[w, h, d];
                }
            }
            if (currentSum == cubeSum / 2)
            {
                counter++;
            }
        }

        Console.WriteLine(counter);
    }
}
