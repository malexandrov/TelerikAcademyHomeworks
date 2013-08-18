using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.InvalidRangeExceptionExercise
{
    class TestProgram
    {
        static void PrintNumber()
        {

            int min = 0;
            int max = 100;

            Console.WriteLine("Enter number in range {0}:{1}", min, max);
            int number = int.Parse(Console.ReadLine());

            if (number < min || number > max)
            {
                throw new InvalidRangeException<int>("Number not in range:", min, max);
            }

            else
            {
                Console.WriteLine("The number {0} is valid!", number);
            }
        }

        static void PrintDate()
        {
            DateTime min = new DateTime(1980, 1, 1);
            DateTime max = new DateTime(2013, 12, 31);

            Console.WriteLine("Enter date in range {0} - {1}", min, max);
            DateTime date = DateTime.Parse(Console.ReadLine());

            if (date < min || date > max)
            {
                throw new InvalidRangeException<DateTime>("Number not in range:", min, max);
            }
            else
            {
                Console.WriteLine("The date {0} is valid!", date);
            }
        }

        static void Main()
        {
            try
            {
                PrintNumber();
                PrintDate();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!" + ex.Message);
            }
        }
    }
}
