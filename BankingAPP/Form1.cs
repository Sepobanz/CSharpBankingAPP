using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace BankingAPP
{
    public partial class Form1 : Form
    {
        private string accountsFile = "accounts.txt";
        private static string[] accountsArray = new string [9999];

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSearchHOME_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void buttonAddHOME_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void buttonTransactionHOME_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void buttonHomeSEARCH_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void buttonHomeADD_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void buttonHomeTRANS_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void buttonHomeCALC_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonSearchSEARCH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFNameSEARCH.Text))
                MessageBox.Show("Must enter a first name");
            if (string.IsNullOrEmpty(textBoxLNameSEARCH.Text))
                MessageBox.Show("Must enter a last name");
            string fullName = textBoxFNameSEARCH.Text + " " + textBoxLNameSEARCH.Text;
            var record = "";
            using (var sr = new StreamReader(accountsFile))
            {
                while (!sr.EndOfStream)
                {
                    record = sr.ReadLine();
                    if (record != null)
                    {
                        accountsArray = record.Split('\t');
                        if (accountsArray[0].Equals(fullName))
                        {
                            MessageBox.Show("Customer Found!" + Environment.NewLine +
                                            "Name:\t\t" + accountsArray[0] + Environment.NewLine +
                                            "Address:\t\t" + accountsArray[1] + Environment.NewLine +
                                            "Phone:\t\t" + accountsArray[2] + Environment.NewLine +
                                            "Account:\t\t" + accountsArray[3] + Environment.NewLine +
                                            "Balance:\t\t" + accountsArray[4] + Environment.NewLine +
                                            "Interest Rate:\t" + accountsArray[5] + Environment.NewLine);
                            return;
                        }
                    }
                }
            }
        }

        private void buttonAddADD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNameADD.Text))
            {
                MessageBox.Show("All fields must be complete");
                return;
            }
            if (string.IsNullOrEmpty(textBoxAddressADD.Text))
            {
                MessageBox.Show("All fields must be complete");
                return;
            }
            if (string.IsNullOrEmpty(textBoxPhoneADD.Text))
            {
                MessageBox.Show("All fields must be complete");
                return;
            }
            if (string.IsNullOrEmpty(textBoxAccNumADD.Text))
            {
                MessageBox.Show("All fields must be complete");
                return;
            }
            if (string.IsNullOrEmpty(textBoxBalanceADD.Text))
            {
                MessageBox.Show("All fields must be complete");
                return;
            }
            if (string.IsNullOrEmpty(textBoxInterestRateADD.Text))
            {
                MessageBox.Show("All fields must be complete");
                return;
            }
            double flag; double flag2;
            bool success = double.TryParse(textBoxBalanceADD.Text, out flag);
            bool success2 = double.TryParse(textBoxInterestRateADD.Text, out flag2);
            if (success && success2)
            {
                using (StreamWriter sw = File.AppendText(accountsFile))
                {
                    sw.WriteLine(textBoxNameADD.Text + "\t" + textBoxAddressADD.Text + "\t" + textBoxPhoneADD.Text + "\t" +
                    textBoxAccNumADD.Text + "\t" + textBoxBalanceADD.Text + "\t" + textBoxInterestRateADD.Text);
                    textBoxNameADD.Clear();
                    textBoxAddressADD.Clear();
                    textBoxPhoneADD.Clear();
                    textBoxAccNumADD.Clear();
                    textBoxBalanceADD.Clear();
                    textBoxInterestRateADD.Clear();
                    MessageBox.Show("Customer successfully added", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sw.Close();
                }
            }
            else
            {
                MessageBox.Show("Account Balance and Interest Rate must be number values.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void buttonDepostTRANS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAccountNumTRANS.Text) || string.IsNullOrEmpty(textBoxAmountTRANS.Text))
            {
                MessageBox.Show("All fields must be complete");
                return;
            }
            string account = textBoxAccountNumTRANS.Text;
            double amount = Convert.ToDouble(textBoxAmountTRANS.Text);
            string record = "";
            using (var sr = new StreamReader(accountsFile))
            {
                while (!sr.EndOfStream)
                {
                    record = sr.ReadLine();
                    if (record != null)
                    {
                        accountsArray = record.Split('\t');
                        if (accountsArray[3].Equals(account))
                        {
                            string[] fields = record.Split('\t');
                            double money = Convert.ToDouble(fields[4]);
                            double nMoney = money + amount;
                            string fMoney = String.Format("{0:0.00}", nMoney);
                            string ar = fields[0] + "\t" + fields[1] + "\t" + fields[2] + "\t" + fields[3] + "\t" + fMoney + "\t" + fields[5];
                            sr.Close();
                            ReplaceInFile(accountsFile, record, ar);
                            MessageBox.Show("Account:\t" + fields[3] + Environment.NewLine + Environment.NewLine +
                                "Deposited $" + String.Format("{0:0.00}", amount) + " successfully, new balance is: $" + fMoney);
                            return;
                        }
                    }
                }
            }
        }

        private void buttonWithdrawTRANS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAccountNumTRANS.Text) || string.IsNullOrEmpty(textBoxAmountTRANS.Text))
            {
                MessageBox.Show("All fields must be complete");
                return;
            }
            string account = textBoxAccountNumTRANS.Text;
            double amount = Convert.ToDouble(textBoxAmountTRANS.Text);
            string record = "";
            using (var sr = new StreamReader(accountsFile))
            {
                while (!sr.EndOfStream)
                {
                    record = sr.ReadLine();
                    if (record != null)
                    {
                        accountsArray = record.Split('\t');
                        if (accountsArray[3].Equals(account))
                        {
                            string[] fields = record.Split('\t');
                            double money = Convert.ToDouble(fields[4]);
                            double nMoney = money - amount;
                            string fMoney = String.Format("{0:0.00}", nMoney);
                            string ar = fields[0] + "\t" + fields[1] + "\t" + fields[2] + "\t" + fields[3] + "\t" + fMoney  + "\t" + fields[5];
                            sr.Close();
                            ReplaceInFile(accountsFile, record, ar);
                            MessageBox.Show("Account:\t" + fields[3] + Environment.NewLine + Environment.NewLine +
                                "Withdrew $" + String.Format("{0:0.00}", amount) + " successfully, new balance is: $" + fMoney);
                            return;
                        }
                    }
                }
            }
        }



        private void buttonCalcCALC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAccountNumCALC.Text) || string.IsNullOrEmpty(textBoxMonthCALC.Text))
            {
                MessageBox.Show("All fields must be complete");
                return;
            }
            string account = textBoxAccountNumCALC.Text;
            var record = "";
            using (var sr = new StreamReader(accountsFile))
            {
                while (!sr.EndOfStream)
                {
                    record = sr.ReadLine();
                    if (record != null)
                    {
                        accountsArray = record.Split('\t');
                        if (accountsArray[3].Equals(account))
                        {
                            string[] fields = record.Split('\t');
                            int month = Convert.ToInt32(textBoxMonthCALC.Text);
                            double iRate = Convert.ToDouble(accountsArray[5]);
                            double result = iRate / month;
                            sr.Close();
                            MessageBox.Show("Interest is: " + String.Format("{0:0.00#}", result));
                            return;
                        }
                    }

                }
            }
        }

        public static void ReplaceInFile(string filePath, string searchText, string replaceText)
        {

            var content = string.Empty;
            using (StreamReader reader = new StreamReader(filePath))
            {
                content = reader.ReadToEnd();
                reader.Close();
            }

            content = Regex.Replace(content, searchText, replaceText);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(content);
                writer.Close();
            }
        }

        private void textBoxFNameSEARCH_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxFNameSEARCH.SelectAll();
        }

        private void textBoxLNameSEARCH_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxLNameSEARCH.SelectAll();
        }

        private void textBoxNameADD_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxNameADD.SelectAll();
        }

        private void textBoxAddressADD_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxAddressADD.SelectAll();
        }

        private void textBoxPhoneADD_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxPhoneADD.SelectAll();
        }

        private void textBoxAccNumADD_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxAccNumADD.SelectAll();
        }

        private void textBoxBalanceADD_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxBalanceADD.SelectAll();
        }

        private void textBoxInterestRateADD_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxInterestRateADD.SelectAll();
        }

        private void textBoxAccountNumTRANS_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxAccountNumTRANS.SelectAll();
        }

        private void textBoxAmountTRANS_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxAmountTRANS.SelectAll();
        }
    }
}
