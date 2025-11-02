using System;

namespace Solution_ReplaceMethodWithMethodObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            Console.WriteLine("Total Price: " + order.CalculatePrice().ToString("C"));
        }
    }

    class Order
    {
        public double PrimaryValue { get { return 100; } }
        public double SecondaryValue { get { return 20; } }
        public int Level { get { return 3; } }

        public double CalculatePrice()
        {
            return new PriceCalculator(this).Compute();
        }
    }

    class PriceCalculator
    {
        private double _primaryBasePrice;
        private double _secondaryBasePrice;
        private double _tertiaryBasePrice;
        private Order _order;

        public PriceCalculator(Order order)
        {
            _order = order;
        }

        public double Compute()
        {
            _primaryBasePrice = _order.PrimaryValue * 0.8;
            _secondaryBasePrice = _order.SecondaryValue * 0.7;
            if (_order.Level > 2)
            {
                _tertiaryBasePrice = _primaryBasePrice * 0.5;
            }
            else
            {
                _tertiaryBasePrice = _secondaryBasePrice * 0.9;
            }

            return _primaryBasePrice + _secondaryBasePrice + _tertiaryBasePrice;
        }
    }
}