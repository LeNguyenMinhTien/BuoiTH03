using System;
using System.Collections.Generic;

namespace Solution_ChangeValueToReference
{
    class Program
    {
        static void Main(string[] args)
        {
            var order1 = new Order(Customer.Create("Nguyễn Văn A"));
            var order2 = new Order(Customer.Create("Nguyễn Văn A"));

            bool areSameObject = order1.GetCustomer() == order2.GetCustomer();
            Console.WriteLine("Customer objects are the same: " + areSameObject);
        }
    }

    class Order
    {
        private Customer _customer;
        public Order(Customer customer) { _customer = customer; }
        public Customer GetCustomer() { return _customer; }
    }

    class Customer
    {
        private static Dictionary<string, Customer> _instances = new Dictionary<string, Customer>();
        public string Name { get; private set; }
        private Customer(string name) { Name = name; }

        public static Customer Create(string name)
        {
            if (!_instances.ContainsKey(name))
            {
                _instances[name] = new Customer(name);
            }
            return _instances[name];
        }
    }
}