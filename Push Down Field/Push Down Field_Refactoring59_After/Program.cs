using System;

namespace Solution_PushDownField
{
    class Program
    {
        static void Main(string[] args)
        {
            var salesperson = new Salesperson(100);
            var engineer = new Engineer();
        }
    }

    class Employee { }

    class Salesperson : Employee
    {
        private double _quota;
        public Salesperson(double quota) { _quota = quota; }
    }
    class Engineer : Employee { }
}