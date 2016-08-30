using System;

namespace OOPwithCsharpDay3
{
    class SavingsAccount : BankAccount
    {
        public SavingsAccount(string AccountNumber, string AccountName, double AccountBalance) : base(AccountNumber, AccountName, AccountBalance, 1)
        { }
        public SavingsAccount(string AccountNumber, Customer Customer, double AccountBalance) : base(AccountNumber, Customer, AccountBalance, 1)
        { }
    }

    class CurrentAccount : BankAccount
    {
        public CurrentAccount(string AccountNumber, string AccountName, double AccountBalance) : base(AccountNumber, AccountName, AccountBalance, 0.25)
        { }
        public CurrentAccount(string AccountNumber, Customer Customer, double AccountBalance) : base(AccountNumber, Customer, AccountBalance, 0.25)
        { }
    }

    class OverDraftAccount : BankAccount
    {
        public OverDraftAccount(string AccountNumber, string AccountName, double AccountBalance) : base(AccountNumber, AccountName, AccountBalance)
        { }
        public OverDraftAccount(string AccountNumber, Customer Customer, double AccountBalance) : base(AccountNumber, Customer, AccountBalance)
        { }
        public override void Withdraw(double amount)
        {
            AccountBalance -= amount;
            Console.WriteLine("{0}\t{1}\t-{2:c}\t{3:c}.", Customer.Name, AccountNumber, amount, AccountBalance);
        }
        public override double CalculateInterest()
        {
            if (AccountBalance < 0)
                InterestRate = 6;
            else
                InterestRate = 0.25;
            return AccountBalance * InterestRate / 100;
        }
        //public void CreditInterest()//why doesn't the old CreditInterest Reference the new CalculateInterest? Is there a way to make it do that?
        //{
        //    double Interest = CalculateInterest();
        //    Deposit(Interest);
        //    //Console.WriteLine("{0}\t{1}\t{2:c}\t{3:c}.", AccountName, AccountNumber, Interest, AccountBalance);
        //}
    }
}
