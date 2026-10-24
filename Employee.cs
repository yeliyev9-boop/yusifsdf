using System.Collections.Generic;

namespace yusifmuasirsdf
{
    // Ödəniş sinfi (Title və Amount)
    public class Payment
    {
        public string Title { get; set; }
        public double Amount { get; set; }

        public Payment()
        {
        }

        public Payment(string title, double amount)
        {
            Title = title;
            Amount = amount;
        }
    }

    // İşçi sinfi (Code, FirstName, LastName, Age, Payments)
    public class Employee
    {
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Payment> Payments { get; set; }

        public Employee()
        {
            Payments = new List<Payment>();
        }

        public Employee(string code, string firstName, string lastName, int age)
        {
            Code = code;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Payments = new List<Payment>();
        }
    }
}
