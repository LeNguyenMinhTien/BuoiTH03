using System;

namespace Problem_PullUpField
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Toyota");
            var truck = new Truck("Hyundai");
        }
    }

    class Vehicle { }

    class Car : Vehicle
    {
        private string _brand;
        public Car(string brand) { _brand = brand; }
    }

    class Truck : Vehicle
    {
        private string _brand;
        public Truck(string brand) { _brand = brand; }
    }
}