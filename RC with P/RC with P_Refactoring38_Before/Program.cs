using System;

namespace Problem_ConditionalWithPolymorphism
{
    enum BirdType { European, African, NorwegianBlue }
    class Program
    {
        static void Main(string[] args)
        {
            var bird = new Bird(BirdType.African, 2);
            Console.WriteLine("Bird Speed: " + bird.GetSpeed());
        }
    }

    class Bird
    {
        public BirdType Type { get; private set; }
        public int NumberOfCoconuts { get; private set; }
        public Bird(BirdType type, int coconuts) { Type = type; NumberOfCoconuts = coconuts; }
        public double GetSpeed()
        {
            switch (Type)
            {
                case BirdType.European: return 10;
                case BirdType.African: return 10 - 2 * NumberOfCoconuts;
                case BirdType.NorwegianBlue: return 0;
            }
            return 0;
        }
    }
}