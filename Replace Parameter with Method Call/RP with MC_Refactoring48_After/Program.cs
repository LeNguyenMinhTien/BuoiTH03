using System;

namespace Solution_ReplaceParameterWithMethodCall
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order(10, 20);

            // Client không cần gọi GetBasePrice() nữa
            double finalPrice = CalculateDiscountedPrice(order, 0.1);

            Console.WriteLine("Final Price: " + finalPrice.ToString("C"));
        }

        static double CalculateDiscountedPrice(Order order, double discount)
        {
            double basePrice = order.GetBasePrice();
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