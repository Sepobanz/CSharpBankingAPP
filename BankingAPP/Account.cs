using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAPP
{
    public class Account
    {
        private string name;
        private string address;
        private string phone;
        private string accountNumber;
        private double balance;
        private double interestRate;
        private double interest;

        public Account(string name, string address, string phone,
                string accountNumber, double balance, double interestRate)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.interestRate = interestRate;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetAddress()
        {
            return address;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }

        public string GetPhone()
        {
            return phone;
        }

        public void SetPhone(string phone)
        {
            this.phone = phone;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void SetBalance(double balance)
        {
            this.balance = balance;
        }

        public string GetAccountNumber()
        {
            return accountNumber;
        }

        public void SetAccountNumber(string accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        public void SetInterestRate(double interestRate)
        {
            this.interestRate = interestRate;
        }

        public double GetInterestRate()
        {
            return interestRate;
        }

        public void SetInterest(double interest)
        {
            this.interest = interest;
        }

        public double GetInterest()
        {
            return interest;
        }

        public void Withdraw(double amount)
        {
            balance = balance - amount;
        }

        public void Deposit(double amount)
        {
            balance = balance + amount;
        }
    }
}
