using System;

namespace Problem_ParameterizeMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee(5000);
            RaiseFivePercent(employee);
            RaiseTenPercent(employee);
        }

        static void RaiseFivePercent(Employee employee)
        {
            employee.Salary *= 1.05;
        }

        static void RaiseTenPercent(Employee employee)
        {
            employee.Salary *= 1.1;
        }
    }

    class Employee
    {
        public double Salary { get; set; }
        public Employee(double salary) { Salary = salary; }
    }
}