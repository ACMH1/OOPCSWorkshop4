using System;

namespace OOPwithCsharpDay3
{
    class Account
    {
        //Attributes
        protected string AccountNumber;
        protected Customer Customer;
        protected double AccountBalance;

        //Constructors
        public Account() : this("", "", 0)
        { }
        public Account(string AccountNumber, string AccountName, double AccountBalance) : this(AccountNumber, new Customer(AccountName), AccountBalance)
        {
            this.AccountNumber = AccountNumber;
            this.Customer = new Customer(AccountName);
            this.AccountBalance = AccountBalance;
        }
        public Account(string AccountNumber, Customer Customer, double AccountBalance)
        {
            this.AccountNumber = AccountNumber;
            this.Customer = Customer;
            this.AccountBalance = AccountBalance;
        }

        //Methods
        public virtual void Withdraw(double amount)
        {
            if (AccountBalance >= amount)
            {
                AccountBalance -= amount;
                Console.WriteLine("{0}\t{1}\t-{2:c}\t{3:c}.", Customer.Name, AccountNumber, amount, AccountBalance);
            }
            else
                Console.WriteLine("Insufficient Funds.");
        }
        public void Deposit(double amount)
        {
            AccountBalance += amount;
            Console.WriteLine("{0}\t{1}\t{2:c}\t\t{3:c}.", Customer.Name, AccountNumber, amount, AccountBalance);
        }
        public void TransferTo(double amount, Account Another)
        {
            if (AccountBalance >= amount)
            {
                this.Withdraw(amount);
                Another.Deposit(amount);
                //Console.WriteLine("Transferred {0:c} from {1} to {2}", amount, Customer.Name, Another.Name);
            }
            else
                Console.WriteLine("Insufficient Funds.");
        }
        public string Show()
        {
            return String.Format("{0}\t{1}\t\t\t{2:c}.", Customer.Name, AccountNumber, AccountBalance);
        }

        //Properties
        public string AccountNo
        {
            get
            {
                return AccountNumber;
            }
        }
        public string Name
        {
            get
            {
                return Customer.Name;
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
