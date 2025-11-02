using System;
using System.Collections.Generic;

namespace Problem_ReplaceDataValueWithObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var orders = new List<Order>();
            orders.Add(new Order("Nguyễn Văn A"));
            orders.Add(new Order("Bình"));
            orders.Add(new Order("Nguyễn Văn A"));

            int count = CountOrdersForCustomer(orders, "Nguyễn Văn A");
            Console.WriteLine("Orders for Nguyễn Văn A: " + count);
        }

        public static int CountOrdersForCustomer(List<Order> orders, string customerName)
        {
            int result = 0;
            foreach (var order in orders)
            {
                if (order.GetCustomerName().Equals(customerName))
                {
                    result++;
                }
            }
            return result;
        }
    }

    class Order
    {
        private string _customerName;
        public Order(string customerName) { _customerName = customerName; }
        public string GetCustomerName() { return _customerName; }
    }
}