using System;

namespace Solution_ExtractMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("A");
            // Cách gọi không thay đổi, hoạt động bên ngoài vẫn như cũ.
            person.PrintOwing(150000.75);

            Console.ReadKey();
        }
    }

    class Person
    {
        private string _name;

        public Person(string name)
        {
            _name = name;
        }

        // Phương thức chính giờ đây ngắn gọn và dễ đọc hơn.
        public void PrintOwing(double amount)
        {
            PrintBanner();
            // Gọi đến phương thức mới đã được trích xuất.
            PrintDetails(amount);
        }

        // --- PHƯƠNG THỨC MỚI ĐƯỢC TRÍCH XUẤT ---
        // Chịu trách nhiệm duy nhất là in chi tiết.
        private void PrintDetails(double amount)
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Amount: " + amount.ToString("C"));
        }

        // Logic in banner cũng có thể tách ra để rõ ràng hơn.
        private void PrintBanner()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("***** Customer Owes *****");
            Console.WriteLine("*************************");
        }
    }
}