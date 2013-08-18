using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.BankSystemModel
{
    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public void DepositMoney(decimal ammount)
        {
            if (ammount < 0)
            {
                throw new ArgumentOutOfRangeException("Deposit ammount can't be negative number.");
            }
            else
            {
                this.balance += ammount;
            }
        }

        public override decimal CalculateInterest(int months)
        {
            decimal interestAmount = (this.interestRate * this.balance) * months;

            if (this.customer.Equals(Customer.Company) && months <= 12)
            {
                return interestAmount / 2;
            }

            else if (this.customer.Equals(Customer.Individual) && months <= 6)
            {
                return 0;
            }

            else { return interestAmount; }
        }
    }
}
