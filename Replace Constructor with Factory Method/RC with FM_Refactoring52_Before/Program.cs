using System;

namespace Problem_ReplaceConstructorWithFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee(0); // Số 0 này có nghĩa là gì?
            Console.WriteLine("Employee Type: " + employee.Type);
        }
    }

    class Employee
    {
        public string Type { get; private set; }
        public Employee(int typeCode)
        {
            switch (typeCode)
            {
                case 0: Type = "Engineer"; break;
                case 1: Type = "Manager"; break;
            }
        }
    }
}