using System;

namespace Solution_DecomposeConditional
{
    class Program
    {
        private const double SUMMER_RATE = 1.5;
        private const double WINTER_RATE = 2.0;
        private const double WINTER_SERVICE_CHARGE = 10;

        static void Main(string[] args)
        {
            var summerDate = new DateTime(2025, 7, 15);
            var winterDate = new DateTime(2025, 12, 15);

            Console.WriteLine("Summer Charge: " + CalculateCharge(summerDate, 10));
            Console.WriteLine("Winter Charge: " + CalculateCharge(winterDate, 10));
        }

        static bool IsWinter(DateTime date)
        {
            return date.Month < 6 || date.Month > 8;
        }

        static double GetWinterCharge(double quantity)
        {
            return quantity * WINTER_RATE + WINTER_SERVICE_CHARGE;
        }

        static double GetSummerCharge(double quantity)
        {
            return quantity * SUMMER_RATE;
        }

        static double CalculateCharge(DateTime date, double quantity)
        {
            return IsWinter(date) ? GetWinterCharge(quantity) : GetSummerCharge(quantity);
        }
    }
}