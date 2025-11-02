using System;

namespace Problem_AddParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Nguyễn Văn A");
            Console.WriteLine(person.GetGreeting());
        }
    }

    class Person
    {
        private string _name;
        public Person(string name) { _name = name; }
        public string GetGreeting()
        {
            return "Xin chào, " + _name;
        }
    }
}