using System;

namespace Solution_ExtractInterface
{
    class Program { static void Main(string[] args) { } }

    interface IBillable
    {
        int GetRate();
    }

    class Employee : IBillable
    {
        public int GetRate() { return 100; }
    }

    class Contractor : IBillable
    {
        public int GetRate() { return 120; }
    }

    class TimeSheet
    {
        public double Charge(IBillable billable, int days)
        {
            return billable.GetRate() * days;
        }
    }
}