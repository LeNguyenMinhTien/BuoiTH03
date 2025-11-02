using System;

namespace Solution_TypeCodeWithSubclasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var engineer = Employee.Create(Employee.ENGINEER);
            var manager = Employee.Create(Employee.MANAGER);
            Console.WriteLine("Engineer Category: " + engineer.GetCategory());
            Console.WriteLine("Manager Category: " + manager.GetCategory());
        }
    }

    abstract class Employee
    {
        public const int ENGINEER = 0;
        public const int MANAGER = 1;
        public abstract string GetCategory();
        public static Employee Create(int type)
        {
            switch (type)
            {
                case ENGINEER: return new Engineer();
                case MANAGER: return new Manager();
                default: throw new ArgumentException("Incorrect type code value");
            }
        }
    }

    class Engineer : Employee
    {
        public override string GetCategory() { return "Kỹ sư"; }
    }

    class Manager : Employee
    {
        public override string GetCategory() { return "Quản lý"; }
    }
}