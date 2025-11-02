using System;

namespace Problem_ReplaceParameterWithExplicitMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var engineer = Employee.Create("engineer");
            Console.WriteLine(engineer.GetType().Name);
        }
    }

    abstract class Employee
    {
        public static Employee Create(string type)
        {
            if (type.Equals("engineer")) return new Engineer();
            if (type.Equals("manager")) return new Manager();
            throw new ArgumentException("Invalid type");
        }
    }
    class Engineer : Employee { }
    class Manager : Employee { }
}