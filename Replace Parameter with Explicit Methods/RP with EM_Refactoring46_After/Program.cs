using System;

namespace Solution_ReplaceParameterWithExplicitMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var engineer = Employee.CreateEngineer();
            Console.WriteLine(engineer.GetType().Name);
        }
    }

    abstract class Employee
    {
        public static Employee CreateEngineer()
        {
            return new Engineer();
        }
        public static Employee CreateManager()
        {
            return new Manager();
        }
    }
    class Engineer : Employee { }
    class Manager : Employee { }
}