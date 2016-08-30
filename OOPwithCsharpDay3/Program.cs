using System;

namespace OOPwithCsharpDay3
{
    //class Workshop3_1
    //{
    //    public static void Main()
    //    {
    //        Account a = new Account("001-001-001", "Tan Ah Kow", 2000);
    //        Account b = new Account("001-001-002", "Kim Keng Lee", 5000);
    //        Console.WriteLine(a.Show());
    //        Console.WriteLine(b.Show());
    //        a.Deposit(100);
    //        Console.WriteLine(a.Show());
    //        a.Withdraw(200);
    //        Console.WriteLine(a.Show());
    //        a.TransferTo(300, b);
    //        Console.WriteLine(a.Show());
    //        Console.WriteLine(b.Show());
    //    }
    //}

    //class Workshop3_2
    //{
    //    public static void Main()
    //    {
    //        Customer y = new Customer("Tan Ah Kow", "20, Seaside Road", "XXX20", new DateTime(1989, 10, 11));
    //        Customer z = new Customer("Kim Lee Keng", "2, Rich View", "XXX9F", new DateTime(1993, 4, 25));
    //        Account a = new Account("001-001-001", y, 2000);
    //        Account b = new Account("001-001-002", z, 5000);
    //        Console.WriteLine(a.Show());
    //        Console.WriteLine(b.Show());
    //        a.Deposit(100);
    //        Console.WriteLine(a.Show());
    //        a.Withdraw(200);
    //        Console.WriteLine(a.Show());
    //        a.TransferTo(300, b);
    //        Console.WriteLine(a.Show());
    //        Console.WriteLine(b.Show());
    //        y.GetAge();
    //        z.GetAge();
    //    }
    //}

    class Workshop4
    {
        public static void Main()
        {
            Customer y = new Customer("Tan Ah Kow", "20, Seaside Road", "XXX20", new DateTime(1989, 10, 11));
            SavingsAccount a = new SavingsAccount("001-001-001", y, 1000);
            CurrentAccount b = new CurrentAccount("001-001-002", y, 1000);
            OverDraftAccount c = new OverDraftAccount("001-001-003", y, -1000);
            Console.WriteLine(a.Show());
            Console.WriteLine(b.Show());
            Console.WriteLine(c.Show());
            a.CreditInterest();
            b.CreditInterest();
            c.CreditInterest();
            Console.WriteLine(a.Show());
            Console.WriteLine(b.Show());
            Console.WriteLine(c.Show());
            Console.WriteLine(a.Balance);
            Console.WriteLine(b.Balance);
            Console.WriteLine(c.Balance);
        }
    }
}