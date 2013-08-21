namespace Knapsack
{
    using System;
    using System.Collections.Generic;

    public class Item
    {
        public string Name { get; set; }
        public int Weigth { get; set; }
        public int Value { get; set; }

        public Item(string name, int weigth, int value)
        {
            this.Name = name;
            this.Weigth = weigth;
            this.Value = value;
        }

        public override string ToString()
        {
            return this.Name + " -> w: " + this.Weigth + ", v: " + this.Value;
        }
    }

    class KnapsackProblem
    {
        static void Main()
        {
            Item[] myItems = new Item[]{
                                        new Item("beer", 3, 2),
                                        new Item("vodka", 8, 12),
                                        new Item("cheese", 4, 5),
                                        new Item("nuts", 1, 4),
                                        new Item("ham", 2, 3),
                                        new Item("wiskey", 8, 13)
            };
            int myBagCapacity = 10;

            List<Item> result = FindOptimalSolution(myItems, myBagCapacity);
            Console.WriteLine("Best choice: ");
            Console.WriteLine(String.Join("\n", result));
        }

        public static List<Item> FindOptimalSolution(Item[] items, int capacity)
        {

            int[,] valuesArray = new int[items.Length + 1, capacity + 1]; 
            int[,] keepArray = new int[items.Length + 1, capacity + 1]; 

            for (int i = 1, itemsLen = items.Length + 1; i < itemsLen; i++) 
            {
                for (int k = 1; k < capacity + 1; k++) 
                {
                    if (items[i - 1].Weigth <= k) 
                    {
                        int remainingSpace = (k) - items[i - 1].Weigth; 

                        if (remainingSpace > 0)
                        {
                            int valueAbove = valuesArray[i - 1, k]; 
                            int sumValue = items[i - 1].Value + valuesArray[i - 1, remainingSpace - 1]; 

                            if (valueAbove > sumValue) 
                            {
                                valuesArray[i, k] = valueAbove;
                                keepArray[i, k] = 0;
                            }
                            else
                            {
                                valuesArray[i, k] = sumValue;
                                keepArray[i, k] = 1;
                            }
                        }
                        else 
                        {
                            valuesArray[i, k] = items[i - 1].Value;
                            keepArray[i, k] = 1;
                        }
                    }
                }
            }

            List<Item> bestChoice = new List<Item>();

            int remainSpace = capacity;
            int item = items.Length;

            while (item >= 0)
            {
                int toBeAdded = keepArray[item, remainSpace - 1];

                if (toBeAdded == 1)
                {
                    bestChoice.Add(items[item - 1]);
                    remainSpace -= items[item - 1].Weigth;
                }

                item--;
            }

            return bestChoice;
        }
    }
}