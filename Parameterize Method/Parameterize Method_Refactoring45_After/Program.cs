using System;

namespace Solution_ParameterizeMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee(5000);
            ApplyRaise(employee, 0.05); // Tăng 5%
            ApplyRaise(employee, 0.10); // Tăng 10%
        }

        static void ApplyRaise(Employee employee, double factor)
        {
            employee.Salary *= (1 + factor);
        }
    }

    class Employee
    {
        public double Salary { get; set; }
        public Employee(double salary) { Salary = salary; }
    }
}