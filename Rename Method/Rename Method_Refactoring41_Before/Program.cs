using System;

namespace Problem_RenameMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer("Nguyễn Văn A", "0901234567");
            Console.WriteLine(customer.GetInv());
        }
    }

    class Customer
    {
        private string _name;
        private string _phone;
        public Customer(string name, string phone) { _name = name; _phone = phone; }
        public string GetInv()
        {
            return "Name: " + _name + ", Phone: " + _phone;
        }
    }
}