using System;

namespace Solution_ConditionalWithPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new African(2);
            Console.WriteLine("Bird Speed: " + bird.GetSpeed());
        }
    }

    abstract class Bird
    {
        public abstract double GetSpeed();
    }

    class European : Bird
    {
        public override double GetSpeed() { return 10; }
    }
    class African : Bird
    {
        private int _numberOfCoconuts;
        public African(int coconuts) { _numberOfCoconuts = coconuts; }
        public override double GetSpeed() { return 10 - 2 * _numberOfCoconuts; }
    }
    class NorwegianBlue : Bird
    {
        public override double GetSpeed() { return 0; }
    }
}