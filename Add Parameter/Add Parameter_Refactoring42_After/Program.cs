using System;

namespace Solution_AddParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Nguyễn Văn A");
            Console.WriteLine(person.GetGreeting("Buổi sáng"));
        }
    }

    class Person
    {
        private string _name;
        public Person(string name) { _name = name; }
        public string GetGreeting(string greetingTime)
        {
            return "Chào " + greetingTime + ", " + _name;
        }
    }
}