using System;

namespace Solution_DuplicateFragments
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateAndSend(100, true);
            CalculateAndSend(100, false);
        }

        static void CalculateAndSend(double price, bool isSpecialDeal)
        {
            double total;
            if (isSpecialDeal)
            {
                total = price * 0.95;
            }
            else
            {
                total = price * 0.98;
            }
            SendEmail(total);
        }

        static void SendEmail(double amount)
        {
            Console.WriteLine("Sending email for: " + amount.ToString("C"));
        }
    }
}