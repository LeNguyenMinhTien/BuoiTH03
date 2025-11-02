using System;

namespace Solution_EncapsulateField
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
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}