using System;

namespace Solution_Unidirectional
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer("Nguyễn Văn A");
            var order = new Order(customer);

            Console.WriteLine("Order's Customer: " + order.GetCustomer().Name);
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