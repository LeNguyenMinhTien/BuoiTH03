using System;

namespace Problem_InlineMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Delivery delivery = new Delivery(10);
            Console.WriteLine("Driver rating: " + delivery.GetRating());
        }
    }

    class Delivery
    {
        private int _numberOfLateDeliveries;

        public Delivery(int numberOfLateDeliveries)
        {
            _numberOfLateDeliveries = numberOfLateDeliveries;
        }

        public int GetRating()
        {
            return IsLate() ? 2 : 1;
        }

        private bool IsLate()
        {
            return _numberOfLateDeliveries > 5;
        }
    }
}