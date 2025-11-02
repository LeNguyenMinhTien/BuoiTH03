using System;

namespace Problem_ReplaceParameterWithMethodCall
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order(10, 20);

            // Client phải gọi GetBasePrice() trước
            double basePrice = order.GetBasePrice();
            double finalPrice = CalculateDiscountedPrice(basePrice, 0.1);

            Console.WriteLine("Final Price: " + finalPrice.ToString("C"));
        }

        static double CalculateDiscountedPrice(double basePrice, double discount)
        {
            return basePrice * (1 - discount);
        }
    }
    class Order
    {
        private double _quantity, _itemPrice;
        public Order(double q, double p) { _quantity = q; _itemPrice = p; }
        public double GetBasePrice() { return _quantity * _itemPrice; }
    }
}