using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.IEnumerableExtensions
{
    static class Extensions
    {
        // Extension for sum
        public static T Sum<T>(this IEnumerable<T> list) where T : IComparable
        {
            dynamic result = 0;
            foreach (var item in list)
            {
                result += item;
            }
            return result;
        }

        // Extension for product
        public static T Product<T>(this IEnumerable<T> list) where T: IComparable
        {
            dynamic product = 1;
            foreach (var item in list)
            {
                product *= item;
            }
            return product;
        }

        // Extension for min
        public static T Min<T>(this IEnumerable<T> list) where T : IComparable
        {
            dynamic minimalElement = int.MaxValue;
            foreach (var item in list)
            {
                if (item.CompareTo(minimalElement) < 0)
                {
                    minimalElement = item;
                }
            }
            return minimalElement;
        }

        // Extension for max
        public static T Max<T>(this IEnumerable<T> list) where T : IComparable
        {
            dynamic maxElement = int.MinValue;
            foreach (var item in list)
            {
                if (item.CompareTo(maxElement) > 0)
                {
                    maxElement = item;
                }
            }
            return maxElement;
        }

        // Extension for average
        public static double Average<T>(this IEnumerable<T> list) where T: IComparable
        {
            return Convert.ToDouble(list.Sum<T>()) / list.Count<T>();
        }
    }
}
