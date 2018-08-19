//========================================================================
// This conversion was produced by the Free Edition of
// Java to C# Converter courtesy of Tangible Software Solutions.
// Order the Premium Edition at https://www.tangiblesoftwaresolutions.com
//========================================================================

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
namespace bankingapp
{

	/// 
	/// <summary>
	/// @author Patsf
	/// </summary>
	public class Account
	{
		private string name;
		private string address;
		private string phone;
		private string accountNumber;
		private double balance;
		private double interestRate;
		private double interest;

		public Account(string name, string address, string phone, string accountNumber, double balance, double interestRate)
		{
			this.name = name;
			this.address = address;
			this.phone = phone;
			this.accountNumber = accountNumber;
			this.balance = balance;
			this.interestRate = interestRate;
		}

		public virtual string Name
		{
			get
			{
				return name;
			}
			set
			{
				this.name = value;
			}
		}


		public virtual string Address
		{
			get
			{
				return address;
			}
			set
			{
				this.address = value;
			}
		}


		public virtual string Phone
		{
			get
			{
				return phone;
			}
			set
			{
				this.phone = value;
			}
		}


		public virtual double Balance
		{
			get
			{
				return balance;
			}
			set
			{
				this.balance = value;
			}
		}


		public virtual string AccountNumber
		{
			get
			{
				return accountNumber;
			}
			set
			{
				this.accountNumber = value;
			}
		}


		public virtual double InterestRate
		{
			set
			{
				this.interestRate = value;
			}
			get
			{
				return interestRate;
			}
		}


		public virtual double Interest
		{
			set
			{
				this.interest = value;
			}
			get
			{
				return interest;
			}
		}


		public virtual void withdraw(double amount)
		{
			balance = balance - amount;
		}

		public virtual void deposit(double amount)
		{
			balance = balance + amount;
		}
	}

}