using System;

namespace Problem_ExtractInterface
{
    class Program { static void Main(string[] args) { } }

    class Employee
    {
        public int GetRate() { return 100; }
    }

    class TimeSheet
    {
        public double Charge(Employee emp, int days)
        {
            return emp.GetRate() * days;
        }
    }
}