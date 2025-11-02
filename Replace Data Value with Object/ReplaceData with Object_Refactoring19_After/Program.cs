using System;
using System.Collections.Generic;

namespace Solution_ReplaceDataValueWithObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerA = new Customer("Nguyễn Văn A");
            var customerB = new Customer("Bình");

            var orders = new List<Order>();
            orders.Add(new Order(customerA));
            orders.Add(new Order(customerB));
            orders.Add(new Order(customerA));

            int count = CountOrdersForCustomer(orders, customerA);
            Console.WriteLine("Orders for Nguyễn Văn A: " + count);
        }

        public static int CountOrdersForCustomer(List<Order> orders, Customer customer)
        {
            int result = 0;
            foreach (var order in orders)
            {
                if (order.GetCustomer().Equals(customer))
                {
                    result++;
                }
            }
            return result;
        }
    }

    class Customer
    {
        public string Name { get; private set; }
        public Customer(string name) { Name = name; }
    }

    class Order
    {
        private Customer _customer;
        public Order(Customer customer) { _customer = customer; }
        public Customer GetCustomer() { return _customer; }
    }
}