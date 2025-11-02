using System;

namespace Problem_ExtractSuperclass
{
    class Program { static void Main(string[] args) { } }

    class Employee
    {
        public string Name { get; private set; }
        private double _annualCost;
        public Employee(string name, double annualCost)
        {
            Name = name;
            _annualCost = annualCost;
        }
        public double GetAnnualCost() { return _annualCost; }
    }

    class Department
    {
        public string Name { get; private set; }
        private double _annualCost;
        public Department(string name, double annualCost)
        {
            Name = name;
            _annualCost = annualCost;
        }
        public double GetAnnualCost() { return _annualCost; }
    }
}