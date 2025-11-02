using System;

namespace Solution_ReplaceTypeCodeWithClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(BloodType.A);
            Console.WriteLine("Blood Type: " + person.BloodType.Name);
        }
    }

    class BloodType
    {
        public static readonly BloodType O = new BloodType("O");
        public static readonly BloodType A = new BloodType("A");
        public static readonly BloodType B = new BloodType("B");
        public static readonly BloodType AB = new BloodType("AB");
        public string Name { get; private set; }
        private BloodType(string name) { Name = name; }
    }

    class Person
    {
        public BloodType BloodType { get; private set; }
        public Person(BloodType bloodType) { BloodType = bloodType; }
    }
}