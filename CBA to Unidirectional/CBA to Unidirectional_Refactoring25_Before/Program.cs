using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_Bidirectional
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer("Nguyễn Văn A");
            var order = new Order();
            customer.AddOrder(order);
            Console.WriteLine("Customer has " + customer.GetOrders().Count() + " orders.");
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