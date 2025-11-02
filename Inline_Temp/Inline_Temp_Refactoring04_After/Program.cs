using System;

namespace Solution_InlineTemp
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
            return _quantity * _itemPrice > 1000;
        }
    }
}