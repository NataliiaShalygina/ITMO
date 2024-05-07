using System;
using System.IO;

namespace Exercise01
{
    public class BankTransaction
    {
        private readonly decimal amount;
        private readonly DateTime when;

        public BankTransaction(decimal tranAmount)
        {
            amount = tranAmount;
            when = DateTime.Now;
        }

        public decimal Amount()
        {
            return amount;
        }

        public DateTime When()
        {
            return when;
        }
    }
}
