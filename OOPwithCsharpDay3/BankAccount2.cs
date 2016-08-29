using System;

namespace OOPwithCsharpDay3
{
    class BankAccount : Account
    {
        //Attributes
        protected double InterestRate;

        //Constructors
        public BankAccount() : this("", "", 0)
        { }
        public BankAccount(string AccountNumber, string AccountName, double AccountBalance)
        {
            this.AccountNumber = AccountNumber;
            this.AccountName = AccountName;
            this.AccountBalance = AccountBalance;
            InterestRate = 0;
        }
        public BankAccount(string AccountNumber, string AccountName, double AccountBalance, double InterestRate) : this(AccountNumber, AccountName, AccountBalance)
        {
            this.InterestRate = InterestRate;
        }
        public BankAccount(string AccountNumber, Customer Customer, double AccountBalance) : this(AccountNumber, Customer.Name, AccountBalance)
        { }
        public BankAccount(string AccountNumber, Customer Customer, double AccountBalance, double InterestRate) : this(AccountNumber, Customer.Name, AccountBalance, InterestRate)
        { }

        //Methods
        public double CalculateInterest()
        {
            //Console.WriteLine("{0:c}, {1}", AccountBalance, InterestRate);
            return AccountBalance * InterestRate / 100;
        }
        public void CreditInterest()
        {
            double Interest = CalculateInterest();
            Deposit(Interest);
            //Console.WriteLine("{0}\t{1}\t{2:c}\t{3:c}.", AccountName, AccountNumber, Interest, AccountBalance);
        }
    }
}
