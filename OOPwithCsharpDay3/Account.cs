using System;

namespace OOPwithCsharpDay3
{
    class Account
    {
        //Attributes
        protected string AccountNumber;
        protected string AccountName;
        protected double AccountBalance;

        //Constructors
        public Account() : this("", "", 0)
        { }
        public Account(string AccountNumber, string AccountName, double AccountBalance)
        {
            this.AccountNumber = AccountNumber;
            this.AccountName = AccountName;
            this.AccountBalance = AccountBalance;
        }
        public Account(string AccountNumber, Customer Customer, double AccountBalance) : this(AccountNumber, Customer.Name, AccountBalance)
        { }

        //Methods
        public void Withdraw(double amount)
        {
            if (AccountBalance >= amount)
            {
                AccountBalance -= amount;
                Console.WriteLine("{0}\t{1}\t-{2:c}\t{3:c}.", AccountName, AccountNumber, amount, AccountBalance);
            }
            else
                Console.WriteLine("Insufficient Funds.");
        }
        public void Deposit(double amount)
        {
            AccountBalance += amount;
            Console.WriteLine("{0}\t{1}\t{2:c}\t\t{3:c}.", AccountName, AccountNumber, amount, AccountBalance);
        }
        public void TransferTo(double amount, Account Another)
        {
            if (AccountBalance >= amount)
            {
                this.Withdraw(amount);
                Another.Deposit(amount);
                //Console.WriteLine("Transferred {0:c} from {1} to {2}", amount, AccountName, Another.Name);
            }
            else
                Console.WriteLine("Insufficient Funds.");
        }
        public string Show()
        {
            return String.Format("{0}\t{1}\t\t\t{2:c}.", AccountName, AccountNumber, AccountBalance);
        }

        //Properties
        public string Name
        {
            get
            {
                return AccountName;
            }
        }
        public double Balance
        {
            get
            {
                return AccountBalance;
            }
        }
    }
}
