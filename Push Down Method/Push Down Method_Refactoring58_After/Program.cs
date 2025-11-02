using System;

namespace Solution_PushDownMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var salesperson = new Salesperson();
            Console.WriteLine("Salesperson Quota: " + salesperson.GetSalesQuota());

            // var engineer = new Engineer();
            // engineer.GetSalesQuota(); // Dòng này sẽ gây lỗi biên dịch!
        }
    }

    class Employee { }

    class Salesperson : Employee
    {
        public double GetSalesQuota()
        {
            return 100;
        }
    }

    class Engineer : Employee { }
}