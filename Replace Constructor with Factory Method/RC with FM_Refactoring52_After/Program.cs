using System;

namespace Solution_ReplaceConstructorWithFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = Employee.CreateEngineer(); // Cách gọi rõ ràng hơn nhiều
            Console.WriteLine("Employee Type: " + employee.Type);
        }
    }

    class Employee
    {
        public string Type { get; private set; }
        private Employee(string type) { Type = type; }

        public static Employee CreateEngineer()
        {
            return new Employee("Engineer");
        }
        public static Employee CreateManager()
        {
            return new Employee("Manager");
        }
    }
}