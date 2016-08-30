using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPwithCsharpDay3
{
    class BankBranch
    {
        string BranchName, BranchManager;
        List<BankAccount> AccountsinBank;

        public BankBranch(string BranchName, string BranchManager)
        {
            this.BranchName = BranchName;
            this.BranchManager = BranchManager;
            AccountsinBank = new List<BankAccount>();
        }

        public void AddAccount(BankAccount BankAccount)
        {
            AccountsinBank.Add(BankAccount);
            Console.WriteLine("Added {0} to list of accounts.", BankAccount.AccountNo);
        }
        public void PrintCustomers()
        {
            for (int i = 0; i < AccountsinBank.Count; i++)
            {
                Console.WriteLine(AccountsinBank[i].Name);
            }
        }
        public double TotalDeposits()
        {
            double result = 0;
            for (int i = 0; i < AccountsinBank.Count; i++)
            {
                result += AccountsinBank[i].Balance;
            }
            return result;
        }
        public double TotalInterestPaid()
        {
            double result = 0;
            for (int i = 0; i < AccountsinBank.Count; i++)
            {
                double interest = AccountsinBank[i].CalculateInterest();
                if (interest > 0)
                    result += interest;
            }
            return result;
        }
        public double TotalInterestEarned()
        {
            double result = 0;
            for (int i = 0; i < AccountsinBank.Count; i++)
            {
                double interest = AccountsinBank[i].CalculateInterest();
                if (interest < 0)
                    result -= interest;
            }
            return result;
        }
    }
}
