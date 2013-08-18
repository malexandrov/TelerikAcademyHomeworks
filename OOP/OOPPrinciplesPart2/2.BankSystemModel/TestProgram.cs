using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankSystemModel
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Customer.Company = new Customer();
            Account NikiCoCompany = new LoanAccount(Customer.Company, 120.500m, 0.05m);
            Account someCompany = new MortgageAccount(Customer.Company, 55.500m, 0.07m);
            Account Pesho = new DepositAccount(Customer.Individual, 1000m, 0.06m);

            Bank.Add(NikiCoCompany);
            Bank.Add(someCompany);
            Bank.Add(Pesho);

            Console.WriteLine("Calculated interest for 2 months:");
            foreach (var customer in Bank.AllAccounts)
            {
                Console.WriteLine(customer.CalculateInterest(2));
            }
            Console.WriteLine("Calculated interest for 3 months:");
            foreach (var customer in Bank.AllAccounts)
            {
                Console.WriteLine(customer.CalculateInterest(3));
            }
            Console.WriteLine("Calculated interest for 7 months:");
            foreach (var customer in Bank.AllAccounts)
            {
                Console.WriteLine(customer.CalculateInterest(7));
            }
            Console.WriteLine("Calculated interest for 13 months:");
            foreach (var customer in Bank.AllAccounts)
            {
                Console.WriteLine(customer.CalculateInterest(13));
            }
        }
    }
}
