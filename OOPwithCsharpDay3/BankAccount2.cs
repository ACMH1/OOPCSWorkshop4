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
        public BankAccount(string AccountNumber, string AccountName, double AccountBalance) : this(AccountNumber, new Customer(AccountName), AccountBalance)
        { }
        public BankAccount(string AccountNumber, string AccountName, double AccountBalance, double InterestRate) : this(AccountNumber, new Customer(AccountName), AccountBalance, InterestRate)
        { }
        public BankAccount(string AccountNumber, Customer Customer, double AccountBalance) : base(AccountNumber, Customer, AccountBalance)
        {
            InterestRate = 0;
        }
        public BankAccount(string AccountNumber, Customer Customer, double AccountBalance, double InterestRate) : this(AccountNumber, Customer, AccountBalance)
        {
            this.InterestRate = InterestRate;
        }

        //Methods
        public virtual double CalculateInterest()
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
