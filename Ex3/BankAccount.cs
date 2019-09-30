﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public class BankAccount
    {

        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string accountNumber, string accountHolder, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public void Desposit(decimal amount)
        {
            Balance += amount;
        }

        public void WithDraw(decimal amount)
        {
            if (Balance >= amount)
                Balance -= amount;
        }

        public string GetYourAccountDetails()
        {
            return
                $"Account Number: {AccountNumber}" +
                $"\nAccount Holder: {AccountHolder}" +
                $"\nAccount Balance: {Balance:C}";
        }
    }
}
