using System;

namespace Solution_RemoveParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Văn", "Nguyễn");
            Console.WriteLine(person.GetFullName());
        }
    }

    class Person
    {
        private string _firstName;
        private string _lastName;

        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public string GetFullName()
        {
            return _lastName + " " + _firstName;
        }
    }
}