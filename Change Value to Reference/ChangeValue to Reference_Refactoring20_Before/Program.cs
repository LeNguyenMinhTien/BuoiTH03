using System;

namespace Problem_ChangeValueToReference
{
    class Program
    {
        static void Main(string[] args)
        {
            var order1 = new Order(new Customer("Nguyễn Văn A"));
            var order2 = new Order(new Customer("Nguyễn Văn A"));

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
        public string Name { get; private set; }
        public Customer(string name) { Name = name; }
    }
}