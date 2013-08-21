namespace ProductCollection
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Threading;
    using Wintellect.PowerCollections;
    using System.Diagnostics;

    class ProductCollection
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string path = "..\\..\\Products.txt";
            OrderedBag<Product> productsCollection = new OrderedBag<Product>();
            Stopwatch sw = new Stopwatch();
            double minPrice = 10;
            double maxPrice = 10000;

            Console.WriteLine("Reading products file...");
            productsCollection = ReadProductsFile(path);
            Console.WriteLine();

            Console.WriteLine("Searching 10000 times for products...");
           
            sw.Start();
            for (int i = 0; i < 10000; i++)
            {
                SearchProducts(productsCollection, minPrice+i, maxPrice+i);
            }
            sw.Stop();

            Console.Write("Done in:");
            Console.WriteLine(sw.Elapsed);
        }

        private static void SearchProducts(OrderedBag<Product> products, double minPrice, double maxPrice, int count = 20)
        {

            var productsRange = products.Range(new Product("minPrice", minPrice), false, new Product("maxPrice", maxPrice), false);
            
            // This is for printing the products to the console - slow for 10 000 searches
            //if (count > productsRange.Count)
            //{
            //    count = productsRange.Count;
            //    Console.WriteLine("There are only {0} products in this range.", count);
            //}

            //Console.WriteLine("First {0} products from {1} to {2} price:", count, minPrice, maxPrice);
            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine("{0}. {1} - Price: {2}", i+1, productsRange[i].Name, productsRange[i].Price);
            //}
        }

        private static OrderedBag<Product> ReadProductsFile(string path)
        {
            StreamReader reader = new StreamReader(path);
            OrderedBag<Product> productsCollection = new OrderedBag<Product>();

            using (reader)
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    string[] entry = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    string productName = entry[0].Trim(); ;
                    double productPrice = double.Parse(entry[1].Trim());
                    Product newProduct = new Product(productName, productPrice);
                    productsCollection.Add(newProduct);
                }
            }

            return productsCollection;
        }
    }
}
