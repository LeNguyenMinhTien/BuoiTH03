using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution_Bidirectional
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer("Nguyễn Văn A");
            var order1 = new Order();
            var order2 = new Order();

            customer.AddOrder(order1);
            customer.AddOrder(order2);

            Console.WriteLine("Order 1's Customer: " + order1.GetCustomer().Name);
            Console.WriteLine("Customer's order count: " + customer.GetOrders().Count());
        }
    }

    class Customer
    {
        public string Name { get; private set; }
        private List<Order> _orders = new List<Order>();
        public Customer(string name) { Name = name; }
        public IEnumerable<Order> GetOrders() { return _orders; }
        public void AddOrder(Order order) { _orders.Add(order); order.SetCustomer(this); }
    }

    class Order
    {
        private Customer _customer;
        public Customer GetCustomer() { return _customer; }
        public void SetCustomer(Customer customer) { _customer = customer; }
    }
}