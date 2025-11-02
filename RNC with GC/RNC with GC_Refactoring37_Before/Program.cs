using System;

namespace Problem_NestedConditional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Payment: " + GetPaymentAmount(false, false, false));
        }
        static double GetPaymentAmount(bool isDead, bool isSeparated, bool isRetired)
        {
            double result;
            if (isDead)
            {
                result = 100;
            }
            else
            {
                if (isSeparated)
                {
                    result = 200;
                }
                else
                {
                    if (isRetired)
                    {
                        result = 300;
                    }
                    else
                    {
                        result = 400; // Logic chính
                    }
                }
            }
            return result;
        }
    }
}