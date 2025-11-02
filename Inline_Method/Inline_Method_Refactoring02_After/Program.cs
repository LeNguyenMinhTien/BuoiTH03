using System;

namespace Solution_InlineMethod
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
            return _numberOfLateDeliveries > 5 ? 2 : 1;
        }
    }
}