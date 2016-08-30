using System;

namespace OOPwithCsharpDay3
{
    class Customer
    {
        //attributes
        string CustomerName, CustomerAddress, PassportNumber;
        DateTime DateOfBirth;
        
        //constructor
        public Customer(string Name) : this(Name, "", "", DateTime.Now)
        { }
        public Customer(string Name, string Address, string PassportNumber, DateTime DateOfBirth)
        {
            CustomerName = Name;
            CustomerAddress = Address;
            this.PassportNumber = PassportNumber;
            this.DateOfBirth = DateOfBirth;
        }

        //method
        public void GetAge()
        {
            int CurrentYear = DateTime.Now.Year;
            Console.WriteLine(CurrentYear - DateOfBirth.Year);
        }

        //property
        public string Name
        {
            get
            {
                return CustomerName;
            }
        }
    }
}
