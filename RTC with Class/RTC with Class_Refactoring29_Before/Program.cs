using System;

namespace Problem_ReplaceTypeCodeWithClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(Person.A);
            Console.WriteLine("Blood Type Code: " + person.BloodType);
        }
    }
    class Person
    {
        public const int O = 0;
        public const int A = 1;
        public const int B = 2;
        public const int AB = 3;
        public int BloodType { get; private set; }
        public Person(int bloodType) { BloodType = bloodType; }
    }
}