using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace BankingAPP
{
        public sealed class AccountTextFile : DAO<Account>
        {
            private IList<Account> accounts = null;
            private string accountsFile = "accounts.txt";
            private readonly string FIELD_SEP = "\t";

        IList<Account> DAO<Account>.GetAll => throw new NotImplementedException();

        public AccountTextFile()
            {
                accounts = this.GetAll();
            }

            public IList<Account> GetAll()
            {
                {
                    List<string> accounts = new List<string>();
                    try
                    {
                        using (StreamReader sr = new StreamReader("accounts.txt"))
                        {
                            // read products from file into array list
                            string line = sr.ReadLine();
                            while (line != null)
                            {
                                string[] fields = line.Split('\t');
                                string name = fields[0];
                                string address = fields[1];
                                string phone = fields[2];
                                string accountNumber = fields[3];
                                string balance = fields[4];
                                string interestRate = fields[5];

                                Account a = new Account(name, address, phone, accountNumber, double.Parse(balance), double.Parse(interestRate));
                                accounts.Add(a.ToString());

                                line = sr.ReadLine();
                            }
                        }
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine(e);
                        return null;
                    }
                    return null;
                }
            }

            public Account Get(string code)
            {
                foreach (Account a in accounts)
                {
                    if (a.GetName().Equals(code))
                    {
                        return a;
                    }
                }
                return null;
            }

            private bool SaveAll()
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(new FileStream(accountsFile, FileMode.OpenOrCreate, FileAccess.ReadWrite)))
                    {

                        // write all products in the array list
                        // to the file
                        foreach (Account a in accounts)
                        {
                            sw.Write(a.GetName() + FIELD_SEP);
                            sw.Write(a.GetAddress() + FIELD_SEP);
                            sw.Write(a.GetPhone() + FIELD_SEP);
                            sw.Write(a.GetAccountNumber() + FIELD_SEP);
                            sw.Write(a.GetBalance() + FIELD_SEP);
                            sw.Write(a.GetInterestRate());
                        }
                        return true;
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine(e);
                    return false;
                }
            }

            public bool Add(Account a)
            {
                accounts.Add(a);
                return this.SaveAll();
            }

            public bool Delete(Account a)
            {
                accounts.Remove(a);
                return this.SaveAll();
            }

            public bool Update(Account newAccount)
            {
                // get the old product and remove it
                Account oldAccount = this.Get(newAccount.GetName());
                int i = accounts.IndexOf(oldAccount);
                accounts.RemoveAt(i);

                // add the updated product
                accounts.Insert(i, newAccount);

            return this.SaveAll();
        }
    }
}
