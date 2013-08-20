namespace PrintStatistics_Exercise2
{
    using System;

    class PrintStatistics
    {
        // Exercise 2: Refactor the following code to apply variable usage and naming best practices:
        public void PrintStatistics(double[] arrayOfValues, int count)
        {
            double maxValue = double.MinValue;
            double minValue = double.MaxValue;
            double averageValue = 0;
            for (int i = 0; i < count; i++)
            {
                //Finding the sum of element in the array
                averageValue += arrayOfValues[i];
                //Finding the maximal element in the array
                if (arrayOfValues[i] > maxValue)
                {
                    maxValue = arrayOfValues[i];
                }
                //Finding the minimal element in the array
                if (arrayOfValues[i] < minValue)
                {
                    minValue = arrayOfValues[i];
                }
            }

            PrintMax(maxValue);
            PrintMin(minValue);
            PrintAverage(averageValue/count);
        }

        static void Main()
        {
        }
    }
}
