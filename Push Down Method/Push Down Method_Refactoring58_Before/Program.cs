using System;

namespace Problem_PushDownMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var salesperson = new Salesperson();
            Console.WriteLine("Salesperson Quota: " + salesperson.GetSalesQuota());
        }
    }

    class Employee
    {
        public double GetSalesQuota()
        {
            return 100;
        }
    }

    class Salesperson : Employee { }
    class Engineer : Employee { }
}