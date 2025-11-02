using System;

namespace Problem_CollapseHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee();
            var manager = new Manager();
        }
    }

    class Employee
    {
        public string GetName() { return "An employee"; }
    }

    class Manager : Employee
    {
        // Lớp con này gần như trống rỗng
    }
}