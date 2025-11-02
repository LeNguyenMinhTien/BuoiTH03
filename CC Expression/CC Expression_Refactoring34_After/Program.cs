using System;

namespace Solution_ConsolidateConditional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factor: " + CalculateDisabilityFactor(1, 15, true));
        }

        static int CalculateDisabilityFactor(int seniority, int monthsDisabled, bool isPartTime)
        {
            if (seniority < 2 || monthsDisabled > 12 || isPartTime)
            {
                return 0;
            }
            return 10; // Tính toán bình thường
        }
    }
}