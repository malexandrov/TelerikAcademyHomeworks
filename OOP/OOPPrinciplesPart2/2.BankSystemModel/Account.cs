using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.BankSystemModel
{
    public abstract class Account
    {
        protected decimal balance;
        protected Customer customer;
        protected decimal interestRate;

 
        public Customer Customer
        {
            get { return this.customer; }
        }

        public decimal Balance
        {
            get { return this.balance; }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The interestRate must be positive number!");
                }
                this.interestRate = value;
            }
        }
        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
        }

        public abstract decimal CalculateInterest(int months);

    }
}
