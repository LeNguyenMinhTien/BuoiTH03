using System;

namespace Problem_NoRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Nguyễn Văn A");
            // Gọi một phương thức duy nhất chứa tất cả logic
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

        // Phương thức này làm quá nhiều việc.
        public void PrintOwing(double amount)
        {
            // Việc 1: In tiêu đề
            Console.WriteLine("*************************");
            Console.WriteLine("***** Customer Owes *****");
            Console.WriteLine("*************************");

            // Việc 2: In chi tiết.
            // Nếu phần này phức tạp hơn, phương thức sẽ rất dài.
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Amount: " + amount.ToString("C"));
        }
    }
}