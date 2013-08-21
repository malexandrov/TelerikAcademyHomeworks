namespace CompanyArticles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Article: IComparable<Article>
    {
        private string Title;
        private double Price;
        private string Vendor;
        private string Barcode;

        public Article(string title,double price, string vendor, string barcode)
        {
            this.Title = title;
            this.Price = price;
            this.Vendor = vendor;
            this.Barcode = barcode;
        }

        public int CompareTo(Article other)
        {
            return this.Title.CompareTo(other.Title);
        }

        public override string ToString()
        {
            string result = this.Price + " lv. " + this.Title + " from " + this.Vendor + " (" + this.Barcode + ")";
            return result;
        }
    }
}
