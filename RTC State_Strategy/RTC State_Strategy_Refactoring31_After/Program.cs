using System;

namespace Solution_TypeCodeWithState
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee(new EngineerType());
            Console.WriteLine("Bonus as Engineer: " + employee.GetBonus());

            employee.Type = new ManagerType(); // Thay đổi "chiến lược"
            Console.WriteLine("Bonus as Manager: " + employee.GetBonus());
        }
    }

    interface IEmployeeType { double GetBonus(); }
    class EngineerType : IEmployeeType { public double GetBonus() { return 100; } }
    class ManagerType : IEmployeeType { public double GetBonus() { return 200; } }

    class Employee
    {
        public IEmployeeType Type { get; set; }
        public Employee(IEmployeeType type) { Type = type; }
        public double GetBonus() { return Type.GetBonus(); }
    }
}