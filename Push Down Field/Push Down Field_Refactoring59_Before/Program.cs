using System;

namespace Problem_PushDownField
{
    class Program
    {
        static void Main(string[] args)
        {
            var salesperson = new Salesperson(100);
            var engineer = new Engineer();
        }
    }

    class Employee
    {
        protected double _quota;
    }

    class Salesperson : Employee
    {
        public Salesperson(double quota) { _quota = quota; }
    }
    class Engineer : Employee { }
}