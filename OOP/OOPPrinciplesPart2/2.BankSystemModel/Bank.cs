using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankSystemModel
{
    static class Bank
    {
        private static List<Account> allAccounts;

        public static List<Account> AllAccounts
        {
            get { return allAccounts; }
        }

        static Bank()
        {
            allAccounts = new List<Account>();
        }
        public static void Add(Account account)
        {
            Bank.allAccounts.Add(account);
        }

    }
}
