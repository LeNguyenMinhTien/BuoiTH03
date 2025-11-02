using System;

namespace Solution_ReplaceSubclassWithFields
{
    class Program
    {
        static void Main(string[] args)
        {
            var male = new Person("M");
            var female = new Person("F");
            Console.WriteLine("Male code: " + male.GetCode());
            Console.WriteLine("Female code: " + female.GetCode());
        }
    }

    class Person
    {
        private string _code;
        public Person(string code) { _code = code; }
        public string GetCode() { return _code; }
    }
}