using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.CreateAccount
{
    public enum AccountType { Checking, Deposit }
    class CreateAccount
    {
        static BankAccount NewBankAccount()
        {
            BankAccount created = new BankAccount();
            //created.accType = AccountType.Checking;
            //created.accBal = (decimal)3200.00;
            Console.Write("Enter balance: ");
            decimal balance = decimal.Parse(Console.ReadLine());
            Console.Write("Enter account number: ");
            long number = long.Parse(Console.ReadLine());
            //created.accNo = number; // Error here
            created.Populate(number, balance);

            return created;
        }

        static void Write(BankAccount toWrite)
        {
            Console.WriteLine("Account number is {0}", toWrite.Number());
            Console.WriteLine("Account balance is {0}", toWrite.Balance());
            Console.WriteLine("Account type is {0}", toWrite.Type());
        }

        static void Main()
        {
            BankAccount bankAccount1 = NewBankAccount();
            Write(bankAccount1);
        }
    }
    class BankAccount
    {
        public void Populate(long number, decimal balance)
        {
            accNo = number;
            accBal = balance;
            accType = AccountType.Checking;
        }

        public long Number()
        {
            return accNo;
        }

        public decimal Balance()
        {
            return accBal;
        }

        public string Type()
        {
            return accType.ToString();
        }


        private long accNo;
        private decimal accBal;
        private AccountType accType;
    }

}
