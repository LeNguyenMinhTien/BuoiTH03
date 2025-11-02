using System;

namespace Solution_GuardClauses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Payment: " + GetPaymentAmount(false, false, false));
        }
        static double GetPaymentAmount(bool isDead, bool isSeparated, bool isRetired)
        {
            if (isDead) return 100;
            if (isSeparated) return 200;
            if (isRetired) return 300;

            return 400; // Logic chính
        }
    }
}