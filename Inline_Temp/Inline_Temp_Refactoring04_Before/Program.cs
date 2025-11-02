using System;

namespace Problem_InlineTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order(100, 15);
            Console.WriteLine("Has discount: " + order.HasDiscount());
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

        public bool HasDiscount()
        {
            double basePrice = _quantity * _itemPrice;
            return basePrice > 1000;
        }
    }
}