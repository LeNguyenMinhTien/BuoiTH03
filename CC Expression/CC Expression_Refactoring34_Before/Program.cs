using System;

namespace Problem_ConsolidateConditional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factor: " + CalculateDisabilityFactor(1, 15, true));
        }

        static int CalculateDisabilityFactor(int seniority, int monthsDisabled, bool isPartTime)
        {
            if (seniority < 2)
            {
                return 0;
            }
            if (monthsDisabled > 12)
            {
                return 0;
            }
            if (isPartTime)
            {
                return 0;
            }
            return 10; // Tính toán bình thường
        }
    }
}