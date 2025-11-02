using System;

namespace Solution_ReplaceTempWithQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order(10, 150);
            Console.WriteLine("Total: " + order.CalculateTotal().ToString("C"));
        }
    }

    class Order
    {
        private double _quantity;
        private double _itemPrice;

        public Order(double quantity, double itemPrice)
        {
            _quantity = quantity;
            _itemPrice = itemPrice;
        }

        private double GetBasePrice()
        {
            return _quantity * _itemPrice;
        }

        public double CalculateTotal()
        {
            double discountFactor;
            if (GetBasePrice() > 1000)
            {
                discountFactor = 0.95;
            }
            else
            {
                discountFactor = 0.98;
            }
            return GetBasePrice() * discountFactor;
        }
    }
}