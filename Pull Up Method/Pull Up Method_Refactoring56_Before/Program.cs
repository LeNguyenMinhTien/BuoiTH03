using System;

namespace Problem_PullUpMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Toyota");
            var truck = new Truck("Hyundai");
            car.DisplayBrand();
            truck.DisplayBrand();
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
        public void DisplayBrand() { Console.WriteLine("Brand: " + _brand); }
    }

    class Truck : Vehicle
    {
        public Truck(string brand) : base(brand) { }
        public void DisplayBrand() { Console.WriteLine("Brand: " + _brand); }
    }
}