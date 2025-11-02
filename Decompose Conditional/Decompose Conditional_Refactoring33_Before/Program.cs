using System;

namespace Problem_DecomposeConditional
{
    class Program
    {
        static void Main(string[] args)
        {
            var summerDate = new DateTime(2025, 7, 15);
            var winterDate = new DateTime(2025, 12, 15);

            Console.WriteLine("Summer Charge: " + CalculateCharge(summerDate, 10));
            Console.WriteLine("Winter Charge: " + CalculateCharge(winterDate, 10));
        }

        static double CalculateCharge(DateTime date, double quantity)
        {
            double charge;
            double summerRate = 1.5;
            double winterRate = 2.0;
            double winterServiceCharge = 10;

            if (date.Month < 6 || date.Month > 8)
            {
                charge = quantity * winterRate + winterServiceCharge;
            }
            else
            {
                charge = quantity * summerRate;
            }
            return charge;
        }
    }
}