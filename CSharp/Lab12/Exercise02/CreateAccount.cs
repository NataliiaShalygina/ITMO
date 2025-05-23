﻿using System;
using System.Collections;
using Exercise02.Banking;

namespace Exercise02
{
    class CreateAccount
    {
        static void Main()
        {

            // Create two bank accounts. Use Bank.CreateAccount(...) with the same balance and type
            // Store the numbers of these two accounts in long variables accNo1 and accNo2
            long accNo1 = Bank.CreateAccount(AccountType.Checking, 100);
            long accNo2 = Bank.CreateAccount(AccountType.Checking, 100);

            // Create two BankAccount variables, acc1 and acc2. 
            // Use Bank.GetAccount() to populate them with the two accounts just created
            BankAccount acc1 = Bank.GetAccount(accNo1);
            BankAccount acc2 = Bank.GetAccount(accNo2);

            // ADD CODE HERE TO DEPOSIT AND WITHDRAW MONEY FROM acc1 AND acc2
            acc1.Deposit(900);
            acc2.Deposit(900);
            acc1.Withdraw(500);
            acc2.Withdraw(500);

            // PRINT THE TRANSACTION HISTORY FOR EACH ACCOUNT - USE THE Write METHOD (BELOW)
            Write(acc1);
            Write(acc2);

            // Print the accounts, using ToString
            Console.WriteLine("acc1 - {0}", acc1);
            Console.WriteLine("acc2 - {0}", acc2);
            Console.ReadLine();
        }

        static void Write(BankAccount acc)
        {
            Console.WriteLine("Account number is {0}", acc.Number);
            Console.WriteLine("Account balance is {0}", acc.Balance());
            Console.WriteLine("Account type is {0}", acc.Type);

            // Print out the transactions (if any)
            Console.WriteLine("Transactions");
            Queue tranQueue = acc.Transactions();
            foreach (BankTransaction tran in tranQueue)
            {
                Console.WriteLine("Date: {0}\tAmount: {1}", tran.When, tran.Amount);
            }
        }
    }
}
