//========================================================================
// This conversion was produced by the Free Edition of
// Java to C# Converter courtesy of Tangible Software Solutions.
// Order the Premium Edition at https://www.tangiblesoftwaresolutions.com
//========================================================================

using System;
using System.Collections.Generic;
using System.Windows.Forms;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
namespace bankingapp
{
	/// 
	/// <summary>
	/// @author sepobanz
	/// </summary>
	public class BankingApp : JFrame
	{
		//private variables here
		private JTextField nameField;
		private JTextField addressField;
		private JTextField phoneField;
		private JTextField accountNumField;
		private JTextField balanceField;
		private JTextField wDField;
		private JButton searchCustomerB;
		private JButton previousB;
		private JButton nextB;
		private JButton addB;
		private JButton updateB;
		private JButton openAcctB;
		private JButton depositB;
		private JButton withdrawB;
		private JButton calcInterestB;
		private JTextField interestField;
		private JTextField calcInterestField;
		private static int nextAccountNumber = 10001;
		private static DAO<Account> accountFile = new AccountTextFile();



		public BankingApp()
		{
			try
			{
				UIManager.LookAndFeel = UIManager.SystemLookAndFeelClassName;
			}
			catch (Exception e) when (e is ClassNotFoundException || e is InstantiationException || e is IllegalAccessException || e is UnsupportedLookAndFeelException)
			{
				Console.WriteLine(e);
			}
			initComponents();

		}

		private void initComponents()
		{
			Title = "Banking Application";
			LocationByPlatform = true;
			DefaultCloseOperation = WindowConstants.EXIT_ON_CLOSE;

			JPanel overallPanel = new JPanel();

			Dimension dim = new Dimension(130,20);
			Dimension dim2 = new Dimension(80,20);

			JPanel namesAndFields = new JPanel();
			JLabel nameLabel = new JLabel("Customer Name: ");
			nameField = new JTextField();
			nameField.PreferredSize = dim;
			JLabel addressLabel = new JLabel("Address: ");
			addressField = new JTextField();
			addressField.PreferredSize = dim;
			JLabel phoneLabel = new JLabel("Phone Number: ");
			phoneField = new JTextField();
			phoneField.PreferredSize = dim;
			JLabel accountNumLabel = new JLabel("Account Number: ");
			accountNumField = new JTextField();
			accountNumField.PreferredSize = dim;
			JLabel balanceLabel = new JLabel("Balance: ");
			balanceField = new JTextField();
			balanceField.PreferredSize = dim;
			balanceField.Editable = false;
			JLabel wDLabel = new JLabel("Withdrawal/Deposit: ");
			wDField = new JTextField();
			wDField.PreferredSize = dim;

			namesAndFields.Layout = new GridBagLayout();
			namesAndFields.add(nameLabel, getConstraints(0,0));
			namesAndFields.add(nameField, getConstraints(1,0));
			namesAndFields.add(addressLabel, getConstraints(0,1));
			namesAndFields.add(addressField, getConstraints(1,1));
			namesAndFields.add(phoneLabel, getConstraints(0,2));
			namesAndFields.add(phoneField, getConstraints(1,2));
			namesAndFields.add(accountNumLabel, getConstraints(0,3));
			namesAndFields.add(accountNumField, getConstraints(1,3));
			namesAndFields.add(balanceLabel, getConstraints(0,4));
			namesAndFields.add(balanceField, getConstraints(1,4));
			namesAndFields.add(wDLabel, getConstraints(0,5));
			namesAndFields.add(wDField, getConstraints(1,5));
			//---BUTTON PANELS------------------------------------
			JPanel buttonsP = new JPanel();

			searchCustomerB = new JButton("Search Customer");
			searchCustomerB.PreferredSize = dim;
			searchCustomerB.addActionListener(e => searchButtonClicked());
			previousB = new JButton("Previous Customer");
			previousB.PreferredSize = dim;
			previousB.addActionListener(e => previousClicked());
			nextB = new JButton("Next Customer");
			nextB.PreferredSize = dim;
			nextB.addActionListener(e => nextButtonClicked());
			addB = new JButton("Add Customer");
			addB.PreferredSize = dim;
			addB.addActionListener(e => addButtonClicked());
			updateB = new JButton("Update Customer");
			updateB.PreferredSize = dim;
			updateB.addActionListener(e => updateClicked());
			openAcctB = new JButton("Open Account");
			openAcctB.PreferredSize = dim;
			openAcctB.addActionListener(e => openAcctButtonClicked());

			buttonsP.Layout = new GridBagLayout();
			buttonsP.add(searchCustomerB, getConstraints(0,0));
			buttonsP.add(previousB, getConstraints(0,1));
			buttonsP.add(nextB, getConstraints(0,2));
			buttonsP.add(addB, getConstraints(0,3));
			buttonsP.add(updateB, getConstraints(0,4));
			buttonsP.add(openAcctB, getConstraints(0,5));

			JPanel buttonsP2 = new JPanel();
			depositB = new JButton("Deposit");
			depositB.PreferredSize = dim;
			depositB.addActionListener(e => depositButtonClicked());
			withdrawB = new JButton("Withdraw");
			withdrawB.PreferredSize = dim;
			withdrawB.addActionListener(e => withdrawButtonClicked());

			buttonsP2.Layout = new GridBagLayout();
			buttonsP2.add(depositB, getConstraints(0,0));
			buttonsP2.add(withdrawB, getConstraints(0,1));

			JPanel buttonsP3 = new JPanel();
			calcInterestB = new JButton("Calculate Interest");
			calcInterestB.PreferredSize = dim;
			calcInterestB.addActionListener(e => calculateInterestClicked());

			buttonsP3.Layout = new GridBagLayout();
			buttonsP3.add(calcInterestB, getConstraints(0,0));
			//---INTEREST PANEL-----------------------------------
			JPanel interest = new JPanel();
			JLabel interestMonthL = new JLabel("Interest Month: ");
			interestField = new JTextField();
			interestField.PreferredSize = dim2;
			JLabel calcInterestL = new JLabel("Calculated Interest: ");
			calcInterestField = new JTextField();
			calcInterestField.PreferredSize = dim2;
			calcInterestField.Editable = false;

			interest.Layout = new GridBagLayout();
			interest.add(interestMonthL, getConstraints(0,0));
			interest.add(interestField, getConstraints(1,0));
			interest.add(calcInterestL, getConstraints(0,1));
			interest.add(calcInterestField, getConstraints(1,1));

			//---MAIN PANEL---------------------------------------
			overallPanel.Layout = new GridBagLayout();
			overallPanel.add(namesAndFields, getConstraints(0,0));
			overallPanel.add(buttonsP, getConstraints(1,0));
			overallPanel.add(buttonsP2, getConstraints(1,1));
			overallPanel.add(buttonsP3, getConstraints(1,2));
			overallPanel.add(interest, getConstraints(0,1));
			add(overallPanel, BorderLayout.CENTER);
			Resizable = false;

			setSize(450,350);
		}

		private GridBagConstraints getConstraints(int x, int y)
		{
			GridBagConstraints c = new GridBagConstraints();
			c.anchor = GridBagConstraints.LINE_START;
			c.insets = new Insets(5, 5, 3, 5);
			c.gridx = x;
			c.gridy = y;
			return c;
		}

		public static void Main(string[] args)
		{
			// TODO code application logic here
				java.awt.EventQueue.invokeLater(() =>
			{
				BankingApp frame = new BankingApp();
				frame.Visible = true;
			});
		}

		private static long NewNumber
		{
			get
			{
				long newNumber = nextAccountNumber;
				nextAccountNumber++;
				return newNumber;
			}
		}

		private void previousClicked()
		{
			IList<Account> accounts = accountFile.All;
			Account a1 = null;
			int index;
			for (int i = 0; i < accounts.Count; i--)
			{
				Account a2 = accounts[i];
				a1 = a2;
				nameField.Text = a2.Name;
				addressField.Text = a2.Address;
				phoneField.Text = a2.Phone;
				accountNumField.Text = a2.AccountNumber;
				balanceField.Text = Convert.ToString(a2.Balance);
				interestField.Text = Convert.ToString(a2.InterestRate);
			}
		}

		private void nextButtonClicked()
		{
			IList<Account> accounts = accountFile.All;
			Account a1 = null;
			int index;
			for (int i = 0; i < accounts.Count; i++)
			{
				Account a2 = accounts[i];
				a1 = a2;
				nameField.Text = a2.Name;
				addressField.Text = a2.Address;
				phoneField.Text = a2.Phone;
				accountNumField.Text = a2.AccountNumber;
				balanceField.Text = Convert.ToString(a2.Balance);
				interestField.Text = Convert.ToString(a2.InterestRate);
			}

		}

		public virtual void searchButtonClicked()
		{
			Validation v = new Validation();
			string errorMsg = "";
			errorMsg += v.isPresent(nameField.Text, "Name");
			if (errorMsg.Length == 0)
			{
				try
				{
					System.IO.StreamReader @in = new System.IO.StreamReader("accounts.txt");
					string n = nameField.Text;
					Account a = accountFile.get(n);
					nameField.Text = a.Name;
					addressField.Text = a.Address;
					phoneField.Text = a.Phone;
					accountNumField.Text = a.AccountNumber;
					balanceField.Text = Convert.ToString(a.Balance);
					interestField.Text = Convert.ToString(a.InterestRate);
				}
				catch (FileNotFoundException ex)
				{
					MessageBox.Show(this, ex, "File Not Located", MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show(this, errorMsg, "Invalid Data", MessageBoxIcon.Error);
			}
		}

		private void openAcctButtonClicked()
		{
			Validation v = new Validation();
			string errorMsg = "";
			errorMsg += v.isPresent(nameField.Text, "Name");
			errorMsg += v.isPresent(addressField.Text, "Address");
			errorMsg += v.isPresent(phoneField.Text, "Phone Number");
			errorMsg += v.isPresent(phoneField.Text, "Phone Number");
			errorMsg += v.isDouble(wDField.Text, "Balance");

			if (errorMsg.Length == 0)
			{
				string name = nameField.Text;
				string address = addressField.Text;
				string phone = phoneField.Text;
				string account = accountNumField.Text;
				double balance = double.Parse(wDField.Text);
				Account a = new Account(name, address, phone, account, balance, 0.9);
				a.Name = name;
				a.Address = address;
				a.Phone = phone;
				a.AccountNumber = account;
				a.Balance = balance;
				a.InterestRate = a.InterestRate;
				accountFile.add(a);
				if (true)
				{
					MessageBox.Show(this, "Success!", "Alert", MessageBoxIcon.None);
				}
			}
			else
			{
				MessageBox.Show(this, errorMsg, "Invalid Data", MessageBoxIcon.Error);
			}
		}

		private void addButtonClicked()
		{
			Validation v = new Validation();
			string errorMsg = "";
			errorMsg += v.isPresent(nameField.Text, "Name");
			errorMsg += v.isPresent(addressField.Text, "Address");
			errorMsg += v.isPresent(phoneField.Text, "Phone Number");
			errorMsg += v.isPresent(accountNumField.Text, "Account Number");
			errorMsg += v.isDouble(wDField.Text, "Balance");

			if (errorMsg.Length == 0)
			{
				string name = nameField.Text;
				string address = addressField.Text;
				string phone = phoneField.Text;
				string account = accountNumField.Text;
				double balance = double.Parse(wDField.Text);
				Account a = new Account(name, address, phone, account, balance, 0.9);
				a.Name = name;
				a.Address = address;
				a.Phone = phone;
				a.AccountNumber = account;
				a.Balance = balance;
				a.InterestRate = a.InterestRate;
				accountFile.add(a);
				if (true)
				{
					MessageBox.Show(this, "Name Added To Account", "Alert", MessageBoxIcon.None);
				}
			}
			else
			{
				MessageBox.Show(this, errorMsg, "Invalid Data", MessageBoxIcon.Error);
			}
		}

		private void updateClicked()
		{
			Validation v = new Validation();
			string errorMsg = "";
			errorMsg += v.isPresent(nameField.Text, "Name");
			errorMsg += v.isPresent(addressField.Text, "Address");
			errorMsg += v.isPresent(phoneField.Text, "Phone Number");
			errorMsg += v.isPresent(accountNumField.Text, "Account Number");

			if (errorMsg.Length == 0)
			{
				IList<Account> accounts = accountFile.All;
				Account a1 = null;
				int index;
				//This will give the right account
				for (int i = 0; i < accounts.Count; i++)
				{
					Account a2 = accounts[i];
					if (accountNumField.Text.equalsIgnoreCase(a2.AccountNumber))
					{
						a1 = a2;
						//save the index location of the account
						index = i;
					}
				}
				//Once the account is pulled out set the variables to the updated data
				a1.Name = nameField.Text; //example
				a1.Address = addressField.Text;
				a1.Phone = phoneField.Text;
				a1.AccountNumber = accountNumField.Text;
				a1.Balance;
				a1.InterestRate;
				accountFile.update(a1);
				if (true)
				{
					MessageBox.Show(this, "Account Updated", "Alert", MessageBoxIcon.None);
				}
			}
			else
			{
				MessageBox.Show(this, errorMsg, "Invalid Data", MessageBoxIcon.Error);
			}
		}

		private void depositButtonClicked()
		{
			Validation v = new Validation();
			string errorMsg = "";
			errorMsg += v.isPresent(accountNumField.Text, "Account Number");
			errorMsg += v.isDouble(wDField.Text, "Balance");

			if (errorMsg.Length == 0)
			{
				IList<Account> accounts = accountFile.All;
				Account a1 = null;
				int index;
				//This will give the right account
				for (int i = 0; i < accounts.Count; i++)
				{
					Account a2 = accounts[i];
					if (accountNumField.Text.equalsIgnoreCase(a2.AccountNumber))
					{
						a1 = a2;
						//save the index location of the account
						index = i;
					}
				}
				//Once the account is pulled out set the variables to the updated data
				a1.Name; //example
				a1.Address;
				a1.Phone;
				a1.AccountNumber = accountNumField.Text;
				a1.Balance;
				a1.deposit(double.Parse(wDField.Text));
				accountFile.update(a1);
				if (true)
				{
					MessageBox.Show(this, "Deposit Successful!" + a1.Name, "Alert", MessageBoxIcon.None);
				}
			}
			else
			{
				MessageBox.Show(this, errorMsg, "Invalid Data", MessageBoxIcon.Error);
			}
		}

		private void withdrawButtonClicked()
		{
			Validation v = new Validation();
			string errorMsg = "";
			errorMsg += v.isPresent(accountNumField.Text, "Account Number");
			errorMsg += v.isDouble(wDField.Text, "Balance");

			if (errorMsg.Length == 0)
			{
				IList<Account> accounts = accountFile.All;
				Account a1 = null;
				int index;
				//This will give the right account
				for (int i = 0; i < accounts.Count; i++)
				{
					Account a2 = accounts[i];
					if (accountNumField.Text.equalsIgnoreCase(a2.AccountNumber))
					{
						a1 = a2;
						//save the index location of the account
						index = i;
					}
				}
				//Once the account is pulled out set the variables to the updated data
				a1.Name; //example
				a1.Address;
				a1.Phone;
				a1.AccountNumber = accountNumField.Text;
				a1.Balance;
				a1.withdraw(double.Parse(wDField.Text));
				accountFile.update(a1);
				if (true)
				{
					MessageBox.Show(this, "Withdrawal Successful " + a1.Name, "Alert", MessageBoxIcon.None);
				}
			}
			else
			{
				MessageBox.Show(this, errorMsg, "Invalid Data", MessageBoxIcon.Error);
			}
		}

		private void calculateInterestClicked()
		{
			Validation v = new Validation();
			string errorMsg = "";
			errorMsg += v.isPresent(accountNumField.Text, "Account Number");
			errorMsg += v.isInteger(interestField.Text, "Interest Month");

			if (errorMsg.Length == 0)
			{
				IList<Account> accounts = accountFile.All;
				Account a1 = null;
				int index;
				//This will give the right account
				for (int i = 0; i < accounts.Count; i++)
				{
					Account a2 = accounts[i];
					if (accountNumField.Text.equalsIgnoreCase(a2.AccountNumber))
					{
						a1 = a2;
						//save the index location of the account
						index = i;
					}
				}
				//Once the account is pulled out set the variables to the updated data
				a1.Name; //example
				a1.Address;
				a1.Phone;
				a1.AccountNumber = accountNumField.Text;
				a1.Balance;
				accountFile.update(a1);
				double a = a1.InterestRate;
				double s = double.Parse(interestField.Text);
				double c = (a / s) / 100;
				calcInterestField.Text = Convert.ToString(c);
				if (true)
				{
					MessageBox.Show(this, "Success!", "Alert", MessageBoxIcon.None);
				}
			}
			else
			{
				MessageBox.Show(this, errorMsg, "Invalid Data", MessageBoxIcon.Error);
			}
		}

	}

}