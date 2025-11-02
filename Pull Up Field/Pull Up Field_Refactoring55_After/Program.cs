using System;

namespace Solution_PullUpField
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Toyota");
            var truck = new Truck("Hyundai");
        }
    }

    class Vehicle
    {
        protected string _brand;
        public Vehicle(string brand) { _brand = brand; }
    }

    class Car : Vehicle
    {
        public Car(string brand) : base(brand) { }
    }

    class Truck : Vehicle
    {
        public Truck(string brand) : base(brand) { }
    }
}