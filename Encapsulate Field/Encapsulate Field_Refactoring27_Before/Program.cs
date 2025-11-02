using System;

namespace Problem_EncapsulateField
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Nguyễn Văn A";
            Console.WriteLine("Name: " + person.Name);
        }
    }

    class Person
    {
        public string Name;
    }
}