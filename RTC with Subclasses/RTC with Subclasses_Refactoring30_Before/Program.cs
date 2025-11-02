using System;

namespace Problem_TypeCodeWithSubclasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var engineer = new Employee(Employee.ENGINEER);
            var manager = new Employee(Employee.MANAGER);
            Console.WriteLine("Engineer Category: " + engineer.GetCategory());
            Console.WriteLine("Manager Category: " + manager.GetCategory());
        }
    }

    class Employee
    {
        public const int ENGINEER = 0;
        public const int MANAGER = 1;
        public int Type { get; private set; }
        public Employee(int type) { Type = type; }

        public string GetCategory()
        {
            switch (Type)
            {
                case ENGINEER: return "Kỹ sư";
                case MANAGER: return "Quản lý";
                default: throw new ArgumentException("Incorrect type code value");
            }
        }
    }
}