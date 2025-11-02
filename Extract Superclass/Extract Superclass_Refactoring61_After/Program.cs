using System;

namespace Solution_ExtractSuperclass
{
    class Program { static void Main(string[] args) { } }

    abstract class Party
    {
        public string Name { get; private set; }
        private double _annualCost;
        public Party(string name, double annualCost)
        {
            Name = name;
            _annualCost = annualCost;
        }
        public double GetAnnualCost() { return _annualCost; }
    }

    class Employee : Party
    {
        public Employee(string name, double annualCost) : base(name, annualCost) { }
    }

    class Department : Party
    {
        public Department(string name, double annualCost) : base(name, annualCost) { }
    }
}