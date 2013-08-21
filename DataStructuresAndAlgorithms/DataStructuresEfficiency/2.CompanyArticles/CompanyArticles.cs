namespace CompanyArticles
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Wintellect.PowerCollections;

    class CompanyArticles
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            OrderedMultiDictionary<double, Article> articles = ReadArticles("..\\..\\articles.txt");
            double priceFrom = 1.2;
            double priceTo = 2.5;
            GetArticlesInRange(articles, priceFrom, priceTo);
        }

        private static void GetArticlesInRange(OrderedMultiDictionary<double, Article> articles, double priceFrom, double priceTo)
        {
            var articlesRange = articles.Range(priceFrom, true, priceTo, true);
           
            foreach (var article in articlesRange)
            {
                foreach (var item in article.Value)
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static OrderedMultiDictionary<double, Article>  ReadArticles(string path)
        {
            OrderedMultiDictionary<double, Article> articles = new OrderedMultiDictionary<double, Article>(true);

            StreamReader reader = new StreamReader(path);
            using (reader)
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    string[] tokens = line.Split(';');
                    string title = tokens[0].Trim();
                    double price = double.Parse(tokens[1].Trim());
                    string vendor = tokens[2].Trim();
                    string barcode = tokens[3].Trim();

                    Article newArticle = new Article(title, price, vendor, barcode);
                    articles.Add(price, newArticle);
                }
            }
            return articles;
        }
    }
}
