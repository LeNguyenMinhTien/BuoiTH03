using System;

namespace Problem_IntroduceNullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var siteWithCustomer = new Site(new Customer("Nguyễn Văn A"));
            var siteWithoutCustomer = new Site(null);

            string name1 = (siteWithCustomer.Customer == null) ? "occupant" : siteWithCustomer.Customer.Name;
            string name2 = (siteWithoutCustomer.Customer == null) ? "occupant" : siteWithoutCustomer.Customer.Name;

            Console.WriteLine("Name 1: " + name1);
            Console.WriteLine("Name 2: " + name2);
        }
    }

    class Site { public Customer Customer { get; private set; } public Site(Customer customer) { Customer = customer; } }
    class Customer { public string Name { get; private set; } public Customer(string name) { Name = name; } }
}