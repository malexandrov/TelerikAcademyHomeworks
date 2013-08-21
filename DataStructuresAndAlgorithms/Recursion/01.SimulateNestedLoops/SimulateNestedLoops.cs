namespace SimulateNestedLoops
{
    using System;

    class SimulateNNestedLoops
    {
        private static int n = 3;
        private static int[] loops = new int[n];

        static void Main(string[] args)
        {

            SimulateNestedLoops(n, 0);
        }

        private static void SimulateNestedLoops(int n, int index)
        {
            if (index >= n)
            {
                Console.WriteLine(string.Join(" ", loops));
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                loops[index] = i;
                SimulateNestedLoops(n, index + 1);
            }

        }
    }
}
