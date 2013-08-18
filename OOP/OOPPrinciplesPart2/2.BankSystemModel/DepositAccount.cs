using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.BankSystemModel
{
    public class DepositAccount : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
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

        public void WithdrawMoney(decimal ammount)
        {
            if (this.balance > ammount)
            {
                throw new ArgumentOutOfRangeException("Cannot withdraw more than current balance.");
            }
            else
            {
                this.balance -= ammount;
            }
        }

        public override decimal CalculateInterest(int months)
        {
            decimal interestAmount = 0;

            if (this.balance < 0 || this.balance > 1000)
            {
                return interestAmount;
            }
            else { return (this.interestRate * this.balance) * months; }
        }

    }
}
