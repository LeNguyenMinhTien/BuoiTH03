using System;

namespace Solution_CollapseHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee();
        }
    }

    class Employee
    {
        public string GetName() { return "An employee"; }
    }
}