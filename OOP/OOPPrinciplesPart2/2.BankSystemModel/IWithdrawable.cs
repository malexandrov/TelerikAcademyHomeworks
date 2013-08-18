using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.BankSystemModel
{
    public interface IWithdrawable
    {
        void WithdrawMoney(decimal ammount);
    }
}
